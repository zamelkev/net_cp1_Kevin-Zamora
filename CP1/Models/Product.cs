using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models {
    public class Product {
        //[Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Coste { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Manufacturer? Fabricante;
        public Manufacturer getFabricante() {
            return Fabricante;
        }
        public void setFabricante(string f) {
            this.Fabricante = f;
        }
        /*
            https://riptutorial.com/csharp/example/25690/implementing-icloneable-in-a-class
        public Product(int id, string nombre, double peso, double precio, int cantidad, double coste, DateTime fechaCreacion, Manufacturer? fabricante) {
            this.Id = other.Id;
            Nombre = nombre;
            Peso = peso;
            Precio = precio;
            Cantidad = cantidad;
            Coste = coste;
            FechaCreacion = fechaCreacion;
            Fabricante = fabricante;
        }
        */
        public override string ToString() {
            return $"Producto '{Nombre}'; fabricado por {Fabricante}, almacenado en la posición {Id} (dentro de la base de datos) y con un Peso de {Peso}. Actualmente hay {Cantidad} unidades en 'stock'. Presenta un precio de venta de {Precio} Y la fecha de creación fue: {FechaCreacion}";
        }
        /*
        #region ICloneable Members
        // Type safe Clone
        public Product Clone() { return new Product(this); }
        // ICloneable implementation
        object ICloneable.Clone() {
            return Clone();
        }
        #endregion
        */
    }
}
