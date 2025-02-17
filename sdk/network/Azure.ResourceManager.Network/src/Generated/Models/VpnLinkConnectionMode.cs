// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn link connection mode. </summary>
    public readonly partial struct VpnLinkConnectionMode : IEquatable<VpnLinkConnectionMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VpnLinkConnectionMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnLinkConnectionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string ResponderOnlyValue = "ResponderOnly";
        private const string InitiatorOnlyValue = "InitiatorOnly";

        /// <summary> Default. </summary>
        public static VpnLinkConnectionMode Default { get; } = new VpnLinkConnectionMode(DefaultValue);
        /// <summary> ResponderOnly. </summary>
        public static VpnLinkConnectionMode ResponderOnly { get; } = new VpnLinkConnectionMode(ResponderOnlyValue);
        /// <summary> InitiatorOnly. </summary>
        public static VpnLinkConnectionMode InitiatorOnly { get; } = new VpnLinkConnectionMode(InitiatorOnlyValue);
        /// <summary> Determines if two <see cref="VpnLinkConnectionMode"/> values are the same. </summary>
        public static bool operator ==(VpnLinkConnectionMode left, VpnLinkConnectionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnLinkConnectionMode"/> values are not the same. </summary>
        public static bool operator !=(VpnLinkConnectionMode left, VpnLinkConnectionMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VpnLinkConnectionMode"/>. </summary>
        public static implicit operator VpnLinkConnectionMode(string value) => new VpnLinkConnectionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnLinkConnectionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnLinkConnectionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
