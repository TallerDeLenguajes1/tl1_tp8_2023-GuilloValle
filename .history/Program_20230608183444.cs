using clases;
internal class Program
{
    private static void Main(string[] args)
    {
        int numDeTareas = GenerarNumeroAleatorio(1, 10);

        List<Tarea> TareasPendientes = new List<Tarea>();

        CargarLista(numDeTareas, TareasPendientes);

        MostarLista(TareasPendientes);

        
        foreach (Tarea Tar in TareasPendientes)
        {
            System.Console.WriteLine("Se esta tarea?");
            Console.WriteLine("Id = " + Tar.Id);
            Console.WriteLine("Descripcion = " + Tar.Descripcion);
            Console.WriteLine("Duracion = " + Tar.Duracion);
            System.Console.WriteLine("--------------");


        }

    }

    private static void CargarLista(int numDeTareas, List<Tarea> TareasPendientes)
    {
        for (int i = 1; i <= numDeTareas; i++)
        {
            var Tarea1 = new Tarea(i, "hola", GenerarNumeroAleatorio(1, 10));
            TareasPendientes.Add(Tarea1);
        }
    }

    private static void MostarLista(List<Tarea> TareasPendientes)
    {
        Console.WriteLine("Elementos de la lista:");
        foreach (Tarea Tar in TareasPendientes)
        {
            Console.WriteLine("Id = " + Tar.Id);
            Console.WriteLine("Descripcion = " + Tar.Descripcion);
            Console.WriteLine("Duracion = " + Tar.Duracion);
            System.Console.WriteLine("--------------");


        }
    }

    public static int GenerarNumeroAleatorio(int min, int max)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(min, max); // Genera un número aleatorio dentro del rango especificado
        return numeroAleatorio;
    }

    
}