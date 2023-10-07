using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GrandHotel.Models
{
    public class Cliente
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Cognome obbligatorio")]
        public string Cognome { get; set; }
        [Required(ErrorMessage = "Nome obbligatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Codice Fiscale obbligatorio")]
        public string codicefiscale { get; set; }
        [Required(ErrorMessage = "Provincia obbligatoria")]
        public string Provincia { get; set; }
        [Required(ErrorMessage = "Città obbligatoria")]
        public string città { get; set; }
        [Required(ErrorMessage = "Email obbligatoria")]
        public string email { get; set; }
        [Required(ErrorMessage = "Telefono obbligatorio")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "Cellulare obbligatorio")]
        public string cellulare { get; set; }
    }
}