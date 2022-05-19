using System; 
namespace MINIrpncalc
{
    public class cLinhas
    {
        public double[] doLista;
        public uint uiTam;
        public cLinhas()
        {
            doLista = new double[1];
            uiTam = 0;
        }
        public void IniciaLinhas()
        {
            Array.Resize(ref doLista, 1);
            doLista[0] = 0.0;
            uiTam = 0;
        }
        public void ComeValor(out double do1)
        {
            try
            {
                uiTam--;
                do1 = doLista[uiTam];
                Array.Resize(ref doLista, doLista.Length - 1);
            }
            catch
            {
                do1 = doLista[0];
            }
        }
        public void PrintStack()
        {
            System.Console.WriteLine("Stack Top");
            if (LiVazia())
                System.Console.WriteLine("The stack is empty.");
            else
            {
                for (int ii = (int)uiTam - 1; ii >= 0; ii--)
                {
                    System.Console.Write("elements[" + ii + "] = ");
                    System.Console.WriteLine(doLista[ii]);
                }
            }
            System.Console.WriteLine("Stack Bottom");
            System.Console.WriteLine();
        }
        public void Empurra(double do1)
        {
            try
            {
                Array.Resize(ref doLista, doLista.Length + 1);
                doLista[uiTam] = do1;
                uiTam++;
            }
            catch
            {
                doLista[0] = do1;
            }
        }
        public bool LiVazia()
        {
            return uiTam == 0;
        }
        public bool LiCheia()
        {
            return false;
        }
    }
}
