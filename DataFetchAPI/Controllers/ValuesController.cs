using System.Linq;
using System.Web.Http;
using DataFetchAPI.Utils;

namespace DataFetchAPI.Controllers
{
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
            var users = odataCon.Vendors.ToList();
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
            var openrfqs = odataCon.ProcurementRequest.Where(r => r.Process_Type == "RFQ" && r.Status == "Open").ToList();
            return Json(openrfqs);
        }

        [HttpGet]
        [Route("api/GetOpenTenders")]
        public IHttpActionResult GetOpenTenders()
        {
            var odataCon = DBConfig.ODataObj();
            var openrfqs = odataCon.Tenders.Where(r=> r.Quotation_Finished==false).ToList();
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
    }
}
