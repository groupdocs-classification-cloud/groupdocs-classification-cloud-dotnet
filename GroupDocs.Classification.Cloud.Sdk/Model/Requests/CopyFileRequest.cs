// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFileRequest.cs">
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
  /// Request model for <see cref="GroupDocs.Classification.Cloud.Sdk.Api.ClassificationApi.CopyFile" /> operation.
  /// </summary>  
  public class CopyFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>        
        public CopyFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        /// <param name="versionId">File version ID to copy</param>
        public CopyFileRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)             
        {
            this.SrcPath = srcPath;
            this.DestPath = destPath;
            this.SrcStorageName = srcStorageName;
            this.DestStorageName = destStorageName;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Source file path e.g. '/folder/file.ext'
        /// </summary>  
        public string SrcPath { get; set; }

        /// <summary>
        /// Destination file path
        /// </summary>  
        public string DestPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>  
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>  
        public string DestStorageName { get; set; }

        /// <summary>
        /// File version ID to copy
        /// </summary>  
        public string VersionId { get; set; }
  }
}