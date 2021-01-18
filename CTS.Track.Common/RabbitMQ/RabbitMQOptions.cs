using CTS.Track.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Common.RabbitMQ
{
    public class RabbitMQOptions
    {
        public static string Password { get; set; } = Appsettings.app(new string[] { "RabbitMQ", "Password" });

        public static string UserName { get; set; } = Appsettings.app(new string[] { "RabbitMQ", "UserName" });

        public static string HostName { get; set; } = Appsettings.app(new string[] { "RabbitMQ", "HostName" });
        public static string RequestedConnectionTimeout { get; set; } = Appsettings.app(new string[] { "RabbitMQ", "RequestedConnectionTimeout" });

    }

    
}
