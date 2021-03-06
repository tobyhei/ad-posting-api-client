# A pact between Ad Posting API Client and Ad Posting Template API

## Requests from Ad Posting API Client to Ad Posting Template API

* [A GET templates request to retrieve all templates](#a_GET_templates_request_to_retrieve_all_templates_given_There_are_no_templates_for_any_advertiser_related_to_the_requestor) given There are no templates for any advertiser related to the requestor

* [A GET templates request to retrieve all templates](#a_GET_templates_request_to_retrieve_all_templates_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor) given There are multiple templates for multiple advertisers related to the requestor

* [A GET templates request to retrieve all templates after specified sequence identifier](#a_GET_templates_request_to_retrieve_all_templates_after_specified_sequence_identifier_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor) given There are multiple templates for multiple advertisers related to the requestor

* [A GET templates request to retrieve all templates for an advertiser](#a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor) given There are multiple templates for multiple advertisers related to the requestor

* [A GET templates request to retrieve all templates for an advertiser after given sequence identifier](#a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_after_given_sequence_identifier_given_There_are_no_templates_after_given_sequence_identifier_for_all_advertisers_related_to_the_requestor) given There are no templates after given sequence identifier for all advertisers related to the requestor

* [A GET templates request to retrieve all templates for an advertiser after specified sequence identifier](#a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_after_specified_sequence_identifier_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor) given There are multiple templates for multiple advertisers related to the requestor

* [A GET templates request to retrieve all templates for an advertiser not related to requestor](#a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_not_related_to_requestor)

* [A GET templates request to retrieve all templates for an advertiser that doesn't exist](#a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_that_doesn_t_exist)

* [A GET templates request to retrieve all templates with invalid request field values](#a_GET_templates_request_to_retrieve_all_templates_with_invalid_request_field_values_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor) given There are multiple templates for multiple advertisers related to the requestor

## Interactions from Ad Posting API Client to Ad Posting Template API

<a name="a_GET_templates_request_to_retrieve_all_templates_given_There_are_no_templates_for_any_advertiser_related_to_the_requestor"></a>
Given **there are no templates for any advertiser related to the requestor**, upon receiving **a GET templates request to retrieve all templates** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "headers": {
    "Authorization": "Bearer a4f2aab5-5582-4ff0-b8f2-890d6146dbb6",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": []
    },
    "_links": {
      "self": {
        "href": "/template"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor"></a>
Given **there are multiple templates for multiple advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": [
        {
          "id": "892138",
          "advertiserId": "3214",
          "name": "Inactive template",
          "updatedDateTime": "2015-10-13T03:41:21Z",
          "state": "Inactive"
        },
        {
          "id": "65146183",
          "advertiserId": "456",
          "name": "The template with a round logo",
          "updatedDateTime": "2016-11-03T13:11:11Z",
          "state": "Active"
        },
        {
          "id": "8059016",
          "advertiserId": "456",
          "name": "The blue template",
          "updatedDateTime": "2017-01-03T11:45:44Z",
          "state": "Active"
        },
        {
          "id": "1132687",
          "advertiserId": "3214",
          "name": "Our first template",
          "updatedDateTime": "2017-03-23T11:12:10Z",
          "state": "Active"
        },
        {
          "id": "9874198",
          "advertiserId": "3214",
          "name": "Testing template",
          "updatedDateTime": "2017-05-07T09:45:43Z",
          "state": "Active"
        }
      ]
    },
    "_links": {
      "self": {
        "href": "/template"
      },
      "next": {
        "href": "/template?after=7005"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_after_specified_sequence_identifier_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor"></a>
Given **there are multiple templates for multiple advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates after specified sequence identifier** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "after=6011",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": [
        {
          "id": "8059016",
          "advertiserId": "456",
          "name": "The blue template",
          "updatedDateTime": "2017-01-03T11:45:44Z",
          "state": "Active"
        },
        {
          "id": "1132687",
          "advertiserId": "3214",
          "name": "Our first template",
          "updatedDateTime": "2017-03-23T11:12:10Z",
          "state": "Active"
        },
        {
          "id": "9874198",
          "advertiserId": "3214",
          "name": "Testing template",
          "updatedDateTime": "2017-05-07T09:45:43Z",
          "state": "Active"
        }
      ]
    },
    "_links": {
      "self": {
        "href": "/template?after=6011"
      },
      "next": {
        "href": "/template?after=7005"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor"></a>
Given **there are multiple templates for multiple advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates for an advertiser** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "advertiserId=456",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": [
        {
          "id": "65146183",
          "advertiserId": "456",
          "name": "The template with a round logo",
          "updatedDateTime": "2016-11-03T13:11:11Z",
          "state": "Active"
        },
        {
          "id": "8059016",
          "advertiserId": "456",
          "name": "The blue template",
          "updatedDateTime": "2017-01-03T11:45:44Z",
          "state": "Active"
        }
      ]
    },
    "_links": {
      "self": {
        "href": "/template?advertiserId=456"
      },
      "next": {
        "href": "/template?advertiserId=456&after=7001"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_after_given_sequence_identifier_given_There_are_no_templates_after_given_sequence_identifier_for_all_advertisers_related_to_the_requestor"></a>
Given **there are no templates after given sequence identifier for all advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates for an advertiser after given sequence identifier** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "advertiserId=3214&after=7005",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": []
    },
    "_links": {
      "self": {
        "href": "/template?advertiserId=3214&after=7005"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_after_specified_sequence_identifier_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor"></a>
Given **there are multiple templates for multiple advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates for an advertiser after specified sequence identifier** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "advertiserId=3214&after=6011",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 200,
  "headers": {
    "Content-Type": "application/vnd.seek.template-list+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "_embedded": {
      "templates": [
        {
          "id": "1132687",
          "advertiserId": "3214",
          "name": "Our first template",
          "updatedDateTime": "2017-03-23T11:12:10Z",
          "state": "Active"
        },
        {
          "id": "9874198",
          "advertiserId": "3214",
          "name": "Testing template",
          "updatedDateTime": "2017-05-07T09:45:43Z",
          "state": "Active"
        }
      ]
    },
    "_links": {
      "self": {
        "href": "/template?advertiserId=3214&after=6011"
      },
      "next": {
        "href": "/template?advertiserId=3214&after=7005"
      }
    }
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_not_related_to_requestor"></a>
Upon receiving **a GET templates request to retrieve all templates for an advertiser not related to requestor** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "advertiserId=456",
  "headers": {
    "Authorization": "Bearer a4f2aab5-5582-4ff0-b8f2-890d6146dbb6",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 403,
  "headers": {
    "Content-Type": "application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "message": "Forbidden",
    "errors": [
      {
        "code": "RelationshipError"
      }
    ]
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_for_an_advertiser_that_doesn_t_exist"></a>
Upon receiving **a GET templates request to retrieve all templates for an advertiser that doesn't exist** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "advertiserId=654321",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 403,
  "headers": {
    "Content-Type": "application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "message": "Forbidden",
    "errors": [
      {
        "code": "RelationshipError"
      }
    ]
  }
}
```

<a name="a_GET_templates_request_to_retrieve_all_templates_with_invalid_request_field_values_given_There_are_multiple_templates_for_multiple_advertisers_related_to_the_requestor"></a>
Given **there are multiple templates for multiple advertisers related to the requestor**, upon receiving **a GET templates request to retrieve all templates with invalid request field values** from Ad Posting API Client, with
```json
{
  "method": "get",
  "path": "/template",
  "query": "after=not-an-accepted-sequence-format",
  "headers": {
    "Authorization": "Bearer b635a7ea-1361-4cd8-9a07-bc3c12b2cf9e",
    "Accept": "application/vnd.seek.template-list+json; version=1; charset=utf-8, application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "User-Agent": "SEEK.AdPostingApi.Client/0.15.630.1108"
  }
}
```
Ad Posting Template API will respond with:
```json
{
  "status": 422,
  "headers": {
    "Content-Type": "application/vnd.seek.template-error+json; version=1; charset=utf-8",
    "X-Request-Id": "PactRequestId"
  },
  "body": {
    "message": "Validation Failure",
    "errors": [
      {
        "field": "after",
        "code": "InvalidValue"
      }
    ]
  }
}
```

