using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.Dto;
using test.Interface;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialHouseController : ControllerBase
    {
        private readonly ISocialHouse socialHouseRepo;

        public SocialHouseController(ISocialHouse socialHouseRepo)
        {
            this.socialHouseRepo = socialHouseRepo;
        }
        [HttpPost]
        public IActionResult addSocialHouse(SocialHouseDTO socialHouseDTO)
        {
            if(socialHouseRepo.addSocialHouse(socialHouseDTO))
            {
                return Created();
            }
            return BadRequest();
        }
        [HttpDelete]
        public IActionResult removeSocialHouse(int id) {
            if (socialHouseRepo.removeSocialHouse(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult editeSocialHouse(SocialHouseDTO socialHouseDTO, int socialHouseID)
        {
            if (socialHouseRepo.editeSocialHouse(socialHouseDTO, socialHouseID))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult returnAllSocialHouses()
        {
            return Ok(socialHouseRepo.returnAllSocialHouses());
        }
    }
}
