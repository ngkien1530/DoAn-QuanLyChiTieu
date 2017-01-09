namespace DoAn
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ThuTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ChiTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ThongKeTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbText = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(467, 161);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ThuTab);
            this.ribbon1.Tabs.Add(this.ChiTab);
            this.ribbon1.Tabs.Add(this.ThongKeTab);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.AltKey = null;
            this.ribbonOrbMenuItem1.CheckedGroup = null;
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonOrbMenuItem1.Tag = null;
            this.ribbonOrbMenuItem1.Text = "Chỉnh sửa hồ sơ";
            this.ribbonOrbMenuItem1.ToolTip = null;
            this.ribbonOrbMenuItem1.ToolTipTitle = null;
            this.ribbonOrbMenuItem1.Value = null;
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.AltKey = null;
            this.ribbonOrbMenuItem2.CheckedGroup = null;
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonOrbMenuItem2.Tag = null;
            this.ribbonOrbMenuItem2.Text = "Đăng xuất";
            this.ribbonOrbMenuItem2.ToolTip = null;
            this.ribbonOrbMenuItem2.ToolTipTitle = null;
            this.ribbonOrbMenuItem2.Value = null;
            // 
            // ThuTab
            // 
            this.ThuTab.Panels.Add(this.ribbonPanel1);
            this.ThuTab.Panels.Add(this.ribbonPanel2);
            this.ThuTab.Panels.Add(this.ribbonPanel3);
            this.ThuTab.Tag = null;
            this.ThuTab.Text = "Thu";
            this.ThuTab.ToolTip = null;
            this.ThuTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ThuTab.ToolTipImage = null;
            this.ThuTab.ToolTipTitle = null;
            this.ThuTab.Value = null;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Thêm";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.CheckedGroup = null;
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = null;
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipTitle = null;
            this.ribbonButton1.Value = null;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton3);
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "Xoá";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.AltKey = null;
            this.ribbonButton3.CheckedGroup = null;
            this.ribbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton3.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton3.Tag = null;
            this.ribbonButton3.Text = null;
            this.ribbonButton3.ToolTip = null;
            this.ribbonButton3.ToolTipTitle = null;
            this.ribbonButton3.Value = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton4);
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Sửa";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.AltKey = null;
            this.ribbonButton4.CheckedGroup = null;
            this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton4.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton4.Tag = null;
            this.ribbonButton4.Text = null;
            this.ribbonButton4.ToolTip = null;
            this.ribbonButton4.ToolTipTitle = null;
            this.ribbonButton4.Value = null;
            // 
            // ChiTab
            // 
            this.ChiTab.Panels.Add(this.ribbonPanel4);
            this.ChiTab.Panels.Add(this.ribbonPanel6);
            this.ChiTab.Panels.Add(this.ribbonPanel7);
            this.ChiTab.Tag = null;
            this.ChiTab.Text = "Chi";
            this.ChiTab.ToolTip = null;
            this.ChiTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ChiTab.ToolTipImage = null;
            this.ChiTab.ToolTipTitle = null;
            this.ChiTab.Value = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton2);
            this.ribbonPanel4.Tag = null;
            this.ribbonPanel4.Text = "Thêm";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.AltKey = null;
            this.ribbonButton2.CheckedGroup = null;
            this.ribbonButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton2.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton2.Tag = null;
            this.ribbonButton2.Text = null;
            this.ribbonButton2.ToolTip = null;
            this.ribbonButton2.ToolTipTitle = null;
            this.ribbonButton2.Value = null;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.ribbonButton5);
            this.ribbonPanel6.Tag = null;
            this.ribbonPanel6.Text = "Xoá";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.AltKey = null;
            this.ribbonButton5.CheckedGroup = null;
            this.ribbonButton5.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton5.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton5.Tag = null;
            this.ribbonButton5.Text = null;
            this.ribbonButton5.ToolTip = null;
            this.ribbonButton5.ToolTipTitle = null;
            this.ribbonButton5.Value = null;
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.ribbonButton6);
            this.ribbonPanel7.Tag = null;
            this.ribbonPanel7.Text = "Sửa";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.AltKey = null;
            this.ribbonButton6.CheckedGroup = null;
            this.ribbonButton6.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton6.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton6.Tag = null;
            this.ribbonButton6.Text = null;
            this.ribbonButton6.ToolTip = null;
            this.ribbonButton6.ToolTipTitle = null;
            this.ribbonButton6.Value = null;
            // 
            // ThongKeTab
            // 
            this.ThongKeTab.Panels.Add(this.ribbonPanel5);
            this.ThongKeTab.Panels.Add(this.ribbonPanel8);
            this.ThongKeTab.Tag = null;
            this.ThongKeTab.Text = "Thống Kê";
            this.ThongKeTab.ToolTip = null;
            this.ThongKeTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ThongKeTab.ToolTipImage = null;
            this.ThongKeTab.ToolTipTitle = null;
            this.ThongKeTab.Value = null;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton7);
            this.ribbonPanel5.Tag = null;
            this.ribbonPanel5.Text = "Danh sách";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.AltKey = null;
            this.ribbonButton7.CheckedGroup = null;
            this.ribbonButton7.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton7.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton7.Tag = null;
            this.ribbonButton7.Text = null;
            this.ribbonButton7.ToolTip = null;
            this.ribbonButton7.ToolTipTitle = null;
            this.ribbonButton7.Value = null;
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.ribbonButton8);
            this.ribbonPanel8.Tag = null;
            this.ribbonPanel8.Text = "Biểu đồ";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.AltKey = null;
            this.ribbonButton8.CheckedGroup = null;
            this.ribbonButton8.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton8.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton8.Tag = null;
            this.ribbonButton8.Text = null;
            this.ribbonButton8.ToolTip = null;
            this.ribbonButton8.ToolTipTitle = null;
            this.ribbonButton8.Value = null;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Time,
            this.Column_Content,
            this.Column_Cost,
            this.Column_Note});
            this.dataGridView3.Location = new System.Drawing.Point(13, 168);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(442, 279);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_Time
            // 
            this.Column_Time.HeaderText = "Thời gian";
            this.Column_Time.Name = "Column_Time";
            this.Column_Time.ReadOnly = true;
            // 
            // Column_Content
            // 
            this.Column_Content.HeaderText = "Nội dung";
            this.Column_Content.Name = "Column_Content";
            this.Column_Content.ReadOnly = true;
            // 
            // Column_Cost
            // 
            this.Column_Cost.HeaderText = "Số tiền";
            this.Column_Cost.Name = "Column_Cost";
            this.Column_Cost.ReadOnly = true;
            // 
            // Column_Note
            // 
            this.Column_Note.HeaderText = "Ghi chú";
            this.Column_Note.Name = "Column_Note";
            this.Column_Note.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 459);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ribbon1);
            this.Name = "Form1";
            this.Text = "Money Savior";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonTab ThuTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonTab ChiTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonTab ThongKeTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Note;
    }
}

