using AutoMapper;
using Homezz.API.Core.Models.Post;
using Homezz.API.Data.Entities;

namespace Homezz.API.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Post, CreatePostDTO>().ReverseMap();
        }
    }
}
