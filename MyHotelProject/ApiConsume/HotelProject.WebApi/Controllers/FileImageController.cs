using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]
        public async Task< IActionResult> UploadImage([FromForm]IFormFile file)
        {
            //file name değişkeni oluşturduk burada benzersiz id olması için guid verdik ve uazntı verdik.
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

            //bizim oluşturmuş olduğumuz yola filenameden gelen değeri oluştur.
            var path = Path.Combine(Directory.GetCurrentDirectory(),"images/" + fileName);

            //bir akış verip bunun modunu oluşturma yaptık ve bunu kaydettik.
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created("", file);

        } 
    }
}
