using authentication_authorization_scratch_.Models;
using System.Text.Json;
namespace authentication_authorization_scratch_.Services
{
    public class SessionService
    {
        public static string SessionKeyName = "LoggedInUser";
        internal static void SetSession(LoggedInUserInfo loggeduserinfo, HttpContext httpContext)
        {
            httpContext.Session.Set<LoggedInUserInfo>(SessionKeyName, loggeduserinfo);
        }

        internal static LoggedInUserInfo GetSession(HttpContext httpContext)
        {
            return httpContext.Session.Get<LoggedInUserInfo>(SessionKeyName);
        }
        internal static LoggedInUserInfo ClearSession(HttpContext httpContext)
        {
            httpContext.Session.Clear();
            return null;
        }
    }
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
