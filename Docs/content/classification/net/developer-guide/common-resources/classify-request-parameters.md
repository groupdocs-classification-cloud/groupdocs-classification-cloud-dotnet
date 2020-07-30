---
id: "classify-request-parameters"
url: "classification/classify-request-parameters"
title: "classify Request Parameters"
productName: "GroupDocs.Classification Cloud"
weight: 1
description: ""
keywords: ""
---

|Parameter|In|Type|Comment
|---|---|---|---
| |body|BaseRequest|Document's description (string) and/or document's info.
|BestClassesCount|url (Optional)|string ("1", "2", "3",..)|Count of the best classes to return.
|Taxonomy|url (Optional)|string ("", "default", "iab2", "documents", "sentiment")|Taxonomy to use for classification return.
|PrecisionRecallBalance|url (Optional)|string ("precision", "recall", "") |Balance between precision and recall.


## BaseRequest ##

### Model: ###

```javascript 

BaseRequest {
  description (string, optional),
  document (FileInfo, optional)
}
FileInfo {
  folder (string, optional),
  name (string, optional),
  password (string, optional)
}

 ```

### Examples: ###


JSON

```html 

{
  "description": "File description or raw text to classify if no document is specified",
  "document":
  {
    "folder": "File folder",
    "name": "File name",
    "password" : "File password"
  }
}

 ```

XML

```xml 

<?xml version#"1.0"?>

<BaseRequest>

<description>File description or raw text to classify if no document is specified
</description>

<document>
 
<folder>File folder
</folder>
 
<name>File name
</name>
 
<password>File password
</password>

</document>

</BaseRequest>

 ```
