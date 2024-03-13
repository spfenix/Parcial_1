internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad constante de 100 km / h. ¿A qué hora el segundo tren alcanzará al primer tren?");

        double tiempo, horafin;
        tiempo = 80 / (100 - 80);
        horafin = 11 + tiempo;

        Console.WriteLine();

        Console.WriteLine( " El segundo tren alcanza al primer tren a las " + horafin + " horas");
    }
}