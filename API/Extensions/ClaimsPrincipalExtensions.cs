using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions //static class because we are creating an extension method.

    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

           public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst( ClaimTypes.NameIdentifier)?.Value);
        }
    }
}