using Microsoft.AspNetCore.Mvc;
using Piskvorky2.Services.Dto;
using Piskvorky2.Services.Services;

namespace Piskvorky2.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
           _gameService = gameService;
        }

        [HttpGet("get-all-players")]
        public async Task<IEnumerable<PlayerDto>> GetAll()
        {
            return await _gameService.GetAllPlayers();
        }

        [HttpGet("get-one-player-test")]
        public async Task<PlayerDto> GetOne()
        {
            return await _gameService.GetOnePlayerTest();
        }
    }
}