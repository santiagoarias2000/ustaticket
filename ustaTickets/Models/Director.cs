using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ustaTickets.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Pricture")]
        public string ProfilePictuaeURL { get; set; }
        [Display(Name = "Name")]
        public string Fullname { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Realationship 
        public List<Movie> Movies { get; set; }

    }
}
