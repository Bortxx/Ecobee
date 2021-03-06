﻿using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user add request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserAddRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAddRequest"/> class.
        /// </summary>
        public UserAddRequest()
        {
            Users = new List<HierarchyUser>();
        }

        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/user"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "add".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get { return "add"; } }

        /// <summary>
        /// The list of users to add.
        /// </summary>
        [JsonProperty(PropertyName = "users", Required = Required.Always)]
        public IList<HierarchyUser> Users { get; set; }

        /// <summary>
        /// The privileges to assign to the new users.
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }
    }
}
