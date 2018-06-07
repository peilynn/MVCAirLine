using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAirLine.Models
{
    public class  GoTrip
    {
        public string TripKey { get; set; }
        public object RPH { get; set; }
        public int segno { get; set; }
        public string AirLine { get; set; }
        public string OPAirLine { get; set; }
        public object PlaneNO { get; set; }
        public string PlaneDate { get; set; }
        public string PlaneTime { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartCity { get; set; }
        public string ArrivalCity { get; set; }
        public string Cabin { get; set; }
        public string RBD { get; set; }
        public int SeatNum { get; set; }
        public string flightNumber { get; set; }
        public object OPflightNumber { get; set; }
        public object BaggageInfo { get; set; }
        public string equipment { get; set; }
        public bool eTicket { get; set; }
        public int flyTime { get; set; }
        public int StopAirPortCount { get; set; }
        public object StopAirportList { get; set; }
        public List<object> StopAirportForSetList { get; set; }
        public string ArrivalTerminal { get; set; }
        public string DepartTerminal { get; set; }

    }

    public class BackTrip
    {
        public string TripKey { get; set; }
        public object RPH { get; set; }
        public int segno { get; set; }
        public string AirLine { get; set; }
        public string OPAirLine { get; set; }
        public object PlaneNO { get; set; }
        public string PlaneDate { get; set; }
        public string PlaneTime { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartCity { get; set; }
        public string ArrivalCity { get; set; }
        public string Cabin { get; set; }
        public string RBD { get; set; }
        public int SeatNum { get; set; }
        public string flightNumber { get; set; }
        public object OPflightNumber { get; set; }
        public object BaggageInfo { get; set; }
        public string equipment { get; set; }
        public bool eTicket { get; set; }
        public int flyTime { get; set; }
        public int StopAirPortCount { get; set; }
        public object StopAirportList { get; set; }
        public List<object> StopAirportForSetList { get; set; }
        public string ArrivalTerminal { get; set; }
        public string DepartTerminal { get; set; }
    }

    public class BagageList
    {
        public int SegNum { get; set; }
        public string SegInfo { get; set; }
        public string FlyInfo { get; set; }
        public string BagInfo { get; set; }
        public string AdultBagInfo { get; set; }
        public object ChildBagInfo { get; set; }
        public object InfantBagInfo { get; set; }
        public List<object> SpecialMemberBaggageInfoList { get; set; }
    }

    public class  Trip
    {
        public string URL { get; set; }
        public string AirLine { get; set; }
        public List<GoTrip> GoTrip { get; set; }
        public List<BackTrip> BackTrip { get; set; }
        public string GoTotalTime { get; set; }
        public string BackTotalTime { get; set; }
        public string BackDepartCity { get; set; }
        public string BackArrivalCity { get; set; }
        public int TransferG { get; set; }
        public int TransferB { get; set; }
        public object TransferGLoc { get; set; }
        public object TransferBLoc { get; set; }
        public string PseudoCityCode { get; set; }
        public bool isBookingAndTicketingNow { get; set; }
        public string RoundTrip { get; set; }
        public int AdultPrice { get; set; }
        public int AdultTax { get; set; }
        public int CNNPrice { get; set; }
        public int CNNTax { get; set; }
        public int InfPrice { get; set; }
        public int InfTax { get; set; }
        public bool PrivateFare { get; set; }
        public int Totalfare { get; set; }
        public List<BagageList> BagageList { get; set; }
    }

    public class RootObject
    {
        public int State { get; set; }
        public string ErrorMsg { get; set; }
        public List<Trip> Trips { get; set; }
    }



}