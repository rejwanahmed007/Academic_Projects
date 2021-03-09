import java.sql.*;//Connection;DriverManager;ResultSet;SQLException;Statement;
import java.lang.*;//Exception;
class DatabaseAccess
{
    Connection conn;
    String JDBC_DRIVER;
    String DB_URL;
    Statement stmt;
    String USER;
    String PASS;
    ResultSet rs;
    public DatabaseAccess()
	{
        JDBC_DRIVER = "com.mysql.jdbc.Driver";
        DB_URL = "jdbc:mysql://localhost:3306/snowflake";
        USER = "root";
        PASS = "";
	    
	/*JDBC_DRIVER = "oracle.jdbc.driver.OracleDriver";
        DB_URL = "jdbc:oracle:thin:@localhost:1521:xe";
        USER = "scott";
        PASS = "tiger";*/
        try
		{
            Class.forName(JDBC_DRIVER);//loading driver;
            System.out.println("Connecting to database...");
            conn = DriverManager.getConnection(DB_URL,USER,PASS);
			System.out.println("Connection Established");
        }
        catch(Exception ex)
		{
			System.out.println("Problem to connect Database");
            ex.printStackTrace();
        }
    }
    public void close()
	{
        try
		{
			
		    rs.close();stmt.close();conn.close();
		}
		catch(Exception ex){ex.printStackTrace();}
        
    }
    public ResultSet getData(String query) 
	{
        try
		{
            stmt = conn.createStatement();
			System.out.println("Statement created");
            rs= stmt.executeQuery(query);
			System.out.println(query);
            System.out.println("Results are stored");
        }
        catch(Exception ex)
		{
            System.out.println("Database Read Error !");
            ex.printStackTrace();
        }
        return rs;
    }
    public int updateDatabase(String sql)
	{
        int numOfRowsUpdated=0;
        try
		{
            stmt = conn.createStatement();
			System.out.println("Statement created");
            numOfRowsUpdated=stmt.executeUpdate(sql);
			System.out.println(sql);
            System.out.println(numOfRowsUpdated+" row(s) updated");
        }
        catch(Exception ex)
		{
            ex.printStackTrace();
        }
        return numOfRowsUpdated;
    }
}