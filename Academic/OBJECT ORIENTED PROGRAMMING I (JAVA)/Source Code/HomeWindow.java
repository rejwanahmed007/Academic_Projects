import java.util.*; //ArrayList
import java.awt.*;
import java.awt.event.*;
import java.sql.*;//ResultSet;SQLException;
import java.lang.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)
class HomeWindow extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private ArrayList<MovieInfo> movieInfoArrayList;
	
	private String movieList[],dateList[],timeList[],optionList[];
	private int movieID,mi;
	private String date,time,option;
	
	private Label welcomeTitleLabel,MovieTitleLabel,movieNameLabel,dateLabel,timeLabel,hallNameLabel,hallTypeLabel,capacityLabel,availableSeatLabel;
	private Button totalRevenueButton,movieInfoButton,showDateButton,showTimeButton,showHallNameButton,refreshButton,goButton;
	private JComboBox optionCombo,movieCombo,dateCombo,timeCombo;
	private TextField totalRevenueTextField,hallNameTextField,hallTypeTextField,capacityTextField,availableSeatTextField;
	private Font titleFont,titleFont1;
	
	public HomeWindow(EntityInterface en,Register r)
	{
		super("Home");
		this.entity=en;
		this.register=r;
		dateList=new String[8];
		timeList=new String[5];
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,25);
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,15);
		
		welcomeTitleLabel=new Label("Welcome Mr."+entity.getUserName());
		welcomeTitleLabel.setBounds(420,50,600,30);
		welcomeTitleLabel.setFont(titleFont);
		add(welcomeTitleLabel);
		
		MovieTitleLabel=new Label("Movie of This Week");
		MovieTitleLabel.setBounds(450,100,400,40);
		MovieTitleLabel.setFont(titleFont1);
		add(MovieTitleLabel);
		
		goButton=new Button("Go");
		goButton.setBounds(1150,100,50,30);
		goButton.setFont(titleFont);
		goButton.addActionListener(this);
		add(goButton);
		
		movieNameLabel=new Label("Movie Name");
		movieNameLabel.setBounds(225,200,125,30);
		movieNameLabel.setFont(titleFont);
		add(movieNameLabel);
		
		getMovieList();
		
		movieCombo=new JComboBox(movieList);
		movieCombo.setBounds(350,200,250,30);
		movieCombo.setFont(titleFont);
		movieCombo.addActionListener(this);
		add(movieCombo);
		
		showDateButton=new Button("Show Date");
		showDateButton.setBounds(650,200,150,30);
		showDateButton.setFont(titleFont);
		showDateButton.addActionListener(this);
		add(showDateButton);
		
		dateLabel=new Label("Date");
		dateLabel.setBounds(225,250,125,30);
		dateLabel.setFont(titleFont);
		dateLabel.setVisible(false);//need to false;
		add(dateLabel);
		
		dateCombo=new JComboBox(dateList);
		dateCombo.setBounds(350,250,250,30);
		dateCombo.setFont(titleFont);
		dateCombo.addActionListener(this);
		dateCombo.setVisible(false);
		add(dateCombo);
		
		showTimeButton=new Button("Show Time");
		showTimeButton.setBounds(650,250,150,30);
		showTimeButton.setFont(titleFont);
		showTimeButton.addActionListener(this);
		showTimeButton.setVisible(false);//need to false
		add(showTimeButton);
		
		timeLabel=new Label("Time");
		timeLabel.setBounds(225,300,125,30);
		timeLabel.setFont(titleFont);
		timeLabel.setVisible(false);//need to false
		add(timeLabel);
		
		timeCombo=new JComboBox(timeList);
		timeCombo.setBounds(350,300,250,30);
		timeCombo.setFont(titleFont);
		timeCombo.addActionListener(this);
		timeCombo.setVisible(false);//need to false;
		add(timeCombo);
		
		showHallNameButton=new Button("Show Hall Info");
		showHallNameButton.setBounds(650,300,150,30);
		showHallNameButton.setFont(titleFont);
		showHallNameButton.addActionListener(this);
		showHallNameButton.setVisible(false); //need to false;
		add(showHallNameButton);
		
		hallNameLabel=new Label("Hall Name");
		hallNameLabel.setBounds(225,350,125,30);
		hallNameLabel.setFont(titleFont);
		hallNameLabel.setVisible(false);//need to false
		add(hallNameLabel);
		
		hallNameTextField=new TextField();
		hallNameTextField.setBounds(350,350,150,30);
		hallNameTextField.setFont(titleFont);
		//hallNameTextField.setEditable(true);
		hallNameTextField.setVisible(false);//need to false;
		add(hallNameTextField);
		
		capacityLabel=new Label("Capacity");
		capacityLabel.setBounds(550,350,150,30);
		capacityLabel.setFont(titleFont);
		capacityLabel.setVisible(false);// need to false;
		add(capacityLabel);
		
		capacityTextField=new TextField();
		capacityTextField.setBounds(700,350,100,30);
		capacityTextField.setFont(titleFont);
		capacityTextField.setVisible(false);//need to false
		add(capacityTextField);
		
		hallTypeLabel=new Label("Hall Type");
		hallTypeLabel.setBounds(225,400,125,30);
		hallTypeLabel.setFont(titleFont);
		hallTypeLabel.setVisible(false); //need to false
		add(hallTypeLabel);
		
		hallTypeTextField=new TextField();
		hallTypeTextField.setBounds(350,400,150,30);
		hallTypeTextField.setFont(titleFont);
		hallTypeTextField.setVisible(false);//need to false
		add(hallTypeTextField);
		
		availableSeatLabel=new Label("Available Seat");
		availableSeatLabel.setBounds(550,400,150,30);
		availableSeatLabel.setFont(titleFont);
		availableSeatLabel.setVisible(false); //need to false
		add(availableSeatLabel);
		
		availableSeatTextField=new TextField();
		availableSeatTextField.setBounds(700,400,100,30);
		availableSeatTextField.setFont(titleFont);
		availableSeatTextField.setVisible(false); //need to false
		add(availableSeatTextField);
		
		refreshButton=new Button("Refresh");
		refreshButton.setBounds(700,550,100,30);
		refreshButton.setFont(titleFont);
		refreshButton.addActionListener(this);
		refreshButton.setVisible(false); //need to false
		add(refreshButton);
		
		movieInfoButton=new Button("Want to know more info about the movie you selected ?");
		movieInfoButton.setBounds(225,550,425,30);
		movieInfoButton.setFont(titleFont2);
		movieInfoButton.addActionListener(this);
		movieInfoButton.setVisible(false);//need to false 
		add(movieInfoButton);
	
		if(entity.getUserType().equals("Customer"))
		{
			optionList=new String[]{"Select Option-","My Profile","Change Password","MY Tickets","Sign Out"};
		    optionCombo=new JComboBox(optionList);
		    optionCombo.setBounds(900,100,200,30);
		    optionCombo.setFont(titleFont);
		    optionCombo.addActionListener(this);
		    add(optionCombo);
		}
		else if(entity.getUserType().equals("Customer Manager"))
		{
			optionList=new String[]{"Select Option-","My Profile","Change Password","Sell Ticket(s)","Sign Out"};
			optionCombo=new JComboBox(optionList);
		    optionCombo.setBounds(900,100,200,30);
		    optionCombo.setFont(titleFont);
		    optionCombo.addActionListener(this);
		    add(optionCombo);
		}
		else if(entity.getUserType().equals("Manager"))
		{
			optionList=new String[]{"Select Option-","My Profile","Change Password","Sell Ticket(s)","Add Employee","View Employee Info","Sign Out"};
			optionCombo=new JComboBox(optionList);
		    optionCombo.setBounds(900,100,200,30);
			optionCombo.setFont(titleFont2);
		    optionCombo.addActionListener(this);
		    add(optionCombo);
			
			totalRevenueButton=new Button("Revenue of this week");
			totalRevenueButton.setBounds(225,450,275,30);
			totalRevenueButton.setFont(titleFont);
			totalRevenueButton.addActionListener(this);
			add(totalRevenueButton);
			
			totalRevenueTextField=new TextField();
			totalRevenueTextField.setBounds(550,450,250,30);
			totalRevenueTextField.setFont(titleFont);
			totalRevenueTextField.setVisible(false);
			add(totalRevenueTextField);
		}
		
		
		
		addWindowListener(this);
		setSize(1250,680);
		setLayout(null);
		
		
	}
	
	public void getMovieList()
	{
		try//creating movie list
		{
			
			register.buffer.loadMovieInfo();
			movieInfoArrayList=register.buffer.getMovieInfoArrayList();
			movieList=new String[movieInfoArrayList.size()+1];
			movieList[0]="Select Movie-";
			
			for(int i=0;i<movieInfoArrayList.size();i++)
			{
				if(movieInfoArrayList.get(i)!=null)
			    movieList[i+1]=movieInfoArrayList.get(i).getMovieName();
			    System.out.println(movieList[i+1]);
			}
		}
		
		catch(Exception ex){ex.printStackTrace();}
		
		
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
	
	public void actionPerformed(ActionEvent e)//need to work on that
	{
		String st=e.getActionCommand();
		
		if(st.equals("Revenue of this week"))
		{
			int totalRevenue=0;
			try
			{
				DatabaseAccess da=new DatabaseAccess(); 
			    ResultSet rs=da.getData("SELECT SUM(revenue) totalRevenue FROM soldticket");
			    while(rs.next())
			    {
				totalRevenue=rs.getInt("totalRevenue");
			    }
			    totalRevenueTextField.setVisible(true);
			    totalRevenueTextField.setText(Integer.toString(totalRevenue));
			    totalRevenueTextField.setEditable(false);
			    totalRevenueTextField.setEnabled(false);
				refreshButton.setVisible(true);
			}
			catch(Exception ex){ex.printStackTrace();}
			
		}
		
		
		else if(st.equals("Show Date"))
		{
			
			availableSeatTextField.setVisible(false);
            availableSeatLabel.setVisible(false); 
            hallTypeTextField.setVisible(false);
            hallTypeLabel.setVisible(false);
            capacityTextField.setVisible(false);
            capacityLabel.setVisible(false);
            hallNameTextField.setVisible(false);
            hallNameLabel.setVisible(false);
            showHallNameButton.setVisible(false);
            timeCombo.setVisible(false);
            timeLabel.setVisible(false);
            showTimeButton.setVisible(false);
            dateCombo.setVisible(false);
            dateLabel.setVisible(false);
			refreshButton.setVisible(false);
			movieInfoButton.setVisible(false);
			
			dateCombo.setEnabled(true);
			timeCombo.setEnabled(true);
			
			String movie=movieCombo.getSelectedItem().toString();
			System.out.println(movie);
			if(movie.equals("Select Movie-"))
			{
				
				System.out.println("You haven't selected any movie,please select first");
				JOptionPane.showMessageDialog(this,"You haven't selected any movie,please select first","Warning",2);
			}
			else if(!movie.equals("Select Movie-"))
			{
				
			for(mi=0;mi<movieInfoArrayList.size();mi++) // getting movie id of the selected movie
			{
				if(movie.equals(movieInfoArrayList.get(mi).getMovieName()))
				{
					movieID=movieInfoArrayList.get(mi).getMovieID();
					System.out.println(movieID);
					break;
				}
				
			}
			try
			{
				DatabaseAccess da=new DatabaseAccess();  //getting showDate for dateCombo;
				ResultSet rs=da.getData("SELECT showdate FROM showtimeinfo WHERE movieID="+movieID+" GROUP by showDate");
				int k=1;
				dateCombo.removeAllItems();
				dateList[0]="Select Date-";
				dateCombo.insertItemAt(dateList[0],0);
				while(rs.next())
				{
					dateList[k]=rs.getString("showdate");
					k++;
					
				}
				for(int j=1;j<k;j++)
				{
					dateCombo.insertItemAt(dateList[j],j);
					
				}
				dateCombo.setSelectedIndex(0);
				dateCombo.setVisible(true);
				dateLabel.setVisible(true);
				showTimeButton.setVisible(true);
				refreshButton.setVisible(true);
				movieInfoButton.setVisible(true);
				movieCombo.setEnabled(false);
				da.close();
				
			}//try ends here
			catch(Exception ex){ex.printStackTrace();}
			
			
			}//else if ends here 
			
		}
		else if(st.equals("Show Time"))
		{
			availableSeatTextField.setVisible(false);
            availableSeatLabel.setVisible(false); 
            hallTypeTextField.setVisible(false);
            hallTypeLabel.setVisible(false);
            capacityTextField.setVisible(false);
            capacityLabel.setVisible(false);
            hallNameTextField.setVisible(false);
            hallNameLabel.setVisible(false);
            showHallNameButton.setVisible(false);
            timeCombo.setVisible(false);
            timeLabel.setVisible(false);

            timeCombo.setEnabled(true);
			
			date=dateCombo.getSelectedItem().toString();
			System.out.println(date);
			if(date.equals("Select Date-"))
			{
				
				System.out.println("You haven't selected any date,please select first");
				JOptionPane.showMessageDialog(this,"You haven't selected any date,please select first","Warning",2);
			}
			else if(!date.equals("Select Date-"))
			{
				try
				{
					DatabaseAccess da=new DatabaseAccess();
				    ResultSet rs=da.getData("SELECT showTime FROM showtimeinfo where movieID="+movieID+" and showDate='"+date+"'");
					int l=1;
				    timeCombo.removeAllItems();
				    timeList[0]="Select Time-";
					timeCombo.insertItemAt(timeList[0],0);
					while(rs.next())
					{
						timeList[l]=rs.getString("showTime");
					    l++;
					}
					for(int m=1;m<l;m++)
				    {
					timeCombo.insertItemAt(timeList[m],m);
					
				    }
					timeCombo.setSelectedIndex(0);
					timeCombo.setVisible(true);
                    timeLabel.setVisible(true);
					showHallNameButton.setVisible(true);
					refreshButton.setVisible(true);
					movieInfoButton.setVisible(true);
					movieCombo.setEnabled(false);
				    dateCombo.setEnabled(false);
					da.close();
					
				}
				catch(Exception ex){ex.printStackTrace();}
			}
			
		}
		else if(st.equals("Show Hall Info"))
		{
			availableSeatTextField.setVisible(false);
            availableSeatLabel.setVisible(false); 
            hallTypeTextField.setVisible(false);
            hallTypeLabel.setVisible(false);
            capacityTextField.setVisible(false);
            capacityLabel.setVisible(false);
            hallNameTextField.setVisible(false);
            hallNameLabel.setVisible(false);
            
			time=timeCombo.getSelectedItem().toString();
			System.out.println(time);
			if(time.equals("Select Time-"))
			{
				System.out.println("You haven't selected any time,please select first");
				JOptionPane.showMessageDialog(this,"You haven't selected any time,please select first","Warning",2);
			}
			else if(!time.equals("Select Time-"))
			{
				String hallName=null;String hallType=null;
				int capacity=0;int availableSeat=0;
				try
				{
					DatabaseAccess da=new DatabaseAccess();
				    ResultSet rs=da.getData("SELECT hallName,hallType,capacity,availableSeat from showtimeinfo,hallinfo where showtimeinfo.hallID=hallinfo.hallID AND movieID="+movieID+" AND showDate='"+date+"' AND showTime='"+time+"'");
					
					while(rs.next())
					{
						hallName=rs.getString("hallName");
					    hallType=rs.getString("hallType");
					    capacity=rs.getInt("capacity");
					    availableSeat=rs.getInt("availableSeat");
						break;
					}
					hallNameLabel.setVisible(true);
					hallNameTextField.setText(hallName);
					hallNameTextField.setEditable(false);
					hallNameTextField.setVisible(true);
					hallNameTextField.setEnabled(false);
					hallTypeLabel.setVisible(true);
					hallTypeTextField.setText(hallType);
					hallTypeTextField.setEditable(false);
					hallTypeTextField.setVisible(true);
					hallTypeTextField.setEnabled(false);
					capacityLabel.setVisible(true);
					capacityTextField.setText(Integer.toString(capacity));
					capacityTextField.setEditable(false);
					capacityTextField.setVisible(true);
					capacityTextField.setEnabled(false);
					availableSeatLabel.setVisible(true);
					availableSeatTextField.setText(Integer.toString(availableSeat));
					availableSeatTextField.setEditable(false);
					availableSeatTextField.setVisible(true);
					availableSeatTextField.setEnabled(false);
					refreshButton.setVisible(true);
					movieInfoButton.setVisible(true);
					timeCombo.setEnabled(false);
					movieCombo.setEnabled(false);
				    dateCombo.setEnabled(false);
					da.close();
					
				}
				catch(Exception ex){ex.printStackTrace();}
				
			}
			
		}
		
		else if(st.equals("Refresh"))
		{
			register.homeWindow.setVisible(false);
			register.homeWindow=new HomeWindow(entity,register);
			register.homeWindow.setVisible(true);
			
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
				register.homeWindow.setVisible(false);
			}
			else if(option.equals("Change Password"))
			{
				register.changePassword=new ChangePassword(entity,register,optionCombo);
				register.changePassword.setVisible(true);
				register.homeWindow.setVisible(false);
			}
			else if(option.equals("MY Tickets"))
			{
				register.myTickets=new MyTickets(entity,register,optionCombo);
				register.myTickets.setVisible(true);
				register.homeWindow.setVisible(false);
			}
			else if(option.equals("Sign Out"))
			{
				register.signInWindow=new SignInWindow(register);
				register.signInWindow.setVisible(true);
				register.homeWindow.setVisible(false);
			}
			else if(option.equals("Sell Ticket(s)"))
			{
				register.sellTicketWindow=new SellTicketWindow(entity,register,optionCombo);
				register.sellTicketWindow.setVisible(true);
				register.homeWindow.setVisible(false);
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
		else if(st.equals("Want to know more info about the movie you selected ?"))
		{
			register.movieWindow=new MovieWindow(entity,register,optionCombo,movieInfoArrayList.get(mi));
			register.movieWindow.setVisible(true);
			register.homeWindow.setVisible(false);
		}
		
		
			
	}
	
}