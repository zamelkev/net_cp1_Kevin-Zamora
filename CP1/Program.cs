using CP1;
using System.Xml.Linq;
using CP1.Repositories;
using CP1.Models;



IProductRepository productRepo = new ProductListRepository();

IManufacturerRepository manufacturerRepo = new ManufacturerListRepository();


bool condition = true;


// while (condition)
do
{
    Console.Clear();
    Console.WriteLine("BIENVENIDX A NUESTRA APLICACIÓN");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("EL SIGUIENTE MENÚ DE OPCIONES SE MOSTRARÁ RECURRENTEMENTE HASTA QUE SE PULSE LA LETRA 'E', PARA SALIR");
    Console.WriteLine("(PULSA UNA TECLA PARA MOSTRARLO)");

    ConsoleKeyInfo currentKey = Console.ReadKey(true);

    // Imprimir MENÚ INTERACTIVO RECURRENTE
    Console.WriteLine("---------------------------------");
    Console.WriteLine("--- ELIGE UNA OPCIÓN DEL MENÚ ---");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("- Operaciones con los productos: -");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1) ENCONTRAR PRODUCTO POR ID (FindById)");
    Console.WriteLine("2) ENCONTRAR TODOS LOS PRUDUCTOS (FindAll)");
    Console.WriteLine("3) ENCONTRAR PRODUCTOS POR RANGO DE PRECIOS");
    Console.WriteLine("4) ENCONTRAR PRODUCTOS POR FECHA DE CREACIÓN ANTERIOR A LA FECHA INTRODUCIDA");
    Console.WriteLine("5) ENCONTRAR PRODUCTOS POR NOMBRE DE FABRICANTE");
    Console.WriteLine("6) GUARDAR NUEVO PRODUCTO EN LA LISTA");
    Console.WriteLine("7) ACTUALIZAR UN PRODUCTO EXISTENTE");
    Console.WriteLine("8) BORRAR PRODUCTO POR ID");
    Console.WriteLine("9) BORRAR TODOS LOS PRODUCTOS");
    Console.WriteLine("10) CALCULAR LA SUMA TOTAL DE LOS PRECIOS");
    Console.WriteLine("11) CALCULAR EL BENEFICIO BRUTO");
    Console.WriteLine("12) CALCULAR EL BENEFICIO NETO");
    Console.WriteLine("13) CALCULAR LOS PRECIOS CON EL IVA");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("- Operaciones con los fabricantes: -");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("14) BUSCAR POR ID");
    Console.WriteLine("15) BUSCAR TODOS");
    Console.WriteLine("16) GUARDAR NUEVO FABRICANTE");
    Console.WriteLine("17) ACTUALIZAR FABRICANTE");
    Console.WriteLine("18) BORRAR FABRICANTE POR ID");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("O PULSE LA TECLA (ESCAPE) PARA SALIR");
    Console.WriteLine("---------------------------------");

    // ConsoleKeyInfo pressedKey = Console.ReadKey();
    // if (pressedKey == pressedKey.KeyChar.) condition = false;

    Console.WriteLine("---------------------------------");
    Console.WriteLine("SELECCIONE UNA OPCIÓN INTRODUCIENDO UN NÚMERO DEL 1 AL 18");


    // DESARROLLO DE LAS OPCIONES

    switch (Console.ReadLine()) {
        case "1":
            Console.WriteLine("OPCIÓN 1: BUSCAR PRODUCTO POR ID");
            Console.WriteLine("Introduce una dirección Id: ");
            int num = Convert.ToInt32(Console.ReadLine());
            productRepo.FindById(num);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("OPCIÓN 2: MUESTRA TODOS LOS PRODUCTOS");
            List<Product> products = productRepo.FindAll();
            productRepo.PrintAll();
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("OPCIÓN 3: BUSCAR PRODUCTOS POR RANGO DE PRECIO");
            Console.WriteLine("Introduce precio mínimo:");
            double minPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce precio máximo:");
            double maxPrice = Convert.ToDouble(Console.ReadLine());
            List<Product> productsByPrice = productRepo.FindByPrice(minPrice, maxPrice);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "4":
            Console.WriteLine("OPCIÓN 4: MOSTRAR PRODUCTOS POSTERIORES A LA FECHA INTRODUCIDA");
            Console.WriteLine("Introduce el día:");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el mes:");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el año:");
            int año = Convert.ToInt32(Console.ReadLine());
            productRepo.FindByCreationDateTime(dia, mes, año);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "5":

            Console.WriteLine("OPCIÓN 5: MOSTRAR PRODUCTOS POR FABRICANTE");
            Console.WriteLine("Introduce el fabricante a buscar:");
            string manufacturer1 = Console.ReadLine();
            productRepo.FindByManufacturer(manufacturer1);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "6":
            
            Console.WriteLine("OPCIÓN 6: AÑADIR NUEVO PRODUCTO \n");
            Console.WriteLine("Introduce el nombre del producto:");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("Introduce la cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el fabricante:");
            string fabricanteABuscar = Console.ReadLine();
            Console.WriteLine("Introduce su peso:");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce su precio de venta (sin IVA):");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce su precio de coste:");
            double precioCoste = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("( Fecha de Creación )");
            Console.WriteLine("Introduce el día:");
            int diaCreacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el mes:");
            int mesCreación = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el año:");
            int añoCreación = Convert.ToInt32(Console.ReadLine());

            DateTime fechaCreación = new DateTime(añoCreación, mesCreación, diaCreacion);
            
            bool exist1 = manufacturerRepo.ThisManufacturerExist(fabricanteABuscar);
            if (!exist1)
            {
                manufacturerRepo.AddNewManufacturer(fabricanteABuscar, exist1);
            }
            else { Console.WriteLine("El fabricante se ha detectado correctamente"); }

            exist1 = manufacturerRepo.ThisManufacturerExist(fabricanteABuscar);
            Product productToAdd = new Product { Nombre = nombreProducto, Cantidad = cantidad, Peso = peso, Precio = precio, Coste = precioCoste, FechaCreacion = fechaCreación, Fabricante = new Manufacturer { Nombre = fabricanteABuscar } };
            productRepo.SaveNewProduct(productToAdd);

            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "7":

            Console.WriteLine("OPCIÓN 7: ACTUALIZAR PRODUCTO EXISTENTE \n");
            Console.WriteLine("Introduce el ID del producto a actualizar:");
            int idABuscar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Intruduce el nombre del fabricante al que pertenece:");
            string manufacturerToFind = Console.ReadLine();
            bool existId = productRepo.ExistsById(idABuscar);
            if (!existId)
            {
                Console.WriteLine("No se ha encontrado el ID");
            }
            bool existManufacturer = manufacturerRepo.ThisManufacturerExist(manufacturerToFind);
            if (!existManufacturer)
            {
                Console.WriteLine("No se ha encontrado el fabricante. Vuelve al menú y créalo");
            }
            else
            {
                Console.WriteLine("Intruduce el nombre del producto actualizado:");
                string productNameToUpdate = Console.ReadLine();
                Console.WriteLine("Introduce la nueva cantidad de producto:");
                int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el nuevo precio para el producto:");
                double nuevoPrecio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce el nuevo coste del producto:");
                double nuevoCoste = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce el nuevo peso del producto:");
                double nuevoPeso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce la fecha de entrada modificada:");
                Console.WriteLine("Día:");
                int diaEntrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mes:");
                int mesEntrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Año:");
                int aEntrada = Convert.ToInt32(Console.ReadLine());
                int idFabricante = manufacturerRepo.TellMeManufacturerId(manufacturerToFind);
                try
                {
                    productRepo.UpdateProduct(idABuscar, productNameToUpdate,
                        nuevaCantidad, manufacturerToFind, diaEntrada, mesEntrada, aEntrada, nuevoPeso, nuevoPrecio,
                         nuevoCoste, existManufacturer, idFabricante);
                }
                catch { 
                   // Console.WriteLine("Se está modificando un elemento al mismo tiempo que se recorre la lista"); 
                }
                productRepo.PrintAll();
            }
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "8":

            Console.WriteLine("OPCIÓN 8: BORRAR PRODUCTO POR ID");
            Console.WriteLine("Introduce ID del producto a borrar:");
            int idToSearch = Convert.ToInt32(Console.ReadLine());
            bool isDeleted = productRepo.DeleteById(idToSearch);
            if (isDeleted) { Console.WriteLine("El producto se ha borrado correctamente"); };
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "9":

            Console.WriteLine("OPCIÓN 9: BORRAR TODOS LOS PRODUCTOS");
            bool allDeleted = productRepo.DeleteAll();
            if (allDeleted) { Console.WriteLine("Se han borrado todos los productos de la lista"); };
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "10":

            Console.WriteLine("OPCIÓN 10: CALCULAR SUMA TOTAL DE LOS PRECIOS");
            double suma = productRepo.CalculatePricesSum();
            if (suma == 0) { Console.WriteLine("La lista está vacia"); } else { Console.WriteLine("La suma de los precios de los productos es: " + suma); }
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "11":

            Console.WriteLine("OPCIÓN 11: CALCULAR BENEFICIO BRUTO");
            double beneficioBruto = productRepo.CalculateGrossBenefit();
            Console.WriteLine("El beneficio bruto, resultado de la mera suma del precio de los productos, es: " + beneficioBruto);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "12":

            Console.WriteLine("OPCIÓN 12: CALCULAR BENEFICIO NETO");
            double beneficioNeto = productRepo.CalculateNetProfit();
            Console.WriteLine("El beneficio neto, resultado de la resta del precio de venta de los productos menos su coste, realizándola para todos los productos de la lista, es: " + beneficioNeto);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "13":

            Console.WriteLine("OPCIÓN 13: MOSTRAR TODOS LOS PRODUCTOS CON EL IVA INCLUIDO");
            Console.WriteLine("Introduce el porcentaje de IVA a sumar (sólo el excedente entero (PE: 21)):");
            int IVA = Convert.ToInt32(Console.ReadLine());
            productRepo.GetProductsWithIVA();
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "14":
            Console.WriteLine("OPCIÓN 14: BUSCAR FABRICANTE POR ID");
            Console.WriteLine("Introduce el Id del fabricante a buscar:");
            int manufacturerId = Convert.ToInt32(Console.ReadLine());
            manufacturerRepo.FindById(manufacturerId);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "15":

            Console.WriteLine("OPCIÓN 15: MOSTRAR TODOS LOS FABRICANTES");
            List<Manufacturer> manufacturers = manufacturerRepo.FindAll();
            manufacturerRepo.PrintAll();
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "16":
            Console.WriteLine("OPCIÓN 16: AÑADIR NUEVO FABRICANTE");
            Console.WriteLine("Introduce el nombre del fabricante");
            string nombreFabricante = Console.ReadLine();
            bool exist = manufacturerRepo.ThisManufacturerExist(nombreFabricante);
            manufacturerRepo.AddNewManufacturer(nombreFabricante, exist);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "17":
            Console.WriteLine("OPCIÓN 17: ACTUALIZAR FABRICANTE");
            Console.WriteLine("Introduce el Id de fabricante a actualizar: ");
            int idToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nuevo nombre de fabricante: ");
            string updatedManufacturer = Console.ReadLine();
            manufacturerRepo.UpdateManufacturer(idToFind, updatedManufacturer);
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "18":

            Console.WriteLine("OPCIÓN 18: BORRAR FABRICANTE POR ID");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("ESTA OPCIÓN NO EXISTE");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
    }
}
while (Console.ReadKey(true).Key != ConsoleKey.X);

Console.WriteLine("Has salido del bucle DO WHILE");

Console.WriteLine("El programa ha llegado a su FIN");

































