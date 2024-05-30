using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysKey
{
	public partial class frmStartupKey : Form
	{
		public event EventHandler Succeeded;
		public frmStartupKey()
		{
			InitializeComponent();
			//SuppressRadioButtonChange = true;
			radioButton1.Checked = true;
			//SuppressRadioButtonChange = false;
			UpdateButtons();
		}

		//public bool SuppressRadioButtonChange { get; private set; }

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			//UpdateRadioButtons("Group 1", sender as RadioButton);
			UpdatePanels();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			//UpdateRadioButtons("Group 1", sender as RadioButton);
			UpdatePanels();
		}

		private void UpdatePanels()
		{
			groupBox1.Enabled = radioButton1.Checked;
			groupBox2.Enabled = radioButton2.Checked;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void UpdateButtons()
		{
			btnOk.Enabled = textBox1.Text == textBox2.Text && textBox1.Text != "";
			btnCancel.Enabled = true;
			btnUpdate.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			SetKey();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			SetKey();
		}
		private void SetKey()
		{
			var form = new frmSuccess();
			form.FormClosed += frmSuccess_FormClosed;
			form.ShowDialog();
		}
		/*private void UpdateRadioButtons(string groupName, RadioButton radioButton)
		{
			if (SuppressRadioButtonChange) return;
			var value = SuppressRadioButtonChange;
			SuppressRadioButtonChange = true;
			var @checked = radioButton.Checked;

			if (groupName == "Group 1")
			{
				radioButton1.Checked = false;
				radioButton2.Checked = false;
			}

			radioButton.Checked = @checked;

			SuppressRadioButtonChange = value;
		}*/

		private void frmSuccess_FormClosed(object? sender, FormClosedEventArgs e)
		{
			//this.Close();
			this.InvokeSucceeded();
		}

		private void InvokeSucceeded()
		{
			if (Succeeded != null) Succeeded.Invoke(this, new EventArgs());
		}
	}
}
