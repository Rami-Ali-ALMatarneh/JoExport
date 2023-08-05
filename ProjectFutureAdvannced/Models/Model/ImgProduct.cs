namespace ProjectFutureAdvannced.Models.Model
    {
    public class ImgProduct
        {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public int productId { get; set; }
        public Product Product { get; set; }
        }
    }
