# SkadisteamInventoryProxy  by <a href="https://github.com/igeligel">igeligel</a>

<div style="text-align:center"><a href="https://www.paypal.me/kevinpeters96/1"><img src="https://img.shields.io/badge/Donate-Paypal-003087.svg?style=flat" alt="badge Donate" /></a> <a href="https://steamcommunity.com/tradeoffer/new/?partner=68364320&token=CzTCv8JM"><img src="https://img.shields.io/badge/Donate-Steam-000000.svg?style=flat" alt="badge Donate" /></a> <a href="https://github.com/igeligel/BackpackLogin/blob/master/LICENSE.md"><img src="https://img.shields.io/badge/License-MIT-1da1f2.svg?style=flat" alt="badge License" /></a> </div>



## Description

> A [.NET Core](https://www.microsoft.com/net/core) Project within a [Docker](https://www.docker.com/) Container to make it possible to easily host a Proxy Service for [Steam Community](http://steamcommunity.com/) Inventory Requests.



## Installation

Just run the command:

```bash
./build.sh
```

If you dont have the possibility to run [Docker](https://www.docker.com/) you can run it as normal [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) Web Application:

```bash
cd src
dotnet restore
dotnet publish -c Release -o out
cd out
dotnet SkadisteamInventoryProxy.dll
```

For development:

```bash
cd src
dotnet restore
dotnet build
dotnet run
```

## How To Use

In the [source code](https://github.com/igeligel/SkadisteamInventoryProxy/tree/master/src) of this repository you can find a file called [appsettings.inventory.json](https://github.com/igeligel/SkadisteamInventoryProxy/blob/master/src/appsettings.inventory.json).

You can set different configurations inside this file. For more documentations check out the docs folder.

After you have applied the settings you can start the application and go to: [localhost:5000/api/inventory/76561198028630048/730/2](http://localhost:5000/api/inventory/{steamCommunityId}/{appId}/{contextId}).

The whole API is hosted on Port 5000. If you want to change this, change the Port inside [Program.cs](https://github.com/igeligel/SkadisteamInventoryProxy/blob/master/src/Program.cs#L16).

## Examples
- [Hosted on Digital Ocean (No Production)](http://46.101.102.223/api/inventory/76561198028630048/730/2)


## Contributing

Feel free to contribute. Always check Issues first if something is requested.

## Resources

### Motivation

Since [Steam Community](http://steamcommunity.com/) is limiting requests to the [inventory endpoint](http://steamcommunity.com/inventory/76561198028630048/730/2?l=english&count=5000) heavily, i was forced to come up with a solution. Since it should be just an easy project you can just get up and running with [Docker](https://www.docker.com/) and configuring the settings file.

### Documentation

> You can find documentation [here](https://github.com/igeligel/SkadisteamInventoryProxy/tree/master/docs).

## Contact

<p align="center">
  <a href="https://discord.gg/HS57euF"><img src="https://img.shields.io/badge/Contact-Discord-7289da.svg" alt="Discord server of Kevin Peters"></a>
  <a href="https://twitter.com/kevinpeters_"><img src="https://img.shields.io/badge/Contact-Twitter-1da1f2.svg" alt="Twitter of Kevin Peters"></a>
  <a href="http://steamcommunity.com/profiles/76561198028630048"><img src="https://img.shields.io/badge/Contact-Steam-000000.svg" alt="Steam Profile of Kevin Peters"></a>
</p>


<h2>Contributors</h2>

<table><thead><tr><th align="center"><a href="https://github.com/igeligel"><img src="https://avatars2.githubusercontent.com/u/12736734?v=3" width="100px;" style="max-width:100%;"><br><sub>igeligel</sub></a><br><p>Contributions: 4</p></th></tbody></table>

## License

*SkadisteamInventoryProxy* is realeased under the MIT License.

## This readme is powered by vue-readme

Check out vue-readme [[Website](https://igeligel.github.io/vue-readme) | [GitHub](https://github.com/igeligel/vue-readme)]
