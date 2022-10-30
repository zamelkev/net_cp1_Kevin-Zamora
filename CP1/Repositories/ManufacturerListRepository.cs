using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;

namespace CP1.Repositories {
    public class ManufacturerListRepository : IManufacturerRepository {

        public List<Manufacturer> manufacturers = new List<Manufacturer> {
            new Manufacturer { Nombre = "Apple"},
            new Manufacturer { Nombre = "DELL"},
            new Manufacturer { Nombre = "Lenovo"},
        };

        
            public bool ExistsById(int id) {

                return FindById(id) != null; // true o false
            }

            public Manufacturer FindById(int id) {

                foreach (Manufacturer manufacturer in manufacturers)
                {
                    if (manufacturer.Id == id)
                        Console.WriteLine($"Se ha encontrado el siguente fabricante al buscar por ID: \n");
                    return manufacturer;

                }
                Console.WriteLine("No se ha encontrado nada, en la busqueda, con la ID introducida");
                return null;
            }

            public List<Manufacturer> FindAll() {
                return manufacturers;
            }

            

            

            public int FindMaxId() {

                int maxId = 0;

                foreach (Manufacturer manufacturer in manufacturers)
                    if (maxId < manufacturer.Id)
                        maxId = manufacturer.Id;

                return maxId;

            }

            public bool Save(Manufacturer manufacturer) {

                int maxId = FindMaxId();
                int nextId = maxId++;

                manufacturer.Id = nextId;
                manufacturers.Add(manufacturer);

                Console.WriteLine("El nuevo fabricante se ha añadido correctamente");

                return true;

            }

        public Manufacturer UpdateManufacturer(int Id) {
            Manufacturer updatedManufacturer = new Manufacturer { };
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (ExistsById(Id))
                    return null;
                    if (manufacturer.Id == Id)
                    {
                        manufacturer.Nombre = "MSI";
                    };
                    manufacturers.Add(updatedManufacturer);
                    Console.WriteLine($"El elemento se ha actuallizado correctamente y ha quedado así: {UpdateManufacturer}");
                    return updatedManufacturer;
            }
            return null;

        }
        
        

        public bool DeleteById(int id) {

                // comprobar si existe 
                if (!ExistsById(id))
                    return false; // si no existe no lo podemos borrar

                for (int i = 0; i < manufacturers.Count; i++)
                {

                    if (manufacturers[i].Id == id)
                    {
                        manufacturers.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }

            

    }
}
