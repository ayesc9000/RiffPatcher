namespace RiffPatcher;

using System.Drawing;
using System.Windows.Forms;

partial class PatcherWindow
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
		FileButton = new Button();
		TitleLabel = new Label();
		AboutLabel = new Label();
		FileSectionLabel = new Label();
		URLInput = new TextBox();
		FileValidLabel = new Label();
		URLSectionLabel = new Label();
		URLRequirementsLabel = new Label();
		URLValidLabel = new Label();
		PatchSectionLabel = new Label();
		PatchButton = new Button();
		PatchSuccessLabel = new Label();
		InfoLabel = new Label();
		GitHubLabel = new LinkLabel();
		VersionLabel = new Label();
		HeaderPanel = new Panel();
		OpenFileDialog = new OpenFileDialog();
		HeaderPanel.SuspendLayout();
		SuspendLayout();
		// 
		// FileButton
		// 
		FileButton.Location = new Point(12, 109);
		FileButton.Name = "FileButton";
		FileButton.Size = new Size(100, 23);
		FileButton.TabIndex = 0;
		FileButton.Text = "Select file...";
		FileButton.UseVisualStyleBackColor = true;
		FileButton.Click += SelectFile;
		// 
		// TitleLabel
		// 
		TitleLabel.AutoSize = true;
		TitleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
		TitleLabel.Location = new Point(6, 9);
		TitleLabel.Name = "TitleLabel";
		TitleLabel.Size = new Size(151, 37);
		TitleLabel.TabIndex = 1;
		TitleLabel.Text = "RiffPatcher";
		// 
		// AboutLabel
		// 
		AboutLabel.AutoSize = true;
		AboutLabel.Location = new Point(12, 50);
		AboutLabel.Name = "AboutLabel";
		AboutLabel.Size = new Size(271, 15);
		AboutLabel.TabIndex = 2;
		AboutLabel.Text = "Patch your Riff Racer to use a custom game server";
		// 
		// FileSectionLabel
		// 
		FileSectionLabel.AutoSize = true;
		FileSectionLabel.Location = new Point(12, 89);
		FileSectionLabel.Name = "FileSectionLabel";
		FileSectionLabel.Size = new Size(254, 15);
		FileSectionLabel.TabIndex = 5;
		FileSectionLabel.Text = "Select the \"ParseOctane.dll\" file from Riff Racer";
		// 
		// URLInput
		// 
		URLInput.Enabled = false;
		URLInput.Location = new Point(12, 172);
		URLInput.MaxLength = 30;
		URLInput.Name = "URLInput";
		URLInput.Size = new Size(271, 23);
		URLInput.TabIndex = 7;
		URLInput.TextChanged += URLChanged;
		// 
		// FileValidLabel
		// 
		FileValidLabel.AutoSize = true;
		FileValidLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		FileValidLabel.Location = new Point(116, 114);
		FileValidLabel.Name = "FileValidLabel";
		FileValidLabel.Size = new Size(0, 13);
		FileValidLabel.TabIndex = 8;
		// 
		// URLSectionLabel
		// 
		URLSectionLabel.AutoSize = true;
		URLSectionLabel.Location = new Point(12, 152);
		URLSectionLabel.Name = "URLSectionLabel";
		URLSectionLabel.Size = new Size(137, 15);
		URLSectionLabel.TabIndex = 9;
		URLSectionLabel.Text = "Enter the new server URL";
		// 
		// URLRequirementsLabel
		// 
		URLRequirementsLabel.AutoSize = true;
		URLRequirementsLabel.Location = new Point(12, 201);
		URLRequirementsLabel.Name = "URLRequirementsLabel";
		URLRequirementsLabel.Size = new Size(235, 15);
		URLRequirementsLabel.TabIndex = 10;
		URLRequirementsLabel.Text = "The URL must be exactly 29 characters long";
		// 
		// URLValidLabel
		// 
		URLValidLabel.AutoSize = true;
		URLValidLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		URLValidLabel.Location = new Point(287, 171);
		URLValidLabel.Name = "URLValidLabel";
		URLValidLabel.Size = new Size(0, 13);
		URLValidLabel.TabIndex = 11;
		// 
		// PatchSectionLabel
		// 
		PatchSectionLabel.AutoSize = true;
		PatchSectionLabel.Location = new Point(12, 239);
		PatchSectionLabel.Name = "PatchSectionLabel";
		PatchSectionLabel.Size = new Size(156, 15);
		PatchSectionLabel.TabIndex = 13;
		PatchSectionLabel.Text = "Patch the URL in the DLL file";
		// 
		// PatchButton
		// 
		PatchButton.Enabled = false;
		PatchButton.Location = new Point(12, 259);
		PatchButton.Name = "PatchButton";
		PatchButton.Size = new Size(100, 23);
		PatchButton.TabIndex = 12;
		PatchButton.Text = "Patch!";
		PatchButton.UseVisualStyleBackColor = true;
		PatchButton.Click += PatchFile;
		// 
		// PatchSuccessLabel
		// 
		PatchSuccessLabel.AutoSize = true;
		PatchSuccessLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		PatchSuccessLabel.Location = new Point(116, 264);
		PatchSuccessLabel.Name = "PatchSuccessLabel";
		PatchSuccessLabel.Size = new Size(0, 13);
		PatchSuccessLabel.TabIndex = 14;
		// 
		// InfoLabel
		// 
		InfoLabel.AutoSize = true;
		InfoLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		InfoLabel.Location = new Point(12, 300);
		InfoLabel.Name = "InfoLabel";
		InfoLabel.Size = new Size(193, 13);
		InfoLabel.TabIndex = 15;
		InfoLabel.Text = "RiffPatcher - Made with <3 by AyesC";
		// 
		// GitHubLabel
		// 
		GitHubLabel.AutoSize = true;
		GitHubLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		GitHubLabel.Location = new Point(287, 300);
		GitHubLabel.Name = "GitHubLabel";
		GitHubLabel.Size = new Size(73, 13);
		GitHubLabel.TabIndex = 16;
		GitHubLabel.TabStop = true;
		GitHubLabel.Text = "GitHub page";
		GitHubLabel.Click += GitHubClicked;
		// 
		// VersionLabel
		// 
		VersionLabel.AutoSize = true;
		VersionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
		VersionLabel.Location = new Point(148, 30);
		VersionLabel.Name = "VersionLabel";
		VersionLabel.Size = new Size(44, 13);
		VersionLabel.TabIndex = 17;
		VersionLabel.Text = "version";
		// 
		// HeaderPanel
		// 
		HeaderPanel.BackColor = Color.White;
		HeaderPanel.Controls.Add(VersionLabel);
		HeaderPanel.Controls.Add(TitleLabel);
		HeaderPanel.Controls.Add(AboutLabel);
		HeaderPanel.Location = new Point(0, 0);
		HeaderPanel.Name = "HeaderPanel";
		HeaderPanel.Size = new Size(362, 77);
		HeaderPanel.TabIndex = 18;
		// 
		// OpenFileDialog
		// 
		OpenFileDialog.DefaultExt = "dll";
		OpenFileDialog.FileName = "ParseOctane.dll";
		OpenFileDialog.Filter = "Dynamic Link Library (*.dll)|*.dll";
		OpenFileDialog.InitialDirectory = "C:\\";
		OpenFileDialog.RestoreDirectory = true;
		OpenFileDialog.SelectReadOnly = false;
		// 
		// PatcherWindow
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(362, 322);
		Controls.Add(HeaderPanel);
		Controls.Add(FileSectionLabel);
		Controls.Add(FileButton);
		Controls.Add(FileValidLabel);
		Controls.Add(URLSectionLabel);
		Controls.Add(URLInput);
		Controls.Add(URLRequirementsLabel);
		Controls.Add(URLValidLabel);
		Controls.Add(PatchSectionLabel);
		Controls.Add(PatchButton);
		Controls.Add(PatchSuccessLabel);
		Controls.Add(InfoLabel);
		Controls.Add(GitHubLabel);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "PatcherWindow";
		SizeGripStyle = SizeGripStyle.Hide;
		Text = "RiffPatcher";
		FormClosing += Closing;
		HeaderPanel.ResumeLayout(false);
		HeaderPanel.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button FileButton;
	private Label TitleLabel;
	private Label AboutLabel;
	private Label FileSectionLabel;
	private TextBox URLInput;
	private Label FileValidLabel;
	private Label URLSectionLabel;
	private Label URLRequirementsLabel;
	private Label URLValidLabel;
	private Label PatchSectionLabel;
	private Button PatchButton;
	private Label PatchSuccessLabel;
	private Label InfoLabel;
	private LinkLabel GitHubLabel;
	private Label VersionLabel;
	private Panel HeaderPanel;
	private OpenFileDialog OpenFileDialog;
}
