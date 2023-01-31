using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class Helpers
    {
        // Método limpador de tela:

        #region
        public void LimparTela(Form tela) 
        {
            foreach (Control crtPai in tela.Controls)
            {
                foreach (Control crt1 in crtPai.Controls)
                {
                    if (crt1 is TabPage)
                    {
                        foreach (Control crt2 in crt1.Controls)
                        {

                            if (crt2 is TextBox)
                            {
                                // Limpando os campos do tipo: TextBox

                                (crt2 as TextBox).Text = string.Empty;

                            }

                            if (crt2 is MaskedTextBox)
                            {
                                // Limpando os campos do tipo: MaskedTextBox

                                (crt2 as MaskedTextBox).Text = string.Empty;

                            }

                            if (crt2 is ComboBox)
                            {
                                // Limpando os campos do tipo: ComboBox

                                (crt2 as ComboBox).Text = string.Empty;

                            }


                        }


                    }


                }


            }       
        
        
        }    

    }
    #endregion
}
