using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_cp1_Kevin_Zamora;
public class Manufacturer {

    int Id { get; set; }
    string Nombre { get; set; }

    List<Product> products { get; set; }

    public Manufacturer() { }

}
