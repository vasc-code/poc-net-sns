﻿using System;

namespace PocAwsSnsCore.Entities
{
    public class SubscriberReceiver
    {
        public string Message { get; set; }
        public string MessageId { get; set; }
        public string Signature { get; set; }
        public string SignatureVersion { get; set; }
        public string SigningCertURL { get; set; }
        public string SubscribeURL { get; set; }
        public DateTime Timestamp { get; set; }
        public string Token { get; set; }
        public string TopicArn { get; set; }
        public string Type { get; set; }
        public string UnsubscribeURL { get; set; }
    }
}
