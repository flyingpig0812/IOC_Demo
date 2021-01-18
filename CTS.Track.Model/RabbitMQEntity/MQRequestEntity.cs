using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Model.RabbitMQEntity
{
    public class MQRequestEntity
    {
        /// <summary>
        /// ExchangeName
        /// </summary>
        public string ExchangeName { get; set; }
        /// <summary>
        /// QueueName
        /// </summary>
        public string QueueName { get; set; }
        /// <summary>
        /// RouteKey
        /// </summary>
        public string RouteKey { get; set; }
        /// <summary>
        /// BindRouteKey
        /// </summary>
        public string RoutingKey { get; set; }
        /// <summary>
        /// MessageContent
        /// </summary>
        public MessageData Data { get; set; }

    }

    public class MessageData
    {
        public string MessageContent { get; set; }

    }


}
