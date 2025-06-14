using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.Dto;
using test.Interface;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusControllerRequests : ControllerBase
    {
        private readonly IContactUsRequests contactUs_repo;

        public ContactusControllerRequests(IContactUsRequests contactUs_repo)
        {
            this.contactUs_repo = contactUs_repo;
        }
        [HttpPost]
        public IActionResult addRequastFlat(ContactUsDto contactUsDto)
        {
            if (contactUs_repo.Request_Flat(contactUsDto))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult getAllContactUsRequests()
        {
            var allContactUs = contactUs_repo.GetContactUs();
            return Ok(allContactUs);
                      }
    }
}
