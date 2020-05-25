using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using Service.Validators;
using System;
using System.Collections;

namespace DapperCrudAPI.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private BaseServices<User> service = new BaseServices<User>();

        [HttpPost]
        public IActionResult Post([FromBody] User item)
        {
            try
            {
                service.Post<UserValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("id")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult("Teste");
                //return new ObjectResult(service.Get(id));
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] User user)
        {
            try
            {
                service.Put<UserValidator>(user);
                return new ObjectResult(user.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);
                return new NoContentResult();
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}