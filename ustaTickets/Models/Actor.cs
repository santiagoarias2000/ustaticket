using System.ComponentModel.DataAnnotations;

namespace ustaTickets.Models
{
    public class Actor
    {
        //Actor ID
        [Key]
        public int Id { get; set; }
        public string ProfilePictuaeURL { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }

}
