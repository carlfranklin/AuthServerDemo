using Microsoft.AspNetCore.Authorization;
namespace AuthServerDemo.Components.Account; 
public class RoleRequirement : IAuthorizationRequirement
{
    public string RequiredRole { get; }

    public RoleRequirement(string requiredRole)
    {
        RequiredRole = requiredRole;
    }
}

