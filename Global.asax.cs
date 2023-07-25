using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication6.Models;

namespace WebApplication6
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // 데이터베이스 초기화
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DocumentsDbContext>());
        }
    }
}
