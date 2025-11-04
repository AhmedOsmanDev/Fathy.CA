using System.Threading;
using System.Threading.Tasks;
using Fathy.CA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fathy.CA.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
