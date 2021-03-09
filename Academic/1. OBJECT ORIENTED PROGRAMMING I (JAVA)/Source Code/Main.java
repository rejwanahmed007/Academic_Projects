
public class Main
{
	public static void main(String args[])
	{
		Register register=new Register();
		register.signInWindow=new SignInWindow(register);
		register.signInWindow.setVisible(true);
	
	}
}
