using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;

namespace CP1.Repositories {
    public interface IProductRepository {

        public Product FindById(int id);

        public void PrintAll();

        public List<Product> FindAll();

        public List<Product> FindByPrice(double minPrice, double maxPrice);

        public List<Product> FindByCreationDateTime(DateTime introducedDate);

        public List<Product> FindByManufacturer(string fabricante);

        public Product UpdateProduct(int Id);

        public bool DeleteById(int id);

        public bool DeleteAll();

        public double CalculatePricesSum();

        public double CalculateNetProfit();

        public int FindMaxId();
        public bool Save(Product product);

    }
}
