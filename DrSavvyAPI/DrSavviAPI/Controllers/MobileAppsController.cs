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
using DrSavviAPI.Models;

namespace DrSavviAPI.Controllers
{
    public class MobileAppsController : ApiController
    {
        private DrSavvyEntities db = new DrSavvyEntities();

        // GET: api/MobileApps
        public IQueryable<MobileApp> GetMobileApps()
        {
            return db.MobileApps;
        }

        // GET: api/MobileApps/5
        [ResponseType(typeof(MobileApp))]
        public IHttpActionResult GetMobileApp(int id)
        {
            MobileApp mobileApp = db.MobileApps.Find(id);
            if (mobileApp == null)
            {
                return NotFound();
            }

            return Ok(mobileApp);
        }

        // PUT: api/MobileApps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMobileApp(int id, MobileApp mobileApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mobileApp.MobileAppID)
            {
                return BadRequest();
            }

            db.Entry(mobileApp).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobileAppExists(id))
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

        // POST: api/MobileApps
        [ResponseType(typeof(MobileApp))]
        public IHttpActionResult PostMobileApp(MobileApp mobileApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MobileApps.Add(mobileApp);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mobileApp.MobileAppID }, mobileApp);
        }

        // DELETE: api/MobileApps/5
        [ResponseType(typeof(MobileApp))]
        public IHttpActionResult DeleteMobileApp(int id)
        {
            MobileApp mobileApp = db.MobileApps.Find(id);
            if (mobileApp == null)
            {
                return NotFound();
            }

            db.MobileApps.Remove(mobileApp);
            db.SaveChanges();

            return Ok(mobileApp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MobileAppExists(int id)
        {
            return db.MobileApps.Count(e => e.MobileAppID == id) > 0;
        }
    }
}