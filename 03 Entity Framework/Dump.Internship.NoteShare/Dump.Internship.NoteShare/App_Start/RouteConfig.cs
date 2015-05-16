using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dump.Internship.NoteShare
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NoteList",
                url: "note-list",
                defaults: new { controller = "Note", action = "List" }
            );

            routes.MapRoute(
                name: "NoteDetails",
                url: "note-details/{id}",
                defaults: new { controller = "Note", action = "Details" }
            );

            routes.MapRoute(
                name: "NoteCreate",
                url: "note-create",
                defaults: new { controller = "Note", action = "Create" }
            );

            routes.MapRoute(
                name: "NoteDelete",
                url: "note-delete/{id}",
                defaults: new { controller = "Note", action = "Delete" }
            );

            routes.MapRoute(
                name: "NoteEdit",
                url: "note-edit/{id}",
                defaults: new { controller = "Note", action = "Edit" }
            );

            routes.MapRoute(
                name: "CommentAdd",
                url: "comment-create",
                defaults: new { controller = "Comment", action = "Create" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Note", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}