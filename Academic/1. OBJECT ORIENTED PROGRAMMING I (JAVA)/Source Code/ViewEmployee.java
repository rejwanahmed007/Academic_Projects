import java.util.*; //ArrayList
import java.awt.*;
import java.awt.event.*;
import java.sql.*;////Connection;DriverManager;ResultSet;SQLException;Statement;
import java.lang.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)

class ViewEmployee extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private String employeeList[],employeeName,designation,mobileNumber,email,option;
	private DatabaseAccess da;
	private int numberOfEmployee,employeeID,salary;
	
	
	private TextField designationTextField,userIDTextField,userNameTextField,mobileTextField,emailTextField,salaryTextField;
	private Label addEmployeeTitleLabel,userIDLabel,userNameLabel,mobileLabel,emailLabel,designationLabel,salaryLabel;
	private JComboBox optionCombo,userIDCombo;
	private Button refreshButton,deleteButton,backButton,goButton,loadButton,updateButton;
	
	public ViewEmployee(EntityInterface en,Register r,JComboBox op)
	{
		super("View Employee Info");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		da=new DatabaseAccess();
		
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,15);
		add(optionCombo);
		
		loadButton=new Button("Load Info");
		loadButton.setBounds(900,200,250,30);
		loadButton.addActionListener(this);
		add(loadButton);
		
		addEmployeeTitleLabel=new Label("View Employee Info");
		addEmployeeTitleLabel.setBounds(450,75,400,40);
		addEmployeeTitleLabel.setFont(titleFont1);
		add(addEmployeeTitleLabel);
		
		backButton=new Button("Back"); 
		backButton.setBounds(100,100,100,30);
		backButton.setFont(titleFont);
		backButton.addActionListener(this);
		add(backButton);
		
		goButton=new Button("Go");
		goButton.setBounds(1150,100,50,30);
		goButton.setFont(titleFont);
		goButton.addActionListener(this);
		add(goButton);
		
		userIDLabel=new Label("Employee/User ID");
		userIDLabel.setBounds(350,200,200,30);
		userIDLabel.setFont(titleFont);
		add(userIDLabel);
		
		getEmployeeList();
		
		userIDCombo=new JComboBox(employeeList);
			userIDCombo.setBounds(550,200,300,30);
			userIDCombo.setFont(titleFont);
			userIDCombo.addActionListener(this);
			add(userIDCombo);
			
			userNameLabel=new Label("Employee Name");
			userNameLabel.setBounds(350,250,200,30);
			userNameLabel.setFont(titleFont);
			add(userNameLabel);
			
		userNameTextField=new TextField();
			userNameTextField.setBounds(550,250,300,30);
			userNameTextField.setFont(titleFont);
			add(userNameTextField);	
			
		mobileLabel=new Label("Mobile Number");
			mobileLabel.setBounds(350,300,200,30);
			mobileLabel.setFont(titleFont);
			add(mobileLabel);
			
		mobileTextField=new TextField();
			mobileTextField.setBounds(550,300,300,30);
			mobileTextField.setFont(titleFont);
			add(mobileTextField);	
			
		emailLabel=new Label("Email Address");
			emailLabel.setBounds(350,350,200,30);
			emailLabel.setFont(titleFont);
			add(emailLabel);
         
		 emailTextField=new TextField();
			emailTextField.setBounds(550,350,300,30);
			emailTextField.setFont(titleFont);
			add(emailTextField);
			
		
		designationLabel=new Label("Designation");
			designationLabel.setBounds(350,400,200,30);
			designationLabel.setFont(titleFont);
			add(designationLabel);
			
			
			
			designationTextField=new TextField();
			designationTextField.setBounds(550,400,300,30);
			designationTextField.setFont(titleFont);
			designationTextField.addActionListener(this);
			add(designationTextField);
			
			salaryLabel=new Label("Salary");
			salaryLabel.setBounds(350,450,200,30);
			salaryLabel.setFont(titleFont);
			add(salaryLabel);
			
			salaryTextField=new TextField();
			salaryTextField.setBounds(550,450,300,30);
			salaryTextField.setFont(titleFont);
			add(salaryTextField);
			
			
			refreshButton=new Button("Refresh");
			refreshButton.setBounds(420,600,80,30);
			refreshButton.setFont(titleFont);
			refreshButton.addActionListener(this);
			add(refreshButton);
			
			updateButton=new Button("Update Salary");
			updateButton.setBounds(540,600,200,30);
			updateButton.setFont(titleFont);
			updateButton.addActionListener(this);
			add(updateButton);
			
			deleteButton=new Button("Delete Account");
			deleteButton.setBounds(780,600,200,30);
			deleteButton.setFont(titleFont);
			deleteButton.addActionListener(this);
			add(deleteButton);
		
		
			
			
		
		addWindowListener(this);
		setSize(1250,680);
		setLayout(null);	
	}
	public void windowClosing(WindowEvent we)
	{
        System.out.println("Window is closing");
		System.exit(0);
	}
	public void windowActivated(WindowEvent e){}
	public void windowClosed(WindowEvent e){}
	public void windowDeactivated(WindowEvent e){}
	public void windowDeiconified(WindowEvent e){}
	public void windowIconified(WindowEvent e){}
	public void windowOpened(WindowEvent e){}
	
	public void getEmployeeList()
	{
		try
		{
			
			ResultSet rs1=da.getData("select COUNT(employeeID) numberOfEmployee FROM employeeinfo");
			while(rs1.next())
			{
				numberOfEmployee=rs1.getInt("numberOfEmployee");
			}
			employeeList=new String[numberOfEmployee];
			int i=0;
			ResultSet rs2=da.getData("select employeeID FROM employeeinfo");
			while(rs2.next())
			{
				employeeList[i]=Integer.toString(rs2.getInt("employeeID"));
				i++;
			}
		}
		catch(Exception ex){ex.printStackTrace();}
		
	}
	
	
	public void actionPerformed(ActionEvent e)
	{
		String st=e.getActionCommand();
		if(st.equals("Load Info"))
		{
			try
			{
				employeeID=Integer.parseInt(userIDCombo.getSelectedItem().toString());
			   ResultSet rs=da.getData("SELECT * FROM employeeinfo WHERE employeeID="+employeeID);
			   while(rs.next())
			   {
				employeeID=rs.getInt("employeeID");
				employeeName=rs.getString("employeeName");
				designation=rs.getString("designation");
				salary=rs.getInt("salary");
				mobileNumber=rs.getString("mobileNumber");
				email=rs.getString("email");
				
			    }
				userIDCombo.setEnabled(false);
				userNameTextField.setText(employeeName);
				userNameTextField.setEnabled(false);
				mobileTextField.setText(mobileNumber);
				mobileTextField.setEnabled(false);
				emailTextField.setText(email);
				emailTextField.setEnabled(false);
				designationTextField.setText(designation);
				designationTextField.setEnabled(false);
				salaryTextField.setText(Integer.toString(salary));
				//salaryTextField.setEnabled(false);
			}
			catch(Exception ex){ex.printStackTrace();}
			
			
		}
		else if(st.equals("Refresh"))
		{
			this.setVisible(false);
			register.viewEmployee=new ViewEmployee(entity,register,optionCombo);
			register.viewEmployee.setVisible(true);
		}
		else if(st.equals("Back"))
		{
			register.homeWindow=new HomeWindow(entity,register);
			register.homeWindow.setVisible(true);
			this.setVisible(false);
		}
		else if(st.equals("Update Salary"))
		{
			salaryTextField.setEnabled(true);
			salaryTextField.setEditable(true);
			try
			{
				da.updateDatabase("UPDATE `employeeinfo` SET `salary` = '"+Integer.parseInt(salaryTextField.getText())+"' WHERE `employeeinfo`.`employeeID` = "+employeeID);
			    salaryTextField.setEditable(false);
				salaryTextField.setEnabled(false);
				JOptionPane.showMessageDialog(this,"Salary Updated Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
			    this.setVisible(false);
			   register.viewEmployee=new ViewEmployee(entity,register,optionCombo);
			   register.viewEmployee.setVisible(true);
			
			}
			catch(Exception ex){ex.printStackTrace();}
		}
		else if(st.equals("Delete Account"))
		{
			try
			{
				da.updateDatabase("DELETE FROM employeeinfo WHERE employeeinfo.employeeID = "+employeeID);
			    JOptionPane.showMessageDialog(this,"Account Deleted","Message",JOptionPane.INFORMATION_MESSAGE);
			    
			}
			catch(Exception ex){ex.printStackTrace();}
		}
		else if(st.equals("Go"))
		{
			option=optionCombo.getSelectedItem().toString();
			System.out.println(option);
			
			if(option.equals("Select Option-"))
			{
				
				System.out.println("You haven't selected any option,please select any option");
				JOptionPane.showMessageDialog(this,"You haven't selected any option,please select any option first","Warning",2);
			
			}
			else if(option.equals("My Profile"))
			{
				//working progress
				register.myProfile=new MyProfile(entity,register,optionCombo);
				register.myProfile.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("Change Password"))
			{
				register.changePassword=new ChangePassword(entity,register,optionCombo);
				register.changePassword.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("MY Tickets"))
			{
				register.myTickets=new MyTickets(entity,register,optionCombo);
				register.myTickets.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("Sign Out"))
			{
				register.signInWindow=new SignInWindow(register);
				register.signInWindow.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("Sell Ticket(s)"))
			{
				register.sellTicketWindow=new SellTicketWindow(entity,register,optionCombo);
				register.sellTicketWindow.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("Add Employee"))
			{
				register.addEmployee=new AddEmployee(entity,register,optionCombo);
				register.addEmployee.setVisible(true);
				this.setVisible(false);
			}
			else if(option.equals("View Employee Info"))
			{
				register.viewEmployee= new ViewEmployee(entity,register,optionCombo);
				register.viewEmployee.setVisible(true);
				this.setVisible(false);
			}
		}
			
	}
}