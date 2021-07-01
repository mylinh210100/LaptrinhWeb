using System.Web.Mvc;

namespace Tieuluan_LTWeb.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
                "Film Delete",
                "film/delete/{idphim}",
                new { controller = "Film", action = "Delete", id = UrlParameter.Optional }
            );



            context.MapRoute(
                "Film Update",
                "film/update/{id}",
                new { controller = "Film", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Film",
                "film",
                new { controller = "Film", action = "Film", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "Film Insert",
                "film/insert",
                new { controller = "Film", action = "ThemFilm", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Topic",
                "topic",
                new { controller = "TopicFilm", action = "Topic", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Topic Insert",
                "topic/insert",
                new { controller = "TopicFilm", action = "InsertNew", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Film of Topic",
                "topic/topic-film/{idchude}",
                new { controller = "TopicFilm", action = "TopicFilm", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Set topic for film",
                "topic/set-topic",
                new { controller = "TopicFilm", action = "SettopicFilm", id = UrlParameter.Optional }
            );


            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}