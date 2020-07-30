---
id: "groupdocs-classification-cloud-20-5"
url: "classification/groupdocs-classification-cloud-20-5"
title: "GroupDocs.Classification Cloud 20.5"
productName: "GroupDocs.Classification Cloud"
description: ""
keywords: ""
---

## Major Features ##

* Support of the Chinese language was added to Sentiment taxonomy classification.


## Full List of Issues Covering all Changes in this Release ##

|#Key|#Summary|#Category
|GDCLASS-58|Support of the Chinese language for Sentiment taxonomy|Feature

## Public API and Backward Incompatible Changes ##

### Classify Chinese text with the Sentiment taxonomy ###

**Sentiment Analysis (Classification)**

```html 

curl -X POST "https://api.groupdocs.cloud/v1.0/classification/classify?BestClassesCount#1&Taxonomy#sentiment" \
-H "accept: application/json" -H "Content-Type: application/json" \
-d "{ \"description\": \"熟能生巧\"}" -H "Authorization: Bearer [Access_token]"

 ```

```json 

{
  "bestClassName": "Positive",
  "bestClassProbability":88.59,
  "bestResults":[{
    "className":"Positive",
 "classProbability":88.59
  }],
  "Code":200,
  "status":"OK"
}

 ```