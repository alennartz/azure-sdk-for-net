// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class VirtualMachineSecrets
    {
        internal static VirtualMachineSecrets DeserializeVirtualMachineSecrets(JsonElement element)
        {
            Optional<VirtualMachineSshCredentials> administratorAccount = default;
            ComputeType computeType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorAccount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    administratorAccount = VirtualMachineSshCredentials.DeserializeVirtualMachineSshCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("computeType"))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachineSecrets(computeType, administratorAccount.Value);
        }
    }
}
