// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Cloud.Azure.Storage.Options.Connection;
using Cloud.Azure.Storage.Services.Account.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using System;

namespace Cloud.Azure.Storage.Services.Account.Getter
{
    /// <summary>Service responsible for getting an Azure Storage account instance</summary>
    public class CloudStorageAccountGetter : ICloudStorageAccountGetter
    {
        private readonly string _connectionString;

        public CloudStorageAccountGetter(IOptions<AzureStorageConnectionOptions> options)
        {
            _connectionString = options?.Value.ConnectionString ?? throw new ArgumentNullException(nameof(options));
        }

        /// <summary>Returns Azure Storage account instance</summary>
        public CloudStorageAccount GetAccount() => CloudStorageAccount.Parse(_connectionString);
    }
}
