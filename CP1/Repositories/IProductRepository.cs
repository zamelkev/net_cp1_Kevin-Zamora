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

        public List<Product> FindAll();

        public List<Product> FindByPrice(float price);

    }
}
