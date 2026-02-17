using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class DirectorHandler : AbstractHandler
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"Director approved the expense request of {request.Amount:C} for {request.Purpose} by {request.EmployeeName} in {request.Department} department.");
            return;
        }

        base.Handle(request);
    }
}
