class EmployeeEntity extends Entity
{
	private int salary;
	private String designation;
	
	public EmployeeEntity(int employeeID,String employeeName,String pw,String type,String mail,String mobile,int stipend,String position)
	{
		super(employeeID,employeeName,pw,type,mail,mobile);
		this.salary=stipend;
		this.designation=position;
		
	}
	public void setSalary(int stipend){this.salary=stipend;}
	public void setDesignation(String position){this.designation=position;}
	public int getSalary(){return salary;}
	public String getDesignation(){return designation;}
	public void printUserInfo()
	{
		System.out.println("------Welcome to "+userName+"------");
		System.out.println("Employee ID : "+userID);
		System.out.println("password : "+password);
		System.out.println("Designation : "+designation);
		System.out.println("Monthly Salary : "+salary);
		System.out.println("Email : "+email);
		System.out.println("Mobile Number : "+mobileNumber);
		System.out.println("----------------------------------");
	}

}