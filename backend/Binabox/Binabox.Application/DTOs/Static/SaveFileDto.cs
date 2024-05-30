using Microsoft.AspNetCore.Http;

namespace Binabox.Application.DTOs.Static;

public class SaveFileDto
{
    public IFormFile File { get; set; }
}