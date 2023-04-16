
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Number_Modifier.Repository;
using Number_Modifier.FormModel;

namespace Number_Modifier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSISDNController : ControllerBase
    {
        private readonly IMSISDNRepository _repo;

        public MSISDNController(IMSISDNRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<IActionResult> IsAgentValid([FromQuery] string oldNumber,string newNumber)
        {
            var resp = await _repo.UpdateNumber(oldNumber, newNumber);
            return Ok(resp);
        }
    }
}
