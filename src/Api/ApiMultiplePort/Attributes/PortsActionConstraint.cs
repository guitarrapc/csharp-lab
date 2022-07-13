using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace ApiMultiplePort.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class PortsActionConstraint : ActionMethodSelectorAttribute
{
    public PortsActionConstraint(int[] ports)
    {
        Ports = ports;
    }

    public IReadOnlyList<int> Ports { get; }

    public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor action)
    {
        //external port
        var externalPort = routeContext.HttpContext.Request.Host.Port;
        //local port 
        var localPort = routeContext.HttpContext.Connection.LocalPort;
        //write here your custom logic. for example  
        return Ports.Contains(localPort);
    }
}
