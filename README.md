# net_cp1_Kevin-Zamora 
( Terminado a esperas de mejorarlo ) {
 // TODO1: Más abajo se muestran los errores persistentes detectados y aún por solucionar
 // TODO2: También se explica muy brevemente qué se ha pretendido desarrollar, a nivel de funcionalidades, con la implementación de dicho programa
 // PD: Se adjunta la copilación de dicha aplicación de consola, en formato .exe, para que pueda resultar más sencilla su puesta a prueba.
}

//// Hola internautas!!! ////

// Descripción: //
Este proyecto viene a representar el primer Caso Práctico perteneciente al desarrollo del Curso de Desarrollo .NET, organizado por la  Adecco, 
con la colaboración de la empresa Sage. Abajo os dejo el enlace a más información, para todx el que le despierte cierto interés:
https://fundacionadecco.org/cursos/curso-de-programacion-net-con-la-colaboracion-de-sage/

En este caso, hemos implementado algunas de las funciones que deberá implementar, en su puesta en marcha y con sus pertinentes modificaciones sobre el 
código presentado, a la hora de construir el "backend" de prácticamente cualquier aplicación; también llamadas operaciones CRUD. En nuestro caso, hemos 
abordado la manipulación interna de dos objetos/clases primarias llamadas "Product" y "Manufacturer". Y haciendo uso para ello de la implementación de dos 
Interfaces, asociadas con los respectivos repositorios/clases dedicados, lxs cuales implementan sus métodos. Por último, hemos vinculado/llamado todas y 
cada una de dichas funciones desde nuestra aplicación principal, a ejecutar y mostrarlas indexadas con un menú por pantalla; lx hemos llamado "program.cs".

// Errores encontrados //
Acto seguido y primeramente, procedo a enumerar los errores encontrados en sus "testeos finales", cuyos fallos restan aún por corregir aunque, por lo que
he podido comprobar, tanto probando la aplicación de consola como depurando, no llegan a entorpecer funcionalmente las funciones principales de dicha 
aplicación.

1. La impresión de los componentes de la lista de productos por pantalla no muestra/llee correctamente los identificadores Id de cada uno de los objetos 
   listados, a la hora de realizar dicha operación (Console.WriteLine(product);). Por el contrario, sí que identifica el valor de dicha variable cuando 
   se realiza una búsqueda de estos por el valor correspondiente de esa variable Id.
2. Cuando la aplicación llega a su fin, por voluntad del/de la propix usuarix al pulsar dos veces seguidas la letra E (en mayúsculas), esta finaliza 
   correctamente, aunque mostrando un mensaje de error.
3. En algunas puestas en marcha de algunas funciones del menú, aunque no siempre, se muestra un "mensaje mostrado a drede por consola" varias veces,
   aunque sin alterar el resultado guardado en lista, perteneciente a dicha operación.
5. (MEJORA) También quedan a modo de mejora posterior el control de todas las excepciones, que se puedan producir durante el uso de dicha aplicación, PE:
   - Tipo de dato introducido con formato erroneo (PE: Se pide un valor en formato int y se introduce un string).
   - Exceder la capacidad del tipo de variable solicitada (PE: Se pide un valor entero que quepa en una variable codificada dentro de 32 bits y se 
     excede el número de dígitos "permitidos").
     
//// ¡Esperamos que os guste! ////
