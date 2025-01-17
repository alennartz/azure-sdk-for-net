// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class AnalyzeConversationTaskResult
    {
        internal static AnalyzeConversationTaskResult DeserializeAnalyzeConversationTaskResult(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ConversationResult": return CustomConversationalTaskResult.DeserializeCustomConversationalTaskResult(element);
                }
            }
            AnalyzeConversationTaskResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AnalyzeConversationTaskResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new AnalyzeConversationTaskResult(kind);
        }
    }
}
