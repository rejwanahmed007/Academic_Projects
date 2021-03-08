class CustomerEntity extends Entity
{
	
	public CustomerEntity(int customerID,String customerName,String pw,String type,String mail,String mobile)
	{
		super(customerID,customerName,pw,type,mail,mobile);
		
	}
	public void printUserInfo()
	{
		System.out.println("------Welcome to "+userName+"------");
		System.out.println("Customer ID : "+userID);
		System.out.println("password : "+password);
		System.out.println("Email : "+email);
		System.out.println("Mobile Number : "+mobileNumber);
		System.out.println("----------------------------------");
	}
}