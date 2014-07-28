using System.Collections.Generic;
using System.Web.Http;
using Backend.Models;

namespace Backend
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static readonly List<Product> Products = new List<Product>();

        protected void Application_Start()
        {
            Products.Add(new Product
            {
                name = "Kayak",
                description = "A boat for one person",
                category = "Watersports",
                price = 275
            });
            Products.Add(new Product
            {
                name = "Lifejacket",
                description = "Protective and fashionable",
                category = "Watersports",
                price = 48.95
            });
            Products.Add(new Product
            {
                name = "Soccer Ball",
                description = "FIFA-approved size and weight",
                category = "Soccer",
                price = 19.5
            });
            Products.Add(new Product
            {
                name = "Corner Flags",
                description = "Give your playing field a professional touch",
                category = "Soccer",
                price = 34.9
            });
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
