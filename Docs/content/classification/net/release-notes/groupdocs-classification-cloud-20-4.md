---
id: "groupdocs-classification-cloud-20-4"
url: "classification/groupdocs-classification-cloud-20-4"
title: "GroupDocs.Classification Cloud 20.4"
productName: "GroupDocs.Classification Cloud"
description: ""
keywords: ""
---

##   ##

## Major Features ##

* Files can be classified from request content.
* Sentiment Classification (Analysis) was added.

##   ##

## Full List of Issues Covering all Changes in this Release ##

|#Key|#Summary|#Category
|GDCLASS-41|Classification with a file in content of post request.|Improvement
|GDCLASS-52|Sentiment taxonomy was added.|Improvement

##   ##

## Public API and Backward Incompatible Changes ##

### Classification with a file in content of post request ###

**File content classification**

```html 

curl -X POST "https://api.groupdocs.cloud/v1.0/classification/classify/file" -F data#@File.docx -H "Authorization: Bearer [AccessToken]"

 ```

```json 

{
  "bestClassName": "Books_and_Literature",
  "bestClassProbability": 48.92,
  "bestResults": [{
    "className": "Books_and_Literature",
    "classProbability": 48.92
  }],
  "code": 200,
  "status": "OK"
}

 ```


### Classify text with the Sentiment taxonomy ###


**Sentiment Analysis (Classification)**

```html 

curl -X POST "https://api.groupdocs.cloud/v1.0/classification/classify?BestClassesCount#1&Taxonomy#sentiment" \
-H "accept: application/json" -H "Content-Type: application/json" \
-d "{ \"description\": \"1st look of the product is simply superb..\"}" -H "Authorization: Bearer [Access_token]"

 ```

```json 

{
  "bestClassName": "Positive",
  "bestClassProbability":90.02,
  "bestResults":[{
    "className":"Positive",
 "classProbability":90.02
  }],
  "Code":200,
  "status":"OK"
}

 ```