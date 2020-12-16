namespace WindowsSerivces.Pagging
{
    partial class UC_FooterPaging
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
            this.TxtTopCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPage = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.txtFromPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTopCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTopCount
            // 
            this.TxtTopCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTopCount.Location = new System.Drawing.Point(243, 1);
            this.TxtTopCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TxtTopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtTopCount.Name = "TxtTopCount";
            this.TxtTopCount.Size = new System.Drawing.Size(56, 27);
            this.TxtTopCount.TabIndex = 30;
            this.TxtTopCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TxtTopCount.ValueChanged += new System.EventHandler(this.TxtTopCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(303, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "تعداد نمایش در هر صفحه:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPage
            // 
            this.LblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPage.Location = new System.Drawing.Point(66, 1);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(52, 27);
            this.LblPage.TabIndex = 28;
            this.LblPage.Text = "از 000";
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Font = new System.Drawing.Font("B Yekan", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnNext.Location = new System.Drawing.Point(7, 1);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(53, 27);
            this.BtnNext.TabIndex = 27;
            this.BtnNext.Text = "صفحه بعد";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("B Yekan", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBack.Location = new System.Drawing.Point(184, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(53, 28);
            this.BtnBack.TabIndex = 26;
            this.BtnBack.Text = "صفحه قبل";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtFromPage
            // 
            this.txtFromPage.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFromPage.Location = new System.Drawing.Point(124, 0);
            this.txtFromPage.Multiline = true;
            this.txtFromPage.Name = "txtFromPage";
            this.txtFromPage.Size = new System.Drawing.Size(48, 22);
            this.txtFromPage.TabIndex = 31;
            this.txtFromPage.TextChanged += new System.EventHandler(this.txtFromPage_TextChanged);
            // 
            // UC_FooterPaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtFromPage);
            this.Controls.Add(this.TxtTopCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPage);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnBack);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_FooterPaging";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(448, 28);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTopCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TxtTopCount;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox txtFromPage;
    }
}
