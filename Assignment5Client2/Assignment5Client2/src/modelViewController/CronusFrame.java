package modelViewController;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.JTableHeader;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import java.awt.Color;
import javax.swing.JTabbedPane;
import javax.swing.JLabel;
import java.awt.SystemColor;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class CronusFrame extends JFrame {
	

	private JPanel contentPane;
	private JTable table;
	private JComboBox comboBox;
	private JTableHeader jTableHeader;


	/**
	 * Create the frame.
	 */
	public CronusFrame() {
		setBackground(SystemColor.activeCaption);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 720, 548);
		contentPane = new JPanel();
		contentPane.setBackground(SystemColor.inactiveCaption);
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		JLabel lblNewLabel = new JLabel("Please select a value : ");
		lblNewLabel.setBounds(22, 67, 168, 14);
		contentPane.add(lblNewLabel);

		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(22, 120, 655, 283);
		contentPane.add(scrollPane);
		this.setVisible(true);

		table = new JTable();
		scrollPane.setViewportView(table);

		comboBox = new JComboBox();
		
		comboBox.setBackground(SystemColor.menu);
		comboBox.setBounds(22, 87, 655, 22);
		contentPane.add(comboBox);
		comboBox.addItem("See Metadata for the Employee Tables and Related Tables");
		comboBox.addItem("See Information about Employees and their Relatives");
		comboBox.addItem("See Information about the Employees that have been Absent due to Sickness in the Year of 2004");
		comboBox.addItem("See first Name of the Employee that has been Absent the most");
		comboBox.addItem("See all Keys");
		comboBox.addItem("See all Indexes");
		comboBox.addItem("See all table_constraints");
		comboBox.addItem("See all Tables in the Database Solution One");
		comboBox.addItem("See all Tables in the Database Solution Two");
		comboBox.addItem("See all Columns of the Employee Table Solution One");
		comboBox.addItem("See all Columns of the Employee Table Solution Two");
		
				
		
	}

	public JPanel getContentPane() {
		return contentPane;
	}

	public JTable getTable() {
		return table;
	}

	public JComboBox getComboBox() {
		return comboBox;
	}



	public void setTable(JTable table) {
		this.table = table;
	}

	public void setComboBox(JComboBox comboBox) {
		this.comboBox = comboBox;
	}
	
	
	
	
}
