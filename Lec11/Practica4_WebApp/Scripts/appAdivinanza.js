$(document).ready(function () {
    const apiBaseUrl = 'https://localhost:44313/api/';

    let adivinanzaActual = null; // Variable para almacenar la adivinanza actual

    // Función para cargar una adivinanza aleatoria desde el servidor
    function cargarAdivinanza() {
        $.get(apiBaseUrl + 'adivinanza', function (adivinanza) {
            adivinanzaActual = adivinanza; // Guardar la adivinanza actual
            $('#adivinanza-pregunta').text(adivinanza.Pregunta); // Mostrar la pregunta
            $('#respuesta-input').val(''); // Limpiar el campo de respuesta
            $('#resultado').text(''); // Limpiar el resultado
        }).fail(function () {
            alert("Error al cargar la adivinanza");
        });
    }

    // Función para enviar la respuesta del usuario
    function enviarRespuesta() {
        const respuestaUsuario = $('#respuesta-input').val();

        if (!adivinanzaActual) {
            alert("No hay ninguna adivinanza cargada");
            return;
        }

        const payload = {
            Id: adivinanzaActual.Id,
            Respuesta: respuestaUsuario
        };

        $.post(apiBaseUrl + 'adivinanza', payload, function (resultado) {
            if (resultado.EsCorrecto) {
                $('#resultado').text("¡Correcto!");
            } else {
                $('#resultado').text(`Incorrecto. La respuesta correcta es: ${resultado.RespuestaCorrecta}`);
            }
        }).fail(function () {
            alert("Error al enviar la respuesta");
        });
    }

    // Cargar una adivinanza al cargar la página
    cargarAdivinanza();

    // Configurar el evento para cargar una nueva adivinanza
    $('#btnNuevaAdivinanza').on('click', function () {
        cargarAdivinanza();
    });

    // Configurar el evento para enviar la respuesta
    $('#btnEnviarRespuesta').on('click', function () {
        enviarRespuesta();
    });
});