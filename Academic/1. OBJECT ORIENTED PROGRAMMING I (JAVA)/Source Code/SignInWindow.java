import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import java.lang.*;
import javax.swing.*;//JOptionPane(pop up window)
class SignInWindow extends Frame implements ActionListener,WindowListener
{
	private Register register;
	private Label titleLabel,subtitleLabel,promptLabel,userIDLabel,passwordLabel;
	private TextField userIDTextField,passwordTextField;
	private Button signInButton,exitButton,signUpButton;
	
	public SignInWindow(Register r)
	{
		super("User Sign In Window");  //naming the page
		this.register=r;
		
		Font titleFont = new Font("TimesRoman",Font.BOLD,30); //adding title;
		titleLabel=new Label("Welcome to Snowflake Movie Theater Management System");
		titleLabel.setBounds(250,30,750,50);
		titleLabel.setFont(titleFont);
		add(titleLabel);
		
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,25); //adding subtitle;
		subtitleLabel=new Label("Already Have An Account ? If Yes...Then Enter");
		subtitleLabel.setBounds(350,100,750,50);
		subtitleLabel.setFont(titleFont2);
		add(subtitleLabel);
		
		promptLabel=new Label("Want to Create A New Account ?");
		promptLabel.setBounds(400,350,750,50);
		promptLabel.setFont(titleFont2);
		add(promptLabel);
		
		userIDLabel=new Label("User ID");
		passwordLabel=new Label("Password");
		userIDTextField=new TextField();
		passwordTextField=new TextField();
		passwordTextField.setEchoChar('*');
		passwordTextField.addActionListener(this);//testing
		signInButton=new Button("Sign In");
		signUpButton=new Button("Sign Up");
		exitButton=new Button("Exit");
		
		userIDTextField.setBounds(550,180,150,30);
		passwordTextField.setBounds(550,230,150,30);
		signInButton.setBounds(550,300,80,30);
		exitButton.setBounds(450,300,80,30);
		signUpButton.setBounds(520,420,80,30);
		userIDLabel.setBounds(350,180,120,30);
		passwordLabel.setBounds(350,230,120,30);
		
		userIDLabel.setFont(titleFont2);
		passwordLabel.setFont(titleFont2);
		
		add(userIDTextField);
		add(passwordTextField);
		add(userIDLabel);
		add(passwordLabel);
		add(signInButton);
		add(exitButton);
		add(signUpButton);
		signInButton.addActionListener(this);
		signUpButton.addActionListener(this);
		exitButton.addActionListener(this);
		addWindowListener(this);
		setSize(1250,680);
		//setLocation(100,100);
		setLayout(null);
		
	}
	
	public void windowClosing(WindowEvent we)
	{
        System.out.println("Window is closing");
		System.exit(0);
	}
	public void actionPerformed(ActionEvent e)
	{
		
		String s=e.getActionCommand();
		EntityInterface entity=null;
		if(s.equals("Sign In"))
		{
			if(userIDTextField.getText().length()!=0 && passwordTextField.getText().length()!=0)
			{
				
			 //working progress;
			 try
			 {
				 register.buffer=new BufferEntity();
				 register.buffer.loadEntity("select * from logininfo");
				 //register.buffer.printEntity();
				 entity=register.buffer.checkEntityAuthentication(Integer.parseInt(userIDTextField.getText()),passwordTextField.getText());
				 
				 if(entity!=null)
				 {
					register.homeWindow=new HomeWindow(entity,register);
					register.homeWindow.setVisible(true);
					register.signInWindow.setVisible(false);
				 }
				 else
				 {
					 this.passwordTextField.setText("");
				     this.userIDTextField.setText("");
				
				     System.out.println("Invalid User ID or Password");
				     JOptionPane.showMessageDialog(this,"Invalid User ID or Password","Warning",2);
				 }
				 
				 
			 }
			 catch(Exception ex){ex.printStackTrace();}
				
			}
			else
			{
				     this.passwordTextField.setText("");
				     this.userIDTextField.setText("");
				
				     System.out.println("You didn't enter any user ID or password");
				     JOptionPane.showMessageDialog(this,"You didn't enter any User ID or Password","Warning",2);
			}
			
		}
		else if(s.equals("Sign Up"))
		{
			
			
			register.signUpWindow=new SignUpWindow(register);
			register.signUpWindow.setVisible(true);
			register.signInWindow.setVisible(false);
		}
		else if(s.equals("Exit"))
		{
			System.out.println("Window is closing");
		    System.exit(0);
		}
	}
	public void windowActivated(WindowEvent e){}
	public void windowClosed(WindowEvent e){}
	public void windowDeactivated(WindowEvent e){}
	public void windowDeiconified(WindowEvent e){}
	public void windowIconified(WindowEvent e){}
	public void windowOpened(WindowEvent e){}


}
