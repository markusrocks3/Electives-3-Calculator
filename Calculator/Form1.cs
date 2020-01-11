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

		
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

	
		private void button_Click(object sender, EventArgs e)
		{
			textbox_result.Text = textbox_result + "1";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
