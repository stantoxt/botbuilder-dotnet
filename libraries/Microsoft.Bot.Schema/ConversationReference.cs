﻿// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object relating to a particular point in a conversation
    /// </summary>
    public partial class ConversationReference
    {
        /// <summary>
        /// Initializes a new instance of the ConversationReference class.
        /// </summary>
        public ConversationReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConversationReference class.
        /// </summary>
        /// <param name="activityId">(Optional) ID of the activity to refer
        /// to</param>
        /// <param name="user">(Optional) User participating in this
        /// conversation</param>
        /// <param name="bot">Bot participating in this conversation</param>
        /// <param name="conversation">Conversation reference</param>
        /// <param name="channelId">Channel ID</param>
        /// <param name="serviceUrl">Service endpoint where operations
        /// concerning the referenced conversation may be performed</param>
        public ConversationReference(string activityId = default(string), ChannelAccount user = default(ChannelAccount), ChannelAccount bot = default(ChannelAccount), ConversationAccount conversation = default(ConversationAccount), string channelId = default(string), string serviceUrl = default(string))
        {
            ActivityId = activityId;
            User = user;
            Bot = bot;
            Conversation = conversation;
            ChannelId = channelId;
            ServiceUrl = serviceUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets (Optional) ID of the activity to refer to
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or sets (Optional) User participating in this conversation
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public ChannelAccount User { get; set; }

        /// <summary>
        /// Gets or sets bot participating in this conversation
        /// </summary>
        [JsonProperty(PropertyName = "bot")]
        public ChannelAccount Bot { get; set; }

        /// <summary>
        /// Gets or sets conversation reference
        /// </summary>
        [JsonProperty(PropertyName = "conversation")]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or sets channel ID
        /// </summary>
        [JsonProperty(PropertyName = "channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets service endpoint where operations concerning the
        /// referenced conversation may be performed
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }    
       
    }
}