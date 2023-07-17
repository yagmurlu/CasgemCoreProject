using Microsoft.AspNetCore.Http;

namespace PizzapannPresentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string ImageURL { get; set; }
        public IFormFile Image { get; set; }
    }
}
