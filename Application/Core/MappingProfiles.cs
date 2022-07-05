using Application.DTOs;
using AutoMapper;
using Domain;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Item, ItemDto>()
            .ForMember(d => d.Category, o => o.MapFrom(x => x.Category.Name));
        CreateMap<Category, CategoryDto>()
            .ForMember(d => d.Items, o => o.MapFrom(x => x.Items));
    }
}