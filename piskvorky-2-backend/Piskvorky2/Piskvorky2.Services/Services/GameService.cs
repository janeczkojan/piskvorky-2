using Piskvorky2.Repositories.Services;
using Piskvorky2.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piskvorky2.Repositories.Models;
using AutoMapper;

namespace Piskvorky2.Services.Services
{
    public interface IGameService
    {
        Task<IEnumerable<PlayerDto>> GetAllPlayers();
        Task<PlayerDto> GetOnePlayerTest();
    }

    internal class GameService : IGameService
    {
        private readonly IPlayersRepository _playersRepository;

        private readonly IGamesRepository _gamesRepository;

        private readonly IMapper _mapper;

        public GameService(IPlayersRepository playersRepository, IGamesRepository gamesRepository, IMapper mapper)
        {
            _playersRepository = playersRepository;
            _gamesRepository = gamesRepository;
            _mapper = mapper;
        }

        public async Task<PlayerDto> GetOnePlayerTest()
        {
            var players = await _playersRepository.GetAll();
            var player = players[0];
            
            return _mapper.Map<PlayerDto>(player);
        }

        public async Task<IEnumerable<PlayerDto>> GetAllPlayers()
        {
            var players = await _playersRepository.GetAll();

            return _mapper.Map<IEnumerable<PlayerDto>>(players);
        }
    }
}
