using SysBot.Pokemon.WinForms.Properties;
using System.Drawing;
using System.Windows.Forms;


namespace SysBot.Pokemon.WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            TC_Main = new TabControl();
            Tab_Bots = new TabPage();
            comboBox1 = new ComboBox();
            CB_Protocol = new ComboBox();
            FLP_Bots = new FlowLayoutPanel();
            TB_IP = new TextBox();
            CB_Routine = new ComboBox();
            NUD_Port = new NumericUpDown();
            B_New = new Button();
            Tab_Hub = new TabPage();
            PG_Hub = new PropertyGrid();
            Tab_Logs = new TabPage();
            RTB_Logs = new RichTextBox();
            B_Stop = new Button();
            B_Start = new Button();
            B_RebootAndStop = new Button();
            ButtonPanel = new Panel();
            TC_Main.SuspendLayout();
            Tab_Bots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Port).BeginInit();
            Tab_Hub.SuspendLayout();
            Tab_Logs.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TC_Main
            // 
            TC_Main.Appearance = TabAppearance.FlatButtons;
            TC_Main.Controls.Add(Tab_Bots);
            TC_Main.Controls.Add(Tab_Hub);
            TC_Main.Controls.Add(Tab_Logs);
            TC_Main.Dock = DockStyle.Fill;
            TC_Main.Font = new Font("Segoe UI", 9F);
            TC_Main.ItemSize = new Size(76, 30);
            TC_Main.Location = new Point(0, 0);
            TC_Main.Margin = new Padding(0);
            TC_Main.Multiline = true;
            TC_Main.Name = "TC_Main";
            TC_Main.Padding = new Point(20, 7);
            TC_Main.SelectedIndex = 0;
            TC_Main.Size = new Size(702, 458);
            TC_Main.TabIndex = 3;
            // 
            // Tab_Bots
            // 
            Tab_Bots.Controls.Add(comboBox1);
            Tab_Bots.Controls.Add(CB_Protocol);
            Tab_Bots.Controls.Add(FLP_Bots);
            Tab_Bots.Controls.Add(TB_IP);
            Tab_Bots.Controls.Add(CB_Routine);
            Tab_Bots.Controls.Add(NUD_Port);
            Tab_Bots.Controls.Add(B_New);
            Tab_Bots.Location = new Point(4, 34);
            Tab_Bots.Margin = new Padding(3, 4, 3, 4);
            Tab_Bots.Name = "Tab_Bots";
            Tab_Bots.Size = new Size(694, 420);
            Tab_Bots.TabIndex = 0;
            Tab_Bots.Text = "Bots";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(600, 8);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // CB_Protocol
            // 
            CB_Protocol.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Protocol.ForeColor = Color.Red;
            CB_Protocol.FormattingEnabled = true;
            CB_Protocol.Location = new Point(333, 8);
            CB_Protocol.Margin = new Padding(3, 4, 3, 4);
            CB_Protocol.Name = "CB_Protocol";
            CB_Protocol.Size = new Size(76, 28);
            CB_Protocol.TabIndex = 10;
            CB_Protocol.SelectedIndexChanged += CB_Protocol_SelectedIndexChanged;
            // 
            // FLP_Bots
            // 
            FLP_Bots.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FLP_Bots.BackColor = SystemColors.AppWorkspace;
            FLP_Bots.BackgroundImage = (Image)resources.GetObject("FLP_Bots.BackgroundImage");
            FLP_Bots.BackgroundImageLayout = ImageLayout.Center;
            FLP_Bots.BorderStyle = BorderStyle.Fixed3D;
            FLP_Bots.Font = new Font("Cambria", 12F);
            FLP_Bots.Location = new Point(0, 49);
            FLP_Bots.Margin = new Padding(0);
            FLP_Bots.Name = "FLP_Bots";
            FLP_Bots.Size = new Size(692, 371);
            FLP_Bots.TabIndex = 9;
            FLP_Bots.Paint += FLP_Bots_Paint;
            FLP_Bots.Resize += FLP_Bots_Resize;
            // 
            // TB_IP
            // 
            TB_IP.Font = new Font("Courier New", 12F);
            TB_IP.Location = new Point(83, 9);
            TB_IP.Margin = new Padding(3, 4, 3, 4);
            TB_IP.Name = "TB_IP";
            TB_IP.Size = new Size(153, 30);
            TB_IP.TabIndex = 8;
            TB_IP.Text = "192.168.0.1";
            // 
            // CB_Routine
            // 
            CB_Routine.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Routine.FormattingEnabled = true;
            CB_Routine.Location = new Point(416, 8);
            CB_Routine.Margin = new Padding(3, 4, 3, 4);
            CB_Routine.Name = "CB_Routine";
            CB_Routine.Size = new Size(177, 28);
            CB_Routine.TabIndex = 7;
            // 
            // NUD_Port
            // 
            NUD_Port.Font = new Font("Courier New", 12F);
            NUD_Port.Location = new Point(246, 9);
            NUD_Port.Margin = new Padding(3, 4, 3, 4);
            NUD_Port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            NUD_Port.Name = "NUD_Port";
            NUD_Port.Size = new Size(78, 30);
            NUD_Port.TabIndex = 6;
            NUD_Port.Value = new decimal(new int[] { 6000, 0, 0, 0 });
            // 
            // B_New
            // 
            B_New.FlatAppearance.BorderSize = 0;
            B_New.FlatStyle = FlatStyle.Flat;
            B_New.Location = new Point(3, 9);
            B_New.Margin = new Padding(3, 4, 3, 4);
            B_New.Name = "B_New";
            B_New.Size = new Size(72, 31);
            B_New.TabIndex = 0;
            B_New.Text = "Add";
            B_New.Click += B_New_Click;
            // 
            // Tab_Hub
            // 
            Tab_Hub.Controls.Add(PG_Hub);
            Tab_Hub.Location = new Point(4, 34);
            Tab_Hub.Margin = new Padding(3, 4, 3, 4);
            Tab_Hub.Name = "Tab_Hub";
            Tab_Hub.Padding = new Padding(3, 4, 3, 4);
            Tab_Hub.Size = new Size(694, 420);
            Tab_Hub.TabIndex = 2;
            Tab_Hub.Text = "Hub";
            // 
            // PG_Hub
            // 
            PG_Hub.BackColor = SystemColors.Control;
            PG_Hub.Dock = DockStyle.Fill;
            PG_Hub.Location = new Point(3, 4);
            PG_Hub.Margin = new Padding(3, 5, 3, 5);
            PG_Hub.Name = "PG_Hub";
            PG_Hub.PropertySort = PropertySort.Categorized;
            PG_Hub.Size = new Size(688, 412);
            PG_Hub.TabIndex = 0;
            PG_Hub.ToolbarVisible = false;
            // 
            // Tab_Logs
            // 
            Tab_Logs.Controls.Add(RTB_Logs);
            Tab_Logs.Location = new Point(4, 34);
            Tab_Logs.Margin = new Padding(3, 4, 3, 4);
            Tab_Logs.Name = "Tab_Logs";
            Tab_Logs.Size = new Size(694, 420);
            Tab_Logs.TabIndex = 1;
            Tab_Logs.Text = "Logs";
            // 
            // RTB_Logs
            // 
            RTB_Logs.Dock = DockStyle.Fill;
            RTB_Logs.Location = new Point(0, 0);
            RTB_Logs.Margin = new Padding(3, 4, 3, 4);
            RTB_Logs.Name = "RTB_Logs";
            RTB_Logs.ReadOnly = true;
            RTB_Logs.Size = new Size(694, 420);
            RTB_Logs.TabIndex = 0;
            RTB_Logs.Text = "";
            // 
            // B_Stop
            // 
            B_Stop.BackColor = Color.Maroon;
            B_Stop.BackgroundImageLayout = ImageLayout.None;
            B_Stop.FlatStyle = FlatStyle.Popup;
            B_Stop.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Stop.ForeColor = Color.WhiteSmoke;
            B_Stop.Image = Resources.stopall;
            B_Stop.ImageAlign = ContentAlignment.MiddleLeft;
            B_Stop.Location = new Point(193, 2);
            B_Stop.Margin = new Padding(0);
            B_Stop.Name = "B_Stop";
            B_Stop.Size = new Size(103, 37);
            B_Stop.TabIndex = 1;
            B_Stop.Text = "Stop Bots";
            B_Stop.TextAlign = ContentAlignment.MiddleRight;
            B_Stop.UseVisualStyleBackColor = false;
            B_Stop.Click += B_Stop_Click;
            // 
            // B_Start
            // 
            B_Start.BackColor = Color.FromArgb(192, 255, 192);
            B_Start.FlatStyle = FlatStyle.Popup;
            B_Start.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Start.ForeColor = Color.ForestGreen;
            B_Start.Image = Resources.startall;
            B_Start.ImageAlign = ContentAlignment.MiddleLeft;
            B_Start.Location = new Point(78, 2);
            B_Start.Margin = new Padding(0);
            B_Start.Name = "B_Start";
            B_Start.Size = new Size(104, 37);
            B_Start.TabIndex = 0;
            B_Start.Text = "Start Bots";
            B_Start.TextAlign = ContentAlignment.MiddleRight;
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += B_Start_Click;
            // 
            // B_RebootAndStop
            // 
            B_RebootAndStop.BackColor = Color.PowderBlue;
            B_RebootAndStop.FlatStyle = FlatStyle.Popup;
            B_RebootAndStop.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_RebootAndStop.ForeColor = Color.SteelBlue;
            B_RebootAndStop.Image = Resources.refresh;
            B_RebootAndStop.ImageAlign = ContentAlignment.MiddleLeft;
            B_RebootAndStop.Location = new Point(307, 2);
            B_RebootAndStop.Margin = new Padding(0);
            B_RebootAndStop.Name = "B_RebootAndStop";
            B_RebootAndStop.Size = new Size(101, 37);
            B_RebootAndStop.TabIndex = 2;
            B_RebootAndStop.Text = "Reset Bot";
            B_RebootAndStop.TextAlign = ContentAlignment.MiddleRight;
            B_RebootAndStop.UseVisualStyleBackColor = false;
            B_RebootAndStop.Click += B_RebootAndStop_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = SystemColors.Control;
            ButtonPanel.Controls.Add(B_RebootAndStop);
            ButtonPanel.Controls.Add(B_Stop);
            ButtonPanel.Controls.Add(B_Start);
            ButtonPanel.Location = new Point(285, 0);
            ButtonPanel.Margin = new Padding(3, 5, 3, 5);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(417, 47);
            ButtonPanel.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 458);
            Controls.Add(ButtonPanel);
            Controls.Add(TC_Main);
            Icon = Resources.icon;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NOT RaidBot";
            FormClosing += Main_FormClosing;
            TC_Main.ResumeLayout(false);
            Tab_Bots.ResumeLayout(false);
            Tab_Bots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Port).EndInit();
            Tab_Hub.ResumeLayout(false);
            Tab_Logs.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl TC_Main;
        private TabPage Tab_Bots;
        private TabPage Tab_Logs;
        private RichTextBox RTB_Logs;
        private TabPage Tab_Hub;
        private PropertyGrid PG_Hub;
        private Button B_Stop;
        private Button B_Start;
        private TextBox TB_IP;
        private ComboBox CB_Routine;
        private NumericUpDown NUD_Port;
        private Button B_New;
        private FlowLayoutPanel FLP_Bots;
        private ComboBox CB_Protocol;
        private ComboBox comboBox1;
        private Button B_RebootAndStop;
        private Panel ButtonPanel;
    }
}

