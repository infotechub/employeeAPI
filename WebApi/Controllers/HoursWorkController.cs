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
    public class HoursWorkController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/HoursWork
        public IQueryable<HoursWork> GetHoursWorks()
        {
            return db.HoursWorks;
        }

        // GET: api/HoursWork/5
        [ResponseType(typeof(HoursWork))]
        public IHttpActionResult GetHoursWork(int id)
        {
            HoursWork hoursWork = db.HoursWorks.Find(id);
            if (hoursWork == null)
            {
                return NotFound();
            }

            return Ok(hoursWork);
        }

        // PUT: api/HoursWork/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHoursWork(int id, HoursWork hoursWork)
        {
           
            if (id != hoursWork.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(hoursWork).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoursWorkExists(id))
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

        // POST: api/HoursWork
        [ResponseType(typeof(HoursWork))]
        public IHttpActionResult PostHoursWork(HoursWork hoursWork)
        {
           
            db.HoursWorks.Add(hoursWork);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hoursWork.EmployeeId }, hoursWork);
        }

        // DELETE: api/HoursWork/5
        [ResponseType(typeof(HoursWork))]
        public IHttpActionResult DeleteHoursWork(int id)
        {
            HoursWork hoursWork = db.HoursWorks.Find(id);
            if (hoursWork == null)
            {
                return NotFound();
            }

            db.HoursWorks.Remove(hoursWork);
            db.SaveChanges();

            return Ok(hoursWork);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HoursWorkExists(int id)
        {
            return db.HoursWorks.Count(e => e.EmployeeId == id) > 0;
        }
    }
}