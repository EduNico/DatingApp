using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions //static class because we are creating an extension method.

    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

           public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst( ClaimTypes.NameIdentifier)?.Value;
        }
    }
}