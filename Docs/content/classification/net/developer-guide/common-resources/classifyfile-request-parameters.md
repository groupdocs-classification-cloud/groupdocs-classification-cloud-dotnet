---
id: "classifyfile-request-parameters"
url: "classification/classifyfile-request-parameters"
title: "classify/file Request Rarameters"
productName: "GroupDocs.Classification Cloud"
weight: 1
description: ""
keywords: ""
---

|Parameter|In|Type|#Default value|Comment
|---|---|---|---|---
| |FormData|multipart/form-data| |File content.
|BestClassesCount|url (Optional)|string ("1", "2", "3",..)|"1"|Count of the best classes to return.
|Taxonomy|url (Optional)|string ("", "default", "iab2", "documents", "sentiment")|"default"|Taxonomy to use for classification return.
|PrecisionRecallBalance|url (Optional)|string ("precision", "recall", "") |""|Balance between precision and recall.
|Password|url (Optional)|string |null (not present)|File password.
