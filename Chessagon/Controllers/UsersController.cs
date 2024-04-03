using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chessagon.Data;
using Chessagon.DTO.User;
using AutoMapper;
using Chessagon.Contracts;

namespace Chessagon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UsersController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUserDto>>> GetUsers()
        {
            var users = await _userRepository.GetAllAsync();
            var records = _mapper.Map<IEnumerable<GetUserDto>>(users);
            return Ok(records);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserDetailsDto>> GetUser(int id)
        {
            var user = await _userRepository.GetUserDetails(id);

            if (user == null)
            {
                return NotFound();
            }
            var record = _mapper.Map<GetUserDetailsDto>(user);
            return Ok(record);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, UpdateUserDto updateUserDto)
        {
            if (id != updateUserDto.Id)
            {
                return BadRequest("Invalid Record Id");
            }

            //_context.Entry(user).State = EntityState.Modified;
            var user = await _userRepository.GetAsync(id);
            if(user == null)
            {
                return NotFound();
            }

            _mapper.Map(updateUserDto, user);

            try
            {
                await _userRepository.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /* 
         * Note to SEGMK:
         * We are using DTOs to prevent overposting attacks. We dont want to expose the User object to the client, so we use DTOs to transfer data.
        */
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(CreateUserDto CreateUserDto)
        {
            //var user = new User
            //{
            //    Username = CreateUser.Username,
            //    Password = CreateUser.Password,
            //    Email = CreateUser.Email,
            //    Description = CreateUser.Description,
            //    Role = CreateUser.Role
            //};

            /*
             * Note to SEGMK:
             * We are using AutoMapper to map the CreateUserDto object to User object.
             * Commented block above is replaced with the block below.
             */

            var user = _mapper.Map<User>(CreateUserDto);

            await _userRepository.AddAsync(user);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _userRepository.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> UserExists(int id)
        {
            return await _userRepository.Exists(id);
        }
    }
}
