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
        //Typedlambda expression for Select() method.
        private static readonly Expression<Func<PageView, PageViewMD_Dto>> AsPageViewMD_Dto =
            x => new EventMD_Dto
            {
                StartDateTime = x.StartDateTime,
                EventIdasTitle = x.EventIdasTitle
            };

        // GET: api/PageViews
        public IQueryable<PageView> GetPageViews()
        {     
            return db.Events.Include(b => b.PageViewId).Select(AsPageViewMD_Dto);
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
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}