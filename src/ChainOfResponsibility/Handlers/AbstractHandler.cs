using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public abstract class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;

    public virtual void Handle(ExpenseRequest request)
    {
        _nextHandler?.Handle(request);
    }

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }
}
