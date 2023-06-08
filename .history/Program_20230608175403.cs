using clases;
internal class Program
{
    private static void Main(string[] args)
    {
        int numDeTareas = GenerarNumeroAleatorio(1,10);
        System.Console.WriteLine(numDeTareas);



    }

    public static int GenerarNumeroAleatorio(int min, int max)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(min, max); // Genera un número aleatorio dentro del rango especificado
        return numeroAleatorio;
    }
}