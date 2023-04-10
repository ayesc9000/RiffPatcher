namespace RiffPatcher;

using System;
using System.Diagnostics;
using System.Windows.Forms;

public partial class PatcherWindow : Form
{
	public PatcherWindow()
	{
		InitializeComponent();
	}

	private void GitHubClicked(object sender, EventArgs e)
	{
		Process.Start("https://github.com/ayesc9000/RiffPatcher");
	}
}
