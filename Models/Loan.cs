using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class Loan
    {
        public int Id{get;set;}
        public DateTime Loan_Date {get;set;}
        public DateTime Expected_Return_Date{get;set;}
        public Book Book{get;set;}
        public Customer Customer {get;set;}

    }
}