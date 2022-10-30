using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;

namespace CP1.Repositories {
    public interface IManufacturerRepository {

        public bool ExistsById(int id) {

            return FindById(id) != null; // true o false
        }

        public Manufacturer FindById(int id);

        public List<Manufacturer> FindAll();





        public int FindMaxId();

        public bool Save(Manufacturer manufacturer);

        public Manufacturer UpdateManufacturer(int Id);



        public bool DeleteById(int id);

    }
}
