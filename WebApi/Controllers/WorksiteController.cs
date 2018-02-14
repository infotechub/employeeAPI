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
    public class WorksiteController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/Worksite
        public IQueryable<Worksite> GetWorksites()
        {
            return db.Worksites;
        }

        // GET: api/Worksite/5
        [ResponseType(typeof(Worksite))]
        public IHttpActionResult GetWorksite(int id)
        {
            Worksite worksite = db.Worksites.Find(id);
            if (worksite == null)
            {
                return NotFound();
            }

            return Ok(worksite);
        }

        // PUT: api/Worksite/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWorksite(int id, Worksite worksite)
        {
            
            if (id != worksite.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(worksite).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorksiteExists(id))
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

        // POST: api/Worksite
        [ResponseType(typeof(Worksite))]
        public IHttpActionResult PostWorksite(Worksite worksite)
        {
          
            db.Worksites.Add(worksite);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WorksiteExists(worksite.EmployeeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = worksite.EmployeeId }, worksite);
        }

        // DELETE: api/Worksite/5
        [ResponseType(typeof(Worksite))]
        public IHttpActionResult DeleteWorksite(int id)
        {
            Worksite worksite = db.Worksites.Find(id);
            if (worksite == null)
            {
                return NotFound();
            }

            db.Worksites.Remove(worksite);
            db.SaveChanges();

            return Ok(worksite);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WorksiteExists(int id)
        {
            return db.Worksites.Count(e => e.EmployeeId == id) > 0;
        }
    }
}