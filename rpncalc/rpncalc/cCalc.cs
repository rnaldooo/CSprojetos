using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MINIrpncalc
{
    class cCalc
    {
        public void calc(string ss1)
        {
            char arithmeticOperator;
            double result;
            double number;
            string token;
            string expression;
            cLinhas stack = new cLinhas();
            while (ss1 != "Sair") //!MetodosCalculadora.Quit())
            {
                stack.IniciaLinhas();
                expression = ss1;
                do
                {
                    cFunções.Pega0(out token, ref expression);
                    if (cFunções.Éoperação(token))
                    {
                        arithmeticOperator = token[0];
                        cFunções.Calcula(stack, arithmeticOperator);
                    }
                    else
                    {
                        number = Convert.ToDouble(token);
                        stack.Empurra(number);
                    }
                }
                while (expression.Length > 0);
                stack.ComeValor(out result);
                if (stack.LiVazia())
                { }
                else
                { } 
            }
        }
    }
}
