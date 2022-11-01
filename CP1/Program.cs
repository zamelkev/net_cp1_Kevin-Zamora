using CP1;
using System.Xml.Linq;
using System;
using System.Text;
using CP1.Repositories;
using CP1.Models;



IProductRepository productRepo = new ProductListRepository();

IManufacturerRepository manufacturerRepo = new ManufacturerListRepository();



ConsoleKeyInfo isPressedKey;

do
{
    Console.WriteLine("BIENVENIDX A NUESTRA APLICACIÓN");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("EL SIGUIENTE MENÚ DE OPCIONES SE MOSTRARÁ RECURRENTEMENTE HASTA QUE SE PULSE LA LETRA 'E', PARA SALIR");
    Console.WriteLine("(PULSA UNA TECLA PARA MOSTRARLO)");


    isPressedKey = Console.ReadKey(true);

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
    Console.WriteLine("O PULSE LA TECLA (E) PARA SALIR");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("SELECCIONE UNA OPCIÓN INTRODUCIENDO UN NÚMERO DEL 1 AL 18");


    // DESARROLLO DE LAS OPCIONES

    switch (Console.ReadLine())
    {
        case "1":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 1");
            Console.WriteLine("Introduce una dirección Id: ");
            int num = Convert.ToInt32(Console.ReadLine());
            productRepo.FindById(num);
            Console.ReadKey();

            break;
        case "2":
            /*Console.Clear();
            Console.WriteLine("MUESTRA VALORES DEL 1 AL 50:");*/
            Console.WriteLine("OPCIÓN 2");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "3":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 3");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "4":
            // Console.Clear();

            Console.WriteLine("OPCIÓN 4");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "5":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 5");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "6":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 6");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "7":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 7");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
        case "8":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 8");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "9":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 9");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "10":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 10");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "11":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 11");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "12":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 12");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "13":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 13");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "14":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 14");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "15":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 15");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "16":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 16");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "17":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 17");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        case "18":
            // Console.Clear();
            Console.WriteLine("OPCIÓN 8");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            break;
        default:
            // Console.Clear();
            /*if (isPressedKey.Key == ConsoleKey.E)
            {
                isPressedKey = Console.ReadKey(false);
                break;
            }*/
            Console.WriteLine("ESTA OPCIÓN NO EXISTE");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();

            break;
    }


} while (isPressedKey.Key == ConsoleKey.E);

































