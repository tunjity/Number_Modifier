using Microsoft.Extensions.Logging;
using Number_Modifier.FormModel;
using Number_Modifier.Model;
using Number_Modifier.Util;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Number_Modifier.Repository
{
    public interface IMSISDNRepository
    {
        public Task<ApiResponse> UpdateNumber(string OldNumber, string NewNumber);
    }
    public class MSISDNRepository : IMSISDNRepository
    {
        private readonly intllgr_dbms2Context _context;
        private readonly IConfiguration _config;
        public MSISDNRepository(IConfiguration config, intllgr_dbms2Context context)
        {
            _config = config;
            _context = context;
        }


        public async Task<ApiResponse> UpdateNumber(string OldNumber, string NewNumber)
        {
            var response = new ApiResponse();
            try
            {
                var checkForNewnumber = _context.PreCustomers.FirstOrDefault(x => x.Msisdn.ToLower() == NewNumber);
                if (checkForNewnumber != null)
                {
                    _context.PreCustomers.Remove(checkForNewnumber);
                }
                var checkForOldNumber = _context.PreCustomers.FirstOrDefault(x => x.Msisdn == OldNumber);
                if (checkForOldNumber != null)
                {
                    checkForOldNumber.Msisdn = NewNumber;
                    _context.PreCustomers.Update(checkForOldNumber);
                    if (checkForOldNumber.OnboardingStatus.ToLower() == "customer-profiled")
                    {
                        var resp = _context.Customers.FirstOrDefault(o => o.Msisdn == OldNumber);
                        if (resp != null)
                        {
                            resp.Msisdn = NewNumber;
                            _context.Customers.Update(resp);

                        }
                    }
                    KycInfo kycInfo = new KycInfo()
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        PreCustomerId = checkForOldNumber.Id,
                        Type = "MSISDN Update",
                        InputName = $"Old Number || {OldNumber}",
                        InputValue = $"New Number || {NewNumber}",
                        InputType = "MSISDN Update",
                    };
                    _context.KycInfos.Add(kycInfo);
                    await _context.SaveChangesAsync();
                    response.code = "200";
                    response.message = "MSISDN Updated Successfully";
                }
                else
                {
                    response.code = "200";
                    response.message = "MSISDN Owner Not In Pre-Customer";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.status = "false";

                Logger.SendErrorToText(ex);
                return response;
            }
        }
    }
}
