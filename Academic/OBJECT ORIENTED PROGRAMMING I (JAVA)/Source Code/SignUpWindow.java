import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import java.lang.*;
import javax.swing.*;//JOptionPane(pop up window)
class SignUpWindow extends Frame implements WindowListener,ActionListener
{
	private DatabaseAccess da;
	private Register register;
	private TextField userIDTextField,userNameTextField,passwordTextField,mobileTextField,emailTextField;
	private Label userIDLabel,userNameLabel,passwordLabel,mobileLabel,emailLabel,titleLabel;
	private Button signUpButton,backButton,generateID;
	private int maxID;
	
	
	public SignUpWindow(Register r)
	{
		super("User Sign Up Window");
		this.register=r;
		
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,20);
		titleLabel=new Label("Create A New Account");//adding title
		Font titleFont = new Font("TimesRoman",Font.BOLD,30);
		titleLabel.setBounds(420,50,750,50);
		titleLabel.setFont(titleFont);
		add(titleLabel);
		
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,25); 
		userIDLabel=new Label("User ID");
		userIDLabel.setBounds(420,130,150,30);
		userIDLabel.setFont(titleFont2);
		add(userIDLabel);
		
		userIDTextField=new TextField();
		userIDTextField.setBounds(570,130,150,30);
		userIDTextField.setFont(titleFont1);
		userIDTextField.setVisible(false);
		add(userIDTextField);
		
		generateID=new Button("Generate User ID");
		generateID.setBounds(740,130,200,30);
		add(generateID);
		
		userNameLabel=new Label("User Name");
		userNameLabel.setBounds(420,180,150,30);
		userNameLabel.setFont(titleFont2);
		userNameLabel.setVisible(false);
		add(userNameLabel);
		
		userNameTextField=new TextField();
		userNameTextField.setBounds(570,180,150,30);
		userNameTextField.setFont(titleFont1);
		userNameTextField.setVisible(false);
		add(userNameTextField);
		
		passwordLabel=new Label("Password");
		passwordLabel.setBounds(420,230,150,30);
		passwordLabel.setFont(titleFont2);
		passwordLabel.setVisible(false);
		add(passwordLabel);
		
		passwordTextField=new TextField();
		passwordTextField.setBounds(570,230,150,30);
		passwordTextField.setFont(titleFont1);
		passwordTextField.setEchoChar('*');
		passwordTextField.setVisible(false);
		add(passwordTextField);
		
		
		mobileLabel=new Label("Mobile No.");
		mobileLabel.setBounds(420,280,150,30);
		mobileLabel.setFont(titleFont2);
		mobileLabel.setVisible(false);
		add(mobileLabel);
		
		mobileTextField=new TextField();
		mobileTextField.setBounds(570,280,150,30);
		mobileTextField.setFont(titleFont1);
		mobileTextField.setVisible(false);
		add(mobileTextField);
		
		emailLabel=new Label("Email ID");
		emailLabel.setBounds(420,330,150,30);
		emailLabel.setFont(titleFont2);
		emailLabel.setVisible(false);
		add(emailLabel);
		
		emailTextField=new TextField();
		emailTextField.setBounds(570,330,150,30);
		emailTextField.setFont(titleFont1);
		emailTextField.setVisible(false);
		add(emailTextField);
		
		signUpButton=new Button("Sign Up");
		signUpButton.setBounds(500,400,150,30);
		signUpButton.setVisible(false);
		add(signUpButton);
		
		backButton=new Button("Back");
		backButton.setBounds(80,50,150,30);
		add(backButton);
		
		signUpButton.addActionListener(this);
		backButton.addActionListener(this);
		generateID.addActionListener(this);
		addWindowListener(this);
		
		da=new DatabaseAccess();
		maxID=0;
		setSize(1250,680);
		setLayout(null);
	}
	public void windowClosing(WindowEvent we)
	{
        System.out.println("Window is closing");
		System.exit(0);
	}
	public void actionPerformed(ActionEvent e)
	{
		String st=e.getActionCommand();
		if(st.equals("Sign Up"))
		{
			String userType="Customer";
			
			
			try
		    {
			int userID=userIDTextField.getText().length();
			int password=passwordTextField.getText().length();
			int userName=userNameTextField.getText().length();
			int email=emailTextField.getText().length();
			int mobile=mobileTextField.getText().length();
			String query1="insert into logininfo values("+Integer.parseInt(userIDTextField.getText())+",'"+passwordTextField.getText()+"','"+userType+"')";
		    String query2="insert into customerinfo values("+Integer.parseInt(userIDTextField.getText())+",'"+userNameTextField.getText()+"','"+emailTextField.getText()+"','"+mobileTextField.getText()+"')";	
			
			if((userID!=0) && (password!=0) && (userName!=0) && (email!=0) && (mobile!=0))
			{
				if(mobile>=1 && mobile<=11)
				{
					da.updateDatabase(query1);
				    da.updateDatabase(query2);
				
			        System.out.println("Database Updated");
				    da.close();
			        JOptionPane.showMessageDialog(this,"Account Created Successfully","Message",JOptionPane.INFORMATION_MESSAGE);
			        register.signUpWindow.setVisible(false);
			        register.signInWindow.setVisible(true);
				}
				else
				{
					JOptionPane.showMessageDialog(this,"Mobile number must be within 11 digits","Warning",2);
				    this.mobileTextField.setText("");
				}
				
				
			}
			else if(userID==0 || password==0 || userName==0 || email==0 || mobile==0)
			{
				JOptionPane.showMessageDialog(this,"Missing Information,Try Again","Warning",2);
				
			}
			
			}//try ends here
		    catch(Exception ex)
			{
				JOptionPane.showMessageDialog(this,"Missing Information,Try Again","Warning",2);
				ex.printStackTrace();
			}
		    
		
			//need to work on that;
		}
		else if(st.equals("Back"))
		{
		    
			register.signInWindow=new SignInWindow(register);
			register.signInWindow.setVisible(true);
			register.signUpWindow.setVisible(false);
		}
		else if(st.equals("Generate User ID"))
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
				userIDTextField.setVisible(true);
				userNameLabel.setVisible(true); 
				userNameTextField.setVisible(true);
				passwordTextField.setVisible(true);
				mobileTextField.setVisible(true);
				emailTextField.setVisible(true);
				userNameLabel.setVisible(true);
				passwordLabel.setVisible(true);
				mobileLabel.setVisible(true);
				emailLabel.setVisible(true);
				signUpButton.setVisible(true);
				userIDTextField.setEditable(false);
				userIDTextField.setEnabled(false);
				
			}
			catch(Exception ex){ex.printStackTrace();}
			
		}
	}
	public void windowActivated(WindowEvent e){}
	public void windowClosed(WindowEvent e){}
	public void windowDeactivated(WindowEvent e){}
	public void windowDeiconified(WindowEvent e){}
	public void windowIconified(WindowEvent e){}
	public void windowOpened(WindowEvent e){}
	
}