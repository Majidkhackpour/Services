
namespace WindowsSerivces.Sync
{
    partial class UcCacheStatus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmDisplayStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.تجدیدارتباطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmReConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStatus.ContextMenuStrip = this.contextMenuStrip1;
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus.Image = global::WindowsSerivces.Properties.Resources.connection_loading;
            this.btnStatus.Location = new System.Drawing.Point(0, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(30, 27);
            this.btnStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStatus.TabIndex = 3;
            this.btnStatus.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmDisplayStatus,
            this.تجدیدارتباطToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 52);
            // 
            // CmDisplayStatus
            // 
            this.CmDisplayStatus.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CmDisplayStatus.Name = "CmDisplayStatus";
            this.CmDisplayStatus.Size = new System.Drawing.Size(185, 24);
            this.CmDisplayStatus.Text = "مشاهده وضعیت سینک";
            this.CmDisplayStatus.Click += new System.EventHandler(this.CmDisplayStatus_Click);
            // 
            // تجدیدارتباطToolStripMenuItem
            // 
            this.تجدیدارتباطToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.تجدیدارتباطToolStripMenuItem.Name = "تجدیدارتباطToolStripMenuItem";
            this.تجدیدارتباطToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.تجدیدارتباطToolStripMenuItem.Text = "تجدید ارتباط";
            this.تجدیدارتباطToolStripMenuItem.Click += new System.EventHandler(this.CmReConnect_click);
            // 
            // CmReConnect
            // 
            this.CmReConnect.Name = "CmReConnect";
            this.CmReConnect.Size = new System.Drawing.Size(189, 22);
            this.CmReConnect.Text = "تجدید ارتباط";
            this.CmReConnect.Click += new System.EventHandler(this.CmReConnect_click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UcCacheStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Name = "UcCacheStatus";
            this.Size = new System.Drawing.Size(30, 27);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CmDisplayStatus;
        private System.Windows.Forms.PictureBox btnStatus;
        private System.Windows.Forms.ToolStripMenuItem تجدیدارتباطToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CmReConnect;
        private System.Windows.Forms.Timer timer1;
    }
}
