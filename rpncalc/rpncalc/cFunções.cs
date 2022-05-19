using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Windows.Forms; //eventos forms
using System.Runtime.InteropServices;//for DLL's
using System.Data; //dataset datatable
using System.Globalization;


namespace MINIrpncalc
{
    class cFunções
    {
        #region Variáveis e constantes
        [DllImport("user32.dll")]
        static extern int MapVirtualKey(uint uCode, uint uMapType);
        public foMINIrpncalc foMINI1;
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
        #endregion

        #region Funções
        protected string stDigitado(Keys keyData)
        {
            int nonVirtualKey = MapVirtualKey((uint)keyData, 2);// 2 para passar char se SHIFT 
            char mappedChar = Convert.ToChar(nonVirtualKey);
            string stteste1 = mappedChar.ToString();
            return stteste1;
        }
        public string Analiza(cLinhas cLi, object sender, KeyEventArgs e)
        {
            //e.Handled = true;
            double do1;
            double do2;
            TextBox tb = (TextBox)sender;
            string stAux1 = "";
            string stAntes = tb.Text;
            string stApertou = stDigitado(e.KeyData);
            string se2 = e.KeyCode.ToString();
            string se3 = e.KeyValue.ToString();
            string stPadra = "";
            string decimalChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

            switch (e.KeyValue.ToString())
            {
                case "\r"://Keys.Return:
                case "13":
                    try
                    {

                        stPadra = foMINI1.tbL0.Text.Replace(",", decimalChar);
                        stPadra = stPadra.Replace(".", decimalChar);
                        double number = Convert.ToDouble(stPadra);
                        cLi.Empurra(number);
                        foMINI1.tbL3.Text = foMINI1.tbL1.Text;
                        foMINI1.tbL1.Text = foMINI1.tbL0.Text;
                        foMINI1.tbL0.Clear();
                        atualiza(cLi);
                    }
                    catch
                    {
                    }
                    //e.Handled = false;
                    //   tbL0.Clear();
                    stAux1 = "limpa";
                    break;
                //case Keys.Oemplus:
                //case Keys.Add:
                case "187":
                case "107":
                    //  tbL0.Clear();
                    foMINI1.tbL0.Focus();
                    SendKeys.Send("{ENTER}");
                    cLi.ComeValor(out do2);
                    cLi.ComeValor(out do1);
                    cLi.Empurra(do1 + do2);
                    atualiza(cLi);
                    //  e.Handled = false;
                    stAux1 = "limpa";
                    break;
                //case Keys.OemMinus:
                //case Keys.Subtract:
                case "189":
                case "109":
                    if (stAntes == "")
                    {
                        foMINI1.tbL0.Focus();
                        SendKeys.Send("{ENTER}");
                        cLi.ComeValor(out do2);
                        cLi.ComeValor(out do1);
                        cLi.Empurra(do1 - do2);
                        atualiza(cLi);
                    }
                    else
                    {
                        int imais = stAntes.IndexOf("+");
                        int imenos = stAntes.IndexOf("-");
                        if (imais == -1 && imenos == -1)
                        {
                            foMINI1.tbL0.Text = "-" + stAntes;
                        }
                        else
                        {
                            try
                            {
                                stAntes.Replace("+", "-");
                            }
                            catch
                            {
                                stAntes.Replace("-", "+");
                            }
                        }
                    }
                    stAux1 = "limpa";
                    break;
                //case Keys.D8:
                //case Keys.Multiply:
                case "56":
                case "106":
                    foMINI1.tbL0.Focus();
                    SendKeys.Send("{ENTER}");
                    cLi.ComeValor(out do2);
                    cLi.ComeValor(out do1);
                    cLi.Empurra(do1 * do2);
                    atualiza(cLi);
                    stAux1 = "limpa";
                    break;
                //case Keys.None:
                //case Keys.Divide:
                case "193":
                case "111":
                    foMINI1.tbL0.Focus();
                    SendKeys.Send("{ENTER}");
                    cLi.ComeValor(out do2);
                    cLi.ComeValor(out do1);
                    cLi.Empurra(do1 / do2);
                    atualiza(cLi);
                    stAux1 = "limpa";
                    break;
                // MessageBox.Show(e.KeyValue.ToString());
                default:
                    //MessageBox.Show(e.KeyData.ToString());
                    stAux1 = "";
                    break;
            }
            return stAux1;
        }

        private void atualiza(cLinhas cLi)
        {
            try
            {
                foMINI1.tbL3.Text = cLi.doLista[cLi.uiTam - 2].ToString();
            }
            catch
            {
                foMINI1.tbL3.Text = "";
            }
            try
            {
                foMINI1.tbL1.Text = cLi.doLista[cLi.uiTam - 1].ToString();
            }
            catch
            {
                foMINI1.tbL1.Text = "";
            }
            try
            {
                ListViewItem[] lvItem = new ListViewItem[cLi.uiTam];
                foMINI1.stZ1 = new string[cLi.uiTam + 1];
                foMINI1.stZ2 = new string[cLi.uiTam + 1];
                int i1 = 0;
                foreach (double dd in cLi.doLista)
                {
                    foMINI1.stZ1[i1] = i1.ToString();
                    foMINI1.stZ2[i1++] = dd.ToString();
                }
                foMINI1.tbL0.Clear();
                foMINI1.tbL0.Text = string.Empty;
                DataSet dataSet = new DataSet();
                DataTable dataTable = dataSet.Tables.Add();
                dataTable.Columns.Add("Posição");
                dataTable.Columns.Add("Valor");
                foreach (string s1 in foMINI1.stZ1)
                {
                    dataTable.Rows.Add(foMINI1.stZ1[int.Parse(s1)], foMINI1.stZ2[int.Parse(s1)]);
                }
                foMINI1.dt1 = dataTable;
                foMINI1.foLi.dt2 = foMINI1.dt1;
            }
            catch
            {
            }
        }
        public static void Calcula(cLinhas cli, char op)
        {
            double do1;
            double do2;
            cli.ComeValor(out do2);
            cli.ComeValor(out do1);
            switch (op)
            {
                case '+': cli.Empurra(do1 + do2);
                    break;
                case '-': cli.Empurra(do1 - do2);
                    break;
                case '*': cli.Empurra(do1 * do2);
                    break;
                case '/': cli.Empurra(do1 / do2);
                    break;
                default:
                    //Console.WriteLine("From Evaluate: Unexpected Error.");
                    break;
            }
        }
        public static void Pega0(out string stRt, ref string stEx)
        {
            int indexOfSpace;
            if (stEx.Length > 0)
            {
                indexOfSpace = stEx.IndexOf(' ');
                if (indexOfSpace == -1)
                {
                    stRt = stEx.Substring(0, stEx.Length);
                    stEx = "";
                }
                else
                {
                    stRt = stEx.Substring(0, indexOfSpace);
                    stEx = stEx.Substring(indexOfSpace + 1, stEx.Length - (indexOfSpace + 1));
                }
            }
            else
            {
                stRt = "";
            }
        }
        public static bool Éoperação(string st1)
        {
            return
            ((st1.Length == 1) &&
            ((st1[0] == '+') ||
            (st1[0] == '-') ||
            (st1[0] == '*') ||
            (st1[0] == '/')
            )
            );
        }
        public static bool Quit()
        {
            //string answer;
            //Console.WriteLine("Would you like to enter an expression? (yes/no)");
            //answer = Console.ReadLine();
            return true;//(answer.Equals("no"));
        }
        #endregion
    }
}
//foMINI1.tbL0.Focus();
//SendKeys.Send("{CTRL}+{A}");
//SendKeys.Send("{DELETE}");
