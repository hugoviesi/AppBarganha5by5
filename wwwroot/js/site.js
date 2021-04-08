// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.when($.ready).then(function () {


    function preencheEndereco() {

        $('#cep input').on("blur", function (event) {

            $.getJSON("https://viacep.com.br/ws/" + $('#cep input').val().replace('-', '').replace('.', '') + "/json", function (rs) {

                $('#logradouro input').val(rs.logradouro)
                $('#bairro input').val(rs.bairro)
                $('#localidade input').val(rs.localidade)
                $('#uf input').val(rs.uf)
            });

        });

    }

    function trataTipoDeFormularioPorPessoa() {

        $('#tipoPessoa input').on('click', function (event) {
            var tipoUsuarioSelecionado = $("#tipoPessoa input[name='TipoUsuario']:checked").val()
            exibeCamposFormularioUsuarioPorTipo(tipoUsuarioSelecionado)
        })

    }

    function mostraFormularioUsuarioPadrao() {
        $("#tipoPessoa input[name='TipoUsuario'][value='Pessoa Física']").prop('checked', true)
        exibeCamposFormularioUsuarioPorTipo('Pessoa Física')
    }

    function exibeCamposFormularioUsuarioPorTipo(tipoUsuarioSelecionado) {
        if (tipoUsuarioSelecionado == 'Pessoa Física') {

            $('#nomeFisico').show()

            $('#razaoSocial').hide()
            $('#razaoSocial input').val("")

            $('#nomeFantasia').hide()
            $('#nomeFantasia input').val("")

        } else {

            $('#nomeFisico').hide()
            $('#nomeFisico input').val("")

            $('#razaoSocial').show()

            $('#nomeFantasia').show()

        }
    }

    function validaDocumento() {

        $('#documento input').on("blur", function (event) {

            $.get("/ValidadorDocumento?documento=" + $('#documento input').val().replace('-', '').replace('.', ''), function () {
                $('#cadastrarUsuario').attr("disabled", false);
            }).fail(function () {
                alert("Seu documento está inválido!")
                $('#cadastrarUsuario').attr("disabled", true);
            })
        })
    }

    preencheEndereco()
    trataTipoDeFormularioPorPessoa()
    mostraFormularioUsuarioPadrao()
    validaDocumento()

});