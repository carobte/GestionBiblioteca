using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class Book
    {
        public int Id {get;set;}
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Img_Url { get; set; }
        public string Category { get; set; }

        public string Availability { get; set; }
    }
}