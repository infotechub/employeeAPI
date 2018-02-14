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
using WebApi.Models;

namespace WebApi.Controllers
{
    public class SickLeaveController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/SickLeave
        public IQueryable<SickLeave> GetSickLeaves()
        {
            return db.SickLeaves;
        }

        // GET: api/SickLeave/5
        [ResponseType(typeof(SickLeave))]
        public IHttpActionResult GetSickLeave(int id)
        {
            SickLeave sickLeave = db.SickLeaves.Find(id);
            if (sickLeave == null)
            {
                return NotFound();
            }

            return Ok(sickLeave);
        }

        // PUT: api/SickLeave/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSickLeave(int id, SickLeave sickLeave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sickLeave.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(sickLeave).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SickLeaveExists(id))
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

        // POST: api/SickLeave
        [ResponseType(typeof(SickLeave))]
        public IHttpActionResult PostSickLeave(SickLeave sickLeave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SickLeaves.Add(sickLeave);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sickLeave.EmployeeId }, sickLeave);
        }

        // DELETE: api/SickLeave/5
        [ResponseType(typeof(SickLeave))]
        public IHttpActionResult DeleteSickLeave(int id)
        {
            SickLeave sickLeave = db.SickLeaves.Find(id);
            if (sickLeave == null)
            {
                return NotFound();
            }

            db.SickLeaves.Remove(sickLeave);
            db.SaveChanges();

            return Ok(sickLeave);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SickLeaveExists(int id)
        {
            return db.SickLeaves.Count(e => e.EmployeeId == id) > 0;
        }
    }
}