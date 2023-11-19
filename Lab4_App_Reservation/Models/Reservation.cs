using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab4_App_Reservation.Models
{
    public class Reservation
    {

        [HiddenInput]
        public DateTime Created { get; set; }
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Prosz� poda� dat�!")]
        public DateTime Date { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "Prosz� poda� miasto!")]
        public string City { get; set; }

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Prosz� poda� adres!")]
        public string Address { get; set; }

        [Display(Name = "Pok�j")]
        [Required(ErrorMessage = "Prosz� poda� pok�j!")]
        public string Room { get; set; }

        [Display(Name = "W�a�ciciel")]
        [Required(ErrorMessage = "Prosz� poda� w�a�ciciela!")]
        public string Owner { get; set; }

        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Prosz� poda� cen�!")]
        [Range(0, double.MaxValue, ErrorMessage = "Prosz� poda� poprawn� cen�!")]
        public decimal Price { get; set; }
    }
}