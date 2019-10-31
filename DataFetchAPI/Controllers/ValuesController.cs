﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using DataFetchAPI.Utils;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DataFetchAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/Values")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/GetPortalUsers")]
        public IHttpActionResult GetPortalUsers()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.PortalUsers.ToList();
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
        [Route("api/GetOpenRfQs/{processtype}/{quotfinished}/{vendorNo}")]
        public IHttpActionResult GetOpenRfQs(string processtype, bool quotfinished, string vendorNo)
        {
            var odataCon = DBConfig.ODataObj();
            var openrfqs = odataCon.ProcurementRequest.Where(r => r.Process_Type == processtype && r.Quotation_Finished == quotfinished &&r.Vendor_No == vendorNo).ToList();
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
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
       
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
