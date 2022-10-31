using CP1;
using System.Xml.Linq;
using CP1.Repositories;

Console.WriteLine("Main Method");

IProductRepository productRepo = new ProductListRepository();

Console.WriteLine("Introduce una dirección Id: ");
int num = Convert.ToInt32(Console.ReadLine());
productRepo.FindById(num);



    

    




    











