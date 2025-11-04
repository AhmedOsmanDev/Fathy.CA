using Fathy.CA.Domain.Common;
using Fathy.CA.Domain.Entities;

namespace Fathy.CA.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
