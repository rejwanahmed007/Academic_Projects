class SoldTicket
{
	private int soldTicketID,movieID,showTimeID,customerID,employeeID,seat;
	
	public SoldTicket(int soldTicketID,int movieID,int showTimeID,int customerID,int employeeID,int seat)
	{
		this.soldTicketID=soldTicketID;
		this.movieID=movieID;
		this.showTimeID=showTimeID;
		this.customerID=customerID;
		this.employeeID=employeeID;
		this.seat=seat;
	}
	public void setSoldTicketID(int soldTicketID){this.soldTicketID=soldTicketID;}
	public void setMovieID(int movieID){this.movieID=movieID;}
	public void setShowTimeID(int showTimeID){this.showTimeID=showTimeID;}
	public void setCustomerID(int customerID){this.customerID=customerID;}
	public void setEmployeeID(int employeeID){this.employeeID=employeeID;}
	public void setSeat(int seat){this.seat=seat;}
	public int getSoldTicketID(){return this.soldTicketID;}
	public int getMovieID(){return this.movieID;}
	public int getShowTimeID(){return this.showTimeID;}
	public int getCustomerID(){return this.customerID;}
	public int getEmployeeID(){return this.employeeID;}
	public int getSeat(){return this.seat;}
}