using System.ComponentModel.DataAnnotations;

namespace ustaTickets.Models
{
    public class Actor
    {
        //Actor ID
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictuaeURL { get; set; }
        [Display(Name="Full Name")]
        public string Fullname { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        //Realtionship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }

}
