using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InstaApplication.Models
{
    public class Inscription
    {
        // clé primaire dans la table
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Nom :")]
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MinLength(1, ErrorMessage = "Au moins un caractère")]
        public string Name { get; set; }

        [Display(Name = "Prenom :")]
        [Required(ErrorMessage = "Merci de saisir le Prenom")]
        [MinLength(1, ErrorMessage = "Au moins deux caractères")]
        public string Prenom { get; set; }
        [Display(Name = "Age :")]
        [Required(ErrorMessage = "Merci de saisir votre age")]
        public int age { get; set; }

        [Display(Name = "Adresse :")]
        [Required(ErrorMessage = "Merci de saisir le adresse")]
        [MinLength(1, ErrorMessage = "Au moins deux caractères")]
        public string adresse { get; set; }
    }
}
