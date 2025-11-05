using Fathy.CA.Infrastructure.Identity;
using Fathy.CA.Web.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Fathy.CA.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapGroup(string.Empty)
            .MapIdentityApi<ApplicationUser>();
    }
}
