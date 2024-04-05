using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chessagon.Data;
using Chessagon.Contracts;
using AutoMapper;
using Chessagon.DTO.Game;
using Microsoft.AspNetCore.Authorization;

namespace Chessagon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GamesController(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        // GET: api/Games
        [HttpGet]
        [Authorize(Roles = "User")] // NOTE TO SEGMK: Only Admin can access this endpoint
        public async Task<ActionResult<IEnumerable<GetGameDto>>> GetGames()
        {
            var games = await _gameRepository.GetAllAsync();
            var records = _mapper.Map<List<GetGameDto>>(games);
            return Ok(records);
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetGameDto>> GetGame(int id)
        {
            var game = await _gameRepository.GetAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<GetGameDto>(game));
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, GetGameDto gameDto)
        {
            if (id != gameDto.Id)
            {
                return BadRequest();
            }

            var game = await _gameRepository.GetAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _mapper.Map(gameDto, game);

            try
            {
                await _gameRepository.UpdateAsync(game);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await GameExists(id))
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

        // POST: api/Games
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(CreateGameDto gameDto)
        {
            var game = _mapper.Map<Game>(gameDto);
            await _gameRepository.AddAsync(game);

            return CreatedAtAction("GetGame", new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _gameRepository.GetAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            await _gameRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> GameExists(int id)
        {
            return await _gameRepository.Exists(id);
        }
    }
}
