namespace MINIrpncalc
{
    /// <summary>
    /// Mostra lista
    /// </summary>
    partial class foLista
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "1.2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "535"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "-5"}, -1);
            this.btSair = new System.Windows.Forms.Button();
            this.lvLista = new System.Windows.Forms.ListView();
            this.chPosição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.la0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(189, 4);
            this.btSair.Margin = new System.Windows.Forms.Padding(0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(17, 15);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "x";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btSair_MouseMove);
            // 
            // lvLista
            // 
            this.lvLista.AutoArrange = false;
            this.lvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosição,
            this.chValor});
            this.lvLista.FullRowSelect = true;
            this.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLista.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvLista.Location = new System.Drawing.Point(2, 20);
            this.lvLista.Margin = new System.Windows.Forms.Padding(0);
            this.lvLista.Name = "lvLista";
            this.lvLista.ShowGroups = false;
            this.lvLista.Size = new System.Drawing.Size(204, 229);
            this.lvLista.TabIndex = 1;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            this.lvLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLista_MouseClick);
            // 
            // chPosição
            // 
            this.chPosição.Text = "Posição";
            this.chPosição.Width = 50;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor";
            this.chValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chValor.Width = 150;
            // 
            // la0
            // 
            this.la0.AutoSize = true;
            this.la0.Location = new System.Drawing.Point(2, 6);
            this.la0.Name = "la0";
            this.la0.Size = new System.Drawing.Size(30, 13);
            this.la0.TabIndex = 2;
            this.la0.Text = "Itens";
            // 
            // foLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 255);
            this.Controls.Add(this.la0);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.btSair);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(950, 30);
            this.Name = "foLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista";
            this.Activated += new System.EventHandler(this.foLista_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.foLista_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.Label la0;
        private System.Windows.Forms.ColumnHeader chPosição;
        private System.Windows.Forms.ColumnHeader chValor;
    }
}