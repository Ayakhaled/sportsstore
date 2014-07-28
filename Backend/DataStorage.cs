using System.Collections.Generic;
using Backend.Models;

namespace Backend
{
    public static class DataStorage
    {
        public static readonly List<Product> Products = new List<Product>();

        public static void Seed()
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

            //            Stadium Flat-packed 35,000-seat stadium Soccer 79500.00
            //Thinking Cap Improve your brain efficiency by 75% Chess 16
            //Unsteady Chair Secretly give your opponent a disadvantage Chess 29.95
            //Human Chess Board A fun game for the family Chess 75
            //Bling-Bling King Gold-plated, diamond-studded King Chess 1200
        }
    }
}