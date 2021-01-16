namespace BlazorEfCoreRepro.Shared.Models.PhotoSession
{
    public sealed class PhotoSessionDetailsResponseModel
    {
        public int Id { get; set; }

        public string LanguageCode { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}