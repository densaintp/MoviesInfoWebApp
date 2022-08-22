using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesInfoWebApp.Models
{
	public class Movie
	{
		[Key]
		[Column(TypeName = "int")]
		public int MovieId { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(max)")]
		[DisplayName("Название фильма")]
		public string MovieName { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(max)")]
		[DisplayName("Описание")]
		public string Descriprion { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(max)")]
		[DisplayName("Жанр")]
		public string Genre { get; set; }

		[DisplayName("Название обложки")]
		public string ImageName { get; set; }

		[NotMapped]
		[DisplayName("Загрузить обложку")]
		public IFormFile ImageFile { get; set; }
	}
}
