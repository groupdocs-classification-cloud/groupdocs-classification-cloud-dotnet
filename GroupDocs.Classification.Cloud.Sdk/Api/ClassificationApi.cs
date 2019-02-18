// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassificationApi.cs">
//   Copyright (c) 2018 GroupDocs.Classification for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Classification.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Classification.Cloud.Sdk.Internal;
    using GroupDocs.Classification.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Classification.Cloud.Sdk.Model;
    using GroupDocs.Classification.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Classification for Cloud API.
    /// </summary>
    public class ClassificationApi
    {
        public const int DefaultTimeout = 100000;

        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public ClassificationApi(string apiKey, string appSid, int timeout = DefaultTimeout)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        /// <param name="timeout">Request's timeout (default is 100s)</param>
        public ClassificationApi(Configuration configuration, int timeout = DefaultTimeout)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, timeout);
        }                            

        /// <summary>
        /// Classifies text or document. 
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyRequest" /></param> 
        /// <returns><see cref="ClassificationResponse"/></returns>            
        public ClassificationResponse Classify(ClassifyRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.Request == null) 
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling Classify");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/classification/classify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bestClassesCount", request.BestClassesCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taxonomy", request.Taxonomy);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "precisionRecallBalance", request.PrecisionRecallBalance);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ClassificationResponse)SerializationHelper.Deserialize(response, typeof(ClassificationResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Retrieves list of supported file formats. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSupportedFileFormatsRequest" /></param> 
        /// <returns><see cref="FormatCollection"/></returns>            
        public FormatCollection GetSupportedFileFormats(GetSupportedFileFormatsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/classification/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FormatCollection)SerializationHelper.Deserialize(response, typeof(FormatCollection));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}
