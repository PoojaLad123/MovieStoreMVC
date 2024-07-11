using System.ComponentModel.DataAnnotations;

namespace MovieStoreMVC.Models.Domain
{
    public class MovieGenre
    {
        public int Id { get; set; }
        //[Required]
        public int MovieId { get; set; }
       /// <summary>
       //[Required]
     
        public int GenreId { get; set; }
       // [Required]

    }
}
