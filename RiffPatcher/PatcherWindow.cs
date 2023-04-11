namespace RiffPatcher;

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;
using System.Windows.Forms;
using System.Text;

/// <summary>
/// The main window displayed to the user
/// </summary>
public partial class PatcherWindow : Form
{
	private const string HASH = "d661606db8658adb54d5be18b3e3a3a6f07c8e738f2d78556ece42355f8e62e4";
	private const int OFFSET = 22436;
	private readonly SHA256 sha;
	private FileStream? file;

	/// <summary>
	/// Intitialize the patcher window
	/// </summary>
	public PatcherWindow()
	{
		InitializeComponent();
		sha = SHA256.Create();

		VersionLabel.Text = Version();
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

		// Check that URL is valid
		if (URLInput.Text.Length == 29)
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
	/// Patch the selected file
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event arguments</param>
	private void PatchFile(object sender, EventArgs e)
	{
		// Check if file is loaded
		if (file is null)
		{
			MessageBox.Show("File not ready", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			// Reset fields
			URLInput.Enabled = false;
			PatchButton.Enabled = false;
			URLInput.Text = string.Empty;
			URLValidLabel.Text = string.Empty;
			PatchSuccessLabel.Text = string.Empty;

			return;
		}

		// Create backup
		FileStream backup = File.Create(file.Name + ".bak");
		file.Seek(0, SeekOrigin.Begin);
		file.CopyTo(backup);
		backup.Close();

		// Get and verify data
		byte[] data = Encoding.ASCII.GetBytes(URLInput.Text);

		if (data.Length != 29)
		{
			MessageBox.Show($"Unexpected length of new data, expected 29 bytes, got {data.Length}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		// Write data
		file.Seek(OFFSET, SeekOrigin.Begin);
		file.Write(data, 0, 29);

		MessageBox.Show("Patching complete!\n\nA backup file has been created alongside the patched file. " +
			"If you choose to patch again with a new server, you will need to restore the backup file first.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	/// <summary>
	/// Shut down the window and any open resources
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Form closing event arguments</param>
	private new void Closing(object sender, FormClosingEventArgs e)
	{
		file?.Close();
	}

	/// <summary>
	/// Check if the SHA256 hash of the selected file is the same as the original
	/// </summary>
	/// <returns>True if the hashes match, otherwise false</returns>
	private bool CheckSHA256()
	{
		// Check if file is loaded
		if (file is null)
		{
			MessageBox.Show("File not ready", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		// Check hash
		string fhash = BitConverter.ToString(sha.ComputeHash(file))
			.Replace("-", "")
			.ToLower();

		return HASH == fhash;
	}

	/// <summary>
	/// Get the version string for this app
	/// </summary>
	/// <returns>The version as a string, or unknown if the version cannot be determined</returns>
	private static string Version()
	{
		Assembly? asm = Assembly.GetEntryAssembly();
		if (asm is null) return "Unknown";

		Version? ver = asm.GetName().Version;
		return ver is null ? "Unknown" : ver.ToString();
	}
}
