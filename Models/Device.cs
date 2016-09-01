//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REST_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        public int id { get; set; }
        public string referrer { get; set; }
        public Nullable<decimal> windowInnerHeight { get; set; }
        public string windowInnerWidth { get; set; }
        public string documentElementClientHeight { get; set; }
        public string documentElementClientWidth { get; set; }
        public string osName { get; set; }
        public string osVersion { get; set; }
        public string browserName { get; set; }
        public string browserVersion { get; set; }
        public string engineName { get; set; }
        public string engineVersion { get; set; }
        public string deviceModel { get; set; }
        public string deviceType { get; set; }
        public string deviceVendor { get; set; }
        public string Issue { get; set; }
        public string handlesOrientationChange { get; set; }
        public Nullable<System.DateTime> DateRecorded { get; set; }
        public Nullable<int> MemberID { get; set; }
    }
}
