
namespace sqlkns_21_2_ro
{
    partial class DataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.btFilter = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.ToolStripLabel();
            this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label2 = new System.Windows.Forms.ToolStripLabel();
            this.textBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.label3 = new System.Windows.Forms.ToolStripLabel();
            this.Del = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(656, 270);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.Edit,
            this.Del,
            this.AddNew,
            this.btSearch,
            this.btFilter,
            this.label1,
            this.textBox1,
            this.label2,
            this.textBox2,
            this.label3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(686, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(23, 22);
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // btSearch
            // 
            this.btSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(23, 22);
            this.btSearch.Text = "toolStripButton1";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btFilter
            // 
            this.btFilter.CheckOnClick = true;
            this.btFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFilter.Image = ((System.Drawing.Image)(resources.GetObject("btFilter.Image")));
            this.btFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(23, 22);
            this.btFilter.Text = "toolStripButton2";
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.Text = "Пошук";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.Visible = false;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.Text = "Введіть фільтр ";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.Visible = false;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.Text = "Enter";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Del
            // 
            this.Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(23, 22);
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(23, 22);
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 302);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataView";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Species_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btFilter;
        private System.Windows.Forms.ToolStripLabel label1;
        private System.Windows.Forms.ToolStripTextBox textBox1;
        private System.Windows.Forms.ToolStripLabel label2;
        private System.Windows.Forms.ToolStripTextBox textBox2;
        private System.Windows.Forms.ToolStripLabel label3;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripButton btSearch;
        private System.Windows.Forms.ToolStripButton Del;
        private System.Windows.Forms.ToolStripButton Edit;
    }
}