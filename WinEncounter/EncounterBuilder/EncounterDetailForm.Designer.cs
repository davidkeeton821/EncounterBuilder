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
            this._buttonCreate = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _buttonCreate
            // 
            this._buttonCreate.Location = new System.Drawing.Point(143, 262);
            this._buttonCreate.Name = "_buttonCreate";
            this._buttonCreate.Size = new System.Drawing.Size(75, 23);
            this._buttonCreate.TabIndex = 0;
            this._buttonCreate.Text = "Create";
            this._buttonCreate.UseVisualStyleBackColor = true;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(272, 262);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 1;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _textName
            // 
            this._textName.Location = new System.Drawing.Point(143, 46);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(204, 22);
            this._textName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // _textDescription
            // 
            this._textDescription.Location = new System.Drawing.Point(143, 106);
            this._textDescription.Multiline = true;
            this._textDescription.Name = "_textDescription";
            this._textDescription.Size = new System.Drawing.Size(204, 89);
            this._textDescription.TabIndex = 5;
            // 
            // EncounterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(386, 326);
            this.Controls.Add(this._textDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textName);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncounterDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encounter Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonCreate;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.TextBox _textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textDescription;
    }
}