using clases;
internal class Program
{
    private static void Main(string[] args)
    {
        int numDeTareas = GenerarNumeroAleatorio(1,10);
        
        List<tarea> tareasPendientes = new List<tarea>();



        for (int i = 0; i < numDeTareas; i++)
        {
            
        }



    }

    public static int GenerarNumeroAleatorio(int min, int max)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(min, max); // Genera un número aleatorio dentro del rango especificado
        return numeroAleatorio;
    }

    public static tarea crearTarea(int id, string descripcion, int duracion){

        var nuevaTarea = new tarea{
            Id = id
        }
    }
}