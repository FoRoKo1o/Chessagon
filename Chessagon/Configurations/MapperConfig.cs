using AutoMapper;
using Chessagon.Data;
using Chessagon.DTO.Game;
using Chessagon.DTO.User;

namespace Chessagon.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<Game, GetGameDto>().ReverseMap();
            CreateMap<Game, CreateGameDto>().ReverseMap();
        }
    }
}
