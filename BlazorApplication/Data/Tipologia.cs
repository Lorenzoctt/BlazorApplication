using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlazorApplication.Data
{
    public class Tipologia
    {
        [Key]
        public int ID_tipologia { get; set; }

        public string Descrizione { get; set; }

    }
}
