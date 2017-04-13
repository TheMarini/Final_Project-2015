using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Web.Mail;
using System.Net.Mail;

namespace prjProjetoFinal
{
    public partial class index : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*---Gera uma lista infinita de exemplos na seção "Portifólio"---*/
                #region Web
                XmlDocument xmlDocWeb = new XmlDocument();
                xmlDocWeb.Load(Request.PhysicalApplicationPath + "xml/web.xml");
                XmlNodeList webItem = xmlDocWeb.GetElementsByTagName("ITEM");

                for (int i = 0; i < webItem.Count; i++)
                {
                    ltlWeb.Text += "<li id='web'><img class='thumb' src=\"" + webItem[i]["imagem"].InnerText + "\" alt=\"" + webItem[i]["titulo"].InnerText + "\"><h3>" + webItem[i]["titulo"].InnerText + "</h3><div id='webLegenda'><p id='webP'>" + webItem[i]["descricao"].InnerText + "</p></div></li>";
                }
                #endregion

                #region Design
                XmlDocument xmlDocDesign = new XmlDocument();
                xmlDocDesign.Load(Request.PhysicalApplicationPath + "xml/design.xml");
                XmlNodeList designItem = xmlDocDesign.GetElementsByTagName("ITEM");

                for (int i = 0; i < designItem.Count; i++)
                {
                    ltlDesign.Text += "<li id='design'><img class='thumb' src=\"" + designItem[i]["imagem"].InnerText + "\" alt=\"" + designItem[i]["titulo"].InnerText + "\"><h3>" + designItem[i]["titulo"].InnerText + "</h3><div id='designLegenda'><p id='designP'>" + designItem[i]["descricao"].InnerText + "</p></div></li>";
                }
                #endregion

                #region Software
                XmlDocument xmlDocSoftware = new XmlDocument();
                xmlDocSoftware.Load(Request.PhysicalApplicationPath + "xml/software.xml");
                XmlNodeList softwareItem = xmlDocSoftware.GetElementsByTagName("ITEM");

                for (int i = 0; i < softwareItem.Count; i++)
                {

                    ltlSoftware.Text += "<li id='software'><img class='thumb' src=\"" + softwareItem[i]["imagem"].InnerText + "\" alt=\"" + softwareItem[i]["titulo"].InnerText + "\"><h3>" + softwareItem[i]["titulo"].InnerText + "</h3><div id='softwareLegenda'><p id='softwareP'>" + softwareItem[i]["descricao"].InnerText + "</p></div></li>";
                }
                #endregion

                /*---Gera as pessoas que estão no grupo da startup*/
                #region Pessoas
                XmlDocument xmlDocSomos = new XmlDocument();
                xmlDocSomos.Load(Request.PhysicalApplicationPath + "xml/somos.xml");
                XmlNodeList pessoa = xmlDocSomos.GetElementsByTagName("PESSOA");

                for (int i = 0; i < pessoa.Count; i++)
                {
                    ltlSomos.Text += "<li><img src=\"" + pessoa[i]["foto"].InnerText + "\" alt=\"" + pessoa[i]["nome"].InnerText + "\" style=\"" + pessoa[i]["estilo"].InnerText + "\"><h3>" + pessoa[i]["nome"].InnerText + "</h3><h4>" + pessoa[i]["funcao"].InnerText + "</h4></li>";
                }
                #endregion
            }
        }
        #endregion

        #region Email
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblErro.Visible = true;
            if (txtNome.Text.Length > 0 && txtMensagem.Text.Length > 0 && txtEmail.Text.Length > 0 && txtMensagem.Text.Length > 0)
            {
                if (!txtNome.Text.Contains("0") && !txtNome.Text.Contains("1") && !txtNome.Text.Contains("2") && !txtNome.Text.Contains("3") && !txtNome.Text.Contains("4") && !txtNome.Text.Contains("5") && !txtNome.Text.Contains("6") && !txtNome.Text.Contains("7") && !txtNome.Text.Contains("8") && !txtNome.Text.Contains("9"))
                {
                    if (!txtSobrenome.Text.Contains("0") && !txtSobrenome.Text.Contains("1") && !txtSobrenome.Text.Contains("2") && !txtSobrenome.Text.Contains("3") && !txtSobrenome.Text.Contains("4") && !txtSobrenome.Text.Contains("5") && !txtSobrenome.Text.Contains("6") && !txtSobrenome.Text.Contains("7") && !txtSobrenome.Text.Contains("8") && !txtSobrenome.Text.Contains("9"))
                    {
                        if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && txtEmail.Text.Length > 5)
                        {
                            string remetente = "pedidosnewprogram@gmail.com";
                            string senha = "marinimirandanani";

                            string destinatario = "pedidosnewprogram@gmail.com";
                            string mensagem = txtMensagem.Text;

                            SmtpClient client = new SmtpClient();
                            client.Credentials = new System.Net.NetworkCredential(remetente, senha);

                            client.Host = "smtp.gmail.com";
                            client.Port = 587;
                            client.EnableSsl = true;

                            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                            mail.To.Add(destinatario);
                            mail.From = new MailAddress(remetente, "Contato via Site", System.Text.Encoding.UTF8);
                            mail.Subject = "Pedido";
                            mail.SubjectEncoding = System.Text.Encoding.UTF8;
                            mail.Body = "<html><body><b>" + txtNome.Text + txtSobrenome.Text + "</b> <br/> <i>" + txtEmail.Text + "</i>" + "<br/><br/>" + mensagem + "</body></html>";
                            mail.BodyEncoding = System.Text.Encoding.UTF8;
                            mail.IsBodyHtml = true;
                            mail.Priority = System.Net.Mail.MailPriority.High;

                            try
                            {
                                client.Send(mail);
                                lblErro.ForeColor = System.Drawing.Color.Green;
                                lblErro.Text = "Email enviado com sucesso.";
                            }
                            catch
                            {
                                lblErro.ForeColor = System.Drawing.Color.Red;
                                lblErro.Text = "Erro no envio do Email.";
                            }
                        }
                        else
                        {
                            lblErro.Text = "Email inválido";
                        }
                    }
                    else
                    {
                        lblErro.Text = "Favor, coloque seu nome verdadeiro";
                    }
                }
                else
                {
                    lblErro.Text = "Favor, coloque seu nome verdadeiro";
                }
            }
            else
            {
                lblErro.Visible = true;
                lblErro.ForeColor = System.Drawing.Color.Red;
                if (txtMensagem.Text.Length == 0)
                {
                    lblErro.Text = "Descreva o seu pedido";
                }
                if (txtEmail.Text.Length == 0)
                {
                    lblErro.Text = "Faltou o seu email";
                }
                if (txtSobrenome.Text.Length == 0)
                {
                    lblErro.Text = "Faltou o seu sobrenome";
                }
                if (txtNome.Text.Length == 0)
                {
                    lblErro.Text = "Faltou o seu nome";
                }
            }
        }
        #endregion
    }
}