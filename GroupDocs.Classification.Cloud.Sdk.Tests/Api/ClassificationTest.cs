// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ClassificationTest.cs">
// //   Copyright (c) 2018 GroupDocs.Classification for Cloud
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

namespace GroupDocs.Classification.Cloud.Sdk.Tests.Api
{
    using System.IO;
    using GroupDocs.Classification.Cloud.Sdk.Model;
    using GroupDocs.Classification.Cloud.Sdk.Model.Requests;
    using GroupDocs.Classification.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Examples of how to classify text and documents with IAB-2, Documents or Sentiment taxonomy.
    /// </summary>
    [TestFixture]
    public class ClassificationTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "Common");

        /// <summary>
        /// Test for raw text classification.
        /// </summary>
        [Test]
        public void TestClassify()
        {
            var request = new ClassifyRequest(new BaseRequest { Description = "Try Text classification" }, "3");
            var actual = this.ClassificationApi.Classify(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for the sentiment classification.
        /// </summary>
        [Test]
        public void TestClassifySentiment()
        {
            var request = new ClassifyRequest(new BaseRequest { Description = "Try sentiment classification. This product is good." }, "3", "sentiment");
            var actual = this.ClassificationApi.Classify(request);

            Assert.AreEqual(200, actual.Code);
            Assert.AreEqual("Positive", actual.BestClassName);
        }

        /// <summary>
        /// Test for the document classification.
        /// </summary>
        [Test]
        public void TestClassifyDocument()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "Source.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var baseRequest = new BaseRequest()
            {
                Document = new Model.FileInfo() { Name = remoteName, Folder = this.dataFolder },
            };

            // ClassifyRequest is a common request for string and document classification.
            var request = new ClassifyRequest(baseRequest, bestClassesCount: "3");
           
            var actual = this.ClassificationApi.Classify(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for the document classification with taxonomy "documents".
        /// </summary>
        [Test]
        public void TestClassifyTaxonomyDocuments()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "Source.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new ClassifyRequest(new BaseRequest()
            {
                Document = new Model.FileInfo() { Name = remoteName, Folder = this.dataFolder },
            },
            bestClassesCount: "3",
            taxonomy: "documents");

            var actual = this.ClassificationApi.Classify(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for classification by request content.
        /// </summary>
        [Test]
        public void TestClassifyRequestBody()
        {
            var localName = "test_multi_pages.docx";

            using (var content = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName))
            {
                // Classifies file with sentiment taxonomy and returns 2 best results.
                var actual = this.ClassificationApi.ClassifyFile(new ClassifyFileRequest(content, "2", "Sentiment"));
                Assert.AreEqual(200, actual.Code);
            }
        }
    }
}