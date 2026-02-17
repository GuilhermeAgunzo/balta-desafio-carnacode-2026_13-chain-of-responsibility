using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class CEOHandler : AbstractHandler
{
    public override void Handle(ExpenseRequest request)
    {
        Console.WriteLine($"CEO approved the expense request of {request.Amount:C} for {request.Purpose} by {request.EmployeeName} from {request.Department} department.");
        base.Handle(request);
    }
}
