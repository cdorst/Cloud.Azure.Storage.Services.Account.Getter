# Cloud.Azure.Storage.Services.Account.Getter

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-account-getter.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-account-getter)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Account.Getter.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Getter)

## Description

Service responsible for getting an Azure Storage account instance

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Cloud.Azure.Storage.Options.Connection](https://github.com/CDorst/Cloud.Azure.Storage.Options.Connection) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-options-connection.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-options-connection) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Options.Connection.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Options.Connection)
[CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-account-interfaces-cl.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-account-interfaces-cl) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Interfaces.CloudStorageAccountGetter)
Microsoft.Extensions.Options | [![NuGet package status](https://img.shields.io/nuget/v/Microsoft.Extensions.Options.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/Microsoft.Extensions.Options)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Cloud.Azure.Storage.Services.Account.Extensions](https://github.com/CDorst/Cloud.Azure.Storage.Services.Account.Extensions) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-account-extensions.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-account-extensions) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Account.Extensions.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Extensions)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Getter](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Account.Getter)

## Version

1.0.0

## Metaproject

Cloud.Azure.Storage.Services.Account.Getter is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

