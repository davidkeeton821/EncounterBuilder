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
            this._dataGridViewRunEncounter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DexRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedTHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRunEncounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewRunEncounter
            // 
            this._dataGridViewRunEncounter.AllowUserToAddRows = false;
            this._dataGridViewRunEncounter.AllowUserToOrderColumns = true;
            this._dataGridViewRunEncounter.AutoGenerateColumns = false;
            this._dataGridViewRunEncounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewRunEncounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this._dataGridViewRunEncounter.RowTemplate.Height = 24;
            this._dataGridViewRunEncounter.Size = new System.Drawing.Size(907, 427);
            this._dataGridViewRunEncounter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(763, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(844, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
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
            // DexRaw
            // 
            this.DexRaw.DataPropertyName = "DexRaw";
            this.DexRaw.HeaderText = "Initiative";
            this.DexRaw.MinimumWidth = 100;
            this.DexRaw.Name = "DexRaw";
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            this.Speed.HeaderText = "Speed(ft.)";
            this.Speed.MinimumWidth = 50;
            this.Speed.Name = "Speed";
            this.Speed.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 200;
            // 
            // fixedHPDataGridViewTextBoxColumn
            // 
            this.fixedHPDataGridViewTextBoxColumn.DataPropertyName = "FixedHP";
            this.fixedHPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.fixedHPDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.fixedHPDataGridViewTextBoxColumn.Name = "fixedHPDataGridViewTextBoxColumn";
            this.fixedHPDataGridViewTextBoxColumn.Width = 50;
            // 
            // fixedTHPDataGridViewTextBoxColumn
            // 
            this.fixedTHPDataGridViewTextBoxColumn.DataPropertyName = "FixedTHP";
            this.fixedTHPDataGridViewTextBoxColumn.HeaderText = "THP";
            this.fixedTHPDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.fixedTHPDataGridViewTextBoxColumn.Name = "fixedTHPDataGridViewTextBoxColumn";
            this.fixedTHPDataGridViewTextBoxColumn.Width = 50;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "LVL";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 50;
            // 
            // aCDataGridViewTextBoxColumn
            // 
            this.aCDataGridViewTextBoxColumn.DataPropertyName = "AC";
            this.aCDataGridViewTextBoxColumn.HeaderText = "AC";
            this.aCDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.aCDataGridViewTextBoxColumn.Name = "aCDataGridViewTextBoxColumn";
            this.aCDataGridViewTextBoxColumn.Width = 50;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(EncounterBuilder.Character);
            // 
            // RunEncounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 526);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._dataGridViewRunEncounter);
            this.Name = "RunEncounterForm";
            this.Text = "RunEncounterForm";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewRunEncounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewRunEncounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DexRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedTHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.BindingSource characterBindingSource;
    }
}