﻿namespace Aplikasi_Kasir
{
    partial class Jenis
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
            System.Windows.Forms.Label kode_jenisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jenis));
            System.Windows.Forms.Label label1;
            this.db_penjualanDataSet = new Aplikasi_Kasir.db_penjualanDataSet();
            this.tb_jenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_jenisTableAdapter = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.tb_jenisTableAdapter();
            this.tableAdapterManager = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager();
            this.tb_jenisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_jenisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.TB_kode = new System.Windows.Forms.TextBox();
            this.TB_jenis = new System.Windows.Forms.TextBox();
            this.ButtonTambahJenis = new System.Windows.Forms.Button();
            this.ButtonSimpanJenis = new System.Windows.Forms.Button();
            this.ButtonDeleteJenis = new System.Windows.Forms.Button();
            this.BTN_EditJenis = new System.Windows.Forms.Button();
            this.DGV_jenis = new System.Windows.Forms.DataGridView();
            this.BTN_Ubah = new System.Windows.Forms.Button();
            kode_jenisLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingNavigator)).BeginInit();
            this.tb_jenisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jenis)).BeginInit();
            this.SuspendLayout();
            // 
            // kode_jenisLabel
            // 
            kode_jenisLabel.AutoSize = true;
            kode_jenisLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kode_jenisLabel.Location = new System.Drawing.Point(18, 55);
            kode_jenisLabel.Name = "kode_jenisLabel";
            kode_jenisLabel.Size = new System.Drawing.Size(101, 19);
            kode_jenisLabel.TabIndex = 1;
            kode_jenisLabel.Text = "Kode Jenis";
            // 
            // db_penjualanDataSet
            // 
            this.db_penjualanDataSet.DataSetName = "db_penjualanDataSet";
            this.db_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_jenisBindingSource
            // 
            this.tb_jenisBindingSource.DataMember = "tb_jenis";
            this.tb_jenisBindingSource.DataSource = this.db_penjualanDataSet;
            // 
            // tb_jenisTableAdapter
            // 
            this.tb_jenisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_barangTableAdapter = null;
            this.tableAdapterManager.tb_detail_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_jenisTableAdapter = this.tb_jenisTableAdapter;
            this.tableAdapterManager.tb_merkTableAdapter = null;
            this.tableAdapterManager.tb_penggunaTableAdapter = null;
            this.tableAdapterManager.tb_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_satuanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_jenisBindingNavigator
            // 
            this.tb_jenisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_jenisBindingNavigator.BindingSource = this.tb_jenisBindingSource;
            this.tb_jenisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_jenisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_jenisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_jenisBindingNavigatorSaveItem});
            this.tb_jenisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_jenisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_jenisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_jenisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_jenisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_jenisBindingNavigator.Name = "tb_jenisBindingNavigator";
            this.tb_jenisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_jenisBindingNavigator.Size = new System.Drawing.Size(449, 25);
            this.tb_jenisBindingNavigator.TabIndex = 0;
            this.tb_jenisBindingNavigator.Text = "bindingNavigator1";
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
            // tb_jenisBindingNavigatorSaveItem
            // 
            this.tb_jenisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_jenisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_jenisBindingNavigatorSaveItem.Image")));
            this.tb_jenisBindingNavigatorSaveItem.Name = "tb_jenisBindingNavigatorSaveItem";
            this.tb_jenisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_jenisBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_jenisBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_jenisBindingNavigatorSaveItem_Click);
            // 
            // TB_kode
            // 
            this.TB_kode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_jenisBindingSource, "kode_jenis", true));
            this.TB_kode.Location = new System.Drawing.Point(132, 56);
            this.TB_kode.Name = "TB_kode";
            this.TB_kode.Size = new System.Drawing.Size(190, 20);
            this.TB_kode.TabIndex = 2;
            // 
            // TB_jenis
            // 
            this.TB_jenis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_jenisBindingSource, "nama_jenis", true));
            this.TB_jenis.Location = new System.Drawing.Point(132, 87);
            this.TB_jenis.Name = "TB_jenis";
            this.TB_jenis.Size = new System.Drawing.Size(190, 20);
            this.TB_jenis.TabIndex = 4;
            // 
            // ButtonTambahJenis
            // 
            this.ButtonTambahJenis.Location = new System.Drawing.Point(132, 125);
            this.ButtonTambahJenis.Name = "ButtonTambahJenis";
            this.ButtonTambahJenis.Size = new System.Drawing.Size(190, 23);
            this.ButtonTambahJenis.TabIndex = 6;
            this.ButtonTambahJenis.Text = "Tambah";
            this.ButtonTambahJenis.UseVisualStyleBackColor = true;
            this.ButtonTambahJenis.Click += new System.EventHandler(this.ButtonTambahJenis_Click);
            // 
            // ButtonSimpanJenis
            // 
            this.ButtonSimpanJenis.Location = new System.Drawing.Point(345, 49);
            this.ButtonSimpanJenis.Name = "ButtonSimpanJenis";
            this.ButtonSimpanJenis.Size = new System.Drawing.Size(75, 24);
            this.ButtonSimpanJenis.TabIndex = 7;
            this.ButtonSimpanJenis.Text = "Simpan";
            this.ButtonSimpanJenis.UseVisualStyleBackColor = true;
            this.ButtonSimpanJenis.Click += new System.EventHandler(this.ButtonSimpanJenis_Click);
            // 
            // ButtonDeleteJenis
            // 
            this.ButtonDeleteJenis.Location = new System.Drawing.Point(345, 78);
            this.ButtonDeleteJenis.Name = "ButtonDeleteJenis";
            this.ButtonDeleteJenis.Size = new System.Drawing.Size(75, 24);
            this.ButtonDeleteJenis.TabIndex = 9;
            this.ButtonDeleteJenis.Text = "Delete";
            this.ButtonDeleteJenis.UseVisualStyleBackColor = true;
            this.ButtonDeleteJenis.Click += new System.EventHandler(this.ButtonDeleteJenis_Click);
            // 
            // BTN_EditJenis
            // 
            this.BTN_EditJenis.Location = new System.Drawing.Point(345, 107);
            this.BTN_EditJenis.Name = "BTN_EditJenis";
            this.BTN_EditJenis.Size = new System.Drawing.Size(75, 24);
            this.BTN_EditJenis.TabIndex = 10;
            this.BTN_EditJenis.Text = "Edit";
            this.BTN_EditJenis.UseVisualStyleBackColor = true;
            this.BTN_EditJenis.Click += new System.EventHandler(this.BTN_EditJenis_Click);
            // 
            // DGV_jenis
            // 
            this.DGV_jenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_jenis.Location = new System.Drawing.Point(132, 168);
            this.DGV_jenis.Name = "DGV_jenis";
            this.DGV_jenis.Size = new System.Drawing.Size(249, 119);
            this.DGV_jenis.TabIndex = 12;
            this.DGV_jenis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_jenis_CellMouseClick);
            // 
            // BTN_Ubah
            // 
            this.BTN_Ubah.Location = new System.Drawing.Point(345, 138);
            this.BTN_Ubah.Name = "BTN_Ubah";
            this.BTN_Ubah.Size = new System.Drawing.Size(75, 24);
            this.BTN_Ubah.TabIndex = 13;
            this.BTN_Ubah.Text = "Ubah";
            this.BTN_Ubah.UseVisualStyleBackColor = true;
            this.BTN_Ubah.Click += new System.EventHandler(this.BTN_Ubah_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(18, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 19);
            label1.TabIndex = 14;
            label1.Text = "Nama Jenis";
            // 
            // Jenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(449, 309);
            this.Controls.Add(label1);
            this.Controls.Add(this.BTN_Ubah);
            this.Controls.Add(this.DGV_jenis);
            this.Controls.Add(this.BTN_EditJenis);
            this.Controls.Add(this.ButtonDeleteJenis);
            this.Controls.Add(this.ButtonSimpanJenis);
            this.Controls.Add(this.ButtonTambahJenis);
            this.Controls.Add(kode_jenisLabel);
            this.Controls.Add(this.TB_kode);
            this.Controls.Add(this.TB_jenis);
            this.Controls.Add(this.tb_jenisBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jenis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jenis";
            this.Activated += new System.EventHandler(this.Jenis_Activated);
            this.Load += new System.EventHandler(this.Jenis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingNavigator)).EndInit();
            this.tb_jenisBindingNavigator.ResumeLayout(false);
            this.tb_jenisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jenis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_penjualanDataSet db_penjualanDataSet;
        private System.Windows.Forms.BindingSource tb_jenisBindingSource;
        private db_penjualanDataSetTableAdapters.tb_jenisTableAdapter tb_jenisTableAdapter;
        private db_penjualanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_jenisBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_jenisBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox TB_kode;
        private System.Windows.Forms.TextBox TB_jenis;
        private System.Windows.Forms.Button ButtonTambahJenis;
        private System.Windows.Forms.Button ButtonSimpanJenis;
        private System.Windows.Forms.Button ButtonDeleteJenis;
        private System.Windows.Forms.Button BTN_EditJenis;
        private System.Windows.Forms.DataGridView DGV_jenis;
        private System.Windows.Forms.Button BTN_Ubah;
    }
}