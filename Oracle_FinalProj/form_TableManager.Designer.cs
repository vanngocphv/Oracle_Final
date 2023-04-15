namespace Oracle_FinalProj
{
    partial class form_TableManager
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admin_TStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfo_TStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout_TStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_tableManager = new System.Windows.Forms.Panel();
            this.flowlayout_tableManager = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listview_Bill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numupdown_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numupdown_foodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.combobox_Food = new System.Windows.Forms.ComboBox();
            this.combobox_Category = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_tableManager.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdown_discount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdown_foodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_TStripMenu,
            this.InfoTSItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admin_TStripMenu
            // 
            this.admin_TStripMenu.Name = "admin_TStripMenu";
            this.admin_TStripMenu.Size = new System.Drawing.Size(55, 20);
            this.admin_TStripMenu.Text = "Admin";
            this.admin_TStripMenu.Visible = false;
            this.admin_TStripMenu.Click += new System.EventHandler(this.admin_TStripMenu_Click);
            // 
            // InfoTSItem
            // 
            this.InfoTSItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserInfo_TStripMenu,
            this.Logout_TStripMenu});
            this.InfoTSItem.Name = "InfoTSItem";
            this.InfoTSItem.Size = new System.Drawing.Size(70, 20);
            this.InfoTSItem.Text = "Thông tin";
            // 
            // UserInfo_TStripMenu
            // 
            this.UserInfo_TStripMenu.Name = "UserInfo_TStripMenu";
            this.UserInfo_TStripMenu.Size = new System.Drawing.Size(170, 22);
            this.UserInfo_TStripMenu.Text = "Thông tin cá nhân";
            this.UserInfo_TStripMenu.Click += new System.EventHandler(this.UserInfo_TStripMenu_Click);
            // 
            // Logout_TStripMenu
            // 
            this.Logout_TStripMenu.Name = "Logout_TStripMenu";
            this.Logout_TStripMenu.Size = new System.Drawing.Size(170, 22);
            this.Logout_TStripMenu.Text = "Đăng xuất";
            this.Logout_TStripMenu.Click += new System.EventHandler(this.Logout_TStripMenu_Click);
            // 
            // pnl_tableManager
            // 
            this.pnl_tableManager.Controls.Add(this.flowlayout_tableManager);
            this.pnl_tableManager.Location = new System.Drawing.Point(12, 27);
            this.pnl_tableManager.Name = "pnl_tableManager";
            this.pnl_tableManager.Size = new System.Drawing.Size(600, 634);
            this.pnl_tableManager.TabIndex = 2;
            // 
            // flowlayout_tableManager
            // 
            this.flowlayout_tableManager.AutoScroll = true;
            this.flowlayout_tableManager.Location = new System.Drawing.Point(3, 3);
            this.flowlayout_tableManager.Name = "flowlayout_tableManager";
            this.flowlayout_tableManager.Size = new System.Drawing.Size(594, 628);
            this.flowlayout_tableManager.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listview_Bill);
            this.panel2.Location = new System.Drawing.Point(618, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 502);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listview_Bill
            // 
            this.listview_Bill.HideSelection = false;
            this.listview_Bill.Location = new System.Drawing.Point(3, 3);
            this.listview_Bill.Name = "listview_Bill";
            this.listview_Bill.Size = new System.Drawing.Size(372, 496);
            this.listview_Bill.TabIndex = 0;
            this.listview_Bill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numupdown_discount);
            this.panel3.Controls.Add(this.btn_discount);
            this.panel3.Controls.Add(this.btn_CheckOut);
            this.panel3.Location = new System.Drawing.Point(618, 601);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 60);
            this.panel3.TabIndex = 4;
            // 
            // numupdown_discount
            // 
            this.numupdown_discount.Location = new System.Drawing.Point(175, 31);
            this.numupdown_discount.Name = "numupdown_discount";
            this.numupdown_discount.Size = new System.Drawing.Size(90, 20);
            this.numupdown_discount.TabIndex = 5;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(175, 3);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(90, 24);
            this.btn_discount.TabIndex = 4;
            this.btn_discount.Text = "Giảm giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(285, 3);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(90, 48);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Thanh Toán";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numupdown_foodCount);
            this.panel4.Controls.Add(this.btn_addFood);
            this.panel4.Controls.Add(this.combobox_Food);
            this.panel4.Controls.Add(this.combobox_Category);
            this.panel4.Location = new System.Drawing.Point(618, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 60);
            this.panel4.TabIndex = 5;
            // 
            // numupdown_foodCount
            // 
            this.numupdown_foodCount.Location = new System.Drawing.Point(337, 27);
            this.numupdown_foodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numupdown_foodCount.Name = "numupdown_foodCount";
            this.numupdown_foodCount.Size = new System.Drawing.Size(38, 20);
            this.numupdown_foodCount.TabIndex = 3;
            this.numupdown_foodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addFood
            // 
            this.btn_addFood.Location = new System.Drawing.Point(241, 3);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(90, 48);
            this.btn_addFood.TabIndex = 2;
            this.btn_addFood.Text = "Thêm món";
            this.btn_addFood.UseVisualStyleBackColor = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // combobox_Food
            // 
            this.combobox_Food.FormattingEnabled = true;
            this.combobox_Food.Location = new System.Drawing.Point(3, 30);
            this.combobox_Food.Name = "combobox_Food";
            this.combobox_Food.Size = new System.Drawing.Size(232, 21);
            this.combobox_Food.TabIndex = 1;
            // 
            // combobox_Category
            // 
            this.combobox_Category.FormattingEnabled = true;
            this.combobox_Category.Location = new System.Drawing.Point(3, 3);
            this.combobox_Category.Name = "combobox_Category";
            this.combobox_Category.Size = new System.Drawing.Size(232, 21);
            this.combobox_Category.TabIndex = 0;
            // 
            // form_TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 674);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_tableManager);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý quán Caffe";
            this.Load += new System.EventHandler(this.form_TableManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_tableManager.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdown_discount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdown_foodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admin_TStripMenu;
        private System.Windows.Forms.ToolStripMenuItem InfoTSItem;
        private System.Windows.Forms.ToolStripMenuItem UserInfo_TStripMenu;
        private System.Windows.Forms.ToolStripMenuItem Logout_TStripMenu;
        private System.Windows.Forms.Panel pnl_tableManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listview_Bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.ComboBox combobox_Food;
        private System.Windows.Forms.ComboBox combobox_Category;
        private System.Windows.Forms.NumericUpDown numupdown_foodCount;
        private System.Windows.Forms.FlowLayoutPanel flowlayout_tableManager;
        private System.Windows.Forms.NumericUpDown numupdown_discount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_CheckOut;
    }
}