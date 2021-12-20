using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PocAwsSnsCore.Entities;
using PocAwsSnsCore.Helper;
using System;
using System.Threading.Tasks;

namespace DomvsSnsPocApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SublscriberController : ControllerBase
    {
        private readonly ILogger<SublscriberController> _logger;

        public SublscriberController(ILogger<SublscriberController> logger)
        {
            var test = this;
            _logger = logger;
        }

        [HttpPost("EndpointOne")]
        public async Task<IActionResult> EndpointOne()
        {
            var message = await Request.Body.ToAsync<SubscriberReceiver>();
            if (message?.Type == "SubscriptionConfirmation")
            {
                var confirmed = message.SubscribeURL.VerifyEndpoint();
            }
            else if (message?.Type == "Notification")
            {

            }
            return Ok("EndpointOne: Recebido em: " + DateTime.Now.ToString("dddd', 'dd' de 'MMMM' de 'yyyy' às 'HH:mm:ss"));
        }

        [HttpPost("EndpointTwo")]
        public async Task<IActionResult> EndpointTwo()
        {
            var message = await Request.Body.ToAsync<SubscriberReceiver>();
            if (message?.Type == "SubscriptionConfirmation")
            {
                var confirmed = message.SubscribeURL.VerifyEndpoint();
            }
            else if (message?.Type == "Notification")
            {

            }
            return Ok("EndpointTwo: Recebido em: " + DateTime.Now.ToString("dddd', 'dd' de 'MMMM' de 'yyyy' às 'HH:mm:ss"));
        }

        [HttpPost("EndpointThree")]
        public async Task<IActionResult> EndpointThree()
        {
            var message = await Request.Body.ToAsync<SubscriberReceiver>();
            if (message?.Type == "SubscriptionConfirmation")
            {
                var confirmed = message.SubscribeURL.VerifyEndpoint();
            }
            else if (message?.Type == "Notification")
            {

            }
            return Ok("EndpointThree: Recebido em: " + DateTime.Now.ToString("dddd', 'dd' de 'MMMM' de 'yyyy' às 'HH:mm:ss"));
        }
    }
}
