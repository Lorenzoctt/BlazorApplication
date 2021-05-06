using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace BlazorApplication
{
    public class Allergene
    {
        [Key]
        public int ID_allergene { get; set; }

        public string Descr_allergene { get; set; }
    }
}