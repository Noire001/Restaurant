using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.MenuItems;

public class List
{
    public class Query : IRequest<Result<List<Item>>>
    {
        
    }

    public class Handler : IRequestHandler<Query, Result<List<Item>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<Item>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var q = await _context.Items
                .ProjectTo<Item>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return Result<List<Item>>.Success(q);
        }
    }
}