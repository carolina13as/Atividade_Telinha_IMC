using System;
using System.Windows.Forms;
public static class Validacoes
{

    public static bool ValidaCpf(string Cpf)
    {
        string Cpf_ver = Cpf.Replace(".", "").Replace("-", "");
        if(Cpf_ver.Length != 11)
        {
            return false;   
        }
        else
        {
            int m = 0;
            int cont = 10;

            for (int i = 0; i < Cpf_ver.Length - 2; i++)
            {
                m += Convert.ToInt32(Cpf_ver[i].ToString()) * cont;
                cont--;
            }
            if(m % 11 < 2)
            {
                if (Convert.ToInt32(Cpf_ver[9].ToString()) != 0)
                {
                    return false;
                }
            }
            else
            {
               int calculo = 11 - (m % 11);
                if (calculo != Convert.ToInt32(Cpf_ver[9].ToString()))
                {
                    return false;
                }
            }
            //---------------------Outra Verificação------------------------------------------------------
            int cont1 = 11;
            int n = 0;
            for (int i = 0; i < Cpf_ver.Length - 1; i++)
            {
                n += int.Parse(Cpf_ver[i].ToString()) * cont1;
                cont1--;
            }
            if (n % 11 < 2)
            {
                if (Convert.ToInt32(Cpf_ver[10].ToString()) != 0)
                {
                    return false;
                }
            }
            else
            {
                int calculo1 = 11 - (n % 11);
                if (calculo1 != Convert.ToInt32(Cpf_ver[10].ToString()))
                {
                    return false;
                }               
            }
            return true;
        }

    }

}
