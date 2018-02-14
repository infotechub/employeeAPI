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
    public class LoginStatusController : ApiController
    {
        private ProNinaEntities db = new ProNinaEntities();

        // GET: api/LoginStatus
        public IQueryable<LoginStatu> GetLoginStatus()
        {
            return db.LoginStatus;
        }

        // GET: api/LoginStatus/5
        [ResponseType(typeof(LoginStatu))]
        public IHttpActionResult GetLoginStatu(int id)
        {
            LoginStatu loginStatu = db.LoginStatus.Find(id);
            if (loginStatu == null)
            {
                return NotFound();
            }

            return Ok(loginStatu);
        }

        // PUT: api/LoginStatus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLoginStatu(int id, LoginStatu loginStatu)
        {
           
            if (id != loginStatu.EmployeeId)
            {
                return BadRequest();
            }

            db.Entry(loginStatu).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginStatuExists(id))
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

        // POST: api/LoginStatus
        [ResponseType(typeof(LoginStatu))]
        public IHttpActionResult PostLoginStatu(LoginStatu loginStatu)
        {
           
            db.LoginStatus.Add(loginStatu);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = loginStatu.EmployeeId }, loginStatu);
        }

        // DELETE: api/LoginStatus/5
        [ResponseType(typeof(LoginStatu))]
        public IHttpActionResult DeleteLoginStatu(int id)
        {
            LoginStatu loginStatu = db.LoginStatus.Find(id);
            if (loginStatu == null)
            {
                return NotFound();
            }

            db.LoginStatus.Remove(loginStatu);
            db.SaveChanges();

            return Ok(loginStatu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoginStatuExists(int id)
        {
            return db.LoginStatus.Count(e => e.EmployeeId == id) > 0;
        }
    }
}