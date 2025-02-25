// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The kind of managed identity assigned to this resource. </summary>
    public readonly partial struct ManagedIdentityType : IEquatable<ManagedIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";
        private const string SystemAndUserAssignedValue = "SystemAssigned,UserAssigned";

        /// <summary> None. </summary>
        public static ManagedIdentityType None { get; } = new ManagedIdentityType(NoneValue);
        /// <summary> SystemAssigned. </summary>
        public static ManagedIdentityType SystemAssigned { get; } = new ManagedIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static ManagedIdentityType UserAssigned { get; } = new ManagedIdentityType(UserAssignedValue);
        /// <summary> SystemAssigned,UserAssigned. </summary>
        public static ManagedIdentityType SystemAndUserAssigned { get; } = new ManagedIdentityType(SystemAndUserAssignedValue);
        /// <summary> Determines if two <see cref="ManagedIdentityType"/> values are the same. </summary>
        public static bool operator ==(ManagedIdentityType left, ManagedIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedIdentityType"/> values are not the same. </summary>
        public static bool operator !=(ManagedIdentityType left, ManagedIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedIdentityType"/>. </summary>
        public static implicit operator ManagedIdentityType(string value) => new ManagedIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
