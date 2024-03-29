﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP1.Models;
using CP1.Repositories;

namespace CP1.Repositories {
    public class ManufacturerListRepository : IManufacturerRepository {

        public List<Manufacturer> manufacturers = new List<Manufacturer> {
            new Manufacturer { Id = 1, Nombre = "Apple"},
            new Manufacturer { Id = 2, Nombre = "DELL"},
            new Manufacturer { Id = 3, Nombre = "Lenovo"},
        };


        public bool ExistsById(int id) {

            return FindById(id) != null; // true o false
        }

        public Manufacturer FindById(int id) {

            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.Id == id)
                {
                    Console.WriteLine($"Se ha encontrado el siguente fabricante al buscar por ID: ");
                    Console.WriteLine(manufacturer);
                    return manufacturer;
                }
            }
            Console.WriteLine("No se ha encontrado nada, en la busqueda, con la ID introducida");
            return null;
        }

        public List<Manufacturer> FindAll() {
            return manufacturers;
        }

        public void PrintAll() {
            if (!manufacturers.Any()) { Console.WriteLine("La lista de productos está vacia"); }
            else
            {
                foreach (Manufacturer manufacturer in manufacturers)
                    Console.WriteLine(manufacturer);
            }
        }

        public bool ThisManufacturerExist(string name) {
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if ((manufacturer.Nombre.ToString().ToLower()).Equals(name.ToLower()))
                {

                    return true;

                }
                else { return false; }
            }
            return false;
        }
        public int TellMeManufacturerId(string name) {
            int id;
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if ((manufacturer.Nombre.ToString().ToLower()).Equals(name.ToLower()))
                {

                    id = manufacturer.Id;
                    return id;

                }
                else { return id = 0101; }
            }
            return id = 0101;
        }

        public int FindMaxManufacturerId() {

            int maxId = 0;

            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (maxId < manufacturer.Id)
                    maxId = manufacturer.Id;
            }
            return maxId;

        }

        public void AddNewManufacturer(string newManufacturer, bool exist) {
            if (!exist)
            {
                int nextId = FindMaxManufacturerId() + 1;
                Manufacturer manufacturer = new Manufacturer { Id = nextId, Nombre = newManufacturer };
                manufacturers.Add(manufacturer);
                Console.WriteLine("Se ha añadido el siguiente fabricante:");
                Console.WriteLine(manufacturer);
            }
            else
            {
                Console.WriteLine("El fabricante introducido ya existe, por ende no se ha añadido");
                foreach (Manufacturer manufacturer in manufacturers)
                {
                    if (manufacturer.Nombre.ToLower().Equals(newManufacturer.ToLower()))
                        Console.WriteLine(manufacturer);
                }
                
            }
        }

        public Manufacturer UpdateManufacturer(int Id, string newName) {
            
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (!ExistsById(Id))
                    return null;
                if (newName == null)
                    return null;
                if (manufacturer.Id == Id)
                {
                    manufacturer.Nombre = newName;
                    Console.WriteLine($"El elemento se ha actuallizado correctamente y ha quedado así: ");
                    Console.WriteLine(manufacturer);
                    return manufacturer;
                };
                    
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
                    Console.WriteLine("El fabricante seleccionado ha sido borrado");
                        return true;
                    }
                }
                return false;
            }

            

    }
}
