using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.Dto;
using test.Interface;
using test.Model;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatController : ControllerBase
    {
        private readonly IFlatRepo _repo;

        public FlatController(IFlatRepo flatRepo)
        {
            this._repo = flatRepo;
        }
        [HttpPost("FlatPost")]
        public IActionResult FlatPost(PostFlatDto postFlatDto)
        {
            if (!ModelState.IsValid)
            { return BadRequest(ModelState); }
            {
                bool status = _repo.PostFlat(postFlatDto);
                if (status)
                {
                    return Accepted(new
                    {
                        status,
                        message = "Flat Request Sent Successfully!"
                    });
                }
                return BadRequest(new
                {
                    status,
                    message = "Invalid Data Entered"
                });
            }
        }
        [HttpGet]
        public IActionResult GetFlat()
        {
            var flats = _repo.GetFlat();
            if (flats != null)
            {
                return Accepted(new
                {
                    flats,
                    message = "Flat Fetched"
                });
            }
            return BadRequest(new
            {
                message = "No Flats Fetched"
            });

        }
        [HttpDelete]
        public IActionResult RemoveFlat(int FlatId)
        {
            bool status = _repo.RemoveFlat(FlatId);
            if (status)
            {
                return Accepted(new
                {
                    status,
                    message = "Flat Deleted Successfully!"
                });
            }
            return BadRequest(new
            {
                status,
                message = "Invalid Operation "
            });
        }
        [HttpPatch("FlatEdit")]
        public IActionResult FlatEdit(PostFlatDto postFlatDto, int id)
        {
            if (!ModelState.IsValid)
            { return BadRequest(ModelState); }
            {
                bool status = _repo.EditFlat(postFlatDto, id);
                if (status)
                {
                    return Accepted(new
                    {
                        status,
                        message = "Flat Data Modified Successfully!"
                    });
                }
                return BadRequest(new
                {
                    status,
                    message = "Invalid Data Entered"
                });
            }
        }
        [HttpPatch("updateFlatState")]
        public IActionResult updateFlatState(int FlatId,bool state)
        {
            if (_repo.updateFlatState(FlatId, state))
            {
                return Ok();
            }
            return NotFound();
        }

    }

}
  

