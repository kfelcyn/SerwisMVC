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
        [Column(TypeName = "nvarchar")]
        [DisplayName("Telefon:")]
        [StringLength(12, MinimumLength = 9)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "Wpisz 9 cyfrowy numer telefonu")]
        [Required(ErrorMessage = "Pole Telefon - jest wymagane")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("E-mail:")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Podaj prawdziwy adres e-mail")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [DisplayName("Opis zlecenia:")]
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
        [DisplayName("Data zgłoszenia:")]
        [DataType(DataType.Date)]
        
        public Nullable <DateTime> CaseDate { get; set; }
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