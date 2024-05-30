namespace SysKey
{
	partial class frmStartupKey
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			radioButton1 = new RadioButton();
			groupBox2 = new GroupBox();
			panel1 = new Panel();
			radioButton4 = new RadioButton();
			label4 = new Label();
			radioButton3 = new RadioButton();
			label5 = new Label();
			radioButton2 = new RadioButton();
			btnOk = new Button();
			btnCancel = new Button();
			btnUpdate = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(296, 146);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Location = new Point(91, 102);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '●';
			textBox2.Size = new Size(199, 23);
			textBox2.TabIndex = 5;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(91, 73);
			textBox1.Name = "textBox1";
			textBox1.PasswordChar = '●';
			textBox1.Size = new Size(199, 23);
			textBox1.TabIndex = 4;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(25, 102);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 3;
			label3.Text = "Confirm:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 76);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 2;
			label2.Text = "Password:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.Location = new Point(25, 22);
			label1.Name = "label1";
			label1.Size = new Size(265, 35);
			label1.TabIndex = 1;
			label1.Text = "Requires a password to be entered during system start.";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(24, 12);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(116, 19);
			radioButton1.TabIndex = 0;
			radioButton1.Text = "Password Startup";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(panel1);
			groupBox2.Location = new Point(12, 164);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(296, 171);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(radioButton4);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(radioButton3);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(6, 25);
			panel1.Name = "panel1";
			panel1.Size = new Size(284, 140);
			panel1.TabIndex = 3;
			// 
			// radioButton4
			// 
			radioButton4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			radioButton4.Location = new Point(19, 58);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(132, 19);
			radioButton4.TabIndex = 2;
			radioButton4.TabStop = true;
			radioButton4.Text = "Store Startup key Locally";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label4.Location = new Point(41, 25);
			label4.Name = "label4";
			label4.Size = new Size(240, 30);
			label4.TabIndex = 3;
			label4.Text = "Requires a floppy disk to be insered during system start.";
			// 
			// radioButton3
			// 
			radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			radioButton3.Location = new Point(19, 3);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(132, 19);
			radioButton3.TabIndex = 1;
			radioButton3.TabStop = true;
			radioButton3.Text = "Store Startup key on Floppy Disk";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label5.Location = new Point(41, 80);
			label5.Name = "label5";
			label5.Size = new Size(240, 49);
			label5.TabIndex = 3;
			label5.Text = "Stores a key as part of the operating system, and no interaction is required during system start.";
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(24, 163);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(173, 19);
			radioButton2.TabIndex = 0;
			radioButton2.Text = "System Generated Password";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// btnOk
			// 
			btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnOk.Location = new Point(71, 357);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(75, 23);
			btnOk.TabIndex = 1;
			btnOk.Text = "OK";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnCancel.Location = new Point(152, 357);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnUpdate.Location = new Point(233, 357);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(75, 23);
			btnUpdate.TabIndex = 2;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// frmStartupKey
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 392);
			Controls.Add(btnUpdate);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "frmStartupKey";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Startup Key";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private RadioButton radioButton1;
		private Label label1;
		private Label label3;
		private Label label2;
		private TextBox textBox2;
		private TextBox textBox1;
		private GroupBox groupBox2;
		private RadioButton radioButton2;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private Panel panel1;
		private Label label4;
		private Label label5;
		private Button btnOk;
		private Button btnCancel;
		private Button btnUpdate;
	}
}