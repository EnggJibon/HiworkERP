using HiWork.BLL.Services;
using HiWork.DAL.Repositories;
using HiWork.Utils.Infrastructure;
using HiWork.Utils.Infrastructure.Contract;
using Microsoft.Practices.Unity;

namespace HiWork.BLL.IOC
{
    public partial class DependencyInjector
    {
        public static void Inject(UnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUserTypeRepository, UserTypeRepository>();
            container.RegisterType<IUserTypeService, UserTypeService>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<ICultureRepository, CultureRepository>();
            container.RegisterType<ICultureService, CultureService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IBankService, BankService>();
            container.RegisterType<IBankRepository, BankRepository>();
            container.RegisterType<ILanguageQualificationService, LanguageQualificationService>();
            container.RegisterType<ILanguageQualificationRepository, LanguageQualificationRepository>();
            container.RegisterType<ITechnicalSkillCategoryService, TechnicalSkillCategoryService>();
            container.RegisterType<ITechnicalSkillCategoryRepository, TechnicalSkillCategoryRepository>();
            container.RegisterType<ITechnicalSkillItemsService, TechnicalSkillItemsService>();
            container.RegisterType<ITechnicalSkillItemsRepository, TechnicalSkillItemsRepository>();
            container.RegisterType<ITeamService, TeamService>();
            container.RegisterType<ITeamRepository, TeamRepository>();
            container.RegisterType<IDivisionService, DivisionService>();
            container.RegisterType<IDivisionRepository, DivisionRepository>();
            container.RegisterType<IBankBranchService, BankBranchSerivce>();
            container.RegisterType<IBankBranchRepository, BankBranchRepository>();
            container.RegisterType<IBankAccountService, BankAccountService>();
            container.RegisterType<IBankAccountRepository, BankAccountRepository>();
            container.RegisterType<ICountryService, CountryService>();
            container.RegisterType<ICountryRepository, CountryRepository>();
            container.RegisterType<IBranchService, BranchService>();
            container.RegisterType<IBranchRepository, BranchRepository>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IDesignationService, DesignationService>();
            container.RegisterType<IDesignationRepository, DesignationRepository>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IInterpretationFieldsService, InterpretationFieldsService>();      
            container.RegisterType<IInterpretationFieldsRepository, InterpretationFieldsRepository>();
            container.RegisterType<IVisaTypeService, VisaTypeService>();
            container.RegisterType<IVisaTypeRepository, VisaTypeRepository>();
            container.RegisterType<IProfessionService, ProfessionService>();
            container.RegisterType<IProfessionRepository, ProfessionRepository>();
            container.RegisterType<IJobCategoryService, JobCategoryService>();
            container.RegisterType<IJobCategoryRepository, JobCategoryRepository>();
            container.RegisterType<IJobCategoryDetailsService, JobCategoryDetailsService>();
            container.RegisterType<IJobCategoryDetailsRepository, JobCategoryDetailsRepository>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ILanguageService, LanguageService>();
            container.RegisterType<ILanguageRepository, LanguageRepository>();
            container.RegisterType<IEstimationTypeRepository, EstimationTypeRepository>();
            container.RegisterType<IEstimationTypeService, EstimationTypeService>();
            container.RegisterType<IStaffTranslationFieldsRepository, StaffTranslationFieldsRepository>();
            container.RegisterType<IStaffTranslationFieldsService, StaffTranslationFieldsService>();
            container.RegisterType<IMajorSubjectRepository, MajorSubjectRepository>();
            container.RegisterType<IMajorSubjectService, MajorSubjectService>();
            container.RegisterType<IMajorSubjectDetailsRepository, MajorSubjectDetailsRepository>();
            container.RegisterType<IMajorSubjectDetailsService, MajorSubjectDetailsService>();
            container.RegisterType<IEmploymentTypeService, EmploymentTypeService>();
            container.RegisterType<IEmploymentTypeRepository, EmploymentTypeRepository>();
            container.RegisterType<IStaffTypeService, StaffTypeService>();
            container.RegisterType<IStaffTypeRepository, StaffTypeRepository>();
            container.RegisterType<IEstimationRoutesRepository, EstimationRoutesRepository>();
            container.RegisterType<IEstimationRoutesService, EstimationRoutesService>();
            container.RegisterType<IEstimationServiceTypeRepository, EstimationServiceTypeRepository>();
            container.RegisterType<IEstimationServiceTypeService, EstimationServiceTypeService>();
            container.RegisterType<ICompanyRepository, CompanyRepository>();
            container.RegisterType<ICompanyService, CompanyService>();
            container.RegisterType<IEstimationSpecializedFieldRepository, EstimationSpecializedFieldRepository>();
            container.RegisterType<IEstimationSpecializedFieldService, EstimationSpecializedFieldService>();
            container.RegisterType<ICompanyTradingCategoryRepository, CompanyTradingCategoryRepository>();
            container.RegisterType<ICompanyTradingCategoryService, CompanyTradingCategoryService>();
            container.RegisterType<ICompanyIndustryClassificationRepository, CompanyIndustryClassificationRepository>();
            container.RegisterType<ICompanyIndustryClassificationService, CompanyIndustryClassificationService>();
            container.RegisterType<ICompanyIndustryClassificationItemRepository, CompanyIndustryClassificationItemRepository>();
            container.RegisterType<ICompanyIndustryClassificationItemService, CompanyIndustryClassificationItemService>();
            container.RegisterType<ICompanyTradingCategoryItemRepository, CompanyTradingCategoryItemRepository>();
            container.RegisterType<ICompanyTradingCategoryItemService, CompanyTradingCategoryItemService>();
            container.RegisterType<ICompanyBusinessService, CompanyBusinessService>();
            container.RegisterType<ICompanyBusinessSpecialityService, CompanyBusinessSpecialityService>();
            container.RegisterType<ICompanyTradingDivisionRepository, CompanyTradingDivisionRepository>();
            container.RegisterType<ICompanyTradingDivisionService, CompanyTradingDivisionService>();
            container.RegisterType<IUnitRepository, UnitRepository>();
            container.RegisterType<IUnitService, UnitService>();
            container.RegisterType<IAgentBusinessService, AgentBusinessService>();
            container.RegisterType<IAgentCharactersticsService, AgentCharactersticsService>();
            container.RegisterType<IAgentFreeDesignationService, AgentFreeDesignationService>();
            container.RegisterType<IEstimationService, EstimationService>();
            container.RegisterType<IEstimationRepository, EstimationRepository>();
            container.RegisterType<IApplicationRepository, ApplicationRepository>();
            container.RegisterType<IApplicationService, ApplicationService>();
            container.RegisterType<IJobHistoryRepository, JobHistoryRepository>();
            container.RegisterType<IJobHistoryService, JobHistoryService>();
            container.RegisterType<IStaffBankAccountInfoRepository, StaffBankAccountInfoRepository>();
            container.RegisterType<IStaffBankAccountInfoService, StaffBankAccountInfoService>();
            container.RegisterType<IUserInfoRepository, UserInfoRepository>();
            container.RegisterType<IUserInfoService, UserInfoService>();
            container.RegisterType<IStaffDevelopmentSkillRepository, StaffDevelopmentSkillRepository>();
            container.RegisterType<IStaffDevelopmentSkillService, StaffDevelopmentSkillService>();
            container.RegisterType<IStaffDevelopmentSkillItemRepository, StaffDevelopmentSkillItemRepository>();
            container.RegisterType<IStaffDevelopmentSkillItemService, StaffDevelopmentSkillItemService>();
            container.RegisterType<IStaffKnowledgeFieldRepository, StaffKnowledgeFieldRepository>();
            container.RegisterType<IStaffKnowledgeFieldService, StaffKnowledgeFieldService>();
            container.RegisterType<IStaffKnowledgeFieldItemRepository, StaffKnowledgeFieldItemRepository>();
            container.RegisterType<IStaffKnowledgeFieldItemService, StaffKnowledgeFieldItemService>();
            container.RegisterType<IStaffMedicalFieldRepository, StaffMedicalFieldRepository>();
            container.RegisterType<IStaffMedicalFieldService, StaffMedicalFieldService>();
            container.RegisterType<IStaffPatentFieldRepository, StaffPatentFieldRepository>();
            container.RegisterType<IStaffPatentFieldService, StaffPatentFieldService>();
            container.RegisterType<IEstimationSubSpecializedFieldRepository, EstimationSubSpecializedFieldRepository>();
            container.RegisterType<IEstimationSubSpecializedFieldService, EstimationSubSpecializedFieldService>();
            container.RegisterType<INarrationInformationRepository, NarrationInformationRepository>();
            container.RegisterType<INarrationInformationService, NarrationInformationService>();
            container.RegisterType<INarrationInformationRepository, NarrationInformationRepository>();
            container.RegisterType<INarrationInformationService, NarrationInformationService>();
            container.RegisterType<IStaffSpecialFieldRepository, StaffSpecialFieldRepository>();
            container.RegisterType<IStaffSpecialFieldService, StaffSpecialFieldService>();
            container.RegisterType<INarrationVoiceFilesService, NarrationVoiceFilesService>();
            container.RegisterType<IStaffTranslationSpecialFieldsRepository, StaffTranslationSpecialFieldsRepository>();
            container.RegisterType<IStaffTranslationSpecialFieldsService, StaffTranslationSpecialFieldsService>();
            container.RegisterType<ITranslateInterpretExperienceRepository, TranslateInterpretExperienceRepository>();
            container.RegisterType<ITranslateInterpretExperienceService, TranslateInterpretExperienceService>();
            container.RegisterType<ITransproInformationRepository, TransproInformationRepository>();
            container.RegisterType<ITransproInformationService, TransproInformationService>();
            container.RegisterType<IStaffNarrationTypeRepository, StaffNarrationTypeRepository>();
            container.RegisterType<IStaffNarrationTypeService, StaffNarrationTypeService>();
            container.RegisterType<ITaskQuotationService, TaskQuotationService>();
            container.RegisterType<IDTPEstimationService, DTPEstimationService>();
            container.RegisterType<ITranscriptionEstimationService, TranscriptionEstimationService>();
            container.RegisterType<IEstimationActionService, EstimationActionService>();
            container.RegisterType<IHiworkLanguagePriceRepository, HiworkLanguagePriceRepository>();
            container.RegisterType<IHiworkLanguagePriceService, HiworkLanguagePriceService>();
            container.RegisterType<IShortTermEstimationService, ShortTermEstimationService>();
            container.RegisterType<ITransproLanguagePriceService, TransproLanguagePriceService>();
            container.RegisterType<IUnitPriceRepository, UnitPriceRepository>();
            container.RegisterType<IUnitPriceService, UnitPriceService>();
            container.RegisterType<ITransproDeliveryPlanRepository, TransproDeliveryPlanRepository>();
            container.RegisterType<ITransproDeliveryPlanService, TransproDeliveryPlanService>();
            container.RegisterType<IOverheadCostQuotationService, OverheadCostQuotationService>();
            container.RegisterType<IOrderDetailsRepository, OrderDetailsRepository>();
            container.RegisterType<IOrderDetailsService, OrderDetailsService>();
            container.RegisterType<INarrationEstimationService, NarrationEstimationService>();
            container.RegisterType<ITransproService, TransproService>();
            container.RegisterType<IAdvancedStaffSearchService, AdvancedStaffSearchService>();
            container.RegisterType<IStaffProfessioanlSpecialityRepository, StaffProfessioanlSpecialityRepository>();
            container.RegisterType<IStaffProfessionalSpecialityService,StaffProfessionalSpecialityService>();
            container.RegisterType<IStaffCurrentStateRepository, StaffCurrentStateRepository>();
            container.RegisterType<IStaffCurrentStateService, StaffCurrentStateService>();
            container.RegisterType<IEmailTemplateRepository, EmailTemplateRepository>();
            container.RegisterType<IEmailTemplateService, EmailTemplateService>();
            container.RegisterType<IAccountingService, AccountingService>();
            container.RegisterType<INoticeRepository, NoticeRepository>();
            container.RegisterType<INoticeService, NoticeService>();
            container.RegisterType<IStaffListService, StaffListService>();
            container.RegisterType<IStaffService, StaffService>();
            container.RegisterType<IHomeApiService, HomeService>();
            container.RegisterType<IStaffRepository, StaffRepository>();
            container.RegisterType<IWorkingStatusRepository, WorkingStatusRepository>();
            container.RegisterType<IWorkingStatusService, WorkingStatusService>();
            container.RegisterType<IPartnerServiceTypeService, PartnerServiceTypeService>();
            container.RegisterType<IPartnerServiceTypeRepository, PartnerServiceTypeRepository>();
            container.RegisterType<INotificationService, NotificationService>();
            container.RegisterType<IErrorReportWebService, ErrorReportWebService>();
            container.RegisterType<IErrorReportWebRepository, ErrorReportWebRepository>();
            container.RegisterType<IEmailDeliverySettingsService, EmailDeliverySettingsService>();
            container.RegisterType<IEmailDeliverySettingsRepository, EmailDeliverySettingsRepository>();
            container.RegisterType<IMasterStaffSoftwareSkillService, MasterStaffSoftwareSkillService>();
            container.RegisterType<IMasterStaffSoftwareSkillRepository, MasterStaffSoftwareSkillRepository>();
            container.RegisterType<IEstimationInterpretationService, EstimationInterpretationService>();
            container.RegisterType<IMessageRepository, MessageRepository>();
            container.RegisterType<IMessageService, MessageService>();
            container.RegisterType<IContactUsService, ContactUsService>();
            container.RegisterType<IContactUsRepository, ContactUsRepository>();
            container.RegisterType<IStaffSoftwareService,StaffSoftwareSkillService>();
            container.RegisterType<IStaffSoftwareRepository,StaffSoftwareSkillRepository>();
            container.RegisterType<IAdvertizementSettingsService,AdvertizementSettingsService>();
            container.RegisterType<IAdvertizementSettingsRepository, AdvertizementSettingsRepository>();
            container.RegisterType<IOrderStaffAllowanceService, OrderStaffAllowanceService>();
            container.RegisterType<IOrderStaffAllowanceRepository, OrderStaffAllowanceRepository>();
            container.RegisterType<IDashboardSuperAdminService, DashboardSuperAdminService>();
            container.RegisterType<IEstimationRoleAccessService, EstimationRoleAccessService>();
            container.RegisterType<IpenaltyRepository, PenaltyRepository>();
            container.RegisterType<IPenaltyService, PenaltyService>();
        }
    }
}