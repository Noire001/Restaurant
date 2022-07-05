using Application.Core;
using Application.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.MenuItems;

public class ListByCategory
{
    public class Query : IRequest<Result<List<CategoryDto>>>
    {
        
    }
    
    public class Handler : IRequestHandler<Query, Result<List<CategoryDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<CategoryDto>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var q = await _context.Categories
                .OrderBy(x => x.Priority)
                .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return Result<List<CategoryDto>>.Success(q);
        }
    }
}