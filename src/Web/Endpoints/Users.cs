using Fathy.CA.Infrastructure.Identity;

namespace Fathy.CA.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder app)
    {
        app.MapGroup(string.Empty)
            .MapIdentityApi<ApplicationUser>();
    }
}
