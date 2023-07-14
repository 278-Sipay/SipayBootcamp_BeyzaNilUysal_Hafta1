using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SipayApi.FluentValidator;
using SipayApi.Models;

namespace SipayApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(Person person)
        {
            var validator = new PersonValidator();
            var validationResult = validator.Validate(person);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return BadRequest(errors);
            }

            // Doğrulama başarılıysa burada gerekli iş mantığını gerçekleştirin ve uygun yanıt döndürün

            return Ok();
        }
    }
}
