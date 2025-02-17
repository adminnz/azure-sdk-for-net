// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
    public partial class NetworkVirtualApplianceCreateOrUpdateOperation : Operation<NetworkVirtualAppliance>, IOperationSource<NetworkVirtualAppliance>
    {
        private readonly OperationInternals<NetworkVirtualAppliance> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of NetworkVirtualApplianceCreateOrUpdateOperation for mocking. </summary>
        protected NetworkVirtualApplianceCreateOrUpdateOperation()
        {
        }

        internal NetworkVirtualApplianceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<NetworkVirtualAppliance>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "NetworkVirtualApplianceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NetworkVirtualAppliance Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        NetworkVirtualAppliance IOperationSource<NetworkVirtualAppliance>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new NetworkVirtualAppliance(_operationBase, NetworkVirtualApplianceData.DeserializeNetworkVirtualApplianceData(document.RootElement));
        }

        async ValueTask<NetworkVirtualAppliance> IOperationSource<NetworkVirtualAppliance>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new NetworkVirtualAppliance(_operationBase, NetworkVirtualApplianceData.DeserializeNetworkVirtualApplianceData(document.RootElement));
        }
    }
}
