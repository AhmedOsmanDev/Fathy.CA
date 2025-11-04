using Fathy.CA.Domain.Common;
using Fathy.CA.Domain.Entities;

namespace Fathy.CA.Domain.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
