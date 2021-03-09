import java.util.*; //ArrayList
import java.awt.*;
import java.awt.event.*;
import java.sql.*;////Connection;DriverManager;ResultSet;SQLException;Statement;
import java.lang.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)


class MyProfile extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private DatabaseAccess da;
	
	private int userID,salary;
	private String userName,mobile,email,designation,option;
	
	private TextField userIDTextField,userNameTextField,mobileTextField,emailTextField,designationTextField,salaryTextField;
	private Label myProfileTitleLabel,userIDLabel,userNameLabel,mobileLabel,emailLabel,designationLabel,salaryLabel;
	private Button backButton,goButton,editProfileButton,cancelButton,updateButton;
	private JComboBox optionCombo;
	
	public MyProfile(EntityInterface en,Register r,JComboBox op)
	{
		super("My Profile");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);//common for all user
		add(optionCombo);
		
		goButton=new Button("Go");//common for all user
		goButton.setBounds(1150,100,50,30);//common for all user
		goButton.setFont(titleFont);
		goButton.addActionListener(this);
		add(goButton);
		
	    myProfileTitleLabel=new Label("MY Profile");//common for all user
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		myProfileTitleLabel.setBounds(450,100,400,40);
		myProfileTitleLabel.setFont(titleFont1);
		add(myProfileTitleLabel);
		
		backButton=new Button("Back"); //common for all user
		backButton.setBounds(100,100,100,30);
		backButton.setFont(titleFont);
		backButton.addActionListener(this);
		add(backButton);
		
			userID=entity.getUserID();
			userName=entity.getUserName();
			email=entity.getEmail();
			mobile=entity.getMobileNumber();
			
		try
		{
			da=new DatabaseAccess();
			ResultSet rs=da.getData("SELECT designation,salary from employeeinfo WHERE employeeID="+userID);
			while(rs.next())
			{
				designation=rs.getString("designation");
				salary=rs.getInt("salary");
			}
		}
		catch(Exception ex){ex.printStackTrace();}
		if(entity.getUserType().equals("Customer"))
		{
		
			
			userIDLabel=new Label("Customer/User ID");
			userIDLabel.setBounds(350,200,200,30);
			userIDLabel.setFont(titleFont);
			add(userIDLabel);
			
		
			userNameLabel=new Label("Customer Name");
			userNameLabel.setBounds(350,250,200,30);
			userNameLabel.setFont(titleFont);
			add(userNameLabel);
			
			editProfileButton=new Button("Edit Your Profile");
			editProfileButton.setBounds(420,550,200,30);
			editProfileButton.setFont(titleFont);
			editProfileButton.addActionListener(this);
			add(editProfileButton);
			
			cancelButton=new Button("Cancel");
			cancelButton.setBounds(420,550,80,30);
			cancelButton.setFont(titleFont);
			cancelButton.addActionListener(this);
			cancelButton.setVisible(false);
			add(cancelButton);
			
			
			updateButton=new Button("Update Profile");
			updateButton.setBounds(540,550,150,30);
			updateButton.setFont(titleFont);
			updateButton.addActionListener(this);
			updateButton.setVisible(false);
			add(updateButton);
		
			
		}
		else
		{
			userIDLabel=new Label("Employee/User ID");
			userIDLabel.setBounds(350,200,200,30);
			userIDLabel.setFont(titleFont);
			add(userIDLabel);
			
			userNameLabel=new Label("Employee Name");
			userNameLabel.setBounds(350,250,200,30);
			userNameLabel.setFont(titleFont);
			add(userNameLabel);
			
			designationLabel=new Label("Designation");
			designationLabel.setBounds(350,400,200,30);
			designationLabel.setFont(titleFont);
			add(designationLabel);
			
			designationTextField=new TextField(designation);
			designationTextField.setBounds(550,400,300,30);
			designationTextField.setFont(titleFont);
			designationTextField.setEditable(false);
			designationTextField.setEnabled(false);
			add(designationTextField);
			
			salaryLabel=new Label("Salary");
			salaryLabel.setBounds(350,450,200,30);
			salaryLabel.setFont(titleFont);
			add(salaryLabel);
			
			salaryTextField=new TextField(Integer.toString(salary));
			salaryTextField.setBounds(550,450,300,30);
			salaryTextField.setFont(titleFont);
			salaryTextField.setEditable(false);
			salaryTextField.setEnabled(false);
			add(salaryTextField);
			
			editProfileButton=new Button("Edit Your Mobile No.");
			editProfileButton.setBounds(400,550,300,30);
			editProfileButton.setFont(titleFont);
			editProfileButton.addActionListener(this);
			add(editProfileButton);
			
			cancelButton=new Button("Cancel");
			cancelButton.setBounds(420,550,80,30);
			cancelButton.setFont(titleFont);
			cancelButton.addActionListener(this);
			cancelButton.setVisible(false);
			add(cancelButton);
			
			
			updateButton=new Button("Update Mobile No.");
			updateButton.setBounds(540,550,200,30);
			updateButton.setFont(titleFont);
			updateButton.addActionListener(this);
			updateButton.setVisible(false);
			add(updateButton);
		}
		
		
		    userIDTextField=new TextField();
			userIDTextField.setBounds(550,200,300,30);
			userIDTextField.setText(Integer.toString(userID));
			userIDTextField.setEditable(false);
			userIDTextField.setFont(titleFont);
			userIDTextField.setEnabled(false);
			add(userIDTextField);
			
		 
		    userNameTextField=new TextField();
			userNameTextField.setBounds(550,250,300,30);
			userNameTextField.setText(userName);
			userNameTextField.setEditable(false);
			userNameTextField.setFont(titleFont);
			userNameTextField.setEnabled(false);
			add(userNameTextField);
			
			mobileLabel=new Label("Mobile Number");
			mobileLabel.setBounds(350,300,200,30);
			mobileLabel.setFont(titleFont);
			add(mobileLabel);
			
			mobileTextField=new TextField();
			mobileTextField.setBounds(550,300,300,30);
			mobileTextField.setText(mobile);
			mobileTextField.setEditable(false);
			mobileTextField.setFont(titleFont);
			mobileTextField.setEnabled(false);
			add(mobileTextField);
			
			emailLabel=new Label("Email Address");
			emailLabel.setBounds(350,350,200,30);
			emailLabel.setFont(titleFont);
			add(emailLabel);
			
			emailTextField=new TextField();
			emailTextField.setBounds(550,350,300,30);
			emailTextField.setText(email);
			emailTextField.setEditable(false);
			emailTextField.setFont(titleFont);
			emailTextField.setEnabled(false);
			add(emailTextField);
		
		    
		
		
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
	
	
	
	
	public void actionPerformed(ActionEvent e)//need to work on 
	{
		String st=e.getActionCommand(); 
		
		if(entity.getUserType().equals("Customer"))
		{
			if(st.equals("Edit Your Profile"))
		{
			userIDTextField.setEnabled(false);
			editProfileButton.setVisible(false);
			userNameTextField.setEditable(true);
			mobileTextField.setEditable(true);
			emailTextField.setEditable(true);
			cancelButton.setVisible(true);
			updateButton.setVisible(true);
			userNameTextField.setEnabled(true);
			mobileTextField.setEnabled(true);
			emailTextField.setEnabled(true);
			userNameTextField.setEditable(true);
			mobileTextField.setEditable(true);
			emailTextField.setEditable(true);
			
			
			
		}
		else if(st.equals("Update Profile"))
		{
			
			
			try
			{
			int editedName=0,editedMobile=0,editedEmail=0;
			
			editedName=userNameTextField.getText().length();
			editedEmail=emailTextField.getText().length();
			editedMobile=mobileTextField.getText().length();
			String query1="UPDATE `customerinfo` SET `customerName` = '"+userNameTextField.getText()+"', `email` = '"+emailTextField.getText()+"', `mobileNumber` = '"+mobileTextField.getText()+"' WHERE `customerinfo`.`customerID` = "+userID;
			
			if((editedName!=0) && (editedMobile!=0) && (editedEmail!=0))
			{
				if(editedMobile>=1 && editedMobile<=11)
				{
					da.updateDatabase(query1);
					System.out.println("Database Updated");
					entity.setUserName(userNameTextField.getText());
					entity.setMobileNumber(mobileTextField.getText());
					entity.setEmail(emailTextField.getText());
					entity.printUserInfo();
				    
					JOptionPane.showMessageDialog(this,"Your Profile Updated Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
			        
					userName=userNameTextField.getText();
					email=emailTextField.getText();
					mobile=mobileTextField.getText();
					
					userNameTextField.setText(userName);
					mobileTextField.setText(mobile);
					emailTextField.setText(email);
					
					userNameTextField.setEditable(false);
			        mobileTextField.setEditable(false);
			        emailTextField.setEditable(false);
			        cancelButton.setVisible(false);
			        updateButton.setVisible(false);
					editProfileButton.setVisible(true);
					userNameTextField.setEnabled(false);
			        mobileTextField.setEnabled(false);
			        emailTextField.setEnabled(false);
					userIDTextField.setEnabled(false);
			        
				}
				else
				{
					JOptionPane.showMessageDialog(this,"Mobile number must be within 11 digits","Warning",2);
				    
				}
				
			}
			else
			{
				JOptionPane.showMessageDialog(this,"Missing Information,Try Again","Warning",2);
				
			}
			
		
			}//try ends here ;
			catch(Exception ex){ex.printStackTrace();}
			


		}
        else if(st.equals("Cancel"))
		{
			userNameTextField.setText(entity.getUserName());
			mobileTextField.setText(entity.getMobileNumber());
			emailTextField.setText(entity.getEmail());
			
			userNameTextField.setEditable(false);
			userNameTextField.setEnabled(false);
			mobileTextField.setEditable(false);
			mobileTextField.setEnabled(false);
			emailTextField.setEditable(false);
			emailTextField.setEnabled(false);
			cancelButton.setVisible(false);
			updateButton.setVisible(false);
			editProfileButton.setVisible(true);
			
		}
		
    
		}//customer if codition ends here;
		else if(entity.getUserType().equals("Manager") || entity.getUserType().equals("Customer Manager"))
		{
			if(st.equals("Edit Your Mobile No."))
			{
				userIDTextField.setEnabled(false);
			    editProfileButton.setVisible(false);
			
			    mobileTextField.setEditable(true);
			    cancelButton.setVisible(true);
			    updateButton.setVisible(true);
			    mobileTextField.setEnabled(true);
			}
			else if(st.equals("Update Mobile No."))
				
			{
				mobileTextField.setEditable(true);
				mobileTextField.setEnabled(true);
				int editedMobile=0;
				try
				{
					editedMobile=mobileTextField.getText().length();
					if(editedMobile>=1 && editedMobile<=11)
					{
						da.updateDatabase("UPDATE `employeeinfo` SET `mobileNumber` = '"+mobileTextField.getText()+"' WHERE `employeeinfo`.`employeeID` = "+userID);
					    System.out.println("Database Updated");
						JOptionPane.showMessageDialog(this,"Your Mobile Number Updated Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
					    entity.setMobileNumber(mobileTextField.getText());
					    entity.printUserInfo();
						mobileTextField.setEditable(false);
						mobileTextField.setEnabled(false);
						userIDTextField.setEnabled(false);
			    		editProfileButton.setVisible(true);
			
			    		cancelButton.setVisible(false);
			    		updateButton.setVisible(false);
			    		
					}
					else
				    {
					  JOptionPane.showMessageDialog(this,"Mobile number must be within 11 digits","Warning",2);
				    
				    }
					
				}
				catch(Exception ex){ex.printStackTrace();}
			}
			else if(st.equals("Cancel"))
			{
				
			mobileTextField.setText(entity.getMobileNumber());
			
			userNameTextField.setEditable(false);
			userNameTextField.setEnabled(false);
			mobileTextField.setEditable(false);
			mobileTextField.setEnabled(false);
			emailTextField.setEditable(false);
			emailTextField.setEnabled(false);
			salaryTextField.setEditable(false);
			salaryTextField.setEnabled(false);
			designationTextField.setEnabled(false);
			designationTextField.setEditable(false);
			cancelButton.setVisible(false);
			updateButton.setVisible(false);
			editProfileButton.setVisible(true);
			}
			
		}
		
		if(st.equals("Back"))
		{
			register.homeWindow=new HomeWindow(entity,register);
			register.homeWindow.setVisible(true);
			register.myProfile.setVisible(false);
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