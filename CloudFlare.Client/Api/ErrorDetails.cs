﻿namespace CloudFlare.Client.Api
{
    public class ErrorDetails
    {
        /// <summary>
        /// Integer error code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }
    }
}