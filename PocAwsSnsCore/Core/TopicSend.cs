using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using PocAwsSnsCore.Constants;
using PocAwsSnsCore.Entities;
using System;
using System.Text.Json;
using System.Threading.Tasks;
//https://aws.amazon.com/pt/sns/pricing/
//https://docs.aws.amazon.com/pt_br/sns/latest/dg/SendMessageToHttp.prepare.html
//https://docs.aws.amazon.com/pt_br/sns/latest/dg/SendMessageToHttp.confirm.html
//https://docs.aws.amazon.com/pt_br/sns/latest/dg/sns-verify-signature-of-message.html
//https://www.c-sharpcorner.com/article/amazon-sns-simple-notification-service-using-visual-studio/
//https://www.stevejgordon.co.uk/publishing-to-aws-simple-notification-service-sns-from-asp-net-core
//ngrok http -host-header=localhost https://localhost:44315

namespace PocAwsSnsCore.Core
{
    public class TopicSend
    {
        public async Task Send(string message)
        {
            try
            {
                var snsClient = new AmazonSimpleNotificationServiceClient(
                    awsAccessKeyId: KeysConstants.AWSAccessKey,
                    awsSecretAccessKey: KeysConstants.AWSSecretKey,
                    Amazon.RegionEndpoint.GetBySystemName(KeysConstants.AWSRegion));
                var topicRequest = new CreateTopicRequest
                {
                    Name = "DomvsSnsPoc"
                };
                var topicResponse = await snsClient.CreateTopicAsync(topicRequest);

                foreach (var endpoint in KeysConstants.Endpoints)
                {
                    var subscribeRequest = new SubscribeRequest()
                    {
                        TopicArn = topicResponse.TopicArn,
                        Protocol = "https",
                        Endpoint = endpoint
                    };
                    var res = await snsClient.SubscribeAsync(subscribeRequest);
                }
                var publishReq = new PublishRequest()
                {
                    TargetArn = topicResponse.TopicArn,
                    MessageStructure = "json",
                    Message = JsonSerializer.Serialize(new MessageBody()
                    {
                        Default = message,
                        Https = message
                    })
                };
                var response = await snsClient.PublishAsync(publishReq);

                if (response != null && response.MessageId != null)
                {
                }
            }
            catch (Exception xx)
            {
            }
        }
    }
}
