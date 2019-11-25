using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace NationalParks.Models
{
  // Model for parks data. These classes can be obtained by either using 
  // the Visual Studio editor (right-click -> Paste Special -> Paste Json as Classes)
  // or sites such as JsonToCSHarp
  public class Park
  {
    public string states { get; set; }
    public string latLong { get; set; }
    public string description { get; set; }
    public string designation { get; set; }
    [Key]
    public string parkCode { get; set; }
    
    public string id { get; set; }
    public string directionsInfo { get; set; }
    public string directionsUrl { get; set; }
    public string fullName { get; set; }
    public string url { get; set; }
    public string weatherInfo { get; set; }
    public string name { get; set; }
  }

  public class Parks
  {
    public string total { get; set; }
    public List<Park> data { get; set; }
    public string limit { get; set; }
    public string start { get; set; }
  }

    public class Campsites
    {
        [ForeignKey("Datum")]

        public string id { get; set; }
        public Datum Datum { get; set; }
        public string other { get; set; }
      
        public string group { get; set; }
        public string horse { get; set; }
        public string totalsites { get; set; }
        public string tentonly { get; set; }
        public string electricalhookups { get; set; }
        public string rvonly { get; set; }
        public string walkboatto { get; set; }
    }

    public class Amenities
    {
        [ForeignKey("Datum")]

        public string id { get; set; }
        public Datum Datum { get; set; }
        public string trashrecyclingcollection { get; set; }
        
        public string internetconnectivity { get; set; }
        
        public string cellphonereception { get; set; }
        public string laundry { get; set; }
        public string amphitheater { get; set; }
        public string dumpstation { get; set; }
        public string campstore { get; set; }
        public string stafforvolunteerhostonsite { get; set; }
       
        public string iceavailableforsale { get; set; }
        public string firewoodforsale { get; set; }
        public string ampitheater { get; set; }
        public string foodstoragelockers { get; set; }
    }


    public class Accessibility
    {
        [ForeignKey("Datum")]

        public string id { get; set; }
        public Datum Datum { get; set; }
        public string wheelchairaccess { get; set; }
        public string internetinfo { get; set; }
        public string rvallowed { get; set; }
      
        public string cellphoneinfo { get; set; }
        public string firestovepolicy { get; set; }
        public string rvmaxlength { get; set; }
        public string additionalinfo { get; set; }
        public string trailermaxlength { get; set; }
        public string adainfo { get; set; }
        public string rvinfo { get; set; }
        public string trailerallowed { get; set; }

    }

    
    public class Datum
    {
        public string regulationsurl { get; set; }
        public string weatheroverview { get; set; }
        public Campsites campsites { get; set; }
        public Accessibility accessibility { get; set; }
        public Amenities Amenities { get; set; }
        public string directionsoverview { get; set; }
        public string reservationsurl { get; set; }
        public string directionsUrl { get; set; }
        public string reservationssitesfirstcome { get; set; }
        public string name { get; set; }
        public string regulationsoverview { get; set; }
        public string latLong { get; set; }
        public string description { get; set; }
        public string reservationssitesreservable { get; set; }
       
        public string parkCode { get; set; }
        [Key]
        public string id { get; set; }
        public string reservationsdescription { get; set; }
    }

    public class RootObject
    {
        public string total { get; set; }
        public List<Datum> data { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
    }

    public class master
    {
       
        public Datum data { get; set; }
        public Campsites campsites { get; set; }
        public Accessibility accessibility { get; set; }
        public Amenities Amenities { get; set; }
    }

    

}
