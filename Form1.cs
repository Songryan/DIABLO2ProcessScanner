using System.Diagnostics;

namespace DIABLO2ProcessScanner
{
    public partial class Form1 : Form
    {
        private MemoryService memoryService = new MemoryService();

        // 실행중인 프로세스들.
        private List<Process> d2rProcesses = new List<Process>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstProcesses.Items.Clear();
            d2rProcesses.Clear();

            var processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                if (proc.ProcessName.Contains("D2R") ||
                    proc.ProcessName.Contains("Diablo"))
                {
                    d2rProcesses.Add(proc);
                    lstProcesses.Items.Add(proc.ProcessName);
                }
            }

            if (lstProcesses.Items.Count == 0)
            {
                MessageBox.Show("D2R 프로세스 없음");
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
