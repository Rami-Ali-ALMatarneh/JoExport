using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Models.Model
    {
    public class Category
        {
        public int Id { get; set; }
        [Required]
        public Categorys Name { get; set; }
        [Required]
        [RegularExpression(@"\b\w+\.(jpg|JPG|PNG|png)\b", ErrorMessage = "This Image not supported")]
        public string CategoryImg { get; set; }
        //public Shop shop { get; set; }
        //public List<Product> Products { get; set; }
        }
    }
