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

            return FindById(id) != null;
        }

        public Manufacturer FindById(int id);

        public List<Manufacturer> FindAll();
        public void PrintAll();

        public bool ThisManufacturerExist(string name);

        public int TellMeManufacturerId(string name);

        public int FindMaxManufacturerId();

        public void AddNewManufacturer(string newManufacturer, bool exist);

        public Manufacturer UpdateManufacturer(int Id, string newName);



        public bool DeleteById(int id);

    }
}
