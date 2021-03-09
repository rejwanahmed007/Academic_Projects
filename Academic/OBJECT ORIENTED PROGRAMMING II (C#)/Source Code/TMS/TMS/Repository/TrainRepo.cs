using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ApplicationLayer;
using TMS.Data;
using TMS.Entity;
using TMS.Framework;

namespace TMS.Repository
{
    internal class TrainRepo
    {

        internal int getAvailableSeat(string from, string to, string date, string time,string trainName,int trainid,string availableSeat)
        {
            int seat = 0;
            try
            {
                string query = "select "+availableSeat+ " from journeytimeinfo,traininfo where journeytimeinfo.trainid=traininfo.trainid  and traininfo.trainid="+trainid+" and traininfo.name='" + trainName+"' and traininfo.departurestation='"+from+"' and traininfo.arrivalstation='"+to+"' and journeydate='"+date+"' and journeytime='"+time+ "' and journeydatetime>SYSDATETIME()";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    seat = Convert.ToInt32(dt.Rows[counter][0].ToString());
                    counter++;
                }
                return seat;
            }
            catch (Exception exception)
            {
                return seat;
            }
        }
        internal int getPricePerSeat(string trainName, int trainid, string price)
        {
            int pricePerSeat = 0;
            try
            {
                string query = "select "+price+" from traininfo where  traininfo.trainid="+trainid+" and traininfo.name='"+trainName+"'";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    pricePerSeat = Convert.ToInt32(dt.Rows[counter][0].ToString());
                    counter++;
                }
                return pricePerSeat;
            }
            catch (Exception exception)
            {
                return pricePerSeat;
            }
        }
        internal List<string> getAvailableTrain(string from, string to, string date,string time)
        {
            var availableTrain = new List<string>();
            try
            {
                string query = "select traininfo.name from journeytimeinfo,traininfo where journeytimeinfo.trainid=traininfo.trainid and traininfo.departurestation='"+from+"' and traininfo.arrivalstation='"+to+"' and journeydate='"+date+"' and journeytime='"+time+ "' and journeydatetime>SYSDATETIME()";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["name"].ToString() != null )
                    {
                        availableTrain.Add(dt.Rows[counter]["name"].ToString());
                        //trainid.Add(Convert.ToInt32(dt.Rows[counter]["trainid"].ToString()));
                    }
                    counter++;
                }
                return availableTrain;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal int GetTrainID(string from, string to, string date, string time,string trainName)
        {
            try
            {
                string query = "select traininfo.trainid from journeytimeinfo,traininfo where journeytimeinfo.trainid=traininfo.trainid and traininfo.departurestation='" + from + "' and traininfo.arrivalstation='" + to + "' and journeydate='" + date + "' and journeytime='" + time + "' and traininfo.name='"+trainName+ "' and journeydatetime>SYSDATETIME()";
                var dt = DataAccess.GetDataTable(query);

                if (dt.Rows[0]["trainid"].ToString() != null)
                {

                    int trainID = Convert.ToInt32(dt.Rows[0]["trainid"].ToString());
                    return trainID;
                }
                else
                    return 0;
                
                
            }
            catch (Exception exception)
            {
                return 0;
            }
        }
        internal List<string> getJourneyTime(string from, string to,string date)
        {
            var journeyTime = new List<string>();
            try
            {
                string query = "select journeytime=convert(char(8),journeytime) from journeytimeinfo,traininfo where journeytimeinfo.trainid=traininfo.trainid and traininfo.departurestation='"+from+"' and traininfo.arrivalstation='"+to+"' and journeydate='"+date+ "' and journeydatetime>SYSDATETIME() group by journeytime";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["journeytime"].ToString() != null)
                    {
                        journeyTime.Add(dt.Rows[counter]["journeytime"].ToString());
                    }
                    counter++;
                }
                return journeyTime;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal List<string> TrainList()
        {
            var trainList = new List<string>();
            try
            {
                string query = "select trainno from traininfo";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["trainno"].ToString() != null)
                    {
                        trainList.Add(dt.Rows[counter]["trainno"].ToString());
                    }
                    counter++;
                }
                return trainList;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal List<string> getJourneyDate(string from,string to)
        {
            var journeyDate = new List<string>();
            try
            {
                string query = "select journeydate=convert(char(10),journeydate) from journeytimeinfo,traininfo where traininfo.trainid=journeytimeinfo.trainid and traininfo.departurestation='" + from+"' and traininfo.arrivalstation='"+to+ "' and journeydatetime>SYSDATETIME()  group by journeydate";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["journeydate"].ToString() != null)
                    {
                        journeyDate.Add(dt.Rows[counter]["journeydate"].ToString());
                    }
                    counter++;
                }
                return journeyDate;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal List<string> getJourneyTo(string from)
        {
            var journeyTo = new List<string>();
            try
            {
                string query = "select arrivalstation from traininfo,journeytimeinfo  where traininfo.trainid=journeytimeinfo.trainid and journeydatetime > SYSDATETIME() and not arrivalstation = '" + from+"' group by arrivalstation";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["arrivalstation"].ToString() != null)
                    {
                        journeyTo.Add(dt.Rows[counter]["arrivalstation"].ToString());
                    }
                    counter++;
                }
                return journeyTo;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal List<string> getJourneyFrom()
        {
            var journeyFrom = new List<string>();
            try
            {
                string query = "select departurestation from traininfo,journeytimeinfo  where traininfo.trainid=journeytimeinfo.trainid and journeydatetime > SYSDATETIME() group by departurestation";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while(counter<dt.Rows.Count)
                {
                    if(dt.Rows[counter]["departurestation"].ToString()!=null)
                    {
                        journeyFrom.Add(dt.Rows[counter]["departurestation"].ToString());
                    }
                    counter++;
                }
                return journeyFrom;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        internal List<TrainInfo> GetAll()
        {
            var trainList = new List<TrainInfo>();
            try
            {
                string query1 = "select * from traininfo;";
                var dt = DataAccess.GetDataTable(query1);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    TrainInfo train = ConvertToTrain(dt.Rows[counter]);
                    trainList.Add(train);
                    counter++;
                }
                return trainList;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        private TrainInfo ConvertToTrain(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            int trainid = Convert.ToInt32(row["trainid"].ToString());
            string trainno = row["trainno"].ToString();
            string name = row["name"].ToString();
            string offday = row["offday"].ToString();
            string departurestation = row["departurestation"].ToString();
            string departuretime = row["departuretime"].ToString();
            string arrivalstation = row["arrivalstation"].ToString();
            string arrivaltime = row["arrivaltime"].ToString();
            string routetype = row["routetype"].ToString();
            int capacity = Convert.ToInt32(row["capacity"].ToString());
            int bogey = Convert.ToInt32(row["bogey"].ToString());
            int standard = Convert.ToInt32(row["standard"].ToString());
            int priceperstandard = Convert.ToInt32(row["priceperstandard"].ToString());
            //int standardbogey = Convert.ToInt32(row["standardbogey"].ToString());
            int economy = Convert.ToInt32(row["economy"].ToString());
            int pricepereconomy = Convert.ToInt32(row["pricepereconomy"].ToString());
            //int economybogey = Convert.ToInt32(row["economybogey"].ToString());
            int firstclass = Convert.ToInt32(row["firstclass"].ToString());
            int priceperfirstclass = Convert.ToInt32(row["priceperfirstclass"].ToString());
            //int firstclassbogey = Convert.ToInt32(row["firstclassbogey"].ToString());
            string bogeyinfo = row["bogeyinfo"].ToString();
            TrainInfo train = new TrainInfo(trainid, trainno, name, offday, departurestation, departuretime, arrivalstation, arrivaltime, routetype, capacity, bogey, standard, priceperstandard, economy, pricepereconomy, firstclass, priceperfirstclass, bogeyinfo);
            return train;
            
        }
    }
}
