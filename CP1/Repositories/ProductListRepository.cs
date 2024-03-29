﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;


namespace CP1.Repositories; 
public class ProductListRepository : IProductRepository {

    // Atributos
    private List<Product> products;
    
    // Constructor
    public ProductListRepository() {
        // Simulamos que la lista products es una base de datos
        products = new List<Product> {
            new Product{ Id = 1, Nombre = "Macbook Pro", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 5, Peso = 2.25f, Coste = 500.75f, Precio = 1994.99f, FechaCreacion = new DateTime(2022, 2, 1) },
            new Product{ Id = 2, Nombre = "Macbook Air", Fabricante =  new Manufacturer { Nombre = "Apple" }, Cantidad = 15, Peso = 1.5f, Coste = 256.25f, Precio = 998.99f, FechaCreacion = new DateTime(2021, 2, 1) },
            new Product{ Id = 3, Nombre = "Ideopad", Fabricante =  new Manufacturer { Nombre = "Lenovo" }, Cantidad = 10, Peso = 2.1f, Coste = 250.5f, Precio = 800.0f, FechaCreacion = new DateTime(2021, 3, 15) },
        };
        
    }

    public bool ExistsById(int id) {

        return FindById(id) != null;
    }

    public Product FindById(int id) {

        foreach (Product product in products)
        {
            if (product.Id == id)
            {
                Console.WriteLine("Se ha encontrado el siguiente producto: \n" + product);
                return product;
            }
        }
        Console.WriteLine("No se ha encontrado ningún producto");
        return null;
    }

    public List<Product> FindAll() {
        return products;
    }

    public void PrintAll() {
        if (!products.Any()) { Console.WriteLine("La lista de productos está vacia"); }
        else
        {
            foreach (Product product in products)
                Console.WriteLine(product);
        }
    }

    public List<Product> FindByPrice(double minPrice, double maxPrice) {

        List<Product> productsByPrice = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Precio >= minPrice)
            {
                if (product.Precio <= maxPrice)
                {
                    productsByPrice.Add(product);
                }
            }
            else
            {
                Console.WriteLine("No se han encontrado productos con ese rango de precios");
                return null;
            }
        }
        if (productsByPrice.Any()) { 
            Console.WriteLine("Se han encontrado los siguientes productos: \n");
            foreach (Product product in productsByPrice)
                Console.WriteLine(product);
            return productsByPrice;
        }
        else
        {
            Console.WriteLine("No se han encontrado productos con ese rango de precios");
        }
        return null;
    }

    public List<Product> FindByCreationDateTime(int Day, int Month, int Year) {

        List<Product> productsByCreationDate = new List<Product>();

        foreach (Product product in products)
        {
            DateTime auxDate = new DateTime ( Year, Month, Day );
            int result = DateTime.Compare(product.FechaCreacion, auxDate);
            if ( result > 0)
            {
                
                productsByCreationDate.Add(product);
                
            } 
        }
        if (productsByCreationDate.Count == 0)
            Console.WriteLine("No se han encontrado productos amteriores a esta fecha");
        if (productsByCreationDate.Count > 0)
        {
            Console.WriteLine("Se han encontrado los siguientes productos: ");
            foreach (Product product in productsByCreationDate)
            {
                Console.WriteLine(product);
            }
            return productsByCreationDate;
        }
        return productsByCreationDate;
    }

    public List<Product> FindByManufacturer(string fabricante) {

        List<Product> productsByManufacturer = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Fabricante.Nombre.ToLower().Equals(fabricante.ToLower()))
            {

                productsByManufacturer.Add(product);

            }
        }
        if (productsByManufacturer.Count == 0)
            Console.WriteLine("No se han encontrado productos fabricados por ese fabricante");
        if (productsByManufacturer.Count > 0)
        {
            Console.WriteLine("Se han encontrado los siguientes productos: ");
            foreach (Product product in productsByManufacturer)
            {
                Console.WriteLine(product);
            }
            return productsByManufacturer;
        }
        return productsByManufacturer;
    }


    public int FindMaxProductId() {

        int maxId = 0;

        foreach (Product product in products)
            if (maxId < product.Id)
                maxId = product.Id;

        return maxId;

    }

    public bool SaveNewProduct(Product product) {

        int maxId = FindMaxProductId();
        int nextId = maxId++;

        product.Id = nextId;
        products.Add(product);

        Console.WriteLine("El producto se ha añadido correctamente");

        return true;

    }
    


    public Product UpdateProduct(int Id, string productNameToUpdate, int cantidad, string fabricante, int dia, int mes, int año, double peso, double precio, double coste, bool existeFabricante, int mId) {
        
        foreach (Product product in products)
        {
            if (product.Id == Id)
            {
                DateTime FechaCreacion = new DateTime(año, mes, dia);
                Manufacturer f1 = new Manufacturer { Id = mId, Nombre = fabricante };

                product.Id = product.Id;
                product.Nombre = productNameToUpdate;
                product.Cantidad = cantidad;
                product.Coste = coste;
                product.Peso = peso;
                product.Precio = precio;
                product.Fabricante = f1;
                product.FechaCreacion = FechaCreacion;
                
                Console.WriteLine($"El elemento se ha actualizado correctamente");
                return product;
            }
            if (!ExistsById(Id))
            {
                Console.WriteLine("No se ha encontrado el producto referido y no se ha podido actualizar");
                return null;
            }
            return null;
        }
        return null;
    }

    public bool DeleteById(int id) {

        // comprobar si existe 
        if (!ExistsById(id))
            return false; // si no existe no lo podemos borrar

        for (int i = 0; i < products.Count; i++)
        {

            if (products[i].Id == id)
            {
                products.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool DeleteAll() {

        if (!products.Any())
            return false;


        products.Clear();
        return true;
    }

    public double CalculatePricesSum() {

        double sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio;

        return (double)sum;
    }

    public double CalculateGrossBenefit() {

        double sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio;

        return (double)sum;
    }

    public double CalculateNetProfit() {

        double sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio - comp.Coste;

        return (double)sum;
    }

    private List<Product> Clone() {
        List<Product> clone = new List<Product>();
        foreach (Product comp in products)
        {
            clone.Add((Product)comp.Clone());
        }
        return clone;
    }

    public List<Product> GetProductsWithIVA ( double IVA = 21 ) {

        List<Product> productsWithIVA = Clone();

        if (IVA < 0)
        {
            Console.WriteLine("No se puede operar con un valor negativo; en consecuencia, se utilizara el valor preestablecido (21%)");
            return null;
        }

        if (!products.Any())
        {
            Console.WriteLine("La lista se encuentra vacia, por ende no se puede realizar dicha operación");
            return null;
        }

        Console.WriteLine("Lista de productos original: ");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Lista de productos con IVA: ");
        foreach (Product product in productsWithIVA)
        {
            double ivaConvertion = IVA/100;
            // Console.WriteLine("Se va a incrementar el siguiente porcentaje: " + ivaConvertion);
            double incrementoIVA = (1 + ivaConvertion);
            // Console.WriteLine("Se va a multiplicar por el siguiente tanto por uno: " + incrementoIVA);
            // Console.WriteLine("El precio previo a la operación es el siguiente también: " + product.Precio);
            product.Precio = Convert.ToDouble(product.Precio) * incrementoIVA;
            Console.WriteLine(product);
        }
        return productsWithIVA;
    }


}


