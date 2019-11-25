using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_PanelControls_Exemplo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controla Visibilidade do Painel
            pnldynamic.Visible = chkvisible.Checked;
            int cont=0;
            //Gera os Controles de Label:
            int n = Int32.Parse(ddllabels.SelectedItem.Value);
            for (int i = 1; i <= n; i++)
            {
                cont++;
                Label lbl = new Label();
                lbl.Text = "Label" + (i).ToString();
                pnldynamic.Controls.Add(lbl);
                pnldynamic.Controls.Add(new LiteralControl("<br />"));
                lbl.ID = "txt"+cont.ToString();
            }

            //Gera os Controles de TextBox:
            int m = Int32.Parse(ddltextbox.SelectedItem.Value);
            for (int i = 1; i <= m; i++)
            {
                TextBox txt = new TextBox();
                txt.Text = "Text Box" + (i).ToString();
                pnldynamic.Controls.Add(txt);
                pnldynamic.Controls.Add(new LiteralControl("<br />"));
            }

            //Gera os Controles de Botões:
            for (int i = 1; i <= 5; i++)
            {
                //Button btn = new Button();
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Text = "Button" + (i).ToString();
                btn.ID = "btn"+i.ToString();
                pnldynamic.Controls.Add(btn);
                pnldynamic.Controls.Add(new LiteralControl("<br />"));
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);

            string x = btn.ClientID;
            
        }
    }
}