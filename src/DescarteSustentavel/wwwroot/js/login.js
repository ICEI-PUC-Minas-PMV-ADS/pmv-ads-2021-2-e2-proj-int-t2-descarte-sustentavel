function menuToggle() {
    const toggleMenu = document.querySelector('.menu');
    toggleMenu.classList.toggle('active')
}

function avancarModal(modal, etapa) {
    $(`#${modal}-passo-${etapa}`).hide();
    $(`#${modal}-passo-${etapa+1}`).show();
}

function voltarModal(modal, etapa) {
    if (etapa == 2) {
        $(`#${modal}-passo-${etapa}`).hide();
        $(`#${modal}-passo-${etapa - 1}`).show();
    }
    else {
        for (i = 1; i <= 3; i++) {
            $(`#${modal}-passo-${i}`).hide();
        }
        $(`#cadastro`).hide();
        $(`#login`).show();
    }
}

function alternarModalLoginCadastro() {
    $(`#login`).hide();
    $(`#cadastro`).show()
    $(`#cadastro-passo-1`).show()
}

//function wizardPasso(wizard, etapa) {
//    for (var i = 1; i <= 3; i++) {
//        try {
//            document.getElementById(wizard + "-passo-" + i).style.display = "none";
//        } catch (error) { }
//    }

//    document.getElementById(wizard + "-passo-" + etapa).style.display = "inline";

//    let tipoDeUsuario = Array.from(document.getElementsByName("TipoDeUsuario")).find(r => r.checked).value;
//    console.log(tipoDeUsuario);
//    if (tipoDeUsuario === "Ecoponto") {
//        document.getElementById("ecoponto-1").style.display = "inline";
//        document.getElementById("ecoponto-2").style.display = "inline";
//    }
//}

//function resetWizard(wizard) {
//    for (var i = 1; i <= 3; i++) {
//        try {
//            document.getElementById(wizard + "-passo-" + i).style.display = "none";
//        } catch (error) { }
//    }
//    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
//}

//function resetWizard(wizard) {
//    for (var j = 1; j <= 5; j++) {
//        try {
//            document.getElementById(wizard + "-passo-" + i).style.display = "none";
//        } catch (error) { }
//    }
//    document.getElementById(wizard + "-passo-" + 1).style.display = "inline";
//}
//function mostrar(mostrando) {
//    console.log(mostrando)
//    document.getElementById("login").style.display = "none";
//    document.getElementById("cadastro").style.display = "none";
//    document.getElementById(mostrando).style.display = "inline";

//    if (mostrando === 'login') {
//        resetWizard("cadastro")
//    }
//}

