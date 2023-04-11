namespace RiffPatcher;

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

/// <summary>
/// The main window displayed to the user
/// </summary>
public partial class PatcherWindow : Form
{
	private const string HASH = "d661606db8658adb54d5be18b3e3a3a6f07c8e738f2d78556ece42355f8e62e4";
	private const int OFFSET = 22436;
	private FileStream? file;
	private SHA256 sha;

	/// <summary>
	/// Intitialize the patcher window
	/// </summary>
	public PatcherWindow()
	{
		InitializeComponent();
		sha = SHA256.Create();
	}

	/// <summary>
	/// Open the GitHub repo for RiffPatcher
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event arguments</param>
	private void GitHubClicked(object sender, EventArgs e)
	{
		Process.Start("explorer", "https://github.com/ayesc9000/RiffPatcher");
	}

	/// <summary>
	/// Ask the user to select a file, and check that it is valid
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event arguments</param>
	private void SelectFile(object sender, EventArgs e)
	{
		// Get new file
		if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
		file?.Close();
		file = File.Open(OpenFileDialog.FileName, FileMode.Open);

		// Reset fields
		URLInput.Enabled = false;
		PatchButton.Enabled = false;
		URLInput.Text = string.Empty;
		URLValidLabel.Text = string.Empty;
		PatchSuccessLabel.Text = string.Empty;

		// Check if hash is valid
		if (!CheckSHA256())
		{
			FileValidLabel.Text = "Invalid/modified file";
			FileValidLabel.ForeColor = Color.Red;
			return;
		}

		// Setup fields
		URLInput.Enabled = true;
		FileValidLabel.Text = "Valid file";
		FileValidLabel.ForeColor = Color.Green;
	}

	/// <summary>
	/// Check if the contents of the URL input are valid
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event arguments</param>
	private void URLChanged(object sender, EventArgs e)
	{
		// Reset fields
		PatchButton.Enabled = false;
		URLValidLabel.Text = string.Empty;
		PatchSuccessLabel.Text = string.Empty;

		// URL tests
		bool length = URLInput.Text.Length == 30;
		bool start = URLInput.Text.StartsWith("https://");
		bool end = URLInput.Text.EndsWith("/");

		// Check that URL is valid
		if (length && start && end)
		{
			PatchButton.Enabled = true;
			URLValidLabel.Text = "Valid URL";
			URLValidLabel.ForeColor = Color.Green;
			return;
		}

		URLValidLabel.Text = "Invalid URL";
		URLValidLabel.ForeColor = Color.Red;
	}

	/// <summary>
	/// Check if the SHA256 hash of the selected file is the same as the original
	/// </summary>
	/// <returns>True if the hashes match, otherwise false</returns>
	private bool CheckSHA256()
	{
		string fhash = BitConverter.ToString(sha.ComputeHash(file))
			.Replace("-", "")
			.ToLower();

		return HASH == fhash;
	}
}
