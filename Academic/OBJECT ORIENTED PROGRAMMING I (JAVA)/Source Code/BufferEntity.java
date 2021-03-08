import java.util.*; //ArrayList
import java.sql.*;//ResultSet;SQLException;

class BufferEntity
{
	private ArrayList<EntityInterface> entityArrayList;
	private ArrayList<MovieInfo> movieInfoArrayList;

	public BufferEntity()
	{
		entityArrayList=new ArrayList<EntityInterface>();
		
	}
	
	public void loadMovieInfo()
	{
		try
		{
			movieInfoArrayList=new ArrayList<MovieInfo>();
		    DatabaseAccess da=new DatabaseAccess();
		    ResultSet rs=da.getData("SELECT * FROM movieinfo");
		    int movieID=0;
		    String movieName=null,genre=null,releaseDate=null,runningTime=null,rating=null;
		    MovieInfo movieInfo=null;
		    while(rs.next())
		      {
			   movieID=rs.getInt("movieID");
			   movieName=rs.getString("movieName");
			   genre=rs.getString("genre");
			   releaseDate=rs.getString("releaseDate");
			   runningTime=rs.getString("runningTime");
			   rating=rs.getString("rating");
			
			   movieInfo=new MovieInfo(movieID,movieName,genre,releaseDate,runningTime,rating);
			   addMovieInfo(movieInfo);
		      }
		      da.close();
		}//try ends here;
		catch(Exception ex){ex.printStackTrace();}
	}
	
	public void addMovieInfo(MovieInfo mv)
	{
	    movieInfoArrayList.add(mv);
	}
	public ArrayList<MovieInfo> getMovieInfoArrayList()
	{
	    return this.movieInfoArrayList;
	}
	
	
	
	public void loadEntity(String sql)
	{
		try
		{
			

		DatabaseAccess da=new DatabaseAccess();
		ResultSet rs=da.getData(sql);
		int userID=0,salary=0;
		String userName=null,password=null,userType=null,email=null,mobileNumber=null,designation=null;
		boolean customerObjectCreation=true;
		boolean employeeObjectCreation=true;
		CustomerEntity customer=null;
		EmployeeEntity employee=null;
		
		while(rs.next())
		{
			userID=rs.getInt("userID");
			password=rs.getString("password");
			userType=rs.getString("userType");
			if(userType.equals("Customer") && customerObjectCreation==true)
			{
				
				String query1="SELECT userID,customerName,password,userType,email,mobileNumber FROM logininfo,customerinfo where logininfo.userID=customerinfo.customerID";
				ResultSet customerinfo=da.getData(query1);
				while(customerinfo.next())
				{
					userID=customerinfo.getInt("userID");
					userName=customerinfo.getString("customerName");
					password=customerinfo.getString("password");
					userType=customerinfo.getString("userType");
					email=customerinfo.getString("email");
					mobileNumber=customerinfo.getString("mobileNumber");
					
					customer=new CustomerEntity(userID,userName,password,userType,email,mobileNumber);
					addEntity(customer);
					
				}
				
				
				customerObjectCreation=false;
			}
			else if((userType.equals("Customer Manager") || userType.equals("Manager")) && employeeObjectCreation==true)
			{
				String query2="SELECT userID,employeeName,password,userType,designation,salary,email,mobileNumber FROM logininfo,employeeinfo where logininfo.userID=employeeinfo.employeeID";
				ResultSet employeeinfo=da.getData(query2);
				while(employeeinfo.next())
				{
					userID=employeeinfo.getInt("userID");
					userName=employeeinfo.getString("employeeName");
					password=employeeinfo.getString("password");
					userType=employeeinfo.getString("userType");
					email=employeeinfo.getString("email");
					mobileNumber=employeeinfo.getString("mobileNumber");
					designation=employeeinfo.getString("designation");
					salary=employeeinfo.getInt("salary");
					
					employee=new EmployeeEntity(userID,userName,password,userType,email,mobileNumber,salary,designation);
					addEntity(employee);
				}
				employeeObjectCreation=false;
			}
		}
		da.close();
		
		}//try ends here
		catch(Exception ex){ex.printStackTrace();}
	}
	
	public EntityInterface checkEntityAuthentication(int id,String pw)
	{
		EntityInterface entityInterface=null;
		for(int i=0;i<entityArrayList.size();i++)
		{
			if(entityArrayList.get(i)!=null)
			{
				if(entityArrayList.get(i).getUserID()==id && entityArrayList.get(i).getPassword().equals(pw))
				{
					entityInterface=entityArrayList.get(i);
					System.out.println("Valid user");
					entityArrayList.get(i).printUserInfo();
					System.out.println("Total User of this system : "+entityArrayList.size());	
				}
			}
		}
		return entityInterface;
	}
	
	
	
	
	public void addEntity(EntityInterface en)
	{
	    entityArrayList.add(en);
	}
	public void printEntity()
	{
		for(int i=0;i<entityArrayList.size();i++)
		{
			if(entityArrayList.get(i)!=null)
			entityArrayList.get(i).printUserInfo();
			
		}
        System.out.println("Total User of this system : "+entityArrayList.size());		
	}
}