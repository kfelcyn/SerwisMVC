using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Zlecenie
    {
        [Key]
        public int ZlecenieId { get; set; }

        [Column(TypeName = "nvarchar")]
        [DisplayName("Imię:")]
        [Required(ErrorMessage = "Pole Imię - jest wymagane")]
        [MaxLength(50)]
        public string First_Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Nazwisko:")]
        [Required(ErrorMessage = "Pole Nazwisko - jest wymagane")]
        [MaxLength(100)]
        public string Last_Name { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Telefon:")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Pole Telefon - jest wymagane")]
        public int Phone { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("E-mail:")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Opis usterki/szczegóły zlecenia:")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string Problem { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Urządzenie:")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Jakiego urządzenia dotyczy zlecenie?")]
        [MaxLength(100)]
        public string Device { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Data przyjęcia zgłoszenia:")]
        [DataType(DataType.Date)]
        
        public DateTime CaseDate { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Dodatki:")]
        [MaxLength(100)]
        public string Addons { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Status:")]
        public string Status { get; set; }
        [Column(TypeName = "bit")]
        [DisplayName("Zrobione:")]
        public bool IsDone { get; set; }
        
    }
}