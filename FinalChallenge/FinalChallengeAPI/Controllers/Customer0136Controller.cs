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
    public class Customer0136Controller : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/Customer0136
        public IQueryable<Customer0136> GetCustomer0136()
        {
            return db.Customer0136;
        }

        // GET: api/Customer0136/5
        [ResponseType(typeof(Customer0136))]
        public IHttpActionResult GetCustomer0136(int id)
        {
            Customer0136 customer0136 = db.Customer0136.Find(id);
            if (customer0136 == null)
            {
                return NotFound();
            }

            return Ok(customer0136);
        }

        // PUT: api/Customer0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer0136(int id, Customer0136 customer0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer0136.CustNo)
            {
                return BadRequest();
            }

            db.Entry(customer0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer0136Exists(id))
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

        // POST: api/Customer0136
        [ResponseType(typeof(Customer0136))]
        public IHttpActionResult PostCustomer0136(Customer0136 customer0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customer0136.Add(customer0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Customer0136Exists(customer0136.CustNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = customer0136.CustNo }, customer0136);
        }

        // DELETE: api/Customer0136/5
        [ResponseType(typeof(Customer0136))]
        public IHttpActionResult DeleteCustomer0136(int id)
        {
            Customer0136 customer0136 = db.Customer0136.Find(id);
            if (customer0136 == null)
            {
                return NotFound();
            }

            db.Customer0136.Remove(customer0136);
            db.SaveChanges();

            return Ok(customer0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Customer0136Exists(int id)
        {
            return db.Customer0136.Count(e => e.CustNo == id) > 0;
        }
    }
}