// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The collection of request properties. </summary>
    public partial class WebTestPropertiesRequest
    {
        /// <summary> Initializes a new instance of WebTestPropertiesRequest. </summary>
        public WebTestPropertiesRequest()
        {
            Headers = new ChangeTrackingList<HeaderField>();
        }

        /// <summary> Initializes a new instance of WebTestPropertiesRequest. </summary>
        /// <param name="requestUri"> Url location to test. </param>
        /// <param name="headers"> List of headers and their values to add to the WebTest call. </param>
        /// <param name="httpVerb"> Http verb to use for this web test. </param>
        /// <param name="requestBody"> Base64 encoded string body to send with this web test. </param>
        /// <param name="parseDependentRequests"> Parse Dependent request for this WebTest. </param>
        /// <param name="followRedirects"> Follow redirects for this web test. </param>
        internal WebTestPropertiesRequest(Uri requestUri, IList<HeaderField> headers, string httpVerb, string requestBody, bool? parseDependentRequests, bool? followRedirects)
        {
            RequestUri = requestUri;
            Headers = headers;
            HttpVerb = httpVerb;
            RequestBody = requestBody;
            ParseDependentRequests = parseDependentRequests;
            FollowRedirects = followRedirects;
        }

        /// <summary> Url location to test. </summary>
        public Uri RequestUri { get; set; }
        /// <summary> List of headers and their values to add to the WebTest call. </summary>
        public IList<HeaderField> Headers { get; }
        /// <summary> Http verb to use for this web test. </summary>
        public string HttpVerb { get; set; }
        /// <summary> Base64 encoded string body to send with this web test. </summary>
        public string RequestBody { get; set; }
        /// <summary> Parse Dependent request for this WebTest. </summary>
        public bool? ParseDependentRequests { get; set; }
        /// <summary> Follow redirects for this web test. </summary>
        public bool? FollowRedirects { get; set; }
    }
}
