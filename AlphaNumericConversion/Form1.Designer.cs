namespace AlphaNumeric
{
	partial class Form1
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
			this.tbNumeric = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAlpha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAlphaValidated = new System.Windows.Forms.Label();
			this.lblNumericValidated = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbNumeric
			// 
			this.tbNumeric.Location = new System.Drawing.Point(29, 56);
			this.tbNumeric.Name = "tbNumeric";
			this.tbNumeric.Size = new System.Drawing.Size(100, 20);
			this.tbNumeric.TabIndex = 0;
			this.tbNumeric.TextChanged += new System.EventHandler(this.tbNumeric_TextChanged);
			this.tbNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numeric:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "=";
			// 
			// tbAlpha
			// 
			this.tbAlpha.Location = new System.Drawing.Point(154, 56);
			this.tbAlpha.Name = "tbAlpha";
			this.tbAlpha.Size = new System.Drawing.Size(100, 20);
			this.tbAlpha.TabIndex = 3;
			this.tbAlpha.TextChanged += new System.EventHandler(this.tbAlpha_TextChanged);
			this.tbAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlpha_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(156, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "AlphaNumeric:";
			// 
			// lblAlphaValidated
			// 
			this.lblAlphaValidated.AutoSize = true;
			this.lblAlphaValidated.Location = new System.Drawing.Point(156, 83);
			this.lblAlphaValidated.Name = "lblAlphaValidated";
			this.lblAlphaValidated.Size = new System.Drawing.Size(88, 13);
			this.lblAlphaValidated.TabIndex = 5;
			this.lblAlphaValidated.Text = "lblAlphaValidated";
			// 
			// lblNumericValidated
			// 
			this.lblNumericValidated.AutoSize = true;
			this.lblNumericValidated.Location = new System.Drawing.Point(29, 83);
			this.lblNumericValidated.Name = "lblNumericValidated";
			this.lblNumericValidated.Size = new System.Drawing.Size(100, 13);
			this.lblNumericValidated.TabIndex = 6;
			this.lblNumericValidated.Text = "lblNumericValidated";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 141);
			this.Controls.Add(this.lblNumericValidated);
			this.Controls.Add(this.lblAlphaValidated);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbAlpha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNumeric);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(343, 175);
			this.MinimumSize = new System.Drawing.Size(343, 175);
			this.Name = "Form1";
			this.Text = "Convert Numeric <-> AlphaNumeric";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNumeric;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbAlpha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAlphaValidated;
		private System.Windows.Forms.Label lblNumericValidated;
	}
}

