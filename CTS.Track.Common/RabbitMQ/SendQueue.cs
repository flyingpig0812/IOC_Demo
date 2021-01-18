using CTS.Track.Model.RabbitMQEntity;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Common.RabbitMQ
{
    public class SendQueue
    {



        public static Task<bool> PublishMQ(RabbitMQParameter para, string msgContent)
        {
            try
            {
                string exchangeName = para.ExchangeName;
                string queueName = para.QueueName;
                string routeKey = para.RouteKey;
                string routingKey = para.RoutingKey;


                //创建连接工厂
                ConnectionFactory factory = new ConnectionFactory
                {
                    UserName = RabbitMQOptions.UserName,
                    Password = RabbitMQOptions.Password,
                    HostName = RabbitMQOptions.HostName,
                };

                //创建连接
                using (var connection = factory.CreateConnection())
                {
                    //创建通道
                    using (var channel = connection.CreateModel())
                    {
                        //定义一个Direct类型交换机
                        channel.ExchangeDeclare(exchangeName, ExchangeType.Topic, false, false, null);

                        //定义队列
                        channel.QueueDeclare(queueName, false, false, false, null);

                        //将队列绑定到交换机
                        channel.QueueBind(queueName, exchangeName, routeKey, null);

                        var sendBytes = Encoding.UTF8.GetBytes(msgContent);
                        //发布消息
                        channel.BasicPublish(exchangeName, routingKey, null, sendBytes);
                    }
                }
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw;
            }
        }




    }
}
