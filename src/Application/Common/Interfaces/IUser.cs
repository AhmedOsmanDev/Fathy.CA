using System.Collections.Generic;

namespace Fathy.CA.Application.Common.Interfaces;

public interface IUser
{
    string Id { get; }
    List<string> Roles { get; }
}
