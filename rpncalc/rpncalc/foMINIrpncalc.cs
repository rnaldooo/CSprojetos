#region Espaços
using System; // eventArgs IntPtr
using System.Data; //dataset datatable
using System.Windows.Forms; //eventos forms
using System.Runtime.InteropServices;//for DLL's
#endregion
namespace MINIrpncalc
{
    public partial class foMINIrpncalc : Form
    {
        #region Declaração das variáveis e constantes
        public string stPass1
        {
            get { return this.tbL0.Text; }
            set { this.tbL0.Text = value; }
        }
        #endregion
        #region  Inicialização do programa e criação do Formulário Listas
        public foLista foLi;
        public foFuncoes foFu;
        private cLinhas cLi = new cLinhas();
        public foMINIrpncalc()
        {
            InitializeComponent();
            foLi = new foLista(this);
            foLi.stPass2 = this.stPass1;
            foFu = new foFuncoes(this);
            foFu.stPass2 = this.stPass1;
            cLi.IniciaLinhas();
        }
        #endregion
        #region Eventos do formulário MINIrpncalc
        private void tsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btLista_MouseMove(object sender, MouseEventArgs e)
        {
            foLi.Show();
            foLi.Activate();
        }

        private void btFuncoes_MouseMove(object sender, MouseEventArgs e)
        {
            foFu.Show();
            foFu.Activate();
        }


        #endregion
        #region Funções para alimentar o formulário
        private cFunções cFu = new cFunções();
        public string[] stZ1;
        public string[] stZ2;
        public DataTable dt1;
        private void tbL0_KeyDown(object sender, KeyEventArgs e)
        {
            string stAux1 = "";
            cFu.foMINI1 = this;
            stAux1 = cFu.Analiza(cLi, sender, e);
            if (stAux1 == "limpa")
            {
                tbL0.Text = string.Empty;
            }
        }
        public static DataTable GetDataTableFromArray(object[] array)
        {
            DataTable dataTable = new DataTable();
            dataTable.LoadDataRow(array, true);//Pass array object to LoadDataRow method
            return dataTable;
        }
        #endregion
        #region Constantes e Funão para Mover o formulário pelo botão
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btMove_MouseDown(object sender, MouseEventArgs e)
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

//public DataSet dtset1;

// cFu.cLi = cLi;

//tbL0.Clear();

/*
/// <summary>
/// realimenta textbox
/// </summary>
private void atualiza()
{
    try
    {
        tbL3.Text = cLi.doLista[cLi.uiTam - 2].ToString();
    }
    catch
    {
        tbL3.Text = "";
    }
    try
    {
        tbL1.Text = cLi.doLista[cLi.uiTam - 1].ToString();
    }
    catch
    {
        tbL1.Text = "";
    }
    ListViewItem[] lvItem = new ListViewItem[cLi.uiTam];
    stZ1 = new string[cLi.uiTam + 1];
    stZ2 = new string[cLi.uiTam + 1];
    int i1 = 0;
    foreach (double dd in cLi.doLista)
    {
        stZ1[i1] = i1.ToString();
        stZ2[i1++] = dd.ToString();
    }
    tbL0.Clear();
    SendKeys.Send("{LEFT}");
    SendKeys.Send("{DELETE}");
    DataSet dataSet = new DataSet();
    DataTable dataTable = dataSet.Tables.Add();
    dataTable.Columns.Add("Posição");
    dataTable.Columns.Add("Valor");
    foreach (string s1 in stZ1)
    {
        dataTable.Rows.Add(stZ1[int.Parse(s1)], stZ2[int.Parse(s1)]);
    }
    dt1 = dataTable;
    foLi.dt2 = dt1;
}
*/