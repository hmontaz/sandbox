namespace SysKey
{
	partial class frmSyskey
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSyskey));
			label1 = new Label();
			label2 = new Label();
			btnOK = new Button();
			btnCancel = new Button();
			btnUpdate = new Button();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			pictureBox2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.Location = new Point(85, 9);
			label1.Name = "label1";
			label1.Size = new Size(271, 55);
			label1.TabIndex = 0;
			label1.Text = "This tool will allow you to configure the Accounts Database to enable additional ecncryption, further protecting the database from compromise.";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label2.Location = new Point(85, 75);
			label2.Name = "label2";
			label2.Size = new Size(271, 30);
			label2.TabIndex = 0;
			label2.Text = "Once enabled, this encryption cannot be disabled.";
			// 
			// btnOK
			// 
			btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnOK.Location = new Point(48, 186);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 1;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancel.Location = new Point(129, 186);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 2;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnUpdate.Location = new Point(210, 186);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(75, 23);
			btnUpdate.TabIndex = 3;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(103, 108);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(130, 19);
			radioButton1.TabIndex = 6;
			radioButton1.TabStop = true;
			radioButton1.Text = "Encryption Disabled";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(103, 133);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(127, 19);
			radioButton2.TabIndex = 7;
			radioButton2.Text = "Encryption Enabled";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 9);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(67, 55);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// frmSyskey
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(368, 221);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(pictureBox2);
			Controls.Add(btnUpdate);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmSyskey";
			ShowIcon = false;
			Text = "Securing the Windows Account Database";
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button btnOK;
		private Button btnCancel;
		private Button btnUpdate;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private PictureBox pictureBox2;
	}
}