using System;
using FluentValidation;

namespace Fathy.CA.Application.TodoItems.Commands.UpdateTodoItem;

public class UpdateTodoItemCommandValidator : AbstractValidator<UpdateTodoItemCommand>
{
    public UpdateTodoItemCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }

    private object RuleFor(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}
