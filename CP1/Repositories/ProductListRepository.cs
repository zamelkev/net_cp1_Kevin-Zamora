using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;

namespace CP1.Repositories; 
public class ProductListRepository : IProductRepository {

    public List<Product> products = new List<Product> {
        new Product{ Nombre = "Macbook Pro", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 5, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2022, 2, 1) },
        new Product{ Nombre = "Macbook Air", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 15, Peso = 1, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 2, 1) },
        new Product{ Nombre = "Ideopad", Fabricante =  new Manufacturer { Nombre = "Lenovo" }, Cantidad = 10, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 3, 15) },

    };




    public Product FindById(int id) {

        foreach (Product product in products)
        {
            if (product.Id == id)
                Console.WriteLine($"Se ha encontrado el siguente producto al buscar por ID: \n");
                return product;

        }
        Console.WriteLine("No se ha encontrado nada, en la busqueda, con la ID introducida");
        return null;
    }

    public List<Product> FindAll() {
        return products;
    }
    
    public List<Product> FindByPrice(float price) {

        List<Product> productsByPrice = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Precio == price)
            {
                Console.WriteLine("Se han encontrado los siguientes productos: ");
                productsByPrice.Add(product);
                return productsByPrice;
            }
            Console.WriteLine("No se han encontrado productos con este precio");
            return null;
        }
        return null;

    }

    public List<Product> FindByCreationDateTime(DateTime introducedDate) {

        List<Product> productsByCreationDate = new List<Product>();

        foreach (Product product in products)
        {
            if (product.FechaCreacion == introducedDate)
            {
                Console.WriteLine("Se han encontrado los siguientes productos: ");
                productsByCreationDate.Add(product);
                return productsByCreationDate;
            }
            Console.WriteLine("No se han encontrado productos con esta fecha");
            return null;
        }
        return null;

    }




}


