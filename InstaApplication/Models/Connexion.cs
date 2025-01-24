using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InstaApplication.Models
{
    public class Connexion
    {
        // clé primaire dans la table
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Nom :")]
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MinLength(1, ErrorMessage = "Au moins un caractère")]
        public string Name { get; set; }

        [Display(Name = "Passeword :")]
        [Required(ErrorMessage = "Merci de saisir le mot de passe")]
        [MinLength(1, ErrorMessage = "Au moins deux caractères")]
        public string password { get; set; }
    }
}
