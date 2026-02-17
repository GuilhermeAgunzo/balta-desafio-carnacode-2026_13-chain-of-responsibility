using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class ManagerHandler : AbstractHandler
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 500)
        {
            Console.WriteLine($"Manager approved the expense request of {request.Amount} for {request.Purpose} by {request.EmployeeName}.");
            return;
        }

        base.Handle(request);
    }
}
