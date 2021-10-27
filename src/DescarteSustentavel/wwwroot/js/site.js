// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var id = 1;

$("#button_adicionar_item").click(function (event) {
    criarLinhaGridItens()
    id++
})

function criarLinhaGridItens() {
    var tipoItem = document.getElementById("tipo_item").value
    var descItem = document.getElementById("item_descricao").value

    $("#tabela_itens_body").append(`<tr><th scope="row">${id}</th><td>${tipoItem}</td><td>${descItem}</td></tr>`)


    //var qtdItens = document.getElementById("qtd_itens").innerHTML(`${id}`)
    //$("#qtd_itens").value = id;
}