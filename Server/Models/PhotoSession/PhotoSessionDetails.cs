using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEfCoreRepro.Server.Models.PhotoSession
{
    [Table(nameof(PhotoSessionDetails))]
    public sealed class PhotoSessionDetails
    {
        public int Id { get; set; }

        public string LanguageCode { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public PhotoSessionInfo PhotoSessionInfo { get; set; }
    }
}