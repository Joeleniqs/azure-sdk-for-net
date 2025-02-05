// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Address prefix item. </summary>
    public partial class AddressPrefixItem
    {
        /// <summary> Initializes a new instance of AddressPrefixItem. </summary>
        public AddressPrefixItem()
        {
        }

        /// <summary> Initializes a new instance of AddressPrefixItem. </summary>
        /// <param name="addressPrefix"> Address prefix. </param>
        /// <param name="addressPrefixType"> Address prefix type. </param>
        internal AddressPrefixItem(string addressPrefix, AddressPrefixType? addressPrefixType)
        {
            AddressPrefix = addressPrefix;
            AddressPrefixType = addressPrefixType;
        }

        /// <summary> Address prefix. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> Address prefix type. </summary>
        public AddressPrefixType? AddressPrefixType { get; set; }
    }
}
