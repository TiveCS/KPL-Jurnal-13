namespace modul13_1302204090
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_username = new System.Windows.Forms.TextBox();
			this.textBox_filePath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label_output = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(67, 160);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(94, 29);
			this.buttonSubmit.TabIndex = 0;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "username";
			// 
			// textBox_username
			// 
			this.textBox_username.Location = new System.Drawing.Point(67, 83);
			this.textBox_username.Name = "textBox_username";
			this.textBox_username.Size = new System.Drawing.Size(218, 27);
			this.textBox_username.TabIndex = 2;
			// 
			// textBox_filePath
			// 
			this.textBox_filePath.Location = new System.Drawing.Point(343, 83);
			this.textBox_filePath.Name = "textBox_filePath";
			this.textBox_filePath.Size = new System.Drawing.Size(231, 27);
			this.textBox_filePath.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(343, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "file path";
			// 
			// label_output
			// 
			this.label_output.AutoSize = true;
			this.label_output.Location = new System.Drawing.Point(343, 164);
			this.label_output.Name = "label_output";
			this.label_output.Size = new System.Drawing.Size(58, 20);
			this.label_output.TabIndex = 5;
			this.label_output.Text = "Output:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label_output);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_filePath);
			this.Controls.Add(this.textBox_username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSubmit);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button buttonSubmit;
		private Label label1;
		private TextBox textBox_username;
		private TextBox textBox_filePath;
		private Label label2;
		private Label label_output;
	}
}