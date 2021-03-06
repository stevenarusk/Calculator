using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		float num = 0;
		char c = ' ';

		//Concatenates string with displayed text, and updates display
		public void Display(string key)
		{
			textBoxOutput.Text = textBoxOutput.Text + key;
		}

		//Performs basic maths operations, displays output
		public void Calculate()
		{
			if (c == '+')
			{
				textBoxOutput.Text = (num + float.Parse(textBoxOutput.Text)).ToString();
			}
			else if (c == '-')
			{
				textBoxOutput.Text = (num - float.Parse(textBoxOutput.Text)).ToString();
			}
			else if (c == 'x')
			{
				textBoxOutput.Text = (num * float.Parse(textBoxOutput.Text)).ToString();
			}
			else if (c == '/')
			{
				textBoxOutput.Text = (num / float.Parse(textBoxOutput.Text)).ToString();
			}
		}

		//Clears output
		public void Clear()
		{
			textBoxOutput.Text = "";
			c = ' ';
		}

		//Simulates rolling a polyhedral die (As used in tabletop RPG games)
		public void Roll(int sides)
		{
			var rand = new Random();
			textBoxOutput.Text = (rand.Next(1, sides + 1)).ToString();
		}

		//Button event handlers, pass appropriate string to display method
		private void button1_Click(object sender, EventArgs e)
		{ Display("1"); }

		private void button2_Click(object sender, EventArgs e)
		{ Display("2"); }

		private void button3_Click(object sender, EventArgs e)
		{ Display("3"); }

		private void button4_Click(object sender, EventArgs e)
		{ Display("4"); }

		private void button5_Click(object sender, EventArgs e)
		{ Display("5"); }

		private void button6_Click(object sender, EventArgs e)
		{ Display("6"); }

		private void button7_Click(object sender, EventArgs e)
		{ Display("7"); }

		private void button8_Click(object sender, EventArgs e)
		{ Display("8"); }

		private void button9_Click(object sender, EventArgs e)
		{ Display("9"); }

		private void button0_Click(object sender, EventArgs e)
		{ Display("0"); }

		private void buttonDecimal_Click(object sender, EventArgs e)
		{ Display("."); }

		//Calls calculate method when equals button is clicked
		private void buttonEquals_Click(object sender, EventArgs e)
		{
			Calculate();
		}

		//Clears display, saves last displayed float, and intended maths operation
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			num = float.Parse(textBoxOutput.Text);
			textBoxOutput.Clear();
			textBoxOutput.Focus();
			c = '+';
		}
		private void buttonSubtract_Click(object sender, EventArgs e)
		{
			num = float.Parse(textBoxOutput.Text);
			textBoxOutput.Clear();
			textBoxOutput.Focus();
			c = '-';
		}
		private void buttonMultiply_Click(object sender, EventArgs e)
		{
			num = float.Parse(textBoxOutput.Text);
			textBoxOutput.Clear();
			textBoxOutput.Focus();
			c = 'x';
		}
		private void buttonDivide_Click(object sender, EventArgs e)
		{
			num = float.Parse(textBoxOutput.Text);
			textBoxOutput.Clear();
			textBoxOutput.Focus();
			c = '/';
		}

		//Calls clear method to clear output
		private void buttonClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		//Rollplaying dice event handlers
		private void buttond4_Click(object sender, EventArgs e)
		{ Roll(4); }

		private void buttond6_Click(object sender, EventArgs e)
		{ Roll(6); }

		private void buttond8_Click(object sender, EventArgs e)
		{ Roll(8); }

		private void buttond10_Click(object sender, EventArgs e)
		{ Roll(10); }

		private void buttond12_Click(object sender, EventArgs e)
		{ Roll(12); }

		private void buttond20_Click(object sender, EventArgs e)
		{ Roll(20); }
	}
}
