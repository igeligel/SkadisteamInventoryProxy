# Api Specification

## Inventory

### Parameters

| Field | Description | Required |
| -- | -- | -- |
| steamCommunityId | Steam Community 64 Bit Id to identify users. | :white_check_mark: |
| appId | Every game has it own id. This Id is called AppId. | :white_check_mark: |
| contextId | Sub Id for inventories of an AppId. Every game has a ContextId but ContextId can differentiate between different type of inventories. | :white_check_mark: |

### Request

```http
GET /api/inventory/{steamCommunityId}/{appId}/{contextId} HTTP/1.1
```

### Example Response

```http
HTTP/1.0 200 OK

{...}
```

- [Example 1](https://gist.github.com/igeligel/fb4eec37e6f74cbfe5a42a384864191b)
