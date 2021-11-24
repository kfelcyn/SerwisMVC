using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Zlecenie
    {
        [Key]
        public int ZlecenieId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Problem { get; set; }
        public DateTime CaseDate { get; set; }
        public string Addons { get; set; }
        public string Status { get; set; }
        public bool IsDone { get; set; }
    }
}