using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Fathy.CA.Application.Common.Interfaces;
using Fathy.CA.Application.Common.Models;
using Fathy.CA.Application.Common.Security;
using Fathy.CA.Domain.Enums;

namespace Fathy.CA.Application.TodoLists.Queries.GetTodos;

[Authorize]
public record GetTodosQuery : IRequest<TodosVm>;

public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, TodosVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<TodosVm> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        return new TodosVm
        {
            PriorityLevels = Enum.GetValues<PriorityLevel>()
                .Select(p => new LookupDto
                {
                    Id = (int)p, Title = p.ToString()
                })
                .ToList(),
            Lists = await _context.TodoLists
                .AsNoTracking()
                .ProjectTo<TodoListDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.Title)
                .ToListAsync(cancellationToken)
        };
    }
}
