function menuToggle() {
    const toggleMenu = document.querySelector('.menu');
    toggleMenu.classList.toggle('active')
}

function wizardPasso(wizard, etapa) {
    for (var i = 1; i <= 3; i++) {
        try {
            document.getElementById(wizard + "-passo-" + i).style.display = "none";
        } catch (error) { }
    }

    document.getElementById(wizard + "-passo-" + etapa).style.display = "inline";

    let tipoDeUsuario = Array.from(document.getElementsByName("TipoDeUsuario")).find(r => r.checked).value;
    console.log(tipoDeUsuario);
    if (tipoDeUsuario === "Ecoponto") {
        document.getElementById("ecoponto-1").style.display = "inline";
        document.getElementById("ecoponto-2").style.display = "inline";
    }
}

function resetWizard(wizard) {
    for (var i = 1; i <= 3; i++) {
        try {
            document.getElementById(wizard + "-passo-" + i).style.display = "none";
        } catch (error) { }
    }
    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
}

function resetWizard(wizard) {
    for (var j = 1; j <= 5; j++) {
        try {
            document.getElementById(wizard + "-passo-" + i).style.display = "none";
        } catch (error) { }
    }
    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
}
function mostrar(mostrando) {
    console.log(mostrando)
    document.getElementById("login").style.display = "none";
    document.getElementById("cadastro").style.display = "none";
    document.getElementById(mostrando).style.display = "inline";

    if (mostrando === 'login') {
        resetWizard("cadastro")
    }
}

