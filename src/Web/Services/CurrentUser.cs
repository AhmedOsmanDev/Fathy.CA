using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

using Fathy.CA.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Fathy.CA.Web.Services;

public class CurrentUser(IHttpContextAccessor httpContextAccessor) : IUser
{
    public string Id => httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

    public List<string> Roles => httpContextAccessor.HttpContext?.User?.FindAll(ClaimTypes.Role).Select(x => x.Value).ToList();
}
