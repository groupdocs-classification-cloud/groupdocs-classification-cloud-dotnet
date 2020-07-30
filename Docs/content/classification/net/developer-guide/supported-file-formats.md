---
id: "supported-file-formats"
url: "classification/supported-file-formats"
title: "Supported File Formats"
productName: "GroupDocs.Classification Cloud"
weight: 2
description: ""
keywords: ""
---






# Introduction #

GroupDocs.Classification Cloud REST API support to classify several documents formats such as:

Classification From:

Portable Document Format: PDF

Documents: DOC, DOCX, DOCM, DOT, DOTX, DOTM, RTF, TXT, ODT, OTT

## Resource ##

The following GroupDocs.Classification Cloud REST API resource has been used in the Supported File Formats example.

## cURL Rest Example ##


 Request

```html 
curl -v "https://api.groupdocs.cloud/v1.0/classification/formats" \
-X GET \
-H "Content-Type: application/json" \
-H "authorization: Bearer [Acccess Token]

 ```


 Response

```html 
{
  "formats": [
    {
      "fileFormat": "Microsoft Word",
      "extension": ".doc"
    },
    {
      "fileFormat": "Microsoft Word",
      "extension": ".docm"
    },
    {
      "fileFormat": "Microsoft Word",
      "extension": ".docx"
    },
    {
      "fileFormat": "Microsoft Word",
      "extension": ".dot"
    },
    {
      "fileFormat": "Microsoft Word",
      "extension": ".dotm"
    },
    {
      "fileFormat": "Microsoft Word",
      "extension": ".dotx"
    },
    {
      "fileFormat": "OpenDocument",
      "extension": ".odt"
    },
    {
      "fileFormat": "OpenDocument",
      "extension": ".ott"
    },
    {
      "fileFormat": "Portable Document Format",
      "extension": ".pdf"
    },
    {
      "fileFormat": "Plain Text",
      "extension": ".txt"
    },
    {
      "fileFormat": "Rich Text Format",
      "extension": ".rtf"
    }
  ]
}
 ```



## SDKs ##

The API is completely independent of your operating system, database system or development language. We provide and support API SDKs for C# language in order to make it even easier to integrate. You can see our available SDKs list [here](https://github.com/groupdocs-classification-cloud/).

### Get a List of Supported File Formats ###



 C#




{{< gist groupdocscloud adb54c76c82d414eeb066a86c8a9fc61 Classification_CSharp_Classify_Get_Supported_File_Formats.cs >}}






###   ###