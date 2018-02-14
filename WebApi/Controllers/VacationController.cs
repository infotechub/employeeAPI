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
    public class VacationController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/Vacation
        public IQueryable<Vacation> GetVacations()
        {
            return db.Vacations;
        }

        // GET: api/Vacation/5
        [ResponseType(typeof(Vacation))]
        public IHttpActionResult GetVacation(int id)
        {
            Vacation vacation = db.Vacations.Find(id);
            if (vacation == null)
            {
                return NotFound();
            }

            return Ok(vacation);
        }

        // PUT: api/Vacation/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVacation(int id, Vacation vacation)
        {
            
            if (id != vacation.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(vacation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VacationExists(id))
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

        // POST: api/Vacation
        [ResponseType(typeof(Vacation))]
        public IHttpActionResult PostVacation(Vacation vacation)
        {
           
            db.Vacations.Add(vacation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vacation.EmployeeId }, vacation);
        }

        // DELETE: api/Vacation/5
        [ResponseType(typeof(Vacation))]
        public IHttpActionResult DeleteVacation(int id)
        {
            Vacation vacation = db.Vacations.Find(id);
            if (vacation == null)
            {
                return NotFound();
            }

            db.Vacations.Remove(vacation);
            db.SaveChanges();

            return Ok(vacation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VacationExists(int id)
        {
            return db.Vacations.Count(e => e.EmployeeId == id) > 0;
        }
    }
}