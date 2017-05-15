# Configuration Examples

## Simple Proxy Configuration

*[appsettings.inventory.json](https://gist.github.com/igeligel/c2f693a6c9def50be6d4434778b971af)*

```json
{
  "proxies":[
    "220.249.185.178:9797",
    "61.5.207.102:80",
    "187.45.112.5:3128"
  ],
  "cacheTime":10,
  "communityIdsToIgnore":[

  ]
}
```

## Simple Ignore Configuration

*[appsettings.inventory.json](https://gist.github.com/igeligel/cd4544ad2a57306eae9b190036b4027a)*

```json
{
  "proxies":[

  ],
  "cacheTime":20,
  "communityIdsToIgnore":[
    76561197984437106,
    76561197993329385,
    76561197972563372
  ]
}
```


## Simple Mixed Configuration

*[appsettings.inventory.json](https://gist.github.com/igeligel/a3c77bd99153a41e0ff0cf7f5fcb3f05)*

```json
{
  "proxies":[
    "220.249.185.178:9797",
    "61.5.207.102:80",
    "187.45.112.5:3128"
  ],
  "cacheTime":40,
  "communityIdsToIgnore":[
    76561197984437106,
    76561197993329385,
    76561197972563372
  ]
}
```
