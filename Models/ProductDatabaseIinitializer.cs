using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class ProductDatabaseIinitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Comida Colombiana",
                },
            new Category
            {
                CategoryID = 2,
                CategoryName = "Comida Francesa",
            },
            new Category
            {
                CategoryID = 3,
                CategoryName = "Comida Española",
            },
           
        };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>{
                new Product
                {
                    ProductID = 1,
                    ProductName = "Bandeja Paisa",
                    Description = "Este plato tiene como ingredientes: Frijoles, Carne molida, Arroz, Platano dulce, Cebolla, Tomate, Harina para arepas, Sal, entre otros",
                    imagePath = "convertiblecar.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Arroz Paisa",
                    Description = "Este plato tiene como ingredientes: Arroz cocido, Aceite vegetal, Pechuga de pollo, Pierna de cerdo, Chorizo Antioqueño, Chicharron carnudo, Maiz tierno, Platano maduro, entre otros",
                    imagePath = "old-timecar.jpg",
                    UnitPrice = 15.95,
                    CategoryID = 1

                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Cocido Boyacense",
                    Description = "Este plato tiene como ingredientes: Costilla de cerdo, Gallina criolla, Longaniza, Papa, Arveja verde, Habas, Mazorca, Cubios, Chuguas, Cebolla larga, Mantequilla, entre otros",
                    imagePath = "fastcar.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Ratatouille",
                    Description = "Este plato tiene como ingredientes: Berenjenas, Cebollas, Zuquini, Pimenton, Ajo, Tomates",
                    imagePath = "superfastcar.png",
                    UnitPrice = 8.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Vichyssoise",
                    Description = "Este plato tiene como ingredientes: Mantequilla, Puerros, Nata ligera, Pimineta negra, Sal, entre otros",
                    imagePath = "oldstylerracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Morbiflette",
                    Description = "Este plato tiene como ingredientes: Cebolla, Panceta, Vino Blanco, Creme fraiche, Queso Morbier, Aceite de oliva, Sal, entre otros.",
                    imagePath = "aceplnae.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Paella Valenciana",
                    Description = "Este plato tiene como ingredientes: Arroz, Carne de pollo, Carne de conejo, Tomate triturado, Pimenton dulce, Colorante alimenticio, entre otros",
                    imagePath = "glider.png",
                    UnitPrice = 4.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Gazpacho de cereza",
                    Description = "Este plato tiene como ingredientes: Tomate maduro, Pimiento rojo, Diente de ajo, Cebolla, Cerezas, Vinagre de jerez, Sal, Pimienta negra, entre otros",
                    imagePath = "paperplane.png",
                    UnitPrice = 2.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Tortilla de patata",
                    Description = "Este plato tiene como ingredientes: Huevos medianos, Patatas, Sal, Aceite de oliva o girasol, Cebolla",
                    imagePath = "proplenerplane.png",
                    UnitPrice = 32.95,
                    CategoryID = 3
                },
                };
            return products;
            }
        }
}