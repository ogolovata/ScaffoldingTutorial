using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DetailedViewAPI.Models;
using DetailedViewAPI.DTOs;

namespace DetailedViewAPI.Controllers
{
    public class EventsController : ApiController
    {
        private EventContext db = new EventContext();

        //Typedlambda expression for Select() method.
        private static readonly Expression<Func<Event, EventMD_Dto>> AsEventMD_Dto =
            x => new EventMD_Dto
            {
                StartDateTime = x.StartDateTime,
                EventIdasTitle = x.EventIdasTitle
            };
       
        // GET: api/Events
        public IQueryable<EventMD_Dto> GetEvents()
        {
            return db.Events.Include(b => b.PageViewId).Select(AsEventMD_Dto);
        }

        // GET: api/Events/5
        [ResponseType(typeof(EventMD_Dto))]
        public async Task<IHttpActionResult> GetEvent(int id)
        {
            EventMD_Dto @event = await db.Events.Include(b => b.PageViewId)
                .Where(b => b.Id == id)
                .Select(AsEventMD_Dto)
                .FirstOrDefaultAsync();
            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}