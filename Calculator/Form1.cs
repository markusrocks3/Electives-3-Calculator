using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{

	

		public Form1()
		{
			InitializeComponent();
		}

	
	
		private void button_Click(object sender, EventArgs e)
		{
			
			textbox_result.Text = textbox_result.Text + "1";
		}
	}
}
