class ShowTimeInfo
{
	private int showTimeID,movieID,hallID,availableSeat;
	private String showDate,showTime;
	
	public ShowTimeInfo(int showTimeID,int movieID,int hallID,int availableSeat,String showDate,String showTime)
	{
		this.showTimeID=showTimeID;
		this.movieID=movieID;
		this.hallID=hallID;
		this.availableSeat=availableSeat;
		this.showDate=showDate;
		this.showTime=showTime;
	}
	public void setShowTimeID(int showTimeID){this.showTimeID=showTimeID;}
	public void setMovieID(int movieID){this.movieID=movieID;}
	public void setHallID(int hallID){this.hallID=hallID;}
	public void setAvailableSeat(int availableSeat){this.availableSeat=availableSeat;}
	public void setShowDate(String showDate){this.showDate=showDate;}
	public void setshowTime(String showTime){this.showTime=showTime;}
	public int getShowTimeID(){return this.showTimeID;}
	public int getMovieID(){return this.movieID;}
	public int getHallID(){return this.hallID;}
	public int getAvailableSeat(){return this.availableSeat;}
	public String getShowDate(){return this.showDate;}
	public String getshowTime(){return this.showTime;}
}