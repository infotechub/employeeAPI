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
    public class TimeSheetController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/TimeSheet
        public IQueryable<TimeSheet> GetTimeSheets()
        {
            return db.TimeSheets;
        }

        // GET: api/TimeSheet/5
        [ResponseType(typeof(TimeSheet))]
        public IHttpActionResult GetTimeSheet(int id)
        {
            TimeSheet timeSheet = db.TimeSheets.Find(id);
            if (timeSheet == null)
            {
                return NotFound();
            }

            return Ok(timeSheet);
        }

        // PUT: api/TimeSheet/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTimeSheet(int id, TimeSheet timeSheet)
        {
           
            if (id != timeSheet.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(timeSheet).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeSheetExists(id))
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

        // POST: api/TimeSheet
        [ResponseType(typeof(TimeSheet))]
        public IHttpActionResult PostTimeSheet(TimeSheet timeSheet)
        {
           
            db.TimeSheets.Add(timeSheet);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = timeSheet.EmployeeId }, timeSheet);
        }

        // DELETE: api/TimeSheet/5
        [ResponseType(typeof(TimeSheet))]
        public IHttpActionResult DeleteTimeSheet(int id)
        {
            TimeSheet timeSheet = db.TimeSheets.Find(id);
            if (timeSheet == null)
            {
                return NotFound();
            }

            db.TimeSheets.Remove(timeSheet);
            db.SaveChanges();

            return Ok(timeSheet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TimeSheetExists(int id)
        {
            return db.TimeSheets.Count(e => e.EmployeeId == id) > 0;
        }
    }
}