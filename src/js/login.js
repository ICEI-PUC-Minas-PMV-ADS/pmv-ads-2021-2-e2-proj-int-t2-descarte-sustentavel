function menuToggle() {
    const toggleMenu = document.querySelector('.menu');
    toggleMenu.classList.toggle('active')
}

function enviardados() {

    if (document.formuser.tx_email.value == "" ||
        document.formuser.tx_email.value.indexOf('@') == -1 ||
        document.formuser.tx_email.value.indexOf('.') == -1) {
        alert("Preencha campo E-MAIL corretamente!");
        document.formuser.tx_email.focus();
        return false;
    }
}