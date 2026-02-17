using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Systems;

public class ExpenseApprovalSystemV3
{
    private readonly SupervisorHandler supervisorHandler;
    private readonly ManagerHandler managerHandler;
    private readonly DirectorHandler directorHandler;
    private readonly CEOHandler ceoHandler;

    public ExpenseApprovalSystemV3()
    {
        supervisorHandler = new SupervisorHandler();
        managerHandler = new ManagerHandler();
        directorHandler = new DirectorHandler();
        ceoHandler = new CEOHandler();

        supervisorHandler.SetNext(managerHandler);
        managerHandler.SetNext(directorHandler);
        directorHandler.SetNext(ceoHandler);
    }

    public void ProcessExpense(ExpenseRequest request) => supervisorHandler.Handle(request);

}
