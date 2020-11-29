# GroupDocs.Classification Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.Words-Cloud.svg)](https://www.nuget.org/packages/GroupDocs.Classification-Cloud/)
This repository contains GroupDocs.Classification Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Classification Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

# Key Features
* Classification of texts
* Classification of documents


See [API Reference](https://apireference.groupdocs.cloud/classification/) for full API specification.

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/GroupDocs.Classification-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.groupdocs.cloud/classification/).

### Prerequisites

To use GroupDocs.Classification for Cloud .NET SDK you need to register an account with [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.groupdocs.cloud/#/apps). There is free quota available. For more details, see [GroupDocs Cloud Pricing](https://purchase.groupdocs.cloud/pricing).

### Installation

#### Install GroupDocs.Classification-Cloud via NuGet

From the command line:

	`nuget install GroupDocs.Classification-Cloud`

From Package Manager:

	`PM> Install-Package GroupDocs.Classification-Cloud`

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "GroupDocs.Classification-Cloud".
5. Click on the GroupDocs.Classification-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The examples below show how your application have to initiate and classify "pdf" file using GroupDocs.Classification-Cloud library:
## Getting Started

```csharp
namespace Example
{
    using System;
    using System.Diagnostics;
    using GroupDocs.Classification.Cloud.Sdk;
    using GroupDocs.Classification.Cloud.Sdk.Api;
    using GroupDocs.Classification.Cloud.Sdk.Model;
    using GroupDocs.Classification.Cloud.Sdk.Model.Requests;

    public class Example
    {
        public void Main()
        {
            // TODO: Get your ClientId and ClientSecret at https://dashboard.groupdocs.cloud/ (free registration is required).
            var configuration = new Configuration
            {
                ClientId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                ClientSecret = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance = new ClassificationApi(configuration);
            var request = new ClassifyRequest(new BaseRequest { Description = "Try Text classification" }, "3");

            try
            {
                var response = apiInstance.classify(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassificationApi.classify: " + e.Message);
            }
        }
    }
}
```

[Tests](GroupDocs.Classification.Cloud.Sdk.Tests) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/classification/net) | [Docs](https://docs.groupdocs.cloud/classification/) | [Demos](https://products.groupdocs.app/classification/family) | [API Reference](https://apireference.groupdocs.cloud/classification/) | [Examples](https://github.com/groupdocs-classification-cloud/groupdocs-classification-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/classification/) | [Free Support](https://forum.groupdocs.cloud/c/classification) | [Free Trial](https://purchase.groupdocs.cloud/trial)
