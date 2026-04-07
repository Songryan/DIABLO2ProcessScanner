namespace DIABLO2ProcessScanner
{
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
            btnFindProcess = new Button();
            btnRefresh = new Button();
            btnReadMemory = new Button();
            lstProcesses = new ListBox();
            txtAddress = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFindProcess
            // 
            btnFindProcess.Location = new Point(452, 12);
            btnFindProcess.Name = "btnFindProcess";
            btnFindProcess.Size = new Size(160, 50);
            btnFindProcess.TabIndex = 0;
            btnFindProcess.Text = "프로세스 찾기";
            btnFindProcess.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "목록 새로고침";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnReadMemory
            // 
            btnReadMemory.Location = new Point(452, 458);
            btnReadMemory.Name = "btnReadMemory";
            btnReadMemory.Size = new Size(160, 59);
            btnReadMemory.TabIndex = 2;
            btnReadMemory.Text = "값 읽기";
            btnReadMemory.UseVisualStyleBackColor = true;
            // 
            // lstProcesses
            // 
            lstProcesses.FormattingEnabled = true;
            lstProcesses.Location = new Point(12, 68);
            lstProcesses.Name = "lstProcesses";
            lstProcesses.Size = new Size(600, 379);
            lstProcesses.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 486);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "주소 입력 (예: 0x12345678)";
            txtAddress.Size = new Size(434, 31);
            txtAddress.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 557);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(600, 31);
            txtResult.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 458);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 6;
            label1.Text = "주소";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 529);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 7;
            label2.Text = "결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 603);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtAddress);
            Controls.Add(lstProcesses);
            Controls.Add(btnReadMemory);
            Controls.Add(btnRefresh);
            Controls.Add(btnFindProcess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindProcess;
        private Button btnRefresh;
        private Button btnReadMemory;
        private ListBox lstProcesses;
        private TextBox txtAddress;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
    }
}
