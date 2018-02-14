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
    public class PayRollController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/PayRoll
        public IQueryable<PayRoll> GetPayRolls()
        {
            return db.PayRolls;
        }

        // GET: api/PayRoll/5
        [ResponseType(typeof(PayRoll))]
        public IHttpActionResult GetPayRoll(int id)
        {
            PayRoll payRoll = db.PayRolls.Find(id);
            if (payRoll == null)
            {
                return NotFound();
            }

            return Ok(payRoll);
        }

        // PUT: api/PayRoll/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPayRoll(int id, PayRoll payRoll)
        {
           
            if (id != payRoll.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(payRoll).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayRollExists(id))
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

        // POST: api/PayRoll
        [ResponseType(typeof(PayRoll))]
        public IHttpActionResult PostPayRoll(PayRoll payRoll)
        {
           
            db.PayRolls.Add(payRoll);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = payRoll.EmployeeId }, payRoll);
        }

        // DELETE: api/PayRoll/5
        [ResponseType(typeof(PayRoll))]
        public IHttpActionResult DeletePayRoll(int id)
        {
            PayRoll payRoll = db.PayRolls.Find(id);
            if (payRoll == null)
            {
                return NotFound();
            }

            db.PayRolls.Remove(payRoll);
            db.SaveChanges();

            return Ok(payRoll);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PayRollExists(int id)
        {
            return db.PayRolls.Count(e => e.EmployeeId == id) > 0;
        }
    }
}