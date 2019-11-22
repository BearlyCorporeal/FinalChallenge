using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FinalChallengeAPI.Models;

namespace FinalChallengeAPI.Controllers
{
    public class Sale0136Controller : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/Sale0136
        public IQueryable<Sale0136> GetSale0136()
        {
            return db.Sale0136;
        }

        // GET: api/Sale0136/5
        [ResponseType(typeof(Sale0136))]
        public IHttpActionResult GetSale0136(int id)
        {
            Sale0136 sale0136 = db.Sale0136.Find(id);
            if (sale0136 == null)
            {
                return NotFound();
            }

            return Ok(sale0136);
        }

        // PUT: api/Sale0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSale0136(int id, Sale0136 sale0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sale0136.CustNo)
            {
                return BadRequest();
            }

            db.Entry(sale0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sale0136Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sale0136
        [ResponseType(typeof(Sale0136))]
        public IHttpActionResult PostSale0136(Sale0136 sale0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sale0136.Add(sale0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Sale0136Exists(sale0136.CustNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sale0136.CustNo }, sale0136);
        }

        // DELETE: api/Sale0136/5
        [ResponseType(typeof(Sale0136))]
        public IHttpActionResult DeleteSale0136(int id)
        {
            Sale0136 sale0136 = db.Sale0136.Find(id);
            if (sale0136 == null)
            {
                return NotFound();
            }

            db.Sale0136.Remove(sale0136);
            db.SaveChanges();

            return Ok(sale0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Sale0136Exists(int id)
        {
            return db.Sale0136.Count(e => e.CustNo == id) > 0;
        }
    }
}