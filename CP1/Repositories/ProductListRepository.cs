using System;
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

        foreach (Product product in products)
            Console.WriteLine(product); 

    }

    public List<Product> FindByPrice(double minPrice, double maxPrice) {

        List<Product> productsByPrice = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Precio >= minPrice)
            {
                if (product.Precio >= maxPrice)
                {
                    productsByPrice.Add(product);
                }
            }
            else
            {
                Console.WriteLine("No se han encontrado productos con este precio");
                return null;
            }
        }
        Console.WriteLine("Se han encontrado los siguientes productos: \n");
        foreach (Product product in productsByPrice)
            Console.WriteLine(product);
        return productsByPrice;

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
            if ((product.Fabricante.ToString().ToLower()).Equals(fabricante.ToLower()))
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


    public int FindMaxId() {

        int maxId = 0;

        foreach (Product product in products)
            if (maxId < product.Id)
                maxId = product.Id;

        return maxId;

    }

    public bool Save(Product product) {

        int maxId = FindMaxId();
        int nextId = maxId++;

        product.Id = nextId;
        products.Add(product);

        Console.WriteLine("El producto se ha añadido correctamente");

        return true;

    }
    


    public Product UpdateProduct(int Id) {
        Product updatedProduct = new Product{};
        foreach (Product product in products)
        {
            if (ExistsById(Id))
                return null;
            if (product.Id == Id)
            {
                int productId = product.Id;
                Manufacturer productManufacturer = product.Fabricante;
                updatedProduct = new Product { Id = productId, Nombre = "Pelota", Cantidad = 6, Coste = 2, Peso = 1, 
                    Precio = 4, Fabricante = productManufacturer, FechaCreacion = new DateTime(2021, 3, 15)
                };
                products.Add(updatedProduct);
                Console.WriteLine($"El elemento se ha actuallizado correctamente y ha quedado así: {UpdateProduct}");
                return updatedProduct;
            } else
            {
                Console.WriteLine("No se ha encontrado el producto referido, no se ha podido actualizar");
                return null;
            }
            
        }
        return updatedProduct;
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

        float sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio;

        return (double)sum;
    }

    public double CalculateGrossBenefit() {

        float sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio;

        return (double)sum;
    }

    public double CalculateNetProfit() {

        float sum = 0;

        foreach (Product comp in products)
            sum += comp.Precio - comp.Coste;

        return (double)sum;
    }


    public List<Product> GetProductsWithIVA ( int IVA = 21 ) {

        List<Product> productsWithIVA = new List<Product>();

        if (!products.Any())
            return null;

        foreach (Product comp in products)
        {
            float aux = comp.Precio * (1 + (IVA/100));
            comp.Precio = aux;
            productsWithIVA.Add(comp);
        }
        
        return productsWithIVA;
    }


}


