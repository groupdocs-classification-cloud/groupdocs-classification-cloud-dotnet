namespace GroupDocs.Classification.Cloud.Sdk.Examples
{
    using System;
    using System.Diagnostics;
    using GroupDocs.Classification.Cloud.Sdk.Api;
    using GroupDocs.Classification.Cloud.Sdk.Model;
    using GroupDocs.Classification.Cloud.Sdk.Model.Requests;

    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud/ (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            // Set timeout if necessary.
            // var apiInstance = new ClassificationApi(configuration,  10000);
            var apiInstance = new ClassificationApi(configuration);
            

            try
            {
                var request = new ClassifyRequest(new BaseRequest { Description = "Try Text classification" }, "3");

                // Get classification results
                var response = apiInstance.Classify(request);    
                Debug.Print(response.ToString());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassificationApi.Classify: " + e.Message);
            }
        }
    }
}
