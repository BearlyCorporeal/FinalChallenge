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
    public class Interest0136Controller : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/Interest0136
        public IQueryable<Interest0136> GetInterest0136()
        {
            return db.Interest0136;
        }

        // GET: api/Interest0136/5
        [ResponseType(typeof(Interest0136))]
        public IHttpActionResult GetInterest0136(string id)
        {
            Interest0136 interest0136 = db.Interest0136.Find(id);
            if (interest0136 == null)
            {
                return NotFound();
            }

            return Ok(interest0136);
        }

        // PUT: api/Interest0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInterest0136(string id, Interest0136 interest0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != interest0136.InterestCode)
            {
                return BadRequest();
            }

            db.Entry(interest0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Interest0136Exists(id))
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

        // POST: api/Interest0136
        [ResponseType(typeof(Interest0136))]
        public IHttpActionResult PostInterest0136(Interest0136 interest0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Interest0136.Add(interest0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Interest0136Exists(interest0136.InterestCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = interest0136.InterestCode }, interest0136);
        }

        // DELETE: api/Interest0136/5
        [ResponseType(typeof(Interest0136))]
        public IHttpActionResult DeleteInterest0136(string id)
        {
            Interest0136 interest0136 = db.Interest0136.Find(id);
            if (interest0136 == null)
            {
                return NotFound();
            }

            db.Interest0136.Remove(interest0136);
            db.SaveChanges();

            return Ok(interest0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Interest0136Exists(string id)
        {
            return db.Interest0136.Count(e => e.InterestCode == id) > 0;
        }
    }
}