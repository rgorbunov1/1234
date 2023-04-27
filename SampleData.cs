using CarShop.Models;
using System.Linq;

namespace CarShop
{
    public class SampleData
    {
        public static void Initialize(CarContext context)
        {
            if (!context.Categories.Any()) 
            {
                context.Categories.AddRange(

                    new Category
                    {
                        categoryName = "Электромобили",
                        desc = "Современный вид транспорта"
                    },

                    new Category
                    {
                        categoryName = "Классические автомобили",
                        desc = "Машины с двигателем внутреннего сгорания"
                    }

                    );
            }

            if (!context.Cars.Any())
            {
                
                context.Cars.AddRange(


                     new Car
                     {
                         Name = "Tesla Model S",
                         shortDesc = "Быстрый автомобиль",
                         longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                         img = "/img/TeslaS.jpg",
                         price = 45000,
                         isfavorite = true,
                         avaible = true,
                         //Category = "Электромобили"
                     },

                    new Car
                    {
                        Name = "Ford Fiesta",
                        shortDesc = "Тихий и надёжный",
                        longDesc = "Удобный автомобиль для езды по городу",
                        img = "/img/Fiesta.jpg",
                        price = 45000,
                        isfavorite = true,
                        avaible = true,
                        //Category = "Классические автомобили"
                    },

                    new Car
                    {
                        Name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный и надёжный автомобиль для движения как по городу, так и по пересечённой местности",
                        img = "/img/BMW.jpg",
                        price = 45000,
                        isfavorite = true,
                        avaible = true,
                        //Category = "Классические автомобили"
                    },

                    new Car
                    {
                        Name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Надёжный немецкий автомобиль",
                        img = "/img/Mercedes.jpg",
                        price = 45000,
                        isfavorite = true,
                        avaible = true,
                        //Category = "Классические автомобили"
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для езды по городу",
                        img = "/img/Nissan.jpg",
                        price = 45000,
                        isfavorite = true,
                        avaible = true,
                        //Category = "Электромобили"
                    },
                    new Car
                    {
                        Name = "Tesla Model M",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/TeslaM.jpg",
                        price = 45000,
                        isfavorite = true,
                        avaible = true,
                        //Category = "Электромобили"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
