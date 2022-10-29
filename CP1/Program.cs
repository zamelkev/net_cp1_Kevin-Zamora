using CP1;
using System;
using System.Xml.Linq;
using CP1.Models;
using CP1.Repositories;


public class program {

    public static void Main() {

        // Console.WriteLine("Main Method");

        public List<Product> products = new List<Product> {
        new Product{ Nombre = "Macbook Pro", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 5, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2022, 2, 1) },
        new Product{ Nombre = "Macbook Air", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 15, Peso = 1, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 2, 1) },
        new Product{ Nombre = "Ideopad", Fabricante =  new Manufacturer { Nombre = "Lenovo" }, Cantidad = 10, Peso = 2, Coste = 500, Precio = 2000, FechaCreacion = new DateTime(2021, 3, 15) },
        };
            /*
            Console.WriteLine("Introduce una dirección Id: ");
            int num = Convert.ToInt32(Console.ReadLine());
            IProductRepository.FindById(num);
            */

    }
 }

    

    




    











