namespace clases{



    public class Tarea {

        private int id;
        private string descripcion;
        private int duracion;

        public Tarea(int id, string descripcion, int duracion)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }


         public int Id { get => id; set => id = value; }
         public string Descripcion { get => descripcion; set => descripcion = value; }
         public int Duracion { get => duracion; set => duracion = value; }

    }

}