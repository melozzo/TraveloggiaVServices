//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraveloggiaREST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int RatingRecordID { get; set; }
        public int SiteID { get; set; }
        public Nullable<int> MapID { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime Date { get; set; }
        public int RatingValue { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string DeviceID { get; set; }
    }
}
