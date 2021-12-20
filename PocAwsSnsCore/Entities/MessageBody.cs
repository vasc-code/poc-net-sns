namespace PocAwsSnsCore.Entities
{
    public class MessageBody
    {
        //{
        //    "default": "A message.",
        //    "email": "A message for email.",
        //    "email-json": "A message for email (JSON).",
        //    "http": "A message for HTTP.",
        //    "https": "A message for HTTPS.",
        //    "sqs": "A message for Amazon SQS." 
        //}
        public string Default { get; set; }
        public string Https { get; set; }
    }
}
