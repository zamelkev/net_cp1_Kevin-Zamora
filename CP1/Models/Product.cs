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
            return $"Producto '{Nombre}'; fabricado por {Fabricante}, almacenado en la posición {Id} (dentro de la base de datos) y con un Peso de {Peso}. Actualmente hay {Cantidad} unidades en 'stock'. Y la fecha de creación fue: {FechaCreacion}";
        }

    }
}
