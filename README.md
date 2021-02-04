![](https://img.shields.io/badge/api-v1.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.classification-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.classification-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-classification-cloud/groupdocs-classification-cloud-dotnet)](https://github.com/groupdocs-classification-cloud/groupdocs-classification-cloud-dotnet/blob/master/LICENSE)

# Data Classification .NET Cloud REST API
This repository contains GroupDocs.Classification Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Classification Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

# Classification Processing Features
- Perform raw text classification.
- Perform document classification for the supported file formats.
- Perform multilingual sentiment analysis (binary or 3-classes) in English, Chinese, Spanish, and German.


See [API Reference](https://apireference.groupdocs.cloud/classification/) for full API specification.
## New Features & Enhancements Version 20.11

- Batch text classification was added to API. Now up to 10 texts can be classified in one request.
- Sentiment3 taxonomy (Negative/Neutral/Positive) is supported now.

## Supported Document Formats

- **Microsoft Word**: DOC, DOCX, DOCM, DOT, DOTX, DOTM
- **OpenOffice**: ODT, OTT
- **Portable**: PDF
- **Other**: RTF, TXT

### Supported IAB-2 Taxonomy

- Automotive,
- Books_and_Literature,
- Business_and_Finance,
- Careers,
- Education,
- Events_and_Attractions,
- Family_and_Relationships,
- Fine_Art,
- Food_&_Drink,
- Healthy_Living,
- Hobbies_&_Interests,
- Home_&_Garden,
- Medical_Health,
- Movies,
- Music_and_Audio,
- News_and_Politics,
- Personal_Finance,
- Pets,
- Pop_Culture,
- Real_Estate,
- Religion_&_Spirituality,
- Science,
- Shopping,
- Sports,
- Style_&_Fashion,
- Technology_&_Computing,
- Television,
- Travel,
- Video_Gaming

### Supported Documents Taxonomy

- ADVE - advertisements, brochures.
- Email
- Form
- Letter
- Memo - memorandums.
- News - articles, including news articles.
- Invoice
- Report
- Resume
- Scientific - scientific papers.
- Other - the other classes of documents or cases where the classifier is not sure.

### Sentiment Taxonomy

- Negative
- Positive
-
### Sentiment3 Taxonomy`

- Negative
- Neutral
- Positive
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


## Get Supported File Formats for Classification

```csharp
// Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
string MyClientId = "";
string MyClientSecret = "";

// Create instance of the API
var configuration = new Configuration(MyClientId, MyClientSecret);
var api = new ClassificationApi(configuration);

// Get supported file formats
var response = api.GetSupportedFileFormats();

foreach (var format in response.Formats)
{
	Debug.Print(format.ToString());
}
```

[Tests](GroupDocs.Classification.Cloud.Sdk.Tests) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## GroupDocs.Classification Cloud Resources

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/classification/net) | [Docs](https://docs.groupdocs.cloud/classification/) | [Demos](https://products.groupdocs.app/classification/family) | [API Reference](https://apireference.groupdocs.cloud/classification/) | [Examples](https://github.com/groupdocs-classification-cloud/groupdocs-classification-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/classification/) | [Free Support](https://forum.groupdocs.cloud/c/classification) | [Free Trial](https://purchase.groupdocs.cloud/trial)
