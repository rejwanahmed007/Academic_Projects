import java.util.*; //ArrayList
import java.awt.*;
import java.sql.*;//Connection;DriverManager;ResultSet;SQLException;Statement;
import java.awt.event.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)

class MyTickets extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private DatabaseAccess da;
	
	
	
	private int seat,movieName,showDate,showTime,hallName,hallType,ticketInfoAmount;
	private Label myTicketTitleLabel,noTicketMessageLabel,maxTicketMessageLabel;
	private TextField seatTextField,movieNameTextField,showDateTextField,showTimeTextField,hallNameTextField,hallTypeTextField;
	private ArrayList<String> seatArray,movieNameArray,showDateArray,showTimeArray,hallNameArray,hallTypeArray;
	private Button backButton,goButton;
	private JComboBox optionCombo;
	private String option;
	
	public MyTickets(EntityInterface en,Register r,JComboBox op)
	{
		super("My Ticket Info");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		add(optionCombo);
		ticketInfoAmount=0;
		seatArray=new ArrayList<String>();
		movieNameArray=new ArrayList<String>();
		showDateArray=new ArrayList<String>();
		showTimeArray=new ArrayList<String>();
		hallNameArray=new ArrayList<String>();
		hallTypeArray=new ArrayList<String>();
		
		myTicketTitleLabel=new Label("My Ticket Info");
		myTicketTitleLabel.setBounds(450,100,400,40);
		myTicketTitleLabel.setFont(titleFont1);
		add(myTicketTitleLabel);
		
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
		
		movieNameTextField=new TextField("Movie Name");
		movieNameTextField.setBounds(50,200,350,30);
		movieNameTextField.setFont(titleFont);
		movieNameTextField.setEditable(false);
		add(movieNameTextField);
		
		showDateTextField=new TextField("Show Date");
		showDateTextField.setBounds(400,200,150,30);
		showDateTextField.setFont(titleFont);
		showDateTextField.setEditable(false);
		add(showDateTextField);
		
		showTimeTextField=new TextField("Show Time");
		showTimeTextField.setBounds(550,200,150,30);
		showTimeTextField.setFont(titleFont);
		showTimeTextField.setEditable(false);
		add(showTimeTextField);
		
		seatTextField=new TextField("Seat(s)");
		seatTextField.setBounds(700,200,100,30);
		seatTextField.setFont(titleFont);
		seatTextField.setEditable(false);
		add(seatTextField);
		
		hallNameTextField=new TextField("Hall Name");
		hallNameTextField.setBounds(800,200,150,30);
		hallNameTextField.setFont(titleFont);
		hallNameTextField.setEditable(false);
		add(hallNameTextField);
		
		hallTypeTextField=new TextField("Hall Type");
		hallTypeTextField.setBounds(950,200,150,30);
		hallTypeTextField.setFont(titleFont);
		hallTypeTextField.setEditable(false);
		add(hallTypeTextField);
		
		getMyTicketsInfo();
		
		setMyTicketsInfo();
		
		/*myTicketsInfoCombo.setSelectedIndex(0);
		myTicketsInfoCombo.setBounds(50,200,1150,30);
		myTicketsInfoCombo.setFont(titleFont);
		add(myTicketsInfoCombo);*/
		
		
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
	
	public void getMyTicketsInfo()
	{
		try
		{
			String query="SELECT movieName,showDate,showTime,seat,hallName,hallType FROM movieinfo,showtimeinfo,hallinfo,soldticket WHERE movieinfo.movieID=showtimeinfo.movieID AND showtimeinfo.showTimeID IN (SELECT soldticket.showTimeID from soldticket WHERE customerID="+entity.getUserID()+") AND showtimeinfo.hallID=hallinfo.hallID AND soldticket.showTimeID=showtimeinfo.showTimeID AND soldticket.customerID="+entity.getUserID()+" ORDER BY soldticket.soldTicketID DESC";
			da=new DatabaseAccess();
			ResultSet rs=da.getData(query);
			while(rs.next())
			{
				movieName=rs.getString("movieName").length();
				showDate=rs.getString("showDate").length();
				showTime=rs.getString("showTime").length();
				seat=rs.getInt("seat");
				hallName=rs.getString("hallName").length();
				hallType=rs.getString("hallType").length();
				if(movieName!=0 && showDate!=0 && showTime!=0 && seat!=0 && hallName!=0 && hallType!=0)
				{
					movieNameArray.add(rs.getString("movieName"));
					showDateArray.add(rs.getString("showDate"));
					showTimeArray.add(rs.getString("showTime"));
					seatArray.add(Integer.toString(rs.getInt("seat")));
					hallNameArray.add(rs.getString("hallName"));
					hallTypeArray.add(rs.getString("hallType"));
					ticketInfoAmount++;
				}
			}
			da.close();
			
		}
		catch(Exception ex){ex.printStackTrace();}
		
	}
	
	public void setMyTicketsInfo()
	{
		int y=200;
		 
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		TextField[] movieNameTextField =new TextField[ticketInfoAmount];
		TextField[] showDateTextField =new TextField[ticketInfoAmount];
		TextField[] showTimeTextField =new TextField[ticketInfoAmount];
		TextField[] seatTextField =new TextField[ticketInfoAmount];
		TextField[] hallTextField =new TextField[ticketInfoAmount];
		TextField[] hallTypeTextField =new TextField[ticketInfoAmount];
		
		
		if(ticketInfoAmount!=0)
		{
			for(int i=0;i<ticketInfoAmount;i++)
			{
				if(i==11)
				{
					break;
				}
				else
				{
					y=y+30;
				
					movieNameTextField[i]=new TextField(movieNameArray.get(i));
					movieNameTextField[i].setBounds(50,y,350,30);
					movieNameTextField[i].setFont(titleFont);
					movieNameTextField[i].setEditable(false);
					add(movieNameTextField[i]);
				
					showDateTextField[i]=new TextField(showDateArray.get(i));
					showDateTextField[i].setBounds(400,y,150,30);
					showDateTextField[i].setFont(titleFont);
					showDateTextField[i].setEditable(false);
					add(showDateTextField[i]);
				
					showTimeTextField[i]=new TextField(showTimeArray.get(i));
					showTimeTextField[i].setBounds(550,y,150,30);
					showTimeTextField[i].setFont(titleFont);
					showTimeTextField[i].setEditable(false);
					add(showTimeTextField[i]);
				
					seatTextField[i]=new TextField(seatArray.get(i));
					seatTextField[i].setBounds(700,y,100,30);
					seatTextField[i].setFont(titleFont);
					seatTextField[i].setEditable(false);
					add(seatTextField[i]);
				
					hallTextField[i]=new TextField(hallNameArray.get(i));
					hallTextField[i].setBounds(800,y,150,30);
					hallTextField[i].setFont(titleFont);
					hallTextField[i].setEditable(false);
					add(hallTextField[i]);
				
					hallTypeTextField[i]=new TextField(hallTypeArray.get(i));
					hallTypeTextField[i].setBounds(950,y,150,30);
					hallTypeTextField[i].setFont(titleFont);
					hallTypeTextField[i].setEditable(false);
					add(hallTypeTextField[i]);
				}
				
				
			}
			maxTicketMessageLabel=new Label("Latest Purchased Information of Each Order (Maximum Ten)");
			maxTicketMessageLabel.setBounds(280,600,700,30);
		    maxTicketMessageLabel.setFont(titleFont);
		    add(maxTicketMessageLabel);
			
		}
		else
		{
			noTicketMessageLabel=new Label("You haven't purchased any ticket");
			noTicketMessageLabel.setBounds(400,600,600,30);
		    noTicketMessageLabel.setFont(titleFont);
		    add(noTicketMessageLabel);
		}
		
	}
	
public void actionPerformed(ActionEvent e)//need to work on that
{
	String st=e.getActionCommand();
	if(st.equals("Back"))
	{
		register.homeWindow=new HomeWindow(entity,register);
		register.homeWindow.setVisible(true);
		register.myTickets.setVisible(false);
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