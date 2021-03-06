using Application.Core;
using Application.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.MenuItems;

public class List
{
    public class Query : IRequest<Result<List<ItemDto>>>
    {
        
    }

    public class Handler : IRequestHandler<Query, Result<List<ItemDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<ItemDto>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var q = await _context.Items
                .ProjectTo<ItemDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return Result<List<ItemDto>>.Success(q);
        }
    }
}