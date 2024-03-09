using System.ComponentModel.Design;
using System.Security.Cryptography;

public class Program
{
    private static void Main(string[] args)
    {
        //Un vendedor recibe un sueldo base de $XXXX.Además, recibe una comisión del 10 % sobre el valor total de cada venta que realiza.El vendedor desea saber:
        //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes
        // ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
       // ¿Cuál fue la venta que le generó la mayor comisión?
       //¿Cuál fue el promedio de las comisiones que recibió por cada venta?
        //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio
        double sueldo, totcomi, vent1, vent2, vent3, sueltot, promc;
        Console.Write("Por favor digite el sueldo base: ");
        sueldo = double.Parse(Console.ReadLine());

        Console.Write("Digite el valor de la primera venta: ");
        vent1 = double.Parse(Console.ReadLine());

        Console.Write("Digite el valor de la segunda venta: ");
        vent2 = double.Parse(Console.ReadLine());

        Console.Write("Digite el valor de la tercera venta: ");
        vent3 = double.Parse(Console.ReadLine());

        totcomi = (vent1 * 0.10) + (vent2 * 0.10) + (vent3 * 0.10);
        sueltot = sueldo + totcomi;
        promc = ((vent1 * 0.10) + (vent2 * 0.10) + (vent3 * 0.10)) / 3;

        Console.WriteLine("El total de comisiones fue de: ", +  totcomi);
        Console.WriteLine("el sueldo total mas comisiones fue de: ", +sueltot);
        Console.WriteLine("El promedio de comisiones fue de: ", +promc);


        if (vent1 + vent2 + vent3 > 1000000) { Console.WriteLine("Tiene derecho a un bono por ventas de 100000"); }


        if ((vent1 > vent2) && (vent2 > vent3)) {

            Console.WriteLine("La mayor comision fue de la primera venta"); 
        }




        else if ((vent2 > vent1) && (vent1 > vent3)) { Console.WriteLine("La mayor comision fue de la segunda venta"); 
        
        
        }


        else
               if ((vent3 > vent2) && (vent2 > vent1)) { Console.WriteLine("La mayor comision fue de la tercera venta"); }
    }

       

}
             
               
           