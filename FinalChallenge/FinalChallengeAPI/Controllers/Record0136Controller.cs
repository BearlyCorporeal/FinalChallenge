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
    public class Record0136Controller : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/Record0136
        public IQueryable<Record0136> GetRecord0136()
        {
            return db.Record0136;
        }

        // GET: api/Record0136/5
        [ResponseType(typeof(Record0136))]
        public IHttpActionResult GetRecord0136(string id)
        {
            Record0136 record0136 = db.Record0136.Find(id);
            if (record0136 == null)
            {
                return NotFound();
            }

            return Ok(record0136);
        }

        // PUT: api/Record0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRecord0136(string id, Record0136 record0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != record0136.RecordID)
            {
                return BadRequest();
            }

            db.Entry(record0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Record0136Exists(id))
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

        // POST: api/Record0136
        [ResponseType(typeof(Record0136))]
        public IHttpActionResult PostRecord0136(Record0136 record0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Record0136.Add(record0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Record0136Exists(record0136.RecordID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = record0136.RecordID }, record0136);
        }

        // DELETE: api/Record0136/5
        [ResponseType(typeof(Record0136))]
        public IHttpActionResult DeleteRecord0136(string id)
        {
            Record0136 record0136 = db.Record0136.Find(id);
            if (record0136 == null)
            {
                return NotFound();
            }

            db.Record0136.Remove(record0136);
            db.SaveChanges();

            return Ok(record0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Record0136Exists(string id)
        {
            return db.Record0136.Count(e => e.RecordID == id) > 0;
        }
    }
}