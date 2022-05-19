namespace MINIrpncalc
{
    partial class foMINIrpncalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foMINIrpncalc));
            this.tbL0 = new System.Windows.Forms.TextBox();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.tbL3 = new System.Windows.Forms.TextBox();
            this.btFu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btMove = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbL0
            // 
            this.tbL0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbL0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbL0, "tbL0");
            this.tbL0.Name = "tbL0";
            this.tbL0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbL0_KeyDown);
            // 
            // tbL1
            // 
            this.tbL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbL1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbL1, "tbL1");
            this.tbL1.Name = "tbL1";
            this.tbL1.ReadOnly = true;
            // 
            // tbL3
            // 
            this.tbL3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbL3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbL3, "tbL3");
            this.tbL3.Name = "tbL3";
            this.tbL3.ReadOnly = true;
            // 
            // btFu
            // 
            resources.ApplyResources(this.btFu, "btFu");
            this.btFu.Name = "btFu";
            this.btFu.UseCompatibleTextRendering = true;
            this.btFu.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Stretch = false;
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSair});
            resources.ApplyResources(this.tsMenu, "tsMenu");
            this.tsMenu.Name = "tsMenu";
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            resources.ApplyResources(this.tsSair, "tsSair");
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // btMove
            // 
            this.btMove.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.btMove, "btMove");
            this.btMove.Name = "btMove";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btFuncoes_MouseMove);
            // 
            // btLista
            // 
            this.btLista.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.btLista, "btLista");
            this.btLista.Name = "btLista";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btLista_MouseMove);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMove_MouseDown);
            // 
            // foMINIrpncalc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btMove);
            this.Controls.Add(this.btFu);
            this.Controls.Add(this.tbL3);
            this.Controls.Add(this.tbL1);
            this.Controls.Add(this.tbL0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "foMINIrpncalc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMove_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        private System.Windows.Forms.Button btMove;
        /// <summary>
        /// linha 0
        /// </summary>
        public System.Windows.Forms.TextBox tbL0;
        /// <summary>
        /// linha 1
        /// </summary>
        public System.Windows.Forms.TextBox tbL1;
        /// <summary>
        /// linha 2
        /// </summary>
        public System.Windows.Forms.TextBox tbL3;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button button1;
    }
}

