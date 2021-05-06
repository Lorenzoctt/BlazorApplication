using System.ComponentModel.DataAnnotations;

namespace BlazorApplication
{
    public class Piatto
    {
        [Key]
        public int ID_piatto { get; set; }

        public int ID_allergene { get; set; }

        public int ID_stagione { get; set; }

        public double Prezzo { get; set; }

        public int ID_tp_portata { get; set; }
    }
}