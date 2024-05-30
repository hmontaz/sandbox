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
	public partial class frmSyskey : Form
	{
		public frmSyskey()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ShowForm();
		}


		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ShowForm();
		}

		private void ShowForm()
		{
			var form = new frmStartupKey();
			form.Succeeded += StartupKey_Succeeded;
			form.ShowDialog();
		}

		private void StartupKey_Succeeded(object? sender, EventArgs e)
		{
			this.Close();
		}
	}
}
