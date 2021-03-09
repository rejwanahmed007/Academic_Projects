using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    class TrainInfo
    {
        internal TrainInfo(int trainID,string trainNo,string trainName,string offDay,string departureStation,string departureTime,string arrivalStation,string arrivalTime,string routeType,int capacity,int bogey,int standard,int pricePerStandard,int economy,int pricePerEconomy,int firstClass,int  pricePerFirstClass,string bogeyInfo)
        {
            this.TrainID = trainID;
            this.TrainNo = trainNo;
            this.TrainName = trainName;
            this.OffDay = offDay;
            this.DepartureStation = departureStation;
            this.DepartureTime = departureTime;
            this.ArrivalStation = arrivalStation;
            this.ArrivalTime = arrivalTime;
            this.RouteType = routeType;
            this.Capacity = capacity;
            this.Bogey = bogey;
            this.Standard = standard;
            this.PricePerStandard = pricePerStandard;
           // this.StandardBogey = standardBogey;
            this.Economy = economy;
            this.PricePerEconomy = pricePerEconomy;
            //this.EconomyBogey = economyBogey;
            this.FirstClass = firstClass;
            this.PricePerFirstClass = pricePerFirstClass;
            //this.FirstClassBogey = firstClassBogey;
            this.BogeyInfo = bogeyInfo;
        }
        internal int TrainID { set; get; }
        internal string TrainNo { set; get; }
        internal string TrainName { set; get; }
        internal string OffDay { set; get; }
        internal string DepartureStation { set; get; }
        internal string DepartureTime { set; get; }
        internal string ArrivalStation { set; get; }
        internal string ArrivalTime { set; get; }
        internal string RouteType { set; get; }
        internal int Capacity { set; get; }
        internal int Bogey { set; get; }
        internal int Standard { set; get; }
        internal int PricePerStandard { set; get; }
        //internal int StandardBogey { set; get; }
        internal int Economy { set; get; }
        internal int PricePerEconomy { set; get; }
       // internal int EconomyBogey { set; get; }
        internal int FirstClass { set; get; }
        internal int PricePerFirstClass { set; get; }
        //internal int FirstClassBogey { set; get; }
        internal string BogeyInfo { set; get; }


    }
}
