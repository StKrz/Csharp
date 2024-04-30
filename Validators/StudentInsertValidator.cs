using FluentValidation;
using WebStarterDBApp1.DTO;

namespace WebStarterDBApp1.Validators
{
    public class StudentInsertValidator : AbstractValidator<StudentInsertDTO>
    {

        public StudentInsertValidator()
        {
            RuleFor(s => s.Firstname)
                .NotEmpty()
                .WithMessage("Το πεδίο 'Όνομα' δεν μπορεί να είναι κενό")
                .Length(2, 50)
                .WithMessage("Το πεδίο 'Όνομα' πρέπει να είναι κενό");

            RuleFor(s => s.Lastname)
                .NotEmpty()
                .WithMessage("Το πεδίο 'Επώνυμο' δεν μπορεί να είναι κενό")
                .Length(2, 50)
                .WithMessage("Το πεδίο 'Επώνυμο' πρέπει να είναι κενό");
        }
    }
}
