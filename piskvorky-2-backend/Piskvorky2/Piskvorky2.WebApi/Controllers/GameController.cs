using Microsoft.AspNetCore.Mvc;
using Piskvorky2.Repositories.Models;
using Piskvorky2.Repositories.Services;

namespace Piskvorky2.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Game : ControllerBase
    {
        private readonly PlayersRepository _playersRepository;

        public Game(PlayersRepository playerRepository)
        {
           _playersRepository = playerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> GetAll()
        {
            return await _playersRepository.GetAll();
        }
    }
}