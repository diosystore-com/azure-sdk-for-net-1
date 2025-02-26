// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    internal class SqlServerBlobAuditingPolicyOperationSource : IOperationSource<SqlServerBlobAuditingPolicyResource>
    {
        private readonly ArmClient _client;

        internal SqlServerBlobAuditingPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerBlobAuditingPolicyResource IOperationSource<SqlServerBlobAuditingPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerBlobAuditingPolicyData.DeserializeSqlServerBlobAuditingPolicyData(document.RootElement);
            return new SqlServerBlobAuditingPolicyResource(_client, data);
        }

        async ValueTask<SqlServerBlobAuditingPolicyResource> IOperationSource<SqlServerBlobAuditingPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerBlobAuditingPolicyData.DeserializeSqlServerBlobAuditingPolicyData(document.RootElement);
            return new SqlServerBlobAuditingPolicyResource(_client, data);
        }
    }
}
