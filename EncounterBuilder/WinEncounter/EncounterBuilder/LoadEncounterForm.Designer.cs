namespace EncounterBuilder
{
    partial class LoadEncounterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataGridViewLoadEncounter = new System.Windows.Forms.DataGridView();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewLoadEncounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewLoadEncounter
            // 
            this._dataGridViewLoadEncounter.AllowUserToAddRows = false;
            this._dataGridViewLoadEncounter.AllowUserToDeleteRows = false;
            this._dataGridViewLoadEncounter.AllowUserToResizeColumns = false;
            this._dataGridViewLoadEncounter.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._dataGridViewLoadEncounter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridViewLoadEncounter.AutoGenerateColumns = false;
            this._dataGridViewLoadEncounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewLoadEncounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.lastEditDataGridViewTextBoxColumn});
            this._dataGridViewLoadEncounter.DataSource = this.encounterBindingSource;
            this._dataGridViewLoadEncounter.Dock = System.Windows.Forms.DockStyle.Top;
            this._dataGridViewLoadEncounter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridViewLoadEncounter.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewLoadEncounter.Margin = new System.Windows.Forms.Padding(2);
            this._dataGridViewLoadEncounter.MultiSelect = false;
            this._dataGridViewLoadEncounter.Name = "_dataGridViewLoadEncounter";
            this._dataGridViewLoadEncounter.ReadOnly = true;
            this._dataGridViewLoadEncounter.RowHeadersVisible = false;
            this._dataGridViewLoadEncounter.RowTemplate.Height = 24;
            this._dataGridViewLoadEncounter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewLoadEncounter.ShowCellErrors = false;
            this._dataGridViewLoadEncounter.Size = new System.Drawing.Size(543, 350);
            this._dataGridViewLoadEncounter.TabIndex = 0;
            this._dataGridViewLoadEncounter.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dataGridViewLoadEncounter_ColumnHeaderMouseClick);
            // 
            // _btnLoad
            // 
            this._btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnLoad.Location = new System.Drawing.Point(415, 379);
            this._btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(56, 19);
            this._btnLoad.TabIndex = 1;
            this._btnLoad.Text = "Load";
            this._btnLoad.UseVisualStyleBackColor = true;
            this._btnLoad.Click += new System.EventHandler(this.OnButtonLoadClick);
            // 
            // _btnCancel
            // 
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(476, 379);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(56, 19);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 33F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 33F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastEditDataGridViewTextBoxColumn
            // 
            this.lastEditDataGridViewTextBoxColumn.DataPropertyName = "LastEdit";
            this.lastEditDataGridViewTextBoxColumn.FillWeight = 33F;
            this.lastEditDataGridViewTextBoxColumn.HeaderText = "LastEdit";
            this.lastEditDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.lastEditDataGridViewTextBoxColumn.Name = "lastEditDataGridViewTextBoxColumn";
            this.lastEditDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditDataGridViewTextBoxColumn.Width = 125;
            // 
            // encounterBindingSource
            // 
            this.encounterBindingSource.DataSource = typeof(EncounterBuilder.Encounter);
            // 
            // LoadEncounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnLoad;
            this.ClientSize = new System.Drawing.Size(543, 415);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnLoad);
            this.Controls.Add(this._dataGridViewLoadEncounter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 454);
            this.Name = "LoadEncounterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Encounter";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewLoadEncounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewLoadEncounter;
        private System.Windows.Forms.BindingSource encounterBindingSource;
        private System.Windows.Forms.Button _btnLoad;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditDataGridViewTextBoxColumn;
    }
}