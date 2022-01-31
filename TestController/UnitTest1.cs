using CocheApplicationWeb.Controllers;
using CocheApplicationWeb.Model;
using CocheApplicationWeb.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace TestController
{
    [TestClass]
    public class UnitTest1
    {

        private RuedaRepository ruedaRepository;

        [TestMethod]
        public void TestGetRuedas()
        {
           /* ruedaRepository.Add(createRueda());
            var controller = new RuedaController(ruedaRepository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.GetRuedas();

            Assert.AreEqual(response.
           */
        }
        [TestMethod]
        public void TestCreateRueda()
        {
           /*
            RuedaController controller = new RuedaController(ruedaRepository);

            controller.Request = new HttpRequestMessage { 
                RequestUri = new Uri("http://localhost/api/rueda") 
            };
            
            controller.Configuration = new HttpConfiguration();
            controller.Configuration.Routes.MapHttpRoute(
             name: "DefaultApi", 
             routeTemplate: "api/{controller}/{id}",
             defaults: new { id = RouteParameter.Optional });

            controller.RequestContext.RouteData = new HttpRouteData(
                 route: new HttpRoute(),
                    values: new HttpRouteValueDictionary { { "controller", "ruedas" } });


            Rueda rueda = createRueda();
            var response = controller.CreateRueda(rueda);


            Assert.AreEqual("http://localhost/api/rueda/4", response.Headers.Location.AbsoluteUri);
           */
        
        }

            private Rueda createRueda()
        {
            Rueda r = new Rueda("michelin", false);
            return r;
        }
    }
}