using Fathy.CA.Domain.Common;
using Fathy.CA.Domain.Entities;

namespace Fathy.CA.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
