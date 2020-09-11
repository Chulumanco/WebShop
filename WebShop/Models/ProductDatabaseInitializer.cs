using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebShop.Models
{

    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
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
                    CategoryName = "Caps"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sneakers"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Hoodies"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Sweats"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Pants"
                },
                 new Category
                {
                    CategoryID = 6,
                    CategoryName = "Shirts"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "MLB 39THIRTY",
                    Description = "Featuring a cotton upper and the letters NY embroidered in the front, this cap will give any look a cool and effortless vibe,"+
                                  " while saving you from harsh sunrays and bad hair days.",
                    ImagePath="original.jpg",
                    UnitPrice = 399.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Graphic PO hoodie G solid - navy",
                    Description = "Hoodie Drawstring Long sleeve Ribbed cuffs Ribbed hem Kangaroo pocket Colourblock designranded embroidery 100% Cotton ",
                    ImagePath="graph.jpg",
                    UnitPrice = 899.00,
                     CategoryID = 3
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Stan Smith - ftwr white / gold met.",
                    Description = "Regular fit Lace closure Leather upper Stan Smith portrait signature tongue label"+
                                "Synthetic lining Rubber cupsole Enjoy the comfort and performance of OrthoLite® sockliner Soft feel",
                    ImagePath="stan.jpg",
                    UnitPrice = 1399.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Crew Neck",
                    Description = "Crew neck Long sleeve Ribbed cuffs Ribbed hem Branded print",
                    ImagePath="Crew.jpg",
                    UnitPrice = 799.95,
                    CategoryID = 4
                },
                     new Product
                {
                    ProductID = 16,
                    ProductName = "Vans Classic L/S - Black/white",
                    Description = "With the seasons changing, it’s wise to start stocking up on transitional weather basics." +
                    " Look no further than this long sleeved made from 100% cotton. " +
                    "It features a round neck design and soft ribbed cuffs for extra comfort. " +
                    "The bold and iconic Vans logo give it a skater appeal." +
                    " Wear it with black jeans and checkered slip on sneakers from Vans.",
                    ImagePath="vans.jpg",
                    UnitPrice = 800.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Nike Joggers",
                    Description = "The Nike Sportswear Club Fleece Joggers combine a classic silhouette with the soft comfort of fleece for an elevated," 
                    +"versatile look that you can wear every day.",
                    ImagePath="joggers.jpg",
                    UnitPrice = 1134.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "New Look Burgundy Poplin Shirt",
                    Description = "For the perfect balance between smart and casual," +
                    " we recommend teaming your chinos with this shirt for a relaxed, yet smart look.",
                    ImagePath="newlook.jpg",
                    UnitPrice = 295.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Short Sleeve Shirt Blue",
                    Description = "Get your office looks to be on-point when opting for this Crosshatch Plain Air Lambert Plain Oxford Short Sleeve Shirt Blue. " +
                    "Stylish, comfortable and versatile, it's easy to pair this shirt with any bottom you feel fit.",
                    ImagePath="short.jpg",
                    UnitPrice = 234.95,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "St Goliath Hessner Tee Black",
                    Description = "St Goliath Hessner Tee Black",
                    ImagePath="stgol.jpg",
                    UnitPrice = 152.95,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "adidas Originals Mens Trefoil Tee Black",
                    Description = "adidas Originals Mens Trefoil Tee Black",
                    ImagePath="Adi_Originals.jpg",
                    UnitPrice = 332.95,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Nike M Nsw Club Hoodie Po Bb Blue",
                    Description = "Brushed-back fleece is soft and smooth against the skin." +
                    "Hood with a drawstring offers adjustable coverage." +
                    "Standard fit for a relaxed, easy feel" +
                    "Ribbed hem and cuffs" +
                    "Kangaroo pocket" +
                    "abric: Body: 80–82 % cotton / 18–20 % polyester.Hood Lining: 100 % cotton.",
                    ImagePath="nikem.jpg",
                    UnitPrice = 715.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Nike M Nsw Club Hoodie Po Bb Blue",
                    Description = "Brushed-back fleece is soft and smooth against the skin." +
                    "Hood with a drawstring offers adjustable coverage." +
                    "Standard fit for a relaxed, easy feel" +
                    "Ribbed hem and cuffs" +
                    "Kangaroo pocket" +
                    "abric: Body: 80–82 % cotton / 18–20 % polyester.Hood Lining: 100 % cotton.",
                    ImagePath="Nike.jpg",
                    UnitPrice = 800.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 11,
                    ProductName = "Soviet Double Dip Delpeche #4 Skinny Denim Jeans Blue",
                    Description = "Invest in versatile closet staples by going for the Soviet Double Dip Delpeche #4 Skinny Denim Jeans Blue." +
                    " These jeans boast the classic design that will be comfortable and stylish at the same time. " +
                    "Pair yours with a tee to create a casual look on weekends.",
                    ImagePath="soviet.jpg",
                    UnitPrice = 426.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Superstar 50 - ftwr white",
                    Description = "Low-top Lace-up Round toe 3 Stripes design Perforated detail Branding details",
                    ImagePath="superstar.jpg",
                    UnitPrice = 1122.95,
                    CategoryID = 2
                },
               
                new Product
                {
                    ProductID = 13,
                    ProductName = "Nike Air Max 270",
                    Description = "Nike's first lifestyle Air Max brings you style, " +
                    "comfort and big attitude in the Nike Air Max 270. " +
                    "The design draws inspiration from Air Max icons," +
                    " showcasing Nike's greatest innovation with its large window and fresh array of colours.",
                    ImagePath="amaix.jpg",
                    UnitPrice = 2499.95,
                    CategoryID = 2
                },
                 new Product
                {
                    ProductID = 14,
                    ProductName = "Men's Lerond Canvas Sneakers",
                    Description = "Canvas uppers Rubber outsole Textile linings Signature crocodile branding" +
                    "Tonal laces and clean lines add subtle detailin composition (100%)",
                    ImagePath="lacoste.JPG",
                    UnitPrice = 1800.95,
                    CategoryID = 2
                }
            };

            return products;
        }

    }
}
