function menuToggle() {
    const toggleMenu = document.querySelector('.menu');
    toggleMenu.classList.toggle('active')
}

function wizardPasso(wizard, etapa) {
    for (var i = 1; i <= 4; i++) {
        document.getElementById(wizard+"-passo-" + i).style.display = "none";
    }
    console.log(wizard);
    console.log(etapa);
    document.getElementById(wizard + "-passo-" + etapa).style.display = "inline";
}

function resetWizard(wizard) {
    for (var i = 1; i <= 4; i++) {
        document.getElementById(wizard + "-passo-" + i).style.display = "none";
    }
    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
}
function wizardProximo(wizard, etapa) {
    for (var j = 1; j <= 5; j++) {
        document.getElementById(wizard + "-passo-" + j).style.display = "none";
    }
    console.log(wizard);
    console.log(etapa);
    document.getElementById(wizard + "-passo-" + etapa).style.display = "inline";
}

function resetWizard(wizard) {
    for (var j = 1; j <= 5; j++) {
        document.getElementById(wizard + "-passo-" + j).style.display = "none";
    }
    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
}
function mostrar(mostrar) {
    console.log(mostrar)
    document.getElementById("login").style.display = "none";
    document.getElementById("cadastro").style.display = "none";
    document.getElementById("esqueceuSenha").style.display = "none";
    document.getElementById(mostrar).style.display = "inline";

    if (mostrar === 'login') {
        resetWizard("cadastro")
    }

    if (mostra === 'login') {
        resetWizard("esqueceuSenha")
    }
}

