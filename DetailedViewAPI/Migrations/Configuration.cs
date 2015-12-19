namespace DetailedViewAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using DetailedViewAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DetailedViewAPI.Models.EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DetailedViewAPI.Models.EventContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.PageViews.AddOrUpdate(new PageView[]
            {
                new PageView { PageViewId = 1, PageViewIdasName = "4267088f-d71b-1464-d1bd-894c44174524", TopicKey = "dn555555", SessionId = "AAA", VisitorId = "729q83y9djkfjkawe", pv_propertyA = "Foo1", pv_propertyB = "Foo2", content_propertyA = "Foo3", content_propertyB = "Foo4", user_propetyA = "Foo5", user_propertyB = "Foo6", map_propertyA = "Foo7", map_propertyB = "Foo8", visit_propertyA = "Foo9", visit_propertyB = "Foo10", issue_propertyA = "Foo11", issue_propertyB = "Foo12" },
                new PageView { PageViewId = 2, PageViewIdasName = "33fb5452-61d1-dd74-f166-933d512a4908", TopicKey = "dn888888", SessionId = "BBB", VisitorId = "729q83y9djkfjkawe", pv_propertyA = "Foo1", pv_propertyB = "Foo2", content_propertyA = "Foo3", content_propertyB = "Foo4", user_propetyA = "Foo5", user_propertyB = "Foo6", map_propertyA = "Foo7", map_propertyB = "Foo8", visit_propertyA = "Foo9", visit_propertyB = "Foo10", issue_propertyA = "Foo11", issue_propertyB = "Foo12" },
            });
            context.Events.AddOrUpdate(new Event[]
            {
                //public int Id, string EventIdasTitle,  int PageViewId, 
              new Event() { Id = 1, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a57", PageViewId = 1, StartDateTime = new DateTime(2015,11,10) },
              new Event() { Id = 2, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a58", PageViewId = 1, StartDateTime = new DateTime(2015,11,10)},
              new Event() { Id = 3, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a59", PageViewId = 1, StartDateTime = new DateTime(2015,11,10) },
              new Event() { Id = 4, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a56", PageViewId = 1, StartDateTime = new DateTime(2015,11,10) },
              new Event() { Id = 5, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a55", PageViewId = 2, StartDateTime = new DateTime(2015,12,10) },
              new Event() { Id = 6, EventIdasTitle = "b0747ee3-4af3-4496-bf77-cddcac308a54", PageViewId = 2, StartDateTime = new DateTime(2015,12,10) },

            });
    }
    }
}
