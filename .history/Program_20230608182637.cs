using clases;
internal class Program
{
    private static void Main(string[] args)
    {
        int numDeTareas = GenerarNumeroAleatorio(1,10);
        
        List<Tarea> TareasPendientes = new List<Tarea>();

        
        for (int i = 1; i <= numDeTareas; i++)
        {
            var Tarea1 = new Tarea(i,"hola",GenerarNumeroAleatorio(1,10));
            TareasPendientes.Add(Tarea1);
        }

        Console.WriteLine("Elementos de la lista:");
        foreach (Tarea Tar in TareasPendientes)
        {
            Console.WriteLine(Tar.Id + Tar.Descripcion + Tar.Duracion);
            System.Console.WriteLine("-------------------");
            
        }


    }

    public static int GenerarNumeroAleatorio(int min, int max)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(min, max); // Genera un número aleatorio dentro del rango especificado
        return numeroAleatorio;
    }

    
}