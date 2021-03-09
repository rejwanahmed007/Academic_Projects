import java.util.*; //ArrayList
import java.awt.*;
import java.awt.event.*;
import java.sql.*;////Connection;DriverManager;ResultSet;SQLException;Statement;
import java.lang.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)

class AddEmployee extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private String designation[],option;
	private DatabaseAccess da;
	private int maxID;
	
	private TextField passwordTextField,userIDTextField,userNameTextField,mobileTextField,emailTextField,salaryTextField;
	private Label passwordLabel,addEmployeeTitleLabel,userIDLabel,userNameLabel,mobileLabel,emailLabel,designationLabel,salaryLabel;
	private JComboBox optionCombo,designationCombo;
	private Button refreshButton,addButton,backButton,goButton,generateID;
	
	public AddEmployee(EntityInterface en,Register r,JComboBox op)
	{
		super("Add Employee");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		da=new DatabaseAccess();
		
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,15);
		add(optionCombo);
		
		
		generateID=new Button("Generate User ID & Password");
		generateID.setBounds(900,200,250,30);
		generateID.addActionListener(this);
		add(generateID);
		
		addEmployeeTitleLabel=new Label("Add Employee");
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
		
		 userIDTextField=new TextField();
			userIDTextField.setBounds(550,200,300,30);
			userIDTextField.setEnabled(false);
			userIDTextField.setFont(titleFont);
			add(userIDTextField);
		
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
			
			designation=new String[]{"Customer Manager","Manager"};
			
			designationCombo=new JComboBox(designation);
			designationCombo.setBounds(550,400,300,30);
			designationCombo.setFont(titleFont);
			designationCombo.addActionListener(this);
			add(designationCombo);
			
			salaryLabel=new Label("Salary");
			salaryLabel.setBounds(350,450,200,30);
			salaryLabel.setFont(titleFont);
			add(salaryLabel);
			
			salaryTextField=new TextField();
			salaryTextField.setBounds(550,450,300,30);
			salaryTextField.setFont(titleFont);
			add(salaryTextField);
			
			passwordLabel=new Label("Password");
			passwordLabel.setBounds(350,500,200,30);
			passwordLabel.setFont(titleFont);
			add(passwordLabel);
			
			passwordTextField=new TextField();
			passwordTextField.setBounds(550,500,300,30);
			passwordTextField.setEnabled(false);
			passwordTextField.setFont(titleFont);
			add(passwordTextField);
			
			refreshButton=new Button("Refresh");
			refreshButton.setBounds(420,600,80,30);
			refreshButton.setFont(titleFont);
			refreshButton.addActionListener(this);
			add(refreshButton);
			
			addButton=new Button("Add");
			addButton.setBounds(540,600,200,30);
			addButton.setFont(titleFont);
			addButton.addActionListener(this);
			add(addButton);
		
		
			
			
		
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
	
	public void actionPerformed(ActionEvent e)
	{
		String st=e.getActionCommand();
		if(st.equals("Generate User ID & Password"))
		{
			ResultSet rs=null;
			String query3="SELECT MAX(userID) maxID FROM logininfo";
			try
			{
				rs=da.getData(query3);
				
				while(rs.next())//check row by row
					{
						maxID=rs.getInt("maxID");
					}
				maxID=maxID+1;
			    userIDTextField.setText(Integer.toString(maxID));
				userIDTextField.setEditable(false);
				userIDTextField.setEnabled(false);
				passwordTextField.setText(Integer.toString(maxID));
				passwordTextField.setEditable(false);
				passwordTextField.setEnabled(false);
			}
			catch(Exception ex){ex.printStackTrace();}
			
		}
		else if(st.equals("Add"))
		{
			String userType=designationCombo.getSelectedItem().toString();
			
			
			try
		    {
			int userID=userIDTextField.getText().length();
			int password=passwordTextField.getText().length();
			int userName=userNameTextField.getText().length();
			int email=emailTextField.getText().length();
			int mobile=mobileTextField.getText().length();
			int salary=salaryTextField.getText().length();
			int userTypeLength=userType.length();
			String query1="insert into logininfo values("+Integer.parseInt(userIDTextField.getText())+",'"+passwordTextField.getText()+"','"+userType+"')";
		    String query2="insert into employeeinfo values("+Integer.parseInt(userIDTextField.getText())+",'"+userNameTextField.getText()+"','"+userType+"',"+Integer.parseInt(salaryTextField.getText())+",'"+mobileTextField.getText()+"','"+emailTextField.getText()+"')";	
			
			if((userID!=0) && (password!=0) && (userName!=0) && (email!=0) && (mobile!=0) && (salary!=0) && (userTypeLength!=0))
			{
				if(mobile>=1 && mobile<=11)
				{
					da.updateDatabase(query1);
				    da.updateDatabase(query2);
				
			        System.out.println("Database Updated");
				    
			        JOptionPane.showMessageDialog(this,"Account Created Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
			        this.setVisible(false);
			        register.addEmployee=new AddEmployee(entity,register,optionCombo);
			        register.addEmployee.setVisible(true);
				}
				else
				{
					JOptionPane.showMessageDialog(this,"Mobile number must be within 11 digits","Warning",2);
				    this.mobileTextField.setText("");
				}
				
				
			}
			else if((userID==0) || (password==0) || (userName==0) || (email==0) || (mobile==0) || (salary==0) || (userTypeLength==0))
			{
				JOptionPane.showMessageDialog(this,"Missing Information,Try Again","Warning",2);
				
			}
			
			}//try ends here
		    catch(Exception ex)
			{
				
				ex.printStackTrace();
			}
		    
		
			//need to work on that;
		}
		else if(st.equals("Back"))
		{
			register.homeWindow=new HomeWindow(entity,register);
			register.homeWindow.setVisible(true);
			this.setVisible(false);
		}
		
		else if(st.equals("Refresh"))
		{
			this.setVisible(false);
			register.addEmployee=new AddEmployee(entity,register,optionCombo);
			register.addEmployee.setVisible(true);
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