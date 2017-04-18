﻿using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Report
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MeterReportResponse : Response
    {
        public MeterReportResponse()
        {
            ReportList = new List<MeterReport>();
        }

        /// <summary>
        /// report UTC start date.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// report start interval.
        /// </summary>
        [JsonProperty(PropertyName = "startInterval")]
        public int StartInterval { get; set; }

        /// <summary>
        /// report UTC end date.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// report end interval.
        /// </summary>
        [JsonProperty(PropertyName = "endInterval")]
        public int EndInterval { get; set; }

        /// <summary>
        /// CSV list of meter types from the request.
        /// </summary>
        [JsonProperty(PropertyName = "meters")]
        public string Meters { get; set; }

        /// <summary>
        /// A list of thermostat meter reports.
        /// </summary>
        [JsonProperty(PropertyName = "reportList")]
        public IList<MeterReport> ReportList { get; set; }
    }
}
