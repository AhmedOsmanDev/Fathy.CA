using System;
using System.Collections.Generic;
using Fathy.CA.Domain.Entities;

namespace Fathy.CA.Application.TodoLists.Queries.GetTodos;

public class TodoListDto
{
    public int Id { get; init; }

    public string Title { get; init; }

    public string Colour { get; init; }

    public IReadOnlyCollection<TodoItemDto> Items { get; init; } = Array.Empty<TodoItemDto>();

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TodoList, TodoListDto>();
        }
    }
}
