import java.awt.*;
import java.awt.event.*;
import java.sql.*;//Connection;DriverManager;ResultSet;SQLException;Statement;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)

class MovieWindow extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private MovieInfo movieInfo; private String option;
	
	private Label movieInfoTitleLabel,movieNameLabel,genreLabel,releaseDateLabel,runningTimeLabel,ratingLabel;
	private TextField movieNameTextField,genreTextField,releaseDateTextField,runningTimeTextField,ratingTextField;
	private Button backButton,goButton;
	private JComboBox optionCombo;
	
	public MovieWindow(EntityInterface en,Register r,JComboBox op,MovieInfo mi)
	{
		super("Movie Info");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		this.movieInfo=mi;
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		add(optionCombo);
		
		
		movieInfoTitleLabel=new Label("Movie Info");
		movieInfoTitleLabel.setBounds(450,100,400,40);
		movieInfoTitleLabel.setFont(titleFont1);
		add(movieInfoTitleLabel);
		
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
		
		movieNameLabel=new Label("Movie Name");
		movieNameLabel.setBounds(350,200,200,30);
		movieNameLabel.setFont(titleFont);
		add(movieNameLabel);
		
		movieNameTextField=new TextField(movieInfo.getMovieName());
		movieNameTextField.setBounds(550,200,350,30);
		movieNameTextField.setFont(titleFont);
		movieNameTextField.setEditable(false);
		movieNameTextField.setEnabled(false);
		add(movieNameTextField);
		
		genreLabel=new Label("Genre");
		genreLabel.setBounds(350,250,200,30);
		genreLabel.setFont(titleFont);
		add(genreLabel);
		
		genreTextField=new TextField(movieInfo.getGenre());
		genreTextField.setBounds(550,250,350,30);
		genreTextField.setFont(titleFont);
		genreTextField.setEditable(false);
		genreTextField.setEnabled(false);
		add(genreTextField);
		
		releaseDateLabel=new Label("Release Date");
		releaseDateLabel.setBounds(350,300,200,30);
		releaseDateLabel.setFont(titleFont);
		add(releaseDateLabel);
		
		releaseDateTextField=new TextField(movieInfo.getReleaseDate());
		releaseDateTextField.setBounds(550,300,350,30);
		releaseDateTextField.setFont(titleFont);
		releaseDateTextField.setEditable(false);
		releaseDateTextField.setEnabled(false);
		add(releaseDateTextField);
		
		runningTimeLabel=new Label("Running Time");
		runningTimeLabel.setBounds(350,350,200,30);
		runningTimeLabel.setFont(titleFont);
		add(runningTimeLabel);
		
		runningTimeTextField=new TextField(movieInfo.getRunningTime());
		runningTimeTextField.setBounds(550,350,350,30);
		runningTimeTextField.setFont(titleFont);
		runningTimeTextField.setEditable(false);
		runningTimeTextField.setEnabled(false);
		add(runningTimeTextField);
		
		ratingLabel=new Label("IMDb Rating");
		ratingLabel.setBounds(350,400,200,30);
		ratingLabel.setFont(titleFont);
		add(ratingLabel);
		
		ratingTextField=new TextField(movieInfo.getRating());
		ratingTextField.setBounds(550,400,350,30);
		ratingTextField.setFont(titleFont);
		ratingTextField.setEditable(false);
		ratingTextField.setEnabled(false);
		add(ratingTextField);
		
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
	

	public void actionPerformed(ActionEvent e)//need to work more 
	{
		String st=e.getActionCommand();
	    if(st.equals("Back"))
	    {
		register.homeWindow=new HomeWindow(entity,register);
		register.homeWindow.setVisible(true);
		register.movieWindow.setVisible(false);
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