using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DetailedViewAPI.Models;

namespace DetailedViewAPI.Controllers
{
    public class PageViewsController : ApiController
    {
        private EventContext db = new EventContext();

        // GET: api/PageViews
        public IQueryable<PageView> GetPageViews()
        {
            return db.PageViews;
        }

        // GET: api/PageViews/5
        [ResponseType(typeof(PageView))]
        public async Task<IHttpActionResult> GetPageView(int id)
        {
            PageView pageView = await db.PageViews.FindAsync(id);
            if (pageView == null)
            {
                return NotFound();
            }

            return Ok(pageView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PageViewExists(int id)
        {
            return db.PageViews.Count(e => e.PageViewId == id) > 0;
        }
    }
}