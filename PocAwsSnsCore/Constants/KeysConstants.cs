using System.Collections.Generic;

namespace PocAwsSnsCore.Constants
{
    public static class KeysConstants
    {
        public static readonly string AWSAccessKey = "AKIA55XC5QJDRMLFLLP2";
        public static readonly string AWSSecretKey = "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";
        public static readonly string AWSRegion = "us-east-1";
        public static readonly string TopicArn = "arn:aws:sns:us-east-1:957179855431:DomvsSnsPoc.fifo";
        public static readonly IReadOnlyList<string> Endpoints = new List<string>
        {
            "https://6dd6-2804-431-e7c1-e67a-a894-3e20-5ed9-2e6e.ngrok.io/Sublscriber/EndpointOne",
            "https://6dd6-2804-431-e7c1-e67a-a894-3e20-5ed9-2e6e.ngrok.io/Sublscriber/EndpointTwo",
            "https://6dd6-2804-431-e7c1-e67a-a894-3e20-5ed9-2e6e.ngrok.io/Sublscriber/EndpointThree"
        };
        // this endpoint is for android devices 
        //public static string gcmARN = $"arn:aws:sns:us-east-1:501401665234:endpoint/GCM/DomvsSnsPoc.fifo/***********************";
        // this endpoint is for ios devices   
        //public static string apnsARN = $"arn:aws:sns:us-east-1:502682123213:endpoint/APNS_SANDBOX/DomvsSnsPoc.fifo/*************";
    }
}
