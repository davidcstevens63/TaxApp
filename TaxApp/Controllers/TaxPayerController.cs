using TaxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace TaxApp.Controllers
{
    public class TaxPayerController : ApiController
    {
        TaxPayer[] taxpayers = new TaxPayer[]  
        {  
            new TaxPayer { Id = 1, Name = "Samuel Jackson"},  
            new TaxPayer { Id = 2, Name = "Joe"},  
            new TaxPayer { Id = 3, Name = "MC Hammer" }  
        };

        public IEnumerable<TaxPayer> GetAllTaxPayers()
        {
            return taxpayers;
        }

        public IHttpActionResult GetTaxPayer(int id)
        {
            var taxpayer = taxpayers.FirstOrDefault((p) => p.Id == id);
            if (taxpayer == null)
            {
                return NotFound();
            }
            return Ok(taxpayer);
        }
    }
}