using System.Net;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;

namespace HttpClientFactorySample.Handlers
{
    public class RequestDataHandler : DelegatingHandler
    {
        private readonly ILogger<RequestDataHandler> _logger;

        private const string RequestSourceHeaderName = "Request-Source";
        private const string RequestSource = "HttpClientFactorySampleApp";
        private const string RequestIdHeaderName = "Request-Identifier";

        public RequestDataHandler(ILogger<RequestDataHandler> logger)
        {
            _logger = logger;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var identifier = Guid.NewGuid(); // some information we want to generate and add per request

            _logger.LogInformation($"Starting request {identifier}");

            request.Headers.Add(RequestSourceHeaderName, RequestSource);
            request.Headers.Add(RequestIdHeaderName, identifier.ToString());

            return base.SendAsync(request, cancellationToken);
        }
    }
}