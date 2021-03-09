interface EntityInterface
{
	public void setUserID(int id);
	public void setUserName(String name);
	public void setPassword(String pw);
	public void setUserType(String type);
	public void setEmail(String mail);
	public void setMobileNumber(String mobile);
	public int getUserID();
	public String getUserName();
	public String getPassword();
	public String getUserType();
	public String getEmail();
	public String getMobileNumber();
	
	public void printUserInfo();
}