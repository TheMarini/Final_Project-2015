function bkcolor(opc, nome) {

    document.getElementById("Categorias").style.transition = "2s"; /*Transition*/

    document.getElementById("Categorias").style.color = "whitesmoke"; 
    document.getElementById("legenda").style.color = "whitesmoke";

    switch (opc)
    {
        case 1:
            document.getElementById("webLegenda").style.backgroundColor = "#3fb094";
            document.getElementById("designLegenda").style.backgroundColor = "whitesmoke";
            document.getElementById("softwareLegenda").style.backgroundColor = "whitesmoke";

            document.getElementById("webP").style.color = "whitesmoke";
            document.getElementById("designP").style.color = "gray";
            document.getElementById("softwareP").style.color = "gray";

            document.getElementById("Categorias").style.backgroundColor = "#3fb094";
            document.getElementById("legenda").innerHTML = "Desenvolvimento de sites Web, blogs, portfólios";
            break;

        case 2:
            document.getElementById("webLegenda").style.backgroundColor = "whitesmoke";
            document.getElementById("designLegenda").style.backgroundColor = "#d65a5a";
            document.getElementById("softwareLegenda").style.backgroundColor = "whitesmoke";

            document.getElementById("webP").style.color = "gray";
            document.getElementById("designP").style.color = "whitesmoke";
            document.getElementById("softwareP").style.color = "gray";

            document.getElementById("Categorias").style.backgroundColor = "#d65a5a";
            document.getElementById("legenda").innerHTML = "Logos, templates, cartões de propaganda";
            break;

        case 3:
            document.getElementById("webLegenda").style.backgroundColor = "whitesmoke";
            document.getElementById("designLegenda").style.backgroundColor = "whitesmoke";
            document.getElementById("softwareLegenda").style.backgroundColor = "#4a9fcf";

            document.getElementById("webP").style.color = "gray";
            document.getElementById("designP").style.color = "gray";
            document.getElementById("softwareP").style.color = "whitesmoke";

            document.getElementById("Categorias").style.backgroundColor = "#4a9fcf";
            document.getElementById("legenda").innerHTML = "Aplicativos desktop, como programas de cadastro e entre outros";
            break;
    }
}

function btnColor(opc) {
    switch (opc) {
        case 0: document.getElementById("btnEnviar").style.transition = "1s";
            document.getElementById("btnEnviar").style.backgroundColor = "";
            break;

        case 1: document.getElementById("btnEnviar").style.transition = "1s";
            document.getElementById("btnEnviar").style.backgroundColor = "#4a9fcf";
            break;
    }
}

function txtColor(opc, nome) {
    document.getElementById(nome).style.transition = "1s";
    switch (opc) {
        case 0: document.getElementById(nome).style.backgroundColor = "whitesmoke"; break;
        case 1: document.getElementById(nome).style.backgroundColor = "white"; break;
    }
}

function navadapt() {
        var $valScrollBody = document.body.scrollTop ? document.body.scrollTop : document.documentElement.scrollTop;
        var $header = document.getElementById('Menu');
        var $home = document.getElementById('home');

        if ($valScrollBody >= 650) {
            if (!($header.className == "fade")) {
                $header.className = "fade";
            }
        } else {
            if ($valScrollBody <= 650) {
                $header.className = "";
            }
        }
    }