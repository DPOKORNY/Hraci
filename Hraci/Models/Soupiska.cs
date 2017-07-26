using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hraci.Models
{
    public class Soupiska
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Nezadal jsi jméno")]
        public string Jmeno { get; set; }
        [Required(ErrorMessage = "Nezadal jsi příjmení")]
        public string Prijmeni { get; set; }
        [Required(ErrorMessage = "Nezadal jsi národnost")]
        public string Narodnost { get; set; }
        [Required(ErrorMessage = "Nezadal jsi post")]
        public string Post { get; set; }
        [Required(ErrorMessage = "Nezadal jsi popis")]
        public string Popis { get; set; }



    }
}