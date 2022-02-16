using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Controllers
{
    public class txtValor : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.SelectAll();
            this.BackColor = Color.White;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
            if (this.Text == "")
            {
                return;
            }
            try
            {
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", ""));
                this.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                MessageBox.Show("Valor inválido","Valor inválido",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                this.Text = "";
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if(this.Name == "txtValorTotal")
            {
                try
                {
                    double valor = Convert.ToDouble(this.Text.Replace("R$ ", ""));
                    this.Text = String.Format("{0:c}", valor);
                }
                catch
                {

                    MessageBox.Show("Valor inválido", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Text = "";
                }

            }
            
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if(e.KeyChar == 8 || e.KeyChar == 44)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
