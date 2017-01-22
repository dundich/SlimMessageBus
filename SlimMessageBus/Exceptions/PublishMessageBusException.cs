﻿using System;

namespace SlimMessageBus
{
    public class PublishMessageBusException : MessageBusException
    {
        public PublishMessageBusException(string message) : base(message)
        {
        }

        public PublishMessageBusException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}