namespace FluentValidator.Tests
{
    public class TestValidatorWithStopOnFirstFailure : BaseValidator<CreateEmployeeRequest>
    {
        public TestValidatorWithStopOnFirstFailure()
        {
            RuleFor(x => x.EmployeeID).StopOnFirstFailure().LessThan(0).WithMessage("Less error").GreaterThan(3).WithMessage("Greater error");
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.DateOfBirth).LessThanToday().NotNull();
            RuleFor(x => x.DateOfBirth).NotNull();
        }
     
    }
}