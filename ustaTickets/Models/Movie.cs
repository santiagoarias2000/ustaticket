using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustaTickets.Data.Enum;

namespace ustaTickets.Models
{
    public class Movie
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [Display(Name = "Name Movie")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price Movie")]
        public double Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }
        [Display(Name = "Actor Movie")]
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Relationship with cinema class...
        
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        [Display(Name = "Cinema")]
        public Cinema Cinema{ get; set; }
        
        //Relationship with director class...
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]

        [Display(Name = "Director")]
        public Director Director{ get; set; }



    }
}
