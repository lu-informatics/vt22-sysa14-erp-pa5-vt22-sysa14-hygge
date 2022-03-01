package modelViewController;

import java.rmi.RemoteException;

import org.tempuri.HyggeServiceSoapProxy;

public class Client2 {

	public static void main(String[] args) {
		HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();
		
		String test;
		try {
			
			
			test = proxy.helloWorld();
			System.out.println(test);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

}
