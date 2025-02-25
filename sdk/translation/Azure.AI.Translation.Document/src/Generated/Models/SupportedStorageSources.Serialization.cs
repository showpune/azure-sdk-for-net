// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class SupportedStorageSources
    {
        internal static SupportedStorageSources DeserializeSupportedStorageSources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<StorageSource> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<StorageSource> array = new List<StorageSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new StorageSource(item.GetString()));
                    }
                    value = array;
                    continue;
                }
            }
            return new SupportedStorageSources(value);
        }
    }
}
