using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [Required,MaxLength(25)]
        public int GenreName { get; set; }

        public List<Book> Books { get; set; } // one genre can have multiple books
    }
}
