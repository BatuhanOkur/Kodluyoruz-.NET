using System;
using System.Linq;
using FluentValidation;
using WebApi.DBOperations;
using WebAPI.Applications.AuthorOperations.Commands.UpdateAuthor;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(command => command.AuthorId).GreaterThan(0); 
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.Surname).NotEmpty().MinimumLength(2);  
            RuleFor(command => command.Model.BirthDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
        }
    }
}