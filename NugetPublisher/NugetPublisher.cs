using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NugetPublisher
{
    public partial class NugetPublisher : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public NugetPublisher()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "C Sharp Project File|*.csproj";
            openFileDialog1.FileName = "";
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                txtProjectFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            try
            {
                string nugetPackCommand = string.Format($"nuget.exe pack \"{txtProjectFile.Text}\"");

                if (chbBuild.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -Build");

                if (chbExcludeEmptyDirectories.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -ExcludeEmptyDirectories");

                if (chbForceEnglishOutput.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -ForceEnglishOutput");

                if (chbIncludeReferencedProjects.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -IncludeReferencedProjects");

                if (chbNoDefaultExcludes.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -NoDefaultExcludes");

                if (chbNonInteractive.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -NonInteractive");

                if (chbNoPackageAnalysis.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -NoPackageAnalysis");

                if (!string.IsNullOrWhiteSpace(txtOutputPath.Text))
                    nugetPackCommand = string.Format($"{nugetPackCommand} -OutputDirectory \"{txtOutputPath.Text}\"");

                if (chbSymbols.Checked)
                    nugetPackCommand = string.Format($"{nugetPackCommand} -Symbols");

                if (cmbConfig.SelectedItem.ToString() == "Release")
                    nugetPackCommand = string.Format($"{nugetPackCommand} -Properties Configuration=Release");

                if (!string.IsNullOrWhiteSpace(txtVersion.Text))
                    nugetPackCommand = string.Format($"{nugetPackCommand} -Version {txtVersion.Text}");

                using (StreamWriter sw = new StreamWriter("nugetcmd.bat", false))
                {
                    sw.WriteLine(nugetPackCommand);
                    sw.Flush();
                    sw.Close();
                }

                System.Diagnostics.Process cmd = new System.Diagnostics.Process();

                cmd.StartInfo.FileName = "nugetcmd.bat";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();


                richTextBox1.Text = cmd.StandardOutput.ReadToEnd();

                cmd.WaitForExit();
            }
            catch(Exception ex)
            {
                richTextBox1.Text = ex.Message;
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = ex.StackTrace;
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                string nugetPushCommand = string.Format($"nuget.exe push \"{txtPackagePath.Text}\"");

                if (chbDisableBuffering.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -DisableBuffering");

                if (chbForceEnglishOutput1.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -ForceEnglishOutput");

                if (chbNonInteractive1.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -NonInteractive");

                if (chbNoServiceEndpoint.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -NoServiceEndpoint");

                if (chbNoSymbols.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -NoSymbols");

                if (chbSkipDuplicate.Checked)
                    nugetPushCommand = string.Format($"{nugetPushCommand} -SkipDuplicate");

                if (!string.IsNullOrWhiteSpace(txtNugetSource.Text))
                    nugetPushCommand = string.Format($"{nugetPushCommand} -Source \"{txtNugetSource.Text}\"");

                if (!string.IsNullOrWhiteSpace(txtAPIKey.Text))
                    nugetPushCommand = string.Format($"{nugetPushCommand} -ApiKey \"{txtAPIKey.Text}\"");

                using (StreamWriter sw = new StreamWriter("nugetPushCommand.bat", false))
                {
                    sw.WriteLine(nugetPushCommand);
                    sw.Flush();
                    sw.Close();
                }

                System.Diagnostics.Process cmd = new System.Diagnostics.Process();

                cmd.StartInfo.FileName = "nugetPushCommand.bat";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();


                richTextBox1.Text = cmd.StandardOutput.ReadToEnd();

                cmd.WaitForExit();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = ex.StackTrace;
            }
        }

        private void btnPackageBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Nuget Package File|*.nupkg";
            openFileDialog1.FileName = "";
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtPackagePath.Text = openFileDialog1.FileName;
            }
        }

        private void NugetPublisher_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }
    }
}
