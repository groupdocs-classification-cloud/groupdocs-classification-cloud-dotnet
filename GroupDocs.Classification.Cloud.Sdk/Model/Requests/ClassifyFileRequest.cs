// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassifyFileRequest.cs">
//   Copyright (c) 2020 GroupDocs.Classification for Cloud
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
namespace GroupDocs.Classification.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Classification.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Classification.Cloud.Sdk.Api.ClassificationApi.ClassifyFile" /> operation.
  /// </summary>  
  public class ClassifyFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyFileRequest"/> class.
        /// </summary>        
        public ClassifyFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyFileRequest"/> class.
        /// </summary>
        /// <param name="file">File to upload.</param>
        /// <param name="bestClassesCount">Count of the best classes to return.</param>
        /// <param name="taxonomy">Taxonomy to use for classification.</param>
        /// <param name="precisionRecallBalance">Balance between precision and recall: precision, recall or empty (for default).</param>
        /// <param name="password">File password.</param>
        public ClassifyFileRequest(System.IO.Stream file = null, string bestClassesCount = null, string taxonomy = null, string precisionRecallBalance = null, string password = null)             
        {
            this.BestClassesCount = bestClassesCount;
            this.Taxonomy = taxonomy;
            this.PrecisionRecallBalance = precisionRecallBalance;
            this.Password = password;
            this.File = file;
        }

        /// <summary>
        /// Count of the best classes to return.
        /// </summary>  
        public string BestClassesCount { get; set; }

        /// <summary>
        /// Taxonomy to use for classification.
        /// </summary>  
        public string Taxonomy { get; set; }

        /// <summary>
        /// Balance between precision and recall: precision, recall or empty (for default).
        /// </summary>  
        public string PrecisionRecallBalance { get; set; }

        /// <summary>
        /// File password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// File to upload
        /// </summary>  
        public System.IO.Stream File { get; set; }
  }
}