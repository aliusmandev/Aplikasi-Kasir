namespace Aplikasi_Kasir
{
    partial class Merk
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label kode_jenisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merk));
            this.db_penjualanDataSet = new Aplikasi_Kasir.db_penjualanDataSet();
            this.tb_merkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_merkTableAdapter = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.tb_merkTableAdapter();
            this.tableAdapterManager = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager();
            this.tb_merkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_merkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kode_merkTextBox = new System.Windows.Forms.TextBox();
            this.nama_merkTextBox = new System.Windows.Forms.TextBox();
            this.DGV_Merk = new System.Windows.Forms.DataGridView();
            this.BTN_UbahMerk = new System.Windows.Forms.Button();
            this.BTN_EditMerk = new System.Windows.Forms.Button();
            this.BTN_DeleteMerk = new System.Windows.Forms.Button();
            this.BTN_SimpanMerk = new System.Windows.Forms.Button();
            this.BTN_TambahMerk = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            kode_jenisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_merkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_merkBindingNavigator)).BeginInit();
            this.tb_merkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Merk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 18);
            label1.TabIndex = 16;
            label1.Text = "Nama Merk";
            // 
            // kode_jenisLabel
            // 
            kode_jenisLabel.AutoSize = true;
            kode_jenisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kode_jenisLabel.Location = new System.Drawing.Point(13, 73);
            kode_jenisLabel.Name = "kode_jenisLabel";
            kode_jenisLabel.Size = new System.Drawing.Size(90, 18);
            kode_jenisLabel.TabIndex = 15;
            kode_jenisLabel.Text = "Kode Merk";
            // 
            // db_penjualanDataSet
            // 
            this.db_penjualanDataSet.DataSetName = "db_penjualanDataSet";
            this.db_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_merkBindingSource
            // 
            this.tb_merkBindingSource.DataMember = "tb_merk";
            this.tb_merkBindingSource.DataSource = this.db_penjualanDataSet;
            // 
            // tb_merkTableAdapter
            // 
            this.tb_merkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_barangTableAdapter = null;
            this.tableAdapterManager.tb_detail_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_jenisTableAdapter = null;
            this.tableAdapterManager.tb_merkTableAdapter = this.tb_merkTableAdapter;
            this.tableAdapterManager.tb_penggunaTableAdapter = null;
            this.tableAdapterManager.tb_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_satuanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_merkBindingNavigator
            // 
            this.tb_merkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_merkBindingNavigator.BindingSource = this.tb_merkBindingSource;
            this.tb_merkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_merkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_merkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_merkBindingNavigatorSaveItem});
            this.tb_merkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_merkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_merkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_merkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_merkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_merkBindingNavigator.Name = "tb_merkBindingNavigator";
            this.tb_merkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_merkBindingNavigator.Size = new System.Drawing.Size(461, 25);
            this.tb_merkBindingNavigator.TabIndex = 0;
            this.tb_merkBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // tb_merkBindingNavigatorSaveItem
            // 
            this.tb_merkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_merkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_merkBindingNavigatorSaveItem.Image")));
            this.tb_merkBindingNavigatorSaveItem.Name = "tb_merkBindingNavigatorSaveItem";
            this.tb_merkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_merkBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_merkBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_merkBindingNavigatorSaveItem_Click);
            // 
            // kode_merkTextBox
            // 
            this.kode_merkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_merkBindingSource, "kode_merk", true));
            this.kode_merkTextBox.Location = new System.Drawing.Point(122, 75);
            this.kode_merkTextBox.Name = "kode_merkTextBox";
            this.kode_merkTextBox.Size = new System.Drawing.Size(178, 20);
            this.kode_merkTextBox.TabIndex = 2;
            // 
            // nama_merkTextBox
            // 
            this.nama_merkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_merkBindingSource, "nama_merk", true));
            this.nama_merkTextBox.Location = new System.Drawing.Point(122, 110);
            this.nama_merkTextBox.Name = "nama_merkTextBox";
            this.nama_merkTextBox.Size = new System.Drawing.Size(178, 20);
            this.nama_merkTextBox.TabIndex = 4;
            // 
            // DGV_Merk
            // 
            this.DGV_Merk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Merk.Location = new System.Drawing.Point(122, 186);
            this.DGV_Merk.Name = "DGV_Merk";
            this.DGV_Merk.Size = new System.Drawing.Size(281, 252);
            this.DGV_Merk.TabIndex = 17;
            // 
            // BTN_UbahMerk
            // 
            this.BTN_UbahMerk.Location = new System.Drawing.Point(345, 149);
            this.BTN_UbahMerk.Name = "BTN_UbahMerk";
            this.BTN_UbahMerk.Size = new System.Drawing.Size(75, 24);
            this.BTN_UbahMerk.TabIndex = 23;
            this.BTN_UbahMerk.Text = "Ubah";
            this.BTN_UbahMerk.UseVisualStyleBackColor = true;
            // 
            // BTN_EditMerk
            // 
            this.BTN_EditMerk.Location = new System.Drawing.Point(345, 118);
            this.BTN_EditMerk.Name = "BTN_EditMerk";
            this.BTN_EditMerk.Size = new System.Drawing.Size(75, 24);
            this.BTN_EditMerk.TabIndex = 22;
            this.BTN_EditMerk.Text = "Edit";
            this.BTN_EditMerk.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteMerk
            // 
            this.BTN_DeleteMerk.Location = new System.Drawing.Point(345, 89);
            this.BTN_DeleteMerk.Name = "BTN_DeleteMerk";
            this.BTN_DeleteMerk.Size = new System.Drawing.Size(75, 24);
            this.BTN_DeleteMerk.TabIndex = 21;
            this.BTN_DeleteMerk.Text = "Delete";
            this.BTN_DeleteMerk.UseVisualStyleBackColor = true;
            // 
            // BTN_SimpanMerk
            // 
            this.BTN_SimpanMerk.Location = new System.Drawing.Point(345, 60);
            this.BTN_SimpanMerk.Name = "BTN_SimpanMerk";
            this.BTN_SimpanMerk.Size = new System.Drawing.Size(75, 24);
            this.BTN_SimpanMerk.TabIndex = 20;
            this.BTN_SimpanMerk.Text = "Simpan";
            this.BTN_SimpanMerk.UseVisualStyleBackColor = true;
            // 
            // BTN_TambahMerk
            // 
            this.BTN_TambahMerk.Location = new System.Drawing.Point(122, 146);
            this.BTN_TambahMerk.Name = "BTN_TambahMerk";
            this.BTN_TambahMerk.Size = new System.Drawing.Size(190, 23);
            this.BTN_TambahMerk.TabIndex = 19;
            this.BTN_TambahMerk.Text = "Tambah";
            this.BTN_TambahMerk.UseVisualStyleBackColor = true;
            // 
            // Merk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.BTN_UbahMerk);
            this.Controls.Add(this.BTN_EditMerk);
            this.Controls.Add(this.BTN_DeleteMerk);
            this.Controls.Add(this.BTN_SimpanMerk);
            this.Controls.Add(this.BTN_TambahMerk);
            this.Controls.Add(this.DGV_Merk);
            this.Controls.Add(label1);
            this.Controls.Add(kode_jenisLabel);
            this.Controls.Add(this.kode_merkTextBox);
            this.Controls.Add(this.nama_merkTextBox);
            this.Controls.Add(this.tb_merkBindingNavigator);
            this.Name = "Merk";
            this.Text = "Merk";
            this.Load += new System.EventHandler(this.Merk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_merkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_merkBindingNavigator)).EndInit();
            this.tb_merkBindingNavigator.ResumeLayout(false);
            this.tb_merkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Merk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_penjualanDataSet db_penjualanDataSet;
        private System.Windows.Forms.BindingSource tb_merkBindingSource;
        private db_penjualanDataSetTableAdapters.tb_merkTableAdapter tb_merkTableAdapter;
        private db_penjualanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_merkBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_merkBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kode_merkTextBox;
        private System.Windows.Forms.TextBox nama_merkTextBox;
        private System.Windows.Forms.DataGridView DGV_Merk;
        private System.Windows.Forms.Button BTN_UbahMerk;
        private System.Windows.Forms.Button BTN_EditMerk;
        private System.Windows.Forms.Button BTN_DeleteMerk;
        private System.Windows.Forms.Button BTN_SimpanMerk;
        private System.Windows.Forms.Button BTN_TambahMerk;
    }
}