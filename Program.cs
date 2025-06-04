using application.models;
using application.models.partner;
using application.models.product;
using application.models.sales;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
namespace application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (models.ApplicationContext db = new models.ApplicationContext())
            {
                if (!db.partners.Any())
                {
                    PartnerType type1 = new PartnerType { name = "ООО" };
                    PartnerType type2 = new PartnerType { name = "ОАО" };
                    PartnerType type3 = new PartnerType { name = "ИП" };

                    PlaceForSale sale1 = new PlaceForSale { name = "123" };
                    PlaceForSale sale2 = new PlaceForSale { name = "123" };
                    PlaceForSale sale3 = new PlaceForSale { name = "123" };

                    Partner partner = new Partner
                    {
                        partnerType = type1,
                        address = "г. Екатеринбург, ул. Столичная, 9",
                        INN = 231312312312,
                        directorName = "Попов Владимир Николаевич",
                        phone = "+7999777666",
                        email = "ggg@gmail.com",
                        logo = "/pics/logo",
                        rating = 4.6,
                        placeForSale = sale1
                    };
                    Partner partner1 = new Partner
                    {
                        partnerType = type2,
                        address = "г. Москва, ул. Столичная, 9",
                        INN = 235235235,
                        directorName = "Попов Алексей Петрович",
                        phone = "+7333222111",
                        email = "ttt@gmail.com",
                        logo = "/pics/logo",
                        rating = 4.8,
                        placeForSale = sale2
                    };
                    Partner partner2 = new Partner
                    {
                        partnerType = type3,
                        address = "г. Санкт-Петербург, ул. Столичная, 9",
                        INN = 321412412,
                        directorName = "Попов Роман Федерович",
                        phone = "+7555666444",
                        email = "eee@gmail.com",
                        logo = "/pics/logo",
                        rating = 4.7,
                        placeForSale = sale3
                    };
                    

                    db.partners.AddRange(partner, partner1, partner2);
                    db.SaveChanges();
                }
                if(!db.materials.Any())
                {
                    Material material1 = new Material
                    {
                        name = "Дерево Береза",
                        brakePercent = 0.5
                    };
                    Material material2 = new Material
                    {
                        name = "Дерево Крутое",
                        brakePercent = 1
                    };
                    Material material3 = new Material
                    {
                        name = "Дерево Дуб",
                        brakePercent = 0.5
                    };
                    if (!db.productsType.Any())
                    {
                        ProductType productType1 = new ProductType
                        {
                            name = "Игрушка",
                            cofficient = 0.2
                        };
                        if (!db.products.Any())
                        {
                            Product product1 = new Product
                            {
                                name = "Игрушка деревянная",
                                needMaterial = 3,
                                material = material1,
                                productType = productType1
                            };

                            if (!db.salesForPartners.Any())
                            {
                                SalesForPartner salesForPartner = new SalesForPartner
                                {
                                    date = "20.11.2025",
                                    product = product1,
                                    partner = db.partners.Find(1),
                                    quantity = 5
                                };
                            }
                        }
                    }
                }
                
            }
            
            Application.Run(new MainForm());
        }
    }
}