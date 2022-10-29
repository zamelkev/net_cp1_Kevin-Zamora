using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models {
    public class Product {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Peso { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public float Coste { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Manufacturer Fabricante { get; set; }


        public override string ToString() {
            return $"Producto fabricado por {Fabricante} con: Id {Id} y Nombre {Nombre} y con un Peso de {Peso}. Actualmente hay en 'stock' {Cantidad} unidades. La fecha de creación fue: {FechaCreacion}";
        }

    }
}
