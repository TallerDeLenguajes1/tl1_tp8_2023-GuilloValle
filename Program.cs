
internal class Program
{
    private static void Main(string[] args)
    {

         string carpetaPath = @"C:\Users\Guillo\Desktop\taller1\tl1_tp8_2023-GuilloValle"; // Reemplaza con la ruta de la carpeta que deseas listar

        // if (Directory.Exists(carpetaPath))
        // {
        //     string[] archivos = Directory.GetFiles(carpetaPath);

        //     Console.WriteLine("Archivos encontrados:");

        //     foreach (string archivo in archivos)
        //     {
        //         Console.WriteLine(archivo);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("La carpeta no existe.");
        // }

        


        // if (Directory.Exists(carpetaPath))
        // {
        //     string[] archivos = Directory.GetFiles(carpetaPath);

        //     Console.WriteLine("Archivos encontrados:");

        //     foreach (string archivo in archivos)
        //     {
        //         string nombreArchivo = Path.GetFileName(archivo);
        //         Console.WriteLine(nombreArchivo);
        //     }

        // using (StreamWriter archivoCSV = new StreamWriter("index.csv"))   CON EL USINGNO HACE FALTA HACER EL CLOSE DESPUES, CUANDO SALE DEL USING SE CIERRA SOLO
        //     {
        //         archivoCSV.WriteLine("Índice,Nombre,Extensión"); // Escribir la línea de encabezado en el archivo CSV

        //         for (int i = 0; i < archivos.Length; i++)
        //         {
        //             string nombreArchivo = Path.GetFileName(archivos[i]); // Obtener el nombre del archivo
        //             string extensionArchivo = Path.GetExtension(archivos[i]); // Obtener la extensión del archivo

        //             archivoCSV.WriteLine($"{i + 1},{nombreArchivo},{extensionArchivo}"); // Escribir los datos en el archivo CSV

        //             Console.WriteLine($"{i + 1}. {nombreArchivo} ({extensionArchivo})");
        //         }
        //     }

        //     Console.WriteLine("Listado de archivos guardado en index.csv");

            
        // }
        // else
        // {
        //     Console.WriteLine("La carpeta no existe.");
        // }


        string[] archivos = Directory.GetFiles(carpetaPath);

        // Crear un nuevo archivo "index.csv" en el directorio actual para escribir los datos
        StreamWriter archivoCSV = new StreamWriter("index.csv");
        archivoCSV.WriteLine("Índice,Nombre,Extensión"); // Escribir la línea de encabezado en el archivo CSV

        for (int i = 0; i < archivos.Length; i++)
        {
            string nombreArchivo = Path.GetFileName(archivos[i]); // Obtener el nombre del archivo
            string extensionArchivo = Path.GetExtension(archivos[i]); // Obtener la extensión del archivo

            archivoCSV.WriteLine($"{i + 1},{nombreArchivo},{extensionArchivo}"); // Escribir los datos en el archivo CSV

            Console.WriteLine($"{i + 1}. {nombreArchivo}");
        }

        archivoCSV.Close(); // Cerrar el archivo después de terminar de escribir en él

        Console.WriteLine("Listado de archivos guardado en index.csv");
        Console.ReadLine();



    }

}

    

    
