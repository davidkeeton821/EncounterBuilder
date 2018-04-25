namespace EncounterBuilder
{
    partial class EncounterDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._dataGridViewCharacters = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Race = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonSave
            // 
            this._buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSave.Location = new System.Drawing.Point(831, 505);
            this._buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 0;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(912, 505);
            this._buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 1;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _textName
            // 
            this._textName.Location = new System.Drawing.Point(112, 16);
            this._textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(289, 22);
            this._textName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // _textDescription
            // 
            this._textDescription.Location = new System.Drawing.Point(112, 46);
            this._textDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._textDescription.Multiline = true;
            this._textDescription.Name = "_textDescription";
            this._textDescription.Size = new System.Drawing.Size(289, 177);
            this._textDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add New Character";
            // 
            // _dataGridViewCharacters
            // 
            this._dataGridViewCharacters.AllowUserToAddRows = false;
            this._dataGridViewCharacters.AllowUserToDeleteRows = false;
            this._dataGridViewCharacters.AllowUserToResizeColumns = false;
            this._dataGridViewCharacters.AllowUserToResizeRows = false;
            this._dataGridViewCharacters.AutoGenerateColumns = false;
            this._dataGridViewCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.Race,
            this.levelDataGridViewTextBoxColumn});
            this._dataGridViewCharacters.DataSource = this.characterBindingSource;
            this._dataGridViewCharacters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridViewCharacters.Location = new System.Drawing.Point(430, 15);
            this._dataGridViewCharacters.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewCharacters.MinimumSize = new System.Drawing.Size(421, 47);
            this._dataGridViewCharacters.MultiSelect = false;
            this._dataGridViewCharacters.Name = "_dataGridViewCharacters";
            this._dataGridViewCharacters.ReadOnly = true;
            this._dataGridViewCharacters.RowHeadersVisible = false;
            this._dataGridViewCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewCharacters.ShowCellErrors = false;
            this._dataGridViewCharacters.Size = new System.Drawing.Size(557, 429);
            this._dataGridViewCharacters.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Race
            // 
            this.Race.DataPropertyName = "Race";
            this.Race.HeaderText = "Race";
            this.Race.Name = "Race";
            this.Race.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "LV";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Width = 30;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(EncounterBuilder.Character);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(322, 259);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(100, 28);
            this._btnAdd.TabIndex = 9;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edit Selected Character";
            // 
            // _btnEdit
            // 
            this._btnEdit.Location = new System.Drawing.Point(322, 312);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(100, 28);
            this._btnEdit.TabIndex = 11;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.OnCharacterEdit);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(322, 416);
            this._btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(100, 28);
            this._btnDelete.TabIndex = 12;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this.OnCharacterDelete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Delete Selected Character";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 126);
            this.button1.TabIndex = 14;
            this.button1.Text = "Run Encounter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnEncounterRun);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCopy);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Copy Selected Character";
            // 
            // EncounterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(999, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._dataGridViewCharacters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textName);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 264);
            this.Name = "EncounterDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encounter Details";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.TextBox _textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView _dataGridViewCharacters;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Race;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}