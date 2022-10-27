using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_cp1_Kevin_Zamora;

public class Product {

    int Id { get; set; }
    string Nombre { get; set; }
    int Peso { get; set; }
    float Precio { get; set; }
    int Cantidad { get; set; }
    float Coste { get; set; }
    DateTime FechaCreacion { get; set; }
    Manufacturer Fabricante { get; set; }


    public override string ToString() {
        return $"Producto fabricado por {Fabricante} con: Id {Id} y Nombre {Nombre} y con un Peso de {Peso}. Actualmente hay en 'stock' {Cantidad} unidades. La fecha de creación fue: {FechaCreacion}";
    }



}
