using System.ComponentModel.DataAnnotations;
namespace BlazorApplication
{
    public class Stagione
    {
        [Key]
        public int ID_stagione { get; set; }

        public string Descr_stagione { get; set; }
    }
}