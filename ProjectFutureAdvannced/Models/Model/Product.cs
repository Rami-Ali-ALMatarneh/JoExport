using Microsoft.AspNetCore.Identity;
using ProjectFutureAdvannced.Models.Enums;

namespace ProjectFutureAdvannced.Models.Model
    {
    public class Product
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Categorys CategoryName { get; set; }
        public double Price { get; set; }
        public List<ImgProduct> Imgs { get; set; } 
        
        public int ShoperId { get; set; }
        public Shop shop { get; set; }
        /***********************************/
        public int CategoryId { get; set; }
        public Category category { get; set; }

        }
    }
