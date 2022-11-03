using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models {
    public class Manufacturer {

        [Key]
        public int Id { get; set; }

        public String Nombre;
        public String getNombre() {
            return Nombre;
        }
        public void setNombre(string n) {
            this.Nombre = n;
        }


        public List<Product> products = new List<Product>();

        public Manufacturer() { }

        public override string ToString() {
            return $"ID: {Id}, Fabricante: {Nombre}";
        }

        public static implicit operator Manufacturer(string v) {
            throw new NotImplementedException();
        }
    }
}
