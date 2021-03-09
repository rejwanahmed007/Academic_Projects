import java.util.*; //ArrayList
import java.awt.*;
import java.awt.event.*;
import java.sql.*;////Connection;DriverManager;ResultSet;SQLException;Statement;
import java.lang.*;
import javax.swing.*; //for jcombobox & JOptionPane(pop up window)

class SellTicketWindow extends Frame implements WindowListener,ActionListener
{
	private EntityInterface entity;
	private Register register;
	private ArrayList<MovieInfo> movieInfoArrayList;
	
	private String amountOfTicketList[],movieList[],dateList[],timeList[],customerIDList[],customerID,date,time,option,hallName,hallType;
	private int totalPrice,capacity,availableSeat,movieID,numberOfCustomer,mi,customer,showTimeID,seat;
	private DatabaseAccess da;
	
	private Button totalPriceButton,showMoviesButton,showDateButton,showTimeButton,showHallNameButton,refreshButton,backButton,goButton,amountOfTicketButton,sellButton;
	private TextField totalPriceTextField,soldByTextField,hallNameTextField,hallTypeTextField,capacityTextField,availableSeatTextField;
	private Label sellTicketTitleLabel,customerIDLabel,soldByLabel,movieNameLabel,dateLabel,timeLabel,hallNameLabel,hallTypeLabel,capacityLabel,availableSeatLabel;
	private JComboBox amountOfTicketCombo,optionCombo,customerIDCombo,movieCombo,dateCombo,timeCombo;
	
	public SellTicketWindow(EntityInterface en,Register r,JComboBox op)
	{
		super("Sell Ticket");
		this.entity=en;
		this.register=r;
		this.optionCombo=op;
		Font titleFont1 = new Font("TimesRoman",Font.BOLD,30);
		Font titleFont = new Font("TimesRoman",Font.BOLD,20);
		Font titleFont2 = new Font("TimesRoman",Font.BOLD,15);
		add(optionCombo);
		da=new DatabaseAccess();
		
		sellTicketTitleLabel=new Label("Sell Ticket(s)");
		sellTicketTitleLabel.setBounds(450,75,400,40);
		sellTicketTitleLabel.setFont(titleFont1);
		add(sellTicketTitleLabel);
		
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
		
		getCustomerIDList();   //for making an array of customer IDs;
		
		customerIDLabel=new Label("Customer ID");
		customerIDLabel.setBounds(225,150,125,30);
		customerIDLabel.setFont(titleFont);
		add(customerIDLabel);
		
		customerIDCombo=new JComboBox(customerIDList);
		customerIDCombo.setBounds(350,150,250,30);
		customerIDCombo.setFont(titleFont);
		customerIDCombo.setSelectedIndex(0);
		customerIDCombo.addActionListener(this);
		add(customerIDCombo);
		
		
		
		showMoviesButton=new Button("Show Movie");
		showMoviesButton.setBounds(650,150,150,30);
		showMoviesButton.setFont(titleFont);
		showMoviesButton.addActionListener(this);
		add(showMoviesButton);
		
		movieNameLabel=new Label("Movie Name");
		movieNameLabel.setBounds(225,200,125,30);
		movieNameLabel.setFont(titleFont);
		movieNameLabel.setVisible(false);//need to false;
		add(movieNameLabel);
		
		getMovieList();
		
		movieCombo=new JComboBox(movieList);
		movieCombo.setBounds(350,200,250,30);
		movieCombo.setFont(titleFont);
		movieCombo.addActionListener(this);
		movieCombo.setVisible(false);//need to false;
		add(movieCombo);
		
		showDateButton=new Button("Show Date");
		showDateButton.setBounds(650,200,150,30);
		showDateButton.setFont(titleFont);
		showDateButton.addActionListener(this);
		showDateButton.setVisible(false);//need to false;
		add(showDateButton);
		
		dateLabel=new Label("Date");
		dateLabel.setBounds(225,250,125,30);
		dateLabel.setFont(titleFont);
		dateLabel.setVisible(false);//need to false;
		add(dateLabel);
		
		dateList=new String[8];
		
		dateCombo=new JComboBox(dateList);
		dateCombo.setBounds(350,250,250,30);
		dateCombo.setFont(titleFont);
		dateCombo.addActionListener(this);
		dateCombo.setVisible(false); //need to false
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
		
		timeList=new String[5];
		
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
		
		amountOfTicketButton=new Button("Amount of Ticket");
		amountOfTicketButton.setBounds(225,450,175,30);
		amountOfTicketButton.setFont(titleFont);
		amountOfTicketButton.addActionListener(this);
		amountOfTicketButton.setVisible(false); //need to false;
		add(amountOfTicketButton);
		
		amountOfTicketList=new String[]{"Select Amount-","1","2","3","4","5","6","7","8","9","10"};
		
		amountOfTicketCombo=new JComboBox(amountOfTicketList);
		amountOfTicketCombo.setBounds(425,450,125,30);
		amountOfTicketCombo.setFont(titleFont2);
		amountOfTicketCombo.setVisible(false); //need to false
		add(amountOfTicketCombo);
		
		soldByLabel=new Label("Sold By");
		soldByLabel.setBounds(560,450,90,30);
		soldByLabel.setFont(titleFont);
		soldByLabel.setVisible(false);  //need to false
		add(soldByLabel);
		
		soldByTextField=new TextField("Employee ID("+Integer.toString(entity.getUserID())+")");
		soldByTextField.setBounds(660,450,140,30);
		soldByTextField.setFont(titleFont2);
		soldByTextField.setEditable(false);
		soldByTextField.setEnabled(false);
		soldByTextField.setVisible(false); // need to false
		add(soldByTextField);
		
		totalPriceButton=new Button("Total Price");
		totalPriceButton.setBounds(225,500,125,30);
		totalPriceButton.setFont(titleFont);
		totalPriceButton.addActionListener(this);
		totalPriceButton.setVisible(false); // need to false;
		add(totalPriceButton);
		
		totalPriceTextField=new TextField();
		totalPriceTextField.setBounds(400,500,200,30);
		totalPriceTextField.setFont(titleFont);
		totalPriceTextField.setEditable(false);
		totalPriceTextField.setEnabled(false);
		totalPriceTextField.setVisible(false); //need to false
		add(totalPriceTextField);
		
		refreshButton=new Button("Refresh");
		refreshButton.setBounds(450,600,100,30);
		refreshButton.setFont(titleFont);
		refreshButton.addActionListener(this);
		refreshButton.setVisible(false);  //need to false
		add(refreshButton);
		
		sellButton=new Button("Sell");
		sellButton.setBounds(650,500,150,35);
		sellButton.setFont(titleFont1);
		sellButton.addActionListener(this);
		sellButton.setVisible(false); //need to false
		add(sellButton);
		
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
	
	public void getCustomerIDList()
	{
		try //creating customer id list in an array;
		{
			int i=1;
			ResultSet rs1=da.getData("SELECT COUNT(customerID) numberOfCustomer FROM customerinfo");
			while(rs1.next())
			{
			numberOfCustomer=rs1.getInt("numberOfCustomer");
			}
			customerIDList=new String[numberOfCustomer+1];
			customerIDList[0]="Select Customer ID-";
			//customerIDList[1]="Anonymous";
			ResultSet rs2=da.getData("SELECT customerID FROM customerinfo");
			while(rs2.next())
			{
				customerIDList[i]= Integer.toString(rs2.getInt("customerID"));
				if(customerIDList[i].equals("1"))
				{
					customerIDList[i]="Anonymous";
				}
				i++;
			}
			
		
		}
		catch(Exception ex){ex.printStackTrace();}
		
	}
		public void getMovieList()
	{
		try//creating movie list in an array;
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
	
	
	public void actionPerformed(ActionEvent e)//need to work on that
	{
		String st=e.getActionCommand();
		
		if(st.equals("Show Movie"))
		{
			movieNameLabel.setVisible(false);
			movieCombo.setVisible(false);
			showDateButton.setVisible(false);
			dateLabel.setVisible(false);
			dateCombo.setVisible(false);
			showTimeButton.setVisible(false);
			timeLabel.setVisible(false);
			timeCombo.setVisible(false);
			showHallNameButton.setVisible(false);
			hallNameLabel.setVisible(false);
			hallNameTextField.setVisible(false);
			capacityLabel.setVisible(false);
			capacityTextField.setVisible(false);
			hallTypeLabel.setVisible(false);
			hallTypeTextField.setVisible(false);
			availableSeatLabel.setVisible(false);
			availableSeatTextField.setVisible(false);
			amountOfTicketButton.setVisible(false);
			amountOfTicketCombo.setVisible(false);
			soldByLabel.setVisible(false);
			soldByTextField.setVisible(false);
			totalPriceButton.setVisible(false);
			totalPriceTextField.setVisible(false);
            refreshButton.setVisible(false); 
			sellButton.setVisible(false); 
			
			
			movieCombo.setEnabled(true);
			dateCombo.setEnabled(true);
			timeCombo.setEnabled(true);
			amountOfTicketCombo.setEnabled(true);
			
		    customerID=customerIDCombo.getSelectedItem().toString();
			System.out.println(customerID);
			
			if(customerID.equals("Select Customer ID-"))
			{
				System.out.println("You haven't selected any Customer ID,please select first");
				JOptionPane.showMessageDialog(this,"You haven't selected any Customer ID,please select first","Warning",2);
			}
			else if(customerID.equals("Anonymous"))
			{
				customer=1;
				System.out.println(customer);
				movieNameLabel.setVisible(true);
				movieCombo.setVisible(true);
				showDateButton.setVisible(true);
				refreshButton.setVisible(true);
				customerIDCombo.setEnabled(false);
			}
			else
			{
				customer=Integer.parseInt(customerID);
				movieNameLabel.setVisible(true);
				movieCombo.setVisible(true);
				showDateButton.setVisible(true);
				refreshButton.setVisible(true);
				customerIDCombo.setEnabled(false);
			}
		}
		
		
		else if(st.equals("Show Date"))
		{
			
			dateLabel.setVisible(false);
			dateCombo.setVisible(false);
			showTimeButton.setVisible(false);
			timeLabel.setVisible(false);
			timeCombo.setVisible(false);
			showHallNameButton.setVisible(false);
			hallNameLabel.setVisible(false);
			hallNameTextField.setVisible(false);
			capacityLabel.setVisible(false);
			capacityTextField.setVisible(false);
			hallTypeLabel.setVisible(false);
			hallTypeTextField.setVisible(false);
			availableSeatLabel.setVisible(false);
			availableSeatTextField.setVisible(false);
			amountOfTicketButton.setVisible(false);
			amountOfTicketCombo.setVisible(false);
			soldByLabel.setVisible(false);
			soldByTextField.setVisible(false);
			sellButton.setVisible(false); 
			totalPriceButton.setVisible(false);
			totalPriceTextField.setVisible(false);
            
			
			dateCombo.setEnabled(true);
			timeCombo.setEnabled(true);
			amountOfTicketCombo.setEnabled(true);
			
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
				 //getting showDate for dateCombo;
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
				movieCombo.setEnabled(false);
				customerIDCombo.setEnabled(false);
			}//try ends here
			catch(Exception ex){ex.printStackTrace();}
			
			
			}//else if ends here 
			
		}
		else if(st.equals("Show Time"))
		{
			timeLabel.setVisible(false);
			timeCombo.setVisible(false);
			showHallNameButton.setVisible(false);
			hallNameLabel.setVisible(false);
			hallNameTextField.setVisible(false);
			capacityLabel.setVisible(false);
			capacityTextField.setVisible(false);
			hallTypeLabel.setVisible(false);
			hallTypeTextField.setVisible(false);
			availableSeatLabel.setVisible(false);
			availableSeatTextField.setVisible(false);
			amountOfTicketButton.setVisible(false);
			amountOfTicketCombo.setVisible(false);
			soldByLabel.setVisible(false);
			soldByTextField.setVisible(false);
			sellButton.setVisible(false); 
			totalPriceButton.setVisible(false);
			totalPriceTextField.setVisible(false);
            
			timeCombo.setEnabled(true);
			amountOfTicketCombo.setEnabled(true);

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
					movieCombo.setEnabled(false);
				    customerIDCombo.setEnabled(false);
					dateCombo.setEnabled(false);
				}
				catch(Exception ex){ex.printStackTrace();}
			}
			
		}
		else if(st.equals("Show Hall Info"))
		{
			hallNameLabel.setVisible(false);
			hallNameTextField.setVisible(false);
			capacityLabel.setVisible(false);
			capacityTextField.setVisible(false);
			hallTypeLabel.setVisible(false);
			hallTypeTextField.setVisible(false);
			availableSeatLabel.setVisible(false);
			availableSeatTextField.setVisible(false);
			amountOfTicketButton.setVisible(false);
			amountOfTicketCombo.setVisible(false);
			soldByLabel.setVisible(false);
			soldByTextField.setVisible(false);
			sellButton.setVisible(false);
			totalPriceButton.setVisible(false);
			totalPriceTextField.setVisible(false);
            
			
			amountOfTicketCombo.setEnabled(true);
            
			time=timeCombo.getSelectedItem().toString();
			System.out.println(time);
			if(time.equals("Select Time-"))
			{
				System.out.println("You haven't selected any time,please select first");
				JOptionPane.showMessageDialog(this,"You haven't selected any time,please select first","Warning",2);
			}
			else if(!time.equals("Select Time-"))
			{
				
				
				try
				{
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
					hallNameTextField.setEnabled(false);
					hallNameTextField.setVisible(true);
					hallTypeLabel.setVisible(true);
					hallTypeTextField.setText(hallType);
					hallTypeTextField.setEditable(false);
					hallTypeTextField.setEnabled(false);
					hallTypeTextField.setVisible(true);
					capacityLabel.setVisible(true);
					capacityTextField.setText(Integer.toString(capacity));
					capacityTextField.setEditable(false);
					capacityTextField.setEnabled(false);
					capacityTextField.setVisible(true);
					availableSeatLabel.setVisible(true);
					availableSeatTextField.setText(Integer.toString(availableSeat));
					availableSeatTextField.setEditable(false);
					availableSeatTextField.setEnabled(false);
					availableSeatTextField.setVisible(true);
					amountOfTicketButton.setVisible(true);
					refreshButton.setVisible(true);
					timeCombo.setEnabled(false);
					movieCombo.setEnabled(false);
				    customerIDCombo.setEnabled(false);
					dateCombo.setEnabled(false);
					
				}
				catch(Exception ex){ex.printStackTrace();}
				
			}
			
		}
		else if(st.equals("Amount of Ticket"))
		{
			
			amountOfTicketCombo.setVisible(true);
			soldByLabel.setVisible(true);
			soldByTextField.setVisible(true);
			sellButton.setVisible(false);
			refreshButton.setVisible(true);
			totalPriceButton.setVisible(true);
			totalPriceTextField.setVisible(false);
            
            amountOfTicketCombo.setEnabled(true);
		}
		else if(st.equals("Total Price"))
		{
			
			if(availableSeat!=0)
			{
				if(amountOfTicketCombo.getSelectedItem().toString().equals("Select Amount-"))
				{
				   System.out.println("You haven't selected any amount,please select any amount");
				   JOptionPane.showMessageDialog(this,"You haven't selected any amount,please select any amount (1-10)","Warning",2);
			
				}
				else if(!amountOfTicketCombo.getSelectedItem().toString().equals("Select Amount-"))
				{
					seat=Integer.parseInt(amountOfTicketCombo.getSelectedItem().toString());
					try
					{
					   ResultSet rs=da.getData("SELECT (pricePerSeat*"+seat+") totalPrice FROM hallinfo WHERE hallName='"+hallName+"'");
					   while(rs.next())
					   {
						   totalPrice=rs.getInt("totalPrice");
					   }
					   
					   totalPriceTextField.setText(Integer.toString(totalPrice));
					   totalPriceTextField.setEnabled(false);
					   totalPriceTextField.setVisible(true);
					   sellButton.setVisible(true);
					   amountOfTicketCombo.setEnabled(false);
					}
					catch(Exception ex){ex.printStackTrace();}
				}
			}
			else
			{
				System.out.println("There is no available seat for this slot,try another one");
				JOptionPane.showMessageDialog(this,"There is no available seat for this slot,try another one","Warning",2);
			}
			
			
		}
		
		else if(st.equals("Refresh"))
		{
			register.sellTicketWindow.setVisible(false);
			register.sellTicketWindow=new SellTicketWindow(entity,register,optionCombo);
			register.sellTicketWindow.setVisible(true);
			
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
		else if(st.equals("Back"))
	    {
		register.homeWindow=new HomeWindow(entity,register);
		register.homeWindow.setVisible(true);
		register.sellTicketWindow.setVisible(false);
	    }
		else if(st.equals("Sell"))
		{
			if(availableSeat!=0)
			{
				if(amountOfTicketCombo.getSelectedItem().toString().equals("Select Amount-"))
				{
				System.out.println("You haven't selected any amount,please select any amount");
				JOptionPane.showMessageDialog(this,"You haven't selected any amount,please select any amount (1-10)","Warning",2);
			
				}
				else if(!amountOfTicketCombo.getSelectedItem().toString().equals("Select Amount-"))
				{
					seat=Integer.parseInt(amountOfTicketCombo.getSelectedItem().toString());
					try
					{
						ResultSet rs=da.getData("SELECT showTimeID from showtimeinfo,hallinfo WHERE showtimeinfo.hallID=hallinfo.hallID AND showtimeinfo.movieID="+movieID+" AND showtimeinfo.hallID=(SELECT hallID FROM hallinfo WHERE hallName='"+hallName+"') AND showtimeinfo.showDate='"+date+"' AND showtimeinfo.showTime='"+time+"'");
			    		while(rs.next())
						{
						showTimeID=rs.getInt("showTimeID");
						}
						da.updateDatabase("INSERT INTO soldticket (soldTicketID, movieID, showTimeID, customerID, employeeID, seat, revenue) VALUES (NULL, "+movieID+", "+showTimeID+", "+customer+", "+entity.getUserID()+", "+seat+", "+totalPrice+")");
				    	da.updateDatabase("UPDATE showtimeinfo SET availableSeat = (SELECT ((SELECT capacity FROM hallinfo WHERE hallID=(select hallID from hallinfo WHERE hallName='"+hallName+"'))-SUM(seat)) availableSeat from soldticket WHERE showTimeID="+showTimeID+") WHERE showtimeinfo.showTimeID = "+showTimeID);
				    	
						JOptionPane.showMessageDialog(this,"Ticket(s) has been sold successfully","Message",JOptionPane.INFORMATION_MESSAGE);
						register.sellTicketWindow.setVisible(false);
						register.sellTicketWindow=new SellTicketWindow(entity,register,optionCombo);
						register.sellTicketWindow.setVisible(true);
					}
					catch(Exception ex){ex.printStackTrace();}
				}
			}
			
			
			
		}
		
			
	}
	

	

}