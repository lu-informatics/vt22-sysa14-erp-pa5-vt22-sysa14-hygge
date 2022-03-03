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

public class Controller {
	
	private String[] employeeMetaDataContentsOneHeader = new String[] { "First Name", "Last Name", "Job Title", "E-Mail" };
	
	private String[] employeeMetaDataContentsTwoHeader = new String[] { "Employee No_", "Cause of Absence Code","From Date"};
	
	private String[] EmployeeMetaDataContentsThreeHeader = new String[] { "Employee No_", "Qualification Code", "Description"  };
	
	private String[] EmployeeMetaDataContentsFourHeader = new String[] { "Employee No_", "Line No_", "Relative Code" };
	
	private String[] EmployeeMetaDataContentsFiveHeader = new String[] { "Code", "Description" };
	
	private String[] EmployeeMetaDataContentsSixHeader = new String[] { "TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" };
	
	private String[] EmployeeMetaDataContentsSevenHeader = new String[] {"TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" };
	
	private String[] EmployeeMetaDataContentsEightHeader = new String[]  {"TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" }; 
	
	private String[] EmployeeMetaDataContentsNineHeader = new String[]  {"TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" };
	
	private String[] EmployeeMetaDataContentsTenHeader = new String[]  {"TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" };
	
	private String[]  EmployeesRelativesHeader = new String[]  {"First_Name", "Last Name", "Birth Date", "First Name", "Last Name", "Job Title", "Relative Code"};
	
	private String[]  EmployeesSick2004Header = new String[]  {"Description", "From Date", "First Name", "Last Name",  "Job Title",};
	
	
	
	
	private String[]  EmployeeMostAbsentHeaders = new String[]  {"Descriptio"};
	
	private String[]  AllKeysHeaders = new String[]  {"Description", "From Date", "First Name", "Last Name",  "Job Title",};
	
	private String[]  AllIndexesHeader = new String[]  {"Description", "From Date", "First Name", "Last Name",  "Job Title",};
	
	private String[]  AllTableConstraintsHeader = new String[]  {"CONSTRAINT_NAME", "CONSTRAINT_TYPE"};
	
	
	
	private String[]  AllTablesInDBOneHeader = new String[]  {"TABLE_NAME"};
	
	private String[]  AllTablesInDBTwoHeader = new String[] {"BASE NAME"};
	
	private String[] AllColumnsEmployeeOneHeader = new String[]  {"COLUMN_NAME"};
	
	private String[] AllColumnsEmployeeTwoHeader = new String[]  {"name"};
	
	
	

	private CronusFrame cronusFrame;
	HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();

	public Controller(CronusFrame cronusFrame) {
		this.cronusFrame = cronusFrame;
		 declareListeners();

	}

	public Controller() {

	}

	public void declareListeners() {
		cronusFrame.getComboBox().addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {

				try {
					String response = cronusFrame.getComboBox().getSelectedItem().toString();

					Object[][] tableArray = proxy.getTableAsList(response);
					addTable(cronusFrame.getTable(), tableArray, allHeaders());
				} catch (RemoteException el) {
					// TODO Auto-generated catch block
					el.printStackTrace();
				}

			}
		});
	}

	public void addTable(JTable table, Object[][] array, String[] headers) {
		Object[][] objects = array;
		DefaultTableModel model = new DefaultTableModel();
		model.setColumnCount(objects[0].length);

		table.setModel(model);

		for (int i = 0; i < headers.length; i++) {
			JTableHeader tHeader = table.getTableHeader();
			TableColumnModel tableColumnModel = tHeader.getColumnModel();
			TableColumn tc = tableColumnModel.getColumn(i);
			tc.setHeaderValue(headers[i]);
			tc.setMinWidth(300);
			tHeader.repaint();

		}

		for (int i = 0; i < objects.length; i++) {
			Object[] obj = objects[i];
			DefaultTableModel tableModel = (DefaultTableModel) table.getModel();
			tableModel.addRow(obj);

		}
		table.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);

	}

	public String[] allHeaders() {
		String response1 = cronusFrame.getComboBox().getSelectedItem().toString();

		switch (response1) {
		case "See Metadata for the Employee Tables and Related Tables (one)":
			return  employeeMetaDataContentsOneHeader;
		case "See Metadata for the Employee Tables and Related Tables (two)":
			return employeeMetaDataContentsTwoHeader;
		case "See Metadata for the Employee Tables and Related Tables (three)":
			return EmployeeMetaDataContentsThreeHeader;

		case "See Metadata for the Employee Tables and Related Tables (four)":
			return  EmployeeMetaDataContentsFourHeader;

		case "See Metadata for the Employee Tables and Related Tables (five)":
			return  EmployeeMetaDataContentsFiveHeader;

		case "See Metadata for the Employee Tables and Related Tables (six)":
			return  EmployeeMetaDataContentsSixHeader;

		case "See Metadata for the Employee Tables and Related Tables (seven)":
			return  EmployeeMetaDataContentsSevenHeader;

		case "See Metadata for the Employee Tables and Related Tables (eight)":
			return  EmployeeMetaDataContentsEightHeader;

		case "See Metadata for the Employee Tables and Related Tables (nine)":
			return  EmployeeMetaDataContentsNineHeader;

		case "See Metadata for the Employee Tables and Related Tables (ten)":
			return  EmployeeMetaDataContentsTenHeader;
		case "See Information about Employees and their Relatives":
			return EmployeesRelativesHeader;
		case "See Information about the Employees that have been absent due to Sickness in the Year of 2004":
			return EmployeesSick2004Header;
		case "See First Name of the Employee that has been Absent the most":
			return  EmployeeMostAbsentHeaders;
		case "See all Keys":
			return AllKeysHeaders;
		case "See all Indexes":
			return   AllIndexesHeader;
		case "See all Table_Constraints":
			return  AllTableConstraintsHeader;
		case "See all Tables in the Database Solution One":
			return AllTablesInDBOneHeader;
		case "See all Tables in the Database Solution Two":
			return  AllTablesInDBTwoHeader;
		case "See all Columns of the Employee Table Solution One":
			return  AllColumnsEmployeeOneHeader;
		case "See all Columns of the Employee Table Solution Two":
			return  AllColumnsEmployeeTwoHeader;

		}
		return null;

	}

}
