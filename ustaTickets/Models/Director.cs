using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ustaTickets.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictuaeURL { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }

        //Realationship 
        public List<Movie> Movies { get; set; }

    }
}
