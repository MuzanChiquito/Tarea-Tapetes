/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 13/11/2024
 * Time: 07:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tapete___
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		void Button1Click(object sender, EventArgs e)
		{
			int CoA, CoLP, CoFD, NoP, CoLA, CoHD, CoMO, Total;
			CoA = int.Parse(textBox1.Text);
			CoLP = int.Parse(textBox2.Text);
			CoFD =  int.Parse(textBox3.Text);
			NoP =  int.Parse(textBox4.Text);
			CoLA =  int.Parse(textBox5.Text);
			CoHD =  int.Parse(textBox6.Text);
			CoMO =  int.Parse(textBox7.Text);
			
			CoA = CoA * 100;
			CoLP = CoLP * 239;
			CoFD = CoFD * 136;
			NoP = NoP * 200;
			CoLA = CoLA * 13;
			CoHD = CoHD * 200;
			Total = CoA + CoLP + CoFD + NoP + CoLA + CoHD + CoMO;
			label8.Text = Total.ToString();
		}
		
	}
}
