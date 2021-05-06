using System.ComponentModel.DataAnnotations;
namespace BlazorApplication
{
    public class Portata
    {
        [Key]
        public int ID_tp_portata { get; set; }
        public string Descr_portata { get; set; }
    }
}