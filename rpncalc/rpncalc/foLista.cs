#region Espaços
using System;
using System.Data; // datatable datarow datarow state
using System.Drawing; // point para criação do formulário proximo do formulário1
using System.Windows.Forms; //eventos e formulário
using System.Runtime.InteropServices;//for DLL's
#endregion
namespace MINIrpncalc
{
    public partial class foLista : Form
    {
        #region variáveis e constantes

        
        /// <summary>
        /// Cria vinculo para passagem de valor para foMINIrpncalc
        /// </summary>
        public string stPass2
        {
            get { return this.la0.Text; }
            set { this.la0.Text = value; }
        }
        /// <summary>
        /// Cria foMINIrpncalc para pegar localização
        /// </summary>
        public foMINIrpncalc foMINI1;
        /// <summary>
        /// para vincular form1
        /// </summary>
        public foMINIrpncalc Form1
        {
            get
            {
                return foMINI1;
            }
            set
            {
                foMINI1 = value;
            }
        }
        /// <summary>
        /// Cria data table
        /// </summary>
        public DataTable dt2;

        #endregion
        #region Inicializa o formulário
        /// <summary>
        /// construtor do form recebendo valores do foMINIrpncalc
        /// </summary>
        /// <param name="frm1"> formulário 1</param>
        public foLista(foMINIrpncalc frm1)
        {
            InitializeComponent();
            foMINI1 = frm1;
            this.Location = new Point(frm1.Location.X + 100, frm1.Location.Y + 30);
        }
        #endregion
        
        #region Eventos
        /// <summary>
        /// botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSair_MouseMove(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
        private void lvLista_MouseClick(object sender, MouseEventArgs e)
        {
            la0.Text = lvLista.SelectedItems[0].SubItems[1].Text;
            foMINI1.stPass1 = la0.Text;
        }
        #endregion
        /// <summary>
        /// Funções
        /// </summary>
        #region funções
        public void crialista()
        {
            lvLista.Items.Clear();
            for (int i = 0; i < dt2.Rows.Count; i++)// Mostrar itens no ListView
            {
                DataRow drow = dt2.Rows[i];
                if (drow.RowState != DataRowState.Deleted) // apenas linhas que não foram deletadas
                {
                    ListViewItem lvi = new ListViewItem(drow["Posição"].ToString()); // definindo os itens
                    lvi.SubItems.Add(drow["Valor"].ToString());
                    lvLista.Items.Add(lvi); // adiciona item ao ListView
                }
            }
        }
        private void foLista_Activated(object sender, EventArgs e)
        {
            crialista();
        }
        #endregion
        #region Move Formulário
        /// <summary>
        /// constante para mover form
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        /// <summary>
        /// constante para mover form
        /// </summary>
        public const int HT_CAPTION = 0x2;
        /// <summary>
        /// dll do sistema para mover form
        /// </summary>
        /// <param name="hWnd"><c>IntPtr</c> precisa do <c>using System;</c></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        /// <summary>
        /// dll do sistema para mover form
        /// </summary>
        /// <returns></returns>
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void foLista_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}


// Define the list items
//lvi.SubItems.Add(drow["Valor"].ToString());
//lvi.SubItems.Add(drow["pubdate"].ToString());
// Add the list items to the ListView


//Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
 //private void Form2_MouseMove(object sender, MouseEventArgs e)
 //       {
            // this.Show();
            // timer1.Interval = 5000;
            // timer1.Enabled = true;
            // timer1.Start();
            // timer1.Tick += new EventHandler(timer1_Tick);
            // label1.Text = timer1.Interval.ToString();
            //Form1.Enable = true;
 //       }
//        private void timer1_Tick(object sender, EventArgs e)
//{
  //          this.Hide();
  //      }
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;


//float[],[] a1 = new float[1],[1];
//formPrincipal.textBox1.Text = f1;
//formPrincipal.Refresh();
// instanciafrm1.TextBox1.Text = f1;
// rpncalc.Form1.textBox1.Text = f1;


// <summary>
// string auxiliar para passar valor selecionado
// </summary>
//public string f1;