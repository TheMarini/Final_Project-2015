<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prjProjetoFinal.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta charset="UTF-8">
	<title>New Program</title>
	<link rel="stylesheet" href="css/style.css">
    <link rel="icon" href="img/Logo-Colorido-JPG.jpg">
	<script src="js/script.js"></script>
</head>
<body onscroll="navadapt()">
  <form id="frmTela" runat="server">
    <nav id="Menu">
       <a href="index.aspx"><img id="home" class="fade hide" src="img/Logo-Branco.png" alt="New Program"/></a>
        <ul>
            <li><a href="#exemplos">Portfólio</a></li>
            <li><a href="#Somos">Sobre</a></li>
            <li><a href="#Contato">Contato</a></li>
        </ul>
    </nav>
  
    <section id="Banner">
        <img id="logo" src="img/Logo-Colorido-JPG.jpg" alt="web"/>
        <p>Conheça a <span id="New">New</span> <span id="Program">Program</span> e saiba como ela pode ajudar você a fazer parte desse novo ramo da internet</p>
       
        <a href="#Somos" id="rolar">
            <h2>ROLE PARA BAIXO</h2><br>
            <img src="img/seta.png"/>
        </a>    
   </section>

   <section id="Portfolio" class="info">
        <ul id="exemplos">
          <asp:Literal ID="ltlWeb" runat="server"></asp:Literal> 
          <asp:Literal ID="ltlDesign" runat="server"></asp:Literal>
          <asp:Literal ID="ltlSoftware" runat="server"></asp:Literal>   
        </ul>
   </section>

    <section id="Categorias" class="info">
        <h1>O que fazemos?</h1>
        <ul>
          <li><img onmouseover="bkcolor(1)" src="img/web.png" alt="web"><h2>Web</h2></li>
          <li><img onmouseover="bkcolor(2)" src="img/design.png" alt="design"><h2>Design</h2></li>
          <li><img onmouseover="bkcolor(3)" src="img/software.png" alt="software"><h2>Software</h2></li>
        </ul>
        <p id="legenda">passe o mouse sobre</p>
     </section>
 
    
    <section id="Somos" class="info">
        <h1>Quem somos?</h1>
        <h2>BASICAMENTE SOMOS DESENVOLVEDORES INDEPENDENTES</h2>
        <ul>
            <asp:Literal ID="ltlSomos" runat="server"></asp:Literal>
        </ul>
        <p>Desenvolvedores web do 2º ano do ensino integrado ao técnino "ETEC - Aristóteles Ferreira", curso ETIM voltado a área de trabalho em programação.</p>
    </section>
 
      <!--
    <section id="Funciona" class="info"> 
        <h1>Como funciona?</h1>
        <h2>BOM, É ASSIM QUE TRABALHAMOS</h2>

        <ul>
            <li>Você manda seu e-mail</li>
            <li><img src="#" alt="pontos" /></li>
            <li>Nós avaliamos e respondemos com orçamentos e sugestões</li>
            <li><img src="#" alt="pontos" /></li>
            <li>Você dá a voz final</li>
            <li><img src="#" alt="pontos" /></li>
            <li>Enviamos</li>
        </ul>
    </section>
      -->

   	<section id="Contato" class="info">
		<h1>Já é nosso cliente?</h1>
      <div id="formulario">
        <asp:TextBox ID="txtNome" CssClass="txt" runat="server" placeholder="nome" onfocus="btnColor(1), txtColor(1, 'txtNome')" onblur="btnColor(0), txtColor(0, 'txtNome')"></asp:TextBox>
        <asp:TextBox ID="txtSobrenome" CssClass="txt" runat="server" placeholder="sobrenome" onfocus="btnColor(1), txtColor(1, 'txtSobrenome')" onblur="btnColor(0), txtColor(0, 'txtSobrenome')"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEmail" CssClass="txt" runat="server" placeholder="email" onfocus="btnColor(1), txtColor(1, 'txtEmail')" onblur="btnColor(0), txtColor(0, 'txtEmail')"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtAssunto" CssClass="txt" runat="server" placeholder="assunto" onfocus="btnColor(1), txtColor(1, 'txtAssunto')" onblur="btnColor(0), txtColor(0, 'txtAssunto')"></asp:TextBox>
        <br />
        <div id="enviar">
            <asp:TextBox ID="txtMensagem" CssClass="txt" runat="server" placeholder="" onfocus="btnColor(1), txtColor(1, 'txtMensagem')" onblur="btnColor(0), txtColor(0, 'txtMensagem')" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" onclick="btnEnviar_Click"></asp:Button>
        </div>
        <br /><br />
        <asp:Label ID="lblErro" runat="server" ForeColor="Red" Font-Size="2em" Visible="False"></asp:Label>
      </div>
      <p>*Ao clicar no botão "Enviar" você concorda com nossos <a href="img/termos.jpg" target="_blank">Termos de Uso</a></p>
	</section>
      
   	<footer id="Footer">
		<br />
	</footer>
  </form>
</body>
</html>
