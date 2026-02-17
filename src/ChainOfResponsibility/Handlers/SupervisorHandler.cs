using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class SupervisorHandler : AbstractHandler
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 100)
        {
            Console.WriteLine($"Supervisor approved the expense request of {request.Amount} for {request.EmployeeName}.");
            return;
        }

        base.Handle(request);
    }
}
