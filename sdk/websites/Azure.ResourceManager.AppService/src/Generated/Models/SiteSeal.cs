// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Site seal. </summary>
    public partial class SiteSeal
    {
        /// <summary> Initializes a new instance of SiteSeal. </summary>
        /// <param name="html"> HTML snippet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="html"/> is null. </exception>
        internal SiteSeal(string html)
        {
            Argument.AssertNotNull(html, nameof(html));

            Html = html;
        }

        /// <summary> HTML snippet. </summary>
        public string Html { get; }
    }
}
