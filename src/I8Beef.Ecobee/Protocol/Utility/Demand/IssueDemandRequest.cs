﻿using System;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API issue demand request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class IssueDemandRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/demandResponse"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(IssueDemandResponse); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [JsonProperty(PropertyName = "selection", Required = Required.Always)]
        public Selection Selection { get; set; }

        /// <summary>
        /// The type of request. Always "create".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get; set; }

        /// <summary>
        /// The demand response object to create.
        /// </summary>
        [JsonProperty(PropertyName = "demandResponse", Required = Required.Always)]
        public DemandResponse DemandResponse { get; set; }
    }
}
