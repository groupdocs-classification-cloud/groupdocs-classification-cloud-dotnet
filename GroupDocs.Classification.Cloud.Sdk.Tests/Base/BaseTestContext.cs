﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="BaseTestContext.cs">
// //   Copyright (c) 2018 Aspose.Words for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Classification.Cloud.Sdk.Tests.Base
{
    using System;
    using System.IO;

    using GroupDocs.Classification.Cloud.Sdk.Api;

    using Newtonsoft.Json;

    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {        
        protected static readonly string LocalTestDataFolder = DirectoryHelper.GetRootSdkFolder() + "/TestData/";
        private readonly Keys keys;        

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            // To run tests with your own credentials please substitute code bellow with this one
            // this.keys = new Keys { ClientSecret = "your client secret", ClientId = "your client id" };
            var serverCreds = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Settings", "servercreds.json");
            this.keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (this.keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain ClientId and ClientSecret");
            }

            var configuration = new Configuration { ApiBaseUrl = this.keys.BaseUrl, ClientSecret = this.keys.ClientSecret, ClientId = this.keys.ClientId, AuthorizationUrl = this.keys.AuthorizationUrl };

            // Set configuration and requests timeout.
            this.ClassificationApi = new ClassificationApi(configuration);
            this.FileApi = new FileApi(configuration);
        }

        /// <summary>
        /// Base path to test data        
        /// </summary>
        protected static string RemoteBaseTestDataFolder
        {
            get
            {
                return "Temp/SdkTests/TestData";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut";
            }
        }

        /// <summary>
        /// Returns common folder with source test files
        /// </summary>
        protected static string CommonFolder
        {
            get
            {
                return "Common/";
            }
        }
       
        /// <summary>
        /// Storage API
        /// </summary>
        protected FileApi FileApi { get; set; }

        /// <summary>
        /// Words API
        /// </summary>
        protected ClassificationApi ClassificationApi { get; set; }

        /// <summary>
        /// Client Id
        /// </summary>
        protected string ClientId
        {
            get
            {
                return this.keys.ClientId;
            }
        }

        /// <summary>
        /// Client Secret
        /// </summary>
        protected string ClientSecret
        {
            get
            {
                return this.keys.ClientSecret;
            }
        }

        /// <summary>
        /// Base Url for tests
        /// </summary>
        protected string BaseProductUri
        {
            get
            {
                return this.keys.BaseUrl;
            }
        }

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine(LocalTestDataFolder, string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }

        /// <summary>
        /// Uploads file to storage.
        /// </summary>
        /// <param name="path">Path in storage.</param>
        /// <param name="fileContent">File content.</param>
        /// <param name="versionId">Api version.</param>
        /// <param name="storage">Storage.</param>
        protected void UploadFileToStorage(string path, byte[] fileContent, string versionId = null, string storage = null)
        {
            using (var ms = new MemoryStream(fileContent))
            {
                var request = new Model.Requests.UploadFileRequest(path, ms, storage);
                var response = this.FileApi.UploadFile(request);
                if (response == null)
                {
                    throw new Exception("Can't upload file to the storage. Details: " + response.ToString());
                }
            }
        }
        
        private class Keys
        {
            public string ClientId { get; set; }

            public string ClientSecret { get; set; }

            public string BaseUrl { get; set; }

            public string AuthorizationUrl { get; set; }
        }
    }
}