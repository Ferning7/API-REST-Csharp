using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
=======
using ProductClientHub.Communication.Request;
using ProductClientHub.Communication.Response;
>>>>>>> 28c350db84e1c4286745f6bd609a9690343646f6

namespace ProductClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestClientJson request)
        {
<<<<<<< HEAD

            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
=======
            return Created();
>>>>>>> 28c350db84e1c4286745f6bd609a9690343646f6
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute]Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
