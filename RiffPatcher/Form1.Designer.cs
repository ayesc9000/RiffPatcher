namespace RiffPatcher;

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
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		button2 = new Button();
		label9 = new Label();
		label10 = new Label();
		linkLabel1 = new LinkLabel();
		label11 = new Label();
		SuspendLayout();
		// 
		// button1
		// 
		button1.Location = new Point(12, 107);
		button1.Name = "button1";
		button1.Size = new Size(100, 23);
		button1.TabIndex = 0;
		button1.Text = "Select file...";
		button1.UseVisualStyleBackColor = true;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
		label1.Location = new Point(7, 9);
		label1.Name = "label1";
		label1.Size = new Size(151, 37);
		label1.TabIndex = 1;
		label1.Text = "RiffPatcher";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(12, 51);
		label2.Name = "label2";
		label2.Size = new Size(271, 15);
		label2.TabIndex = 2;
		label2.Text = "Patch your Riff Racer to use a custom game server";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(12, 87);
		label3.Name = "label3";
		label3.Size = new Size(254, 15);
		label3.TabIndex = 5;
		label3.Text = "Select the \"ParseOctane.dll\" file from Riff Racer";
		// 
		// textBox1
		// 
		textBox1.Location = new Point(12, 165);
		textBox1.MaxLength = 30;
		textBox1.Name = "textBox1";
		textBox1.Size = new Size(271, 23);
		textBox1.TabIndex = 7;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		label4.Location = new Point(116, 112);
		label4.Name = "label4";
		label4.Size = new Size(35, 13);
		label4.TabIndex = 8;
		label4.Text = "Valid!";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(12, 145);
		label5.Name = "label5";
		label5.Size = new Size(137, 15);
		label5.TabIndex = 9;
		label5.Text = "Enter the new server URL";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(12, 194);
		label6.Name = "label6";
		label6.Size = new Size(217, 60);
		label6.TabIndex = 10;
		label6.Text = "The URL must meet these requirements:\r\n  - Exactly 30 characters long\r\n  - Must begin with \"https://\"\r\n  - Must end with a forward slash \"/\"";
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		label7.Location = new Point(287, 171);
		label7.Name = "label7";
		label7.Size = new Size(35, 13);
		label7.TabIndex = 11;
		label7.Text = "Valid!";
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Location = new Point(12, 271);
		label8.Name = "label8";
		label8.Size = new Size(156, 15);
		label8.TabIndex = 13;
		label8.Text = "Patch the URL in the DLL file";
		// 
		// button2
		// 
		button2.Location = new Point(12, 291);
		button2.Name = "button2";
		button2.Size = new Size(100, 23);
		button2.TabIndex = 12;
		button2.Text = "Patch!";
		button2.UseVisualStyleBackColor = true;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		label9.Location = new Point(116, 296);
		label9.Name = "label9";
		label9.Size = new Size(49, 13);
		label9.TabIndex = 14;
		label9.Text = "Success!";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		label10.Location = new Point(12, 335);
		label10.Name = "label10";
		label10.Size = new Size(193, 13);
		label10.TabIndex = 15;
		label10.Text = "RiffPatcher - Made with <3 by AyesC";
		// 
		// linkLabel1
		// 
		linkLabel1.AutoSize = true;
		linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		linkLabel1.Location = new Point(277, 335);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(73, 13);
		linkLabel1.TabIndex = 16;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "GitHub page";
		// 
		// label11
		// 
		label11.AutoSize = true;
		label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		label11.Location = new Point(149, 28);
		label11.Name = "label11";
		label11.Size = new Size(44, 13);
		label11.TabIndex = 17;
		label11.Text = "version";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(362, 357);
		Controls.Add(label11);
		Controls.Add(linkLabel1);
		Controls.Add(label10);
		Controls.Add(label9);
		Controls.Add(label8);
		Controls.Add(button2);
		Controls.Add(label7);
		Controls.Add(label6);
		Controls.Add(label5);
		Controls.Add(label4);
		Controls.Add(textBox1);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(button1);
		Name = "Form1";
		Text = "RiffPatcher";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button button1;
	private Label label1;
	private Label label2;
	private Label label3;
	private TextBox textBox1;
	private Label label4;
	private Label label5;
	private Label label6;
	private Label label7;
	private Label label8;
	private Button button2;
	private Label label9;
	private Label label10;
	private LinkLabel linkLabel1;
	private Label label11;
}
