namespace EncounterBuilder
{
    partial class MainForm
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
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.encounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miEncounterNew = new System.Windows.Forms.ToolStripMenuItem();
            this._miEncounterLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miEncounterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encounterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this._mainMenu.Size = new System.Drawing.Size(767, 28);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(181, 26);
            this._miFileExit.Text = "&Exit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // encounterToolStripMenuItem
            // 
            this.encounterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miEncounterNew,
            this._miEncounterLoad,
            this.toolStripSeparator1,
            this._miEncounterDelete});
            this.encounterToolStripMenuItem.Name = "encounterToolStripMenuItem";
            this.encounterToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.encounterToolStripMenuItem.Text = "En&counter";
            // 
            // _miEncounterNew
            // 
            this._miEncounterNew.Name = "_miEncounterNew";
            this._miEncounterNew.Size = new System.Drawing.Size(181, 26);
            this._miEncounterNew.Text = "&New";
            this._miEncounterNew.Click += new System.EventHandler(this.OnEncounterNew);
            // 
            // _miEncounterLoad
            // 
            this._miEncounterLoad.Name = "_miEncounterLoad";
            this._miEncounterLoad.Size = new System.Drawing.Size(181, 26);
            this._miEncounterLoad.Text = "&Load";
            this._miEncounterLoad.Click += new System.EventHandler(this.OnEncounterLoad);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // _miEncounterDelete
            // 
            this._miEncounterDelete.Name = "_miEncounterDelete";
            this._miEncounterDelete.Size = new System.Drawing.Size(181, 26);
            this._miEncounterDelete.Text = "&Delete";
            this._miEncounterDelete.Click += new System.EventHandler(this.OnEncounterDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.Size = new System.Drawing.Size(181, 26);
            this._miHelpAbout.Text = "&About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 553);
            this.Controls.Add(this._mainMenu);
            this.MainMenuStrip = this._mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encounter Builder";
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem encounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miEncounterNew;
        private System.Windows.Forms.ToolStripMenuItem _miEncounterLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miEncounterDelete;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
    }
}

