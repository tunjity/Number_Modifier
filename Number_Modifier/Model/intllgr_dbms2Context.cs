using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Number_Modifier.Model
{
    public partial class intllgr_dbms2Context : DbContext
    {
        public intllgr_dbms2Context()
        {
        }

        public intllgr_dbms2Context(DbContextOptions<intllgr_dbms2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLog> ActivityLogs { get; set; } = null!;
        public virtual DbSet<ActivityLogs01> ActivityLogs01s { get; set; } = null!;
        public virtual DbSet<ActivityLogs02> ActivityLogs02s { get; set; } = null!;
        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<ApiClient> ApiClients { get; set; } = null!;
        public virtual DbSet<Apirolepermission> Apirolepermissions { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Bankref> Bankrefs { get; set; } = null!;
        public virtual DbSet<Bankstatement> Bankstatements { get; set; } = null!;
        public virtual DbSet<Bundlenotificationlog> Bundlenotificationlogs { get; set; } = null!;
        public virtual DbSet<Bvndetail> Bvndetails { get; set; } = null!;
        public virtual DbSet<Bvndetail1> Bvndetails1 { get; set; } = null!;
        public virtual DbSet<CdlLog> CdlLogs { get; set; } = null!;
        public virtual DbSet<ClientDevice> ClientDevices { get; set; } = null!;
        public virtual DbSet<Clientinterface> Clientinterfaces { get; set; } = null!;
        public virtual DbSet<Cluster> Clusters { get; set; } = null!;
        public virtual DbSet<CmsPost> CmsPosts { get; set; } = null!;
        public virtual DbSet<CmsPostMeta> CmsPostMetas { get; set; } = null!;
        public virtual DbSet<CommChannel> CommChannels { get; set; } = null!;
        public virtual DbSet<CommChannelsUser> CommChannelsUsers { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerActivityLog> CustomerActivityLogs { get; set; } = null!;
        public virtual DbSet<CustomerInfo> CustomerInfos { get; set; } = null!;
        public virtual DbSet<CustomerLoanRepayScheduleBkp19062022> CustomerLoanRepayScheduleBkp19062022s { get; set; } = null!;
        public virtual DbSet<CustomerLockedview> CustomerLockedviews { get; set; } = null!;
        public virtual DbSet<CustomerToc> CustomerTocs { get; set; } = null!;
        public virtual DbSet<Customerchangelog> Customerchangelogs { get; set; } = null!;
        public virtual DbSet<Customerrenewalsmtn> Customerrenewalsmtns { get; set; } = null!;
        public virtual DbSet<Customerrenewalsmtnjan> Customerrenewalsmtnjans { get; set; } = null!;
        public virtual DbSet<CustomersAutoRenewal> CustomersAutoRenewals { get; set; } = null!;
        public virtual DbSet<DataDump> DataDumps { get; set; } = null!;
        public virtual DbSet<DataDumps200123> DataDumps200123s { get; set; } = null!;
        public virtual DbSet<Datalog> Datalogs { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<DeviceCategory> DeviceCategories { get; set; } = null!;
        public virtual DbSet<DeviceOption> DeviceOptions { get; set; } = null!;
        public virtual DbSet<DeviceSubRenewal> DeviceSubRenewals { get; set; } = null!;
        public virtual DbSet<DeviceType> DeviceTypes { get; set; } = null!;
        public virtual DbSet<Devicemanualextentionhistory> Devicemanualextentionhistories { get; set; } = null!;
        public virtual DbSet<Deviceworkflow> Deviceworkflows { get; set; } = null!;
        public virtual DbSet<Deviceworkflowstephistory> Deviceworkflowstephistories { get; set; } = null!;
        public virtual DbSet<Distributor> Distributors { get; set; } = null!;
        public virtual DbSet<Duplicatecheck> Duplicatechecks { get; set; } = null!;
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; } = null!;
        public virtual DbSet<Endofdaysale> Endofdaysales { get; set; } = null!;
        public virtual DbSet<EnterpriseBundle> EnterpriseBundles { get; set; } = null!;
        public virtual DbSet<EnterpriseBundleClassification> EnterpriseBundleClassifications { get; set; } = null!;
        public virtual DbSet<EnterpriseBundlePlan> EnterpriseBundlePlans { get; set; } = null!;
        public virtual DbSet<EnterpriseCompany> EnterpriseCompanies { get; set; } = null!;
        public virtual DbSet<EnterpriseCustomer> EnterpriseCustomers { get; set; } = null!;
        public virtual DbSet<EnterprisePlan> EnterprisePlans { get; set; } = null!;
        public virtual DbSet<Entitynote> Entitynotes { get; set; } = null!;
        public virtual DbSet<Entitynoteflag> Entitynoteflags { get; set; } = null!;
        public virtual DbSet<Entitynotetype> Entitynotetypes { get; set; } = null!;
        public virtual DbSet<FinanceMovement> FinanceMovements { get; set; } = null!;
        public virtual DbSet<Financieramortizationschedule> Financieramortizationschedules { get; set; } = null!;
        public virtual DbSet<Finservicetxnlog> Finservicetxnlogs { get; set; } = null!;
        public virtual DbSet<Inventory> Inventories { get; set; } = null!;
        public virtual DbSet<KycBk0507> KycBk0507s { get; set; } = null!;
        public virtual DbSet<KycInfo> KycInfos { get; set; } = null!;
        public virtual DbSet<KycInfoBkp> KycInfoBkps { get; set; } = null!;
        public virtual DbSet<KycInfoBkp1> KycInfoBkp1s { get; set; } = null!;
        public virtual DbSet<KycInfos1024> KycInfos1024s { get; set; } = null!;
        public virtual DbSet<KycInfos130123> KycInfos130123s { get; set; } = null!;
        public virtual DbSet<KycInfos2> KycInfos2s { get; set; } = null!;
        public virtual DbSet<KycInfosBck> KycInfosBcks { get; set; } = null!;
        public virtual DbSet<Ledger> Ledgers { get; set; } = null!;
        public virtual DbSet<Ledgertransaction> Ledgertransactions { get; set; } = null!;
        public virtual DbSet<LedgertransactionBkp> LedgertransactionBkps { get; set; } = null!;
        public virtual DbSet<LedgertransactionBkp1> LedgertransactionBkp1s { get; set; } = null!;
        public virtual DbSet<Ledgertransactiondetail> Ledgertransactiondetails { get; set; } = null!;
        public virtual DbSet<LedgertransactiondetailsBkp1> LedgertransactiondetailsBkp1s { get; set; } = null!;
        public virtual DbSet<Lender> Lenders { get; set; } = null!;
        public virtual DbSet<LenderCreditLimit> LenderCreditLimits { get; set; } = null!;
        public virtual DbSet<Lga> Lgas { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<LoanAllocation> LoanAllocations { get; set; } = null!;
        public virtual DbSet<LoanAllocationsDevices0> LoanAllocationsDevices0s { get; set; } = null!;
        public virtual DbSet<LoanRepayHistory> LoanRepayHistories { get; set; } = null!;
        public virtual DbSet<LoanRepaySchedule> LoanRepaySchedules { get; set; } = null!;
        public virtual DbSet<Loanallocationbk20230110> Loanallocationbk20230110s { get; set; } = null!;
        public virtual DbSet<Loanallocationsbkup1> Loanallocationsbkup1s { get; set; } = null!;
        public virtual DbSet<Loanrepayschedulesbkup1> Loanrepayschedulesbkup1s { get; set; } = null!;
        public virtual DbSet<Loanschedulebk20230110> Loanschedulebk20230110s { get; set; } = null!;
        public virtual DbSet<LrhBk> LrhBks { get; set; } = null!;
        public virtual DbSet<Lrpmtnexceptionmarch2023> Lrpmtnexceptionmarch2023s { get; set; } = null!;
        public virtual DbSet<MailQueue> MailQueues { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MtnRenewReport> MtnRenewReports { get; set; } = null!;
        public virtual DbSet<Mtnactivesubscription20230305> Mtnactivesubscription20230305s { get; set; } = null!;
        public virtual DbSet<Mtndump> Mtndumps { get; set; } = null!;
        public virtual DbSet<Paelytcustomerlog> Paelytcustomerlogs { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<Partnerstype> Partnerstypes { get; set; } = null!;
        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; } = null!;
        public virtual DbSet<Paymentchannel> Paymentchannels { get; set; } = null!;
        public virtual DbSet<Paymentchannelparameter> Paymentchannelparameters { get; set; } = null!;
        public virtual DbSet<Paymentinitiationlog> Paymentinitiationlogs { get; set; } = null!;
        public virtual DbSet<Paystackrecipient> Paystackrecipients { get; set; } = null!;
        public virtual DbSet<Paystacktransferlog> Paystacktransferlogs { get; set; } = null!;
        public virtual DbSet<PenaltyPayment> PenaltyPayments { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<PreCustomer> PreCustomers { get; set; } = null!;
        public virtual DbSet<PreCustomersBck> PreCustomersBcks { get; set; } = null!;
        public virtual DbSet<PreCustomersBkp> PreCustomersBkps { get; set; } = null!;
        public virtual DbSet<PreCustomersBkp1> PreCustomersBkp1s { get; set; } = null!;
        public virtual DbSet<PreCustomersBkp11> PreCustomersBkp1s1 { get; set; } = null!;
        public virtual DbSet<PreCustomersBkp2> PreCustomersBkp2s { get; set; } = null!;
        public virtual DbSet<PreCustomersBkp3> PreCustomersBkp3s { get; set; } = null!;
        public virtual DbSet<PreCustomersBvnissue> PreCustomersBvnissues { get; set; } = null!;
        public virtual DbSet<Precustnobvn> Precustnobvns { get; set; } = null!;
        public virtual DbSet<PriceList> PriceLists { get; set; } = null!;
        public virtual DbSet<Ptmfbtransactionslog> Ptmfbtransactionslogs { get; set; } = null!;
        public virtual DbSet<Rechargelist> Rechargelists { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<RegionSupervisorMapping> RegionSupervisorMappings { get; set; } = null!;
        public virtual DbSet<RepReview> RepReviews { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Reportcategory> Reportcategories { get; set; } = null!;
        public virtual DbSet<Reporter> Reporters { get; set; } = null!;
        public virtual DbSet<ReportingLog> ReportingLogs { get; set; } = null!;
        public virtual DbSet<Reportparameter> Reportparameters { get; set; } = null!;
        public virtual DbSet<Reportpermission> Reportpermissions { get; set; } = null!;
        public virtual DbSet<Reporttype> Reporttypes { get; set; } = null!;
        public virtual DbSet<RetailStore> RetailStores { get; set; } = null!;
        public virtual DbSet<RetailStoreUser> RetailStoreUsers { get; set; } = null!;
        public virtual DbSet<RoleAcl> RoleAcls { get; set; } = null!;
        public virtual DbSet<Rolepermission> Rolepermissions { get; set; } = null!;
        public virtual DbSet<Rpfsrfilter> Rpfsrfilters { get; set; } = null!;
        public virtual DbSet<SaleLog> SaleLogs { get; set; } = null!;
        public virtual DbSet<Scheduledreport> Scheduledreports { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Settlementlog> Settlementlogs { get; set; } = null!;
        public virtual DbSet<Settlementlogitem> Settlementlogitems { get; set; } = null!;
        public virtual DbSet<SimRegister> SimRegisters { get; set; } = null!;
        public virtual DbSet<Staffrechargelist> Staffrechargelists { get; set; } = null!;
        public virtual DbSet<Stanbicloanlog> Stanbicloanlogs { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Statelog> Statelogs { get; set; } = null!;
        public virtual DbSet<Subledgertransaction> Subledgertransactions { get; set; } = null!;
        public virtual DbSet<Subloan> Subloans { get; set; } = null!;
        public virtual DbSet<Subregion> Subregions { get; set; } = null!;
        public virtual DbSet<Telco> Telcos { get; set; } = null!;
        public virtual DbSet<TelcoBundle> TelcoBundles { get; set; } = null!;
        public virtual DbSet<Telcoreport> Telcoreports { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Toc> Tocs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserLockedview> UserLockedviews { get; set; } = null!;
        public virtual DbSet<UserMessage> UserMessages { get; set; } = null!;
        public virtual DbSet<UserPost> UserPosts { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserRoleMap> UserRoleMaps { get; set; } = null!;
        public virtual DbSet<Userinfo> Userinfos { get; set; } = null!;
        public virtual DbSet<Utility> Utilities { get; set; } = null!;
        public virtual DbSet<ValueInfo> ValueInfos { get; set; } = null!;
        public virtual DbSet<VtuPlan> VtuPlans { get; set; } = null!;
        public virtual DbSet<VtuRenewalHistory> VtuRenewalHistories { get; set; } = null!;
        public virtual DbSet<VtuSchedule> VtuSchedules { get; set; } = null!;
        public virtual DbSet<Vwbvndetail> Vwbvndetails { get; set; } = null!;
        public virtual DbSet<Vwcustomerrenewalsmtn> Vwcustomerrenewalsmtns { get; set; } = null!;
        public virtual DbSet<Vwcustomerrenewalsmtnjan> Vwcustomerrenewalsmtnjans { get; set; } = null!;
        public virtual DbSet<Vwmtnactivesubscription20230305> Vwmtnactivesubscription20230305s { get; set; } = null!;
        public virtual DbSet<Vwrepaymenthistorydetail> Vwrepaymenthistorydetails { get; set; } = null!;
        public virtual DbSet<Vwrolepermission> Vwrolepermissions { get; set; } = null!;
        public virtual DbSet<Workflowapprovalgroup> Workflowapprovalgroups { get; set; } = null!;
        public virtual DbSet<Workflowapprovalusergroup> Workflowapprovalusergroups { get; set; } = null!;
        public virtual DbSet<Workflowdefinition> Workflowdefinitions { get; set; } = null!;
        public virtual DbSet<Workflowstepdefinition> Workflowstepdefinitions { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySQL("server=51.81.163.57;port=3306;database=intllgr_dbms2;user=root;password=2!npS2jw59#c; Persist Security Info=False;SSL Mode=None; Connect Timeout=300; default command timeout=120;SslMode=none;convert zero datetime=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("activity_logs");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.ApiClientId)
                    .HasColumnType("int(10)")
                    .HasColumnName("api_client_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_ref");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DeviceRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_ref");

                entity.Property(e => e.DumpRef)
                    .HasColumnType("int(11)")
                    .HasColumnName("dump_ref");

                entity.Property(e => e.EntryNumber)
                    .HasColumnType("int(10)")
                    .HasColumnName("entry_number");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LenderRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("lender_ref");

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.NewData)
                    .HasColumnType("text")
                    .HasColumnName("new_data");

                entity.Property(e => e.OldData)
                    .HasColumnType("text")
                    .HasColumnName("old_data");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .HasColumnName("sector");

                entity.Property(e => e.TelcoRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_ref");

                entity.Property(e => e.UserBrowser)
                    .HasColumnType("text")
                    .HasColumnName("user_browser");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ActivityLogs01>(entity =>
            {
                entity.ToTable("activity_logs_01");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.ApiClientId)
                    .HasColumnType("int(10)")
                    .HasColumnName("api_client_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_ref");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DeviceRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_ref");

                entity.Property(e => e.DumpRef)
                    .HasColumnType("int(11)")
                    .HasColumnName("dump_ref");

                entity.Property(e => e.EntryNumber)
                    .HasColumnType("int(10)")
                    .HasColumnName("entry_number");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LenderRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("lender_ref");

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.NewData)
                    .HasColumnType("text")
                    .HasColumnName("new_data");

                entity.Property(e => e.OldData)
                    .HasColumnType("text")
                    .HasColumnName("old_data");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .HasColumnName("sector");

                entity.Property(e => e.TelcoRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_ref");

                entity.Property(e => e.UserBrowser)
                    .HasColumnType("text")
                    .HasColumnName("user_browser");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ActivityLogs02>(entity =>
            {
                entity.ToTable("activity_logs_02");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.ApiClientId)
                    .HasColumnType("int(10)")
                    .HasColumnName("api_client_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_ref");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DeviceRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_ref");

                entity.Property(e => e.DumpRef)
                    .HasColumnType("int(11)")
                    .HasColumnName("dump_ref");

                entity.Property(e => e.EntryNumber)
                    .HasColumnType("int(10)")
                    .HasColumnName("entry_number");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LenderRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("lender_ref");

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.NewData)
                    .HasColumnType("text")
                    .HasColumnName("new_data");

                entity.Property(e => e.OldData)
                    .HasColumnType("text")
                    .HasColumnName("old_data");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .HasColumnName("sector");

                entity.Property(e => e.TelcoRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_ref");

                entity.Property(e => e.UserBrowser)
                    .HasColumnType("text")
                    .HasColumnName("user_browser");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agents");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.FirstName).HasColumnType("text");

                entity.Property(e => e.LastName).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiClient>(entity =>
            {
                entity.ToTable("api_clients");

                entity.HasIndex(e => e.ClientUserIdentity, "client_user_identity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(255)
                    .HasColumnName("app_key");

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(255)
                    .HasColumnName("app_secret");

                entity.Property(e => e.ClientUserIdentity).HasColumnName("client_user_identity");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Hash)
                    .HasMaxLength(255)
                    .HasColumnName("hash");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RoleName).HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnType("int(1)")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Whitelist)
                    .HasColumnType("text")
                    .HasColumnName("whitelist");
            });

            modelBuilder.Entity<Apirolepermission>(entity =>
            {
                entity.ToTable("apirolepermissions");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedBy).HasColumnType("text");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndPoint).HasColumnType("text");

                entity.Property(e => e.LastDateUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy).HasColumnType("text");

                entity.Property(e => e.RoleName).HasColumnType("text");

                entity.Property(e => e.Service).HasColumnType("text");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("banks");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.SortCode).HasColumnType("text");
            });

            modelBuilder.Entity<Bankref>(entity =>
            {
                entity.ToTable("bankrefs");

                entity.HasIndex(e => e.BankId, "IX_BankRefs_BankId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BankId).HasColumnType("bigint(20)");

                entity.Property(e => e.Gateway).HasColumnType("text");

                entity.Property(e => e.GatewayCode).HasColumnType("text");

                entity.Property(e => e.GatewayLiveCode).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Bankrefs)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BankRefs_Banks_BankId");
            });

            modelBuilder.Entity<Bankstatement>(entity =>
            {
                entity.ToTable("bankstatements");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountName).HasColumnType("text");

                entity.Property(e => e.AccountNo).HasColumnType("text");

                entity.Property(e => e.BankName).HasColumnType("text");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.Narration).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("bigint(20)");

                entity.Property(e => e.TxnRefId).HasColumnType("text");
            });

            modelBuilder.Entity<Bundlenotificationlog>(entity =>
            {
                entity.ToTable("bundlenotificationlogs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Financier)
                    .HasColumnType("text")
                    .HasColumnName("financier");

                entity.Property(e => e.Msisdn)
                    .HasColumnType("text")
                    .HasColumnName("msisdn");
            });

            modelBuilder.Entity<Bvndetail>(entity =>
            {
                entity.ToTable("bvndetail");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(11)
                    .HasColumnName("bvn");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Bvndetail1>(entity =>
            {
                entity.ToTable("bvndetails");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(11)
                    .HasColumnName("bvn");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CdlLog>(entity =>
            {
                entity.ToTable("cdl_logs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");

                entity.Property(e => e.IsSignatureSent).HasColumnName("isSignatureSent");

                entity.Property(e => e.LoanId).HasColumnType("int(11)");

                entity.Property(e => e.PrecustomerId).HasColumnType("int(11)");

                entity.Property(e => e.RefNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ref_no");

                entity.Property(e => e.Signature).HasColumnType("text");

                entity.Property(e => e.UserName).HasColumnType("text");
            });

            modelBuilder.Entity<ClientDevice>(entity =>
            {
                entity.ToTable("client_devices");

                entity.HasIndex(e => e.PushToken, "unique_push")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Blocked)
                    .HasColumnType("int(1)")
                    .HasColumnName("blocked");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.LastAccess)
                    .HasColumnType("datetime")
                    .HasColumnName("last_access");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.ProfileToken)
                    .HasMaxLength(255)
                    .HasColumnName("profile_token");

                entity.Property(e => e.PushToken).HasColumnName("push_token");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(255)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<Clientinterface>(entity =>
            {
                entity.ToTable("clientinterface");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.BrandColour).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DomainUrl).HasColumnType("text");

                entity.Property(e => e.Financier).HasColumnType("int(11)");

                entity.Property(e => e.LandingImage).HasColumnType("text");

                entity.Property(e => e.LandingPhrase).HasColumnType("text");

                entity.Property(e => e.LogoUrl).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Oem)
                    .HasColumnType("int(11)")
                    .HasColumnName("OEM");

                entity.Property(e => e.Telco).HasColumnType("int(11)");

                entity.Property(e => e.Tenure).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Cluster>(entity =>
            {
                entity.ToTable("cluster");

                entity.HasIndex(e => e.SubRegionId, "IX_cluster_SubRegionId");

                entity.HasIndex(e => e.UserId, "IX_cluster_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.SubRegionId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.HasOne(d => d.SubRegion)
                    .WithMany(p => p.Clusters)
                    .HasForeignKey(d => d.SubRegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cluster_SubRegions_SubRegionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clusters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsPost>(entity =>
            {
                entity.ToTable("cms_posts");

                entity.HasIndex(e => e.Tagline, "unique_tag")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnType("int(10)")
                    .HasColumnName("author");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PostContent)
                    .HasColumnType("text")
                    .HasColumnName("post_content");

                entity.Property(e => e.PostParent)
                    .HasColumnType("int(10)")
                    .HasColumnName("post_parent");

                entity.Property(e => e.PostTitle)
                    .HasColumnType("text")
                    .HasColumnName("post_title");

                entity.Property(e => e.Publish)
                    .HasColumnType("set('0','1')")
                    .HasColumnName("publish")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tagline).HasColumnName("tagline");
            });

            modelBuilder.Entity<CmsPostMeta>(entity =>
            {
                entity.ToTable("cms_post_metas");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CmsPostId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cms_post_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Metaname)
                    .HasColumnType("text")
                    .HasColumnName("metaname");

                entity.Property(e => e.Metavalue)
                    .HasColumnType("text")
                    .HasColumnName("metavalue");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");
            });

            modelBuilder.Entity<CommChannel>(entity =>
            {
                entity.ToTable("comm_channels");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Private).HasColumnName("private");

                entity.Property(e => e.Slug)
                    .HasMaxLength(50)
                    .HasColumnName("slug");
            });

            modelBuilder.Entity<CommChannelsUser>(entity =>
            {
                entity.ToTable("comm_channels_users");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CommChannelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("comm_channel_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("currencies");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Abbr)
                    .HasMaxLength(4)
                    .HasColumnName("abbr");

                entity.Property(e => e.Markup)
                    .HasMaxLength(10)
                    .HasColumnName("markup");

                entity.Property(e => e.MarkupHexCode)
                    .HasMaxLength(10)
                    .HasColumnName("markup_hex_code");

                entity.Property(e => e.MarkupHtmlCode)
                    .HasMaxLength(10)
                    .HasColumnName("markup_html_code");

                entity.Property(e => e.MarkupHtmlEntity)
                    .HasMaxLength(10)
                    .HasColumnName("markup_html_entity");

                entity.Property(e => e.MarkupUnicode)
                    .HasMaxLength(10)
                    .HasColumnName("markup_unicode");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.Bvn, "bvn")
                    .IsUnique();

                entity.HasIndex(e => e.Created, "cus_ind_created");

                entity.HasIndex(e => e.Firstname, "cus_ind_firstname");

                entity.HasIndex(e => e.Lastname, "cus_ind_lastname");

                entity.HasIndex(e => e.PrequalifiedMsisdn, "cus_ind_pm");

                entity.HasIndex(e => e.Score, "cus_ind_score");

                entity.HasIndex(e => e.Msisdn, "msisdn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date");

                entity.Property(e => e.Avatar)
                    .HasColumnType("text")
                    .HasColumnName("avatar");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(100)
                    .HasColumnName("bvn");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrentDeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_device_id");

                entity.Property(e => e.CurrentLoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_loan_id");

                entity.Property(e => e.CurrentPlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_plan_id");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(200)
                    .HasColumnName("firstname");

                entity.Property(e => e.Imsi)
                    .HasMaxLength(100)
                    .HasColumnName("imsi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(200)
                    .HasColumnName("lastname");

                entity.Property(e => e.LoginStatus).HasColumnName("login_status");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.OnboardDate)
                    .HasColumnType("datetime")
                    .HasColumnName("onboard_date");

                entity.Property(e => e.Otp)
                    .HasMaxLength(10)
                    .HasColumnName("otp");

                entity.Property(e => e.PaelytRefno)
                    .HasMaxLength(50)
                    .HasColumnName("paelyt_refno");

                entity.Property(e => e.Pin)
                    .HasMaxLength(255)
                    .HasColumnName("pin");

                entity.Property(e => e.PrequalifiedMsisdn)
                    .HasMaxLength(20)
                    .HasColumnName("prequalified_msisdn")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrequalifiedTelcoId)
                    .HasColumnType("int(10)")
                    .HasColumnName("prequalified_telco_id");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SecurityQuestion)
                    .HasColumnType("text")
                    .HasColumnName("security_question");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.TelcoId)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_id");
            });

            modelBuilder.Entity<CustomerActivityLog>(entity =>
            {
                entity.ToTable("customer_activity_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.ApiClientId)
                    .HasColumnType("int(10)")
                    .HasColumnName("api_client_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EntryNumber)
                    .HasColumnType("int(10)")
                    .HasColumnName("entry_number");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.NewData)
                    .HasColumnType("text")
                    .HasColumnName("new_data");

                entity.Property(e => e.OldData)
                    .HasColumnType("text")
                    .HasColumnName("old_data");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .HasColumnName("sector");

                entity.Property(e => e.UserBrowser)
                    .HasColumnType("text")
                    .HasColumnName("user_browser");
            });

            modelBuilder.Entity<CustomerInfo>(entity =>
            {
                entity.ToTable("customer_infos");

                entity.HasIndex(e => new { e.CustomerId, e.KycInputName }, "unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.KycInputName).HasColumnName("kyc_input_name");

                entity.Property(e => e.KycInputValue)
                    .HasColumnType("text")
                    .HasColumnName("kyc_input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PrecustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("precustomer_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerInfos)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer");
            });

            modelBuilder.Entity<CustomerLoanRepayScheduleBkp19062022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer_loan_repay_schedule_bkp19062022");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.RepaymentMonthlyAnniversay)
                    .HasColumnType("date")
                    .HasColumnName("repayment_monthly_anniversay");

                entity.Property(e => e.ScheduleMonthlyAnniversay)
                    .HasMaxLength(20)
                    .HasColumnName("schedule_monthly_anniversay");
            });

            modelBuilder.Entity<CustomerLockedview>(entity =>
            {
                entity.ToTable("customer_lockedviews");

                entity.HasIndex(e => e.CustomerId, "customer_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Acl)
                    .HasColumnType("set('excl','role')")
                    .HasColumnName("acl")
                    .HasDefaultValueSql("'role'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.ExclAcl)
                    .HasColumnType("text")
                    .HasColumnName("excl_acl");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RoleAcl)
                    .HasColumnType("text")
                    .HasColumnName("role_acl");
            });

            modelBuilder.Entity<CustomerToc>(entity =>
            {
                entity.ToTable("customer_toc");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasMaxLength(6);

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customerID");

                entity.Property(e => e.FinancierCode).HasMaxLength(145);

                entity.Property(e => e.TocId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TocID");
            });

            modelBuilder.Entity<Customerchangelog>(entity =>
            {
                entity.ToTable("customerchangelog");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ChangeType).HasColumnType("text");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnType("int(11)");

                entity.Property(e => e.CustomerType).HasMaxLength(200);

                entity.Property(e => e.NewValue).HasColumnType("text");

                entity.Property(e => e.OldValue).HasColumnType("text");

                entity.Property(e => e.UserId).HasMaxLength(200);
            });

            modelBuilder.Entity<Customerrenewalsmtn>(entity =>
            {
                entity.ToTable("customerrenewalsmtn");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.ChargingAmount)
                    .HasPrecision(8)
                    .HasColumnName("charging_amount");

                entity.Property(e => e.Msisdn).HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.TblDt)
                    .HasColumnType("date")
                    .HasColumnName("tbl_dt");
            });

            modelBuilder.Entity<Customerrenewalsmtnjan>(entity =>
            {
                entity.ToTable("customerrenewalsmtnjan");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.ChargingAmount)
                    .HasPrecision(8)
                    .HasColumnName("charging_amount");

                entity.Property(e => e.Msisdn).HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.TblDt)
                    .HasColumnType("date")
                    .HasColumnName("tbl_dt");
            });

            modelBuilder.Entity<CustomersAutoRenewal>(entity =>
            {
                entity.ToTable("customers_auto_renewal");

                entity.HasIndex(e => e.Msisdn, "msisdn_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("timestamp(6)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("activation_date")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP(6)'");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(15)
                    .HasColumnName("msisdn");

                entity.Property(e => e.Tenure)
                    .HasColumnType("int(11)")
                    .HasColumnName("tenure");
            });

            modelBuilder.Entity<DataDump>(entity =>
            {
                entity.ToTable("data_dumps");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Dump)
                    .HasColumnType("text")
                    .HasColumnName("dump");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .HasColumnName("provider");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .HasColumnName("ref");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DataDumps200123>(entity =>
            {
                entity.ToTable("data_dumps_20_01_23");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Dump)
                    .HasColumnType("text")
                    .HasColumnName("dump");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .HasColumnName("provider");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .HasColumnName("ref");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Datalog>(entity =>
            {
                entity.ToTable("datalogs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.KeyId)
                    .HasColumnType("text")
                    .HasColumnName("key_id");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices");

                entity.HasIndex(e => e.Imei, "dev_ind_imei");

                entity.HasIndex(e => e.Name, "dev_ind_name");

                entity.HasIndex(e => e.Status, "dev_ind_status");

                entity.HasIndex(e => e.RepId, "devices_ibfk_4_idx");

                entity.HasIndex(e => e.Imei, "imei")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.AionStatus)
                    .HasMaxLength(30)
                    .HasColumnName("aion_status")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CtnNo)
                    .HasMaxLength(100)
                    .HasColumnName("ctn_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerImsi)
                    .HasMaxLength(50)
                    .HasColumnName("customer_imsi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CustomerMsisdn)
                    .HasMaxLength(20)
                    .HasColumnName("customer_msisdn")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_type_id");

                entity.Property(e => e.DistributorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("distributor_id");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("imei")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Imsi)
                    .HasMaxLength(50)
                    .HasColumnName("imsi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.Oem)
                    .HasMaxLength(50)
                    .HasColumnName("oem")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OldImsi)
                    .HasMaxLength(50)
                    .HasColumnName("old_imsi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OldMsisdn)
                    .HasMaxLength(50)
                    .HasColumnName("old_msisdn")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PO)
                    .HasMaxLength(100)
                    .HasColumnName("p_o")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.RetailStoreId)
                    .HasColumnType("int(11)")
                    .HasColumnName("retail_store_id");

                entity.Property(e => e.SN)
                    .HasMaxLength(100)
                    .HasColumnName("s_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DeviceCategory>(entity =>
            {
                entity.ToTable("device_categories");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BrandName)
                    .HasColumnType("text")
                    .HasColumnName("brand_name");

                entity.Property(e => e.CategoryName)
                    .HasColumnType("text")
                    .HasColumnName("category_name");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("partner_id");
            });

            modelBuilder.Entity<DeviceOption>(entity =>
            {
                entity.ToTable("device_options");

                entity.HasIndex(e => e.LoanId, "loan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BundleDeviceCost).HasColumnName("bundle_device_cost");

                entity.Property(e => e.BundleName)
                    .HasMaxLength(20)
                    .HasColumnName("bundle_name");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_type_id");

                entity.Property(e => e.DurationMonths)
                    .HasColumnType("smallint(2)")
                    .HasColumnName("duration_months");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.MaxDurationMonths).HasColumnType("smallint(6)");

                entity.Property(e => e.MinDurationMonths).HasColumnType("smallint(6)");

                entity.Property(e => e.RefMaxAmount).HasColumnName("ref_max_amount");

                entity.Property(e => e.RefMinAmount).HasColumnName("ref_min_amount");

                entity.Property(e => e.RiskClasses)
                    .HasColumnType("text")
                    .HasColumnName("risk_classes");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TelcoBundleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("telco_bundle_id");
            });

            modelBuilder.Entity<DeviceSubRenewal>(entity =>
            {
                entity.ToTable("device_sub_renewals");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AionActivationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("aion_activation_dt");

                entity.Property(e => e.AionNextRenewalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("aion_next_renewal_dt");

                entity.Property(e => e.AmtPaid)
                    .HasColumnName("amt_paid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("imei");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(20)
                    .HasColumnName("msisdn");

                entity.Property(e => e.Plan).HasColumnName("plan");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.ToTable("device_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Battery)
                    .HasColumnType("text")
                    .HasColumnName("battery");

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(30)
                    .HasColumnName("bluetooth");

                entity.Property(e => e.Camera)
                    .HasColumnType("text")
                    .HasColumnName("camera");

                entity.Property(e => e.Chipset)
                    .HasColumnType("text")
                    .HasColumnName("chipset");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DeviceCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_category_id");

                entity.Property(e => e.DeviceCount)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_count");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(100)
                    .HasColumnName("device_name");

                entity.Property(e => e.DeviceRam)
                    .HasColumnType("text")
                    .HasColumnName("device_ram");

                entity.Property(e => e.Dimension)
                    .HasColumnType("text")
                    .HasColumnName("dimension");

                entity.Property(e => e.Display)
                    .HasColumnType("text")
                    .HasColumnName("display");

                entity.Property(e => e.FullPriceNaira).HasColumnName("full_price_naira");

                entity.Property(e => e.MainPhoto)
                    .HasColumnType("text")
                    .HasColumnName("main_photo");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Netw)
                    .HasColumnType("text")
                    .HasColumnName("netw");

                entity.Property(e => e.OsUi)
                    .HasColumnType("text")
                    .HasColumnName("os_ui");

                entity.Property(e => e.PhotoGallery)
                    .HasColumnType("text")
                    .HasColumnName("photo_gallery");

                entity.Property(e => e.ScoreMax)
                    .HasColumnType("int(3)")
                    .HasColumnName("score_max")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.ScoreMin)
                    .HasColumnType("int(3)")
                    .HasColumnName("score_min")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ScreenSize)
                    .HasColumnType("text")
                    .HasColumnName("screen_size");

                entity.Property(e => e.Sensors)
                    .HasMaxLength(50)
                    .HasColumnName("sensors");

                entity.Property(e => e.Sim)
                    .HasMaxLength(30)
                    .HasColumnName("sim");

                entity.Property(e => e.Specs)
                    .HasColumnType("text")
                    .HasColumnName("specs");

                entity.Property(e => e.Storage)
                    .HasColumnType("text")
                    .HasColumnName("storage");

                entity.Property(e => e.Usb)
                    .HasMaxLength(30)
                    .HasColumnName("usb");

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .HasColumnName("weight");

                entity.Property(e => e.Wlan)
                    .HasMaxLength(30)
                    .HasColumnName("wlan");
            });

            modelBuilder.Entity<Devicemanualextentionhistory>(entity =>
            {
                entity.ToTable("devicemanualextentionhistory");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.ExtendedNoOfDays).HasColumnType("int(11)");

                entity.Property(e => e.ExtentionDate).HasMaxLength(6);

                entity.Property(e => e.UserId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Deviceworkflow>(entity =>
            {
                entity.ToTable("deviceworkflows");

                entity.HasIndex(e => e.WorkFlowDefinitionId, "FK_DeviceWorkFlows_WorkFlowDefinitions_WorkFlowDefinitionId");

                entity.HasIndex(e => e.DeviceId, "FK_DeviceWorkFlows_devices_DeviceId");

                entity.HasIndex(e => e.RepId, "FK_DeviceWorkFlows_users_RepId");

                entity.HasIndex(e => e.RetailStoreId, "IX_DeviceWorkFlows_RetailStoreId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnType("int(11)");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProcessLevel).HasColumnType("text");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RepId).HasColumnType("int(11)");

                entity.Property(e => e.RetailStoreId).HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("text");

                entity.Property(e => e.WorkFlowDefinitionId).HasColumnType("int(11)");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Deviceworkflows)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeviceWorkFlows_devices_DeviceId");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.Deviceworkflows)
                    .HasForeignKey(d => d.RepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeviceWorkFlows_users_RepId");

                entity.HasOne(d => d.WorkFlowDefinition)
                    .WithMany(p => p.Deviceworkflows)
                    .HasForeignKey(d => d.WorkFlowDefinitionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeviceWorkFlows_WorkFlowDefinitions_WorkFlowDefinitionId");
            });

            modelBuilder.Entity<Deviceworkflowstephistory>(entity =>
            {
                entity.ToTable("deviceworkflowstephistories");

                entity.HasIndex(e => e.DeviceWorkFlowId, "IX_DeviceWorkFlowStepHistories_DeviceWorkFlowId");

                entity.HasIndex(e => e.WorkFlowStepDefinitionId, "IX_DeviceWorkFlowStepHistories_WorkFlowStepDefinitionId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DeviceWorkFlowId).HasColumnType("int(11)");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("text");

                entity.Property(e => e.WorkFlowStepDefinitionId).HasColumnType("int(11)");

                entity.HasOne(d => d.DeviceWorkFlow)
                    .WithMany(p => p.Deviceworkflowstephistories)
                    .HasForeignKey(d => d.DeviceWorkFlowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeviceWorkFlowStepHistories_DeviceWorkFlows_DeviceWorkFlowId");

                entity.HasOne(d => d.WorkFlowStepDefinition)
                    .WithMany(p => p.Deviceworkflowstephistories)
                    .HasForeignKey(d => d.WorkFlowStepDefinitionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeviceWorkFlowStepHistories_WorkFlowStepDefinitions_WorkFlow~");
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.ToTable("distributors");

                entity.HasIndex(e => e.CompanyId, "company_id");

                entity.HasIndex(e => e.CompanyId, "company_id_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.Distributor)
                    .HasForeignKey<Distributor>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("distributors_ibfk_1");
            });

            modelBuilder.Entity<Duplicatecheck>(entity =>
            {
                entity.ToTable("duplicatecheck");

                entity.HasIndex(e => e.Id, "Id")
                    .IsUnique();

                entity.HasIndex(e => e.RefNo, "ref_no")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(767)
                    .HasColumnName("ref_no");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Endofdaysale>(entity =>
            {
                entity.ToTable("endofdaysales");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountNo).HasMaxLength(10);

                entity.Property(e => e.Customer).HasMaxLength(24);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Device).HasMaxLength(28);

                entity.Property(e => e.Financier).HasMaxLength(20);

                entity.Property(e => e.Imei).HasMaxLength(15);

                entity.Property(e => e.KycUrl)
                    .HasMaxLength(76)
                    .HasColumnName("Kyc_Url");

                entity.Property(e => e.LoanAmount)
                    .HasPrecision(8)
                    .HasColumnName("Loan_Amount");

                entity.Property(e => e.LoanDuration)
                    .HasMaxLength(9)
                    .HasColumnName("Loan_Duration");

                entity.Property(e => e.Msisdn).HasMaxLength(11);

                entity.Property(e => e.PlanTitle)
                    .HasMaxLength(20)
                    .HasColumnName("Plan_Title");

                entity.Property(e => e.RepName)
                    .HasMaxLength(29)
                    .HasColumnName("Rep_Name");

                entity.Property(e => e.Retailer).HasMaxLength(46);

                entity.Property(e => e.Telco).HasMaxLength(3);
            });

            modelBuilder.Entity<EnterpriseBundle>(entity =>
            {
                entity.ToTable("enterprise_bundles");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BundleName)
                    .HasMaxLength(255)
                    .HasColumnName("bundle_name");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DeviceRangeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_range_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<EnterpriseBundleClassification>(entity =>
            {
                entity.ToTable("enterprise_bundle_classifications");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BundleName)
                    .HasMaxLength(255)
                    .HasColumnName("bundle_name");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<EnterpriseBundlePlan>(entity =>
            {
                entity.ToTable("enterprise_bundle_plans");

                entity.HasIndex(e => e.EnterpriseBundleId, "enterprise_bundle_id");

                entity.HasIndex(e => e.EnterprisePlanId, "enterprise_plan_id");

                entity.HasIndex(e => new { e.RefLoanId, e.RefPlanId }, "ref_loan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DataPerMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("data_per_month");

                entity.Property(e => e.EnterpriseBundleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("enterprise_bundle_id");

                entity.Property(e => e.EnterprisePlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("enterprise_plan_id");

                entity.Property(e => e.FinanceAmount)
                    .HasPrecision(19, 4)
                    .HasColumnName("finance_amount");

                entity.Property(e => e.FinancingPartyFee)
                    .HasPrecision(19, 4)
                    .HasColumnName("financing_party_fee");

                entity.Property(e => e.InitialDeposit)
                    .HasPrecision(19, 4)
                    .HasColumnName("initial_deposit");

                entity.Property(e => e.IntelligraSupportFee)
                    .HasPrecision(19, 4)
                    .HasColumnName("intelligra_support_fee");

                entity.Property(e => e.InterestPercent)
                    .HasPrecision(19, 4)
                    .HasColumnName("interest_percent");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RefLoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ref_loan_id");

                entity.Property(e => e.RefPlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ref_plan_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.TotalBundleCharge)
                    .HasPrecision(19, 4)
                    .HasColumnName("total_bundle_charge");

                entity.Property(e => e.VoicePerMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_per_month");

                entity.HasOne(d => d.EnterpriseBundle)
                    .WithMany(p => p.EnterpriseBundlePlans)
                    .HasForeignKey(d => d.EnterpriseBundleId)
                    .HasConstraintName("enterprise_bundle_plans_ibfk_1");

                entity.HasOne(d => d.EnterprisePlan)
                    .WithMany(p => p.EnterpriseBundlePlans)
                    .HasForeignKey(d => d.EnterprisePlanId)
                    .HasConstraintName("enterprise_bundle_plans_ibfk_2");
            });

            modelBuilder.Entity<EnterpriseCompany>(entity =>
            {
                entity.ToTable("enterprise_companies");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyLocation)
                    .HasMaxLength(255)
                    .HasColumnName("company_location");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<EnterpriseCustomer>(entity =>
            {
                entity.ToTable("enterprise_customers");

                entity.HasIndex(e => e.CompanyId, "company_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreditLimit)
                    .HasPrecision(10)
                    .HasColumnName("credit_limit");

                entity.Property(e => e.FinancierCompanyId)
                    .HasColumnType("bigint(20) unsigned zerofill")
                    .HasColumnName("financier_company_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(255)
                    .HasColumnName("msisdn");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<EnterprisePlan>(entity =>
            {
                entity.ToTable("enterprise_plans");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("plan_name");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Entitynote>(entity =>
            {
                entity.ToTable("entitynotes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasMaxLength(6);

                entity.Property(e => e.EntityId)
                    .HasMaxLength(450)
                    .HasColumnName("EntityID");

                entity.Property(e => e.EntityTypeId).HasColumnType("int(11)");

                entity.Property(e => e.Flag).HasMaxLength(200);

                entity.Property(e => e.LastDate).HasMaxLength(6);

                entity.Property(e => e.Modified).HasMaxLength(6);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UserId).HasMaxLength(200);
            });

            modelBuilder.Entity<Entitynoteflag>(entity =>
            {
                entity.ToTable("entitynoteflag");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FlagCode).HasMaxLength(200);
            });

            modelBuilder.Entity<Entitynotetype>(entity =>
            {
                entity.ToTable("entitynotetype");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DateAdded).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<FinanceMovement>(entity =>
            {
                entity.ToTable("finance_movements");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Method)
                    .HasColumnType("text")
                    .HasColumnName("method");

                entity.Property(e => e.UniqueIdentifier)
                    .HasColumnType("text")
                    .HasColumnName("uniqueIdentifier");
            });

            modelBuilder.Entity<Financieramortizationschedule>(entity =>
            {
                entity.ToTable("financieramortizationschedule");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Bundle).HasColumnType("text");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.FinancierId).HasColumnType("int(11)");

                entity.Property(e => e.InterestRepayment).HasPrecision(8);

                entity.Property(e => e.OriginatingFee).HasPrecision(8);

                entity.Property(e => e.PlatformFee).HasPrecision(8);

                entity.Property(e => e.PrincipalRepayment).HasPrecision(8);

                entity.Property(e => e.RepaymentMonth).HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TelcoFee).HasPrecision(8);

                entity.Property(e => e.TotalMonthlyRepayment).HasPrecision(8);

                entity.Property(e => e.TotalPaymentToFinancier).HasPrecision(8);
            });

            modelBuilder.Entity<Finservicetxnlog>(entity =>
            {
                entity.ToTable("finservicetxnlogs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ActivationStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("activation_status");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InsurerPaytStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("insurer_payt_status");

                entity.Property(e => e.Manualcomment)
                    .HasColumnType("text")
                    .HasColumnName("manualcomment");

                entity.Property(e => e.Manualcommentby)
                    .HasColumnType("int(11)")
                    .HasColumnName("manualcommentby");

                entity.Property(e => e.PrecustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("precustomer_id");

                entity.Property(e => e.RefNo)
                    .HasColumnType("text")
                    .HasColumnName("ref_no");

                entity.Property(e => e.RetailerPaytStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("retailer_payt_status");

                entity.Property(e => e.Syscomment)
                    .HasColumnType("text")
                    .HasColumnName("syscomment");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("inventories");

                entity.HasIndex(e => e.DeviceId, "device_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DeviceCategoryId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_category_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.DeviceImei)
                    .HasMaxLength(50)
                    .HasColumnName("device_imei");

                entity.Property(e => e.DeviceStatus)
                    .HasMaxLength(20)
                    .HasColumnName("device_status");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_type_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.RetailStoreId)
                    .HasColumnType("int(10)")
                    .HasColumnName("retail_store_id");
            });

            modelBuilder.Entity<KycBk0507>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kyc_bk_05_07");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.InputName)
                    .HasMaxLength(255)
                    .HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfo>(entity =>
            {
                entity.ToTable("kyc_infos");

                entity.HasIndex(e => new { e.InputName, e.PreCustomerId }, "input_name")
                    .IsUnique();

                entity.HasIndex(e => e.InputName, "kyc_ind_input_value");

                entity.HasIndex(e => e.PreCustomerId, "precustid");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.InputName).HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfoBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kyc_info_bkp");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InputName)
                    .HasMaxLength(255)
                    .HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfoBkp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kyc_info_bkp1");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InputName)
                    .HasMaxLength(255)
                    .HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfos1024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kyc_infos_10_24");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InputName)
                    .HasMaxLength(255)
                    .HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfos130123>(entity =>
            {
                entity.ToTable("kyc_infos_13_01_23");

                entity.HasIndex(e => new { e.InputName, e.PreCustomerId }, "input_name")
                    .IsUnique();

                entity.HasIndex(e => e.InputName, "kyc_ind_input_value");

                entity.HasIndex(e => e.PreCustomerId, "precustid");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.InputName).HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfos2>(entity =>
            {
                entity.ToTable("kyc_infos2");

                entity.HasIndex(e => new { e.InputName, e.PreCustomerId }, "input_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.InputName).HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KycInfosBck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kyc_infos_bck");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InputName)
                    .HasMaxLength(255)
                    .HasColumnName("input_name");

                entity.Property(e => e.InputType)
                    .HasMaxLength(20)
                    .HasColumnName("input_type");

                entity.Property(e => e.InputValue)
                    .HasColumnType("text")
                    .HasColumnName("input_value");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Sequence)
                    .HasColumnType("int(3)")
                    .HasColumnName("sequence");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Ledger>(entity =>
            {
                entity.ToTable("ledgers");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ActualFormular).HasColumnType("text");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.ProposedFormular).HasColumnType("text");
            });

            modelBuilder.Entity<Ledgertransaction>(entity =>
            {
                entity.ToTable("ledgertransactions");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BookedLoanDate).HasColumnType("datetime");

                entity.Property(e => e.BundledDeviceTypeId)
                    .HasColumnType("text")
                    .HasColumnName("Bundled_Device_Type_Id");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.DeviceTypeId).HasColumnType("int(11)");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.Imei).HasColumnType("text");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.OldFinancierCode).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("int(11)");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RepId)
                    .HasColumnType("text")
                    .HasColumnName("Rep_id");

                entity.Property(e => e.RetailerPaidDate).HasColumnType("datetime");

                entity.Property(e => e.SalesRepId).HasColumnType("int(11)");

                entity.Property(e => e.StoreId).HasColumnType("int(11)");

                entity.Property(e => e.SystemComment).HasColumnType("text");

                entity.Property(e => e.UpdatedStoreId)
                    .HasColumnType("text")
                    .HasColumnName("Updated_StoreId");

                entity.Property(e => e.UserComment).HasColumnType("text");

                entity.Property(e => e.VoluntaryDownpayment).HasColumnName("Voluntary_Downpayment");
            });

            modelBuilder.Entity<LedgertransactionBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ledgertransaction_bkp");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.DeviceTypeId).HasColumnType("int(11)");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("int(11)");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.SalesRepId).HasColumnType("int(11)");

                entity.Property(e => e.SystemComment).HasColumnType("text");

                entity.Property(e => e.UserComment).HasColumnType("text");
            });

            modelBuilder.Entity<LedgertransactionBkp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ledgertransaction_bkp1");

                entity.HasIndex(e => e.Id, "Id")
                    .IsUnique();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.DeviceTypeId).HasColumnType("int(11)");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("int(11)");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.SalesRepId).HasColumnType("int(11)");

                entity.Property(e => e.SystemComment).HasColumnType("text");

                entity.Property(e => e.UserComment).HasColumnType("text");
            });

            modelBuilder.Entity<Ledgertransactiondetail>(entity =>
            {
                entity.ToTable("ledgertransactiondetails");

                entity.HasIndex(e => e.LedgerId, "IX_LedgerTransactionDetails_LedgerId");

                entity.HasIndex(e => e.LedgerTransactionId, "IX_LedgerTransactionDetails_LedgerTransactionId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LedgerId).HasColumnType("int(11)");

                entity.Property(e => e.LedgerTransactionId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.Ledgertransactiondetails)
                    .HasForeignKey(d => d.LedgerId)
                    .HasConstraintName("FK_LedgerTransactionDetails_Ledgers_LedgerId");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.Ledgertransactiondetails)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .HasConstraintName("FK_LedgerTransactionDetails_LedgerTransactions_LedgerTransactio~");
            });

            modelBuilder.Entity<LedgertransactiondetailsBkp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ledgertransactiondetails_bkp1");

                entity.HasIndex(e => e.Id, "Id")
                    .IsUnique();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.LedgerId).HasColumnType("int(11)");

                entity.Property(e => e.LedgerTransactionId).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Lender>(entity =>
            {
                entity.ToTable("lenders");

                entity.HasIndex(e => e.CompanyId, "company_id");

                entity.HasIndex(e => e.CompanyId, "company_id_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActualMonthlyInterestRate).HasColumnName("actual_monthly_interest_rate");

                entity.Property(e => e.AutoApprove).HasColumnName("auto_approve");

                entity.Property(e => e.BannerUrl)
                    .HasColumnType("text")
                    .HasColumnName("banner_url");

                entity.Property(e => e.BrandTheme)
                    .HasColumnType("text")
                    .HasColumnName("brand_theme");

                entity.Property(e => e.Code)
                    .HasColumnType("text")
                    .HasColumnName("code");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.DailyCreditLimit).HasColumnName("daily_credit_limit");

                entity.Property(e => e.EstimatedInterestRate).HasColumnName("estimated_interest_rate");

                entity.Property(e => e.IsCustomKyc).HasColumnName("is_custom_kyc");

                entity.Property(e => e.LoanCount)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_count");

                entity.Property(e => e.LogoUrl)
                    .HasColumnType("text")
                    .HasColumnName("logo_url");

                entity.Property(e => e.MonthlyCreditLimit).HasColumnName("monthly_credit_limit");

                entity.Property(e => e.OnboardUrl)
                    .HasColumnType("text")
                    .HasColumnName("onboard_url");

                entity.Property(e => e.ProcessingFeeRate).HasColumnName("processing_fee_rate");

                entity.Property(e => e.ReportReceivers)
                    .HasColumnType("text")
                    .HasColumnName("report_receivers");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.Lender)
                    .HasForeignKey<Lender>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("company");
            });

            modelBuilder.Entity<LenderCreditLimit>(entity =>
            {
                entity.ToTable("lender_credit_limits");

                entity.HasIndex(e => new { e.LenderId, e.RiskClass }, "unique_credit_limit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreditLimit).HasColumnName("credit_limit");

                entity.Property(e => e.LenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lender_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(3)
                    .HasColumnName("risk_class");
            });

            modelBuilder.Entity<Lga>(entity =>
            {
                entity.ToTable("lgas");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LgaName)
                    .HasMaxLength(22)
                    .HasColumnName("lga_name");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.ToTable("loans");

                entity.HasIndex(e => e.LenderId, "lender_id");

                entity.HasIndex(e => e.PrincipalAmt, "loa_ind_principal_amt");

                entity.HasIndex(e => e.LoanTitle, "loa_ind_title");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AftersalesFees)
                    .HasColumnName("aftersales_fees")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Downpayment)
                    .HasColumnName("downpayment")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GraceTimeDays)
                    .HasColumnType("mediumint(4)")
                    .HasColumnName("grace_time_days");

                entity.Property(e => e.InterestAmt).HasColumnName("interest_amt");

                entity.Property(e => e.InterestAmt2Intlgr)
                    .HasColumnName("interest_amt2_intlgr")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InterestAmt2Lender)
                    .HasColumnName("interest_amt2_lender")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IntlgrAmt)
                    .HasColumnName("intlgr_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsCofinance).HasColumnName("is_cofinance");

                entity.Property(e => e.LenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lender_id");

                entity.Property(e => e.LoanTitle)
                    .HasMaxLength(500)
                    .HasColumnName("loan_title");

                entity.Property(e => e.MaxRiskClass)
                    .HasMaxLength(3)
                    .HasColumnName("max_risk_class");

                entity.Property(e => e.MinRiskClass)
                    .HasMaxLength(3)
                    .HasColumnName("min_risk_class");

                entity.Property(e => e.MinimumScore).HasColumnName("minimum_score");

                entity.Property(e => e.MnoCommission)
                    .HasColumnName("mno_commission")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyTenure)
                    .HasMaxLength(20)
                    .HasColumnName("monthly_tenure");

                entity.Property(e => e.OriginInterestFees)
                    .HasColumnName("origin_interest_fees")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PaelytLoancode)
                    .HasMaxLength(20)
                    .HasColumnName("paelyt_loancode");

                entity.Property(e => e.PenaltyAmt)
                    .HasColumnName("penalty_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.PrincipalAmt).HasColumnName("principal_amt");

                entity.Property(e => e.SecondaryFinancierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("secondary_financier_id");

                entity.Property(e => e.SecondaryFinancierInterestAmt).HasColumnName("secondary_financier_interest_amt");

                entity.Property(e => e.SecondaryFinancierShareamt).HasColumnName("secondary_financier_shareamt");

                entity.Property(e => e.TelcoAmt)
                    .HasColumnName("telco_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TertiaryFinancierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tertiary_financier_id");

                entity.Property(e => e.TertiaryFinancierInterestAmt).HasColumnName("tertiary_financier_interest_amt");

                entity.Property(e => e.TertiaryFinancierShareamt).HasColumnName("tertiary_financier_shareamt");

                entity.Property(e => e.TotalAmt)
                    .HasMaxLength(11)
                    .HasColumnName("total_amt");

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.LenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loans_ibfk_1");
            });

            modelBuilder.Entity<LoanAllocation>(entity =>
            {
                entity.ToTable("loan_allocations");

                entity.HasIndex(e => e.DeviceId, "device_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(6)")
                    .HasColumnName("duration");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");
            });

            modelBuilder.Entity<LoanAllocationsDevices0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("loan_allocations_devices0");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(6)")
                    .HasColumnName("duration");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");
            });

            modelBuilder.Entity<LoanRepayHistory>(entity =>
            {
                entity.ToTable("loan_repay_history");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.DeviceId, "device_id");

                entity.HasIndex(e => e.LoanId, "loan_id");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActualPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("actual_payment_date");

                entity.Property(e => e.AmtPaid).HasColumnName("amt_paid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DataDumpId)
                    .HasColumnType("int(10)")
                    .HasColumnName("data_dump_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyActivationDate)
                    .HasColumnType("date")
                    .HasColumnName("monthly_activation_date");

                entity.Property(e => e.PenaltyAmt)
                    .HasColumnName("penalty_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LoanRepayHistories)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_history_ibfk_3");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.LoanRepayHistories)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_history_ibfk_4");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.LoanRepayHistories)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_history_ibfk_1");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.LoanRepayHistories)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_history_ibfk_2");
            });

            modelBuilder.Entity<LoanRepaySchedule>(entity =>
            {
                entity.ToTable("loan_repay_schedules");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.DeviceId, "device_id");

                entity.HasIndex(e => e.LoanId, "loan_id");

                entity.HasIndex(e => e.NumberOfPaymentMade, "lrp_ind_number_of_payment_made");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.AmountPending).HasColumnName("amount_pending");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.LoanAllocationId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_allocation_id");

                entity.Property(e => e.LoanDuration)
                    .HasMaxLength(20)
                    .HasColumnName("loan_duration");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyAnniversaryDate)
                    .HasMaxLength(20)
                    .HasColumnName("monthly_anniversary_date");

                entity.Property(e => e.NextAmountDue).HasColumnName("next_amount_due");

                entity.Property(e => e.NextPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("next_payment_date");

                entity.Property(e => e.NumberOfPaymentMade)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payment_made");

                entity.Property(e => e.NumberOfPaymentsPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payments_pending");

                entity.Property(e => e.NumberOfRepayments)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_repayments");

                entity.Property(e => e.PenaltyPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("penalty_pending");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.RepayIsDaily)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_daily");

                entity.Property(e => e.RepayIsWeekly)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_weekly");

                entity.Property(e => e.TotalLoanAmount).HasColumnName("total_loan_amount");

                entity.Property(e => e.TxDumpsList)
                    .HasColumnType("text")
                    .HasColumnName("tx_dumps_list");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LoanRepaySchedules)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_schedules_ibfk_3");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.LoanRepaySchedules)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_schedules_ibfk_4");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.LoanRepaySchedules)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_schedules_ibfk_1");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.LoanRepaySchedules)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("loan_repay_schedules_ibfk_2");
            });

            modelBuilder.Entity<Loanallocationbk20230110>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("loanallocationbk_2023_01_10");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(6)")
                    .HasColumnName("duration");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");
            });

            modelBuilder.Entity<Loanallocationsbkup1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("loanallocationsbkup1");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(6)")
                    .HasColumnName("duration");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");
            });

            modelBuilder.Entity<Loanrepayschedulesbkup1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("loanrepayschedulesbkup1");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.AmountPending).HasColumnName("amount_pending");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanAllocationId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_allocation_id");

                entity.Property(e => e.LoanDuration)
                    .HasMaxLength(20)
                    .HasColumnName("loan_duration");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyAnniversaryDate)
                    .HasMaxLength(20)
                    .HasColumnName("monthly_anniversary_date");

                entity.Property(e => e.NextAmountDue).HasColumnName("next_amount_due");

                entity.Property(e => e.NextPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("next_payment_date");

                entity.Property(e => e.NumberOfPaymentMade)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payment_made");

                entity.Property(e => e.NumberOfPaymentsPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payments_pending");

                entity.Property(e => e.NumberOfRepayments)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_repayments");

                entity.Property(e => e.PenaltyPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("penalty_pending");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.RepayIsDaily)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_daily");

                entity.Property(e => e.RepayIsWeekly)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_weekly");

                entity.Property(e => e.TotalLoanAmount).HasColumnName("total_loan_amount");

                entity.Property(e => e.TxDumpsList)
                    .HasColumnType("text")
                    .HasColumnName("tx_dumps_list");
            });

            modelBuilder.Entity<Loanschedulebk20230110>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("loanschedulebk_2023_01_10");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.AmountPending).HasColumnName("amount_pending");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanAllocationId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_allocation_id");

                entity.Property(e => e.LoanDuration)
                    .HasMaxLength(20)
                    .HasColumnName("loan_duration");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyAnniversaryDate)
                    .HasMaxLength(20)
                    .HasColumnName("monthly_anniversary_date");

                entity.Property(e => e.NextAmountDue).HasColumnName("next_amount_due");

                entity.Property(e => e.NextPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("next_payment_date");

                entity.Property(e => e.NumberOfPaymentMade)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payment_made");

                entity.Property(e => e.NumberOfPaymentsPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_payments_pending");

                entity.Property(e => e.NumberOfRepayments)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("number_of_repayments");

                entity.Property(e => e.PenaltyPending)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("penalty_pending");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.RepayIsDaily)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_daily");

                entity.Property(e => e.RepayIsWeekly)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("repay_is_weekly");

                entity.Property(e => e.TotalLoanAmount).HasColumnName("total_loan_amount");

                entity.Property(e => e.TxDumpsList)
                    .HasColumnType("text")
                    .HasColumnName("tx_dumps_list");
            });

            modelBuilder.Entity<LrhBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lrh_bk");

                entity.Property(e => e.ActualPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("actual_payment_date");

                entity.Property(e => e.AmtPaid).HasColumnName("amt_paid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DataDumpId)
                    .HasColumnType("int(10)")
                    .HasColumnName("data_dump_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyActivationDate)
                    .HasColumnType("date")
                    .HasColumnName("monthly_activation_date");

                entity.Property(e => e.PenaltyAmt)
                    .HasColumnName("penalty_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");
            });

            modelBuilder.Entity<Lrpmtnexceptionmarch2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lrpmtnexceptionmarch2023");

                entity.Property(e => e.ActualPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("actual_payment_date");

                entity.Property(e => e.AmtPaid).HasColumnName("amt_paid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DataDumpId)
                    .HasColumnType("int(10)")
                    .HasColumnName("data_dump_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MonthlyActivationDate)
                    .HasColumnType("date")
                    .HasColumnName("monthly_activation_date");

                entity.Property(e => e.PenaltyAmt)
                    .HasColumnName("penalty_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");
            });

            modelBuilder.Entity<MailQueue>(entity =>
            {
                entity.ToTable("mail_queue");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.MsgTemplate)
                    .HasColumnType("text")
                    .HasColumnName("msg_template");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(50)
                    .HasColumnName("recipient");

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .HasColumnName("sender");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .HasColumnName("subject");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Viewvars)
                    .HasColumnType("text")
                    .HasColumnName("viewvars");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("messages");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Body).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.NotifyType).HasColumnType("text");

                entity.Property(e => e.Subject).HasColumnType("text");
            });

            modelBuilder.Entity<MtnRenewReport>(entity =>
            {
                entity.ToTable("mtn_renew_reports");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AionLastRenewalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("aion_last_renewal_date");

                entity.Property(e => e.AionNextRenewalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("aion_next_renewal_date");

                entity.Property(e => e.ChargingAmt)
                    .HasMaxLength(50)
                    .HasColumnName("charging_amt");

                entity.Property(e => e.CurrentLoan).HasColumnName("current_loan");

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .HasColumnName("customer");

                entity.Property(e => e.Device).HasColumnName("device");

                entity.Property(e => e.Imei)
                    .HasMaxLength(100)
                    .HasColumnName("imei");

                entity.Property(e => e.IsUnlock)
                    .HasMaxLength(10)
                    .HasColumnName("is_unlock");

                entity.Property(e => e.LastLoan).HasColumnName("last_loan");

                entity.Property(e => e.LastPaidAmt)
                    .HasColumnName("last_paid_amt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(20)
                    .HasColumnName("msisdn");

                entity.Property(e => e.Plan)
                    .HasMaxLength(500)
                    .HasColumnName("plan");

                entity.Property(e => e.SysLastRenewalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sys_last_renewal_date");

                entity.Property(e => e.SysNextRenewalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sys_next_renewal_date");
            });

            modelBuilder.Entity<Mtnactivesubscription20230305>(entity =>
            {
                entity.ToTable("mtnactivesubscription20230305");

                entity.HasIndex(e => e.Msisdn, "msisdn_mtn_index");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Bundle).HasMaxLength(200);

                entity.Property(e => e.Channel).HasMaxLength(100);

                entity.Property(e => e.Msisdn).HasMaxLength(50);
            });

            modelBuilder.Entity<Mtndump>(entity =>
            {
                entity.ToTable("mtndumps");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Collection).HasColumnName("collection");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.FileContent)
                    .HasColumnType("text")
                    .HasColumnName("file_content");

                entity.Property(e => e.FileName)
                    .HasColumnType("text")
                    .HasColumnName("file_name");

                entity.Property(e => e.Logging)
                    .HasMaxLength(10)
                    .HasColumnName("logging");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(20)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NextPaymDate)
                    .HasColumnType("date")
                    .HasColumnName("next_paym_date");

                entity.Property(e => e.RefId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ref_id");
            });

            modelBuilder.Entity<Paelytcustomerlog>(entity =>
            {
                entity.ToTable("paelytcustomerlogs");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountNumber).HasColumnType("text");

                entity.Property(e => e.ApplicationDate).HasColumnType("text");

                entity.Property(e => e.BankCode).HasColumnType("text");

                entity.Property(e => e.Bvn).HasColumnType("text");

                entity.Property(e => e.CustomerName).HasColumnType("text");

                entity.Property(e => e.CustomerPhoneNo).HasColumnType("text");

                entity.Property(e => e.DeliveryCode).HasColumnType("text");

                entity.Property(e => e.Device).HasColumnType("text");

                entity.Property(e => e.DeviceBrand).HasColumnType("text");

                entity.Property(e => e.DeviceOptionId)
                    .HasColumnType("text")
                    .HasColumnName("Device_Option_Id");

                entity.Property(e => e.DevicePlanName).HasColumnType("text");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("text")
                    .HasColumnName("Device_Type_Id");

                entity.Property(e => e.Imei).HasColumnType("text");

                entity.Property(e => e.LoanCode).HasColumnType("text");

                entity.Property(e => e.LoanTenure).HasColumnType("int(11)");

                entity.Property(e => e.Network).HasColumnType("text");

                entity.Property(e => e.Nin).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("bigint(20)");

                entity.Property(e => e.ReferenceId).HasColumnType("text");

                entity.Property(e => e.StoreId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("partners");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.BankAcc)
                    .HasMaxLength(20)
                    .HasColumnName("bank_acc");

                entity.Property(e => e.BankAccName)
                    .HasMaxLength(100)
                    .HasColumnName("bank_acc_name");

                entity.Property(e => e.BankName)
                    .HasColumnType("text")
                    .HasColumnName("bank_name");

                entity.Property(e => e.CacRegNo)
                    .HasMaxLength(20)
                    .HasColumnName("cac_reg_no");

                entity.Property(e => e.CompanyName)
                    .HasColumnType("text")
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyType)
                    .HasMaxLength(20)
                    .HasColumnName("company_type");

                entity.Property(e => e.Contact1Email)
                    .HasMaxLength(100)
                    .HasColumnName("contact1_email");

                entity.Property(e => e.Contact1Name)
                    .HasColumnType("text")
                    .HasColumnName("contact1_name");

                entity.Property(e => e.Contact1Phone)
                    .HasMaxLength(20)
                    .HasColumnName("contact1_phone");

                entity.Property(e => e.Contact2Email)
                    .HasMaxLength(100)
                    .HasColumnName("contact2_email");

                entity.Property(e => e.Contact2Name)
                    .HasColumnType("text")
                    .HasColumnName("contact2_name");

                entity.Property(e => e.Contact2Phone)
                    .HasMaxLength(20)
                    .HasColumnName("contact2_phone");
            });

            modelBuilder.Entity<Partnerstype>(entity =>
            {
                entity.ToTable("partnerstypes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Type).HasColumnType("text");
            });

            modelBuilder.Entity<PaymentTransaction>(entity =>
            {
                entity.ToTable("payment_transactions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(11,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Comment1)
                    .HasColumnType("text")
                    .HasColumnName("comment1");

                entity.Property(e => e.Comment2)
                    .HasColumnType("text")
                    .HasColumnName("comment2");

                entity.Property(e => e.Comment3)
                    .HasColumnType("text")
                    .HasColumnName("comment3");

                entity.Property(e => e.Commission)
                    .HasColumnType("double(11,2)")
                    .HasColumnName("commission");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("currency_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PayGateway)
                    .HasMaxLength(100)
                    .HasColumnName("pay_gateway");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .HasColumnName("status");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(20)
                    .HasColumnName("status_code");

                entity.Property(e => e.TransactionRef)
                    .HasMaxLength(255)
                    .HasColumnName("transaction_ref");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(20)
                    .HasColumnName("transaction_type");
            });

            modelBuilder.Entity<Paymentchannel>(entity =>
            {
                entity.ToTable("paymentchannels");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<Paymentchannelparameter>(entity =>
            {
                entity.ToTable("paymentchannelparameters");

                entity.HasIndex(e => e.PaymentChannelId, "IX_PaymentChannelParameters_PaymentChannelId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InputName).HasColumnType("text");

                entity.Property(e => e.InputValue).HasColumnType("text");

                entity.Property(e => e.Mode).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PaymentChannelId).HasColumnType("int(11)");

                entity.HasOne(d => d.PaymentChannel)
                    .WithMany(p => p.Paymentchannelparameters)
                    .HasForeignKey(d => d.PaymentChannelId)
                    .HasConstraintName("FK_PaymentChannelParameters_PaymentChannels_PaymentChannelId");
            });

            modelBuilder.Entity<Paymentinitiationlog>(entity =>
            {
                entity.HasKey(e => e.RefNo)
                    .HasName("PRIMARY");

                entity.ToTable("paymentinitiationlogs");

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Amount).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Paystackrecipient>(entity =>
            {
                entity.ToTable("paystackrecipients");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountNo).HasColumnType("text");

                entity.Property(e => e.AcountName).HasColumnType("text");

                entity.Property(e => e.BankCode).HasColumnType("text");

                entity.Property(e => e.Currency).HasColumnType("text");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.Phone).HasColumnType("text");

                entity.Property(e => e.RecipientCode).HasColumnType("text");

                entity.Property(e => e.RecipientType).HasColumnType("text");
            });

            modelBuilder.Entity<Paystacktransferlog>(entity =>
            {
                entity.ToTable("paystacktransferlogs");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.DateInitiated).HasColumnType("datetime");

                entity.Property(e => e.PaystackTransferCode).HasColumnType("text");

                entity.Property(e => e.PaystackTransferId).HasColumnType("text");

                entity.Property(e => e.PaystackTransferRef).HasColumnType("text");

                entity.Property(e => e.PreCustomerId).HasColumnType("bigint(20)");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RecipientCode).HasColumnType("text");

                entity.Property(e => e.Source).HasColumnType("text");

                entity.Property(e => e.TransferStatus).HasColumnType("text");

                entity.Property(e => e.WebhookStatus).HasColumnType("text");

                entity.Property(e => e.WebhookTimestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<PenaltyPayment>(entity =>
            {
                entity.ToTable("penalty_payments");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permissions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasMaxLength(767);

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Section).HasColumnType("text");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasIndex(e => e.PlanTitle, "pla_index_plan_title");

                entity.HasIndex(e => e.TelcoId, "telco_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DataQty)
                    .HasMaxLength(20)
                    .HasColumnName("data_qty");

                entity.Property(e => e.Downpayment).HasColumnName("downpayment");

                entity.Property(e => e.Duration)
                    .HasMaxLength(10)
                    .HasColumnName("duration");

                entity.Property(e => e.MonthlyCost2lender).HasColumnName("monthly_cost2lender");

                entity.Property(e => e.MonthlyCost2telco).HasColumnName("monthly_cost2telco");

                entity.Property(e => e.MonthlyCost4others).HasColumnName("monthly_cost4others");

                entity.Property(e => e.MonthlyCostTotal).HasColumnName("monthly_cost_total");

                entity.Property(e => e.OtherBenefits)
                    .HasColumnType("text")
                    .HasColumnName("other_benefits");

                entity.Property(e => e.PlanTitle)
                    .HasMaxLength(500)
                    .HasColumnName("plan_title");

                entity.Property(e => e.SmsQty)
                    .HasMaxLength(20)
                    .HasColumnName("sms_qty");

                entity.Property(e => e.TelcoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("telco_id");

                entity.Property(e => e.VoiceMinutes)
                    .HasMaxLength(20)
                    .HasColumnName("voice_minutes");

                entity.HasOne(d => d.Telco)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.TelcoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plans_ibfk_1");
            });

            modelBuilder.Entity<PreCustomer>(entity =>
            {
                entity.ToTable("pre_customers");

                entity.HasIndex(e => e.Msisdn, "msisdn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BundleDeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bundleDeviceTypeId");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Imei).HasColumnType("text");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.RepCurrentStatus).HasColumnType("text");

                entity.Property(e => e.RepId).HasColumnType("int(11)");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bck");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBkp>(entity =>
            {
                entity.ToTable("pre_customers_bkp");

                entity.HasIndex(e => e.Msisdn, "msisdn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(20)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBkp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bkp1");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBkp11>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bkp_1");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BundleDeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bundleDeviceTypeId");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Imei).HasColumnType("text");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RepCurrentStatus).HasColumnType("text");

                entity.Property(e => e.RepId).HasColumnType("int(11)");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBkp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bkp2");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBkp3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bkp3");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PreCustomersBvnissue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_customers_bvnissue");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<Precustnobvn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("precustnobvn");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.AvatarGen)
                    .HasColumnType("text")
                    .HasColumnName("avatar_gen");

                entity.Property(e => e.BundleDeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bundleDeviceTypeId");

                entity.Property(e => e.BvnCheckCount)
                    .HasColumnType("mediumint(3)")
                    .HasColumnName("bvn_check_count");

                entity.Property(e => e.BvnDump)
                    .HasColumnType("text")
                    .HasColumnName("bvn_dump");

                entity.Property(e => e.BvnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("bvn_number");

                entity.Property(e => e.BvnStatus)
                    .HasMaxLength(20)
                    .HasColumnName("bvn_status");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.Datasource)
                    .HasMaxLength(20)
                    .HasColumnName("datasource");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.DeviceOptionId).HasColumnType("int(11)");

                entity.Property(e => e.Dob)
                    .HasColumnType("text")
                    .HasColumnName("dob");

                entity.Property(e => e.FamilyPlannerCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("family_planner_customer");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("fname");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdDump)
                    .HasColumnType("text")
                    .HasColumnName("id_dump");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(100)
                    .HasColumnName("id_number");

                entity.Property(e => e.IdStatus)
                    .HasMaxLength(100)
                    .HasColumnName("id_status");

                entity.Property(e => e.Imei).HasColumnType("text");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(100)
                    .HasColumnName("msisdn");

                entity.Property(e => e.NonuserReason)
                    .HasColumnType("text")
                    .HasColumnName("nonuser_reason");

                entity.Property(e => e.OnboardingStatus)
                    .HasMaxLength(30)
                    .HasColumnName("onboarding_status")
                    .HasDefaultValueSql("'incomplete'");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.RepCurrentStatus).HasColumnType("text");

                entity.Property(e => e.RepId).HasColumnType("int(11)");

                entity.Property(e => e.RiskClass)
                    .HasMaxLength(5)
                    .HasColumnName("risk_class");

                entity.Property(e => e.Score)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TempOtp)
                    .HasMaxLength(10)
                    .HasColumnName("temp_otp");

                entity.Property(e => e.VerifyStatus).HasColumnName("verify_status");
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.ToTable("price_lists");

                entity.HasIndex(e => new { e.DeviceTypeId, e.RetailStoreId }, "unique_entry")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("device_type_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RetailStoreId)
                    .HasColumnType("int(11)")
                    .HasColumnName("retail_store_id");
            });

            modelBuilder.Entity<Ptmfbtransactionslog>(entity =>
            {
                entity.ToTable("ptmfbtransactionslog");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.RetrievalReference).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnType("text");

                entity.Property(e => e.TransactionRef).HasColumnType("text");

                entity.Property(e => e.TransactionType).HasColumnType("text");
            });

            modelBuilder.Entity<Rechargelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rechargelist");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IsTreated).HasColumnType("int(11)");

                entity.Property(e => e.Network).HasMaxLength(100);

                entity.Property(e => e.PhoneNo).HasColumnType("bigint(10)");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(3)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supervisor_id");
            });

            modelBuilder.Entity<RegionSupervisorMapping>(entity =>
            {
                entity.ToTable("region_supervisor_mapping");

                entity.HasIndex(e => e.RegionId, "IX_region_supervisor_mapping_regionId");

                entity.HasIndex(e => e.StateId, "IX_region_supervisor_mapping_stateId");

                entity.HasIndex(e => e.SupervisorId, "IX_region_supervisor_mapping_supervisorId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("regionId");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stateId");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supervisorId");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionSupervisorMappings)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_region_supervisor_mapping_Regions_regionId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.RegionSupervisorMappings)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.RegionSupervisorMappings)
                    .HasForeignKey(d => d.SupervisorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<RepReview>(entity =>
            {
                entity.ToTable("rep_reviews");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerStatus)
                    .HasMaxLength(30)
                    .HasColumnName("customer_status");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.ImageUploadStatus).HasColumnName("image_upload_status");

                entity.Property(e => e.LoanAllocationId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_allocation_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.OnboardingDate)
                    .HasColumnType("date")
                    .HasColumnName("onboarding_date");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.RepRating).HasColumnName("rep_rating");

                entity.Property(e => e.ReviewType)
                    .HasColumnType("set('sales','service')")
                    .HasColumnName("review_type")
                    .HasDefaultValueSql("'sales'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ReportCategory).HasColumnType("int(11)");

                entity.Property(e => e.ReportCode).HasColumnType("text");

                entity.Property(e => e.ReportName).HasColumnType("text");

                entity.Property(e => e.ReportPermissionCode).HasColumnType("text");

                entity.Property(e => e.ReportQuery).HasColumnType("text");

                entity.Property(e => e.ReportType).HasColumnType("int(11)");

                entity.Property(e => e.ReportUrl).HasColumnType("text");
            });

            modelBuilder.Entity<Reportcategory>(entity =>
            {
                entity.ToTable("reportcategory");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CategoryName).HasColumnType("text");

                entity.Property(e => e.CategoryPermissionCode).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Reporter>(entity =>
            {
                entity.ToTable("reporters");

                entity.HasIndex(e => e.Namespace, "namespace_2")
                    .IsUnique();

                entity.HasIndex(e => e.Namespace, "namespace_3");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllstepsDaily)
                    .HasColumnType("text")
                    .HasColumnName("allsteps_daily");

                entity.Property(e => e.AllstepsMonthly)
                    .HasColumnType("text")
                    .HasColumnName("allsteps_monthly");

                entity.Property(e => e.AllstepsWeekly)
                    .HasColumnType("text")
                    .HasColumnName("allsteps_weekly");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.Emails)
                    .HasColumnType("text")
                    .HasColumnName("emails");

                entity.Property(e => e.Namespace)
                    .HasMaxLength(50)
                    .HasColumnName("namespace");

                entity.Property(e => e.ReviewDaily)
                    .IsRequired()
                    .HasColumnName("review_daily")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ReviewMonthly)
                    .IsRequired()
                    .HasColumnName("review_monthly")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ReviewWeekly)
                    .IsRequired()
                    .HasColumnName("review_weekly")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReportingLog>(entity =>
            {
                entity.ToTable("reporting_logs");

                entity.HasIndex(e => e.Namespace, "namespace");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnType("set('no','yes')")
                    .HasColumnName("completed")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.Emails)
                    .HasColumnType("text")
                    .HasColumnName("emails");

                entity.Property(e => e.Namespace)
                    .HasMaxLength(50)
                    .HasColumnName("namespace");

                entity.Property(e => e.ProcessEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("process_end");

                entity.Property(e => e.ProcessStart)
                    .HasColumnType("datetime")
                    .HasColumnName("process_start");

                entity.Property(e => e.ReviewEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("review_end");

                entity.Property(e => e.ReviewStart)
                    .HasColumnType("datetime")
                    .HasColumnName("review_start");

                entity.Property(e => e.ReviewType)
                    .HasMaxLength(10)
                    .HasColumnName("review_type");

                entity.Property(e => e.SentOn)
                    .HasColumnType("datetime")
                    .HasColumnName("sent_on");

                entity.Property(e => e.SentStatus).HasColumnName("sent_status");

                entity.Property(e => e.Steps)
                    .HasColumnType("text")
                    .HasColumnName("steps");

                entity.Property(e => e.StepsDone)
                    .HasColumnType("text")
                    .HasColumnName("steps_done");
            });

            modelBuilder.Entity<Reportparameter>(entity =>
            {
                entity.ToTable("reportparameters");

                entity.HasIndex(e => e.ReportId, "IX_ReportParameters_ReportId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.FieldName).HasColumnType("text");

                entity.Property(e => e.FieldType).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnType("int(11)");

                entity.Property(e => e.SelectAction).HasColumnType("text");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Reportparameters)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_ReportParameters_Report_ReportId");
            });

            modelBuilder.Entity<Reportpermission>(entity =>
            {
                entity.ToTable("reportpermissions");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Section).HasColumnType("text");
            });

            modelBuilder.Entity<Reporttype>(entity =>
            {
                entity.ToTable("reporttype");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<RetailStore>(entity =>
            {
                entity.ToTable("retail_stores");

                entity.HasIndex(e => e.ClustersId, "IX_retail_stores_ClustersId");

                entity.HasIndex(e => e.RegionId, "IX_retail_stores_RegionId");

                entity.HasIndex(e => e.SubRegionId, "IX_retail_stores_SubRegionId");

                entity.HasIndex(e => e.CompanyId, "company_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BankAcc)
                    .HasMaxLength(20)
                    .HasColumnName("bank_acc");

                entity.Property(e => e.BankAccName)
                    .HasMaxLength(100)
                    .HasColumnName("bank_acc_name");

                entity.Property(e => e.BankName)
                    .HasColumnType("text")
                    .HasColumnName("bank_name");

                entity.Property(e => e.Category)
                    .HasColumnType("text")
                    .HasColumnName("category");

                entity.Property(e => e.ClustersId).HasColumnType("int(11)");

                entity.Property(e => e.CommissionRate).HasColumnName("commission_rate");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(500)
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactName)
                    .HasColumnType("text")
                    .HasColumnName("contact_name");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.Countrycode)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("countrycode")
                    .HasDefaultValueSql("'234'");

                entity.Property(e => e.DistributorCode)
                    .HasColumnType("text")
                    .HasColumnName("distributor_code");

                entity.Property(e => e.LgaId).HasColumnType("int(11)");

                entity.Property(e => e.LocationLat)
                    .HasColumnType("text")
                    .HasColumnName("location_lat");

                entity.Property(e => e.LocationLong)
                    .HasColumnType("text")
                    .HasColumnName("location_long");

                entity.Property(e => e.Otp)
                    .HasColumnType("text")
                    .HasColumnName("otp");

                entity.Property(e => e.Password)
                    .HasColumnType("text")
                    .HasColumnName("password");

                entity.Property(e => e.RegionId).HasColumnType("int(11)");

                entity.Property(e => e.RepCount)
                    .HasColumnType("mediumint(5)")
                    .HasColumnName("rep_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Role).HasColumnType("text");

                entity.Property(e => e.StateId).HasColumnType("int(11)");

                entity.Property(e => e.StoreAddress)
                    .HasColumnType("text")
                    .HasColumnName("store_address");

                entity.Property(e => e.StoreName)
                    .HasColumnType("text")
                    .HasColumnName("store_name");

                entity.Property(e => e.SubRegionId).HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .HasColumnType("text")
                    .HasColumnName("username");

                entity.HasOne(d => d.Clusters)
                    .WithMany(p => p.RetailStores)
                    .HasForeignKey(d => d.ClustersId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RetailStores)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("retail_stores_ibfk_1");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RetailStores)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_retail_stores_Regions_RegionId");

                entity.HasOne(d => d.SubRegion)
                    .WithMany(p => p.RetailStores)
                    .HasForeignKey(d => d.SubRegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_retail_stores_SubRegions_SubRegionId");
            });

            modelBuilder.Entity<RetailStoreUser>(entity =>
            {
                entity.ToTable("retail_store_users");

                entity.HasIndex(e => e.UserId, "IX_retail_store_users_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RetailStoreId)
                    .HasColumnType("int(10)")
                    .HasColumnName("retail_store_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<RoleAcl>(entity =>
            {
                entity.ToTable("role_acls");

                entity.HasIndex(e => e.Role, "role")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CanAdd).HasColumnName("can_add");

                entity.Property(e => e.CanDelete).HasColumnName("can_delete");

                entity.Property(e => e.CanEdit).HasColumnName("can_edit");

                entity.Property(e => e.CanView).HasColumnName("can_view");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Ctrl)
                    .HasMaxLength(50)
                    .HasColumnName("ctrl");

                entity.Property(e => e.CtrlMethod)
                    .HasMaxLength(50)
                    .HasColumnName("ctrl_method");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Role)
                    .HasMaxLength(30)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Rolepermission>(entity =>
            {
                entity.ToTable("rolepermissions");

                entity.HasIndex(e => e.PermissionId, "IX_RolePermissions_PermissionId");

                entity.HasIndex(e => new { e.UserRoleId, e.PermissionId }, "IX_RolePermissions_UserRoleId_PermissionId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.PermissionId).HasColumnType("int(11)");

                entity.Property(e => e.UserRoleId).HasColumnType("int(11)");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.Rolepermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_RolePermissions_Permissions_PermissionId");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Rolepermissions)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_RolePermissions_user_roles_UserRoleId");
            });

            modelBuilder.Entity<Rpfsrfilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rpfsrfilter");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(30);
            });

            modelBuilder.Entity<SaleLog>(entity =>
            {
                entity.ToTable("sale_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_id");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.ReceiptUrl)
                    .HasColumnType("text")
                    .HasColumnName("receipt_url");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(10)")
                    .HasColumnName("rep_id");
            });

            modelBuilder.Entity<Scheduledreport>(entity =>
            {
                entity.ToTable("scheduledreport");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.CopyRecipient).HasColumnType("text");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Reciever).HasColumnType("text");

                entity.Property(e => e.ReportCode).HasColumnType("text");

                entity.Property(e => e.ReportMode).HasColumnType("text");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Settlementlog>(entity =>
            {
                entity.ToTable("settlementlogs");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.BatchNo).HasColumnType("text");

                entity.Property(e => e.DateProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUploaded).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasColumnType("text");

                entity.Property(e => e.ItemCount).HasColumnType("int(11)");

                entity.Property(e => e.ProcessedBy).HasColumnType("text");

                entity.Property(e => e.UploadedBy).HasColumnType("text");

                entity.Property(e => e.UserId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Settlementlogitem>(entity =>
            {
                entity.ToTable("settlementlogitems");

                entity.HasIndex(e => e.SettlementLogId, "IX_SettlementLogItems_SettlementLogId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Financier).HasColumnType("text");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.MssIdn).HasColumnType("text");

                entity.Property(e => e.RepayDate).HasColumnType("datetime");

                entity.Property(e => e.SettlementLogId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.SettlementLog)
                    .WithMany(p => p.Settlementlogitems)
                    .HasForeignKey(d => d.SettlementLogId)
                    .HasConstraintName("FK_SettlementLogItems_SettlementLogs_SettlementLogId");
            });

            modelBuilder.Entity<SimRegister>(entity =>
            {
                entity.ToTable("sim_registers");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.Msisdn, "msisdn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_date");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrentDeviceId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_device_id");

                entity.Property(e => e.CurrentLoanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_loan_id");

                entity.Property(e => e.CurrentPlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("current_plan_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.LoginStatus).HasColumnName("login_status");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(20)
                    .HasColumnName("msisdn");

                entity.Property(e => e.OnboardDate)
                    .HasColumnType("datetime")
                    .HasColumnName("onboard_date");

                entity.Property(e => e.Otp)
                    .HasMaxLength(20)
                    .HasColumnName("otp");

                entity.Property(e => e.Pin)
                    .HasMaxLength(255)
                    .HasColumnName("pin");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status");

                entity.Property(e => e.TelcoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("telco_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SimRegisters)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sim_registers_ibfk_2");
            });

            modelBuilder.Entity<Staffrechargelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("staffrechargelist");

                entity.HasIndex(e => e.UserId, "UserID")
                    .IsUnique();

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IsTreated).HasColumnType("int(11)");

                entity.Property(e => e.Network).HasMaxLength(100);

                entity.Property(e => e.OperatorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OperatorID");

                entity.Property(e => e.PhoneNo).HasColumnType("bigint(20)");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Stanbicloanlog>(entity =>
            {
                entity.ToTable("stanbicloanlogs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.Mssidn).HasColumnType("text");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.RequestTimestamp).HasColumnType("datetime");

                entity.Property(e => e.SalesRepId).HasColumnType("int(11)");

                entity.Property(e => e.WebhookResponseTimestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("states");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(100)
                    .HasColumnName("state_name");
            });

            modelBuilder.Entity<Statelog>(entity =>
            {
                entity.ToTable("statelogs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Financier).HasColumnName("financier");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.PrecustomerId).HasColumnType("int(11)");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<Subledgertransaction>(entity =>
            {
                entity.ToTable("subledgertransactions");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.FinancierId).HasColumnType("int(11)");

                entity.Property(e => e.LedgerTransactionId).HasColumnType("int(11)");

                entity.Property(e => e.LoanAccountNo).HasColumnType("text");

                entity.Property(e => e.RefNo).HasColumnType("text");

                entity.Property(e => e.SystemComment).HasColumnType("text");
            });

            modelBuilder.Entity<Subloan>(entity =>
            {
                entity.ToTable("subloans");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FinancierCode).HasColumnType("text");

                entity.Property(e => e.FinancierId).HasColumnType("int(11)");

                entity.Property(e => e.InterestAmt).HasColumnName("interest_amt");

                entity.Property(e => e.LoanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_id");

                entity.Property(e => e.Shareamt).HasColumnName("shareamt");
            });

            modelBuilder.Entity<Subregion>(entity =>
            {
                entity.ToTable("subregions");

                entity.HasIndex(e => e.RegionId, "IX_SubRegions_RegionId");

                entity.HasIndex(e => e.UserId, "IX_SubRegions_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.RegionId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Subregions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubRegions_Regions_RegionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subregions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubRegions_users_UserId");
            });

            modelBuilder.Entity<Telco>(entity =>
            {
                entity.ToTable("telcos");

                entity.HasIndex(e => e.CompanyId, "company_id");

                entity.HasIndex(e => e.CompanyId, "company_id_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.PlanCount)
                    .HasColumnType("int(10)")
                    .HasColumnName("plan_count");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.Telco)
                    .HasForeignKey<Telco>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("telcos_ibfk_1");
            });

            modelBuilder.Entity<TelcoBundle>(entity =>
            {
                entity.ToTable("telco_bundles");

                entity.HasIndex(e => e.BundleName, "bundle_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BundleName)
                    .HasMaxLength(100)
                    .HasColumnName("bundle_name");

                entity.Property(e => e.TelcoBundleCode)
                    .HasMaxLength(20)
                    .HasColumnName("telco_bundle_code");

                entity.Property(e => e.TelcoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("telco_id");

                entity.Property(e => e.TenureMonths)
                    .HasColumnType("smallint(2)")
                    .HasColumnName("tenure_months")
                    .HasDefaultValueSql("'12'");
            });

            modelBuilder.Entity<Telcoreport>(entity =>
            {
                entity.ToTable("telcoreports");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Df)
                    .HasColumnType("int(11)")
                    .HasColumnName("DF");

                entity.Property(e => e.Dh)
                    .HasColumnType("int(11)")
                    .HasColumnName("DH");

                entity.Property(e => e.Mdf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("MDF");

                entity.Property(e => e.Mdr)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("MDR");

                entity.Property(e => e.Renewals).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("tickets");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.HasIndex(e => e.RepId, "rep_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerMsisdn)
                    .HasMaxLength(20)
                    .HasColumnName("customer_msisdn");

                entity.Property(e => e.Discussion)
                    .HasColumnType("int(10)")
                    .HasColumnName("discussion");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Priority)
                    .HasMaxLength(5)
                    .HasColumnName("priority");

                entity.Property(e => e.RepId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rep_id");

                entity.Property(e => e.Replyto)
                    .HasColumnType("int(10)")
                    .HasColumnName("replyto");

                entity.Property(e => e.Sender)
                    .HasMaxLength(10)
                    .HasColumnName("sender");

                entity.Property(e => e.ServiceRating)
                    .HasMaxLength(10)
                    .HasColumnName("service_rating");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tickets_ibfk_1");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.RepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tickets_ibfk_2");
            });

            modelBuilder.Entity<Toc>(entity =>
            {
                entity.ToTable("toc");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.Created).HasMaxLength(6);

                entity.Property(e => e.Financier)
                    .HasMaxLength(245)
                    .HasColumnName("financier");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.CompanyId, "IX_users_company_id");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "phone")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivatePass)
                    .HasColumnType("text")
                    .HasColumnName("activate_pass");

                entity.Property(e => e.Activated)
                    .HasColumnName("activated")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ActivationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("activation_dt");

                entity.Property(e => e.Avatar)
                    .HasColumnType("text")
                    .HasColumnName("avatar");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fname)
                    .HasColumnType("text")
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasColumnType("text")
                    .HasColumnName("lname");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordHash).HasColumnType("text");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Pin)
                    .HasMaxLength(20)
                    .HasColumnName("pin");

                entity.Property(e => e.PwdHash)
                    .HasColumnType("text")
                    .HasColumnName("pwd_hash");

                entity.Property(e => e.PwdHashExpires)
                    .HasColumnType("datetime")
                    .HasColumnName("pwd_hash_expires");

                entity.Property(e => e.RepStatus).HasMaxLength(200);

                entity.Property(e => e.Role)
                    .HasMaxLength(30)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserLockedview>(entity =>
            {
                entity.ToTable("user_lockedviews");

                entity.HasIndex(e => e.UserId, "unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Acl)
                    .HasColumnType("set('excl','role')")
                    .HasColumnName("acl")
                    .HasDefaultValueSql("'role'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.ExclAcl)
                    .HasColumnType("text")
                    .HasColumnName("excl_acl");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RoleAcl)
                    .HasColumnType("text")
                    .HasColumnName("role_acl");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.ToTable("user_messages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Discussion)
                    .HasColumnType("int(10)")
                    .HasColumnName("discussion");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.IsSent).HasColumnName("is_sent");

                entity.Property(e => e.IsTrashed).HasColumnName("is_trashed");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Recipient)
                    .HasColumnType("int(10)")
                    .HasColumnName("recipient");

                entity.Property(e => e.Replyto)
                    .HasColumnType("int(10)")
                    .HasColumnName("replyto");

                entity.Property(e => e.Sender)
                    .HasColumnType("int(10)")
                    .HasColumnName("sender");

                entity.Property(e => e.Sendtag)
                    .HasMaxLength(20)
                    .HasColumnName("sendtag");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<UserPost>(entity =>
            {
                entity.ToTable("user_posts");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivityRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("activity_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attachments)
                    .HasColumnType("text")
                    .HasColumnName("attachments");

                entity.Property(e => e.ChannelOnly).HasColumnName("channel_only");

                entity.Property(e => e.CommChannelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("comm_channel_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DeviceRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("device_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DumpRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("dump_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LenderRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("lender_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Replyto)
                    .HasColumnType("int(11)")
                    .HasColumnName("replyto");

                entity.Property(e => e.TaskRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("task_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TelcoRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Thread)
                    .HasColumnType("int(11)")
                    .HasColumnName("thread");

                entity.Property(e => e.TicketRef)
                    .HasColumnType("int(10)")
                    .HasColumnName("ticket_ref")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'crm'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_roles");

                entity.HasIndex(e => e.Tagname, "tagname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Tagname)
                    .HasMaxLength(30)
                    .HasColumnName("tagname");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<UserRoleMap>(entity =>
            {
                entity.ToTable("user_role_maps");

                entity.HasIndex(e => new { e.Section, e.Action }, "acl_node")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(30)
                    .HasColumnName("action");

                entity.Property(e => e.Customerserv1).HasColumnName("customerserv1");

                entity.Property(e => e.Customerserv2).HasColumnName("customerserv2");

                entity.Property(e => e.External2distro).HasColumnName("external2distro");

                entity.Property(e => e.External2lender).HasColumnName("external2lender");

                entity.Property(e => e.External2mno).HasColumnName("external2mno");

                entity.Property(e => e.External2oem).HasColumnName("external2oem");

                entity.Property(e => e.Externalexec1).HasColumnName("externalexec1");

                entity.Property(e => e.Internalexec1).HasColumnName("internalexec1");

                entity.Property(e => e.Inventorymgr1).HasColumnName("inventorymgr1");

                entity.Property(e => e.Salesexec1).HasColumnName("salesexec1");

                entity.Property(e => e.Salessuper).HasColumnName("salessuper");

                entity.Property(e => e.Section)
                    .HasMaxLength(30)
                    .HasColumnName("section");

                entity.Property(e => e.Special1sa).HasColumnName("special1sa");

                entity.Property(e => e.Special2bi).HasColumnName("special2bi");

                entity.Property(e => e.Superadmin).HasColumnName("superadmin");
            });

            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.ToTable("userinfos");

                entity.HasIndex(e => e.UsersId, "IX_UserInfos_UsersId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InputName).HasColumnType("text");

                entity.Property(e => e.InputValue).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.UsersId).HasColumnType("int(11)");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Userinfos)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserInfos_users_UsersId");
            });

            modelBuilder.Entity<Utility>(entity =>
            {
                entity.ToTable("utilities");

                entity.HasIndex(e => new { e.Type, e.Attr }, "uniqvar")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Attr)
                    .HasMaxLength(100)
                    .HasColumnName("attr");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Val)
                    .HasColumnType("text")
                    .HasColumnName("val");
            });

            modelBuilder.Entity<ValueInfo>(entity =>
            {
                entity.ToTable("value_infos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.KeyId)
                    .HasColumnType("text")
                    .HasColumnName("key_id");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<VtuPlan>(entity =>
            {
                entity.ToTable("vtu_plans");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("int(10)")
                    .HasColumnName("currency_id");

                entity.Property(e => e.DataQty)
                    .HasMaxLength(20)
                    .HasColumnName("data_qty");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(4)")
                    .HasColumnName("duration");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.SmsQty)
                    .HasMaxLength(20)
                    .HasColumnName("sms_qty");

                entity.Property(e => e.TelcoId)
                    .HasColumnType("int(10)")
                    .HasColumnName("telco_id");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");

                entity.Property(e => e.VoiceMinutes)
                    .HasMaxLength(20)
                    .HasColumnName("voice_minutes");
            });

            modelBuilder.Entity<VtuRenewalHistory>(entity =>
            {
                entity.ToTable("vtu_renewal_history");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActualDate)
                    .HasColumnType("date")
                    .HasColumnName("actual_date");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.RenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("renewal_date");

                entity.Property(e => e.RenewalStatus).HasColumnName("renewal_status");

                entity.Property(e => e.VtuPlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("vtu_plan_id");
            });

            modelBuilder.Entity<VtuSchedule>(entity =>
            {
                entity.ToTable("vtu_schedules");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.NoOfPendingRenewals)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("no_of_pending_renewals");

                entity.Property(e => e.RenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("renewal_date");

                entity.Property(e => e.VtuPlanId)
                    .HasColumnType("int(10)")
                    .HasColumnName("vtu_plan_id");
            });

            modelBuilder.Entity<Vwbvndetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwbvndetails");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(11)
                    .HasColumnName("bvn");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PreCustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pre_customer_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Vwcustomerrenewalsmtn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwcustomerrenewalsmtn");

                entity.Property(e => e.ChargingAmount)
                    .HasPrecision(8)
                    .HasColumnName("charging_amount");

                entity.Property(e => e.MaxRenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("max_renewal_date");

                entity.Property(e => e.MinRenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("min_renewal_date");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(50)
                    .HasColumnName("msisdn");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.Repaymentcount)
                    .HasColumnType("bigint(21)")
                    .HasColumnName("repaymentcount");
            });

            modelBuilder.Entity<Vwcustomerrenewalsmtnjan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwcustomerrenewalsmtnjan");

                entity.Property(e => e.ChargingAmount)
                    .HasPrecision(8)
                    .HasColumnName("charging_amount");

                entity.Property(e => e.MaxRenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("max_renewal_date");

                entity.Property(e => e.MinRenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("min_renewal_date");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(50)
                    .HasColumnName("msisdn");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.Repaymentcount)
                    .HasColumnType("bigint(21)")
                    .HasColumnName("repaymentcount");
            });

            modelBuilder.Entity<Vwmtnactivesubscription20230305>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwmtnactivesubscription20230305");

                entity.Property(e => e.Bundle).HasMaxLength(200);

                entity.Property(e => e.Channel).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Msisdn).HasMaxLength(50);
            });

            modelBuilder.Entity<Vwrepaymenthistorydetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwrepaymenthistorydetail");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("date")
                    .HasColumnName("activation_date");

                entity.Property(e => e.AmtPaid).HasColumnName("amt_paid");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Historycount)
                    .HasColumnType("bigint(21)")
                    .HasColumnName("historycount");

                entity.Property(e => e.MaxExtensionDate)
                    .HasColumnType("date")
                    .HasColumnName("max_extension_date");

                entity.Property(e => e.MaxRenewalDate)
                    .HasColumnType("date")
                    .HasColumnName("max_renewal_date");

                entity.Property(e => e.MinExtensionDate)
                    .HasColumnType("date")
                    .HasColumnName("min_extension_date");
            });

            modelBuilder.Entity<Vwrolepermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwrolepermission");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Permission)
                    .HasMaxLength(767)
                    .HasColumnName("permission");

                entity.Property(e => e.Role)
                    .HasMaxLength(30)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Workflowapprovalgroup>(entity =>
            {
                entity.ToTable("workflowapprovalgroups");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasColumnType("text");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Workflowapprovalusergroup>(entity =>
            {
                entity.ToTable("workflowapprovalusergroups");

                entity.HasIndex(e => e.ApprovalGroupId, "IX_WorkFlowApprovalUserGroups_ApprovalGroupId");

                entity.HasIndex(e => e.UserId, "IX_WorkFlowApprovalUserGroups_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApprovalGroupId).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.HasOne(d => d.ApprovalGroup)
                    .WithMany(p => p.Workflowapprovalusergroups)
                    .HasForeignKey(d => d.ApprovalGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkFlowApprovalUserGroups_WorkFlowApprovalGroups_ApprovalGr~");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Workflowapprovalusergroups)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WorkFlowApprovalUserGroups_users_UserId");
            });

            modelBuilder.Entity<Workflowdefinition>(entity =>
            {
                entity.ToTable("workflowdefinitions");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<Workflowstepdefinition>(entity =>
            {
                entity.ToTable("workflowstepdefinitions");

                entity.HasIndex(e => e.ApprovalUserGroupId, "IX_WorkFlowStepDefinitions_ApprovalUserGroupId");

                entity.HasIndex(e => e.WorkFlowDefinitionId, "IX_WorkFlowStepDefinitions_WorkFlowDefinitionId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApprovalUserGroupId).HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.NextStepId).HasColumnType("int(11)");

                entity.Property(e => e.StepName).HasColumnType("text");

                entity.Property(e => e.WorkFlowDefinitionId).HasColumnType("int(11)");

                entity.HasOne(d => d.ApprovalUserGroup)
                    .WithMany(p => p.Workflowstepdefinitions)
                    .HasForeignKey(d => d.ApprovalUserGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkFlowStepDefinitions_WorkFlowApprovalUserGroups_ApprovalU~");

                entity.HasOne(d => d.WorkFlowDefinition)
                    .WithMany(p => p.Workflowstepdefinitions)
                    .HasForeignKey(d => d.WorkFlowDefinitionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkFlowStepDefinitions_WorkFlowDefinitions_WorkFlowDefiniti~");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
