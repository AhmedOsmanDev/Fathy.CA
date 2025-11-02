using Microsoft.AspNetCore.Routing;

namespace Fathy.CA.Web.Infrastructure;

public abstract class EndpointGroupBase
{
    public virtual string GroupName { get; }
    public abstract void Map(RouteGroupBuilder groupBuilder);
}
