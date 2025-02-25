// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class ErrorSummaryModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AffectedResourceType))
            {
                writer.WritePropertyName("affectedResourceType"u8);
                writer.WriteStringValue(AffectedResourceType);
            }
            if (Optional.IsDefined(AffectedObjectsCount))
            {
                writer.WritePropertyName("affectedObjectsCount"u8);
                writer.WriteNumberValue(AffectedObjectsCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static ErrorSummaryModel DeserializeErrorSummaryModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> affectedResourceType = default;
            Optional<int> affectedObjectsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affectedResourceType"u8))
                {
                    affectedResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affectedObjectsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new ErrorSummaryModel(affectedResourceType.Value, Optional.ToNullable(affectedObjectsCount));
        }
    }
}
