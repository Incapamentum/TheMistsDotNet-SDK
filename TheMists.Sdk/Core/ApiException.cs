// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Net;

namespace TheMists.Sdk.Core
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string ResponseBody { get; }

        public ApiException(string message, HttpStatusCode statusCode, string responseBody)
            : base(message)
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }
}