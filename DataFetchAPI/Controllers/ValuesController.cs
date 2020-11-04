using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using DataFetchAPI.Utils;

namespace DataFetchAPI.Controllers
{
    //KERRA Datafetch API
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    [BasicAuthentication]
    public class ValuesController : ApiController
    {
        [Route("api/Values")]


        [HttpGet]
        [Route("api/GetPortalUsers")]
        public IHttpActionResult GetPortalUsers()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.PortalUsers.ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetAllVendors")]
        public IHttpActionResult GetAllVendors()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.eProVendorQT.ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetPortalContacts")]
        public IHttpActionResult GetPortalContacts()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.contacts.ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetPortalCustomers/{customerNo}")]
        public IHttpActionResult GetPortalCustomers(string customerNo)
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.Customers.Where(c=>c.No == customerNo).ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetCustomerbyId/{custNo}")]
        public IHttpActionResult GetCustomerbyId(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.Customers.ToList().Where(p => p.customer_No == custNo);
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetOpenRfQs")]
        public IHttpActionResult GetOpenRfQs()
        {
            var odataCon = DBConfig.ODataObj();
            var openrfqs = odataCon.ProcurementRequest.Where(r => r.Process_Type == "RFQ").ToList();
            return Json(openrfqs);
        }

        [HttpGet]
        [Route("api/GetOpenTenders")]
        public IHttpActionResult GetOpenTenders()
        {
            var odataCon = DBConfig.ODataObj();
            var openrfqs = odataCon.Tenders.Where(r => r.Process_Type == "Tender").ToList();
            return Json(openrfqs);
        }

        [HttpGet]
        [Route("api/GetTenderApplication/{vendorNo}")]
        public IHttpActionResult GetTenderApplication(string vendorNo)
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.TenderApps.Where(c => c.Vendor_No == vendorNo).ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetAllCustomers")]
        public IHttpActionResult GetAllCustomers()
        {
            var odataCon = DBConfig.ODataObj();
            var contacts = odataCon.contacts.ToList();
            return Json(contacts);
        }

        [HttpGet]
        [Route("api/GetTenderApplications")]
        public IHttpActionResult GetTenderApplications()
        {
            var odataCon = DBConfig.ODataObj();
            var tenders = odataCon.TenderApps.ToList();
            return Json(tenders);
        }

        [HttpGet]
        [Route("api/GetRfqApplications")]
        public IHttpActionResult GetRfqApplications()
        {
            var odataCon = DBConfig.ODataObj();
            var rfqs = odataCon.RFQApps.ToList();
            return Json(rfqs);
        }
        [HttpGet]
        [Route("api/GetAllPreQualifications")]
        public IHttpActionResult GetAllPreQualifications()
        {
            var odataCon = DBConfig.ODataObj();
            var rfqs = odataCon.PrequalifiedSuppliers.ToList();
            return Json(rfqs);
        }
        [HttpGet]
        [Route("api/GetAllBlogForums")]
        public IHttpActionResult GetAllBlogForums()
        {
            var odataCon = DBConfig.ODataObj();
            var blogs = odataCon.SupplierBlogs.ToList();
            return Json(blogs);
        }

        [HttpGet]
        [Route("api/GetAllBlogForumsReplies")]
        public IHttpActionResult GetAllBlogForumsReplies()
        {
            var odataCon = DBConfig.ODataObj();
            var blogs = odataCon.SupplierBlogReplies.ToList();
            return Json(blogs);
        }

        [HttpGet]
        [Route("api/GetPurchaseReqLines")]
        public IHttpActionResult GetPurchaseReqLines()
        {
            var odataCon = DBConfig.ODataObj();
            var prLs = odataCon.PurchaseReqLines.ToList();
            return Json(prLs);
        }

        [HttpGet]
        [Route("api/GetPrequalifiedSuppliers")]
        public IHttpActionResult GetPrequalifiedSuppliers()
        {
            var odataCon = DBConfig.ODataObj();
            var prLs = odataCon.PrequalifiedSuppliers.Where(p=>p.Pre_Qualified==true&&p.Selected==true).ToList();
            return Json(prLs);
        }
       
        [HttpGet]
        [Route("api/GetSupplierCategorization")]
        public IHttpActionResult GetSupplierCategorization()
        {
            var odataCon = DBConfig.ODataObj();
            var mySupplyCats = odataCon.SupplierCategories.ToList();
            return Json(mySupplyCats);
        }

        [HttpGet]
        [Route("api/GetPostalCodes")]
        public IHttpActionResult GetPostalCodes()
        {
            var odataCon = DBConfig.ODataObj();
            var myPostcode = odataCon.postcodes.ToList();
            return Json(myPostcode);
        }

        [HttpGet]
        [Route("api/GetCountry")]
        public IHttpActionResult GetCountry()
        {
            var odataCon = DBConfig.ODataObj();
            var myCountry = odataCon.myCountryList.ToList();
            return Json(myCountry);
        }

        [HttpGet]
        [Route("api/GetSupplierCat")]
        public IHttpActionResult GetSupplierCat()
        {
            var odataCon = DBConfig.ODataObj();
            var mySupplyCats = odataCon.SupplierCategories.ToList();
            return Json(mySupplyCats);
        }
       
        [HttpGet]
        [Route("api/GetPostaCodes")]
        public IHttpActionResult GetPostaCodes()
        {
            var odataCon = DBConfig.ODataObj();
            var myPostcode = odataCon.postcodes.ToList();
            return Json(myPostcode);
        }

        [HttpGet]
        [Route("api/GetSupplierCatgry")]
        public IHttpActionResult GetSupplierCatgry()
        {
            var odataCon = DBConfig.ODataObj();
            var supplierlines = odataCon.SupplyCategoryHeader.ToList();
            return Json(supplierlines);
        }

        [HttpGet]
        [Route("api/GetFiscalYear")]
        public IHttpActionResult GetFiscalYear()
        {
            var odataCon = DBConfig.ODataObj();
            var myYears = odataCon.FiscalYears.ToList();
            return Json(myYears);
        }

        [HttpGet]
        [Route("api/GetAdds")]
        public IHttpActionResult GetAdds()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.AdsNotices.ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetIfPs")]
        public IHttpActionResult GetIfPs()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.IFPRequests.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetDocumentsTemplates")]
        public IHttpActionResult GetDocumentsTemplates()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.eProcDocuments.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetBusinessTypes")]
        public IHttpActionResult GetBusinessTypes()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.businessTypes.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetIndustryGroups")]
        public IHttpActionResult GetIndustryGroups()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.IndustryGroup.ToList();
            return Json(myIfps);
        }
        [HttpGet]
        [Route("api/GetVenderPreferences")]
        public IHttpActionResult GetVenderPreferences()
        {
            var odataCon = DBConfig.ODataObj();
            var vendeopreference= odataCon.BidReferencePreference.ToList();
            return Json(vendeopreference);
        }
        [HttpGet]
        [Route("api/GetCompanySize")]
        public IHttpActionResult GetCompanySize()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.companySizes.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetLanguageCode")]
        public IHttpActionResult GetLanguageCode()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.LanguageCode.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetSpecialGroupes")]
        public IHttpActionResult GetSpecialGroupes()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.SpecialCatGroups.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetBalanceSheet")]
        public IHttpActionResult GetBalanceSheet()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.vendorBalancesheet.ToList();
            return Json(myIfps);
        }
        [HttpGet]
        [Route("api/GetIncomeStatememt")]
        public IHttpActionResult GetIncomeStatememt()
        {
            var odataCon = DBConfig.ODataObj();
            var myIfps = odataCon.vendorIncomestatement.ToList();
            return Json(myIfps);
        }

        [HttpGet]
        [Route("api/GetRfiPrequalification")]
        public IHttpActionResult GetRfiPrequalification()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.RFIPreqList.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetRfiDocs")]
        public IHttpActionResult GetRfiDocs()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifpReqDocuments.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetRfiResponses")]
        public IHttpActionResult GetRfiResponses()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.rfiResponseT.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetDocumentsTemplates_Rfi")]
        public IHttpActionResult GetDocumentsTemplates_Rfi()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifpReqDocuments.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetInvitetoTenders")]
        public IHttpActionResult GetInvitetoTenders()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.invitetoTenders.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetResponsibiltyCenter")]
        public IHttpActionResult GetResponsibiltyCenter()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.responsibiltyCenter.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetProcurementTypes")]
        public IHttpActionResult GetProcurementTypes()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.procurementTypes.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetWorksCategory")]
        public IHttpActionResult GetWorksCategory()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.worksCategory.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetPurchaseCodeHeaders")]
        public IHttpActionResult GetPurchaseCodeHeaders()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.purchaseCodeHeaders.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetPurchaseCodeLines")]
        public IHttpActionResult GetPurchaseCodeLines()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.purchaseCodeLines.ToList();
            return Json(jresp);
        }
        
        [HttpGet]
        [Route("api/GetAddendums")]
        public IHttpActionResult GetAddendums()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.tenderAddendums.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetBidScoringTemplate")]
        public IHttpActionResult GetBidScoringTemplate()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.bidscoringTemplate.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetIfsRequirements")]
        public IHttpActionResult GetIfsRequirements()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsSecurities.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetIfsDocs")]
        public IHttpActionResult GetIfsDocs()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsReqDocuments.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetTenderReservCategory")]
        public IHttpActionResult GetTenderReservCategory()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifcRestrictedTenderCat.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetTenderKeystaff")]
        public IHttpActionResult GetTenderKeystaff()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsKeyStaff.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetTenderEquipSpecs")]
        public IHttpActionResult GetTenderEquipSpecs()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsEquipspecs.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetTenderifsBidscoreGrp")]
        public IHttpActionResult GetTenderifsBidscoreGrp()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsBidSCoreCritGrp.ToList();
            return Json(jresp);
        }


        [HttpGet]
        [Route("api/GetTenderVDebarment")]
        public IHttpActionResult GetTenderVDebarment()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.ifsVendorDebarment.ToList();
            return Json(jresp);
        }


        [HttpGet]
        [Route("api/GetBidResponseDetails")]
        public IHttpActionResult GetBidResponseDetails()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidResponsesDetails.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidResponseOwners")]
        public IHttpActionResult GetBidResponseOwners()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidResponseOwner.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidItemsLinesDetails")]
        public IHttpActionResult GetBidItemsLinesDetails()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidResponseItemLines.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidKeyStaffQualification")]
        public IHttpActionResult GetBidKeyStaffQualification()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidKeyStaffQualification.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidKeyAuditedBalanaceSheet")]
        public IHttpActionResult GetBidKeyAuditedBalanaceSheet()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidAuditedBalanaceSheet.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidKeyAuditedIncomeStatement")]
        public IHttpActionResult GetBidKeyAuditedIncomeStatement()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidAuditedIncomeStatement.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetBidKeyBankAccounts")]
        public IHttpActionResult GetBidKeyBankAccounts()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidVendorBankAccount.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetKeyBidPastExperience")]
        public IHttpActionResult GetKeyBidPastExperience()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidPastExperiences.ToList();
            return Json(jresp);
        }
        [HttpGet]
        [Route("api/GetKeyBidLitigationHistory")]
        public IHttpActionResult GetKeyBidLitigationHistory()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.BidLitigationHistory.ToList();
            return Json(jresp);
        }

        [HttpGet]
        [Route("api/GetKeyBidderEquipment")]
        public IHttpActionResult GetKeyBidderEquipment()
        {
            var odataCon = DBConfig.ODataObj();
            var jresp = odataCon.bidderEquipment.ToList();
            return Json(jresp);
        }
    }

}
