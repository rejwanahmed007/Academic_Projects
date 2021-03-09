abstract class Entity implements EntityInterface
{
	protected int userID;
	protected String userName,password,userType,email,mobileNumber;
	
	public Entity(int id,String name,String pw,String type,String mail,String mobile)
	{
		this.userID=id;
		this.userName=name;
		this.password=pw;
		this.userType=type;
		this.email=mail;
		this.mobileNumber=mobile;
	}
	public void setUserID(int id){this.userID=id;}
	public void setUserName(String name){this.userName=name;}
	public void setPassword(String pw){this.password=pw;}
	public void setUserType(String type){this.userType=type;}
	public void setEmail(String mail){this.email=mail;}
	public void setMobileNumber(String mobile){this.mobileNumber=mobile;}
	public int getUserID(){return this.userID;}
	public String getUserName(){return this.userName;}
	public String getPassword(){return this.password;}
	public String getUserType(){return this.userType;}
	public String getEmail(){return this.email;}
	public String getMobileNumber(){return this.mobileNumber;}
	
	public abstract void printUserInfo();

	
}