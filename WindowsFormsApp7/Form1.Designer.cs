
namespace WindowsFormsApp7
{
    partial class formUsers
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.institutoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institutoDataSet = new WindowsFormsApp7.institutoDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institutoTableAdapter = new WindowsFormsApp7.institutoDataSetTableAdapters.institutoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.institutoDataSetTableAdapters.TableAdapterManager();
            this.notasTableAdapter = new WindowsFormsApp7.institutoDataSetTableAdapters.notasTableAdapter();
            this.notasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimestresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trimestresTableAdapter = new WindowsFormsApp7.institutoDataSetTableAdapters.trimestresTableAdapter();
            this.trimestresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(113, 609);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 17);
            this.lbCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1190, 30);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addNoteToolStripMenuItem});
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.añadirToolStripMenuItem.Text = "Add";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Enabled = false;
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
            this.borrarToolStripMenuItem.Enabled = false;
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.borrarToolStripMenuItem.Text = "Delete";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Enabled = false;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Enabled = false;
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyUserToolStripMenuItem,
            this.modifyNoteToolStripMenuItem});
            this.modificarToolStripMenuItem.Enabled = false;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.modificarToolStripMenuItem.Text = "Modify";
            // 
            // modifyUserToolStripMenuItem
            // 
            this.modifyUserToolStripMenuItem.Enabled = false;
            this.modifyUserToolStripMenuItem.Name = "modifyUserToolStripMenuItem";
            this.modifyUserToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.modifyUserToolStripMenuItem.Text = "Modify User";
            this.modifyUserToolStripMenuItem.Click += new System.EventHandler(this.modifyUserToolStripMenuItem_Click);
            // 
            // modifyNoteToolStripMenuItem
            // 
            this.modifyNoteToolStripMenuItem.Enabled = false;
            this.modifyNoteToolStripMenuItem.Name = "modifyNoteToolStripMenuItem";
            this.modifyNoteToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.modifyNoteToolStripMenuItem.Text = "Modify Note";
            this.modifyNoteToolStripMenuItem.Click += new System.EventHandler(this.modifyNoteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "RowIndexUser:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Query:";
            // 
            // institutoDataGridView
            // 
            this.institutoDataGridView.AllowUserToAddRows = false;
            this.institutoDataGridView.AllowUserToDeleteRows = false;
            this.institutoDataGridView.AutoGenerateColumns = false;
            this.institutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.institutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.institutoDataGridView.DataSource = this.institutoBindingSource;
            this.institutoDataGridView.Location = new System.Drawing.Point(15, 80);
            this.institutoDataGridView.Name = "institutoDataGridView";
            this.institutoDataGridView.ReadOnly = true;
            this.institutoDataGridView.RowHeadersWidth = 51;
            this.institutoDataGridView.RowTemplate.Height = 24;
            this.institutoDataGridView.Size = new System.Drawing.Size(554, 363);
            this.institutoDataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "RowIndexNotes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Students";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(820, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Class Average:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 12;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.institutoDataSet;
            // 
            // institutoDataSet
            // 
            this.institutoDataSet.DataSetName = "institutoDataSet";
            this.institutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QUARTER";
            this.dataGridViewTextBoxColumn4.HeaderText = "QUARTER";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AVERAGE";
            this.dataGridViewTextBoxColumn5.HeaderText = "AVERAGE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // institutoBindingSource
            // 
            this.institutoBindingSource.DataMember = "instituto";
            this.institutoBindingSource.DataSource = this.institutoDataSet;
            // 
            // institutoTableAdapter
            // 
            this.institutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.institutoTableAdapter = this.institutoTableAdapter;
            this.tableAdapterManager.notasTableAdapter = null;
            this.tableAdapterManager.trimestresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp7.institutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // notasDataGridView
            // 
            this.notasDataGridView.AllowUserToAddRows = false;
            this.notasDataGridView.AllowUserToDeleteRows = false;
            this.notasDataGridView.AutoGenerateColumns = false;
            this.notasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.notasDataGridView.DataSource = this.notasBindingSource;
            this.notasDataGridView.Location = new System.Drawing.Point(602, 80);
            this.notasDataGridView.Name = "notasDataGridView";
            this.notasDataGridView.ReadOnly = true;
            this.notasDataGridView.RowHeadersWidth = 51;
            this.notasDataGridView.RowTemplate.Height = 24;
            this.notasDataGridView.Size = new System.Drawing.Size(568, 153);
            this.notasDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn7.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NOTE";
            this.dataGridViewTextBoxColumn8.HeaderText = "NOTE";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_STUDENT";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID_STUDENT";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QUARTER";
            this.dataGridViewTextBoxColumn10.HeaderText = "QUARTER";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // trimestresBindingSource
            // 
            this.trimestresBindingSource.DataMember = "trimestres";
            this.trimestresBindingSource.DataSource = this.institutoDataSet;
            // 
            // trimestresTableAdapter
            // 
            this.trimestresTableAdapter.ClearBeforeFill = true;
            // 
            // trimestresDataGridView
            // 
            this.trimestresDataGridView.AllowUserToAddRows = false;
            this.trimestresDataGridView.AllowUserToDeleteRows = false;
            this.trimestresDataGridView.AutoGenerateColumns = false;
            this.trimestresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trimestresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.trimestresDataGridView.DataSource = this.trimestresBindingSource;
            this.trimestresDataGridView.Location = new System.Drawing.Point(602, 276);
            this.trimestresDataGridView.Name = "trimestresDataGridView";
            this.trimestresDataGridView.ReadOnly = true;
            this.trimestresDataGridView.RowHeadersWidth = 51;
            this.trimestresDataGridView.RowTemplate.Height = 24;
            this.trimestresDataGridView.Size = new System.Drawing.Size(568, 167);
            this.trimestresDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_STUDENT";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID_STUDENT";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "QUARTER1_AVG";
            this.dataGridViewTextBoxColumn12.HeaderText = "QUARTER1_AVG";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "QUARTER2_AVG";
            this.dataGridViewTextBoxColumn13.HeaderText = "QUARTER2_AVG";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "QUARTER3_AVG";
            this.dataGridViewTextBoxColumn14.HeaderText = "QUARTER3_AVG";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(820, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quarters";
            // 
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 647);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trimestresDataGridView);
            this.Controls.Add(this.notasDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.institutoDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private institutoDataSet institutoDataSet;
        private System.Windows.Forms.BindingSource institutoBindingSource;
        private institutoDataSetTableAdapters.institutoTableAdapter institutoTableAdapter;
        private institutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView institutoDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private institutoDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        public System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modifyUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modifyNoteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView notasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource trimestresBindingSource;
        private institutoDataSetTableAdapters.trimestresTableAdapter trimestresTableAdapter;
        private System.Windows.Forms.DataGridView trimestresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label10;
    }
}

