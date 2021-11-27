
namespace ProjetoPIM04.Apresentacao
{
    partial class Checkin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkin));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_reservaLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            System.Windows.Forms.Label cl_nomeLabel;
            this.projetoLoginDataSet1 = new ProjetoPIM04.ProjetoLoginDataSet1();
            this.tb_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ClienteTableAdapter = new ProjetoPIM04.ProjetoLoginDataSet1TableAdapters.tb_ClienteTableAdapter();
            this.tableAdapterManager = new ProjetoPIM04.ProjetoLoginDataSet1TableAdapters.TableAdapterManager();
            this.tb_ClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_ClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.projetoLoginDataSet = new ProjetoPIM04.ProjetoLoginDataSet();
            this.tb_CheckinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CheckinTableAdapter = new ProjetoPIM04.ProjetoLoginDataSetTableAdapters.tb_CheckinTableAdapter();
            this.tableAdapterManager1 = new ProjetoPIM04.ProjetoLoginDataSetTableAdapters.TableAdapterManager();
            this.tb_CheckinDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_reservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cl_nomeComboBox = new System.Windows.Forms.ComboBox();
            this.tabelaCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_reservaLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            cl_nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingNavigator)).BeginInit();
            this.tb_ClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CheckinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CheckinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projetoLoginDataSet1
            // 
            this.projetoLoginDataSet1.DataSetName = "ProjetoLoginDataSet1";
            this.projetoLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ClienteBindingSource
            // 
            this.tb_ClienteBindingSource.DataMember = "tb_Cliente";
            this.tb_ClienteBindingSource.DataSource = this.projetoLoginDataSet1;
            // 
            // tb_ClienteTableAdapter
            // 
            this.tb_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ClienteTableAdapter = this.tb_ClienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPIM04.ProjetoLoginDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ClienteBindingNavigator
            // 
            this.tb_ClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ClienteBindingNavigator.BindingSource = this.tb_ClienteBindingSource;
            this.tb_ClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_ClienteBindingNavigatorSaveItem});
            this.tb_ClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ClienteBindingNavigator.Name = "tb_ClienteBindingNavigator";
            this.tb_ClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ClienteBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tb_ClienteBindingNavigator.TabIndex = 0;
            this.tb_ClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_ClienteBindingNavigatorSaveItem
            // 
            this.tb_ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ClienteBindingNavigatorSaveItem.Image")));
            this.tb_ClienteBindingNavigatorSaveItem.Name = "tb_ClienteBindingNavigatorSaveItem";
            this.tb_ClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_ClienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_ClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ClienteBindingNavigatorSaveItem_Click);
            // 
            // projetoLoginDataSet
            // 
            this.projetoLoginDataSet.DataSetName = "ProjetoLoginDataSet";
            this.projetoLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CheckinBindingSource
            // 
            this.tb_CheckinBindingSource.DataMember = "tb_Checkin";
            this.tb_CheckinBindingSource.DataSource = this.projetoLoginDataSet;
            // 
            // tb_CheckinTableAdapter
            // 
            this.tb_CheckinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tb_CheckinTableAdapter = this.tb_CheckinTableAdapter;
            this.tableAdapterManager1.UpdateOrder = ProjetoPIM04.ProjetoLoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_CheckinDataGridView
            // 
            this.tb_CheckinDataGridView.AllowUserToAddRows = false;
            this.tb_CheckinDataGridView.AllowUserToDeleteRows = false;
            this.tb_CheckinDataGridView.AutoGenerateColumns = false;
            this.tb_CheckinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_CheckinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tb_CheckinDataGridView.DataSource = this.tb_CheckinBindingSource;
            this.tb_CheckinDataGridView.Location = new System.Drawing.Point(12, 218);
            this.tb_CheckinDataGridView.Name = "tb_CheckinDataGridView";
            this.tb_CheckinDataGridView.ReadOnly = true;
            this.tb_CheckinDataGridView.Size = new System.Drawing.Size(461, 220);
            this.tb_CheckinDataGridView.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CheckinBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(110, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(15, 114);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(83, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Escolher Cliente";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CheckinBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(110, 111);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // data_reservaLabel
            // 
            data_reservaLabel.AutoSize = true;
            data_reservaLabel.Location = new System.Drawing.Point(15, 141);
            data_reservaLabel.Name = "data_reservaLabel";
            data_reservaLabel.Size = new System.Drawing.Size(69, 13);
            data_reservaLabel.TabIndex = 6;
            data_reservaLabel.Text = "data reserva:";
            // 
            // data_reservaDateTimePicker
            // 
            this.data_reservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_CheckinBindingSource, "data_reserva", true));
            this.data_reservaDateTimePicker.Location = new System.Drawing.Point(110, 137);
            this.data_reservaDateTimePicker.Name = "data_reservaDateTimePicker";
            this.data_reservaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_reservaDateTimePicker.TabIndex = 7;
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.Location = new System.Drawing.Point(15, 167);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(89, 13);
            data_vencimentoLabel.TabIndex = 8;
            data_vencimentoLabel.Text = "data vencimento:";
            // 
            // data_vencimentoDateTimePicker
            // 
            this.data_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_CheckinBindingSource, "data_vencimento", true));
            this.data_vencimentoDateTimePicker.Location = new System.Drawing.Point(110, 163);
            this.data_vencimentoDateTimePicker.Name = "data_vencimentoDateTimePicker";
            this.data_vencimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_vencimentoDateTimePicker.TabIndex = 9;
            // 
            // cl_nomeLabel
            // 
            cl_nomeLabel.AutoSize = true;
            cl_nomeLabel.Location = new System.Drawing.Point(-1, 87);
            cl_nomeLabel.Name = "cl_nomeLabel";
            cl_nomeLabel.Size = new System.Drawing.Size(105, 13);
            cl_nomeLabel.TabIndex = 10;
            cl_nomeLabel.Text = "Clientes cadastrados";
            // 
            // cl_nomeComboBox
            // 
            this.cl_nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaCCBindingSource, "cl_nome", true));
            this.cl_nomeComboBox.DataSource = this.tabelaCCBindingSource;
            this.cl_nomeComboBox.DisplayMember = "cl_nome";
            this.cl_nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cl_nomeComboBox.FormattingEnabled = true;
            this.cl_nomeComboBox.Location = new System.Drawing.Point(110, 84);
            this.cl_nomeComboBox.Name = "cl_nomeComboBox";
            this.cl_nomeComboBox.Size = new System.Drawing.Size(200, 21);
            this.cl_nomeComboBox.TabIndex = 11;
            this.cl_nomeComboBox.ValueMember = "cl_id";
            // 
            // tabelaCCBindingSource
            // 
            this.tabelaCCBindingSource.DataSource = typeof(sistema.DAL.TabelaCC);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_reserva";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data da reserva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_vencimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de vencimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(cl_nomeLabel);
            this.Controls.Add(this.cl_nomeComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_reservaLabel);
            this.Controls.Add(this.data_reservaDateTimePicker);
            this.Controls.Add(data_vencimentoLabel);
            this.Controls.Add(this.data_vencimentoDateTimePicker);
            this.Controls.Add(this.tb_CheckinDataGridView);
            this.Controls.Add(this.tb_ClienteBindingNavigator);
            this.Name = "Checkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingNavigator)).EndInit();
            this.tb_ClienteBindingNavigator.ResumeLayout(false);
            this.tb_ClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CheckinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CheckinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjetoLoginDataSet1 projetoLoginDataSet1;
        private System.Windows.Forms.BindingSource tb_ClienteBindingSource;
        private ProjetoLoginDataSet1TableAdapters.tb_ClienteTableAdapter tb_ClienteTableAdapter;
        private ProjetoLoginDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ClienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_ClienteBindingNavigatorSaveItem;
        private ProjetoLoginDataSet projetoLoginDataSet;
        private System.Windows.Forms.BindingSource tb_CheckinBindingSource;
        private ProjetoLoginDataSetTableAdapters.tb_CheckinTableAdapter tb_CheckinTableAdapter;
        private ProjetoLoginDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tb_CheckinDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_reservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_vencimentoDateTimePicker;
        private System.Windows.Forms.BindingSource tabelaCCBindingSource;
        private System.Windows.Forms.ComboBox cl_nomeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}