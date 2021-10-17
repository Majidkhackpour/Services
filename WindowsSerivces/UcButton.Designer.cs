
namespace WindowsSerivces
{
    partial class UcButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupPanel67 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupPanel67.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel67
            // 
            this.groupPanel67.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel67.Controls.Add(this.lblTitle);
            this.groupPanel67.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupPanel67.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel67.Location = new System.Drawing.Point(0, 0);
            this.groupPanel67.Name = "groupPanel67";
            this.groupPanel67.Size = new System.Drawing.Size(197, 43);
            // 
            // 
            // 
            this.groupPanel67.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(231)))));
            this.groupPanel67.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(231)))));
            this.groupPanel67.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel67.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(231)))));
            this.groupPanel67.Style.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(231)))));
            this.groupPanel67.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel67.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel67.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel67.Style.CornerDiameter = 10;
            this.groupPanel67.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            // 
            // 
            // 
            this.groupPanel67.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel67.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel67.TabIndex = 55727;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نام مشتری";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // UcButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanel67);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcButton";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(197, 43);
            this.groupPanel67.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel67;
        private System.Windows.Forms.Label lblTitle;
    }
}
