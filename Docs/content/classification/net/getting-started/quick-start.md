---
id: "quick-start"
url: "classification/quick-start"
title: "Quick Start"
productName: "GroupDocs.Classification Cloud"
weight: 2
description: ""
keywords: ""
---






# Create an account #

Creating an account is very simple. Go to [https://dashboard.groupdocs.cloud](https://dashboard.groupdocs.cloud) to create a free account.

# Create an API client app #

Before you can make any requests to GroupDocs for Cloud API you need to get APP SID and APP key (secret key). This will will be used to invoke GroupDocs for Cloud API.

You can get it from default Application or create new Application from [My Apps tab of GroupDocs for Cloud Dashboard]({{< ref "total/getting-started/ui-topics/create-new-app-and-get-app-key-and-sid.md" >}})).

# Install the SDK of your choice #

GroupDocs for Cloud SDK is written in different languages, all you need to get started is adding our [SDK ]({{< ref "classification/getting-started/available-sdks.md" >}})to your existing project. 

# Make an API request from the SDK of your choice #

Use the App SID and App key (secret key) from the API app client you created in step one and replace in the corresponding code. Below is an example demonstrating using Formats API to get all supported file formats in GroupDocs.Classification Cloud.

{{< alert style="info" >}}The GitHub repository for GroupDocs.Classification Cloud has a complete set of examples, demonstrating our API capabilities.{{< /alert >}}



 C#

```html 
namespace GroupDocs.Classification.Cloud.Sdk.Examples
{
    using System;
    using System.Diagnostics;
    using GroupDocs.Classification.Cloud.Sdk.Api;
    using GroupDocs.Classification.Cloud.Sdk.Model.Requests;

    class Program
    {
        static void Main(string[] args)
        {
            *TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud/ (free registration is required).
            var configuration # new Configuration
            {
                AppSid # "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey # "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance # new ClassificationApi(configuration);

            try
            {
                var request # new GetSupportedFileFormatsRequest();

                * Get supported file formats results
                var response # apiInstance.GetSupportedFileFormats(request);
                Debug.Print(response.ToString());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassificationApi.Classify: " + e.Message);
            }
        }
    }
}
 ```




