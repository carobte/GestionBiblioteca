using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Document_type { get; set; }
        public string Document_Number { get; set; }
        public string Name { get; set; }
        public string Adress {get;set;}
        public string Contact_number {get; set;}
    }
}