using System.Web.Mvc;
using System.Web.Routing;

namespace Dump.Internship.NoteShare
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Notes", action = "List" });
            routes.MapRoute("NotesList", "notes", new { controller = "Notes", action = "List" });
            routes.MapRoute("NotesDetails", "note/{id}", new { controller = "Notes", action = "Details" });
            routes.MapRoute("NotesCreate", "create", new { controller = "Notes", action = "Create" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Notes", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}