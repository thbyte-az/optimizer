using System.Diagnostics;

namespace PC_Optimizer
{
    public partial class Form3 : Form
    {
        bool msdown;

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define the commands
            string command = "powercfg -duplicatescheme 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c"; // First command
            string commandd = "control powercfg.cpl"; // Second command

            // Set up the process start information for the first command
            ProcessStartInfo processStartInfo1 = new ProcessStartInfo("cmd.exe", "/C " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the first process
            using (Process process1 = Process.Start(processStartInfo1))
            {
                // Read the output (if needed)
                string output = process1.StandardOutput.ReadToEnd();
                process1.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Plan uğurla tətbiq edildi.Planı seçmək üçün Control Panel açılır."); // Message after the first command
            }

            // Set up the process start information for the second command
            ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe", "/C " + commandd)
            {
                UseShellExecute = true, // UseShellExecute must be true to open control panel items
                CreateNoWindow = false // Show the command window
            };

            // Start the second process
            using (Process process2 = Process.Start(processStartInfo2))
            {
                // No need to read output in this case
                process2.WaitForExit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define the commands
            string command = "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61"; // First command
            string commandd = "control powercfg.cpl"; // Second command

            // Set up the process start information for the first command
            ProcessStartInfo processStartInfo1 = new ProcessStartInfo("cmd.exe", "/C " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the first process
            using (Process process1 = Process.Start(processStartInfo1))
            {
                // Read the output (if needed)
                string output = process1.StandardOutput.ReadToEnd();
                process1.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Plan uğurla tətbiq edildi.Planı seçmək üçün Control Panel açılır."); // Message after the first command
            }

            // Set up the process start information for the second command
            ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe", "/C " + commandd)
            {
                UseShellExecute = true, // UseShellExecute must be true to open control panel items
                CreateNoWindow = false // Show the command window
            };

            // Start the second process
            using (Process process2 = Process.Start(processStartInfo2))
            {
                // No need to read output in this case
                process2.WaitForExit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ram = 380000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ram = 400000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ram = 600000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ram = 800000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string ram = "c00000";

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ram = 1000000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ram = 1800000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ram = 2000000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ram = 1800000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ram = 4000000;

            // Define the PowerShell command to change the registry value
            string command = "Set-ItemProperty -Path 'HKLM:\\SYSTEM\\ControlSet001\\Control' -Name 'SvcHostSplitThresholdInKB' -Value " + ram + " -Type DWord";
            // Set up the process start information for PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true // Change to false if you want to see the command window
            };

            // Start the process
            using (Process process = Process.Start(processStartInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Optional: Show output in a message box
                MessageBox.Show("Ayar uğurlu şəkildə tətbiq edildi");
            }
        }



        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (msdown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            msdown = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            msdown = false;
        }


        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
