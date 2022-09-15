using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustaTickets.Data.Enum;

namespace ustaTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }

        //Relationship with cinema class...
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema{ get; set; }
        
        //Relationship with director class...
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director{ get; set; }



    }
}
