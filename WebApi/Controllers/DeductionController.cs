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
    public class DeductionController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/Deduction
        public IQueryable<Deduction> GetDeductions()
        {
            return db.Deductions;
        }

        // GET: api/Deduction/5
        [ResponseType(typeof(Deduction))]
        public IHttpActionResult GetDeduction(int id)
        {
            Deduction deduction = db.Deductions.Find(id);
            if (deduction == null)
            {
                return NotFound();
            }

            return Ok(deduction);
        }

        // PUT: api/Deduction/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDeduction(int id, Deduction deduction)
        {
           
            if (id != deduction.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(deduction).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeductionExists(id))
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

        // POST: api/Deduction
        [ResponseType(typeof(Deduction))]
        public IHttpActionResult PostDeduction(Deduction deduction)
        {
           
            db.Deductions.Add(deduction);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = deduction.EmployeeId }, deduction);
        }

        // DELETE: api/Deduction/5
        [ResponseType(typeof(Deduction))]
        public IHttpActionResult DeleteDeduction(int id)
        {
            Deduction deduction = db.Deductions.Find(id);
            if (deduction == null)
            {
                return NotFound();
            }

            db.Deductions.Remove(deduction);
            db.SaveChanges();

            return Ok(deduction);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeductionExists(int id)
        {
            return db.Deductions.Count(e => e.EmployeeId == id) > 0;
        }
    }
}