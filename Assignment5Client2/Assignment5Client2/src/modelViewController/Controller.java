package modelViewController;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import javax.swing.table.TableColumn;
import javax.swing.table.TableColumnModel;
import javax.xml.crypto.Data;

import org.tempuri.HyggeServiceSoapProxy;


public class Controller  {
	
	private CronusFrame cronusFrame;
	HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();
	
	
	public Controller(CronusFrame cronusFrame) {
		this.cronusFrame = cronusFrame;
		//declareListeners();
		
	}
	
	public Controller() {
		
	}
	
	/*public void declareListeners() {
		cronusFrame.getComboBox().addActionListener(new ActionListener() {
			
			public void  actionPerformed(ActionEvent e) {
				
				try {
					String response = cronusFrame.getComboBox().getSelectedItem().toString();
					
					Object[][] tableArray = proxy.getTablesAsList(response);
					addTable(cronusFrame.getTableData(), tableArray, allHeaders());
					
					
				} catch (RemoteException el) {
					//TODO Auto-generated catch block
					el.printStackTrace();
				}
				
			}
		});
	}*/
	
	public void addTable(JTable table, Object[][] array, String[] headers) {
		Object[][] objects = array;
		DefaultTableModel model = new DefaultTableModel();
		model.setColumnCount(objects[0].length);
		
		table.setModel(model);
		
		for(int i = 0; i < headers.length; i++) {
			JTableHeader tHeader = table.getTableHeader();
			TableColumnModel tableColumnModel = tHeader.getColumnModel();
			TableColumn tc = tableColumnModel.getColumn(i);
			tc.setHeaderValue(headers[i]);
			tc.setMinWidth(300);
			tHeader.repaint();
			
		}
		
		for(int i = 0; i < objects.length; i++) {
			Object[] obj = objects[i];
			DefaultTableModel tableModel = (DefaultTableModel) table.getModel();
			tableModel.addRow(obj);
			
		}
		table.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);
		
	}
	
	public String[] allHeaders() {
		String response1 = cronusFrame.getComboBox().getSelectedItem().ToString();
		
		switch (response1) {  
		case "See Metadata for the Employee Tables and Related Rables":
			return personHeaders;
		case "See Information about Employees and their Relatives":
			return educationHeaders;
		case "See Information about the Employees that have been absent due to Sickness in the Year of 2004":
			return industryHeaders;
		case "See First Name of the Employee that has been Absent the most":
			return interestHeaders;
		case "See all Keys":
			return loginsHeaders;
		case "See all Indexes":
			return relationshipHeaders;
		case "See all Table_Constraints":
			return educationIndustryHeaders;
		case "See all Tables in the Database Solution One":
			return null;
		case "See all Tables in the Database Solution Two":
			return null;
		case "See all Columns of the Employee Table Solution One":
			return null;
		case "See all Columns of the Employee Table Solution Two":
			return null;
			
			
			
			

		}
		return null;

	}


	}
	
/* 


comboBox.addItem("See all columns of the Employee table solution two"); */
	

	


