namespace MeusContatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_CONTATOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label aNIVERSARIOLabel;
            System.Windows.Forms.Label fAMILIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cONTATOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cONTATOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_CONTATOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.fAMILIACheckBox = new System.Windows.Forms.CheckBox();
            this.aNIVERSARIOTextBox = new System.Windows.Forms.TextBox();
            this.cONTATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDeContatosDataSet = new MeusContatos.AgendaDeContatosDataSet();
            this.cONTATOSTableAdapter = new MeusContatos.AgendaDeContatosDataSetTableAdapters.CONTATOSTableAdapter();
            this.tableAdapterManager = new MeusContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager();
            id_CONTATOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            aNIVERSARIOLabel = new System.Windows.Forms.Label();
            fAMILIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cONTATOSBindingNavigator)).BeginInit();
            this.cONTATOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_CONTATOLabel
            // 
            id_CONTATOLabel.AutoSize = true;
            id_CONTATOLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_CONTATOLabel.Location = new System.Drawing.Point(16, 89);
            id_CONTATOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_CONTATOLabel.Name = "id_CONTATOLabel";
            id_CONTATOLabel.Size = new System.Drawing.Size(57, 23);
            id_CONTATOLabel.TabIndex = 1;
            id_CONTATOLabel.Text = "Código:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(16, 135);
            nOMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(51, 23);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Nome:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(16, 181);
            tELEFONELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(69, 23);
            tELEFONELabel.TabIndex = 5;
            tELEFONELabel.Text = "Telefone:";
            // 
            // aNIVERSARIOLabel
            // 
            aNIVERSARIOLabel.AutoSize = true;
            aNIVERSARIOLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aNIVERSARIOLabel.Location = new System.Drawing.Point(16, 228);
            aNIVERSARIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aNIVERSARIOLabel.Name = "aNIVERSARIOLabel";
            aNIVERSARIOLabel.Size = new System.Drawing.Size(89, 23);
            aNIVERSARIOLabel.TabIndex = 7;
            aNIVERSARIOLabel.Text = "Aniversário:";
            // 
            // fAMILIALabel
            // 
            fAMILIALabel.AutoSize = true;
            fAMILIALabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fAMILIALabel.Location = new System.Drawing.Point(311, 228);
            fAMILIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fAMILIALabel.Name = "fAMILIALabel";
            fAMILIALabel.Size = new System.Drawing.Size(63, 23);
            fAMILIALabel.TabIndex = 9;
            fAMILIALabel.Text = "Familia:";
            // 
            // cONTATOSBindingNavigator
            // 
            this.cONTATOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cONTATOSBindingNavigator.BindingSource = this.cONTATOSBindingSource;
            this.cONTATOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cONTATOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cONTATOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cONTATOSBindingNavigatorSaveItem});
            this.cONTATOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cONTATOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cONTATOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cONTATOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cONTATOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cONTATOSBindingNavigator.Name = "cONTATOSBindingNavigator";
            this.cONTATOSBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cONTATOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cONTATOSBindingNavigator.Size = new System.Drawing.Size(611, 25);
            this.cONTATOSBindingNavigator.TabIndex = 0;
            this.cONTATOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(66, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cONTATOSBindingNavigatorSaveItem
            // 
            this.cONTATOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cONTATOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cONTATOSBindingNavigatorSaveItem.Image")));
            this.cONTATOSBindingNavigatorSaveItem.Name = "cONTATOSBindingNavigatorSaveItem";
            this.cONTATOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cONTATOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cONTATOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cONTATOSBindingNavigatorSaveItem_Click);
            // 
            // id_CONTATOTextBox
            // 
            this.id_CONTATOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTATOSBindingSource, "Id_CONTATO", true));
            this.id_CONTATOTextBox.Enabled = false;
            this.id_CONTATOTextBox.Location = new System.Drawing.Point(134, 83);
            this.id_CONTATOTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_CONTATOTextBox.Name = "id_CONTATOTextBox";
            this.id_CONTATOTextBox.ReadOnly = true;
            this.id_CONTATOTextBox.Size = new System.Drawing.Size(79, 30);
            this.id_CONTATOTextBox.TabIndex = 2;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTATOSBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(134, 129);
            this.nOMETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(375, 30);
            this.nOMETextBox.TabIndex = 4;
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTATOSBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Location = new System.Drawing.Point(134, 175);
            this.tELEFONETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(138, 30);
            this.tELEFONETextBox.TabIndex = 6;
            // 
            // fAMILIACheckBox
            // 
            this.fAMILIACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cONTATOSBindingSource, "FAMILIA", true));
            this.fAMILIACheckBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fAMILIACheckBox.Location = new System.Drawing.Point(405, 224);
            this.fAMILIACheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fAMILIACheckBox.Name = "fAMILIACheckBox";
            this.fAMILIACheckBox.Size = new System.Drawing.Size(118, 31);
            this.fAMILIACheckBox.TabIndex = 10;
            this.fAMILIACheckBox.Text = "É da Família";
            this.fAMILIACheckBox.UseVisualStyleBackColor = true;
            // 
            // aNIVERSARIOTextBox
            // 
            this.aNIVERSARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTATOSBindingSource, "ANIVERSARIO", true));
            this.aNIVERSARIOTextBox.Location = new System.Drawing.Point(134, 224);
            this.aNIVERSARIOTextBox.Name = "aNIVERSARIOTextBox";
            this.aNIVERSARIOTextBox.Size = new System.Drawing.Size(100, 30);
            this.aNIVERSARIOTextBox.TabIndex = 12;
            // 
            // cONTATOSBindingSource
            // 
            this.cONTATOSBindingSource.DataMember = "CONTATOS";
            this.cONTATOSBindingSource.DataSource = this.agendaDeContatosDataSet;
            // 
            // agendaDeContatosDataSet
            // 
            this.agendaDeContatosDataSet.DataSetName = "AgendaDeContatosDataSet";
            this.agendaDeContatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTATOSTableAdapter
            // 
            this.cONTATOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONTATOSTableAdapter = this.cONTATOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = MeusContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 327);
            this.Controls.Add(this.aNIVERSARIOTextBox);
            this.Controls.Add(id_CONTATOLabel);
            this.Controls.Add(this.id_CONTATOTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(aNIVERSARIOLabel);
            this.Controls.Add(fAMILIALabel);
            this.Controls.Add(this.fAMILIACheckBox);
            this.Controls.Add(this.cONTATOSBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "MEUS CONTATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONTATOSBindingNavigator)).EndInit();
            this.cONTATOSBindingNavigator.ResumeLayout(false);
            this.cONTATOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgendaDeContatosDataSet agendaDeContatosDataSet;
        private System.Windows.Forms.BindingSource cONTATOSBindingSource;
        private AgendaDeContatosDataSetTableAdapters.CONTATOSTableAdapter cONTATOSTableAdapter;
        private AgendaDeContatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cONTATOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cONTATOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_CONTATOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.CheckBox fAMILIACheckBox;
        private System.Windows.Forms.TextBox aNIVERSARIOTextBox;
    }
}

