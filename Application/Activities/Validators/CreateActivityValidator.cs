using System;
using Application.Activities.Commands;
using Application.Activities.DTO;
using FluentValidation;
using FluentValidation.Validators;

namespace Application.Activities.Validators;

public class CreateActivityValidator
    : BaseActivityValidator<CreateActivity.Command, CreateActivityDto>
{
    public CreateActivityValidator() : base(x => x.ActivityDto)
    {

    }
}
