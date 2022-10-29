
using net_cp1_Kevin_Zamora.Models;
using net_cp1_Kevin_Zamora.Repositories;

namespace net_cp1_Kevin_Zamora;

public class Consola {
    public static void Main() {
        Console.WriteLine("--- ELIGE UNA OPCIÓN DEL MENÚ ---");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1) BUSCA PRODUCTO POR ID");
        

        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Console.WriteLine("MUESTRA UN MENSAJE:");

                Console.WriteLine("\n Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("MUESTRA VALORES DEL 1 AL 50:");

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("MUESTRA VALORES ENTRE 2 CIFRAS INTRODUCIDAS:\n");
                Console.WriteLine("Introduce el valor inicial: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el valor final: ");
                int valor2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("MUESTRA VALORES ENTRE 2 CIFRAS INTRODUCIDAS, CONCATENADAS CON UN MENSAJE:\n");
                Console.WriteLine("Introduce el valor inicial: ");
                int valorX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el valor final: ");
                int valorY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce texto a mostrar delante de los valores:");
                string Mensaje = Console.ReadLine();

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("SUMAMOS 2 NÚMEROS INTRODUCIDOS:");
                Console.WriteLine("Introduce el valor inicial: ");
                int valorI = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el valor final: ");
                int valorJ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "6":
                Console.Clear();
                Console.WriteLine("COMPLETA EL MENSAJE SIGUIENTE: 'Me gustaría ser: '");
                String Saludo = Console.ReadLine();

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "7":
                Console.Clear();
                Console.WriteLine("DIME SI EL VALOR INTRODUCIDO, A CONTINUACIÓN, ES PRIMO");
                Console.WriteLine("Introduce el posible PRIMO: ");
                int valorE = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
            case "8":
                Console.Clear();
                Console.WriteLine("SALIR DEL PROGRAMA");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                break;
            default:
                Console.Clear();
                Console.WriteLine("HAS INTRODUCIDO UN VALOR INCORRECTO");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Main();
                break;
        }

    }

}