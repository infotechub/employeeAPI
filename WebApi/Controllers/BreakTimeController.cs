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
    public class BreakTimeController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/BreakTime
        public IQueryable<BreakTime> GetBreakTimes()
        {
            return db.BreakTimes;
        }

        // GET: api/BreakTime/5
        [ResponseType(typeof(BreakTime))]
        public IHttpActionResult GetBreakTime(int id)
        {
            BreakTime breakTime = db.BreakTimes.Find(id);
            if (breakTime == null)
            {
                return NotFound();
            }

            return Ok(breakTime);
        }

        // PUT: api/BreakTime/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBreakTime(int id, BreakTime breakTime)
        {
            
            if (id != breakTime.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(breakTime).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakTimeExists(id))
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

        // POST: api/BreakTime
        [ResponseType(typeof(BreakTime))]
        public IHttpActionResult PostBreakTime(BreakTime breakTime)
        {
           
            db.BreakTimes.Add(breakTime);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = breakTime.EmployeeId }, breakTime);
        }

        // DELETE: api/BreakTime/5
        [ResponseType(typeof(BreakTime))]
        public IHttpActionResult DeleteBreakTime(int id)
        {
            BreakTime breakTime = db.BreakTimes.Find(id);
            if (breakTime == null)
            {
                return NotFound();
            }

            db.BreakTimes.Remove(breakTime);
            db.SaveChanges();

            return Ok(breakTime);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BreakTimeExists(int id)
        {
            return db.BreakTimes.Count(e => e.EmployeeId == id) > 0;
        }
    }
}