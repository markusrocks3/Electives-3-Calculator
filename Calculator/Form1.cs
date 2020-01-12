using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{

		Double resultValue = 0;
		String operationPerformed = "";
		bool isOperationPerformed = false;


		public Form1()
		{
			InitializeComponent();
		}

		private void button_click(object sender, EventArgs e)
		{

			if ((textbox_result.Text == "0") || (isOperationPerformed))
				textbox_result.Clear();

			isOperationPerformed = false;
			Button button = (Button)sender;
			if (button.Text == ".")
			{
				if (!textbox_result.Text.Contains("."))
					textbox_result.Text = textbox_result.Text + button.Text;
			}
			else
			{
				textbox_result.Text = textbox_result.Text + button.Text;
			}
		}

		private void operator_click(object sender, EventArgs e)
		{

			Button button = (Button)sender;

			if (resultValue != 0)
			{
				button16.PerformClick();
				operationPerformed = button.Text;
				label_operation.Text = resultValue + " " + operationPerformed;
				isOperationPerformed = true;
			}
			else
			{
				operationPerformed = button.Text;
				resultValue = Double.Parse(textbox_result.Text);
				label_operation.Text = resultValue + " " + operationPerformed;
				isOperationPerformed = true;
			}
		}

		private void button2_click(object sender, EventArgs e)
		{
			textbox_result.Text = "0";
		}

		private void button3_click(object sender, EventArgs e)
		{
			textbox_result.Text = "0";
			resultValue = 0;
		}

		private void equals_click(object sender, EventArgs e)
		{
			switch (operationPerformed)
			{
				case "+":
					textbox_result.Text=(resultValue + Double.Parse(textbox_result.Text)).ToString();
					break;
				

			}


			resultValue = Double.Parse(textbox_result.Text);
			label_operation.Text = "";
		}

		private void textbox_result_TextChanged(object sender, EventArgs e)
		{
			if ((textbox_result.Text.Trim()).StartsWith("."))
				textbox_result.Text = "0" + textbox_result.Text;
		}
	}
}
