// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Teams channel account detailing user Azure Active Directory details.
    /// </summary>
    public partial class TeamsChannelAccount : ChannelAccount
    {
        /// <summary>
        /// Initializes a new instance of the TeamsChannelAccount class.
        /// </summary>
        public TeamsChannelAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamsChannelAccount class.
        /// </summary>
        /// <param name="id">Channel id for the user or bot on this channel
        /// (Example: joe@smith.com, or @joesmith or 123456)</param>
        /// <param name="name">Display friendly name</param>
        /// <param name="aadObjectId">Unique Azure Active Directory object
        /// Id.</param>
        /// <param name="givenName">Given name part of the user name.</param>
        /// <param name="surname">Surname part of the user name.</param>
        /// <param name="email">Email Id of the user.</param>
        /// <param name="userPrincipalName">Unique user principal name</param>
        public TeamsChannelAccount(string id = default(string), string name = default(string), string aadObjectId = default(string), string givenName = default(string), string surname = default(string), string email = default(string), string userPrincipalName = default(string))
            : base(id, name)
        {
            AadObjectId = aadObjectId;
            GivenName = givenName;
            Surname = surname;
            Email = email;
            UserPrincipalName = userPrincipalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique Azure Active Directory object Id.
        /// </summary>
        [JsonProperty(PropertyName = "aadObjectId")]
        public string AadObjectId { get; set; }

        /// <summary>
        /// Gets or sets given name part of the user name.
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets surname part of the user name.
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets email Id of the user.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets unique user principal name
        /// </summary>
        [JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

    }
}
