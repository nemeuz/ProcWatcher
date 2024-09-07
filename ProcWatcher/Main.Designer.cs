namespace ProcWatcher
{
    partial class Main
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
            grpProcessName = new GroupBox();
            btnScanRefresh = new Button();
            txtProcessName = new TextBox();
            grpProcesses = new GroupBox();
            btnSortB = new Button();
            btnSortA = new Button();
            btnFlash = new Button();
            btnMoveDown = new Button();
            btnMoveUp = new Button();
            btnKill = new Button();
            btnRename = new Button();
            btnToFront = new Button();
            lstProcesses = new ListBox();
            grpConditions = new GroupBox();
            lbSmartCondition1 = new Label();
            chkNetworkInactivityDetected = new CheckBox();
            chkProcessTitleChanged = new CheckBox();
            chkProcessFlashes = new CheckBox();
            chkAdvanceConditions = new CheckBox();
            numProcessCountChanged2 = new NumericUpDown();
            cbProcessCountChanged2 = new ComboBox();
            chkProcessCountChanged2 = new CheckBox();
            chkProcessCountChanged1 = new CheckBox();
            grpActions = new GroupBox();
            lbNotifyViaLine = new Label();
            txtNotifyViaLine = new TextBox();
            chkNotifyViaLine = new CheckBox();
            grpMessageLogs = new GroupBox();
            txtMessageLogs = new TextBox();
            grpControlPanel = new GroupBox();
            btnStartStop = new Button();
            statusMain = new StatusStrip();
            ledServiceStatus = new ToolStripStatusLabel();
            lbServiceStatus = new ToolStripStatusLabel();
            lbSpring = new ToolStripStatusLabel();
            lbTriggeredCount = new ToolStripStatusLabel();
            btnClearLogs = new Button();
            chkLogAutoScroll = new CheckBox();
            grpProcessName.SuspendLayout();
            grpProcesses.SuspendLayout();
            grpConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProcessCountChanged2).BeginInit();
            grpActions.SuspendLayout();
            grpMessageLogs.SuspendLayout();
            grpControlPanel.SuspendLayout();
            statusMain.SuspendLayout();
            SuspendLayout();
            // 
            // grpProcessName
            // 
            grpProcessName.Controls.Add(btnScanRefresh);
            grpProcessName.Controls.Add(txtProcessName);
            grpProcessName.Location = new Point(12, 12);
            grpProcessName.Name = "grpProcessName";
            grpProcessName.Size = new Size(360, 68);
            grpProcessName.TabIndex = 0;
            grpProcessName.TabStop = false;
            grpProcessName.Text = "Process Name:";
            // 
            // btnScanRefresh
            // 
            btnScanRefresh.Location = new Point(259, 24);
            btnScanRefresh.Name = "btnScanRefresh";
            btnScanRefresh.Size = new Size(89, 31);
            btnScanRefresh.TabIndex = 1;
            btnScanRefresh.Text = "Scan";
            btnScanRefresh.UseVisualStyleBackColor = true;
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new Point(15, 27);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(238, 25);
            txtProcessName.TabIndex = 0;
            // 
            // grpProcesses
            // 
            grpProcesses.Controls.Add(btnSortB);
            grpProcesses.Controls.Add(btnSortA);
            grpProcesses.Controls.Add(btnFlash);
            grpProcesses.Controls.Add(btnMoveDown);
            grpProcesses.Controls.Add(btnMoveUp);
            grpProcesses.Controls.Add(btnKill);
            grpProcesses.Controls.Add(btnRename);
            grpProcesses.Controls.Add(btnToFront);
            grpProcesses.Controls.Add(lstProcesses);
            grpProcesses.Location = new Point(13, 86);
            grpProcesses.Name = "grpProcesses";
            grpProcesses.Size = new Size(360, 336);
            grpProcesses.TabIndex = 1;
            grpProcesses.TabStop = false;
            grpProcesses.Text = "Processes: (0)";
            // 
            // btnSortB
            // 
            btnSortB.Location = new Point(258, 231);
            btnSortB.Name = "btnSortB";
            btnSortB.Size = new Size(89, 31);
            btnSortB.TabIndex = 9;
            btnSortB.Text = "Sort B";
            btnSortB.UseVisualStyleBackColor = true;
            // 
            // btnSortA
            // 
            btnSortA.Location = new Point(258, 194);
            btnSortA.Name = "btnSortA";
            btnSortA.Size = new Size(89, 31);
            btnSortA.TabIndex = 8;
            btnSortA.Text = "Sort A";
            btnSortA.UseVisualStyleBackColor = true;
            // 
            // btnFlash
            // 
            btnFlash.Location = new Point(258, 103);
            btnFlash.Name = "btnFlash";
            btnFlash.Size = new Size(89, 31);
            btnFlash.TabIndex = 7;
            btnFlash.Text = "Flash!";
            btnFlash.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Location = new Point(304, 157);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(43, 31);
            btnMoveDown.TabIndex = 6;
            btnMoveDown.Text = "▼";
            btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Location = new Point(258, 157);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(43, 31);
            btnMoveUp.TabIndex = 5;
            btnMoveUp.Text = "▲";
            btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnKill
            // 
            btnKill.Location = new Point(258, 291);
            btnKill.Name = "btnKill";
            btnKill.Size = new Size(89, 31);
            btnKill.TabIndex = 4;
            btnKill.Text = "Kill";
            btnKill.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(258, 66);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(89, 31);
            btnRename.TabIndex = 3;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // btnToFront
            // 
            btnToFront.Location = new Point(258, 29);
            btnToFront.Name = "btnToFront";
            btnToFront.Size = new Size(89, 31);
            btnToFront.TabIndex = 2;
            btnToFront.Text = "To Front";
            btnToFront.UseVisualStyleBackColor = true;
            // 
            // lstProcesses
            // 
            lstProcesses.FormattingEnabled = true;
            lstProcesses.ItemHeight = 17;
            lstProcesses.Location = new Point(14, 29);
            lstProcesses.Name = "lstProcesses";
            lstProcesses.Size = new Size(238, 293);
            lstProcesses.TabIndex = 0;
            // 
            // grpConditions
            // 
            grpConditions.Controls.Add(lbSmartCondition1);
            grpConditions.Controls.Add(chkNetworkInactivityDetected);
            grpConditions.Controls.Add(chkProcessTitleChanged);
            grpConditions.Controls.Add(chkProcessFlashes);
            grpConditions.Controls.Add(chkAdvanceConditions);
            grpConditions.Controls.Add(numProcessCountChanged2);
            grpConditions.Controls.Add(cbProcessCountChanged2);
            grpConditions.Controls.Add(chkProcessCountChanged2);
            grpConditions.Controls.Add(chkProcessCountChanged1);
            grpConditions.Location = new Point(382, 86);
            grpConditions.Name = "grpConditions";
            grpConditions.Size = new Size(443, 223);
            grpConditions.TabIndex = 2;
            grpConditions.TabStop = false;
            grpConditions.Text = "Conditions:";
            // 
            // lbSmartCondition1
            // 
            lbSmartCondition1.BackColor = Color.LightGreen;
            lbSmartCondition1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbSmartCondition1.Location = new Point(231, 181);
            lbSmartCondition1.Name = "lbSmartCondition1";
            lbSmartCondition1.Size = new Size(58, 19);
            lbSmartCondition1.TabIndex = 30;
            lbSmartCondition1.Text = " SMART ";
            lbSmartCondition1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkNetworkInactivityDetected
            // 
            chkNetworkInactivityDetected.AutoSize = true;
            chkNetworkInactivityDetected.Location = new Point(37, 180);
            chkNetworkInactivityDetected.Name = "chkNetworkInactivityDetected";
            chkNetworkInactivityDetected.Size = new Size(195, 23);
            chkNetworkInactivityDetected.TabIndex = 29;
            chkNetworkInactivityDetected.Text = "Network inactivity detected";
            chkNetworkInactivityDetected.UseVisualStyleBackColor = true;
            // 
            // chkProcessTitleChanged
            // 
            chkProcessTitleChanged.AutoSize = true;
            chkProcessTitleChanged.Location = new Point(37, 151);
            chkProcessTitleChanged.Name = "chkProcessTitleChanged";
            chkProcessTitleChanged.Size = new Size(157, 23);
            chkProcessTitleChanged.TabIndex = 10;
            chkProcessTitleChanged.Text = "Process title changed";
            chkProcessTitleChanged.UseVisualStyleBackColor = true;
            // 
            // chkProcessFlashes
            // 
            chkProcessFlashes.AutoSize = true;
            chkProcessFlashes.Location = new Point(37, 122);
            chkProcessFlashes.Name = "chkProcessFlashes";
            chkProcessFlashes.Size = new Size(119, 23);
            chkProcessFlashes.TabIndex = 9;
            chkProcessFlashes.Text = "Process flashes";
            chkProcessFlashes.UseVisualStyleBackColor = true;
            // 
            // chkAdvanceConditions
            // 
            chkAdvanceConditions.AutoSize = true;
            chkAdvanceConditions.Location = new Point(15, 93);
            chkAdvanceConditions.Name = "chkAdvanceConditions";
            chkAdvanceConditions.Size = new Size(385, 23);
            chkAdvanceConditions.TabIndex = 6;
            chkAdvanceConditions.Text = "When one or more processes met one of these conditions:";
            chkAdvanceConditions.UseVisualStyleBackColor = true;
            // 
            // numProcessCountChanged2
            // 
            numProcessCountChanged2.Location = new Point(237, 59);
            numProcessCountChanged2.Name = "numProcessCountChanged2";
            numProcessCountChanged2.Size = new Size(58, 25);
            numProcessCountChanged2.TabIndex = 5;
            numProcessCountChanged2.TextAlign = HorizontalAlignment.Center;
            // 
            // cbProcessCountChanged2
            // 
            cbProcessCountChanged2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProcessCountChanged2.FormattingEnabled = true;
            cbProcessCountChanged2.Items.AddRange(new object[] { "<", "<=", ">", ">=", "==", "!=" });
            cbProcessCountChanged2.Location = new Point(181, 59);
            cbProcessCountChanged2.Name = "cbProcessCountChanged2";
            cbProcessCountChanged2.Size = new Size(49, 25);
            cbProcessCountChanged2.TabIndex = 4;
            // 
            // chkProcessCountChanged2
            // 
            chkProcessCountChanged2.AutoSize = true;
            chkProcessCountChanged2.Location = new Point(15, 60);
            chkProcessCountChanged2.Name = "chkProcessCountChanged2";
            chkProcessCountChanged2.Size = new Size(170, 23);
            chkProcessCountChanged2.TabIndex = 3;
            chkProcessCountChanged2.Text = "When process count is ";
            chkProcessCountChanged2.UseVisualStyleBackColor = true;
            // 
            // chkProcessCountChanged1
            // 
            chkProcessCountChanged1.AutoSize = true;
            chkProcessCountChanged1.Location = new Point(15, 29);
            chkProcessCountChanged1.Name = "chkProcessCountChanged1";
            chkProcessCountChanged1.Size = new Size(222, 23);
            chkProcessCountChanged1.TabIndex = 0;
            chkProcessCountChanged1.Text = "When process count is changed";
            chkProcessCountChanged1.UseVisualStyleBackColor = true;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(lbNotifyViaLine);
            grpActions.Controls.Add(txtNotifyViaLine);
            grpActions.Controls.Add(chkNotifyViaLine);
            grpActions.Location = new Point(382, 320);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(443, 102);
            grpActions.TabIndex = 3;
            grpActions.TabStop = false;
            grpActions.Text = "Actions:";
            // 
            // lbNotifyViaLine
            // 
            lbNotifyViaLine.AutoSize = true;
            lbNotifyViaLine.Location = new Point(31, 60);
            lbNotifyViaLine.Name = "lbNotifyViaLine";
            lbNotifyViaLine.Size = new Size(49, 19);
            lbNotifyViaLine.TabIndex = 2;
            lbNotifyViaLine.Text = "Target:";
            // 
            // txtNotifyViaLine
            // 
            txtNotifyViaLine.Location = new Point(86, 57);
            txtNotifyViaLine.Name = "txtNotifyViaLine";
            txtNotifyViaLine.Size = new Size(339, 25);
            txtNotifyViaLine.TabIndex = 1;
            // 
            // chkNotifyViaLine
            // 
            chkNotifyViaLine.AutoSize = true;
            chkNotifyViaLine.Location = new Point(15, 28);
            chkNotifyViaLine.Name = "chkNotifyViaLine";
            chkNotifyViaLine.Size = new Size(182, 23);
            chkNotifyViaLine.TabIndex = 0;
            chkNotifyViaLine.Text = "Notify me via LINE Notify";
            chkNotifyViaLine.UseVisualStyleBackColor = true;
            // 
            // grpMessageLogs
            // 
            grpMessageLogs.Controls.Add(chkLogAutoScroll);
            grpMessageLogs.Controls.Add(btnClearLogs);
            grpMessageLogs.Controls.Add(txtMessageLogs);
            grpMessageLogs.Location = new Point(13, 428);
            grpMessageLogs.Name = "grpMessageLogs";
            grpMessageLogs.Size = new Size(812, 181);
            grpMessageLogs.TabIndex = 4;
            grpMessageLogs.TabStop = false;
            grpMessageLogs.Text = "Message Logs:";
            // 
            // txtMessageLogs
            // 
            txtMessageLogs.Location = new Point(14, 26);
            txtMessageLogs.Multiline = true;
            txtMessageLogs.Name = "txtMessageLogs";
            txtMessageLogs.ReadOnly = true;
            txtMessageLogs.ScrollBars = ScrollBars.Vertical;
            txtMessageLogs.Size = new Size(783, 111);
            txtMessageLogs.TabIndex = 0;
            // 
            // grpControlPanel
            // 
            grpControlPanel.Controls.Add(btnStartStop);
            grpControlPanel.Location = new Point(382, 12);
            grpControlPanel.Name = "grpControlPanel";
            grpControlPanel.Size = new Size(443, 68);
            grpControlPanel.TabIndex = 5;
            grpControlPanel.TabStop = false;
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(307, 21);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(118, 31);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start Watching";
            btnStartStop.UseVisualStyleBackColor = true;
            // 
            // statusMain
            // 
            statusMain.Items.AddRange(new ToolStripItem[] { ledServiceStatus, lbServiceStatus, lbSpring, lbTriggeredCount });
            statusMain.Location = new Point(0, 619);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(839, 22);
            statusMain.SizingGrip = false;
            statusMain.TabIndex = 6;
            // 
            // ledServiceStatus
            // 
            ledServiceStatus.Font = new Font("Segoe UI Symbol", 9F);
            ledServiceStatus.ForeColor = Color.Silver;
            ledServiceStatus.Name = "ledServiceStatus";
            ledServiceStatus.Size = new Size(17, 17);
            ledServiceStatus.Text = "●";
            // 
            // lbServiceStatus
            // 
            lbServiceStatus.Name = "lbServiceStatus";
            lbServiceStatus.Size = new Size(39, 17);
            lbServiceStatus.Text = "Ready";
            // 
            // lbSpring
            // 
            lbSpring.Name = "lbSpring";
            lbSpring.Size = new Size(700, 17);
            lbSpring.Spring = true;
            // 
            // lbTriggeredCount
            // 
            lbTriggeredCount.Name = "lbTriggeredCount";
            lbTriggeredCount.Size = new Size(68, 17);
            lbTriggeredCount.Text = "Triggered: 0";
            // 
            // btnClearLogs
            // 
            btnClearLogs.Location = new Point(703, 143);
            btnClearLogs.Name = "btnClearLogs";
            btnClearLogs.Size = new Size(91, 31);
            btnClearLogs.TabIndex = 3;
            btnClearLogs.Text = "Clear Logs";
            btnClearLogs.UseVisualStyleBackColor = true;
            // 
            // chkLogAutoScroll
            // 
            chkLogAutoScroll.AutoSize = true;
            chkLogAutoScroll.Location = new Point(14, 147);
            chkLogAutoScroll.Name = "chkLogAutoScroll";
            chkLogAutoScroll.Size = new Size(89, 23);
            chkLogAutoScroll.TabIndex = 4;
            chkLogAutoScroll.Text = "Autoscroll";
            chkLogAutoScroll.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(839, 641);
            Controls.Add(statusMain);
            Controls.Add(grpControlPanel);
            Controls.Add(grpMessageLogs);
            Controls.Add(grpActions);
            Controls.Add(grpConditions);
            Controls.Add(grpProcesses);
            Controls.Add(grpProcessName);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcWatcher";
            grpProcessName.ResumeLayout(false);
            grpProcessName.PerformLayout();
            grpProcesses.ResumeLayout(false);
            grpConditions.ResumeLayout(false);
            grpConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProcessCountChanged2).EndInit();
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            grpMessageLogs.ResumeLayout(false);
            grpMessageLogs.PerformLayout();
            grpControlPanel.ResumeLayout(false);
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpProcessName;
        private Button btnScanRefresh;
        private TextBox txtProcessName;
        private GroupBox grpProcesses;
        private ListBox lstProcesses;
        private GroupBox grpConditions;
        private NumericUpDown numProcessCountChanged2;
        private ComboBox cbProcessCountChanged2;
        private CheckBox chkProcessCountChanged2;
        private CheckBox chkProcessCountChanged1;
        private GroupBox grpActions;
        private CheckBox chkNotifyViaLine;
        private CheckBox chkAdvanceConditions;
        private CheckBox chkProcessFlashes;
        private CheckBox chkProcessTitleChanged;
        private CheckBox chkNetworkInactivityDetected;
        private Label lbSmartCondition1;
        private Label lbNotifyViaLine;
        private TextBox txtNotifyViaLine;
        private GroupBox grpMessageLogs;
        private GroupBox grpControlPanel;
        private Button btnStartStop;
        private Button btnKill;
        private Button btnRename;
        private Button btnToFront;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private Button btnFlash;
        private Button btnSortA;
        private Button btnSortB;
        private TextBox txtMessageLogs;
        private StatusStrip statusMain;
        private ToolStripStatusLabel ledServiceStatus;
        private ToolStripStatusLabel lbServiceStatus;
        private ToolStripStatusLabel lbSpring;
        private ToolStripStatusLabel lbTriggeredCount;
        private Button btnClearLogs;
        private CheckBox chkLogAutoScroll;
    }
}
