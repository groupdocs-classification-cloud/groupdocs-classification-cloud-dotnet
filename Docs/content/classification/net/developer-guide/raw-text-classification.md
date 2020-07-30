---
id: "raw-text-classification"
url: "classification/raw-text-classification"
title: "Raw Text Classification"
productName: "GroupDocs.Classification Cloud"
weight: 3
description: ""
keywords: ""
---






# Classify raw text #

This API retrieves raw text classification result for [IAB-2, Documents or Sentiment taxonomy]({{< ref "classification/developer-guide/common-resources/taxonomy.md" >}}). It returns an object that contains information about the best class and its probability and about probabilities of the other classes. For Sentiment taxonomy Chinese and English are supported with the language auto-detection.

See [Classify request parameters]({{< ref "classification/developer-guide/common-resources/classify-request-parameters.md" >}}) for request's details.

## Resource ##

This resource represents a controller for single call text classification.

Classify raw text with IAB-2 taxonomy.

## cURL REST Example ##


 Request

```javascript 
curl -v "http://api.groupdocs.cloud/v1.0/classification/classify?bestClassesCount#3"
-H "content-type: application/json"
-X POST -d '{ "Description" : "Medicine is an important part of our life" }'
 ```


 Response

```javascript 
{
  "bestClassName": "Healthy_Living",
  "bestClassProbability": 53.77,
  "bestResults": [
    {
      "className": "Healthy_Living",
      "classProbability": 53.77
    },
    {
      "className": "Medical_Health",
      "classProbability": 38.27
    },
    {
      "className": "Pets",
      "classProbability": 1.98
    }
  ],
  "code": 200,
  "status": "OK"
}
 ```



## SDKs ##

The API is completely independent of your operating system, database system or development language. We provide and support API SDKs in many development languages in order to make it even easier to integrate. You can see our available SDKs list [here](https://github.com/groupdocs-classification-cloud/)

### Classify raw text ###


 C#




{{< gist groupdocscloud adb54c76c82d414eeb066a86c8a9fc61 Classification_CSharp_Classify_Raw_Text.cs >}}




