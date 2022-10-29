using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net_cp1_Kevin_Zamora.Models;
using net_cp1_Kevin_Zamora.Repositories;

namespace net_cp1_Kevin_Zamora;

public class Manufacturer {
    [Key]
    public int Id { get; set; }
    public String Nombre { get; set; }

    

    public List<Product> products = new List<Product>();
    
    public Manufacturer() { }





}

