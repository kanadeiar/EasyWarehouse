using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Domain.Models;
using Warehouse.Domain.WebModels;

namespace Warehouse.Domain.Models.Data
{
    public static class StaticData
    {
        public static IEnumerable<ProductType> ProductTypes => new List<ProductType>()
        {
            new ProductType
            {
                Id = 1,
                Name = "Кирпич обычный 250x100x80 в пачке",
                Volume = 3.5f,
                Count = 350,
            },
            new ProductType
            {
                Id = 2,
                Name = "Кирпич обычный 100x100x50 в пачке",
                Volume = 3.6f,
                Count = 400,
            },
            new ProductType
            {
                Id = 3,
                Name = "Кирпич особенный 120x100x60 в пачке",
                Volume = 2.5f,
                Count = 100,
            },
            new ProductType
            {
                Id = 4,
                Name = "Блок особенный с дырками 250x250x250 в пачке",
                Volume = 4.6f,
                Count = 50,
            },
            new ProductType
            {
                Id = 5,
                Name = "Блок особенный с дырками 120x120x50 в пачке",
                Volume = 3.6f,
                Count = 290,
            }
        };

        public static IEnumerable<Place> Places => new List<Place>()
        {
            new Place
            {
                Id = 1,
                Name = "Главный стеллаж",
                Size = 200,
            },
            new Place
            {
                Id = 2,
                Name = "Стеллаж под навесом",
                Size = 50,
            },
            new Place
            {
                Id = 3,
                Name = "Малый стеллаж",
                Size = 10,
            },
            new Place
            {
                Id = 4,
                Name = "Холодный стеллаж",
                Size = 80,
            },
            new Place
            {
                Id = 5,
                Name = "Резервный стеллаж",
                Size = 20,
            }
        };

        public static IEnumerable<Product> Products => new List<Product>()
        {
            new Product {Id = 1, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(8) },
            new Product {Id = 2, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(8) },
            new Product {Id = 3, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(9) },
            new Product {Id = 4, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(9) },
            new Product {Id = 5, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(7) },
            new Product {Id = 6, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(6) },
            new Product {Id = 7, PlaceId = 1, ProductTypeId = 1, DateTime = DateTime.Today.AddHours(5) },
            new Product {Id = 8, PlaceId = 1, ProductTypeId = 4, DateTime = DateTime.Today.AddDays(-5).AddHours(4) },

            new Product {Id = 9, PlaceId = 2, ProductTypeId = 2, DateTime = DateTime.Today.AddDays(-1).AddHours(7) },
            new Product {Id = 10, PlaceId = 2, ProductTypeId = 2, DateTime = DateTime.Today.AddDays(-1).AddHours(8) },
            new Product {Id = 11, PlaceId = 2, ProductTypeId = 2, DateTime = DateTime.Today.AddDays(-1).AddHours(9) },
            new Product {Id = 12, PlaceId = 2, ProductTypeId = 2, DateTime = DateTime.Today.AddDays(-1).AddHours(10) },

            new Product {Id = 13, PlaceId = 3, ProductTypeId = 2, DateTime = DateTime.Now.AddDays(-1).AddHours(20) },
            new Product {Id = 14, PlaceId = 3, ProductTypeId = 2, DateTime = DateTime.Now.AddDays(-1).AddHours(20) },
            new Product {Id = 15, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(8) },
            new Product {Id = 16, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(8) },
            new Product {Id = 17, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(8) },
            new Product {Id = 18, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(10) },
            new Product {Id = 19, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(10) },
            new Product {Id = 20, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(11) },
            new Product {Id = 21, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(12) },
            new Product {Id = 22, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(13) },
            new Product {Id = 23, PlaceId = 3, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-2).AddHours(14) },

            new Product {Id = 24, PlaceId = 4, ProductTypeId = 3, DateTime = DateTime.Now.AddDays(-3).AddHours(8) },
            new Product {Id = 25, PlaceId = 4, ProductTypeId = 3, DateTime = DateTime.Now.AddDays(-3).AddHours(20) },
            new Product {Id = 26, PlaceId = 4, ProductTypeId = 2, DateTime = DateTime.Now.AddDays(-4).AddHours(8) },
            new Product {Id = 27, PlaceId = 4, ProductTypeId = 3, DateTime = DateTime.Now.AddDays(-5).AddHours(20) },
            new Product {Id = 28, PlaceId = 4, ProductTypeId = 4, DateTime = DateTime.Now.AddDays(-8).AddHours(8) },
            new Product {Id = 29, PlaceId = 4, ProductTypeId = 3, DateTime = DateTime.Now.AddDays(-8).AddHours(20) },
            new Product {Id = 30, PlaceId = 4, ProductTypeId = 1, DateTime = DateTime.Now.AddDays(-12).AddHours(8) },
        };

        public static IEnumerable<ProductWebModel> ToWebModel(this IEnumerable<Product> products)
        {
            var productTupes = ProductTypes.ToArray();
            var places = Places.ToArray();
            var result = products.Select(p => new ProductWebModel
            {
                Id = p.Id,
                Name = productTupes[p.ProductTypeId - 1].Name,
                PlaceName = places[p.PlaceId - 1].Name,
                DateTime = p.DateTime,
                Volume = productTupes[p.ProductTypeId - 1].Volume,
                Count = productTupes[p.ProductTypeId - 1].Count,
            });
            return result.OrderBy(p => p.Name);
        }

        public static ProductDetailWebModel ToWebModel(this Product product)
        {
            var productTupes = ProductTypes.ToArray();
            var places = Places.ToArray();
            var result = new ProductDetailWebModel
            {
                Id = product.Id,
                Name = productTupes[product.ProductTypeId - 1].Name,
                PlaceId = product.PlaceId,
                PlaceName = places[product.PlaceId - 1].Name,
                DateTime = product.DateTime,
                Volume = productTupes[product.ProductTypeId - 1].Volume,
                Count = productTupes[product.ProductTypeId - 1].Count,
            };
            return result;
        }

        public static IEnumerable<PlaceWebModel> ToWebModel(this IEnumerable<Place> places)
        {
            var productTupes = ProductTypes.ToArray();
            var result = places.Select(p => new PlaceWebModel
            {
                Id = p.Id,
                Name = p.Name,
                CountProducts = Products.Where(pr => pr.PlaceId == p.Id).Count(),
                Size = p.Size,
            }).ToList();
            foreach (var place in result)
            {
                if (place.CountProducts == 0)
                    place.Status = "Пусто";
                else if (place.CountProducts == place.Size)
                    place.Status = "Заполнен";
                else if (place.CountProducts >= place.Size)
                    place.Status = "Переполнение";
                else
                    place.Status = "Норма";
            }
            return result.OrderBy(p => p.Name);
        }

        public static PlaceDetailWebModel ToWebModel(this Place place)
        {
            var productTupes = ProductTypes.ToArray();
            var placeProducts = Products.Where(pr => pr.PlaceId == place.Id).ToWebModel();
            var result = new PlaceDetailWebModel
            {
                Id = place.Id,
                Name = place.Name,
                ProductsCount = placeProducts.Count(),
                Size = place.Size,
                ProductsVolume = placeProducts.Sum(pr => pr.Volume),
                ProductsSum = placeProducts.Sum(pr => pr.Count),
                Products = placeProducts,
            };
            if (result.ProductsCount == 0)
                result.Status = "Пусто";
            else if (result.ProductsCount == result.Size)
                result.Status = "Заполнен";
            else if (result.ProductsCount >= result.Size)
                result.Status = "Переполнение";
            else
                result.Status = "Норма";
            return result;
        }

        public static IEnumerable<ProductTypeWebModel> ToWebModel(this IEnumerable<ProductType> productTypes)
        {
            var result = productTypes.Select(p => new ProductTypeWebModel
            {
                Id = p.Id,
                Name = p.Name,
                Volume = p.Volume,
                Count = p.Count,
            }).ToList();
            return result.OrderBy(p => p.Name);
        }

        public static IEnumerable<FillingInfoWebModel> ToFillingWebModel(this IEnumerable<Place> places)
        {
            var result = places.Select(p => new FillingInfoWebModel
            {
                Id = p.Id,
                Name = p.Name,
                Size = p.Size,
            }).ToList();
            foreach (var place in result)
            {
                var placeProducts = Products.Where(pr => pr.PlaceId == place.Id).ToWebModel();
                place.Occupied = placeProducts.Count();
                place.Free = place.Size - place.Occupied;
                if (place.Free < 0)
                    place.Free = 0;
                place.Filling = Convert.ToInt32(place.Size != 0 ? (float)place.Occupied / (float)place.Size * 100.0f : 0.0f);
                if (place.Occupied == 0)
                    place.Status = "Пусто";
                else if (place.Occupied == place.Size)
                    place.Status = "Заполнен";
                else if (place.Occupied >= place.Size)
                    place.Status = "Переполнение";
                else
                    place.Status = "Норма";
            }
            return result;
        }

        public static IEnumerable<CountsInfoWebModel> ToCountsWebModel(this IEnumerable<ProductType> productTypes)
        {
            var result = productTypes.Select(p => new CountsInfoWebModel
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
            foreach (var product in result)
            {
                var typeProducts = Products.Where(pr => pr.ProductTypeId == product.Id).ToWebModel();
                product.Volume = typeProducts.Sum(p => p.Volume);
                product.Count = typeProducts.Sum(p => p.Count);
                product.Size = typeProducts.Count();
            }
            var maxVolume = result.Max(p => p.Volume);
            var maxCount = result.Max(p => p.Count);
            var maxSize = result.Max(p => p.Size);
            foreach (var product in result)
            {
                product.VolumePercent = Convert.ToInt32((float)product.Volume / (float)maxVolume * 100.0f);
                product.CountPercent = Convert.ToInt32(product.Count / (float)maxCount * 100.0f);
                product.SizePercent = Convert.ToInt32(product.Size / (float)maxSize * 100.0f);
                if (product.Size == 0)
                    product.Status = "Отсутствует товар на складе";
                else if (product.Size >= maxSize * 0.8)
                    product.Status = "Избыток товара на складе";
                else if (product.Size <= maxSize * 0.2)
                    product.Status = "Недостаток товара на складе";
                else
                    product.Status = "Товар есть на складе";
            }
            return result.OrderBy(p => p.Name);
        }

        public static IEnumerable<HistoryProductWebModel> ToHistoryWebModel(this IEnumerable<Product> products)
        {
            var history = products.GroupBy(p => p.DateTime.Date).ToList();
            var result = history.OrderByDescending(h => h.Key).Select(h => new HistoryProductWebModel
            {
                DateTime = h.Key,
                Products = h.OrderByDescending(p => p.DateTime).ToWebModel(),
            });
            return result;
        }
    }
}
