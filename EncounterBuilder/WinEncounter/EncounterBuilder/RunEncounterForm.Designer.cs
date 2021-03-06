﻿namespace EncounterBuilder
{
    partial class RunEncounterForm
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
            this._dataGridViewRunEncounter = new System.Windows.Forms.DataGridView();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentTurn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DexRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedTHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRunEncounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewRunEncounter
            // 
            this._dataGridViewRunEncounter.AllowUserToAddRows = false;
            this._dataGridViewRunEncounter.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._dataGridViewRunEncounter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridViewRunEncounter.AutoGenerateColumns = false;
            this._dataGridViewRunEncounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewRunEncounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrentTurn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.DexRaw,
            this.fixedHPDataGridViewTextBoxColumn,
            this.fixedTHPDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.aCDataGridViewTextBoxColumn,
            this.Speed});
            this._dataGridViewRunEncounter.DataSource = this.characterBindingSource;
            this._dataGridViewRunEncounter.Location = new System.Drawing.Point(12, 12);
            this._dataGridViewRunEncounter.Name = "_dataGridViewRunEncounter";
            this._dataGridViewRunEncounter.RowHeadersVisible = false;
            this._dataGridViewRunEncounter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dataGridViewRunEncounter.RowTemplate.Height = 24;
            this._dataGridViewRunEncounter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewRunEncounter.Size = new System.Drawing.Size(948, 427);
            this._dataGridViewRunEncounter.TabIndex = 0;
            this._dataGridViewRunEncounter.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridViewRunEncounter_CellEndEdit);
            this._dataGridViewRunEncounter.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnColumnHeaderClick);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(804, 491);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnExit
            // 
            this._btnExit.CausesValidation = false;
            this._btnExit.Location = new System.Drawing.Point(885, 491);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 2;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.OnExit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "Merge Existing Encounter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(EncounterBuilder.Character);
            // 
            // CurrentTurn
            // 
            this.CurrentTurn.Frozen = true;
            this.CurrentTurn.HeaderText = "Turn";
            this.CurrentTurn.MinimumWidth = 50;
            this.CurrentTurn.Name = "CurrentTurn";
            this.CurrentTurn.ReadOnly = true;
            this.CurrentTurn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 150;
            // 
            // DexRaw
            // 
            this.DexRaw.DataPropertyName = "DexRaw";
            this.DexRaw.HeaderText = "Initiative";
            this.DexRaw.MinimumWidth = 75;
            this.DexRaw.Name = "DexRaw";
            this.DexRaw.Width = 75;
            // 
            // fixedHPDataGridViewTextBoxColumn
            // 
            this.fixedHPDataGridViewTextBoxColumn.DataPropertyName = "FixedHP";
            this.fixedHPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.fixedHPDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.fixedHPDataGridViewTextBoxColumn.Name = "fixedHPDataGridViewTextBoxColumn";
            this.fixedHPDataGridViewTextBoxColumn.Width = 75;
            // 
            // fixedTHPDataGridViewTextBoxColumn
            // 
            this.fixedTHPDataGridViewTextBoxColumn.DataPropertyName = "FixedTHP";
            this.fixedTHPDataGridViewTextBoxColumn.HeaderText = "THP";
            this.fixedTHPDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.fixedTHPDataGridViewTextBoxColumn.Name = "fixedTHPDataGridViewTextBoxColumn";
            this.fixedTHPDataGridViewTextBoxColumn.Width = 75;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "LVL";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 75;
            // 
            // aCDataGridViewTextBoxColumn
            // 
            this.aCDataGridViewTextBoxColumn.DataPropertyName = "AC";
            this.aCDataGridViewTextBoxColumn.HeaderText = "AC";
            this.aCDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.aCDataGridViewTextBoxColumn.Name = "aCDataGridViewTextBoxColumn";
            this.aCDataGridViewTextBoxColumn.Width = 75;
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            this.Speed.HeaderText = "Speed(ft.)";
            this.Speed.MinimumWidth = 75;
            this.Speed.Name = "Speed";
            this.Speed.Width = 75;
            // 
            // RunEncounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 526);
            this.Controls.Add(this.button3);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._dataGridViewRunEncounter);
            this.Name = "RunEncounterForm";
            this.Text = "RunEncounterForm";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRunEncounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewRunEncounter;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CurrentTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DexRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedTHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
    }
}