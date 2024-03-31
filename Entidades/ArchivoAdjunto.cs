using Microsoft.EntityFrameworkCore;

namespace TareasMVC.Entidades
{
    public class ArchivoAdjunto
    {
        public Guid Id { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        [Unicode]
        public String Url { get; set; }
        public String Titulo { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCracion { get; set; }
    }
}
