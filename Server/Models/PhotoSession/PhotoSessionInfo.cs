using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEfCoreRepro.Server.Models.PhotoSession
{
    [Table(nameof(PhotoSessionInfo))]
    public sealed class PhotoSessionInfo
    {
        public int Id { get; set; }

        public string BackgroundImageUri { get; set; }

        public decimal Price { get; set; }

        public int Frames { get; set; }

        public ICollection<PhotoSessionDetails> PhotoSessionDetails { get; } = new List<PhotoSessionDetails>();
    }
}