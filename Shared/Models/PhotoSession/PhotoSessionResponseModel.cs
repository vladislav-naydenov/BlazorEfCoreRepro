using System.Collections.Generic;

namespace BlazorEfCoreRepro.Shared.Models.PhotoSession
{
    public sealed class PhotoSessionResponseModel
    {
        public int Id { get; set; }

        public string BackgroundImageUri { get; set; }

        public decimal Price { get; set; }

        public int Frames { get; set; }

        public PhotoSessionDetailsResponseModel DetailsModel { get; set; }

        public IEnumerable<PhotoSessionDetailsResponseModel> Details { get; set; }
    }
}