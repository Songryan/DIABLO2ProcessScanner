using System.Diagnostics;

namespace DIABLO2ProcessScanner
{
    public partial class Form1 : Form
    {
        private MemoryService memoryService = new MemoryService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstProcesses.Items.Clear();

            foreach (var proc in Process.GetProcesses())
            {
                lstProcesses.Items.Add(proc.ProcessName);
            }
        }

        private void btnFindProcess_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                MessageBox.Show("프로세스 선택하세요");
                return;
            }

            string selectedName = lstProcesses.SelectedItem.ToString();

            var processes = Process.GetProcessesByName(selectedName);

            if (processes.Length == 0)
            {
                MessageBox.Show("프로세스 못찾음");
                return;
            }

            memoryService.Attach(processes[0]);
            MessageBox.Show("연결 성공!");
        }

        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtAddress.Text;

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("주소 입력하세요");
                    return;
                }

                // 0x 제거
                input = input.Replace("0x", "");

                IntPtr address = (IntPtr)Convert.ToInt64(input, 16);

                int value = memoryService.ReadInt32(address);

                txtResult.Text = value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
