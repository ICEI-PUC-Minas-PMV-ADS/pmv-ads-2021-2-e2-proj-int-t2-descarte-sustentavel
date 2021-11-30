var id = 0;

$("#button_adicionar_item").click(function (event) {

    $('#tipo_material').prop('readonly', true)

    if (id < 5) {
        id++
        criarLinhaGridItens()        
    }
    if (id == 5) {
        $('#button_adicionar_item_btn').prop('disabled', true)
        $('#tipo_item').prop('disabled', true)
        $('#item_descricao').prop('disabled', true)        
        $('#button_adicionar_item_btn').css({ color: "#FFF", backgroundColor: "#e9ecef", opacity: 5 })
    }

})

function criarLinhaGridItens() {
    var tipoItem = document.getElementById("tipo_item").value
    var descItem = document.getElementById("item_descricao").value

    $("#tabela_itens_body").append(`<tr><th scope="row">${id}</th><td>${tipoItem}</td><td>${descItem}</td></tr>`)

    //var qtdItens = document.getElementById("qtd_itens").innerHTML(`${id}`)
    //$("qtd_itens").value = id;
}

function habilitarOpcoesDeItensReciclaveisOuEletronicos() {
    var tipoMaterial = document.getElementById("tipo_material")

        if (tipoMaterial.value == "Reciclável") {
            $("#tipo_item").append(`<option class="itens_reciclaveis" value="Plástico">Plastico</option>
                                <option class="itens_reciclaveis" value="Metal">Metal</option>
                                <option class="itens_reciclaveis" value="Vidro">Vidro</option>
                                <option class="itens_reciclaveis" value="Papel">Papel</option>`)
        }
        else if (tipoMaterial.value == "Eletrônico") {
            $("#tipo_item").append(`<option class="itens_eletronicos" value="Pilhas / Baterias">Pilhas / Baterias</option>
                                <option class="itens_eletronicos" value="Fones de Ouvido / Cabos">Fones de Ouvido / Cabos</option>
                                <option class="itens_eletronicos" value="Eletrônico Pequeno ou Médio">Eletrônico Pequeno ou Médio</option>
                                <option class="itens_eletronicos" value="Eletrodoméstico">Eletrodoméstico</option>`)
    }

    
}