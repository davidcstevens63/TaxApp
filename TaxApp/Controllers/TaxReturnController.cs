using TaxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaxApp.Controllers
{
    public class TaxReturnController : ApiController
    {
        TaxReturn[] taxreturns = new TaxReturn[]  
        {  
            new TaxReturn { Id = 1, Amended = true},  
            new TaxReturn { Id = 2, Amended = true},  
            new TaxReturn { Id = 3, Amended = false}  
        };

        public IEnumerable<TaxReturn> GetAllTaxReturns()
        {
            return taxreturns;
        }

        public IHttpActionResult GetTaxReturn(int id)
        {
            var taxpayer = taxreturns.FirstOrDefault((p) => p.Id == id);
            if (taxpayer == null)
            {
                return NotFound();
            }
            return Ok(taxpayer);
        }
    }
}
