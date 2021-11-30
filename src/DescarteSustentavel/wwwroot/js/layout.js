const navbar = document.getElementById('itens_menu')
const botaoToggle = document.getElementById('botao_menu')
const logo = document.getElementById('logo_icon')
console.log(botaoToggle)

function alternarNavbar() {

    navbar.classList.toggle('active')

    if ($(navbar).hasClass('active')) {
        navbar.style.width = "28%";
        botaoToggle.style.width = "21.5%";
        logo.style.width = "70%";
    }
    else {
        navbar.style.width = "0";
        botaoToggle.style.width = "10%";
        logo.style.width = "80%";
    }

 }