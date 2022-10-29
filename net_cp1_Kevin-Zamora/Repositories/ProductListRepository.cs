using net_cp1_Kevin_Zamora.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net_cp1_Kevin_Zamora.Repositories;
using net_cp1_Kevin_Zamora.Models;

namespace net_cp1_Kevin_Zamora;
public class ProductListRepository : IProductRepository {

        public List<Product> products = new List<Product> {
            new Product{ Nombre = "Macbook Pro", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 5, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2022, 2, 1) },
            new Product{ Nombre = "Macbook Air", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 15, Peso = 1, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 2, 1) },
            new Product{ Nombre = "Ideopad", Fabricante =  new Manufacturer { Nombre = "Lenovo" }, Cantidad = 10, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 3, 15) },

        };


           
        
public Models.Product FindById(int id) {

        foreach (Product product in products)
        {
            if (product.Id == id)
                return product;
        }

        return null;
    }






}

