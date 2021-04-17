$(function () {

    function preencheEndereco() {

        $('#cep input').on("blur", function (event) {

            $.getJSON("https://viacep.com.br/ws/" + $('#cep input').val().replace('-', '').replace('.', '') + "/json", function (cep) {
                $('#logradouro input').val(cep.logradouro)
                $('#bairro input').val(cep.bairro)
                $('#localidade input').val(cep.localidade)
                $('#uf input').val(cep.uf)
            });
        });
    }

    function trataTipoDeFormularioPorPessoa() {

        $('#tipoPessoa input').on('click', function (event) {
            var tipoUsuarioSelecionado = $("#tipoPessoa input[name='TipoUsuario']:checked").val()


            exibeCamposFormularioUsuarioPorTipo(tipoUsuarioSelecionado)
            exibePerfilPorUsuario(tipoUsuarioSelecionado)
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

            $('#picDocumentos').hide()
            $('#picDocumentos input').val("")
        } else {

            $('#nomeFisico').hide()
            $('#nomeFisico input').val("")

            $('#razaoSocial').show()

            $('#nomeFantasia').show()

            $('#picDocumentos').show()
        }
    }

    function exibePerfilPorUsuario(tipoUsuarioSelecionado) {
        if (tipoUsuarioSelecionado == 'Pessoa Física') {
            $('#cabNome').show()
            $('#tabNome').show()
        } else {
            $('#cabNome').hide()
            $('#tabNome').hide()
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

    function atualizarNotificacao() {
        $.get("/Home/Notificacao", function (data) {
            $("#noti").html(data);
        });
    }

    $(document).ready(function () {
        setInterval(atualizarNotificacao, 250);
    });

    preencheEndereco()
    trataTipoDeFormularioPorPessoa()
    mostraFormularioUsuarioPadrao()
    validaDocumento()
});