class HallInfo
{
	private int hallID,capacity;
	private String hallName,hallType;
	
	public HallInfo(int hallID,int capacity,String hallName,String hallType)
	{
		this.hallID=hallID;
		this.capacity=capacity;
		this.hallName=hallName;
		this.hallType=hallType;
	}
	public void setHallID(int hallID){this.hallID=hallID;}
	public void setCapacity(int capacity){this.capacity=capacity;}
	public void setHallName(String hallName){this.hallName=hallName;}
	public void setHallType(String hallType){this.hallType=hallType;}
	public int getHallID(){return this.hallID;}
	public int getCapacity(){return this.capacity;}
	public String getHallName(){return this.hallName;}
	public String getHallType(){return this.hallType;}
	
}