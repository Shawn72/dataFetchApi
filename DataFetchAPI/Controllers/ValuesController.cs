using System.ComponentModel.DataAnnotations;
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
            var users = odataCon.eProcVendorQ.ToList();
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
    }
  
}
