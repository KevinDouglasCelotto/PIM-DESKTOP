
namespace ProjetoPIM04.Apresentacao
{
    partial class FrmCk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCk));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeClLabel;
            System.Windows.Forms.Label data_entradaLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            this.projetoLoginDataSet2 = new ProjetoPIM04.ProjetoLoginDataSet2();
            this.tb_CkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CkTableAdapter = new ProjetoPIM04.ProjetoLoginDataSet2TableAdapters.tb_CkTableAdapter();
            this.tableAdapterManager = new ProjetoPIM04.ProjetoLoginDataSet2TableAdapters.TableAdapterManager();
            this.tb_CkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_CkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeClTextBox = new System.Windows.Forms.TextBox();
            this.data_entradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_CkDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeClLabel = new System.Windows.Forms.Label();
            data_entradaLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkBindingNavigator)).BeginInit();
            this.tb_CkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projetoLoginDataSet2
            // 
            this.projetoLoginDataSet2.DataSetName = "ProjetoLoginDataSet2";
            this.projetoLoginDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CkBindingSource
            // 
            this.tb_CkBindingSource.DataMember = "tb_Ck";
            this.tb_CkBindingSource.DataSource = this.projetoLoginDataSet2;
            // 
            // tb_CkTableAdapter
            // 
            this.tb_CkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_CkTableAdapter = this.tb_CkTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPIM04.ProjetoLoginDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_CkBindingNavigator
            // 
            this.tb_CkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_CkBindingNavigator.BindingSource = this.tb_CkBindingSource;
            this.tb_CkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_CkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_CkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_CkBindingNavigatorSaveItem});
            this.tb_CkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_CkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_CkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_CkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_CkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_CkBindingNavigator.Name = "tb_CkBindingNavigator";
            this.tb_CkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_CkBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tb_CkBindingNavigator.TabIndex = 0;
            this.tb_CkBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_CkBindingNavigatorSaveItem
            // 
            this.tb_CkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_CkBindingNavigatorSaveItem.Image")));
            this.tb_CkBindingNavigatorSaveItem.Name = "tb_CkBindingNavigatorSaveItem";
            this.tb_CkBindingNavigatorSaveItem.Size = new System.Drawing.Size(94, 22);
            this.tb_CkBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_CkBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_CkBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 102);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(85, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Código Check-in";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CkBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(114, 95);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeClLabel
            // 
            nomeClLabel.AutoSize = true;
            nomeClLabel.Location = new System.Drawing.Point(24, 128);
            nomeClLabel.Name = "nomeClLabel";
            nomeClLabel.Size = new System.Drawing.Size(70, 13);
            nomeClLabel.TabIndex = 3;
            nomeClLabel.Text = "Nome Cliente";
            // 
            // nomeClTextBox
            // 
            this.nomeClTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CkBindingSource, "nomeCl", true));
            this.nomeClTextBox.Location = new System.Drawing.Point(114, 121);
            this.nomeClTextBox.Name = "nomeClTextBox";
            this.nomeClTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeClTextBox.TabIndex = 4;
            // 
            // data_entradaLabel
            // 
            data_entradaLabel.AutoSize = true;
            data_entradaLabel.Location = new System.Drawing.Point(19, 157);
            data_entradaLabel.Name = "data_entradaLabel";
            data_entradaLabel.Size = new System.Drawing.Size(84, 13);
            data_entradaLabel.TabIndex = 5;
            data_entradaLabel.Text = "Data de entrada";
            // 
            // data_entradaDateTimePicker
            // 
            this.data_entradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_CkBindingSource, "data_entrada", true));
            this.data_entradaDateTimePicker.Location = new System.Drawing.Point(114, 151);
            this.data_entradaDateTimePicker.Name = "data_entradaDateTimePicker";
            this.data_entradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_entradaDateTimePicker.TabIndex = 6;
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.Location = new System.Drawing.Point(19, 184);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(75, 13);
            data_vencimentoLabel.TabIndex = 7;
            data_vencimentoLabel.Text = "Data de saída";
            // 
            // data_vencimentoDateTimePicker
            // 
            this.data_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_CkBindingSource, "data_vencimento", true));
            this.data_vencimentoDateTimePicker.Location = new System.Drawing.Point(114, 184);
            this.data_vencimentoDateTimePicker.Name = "data_vencimentoDateTimePicker";
            this.data_vencimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_vencimentoDateTimePicker.TabIndex = 8;
            // 
            // tb_CkDataGridView
            // 
            this.tb_CkDataGridView.AutoGenerateColumns = false;
            this.tb_CkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_CkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tb_CkDataGridView.DataSource = this.tb_CkBindingSource;
            this.tb_CkDataGridView.Location = new System.Drawing.Point(44, 258);
            this.tb_CkDataGridView.Name = "tb_CkDataGridView";
            this.tb_CkDataGridView.Size = new System.Drawing.Size(452, 220);
            this.tb_CkDataGridView.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 185);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Check-in";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCl";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_entrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Entrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_vencimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Saída";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmCk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_CkDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeClLabel);
            this.Controls.Add(this.nomeClTextBox);
            this.Controls.Add(data_entradaLabel);
            this.Controls.Add(this.data_entradaDateTimePicker);
            this.Controls.Add(data_vencimentoLabel);
            this.Controls.Add(this.data_vencimentoDateTimePicker);
            this.Controls.Add(this.tb_CkBindingNavigator);
            this.Name = "FrmCk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCk";
            this.Load += new System.EventHandler(this.FrmCk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkBindingNavigator)).EndInit();
            this.tb_CkBindingNavigator.ResumeLayout(false);
            this.tb_CkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjetoLoginDataSet2 projetoLoginDataSet2;
        private System.Windows.Forms.BindingSource tb_CkBindingSource;
        private ProjetoLoginDataSet2TableAdapters.tb_CkTableAdapter tb_CkTableAdapter;
        private ProjetoLoginDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_CkBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_CkBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeClTextBox;
        private System.Windows.Forms.DateTimePicker data_entradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_vencimentoDateTimePicker;
        private System.Windows.Forms.DataGridView tb_CkDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}