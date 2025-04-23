using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_System
{
    internal static class SessionStorage
    {
        public static string AuthToken = string.Empty;
        public static string Username { get; set; }
        public static void SetToken()
        {
            AuthToken = Guid.NewGuid().ToString();
        }

        public static void DeleteCreds()
        {
            AuthToken = string.Empty;
            Username = string.Empty;
        }
    }
}
