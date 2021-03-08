import java.awt.*;
import java.sql.*;//Connection;DriverManager;ResultSet;SQLException;Statement;
import java.awt.event.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)
class ChangePassword extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private DatabaseAccess da;
	private ResultSet rs;
	
	
	private String oldPassword,option;
	private Label changePasswordTitleLabel,oldPasswordLabel,newPasswordLabel;
	private TextField oldPasswordTextField,newPasswordTextField;
	private Button backButton,goButton,updatePasswordButton;
	private JComboBox optionCombo;
	
	public ChangePassword(EntityInterface en,Register r,JComboBox op)
	{
		super("Password Change");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		add(optionCombo);
		
		
		changePasswordTitleLabel=new Label("Change Your Password");
		changePasswordTitleLabel.setBounds(450,100,400,40);
		changePasswordTitleLabel.setFont(titleFont1);
		add(changePasswordTitleLabel);
		
		backButton=new Button("Back"); 
		backButton.setBounds(100,100,100,30);
		backButton.setFont(titleFont);
		backButton.addActionListener(this);
		add(backButton);
		
		goButton=new Button("Go");//common for all user
		goButton.setBounds(1150,100,50,30);//common for all user
		goButton.setFont(titleFont);
		goButton.addActionListener(this);
		add(goButton);
		
		oldPasswordLabel=new Label("Old Password");
		oldPasswordLabel.setBounds(350,200,200,30);
	    oldPasswordLabel.setFont(titleFont);
		add(oldPasswordLabel);
		
		oldPasswordTextField=new TextField();
		oldPasswordTextField.setBounds(550,200,300,30);
		oldPasswordTextField.setFont(titleFont);
		oldPasswordTextField.setEchoChar('*');
		add(oldPasswordTextField);
		
		newPasswordLabel=new Label("New Password");
		newPasswordLabel.setBounds(350,250,200,30);
		newPasswordLabel.setFont(titleFont);
		add(newPasswordLabel);
		
		newPasswordTextField=new TextField();
		newPasswordTextField.setBounds(550,250,300,30);
		newPasswordTextField.setFont(titleFont);
		newPasswordTextField.setEchoChar('*');
		add(newPasswordTextField);
		
		updatePasswordButton=new Button("Update Password");
		updatePasswordButton.setBounds(500,320,150,30);
		updatePasswordButton.setFont(titleFont);
		updatePasswordButton.addActionListener(this);
		add(updatePasswordButton);
		
		
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
	
	public void actionPerformed(ActionEvent e)// need to work on that;
	{
		String st=e.getActionCommand(); 
		
		if(st.equals("Update Password"))
		{
			int oldPasswordLength=oldPasswordTextField.getText().length();
			int newPasswordLength=newPasswordTextField.getText().length();
			String query1="SELECT password FROM logininfo WHERE userID="+entity.getUserID();
			String query2="UPDATE logininfo SET password = '"+newPasswordTextField.getText()+"' WHERE logininfo.userID = "+entity.getUserID();
			try
			{
				da=new DatabaseAccess();
			    rs=da.getData(query1); 
			    while(rs.next())
			    {
				oldPassword=rs.getString("password");
			    }
				if(oldPasswordLength!=0 && newPasswordLength!=0)
				{
					if(oldPassword.equals(oldPasswordTextField.getText()))
			        {
				    da.updateDatabase(query2);
				    JOptionPane.showMessageDialog(this,"Password Updated Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
					register.homeWindow=new HomeWindow(entity,register);
				    register.homeWindow.setVisible(true);
					register.changePassword.setVisible(false);
					da.close();
			        }
				    else
				    {
					JOptionPane.showMessageDialog(this,"Old Password Mismatched,try again","Warning",2);
					oldPasswordTextField.setText("");
					newPasswordTextField.setText("");
				    }
				}
				else{JOptionPane.showMessageDialog(this,"You haven't entered any value","Warning",2);}
			    
			}//try ends here;
			catch(Exception ex){ex.printStackTrace();}
			
		}
		else if(st.equals("Back"))
		{
			register.homeWindow=new HomeWindow(entity,register);
			register.homeWindow.setVisible(true);
			register.changePassword.setVisible(false);
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