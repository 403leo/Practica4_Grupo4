$(document).ready(function () {
    const apiBaseUrl = 'https://localhost:44313/api/';

    let adivinanzaActual = []; // Lista de adivinanzas
    let adivinanzaSeleccionada = null; // Adivinanza actualmente mostrada

    // Función para cargar todas las adivinanzas
    function cargarAdivinanzas() {
        $.get(apiBaseUrl + 'adivinanza', function (adivinanzas) {
            $('#adivinanzas-list').empty();
            adivinanzaActual = adivinanzas;

            // Mostrar la lista de adivinanzas en el HTML
            adivinanzas.forEach(adivinanza => {
                $('#adivinanzas-list').append(`
                    <li>
                        <span><strong>${adivinanza.Name}</strong>: ${adivinanza.Description}</span>
                    </li>
                `);
            });

            // Seleccionar y mostrar una adivinanza aleatoria
            mostrarNuevaAdivinanza();
        }).fail(function () {
            alert("Error al cargar las adivinanzas");
        });
    }

    // Función para seleccionar y mostrar una adivinanza aleatoria
    function mostrarNuevaAdivinanza() {
        if (!adivinanzaActual || adivinanzaActual.length === 0) {
            alert("No hay adivinanzas disponibles");
            return;
        }

        // Seleccionar una adivinanza aleatoria
        const indiceAleatorio = Math.floor(Math.random() * adivinanzaActual.length);
        adivinanzaSeleccionada = adivinanzaActual[indiceAleatorio];

        // Mostrar la adivinanza seleccionada
        $('#adivinanza-random').text(adivinanzaSeleccionada.Description);
        $('#respuesta-input').val(""); // Limpiar el campo de respuesta
        $('#resultado-respuesta').text(""); // Limpiar el resultado
    }

    // Función para enviar la respuesta del usuario
    function enviarRespuesta() {
        const respuestaUsuario = $('#respuesta-input').val().trim();

        if (!adivinanzaSeleccionada) {
            alert("No hay ninguna adivinanza seleccionada");
            return;
        }

        const payload = {
            Id: adivinanzaSeleccionada.Id,
            Respuesta: respuestaUsuario
        };

        $.post(apiBaseUrl + 'adivinanza/validar', payload, function (resultado) {
            if (resultado.EsCorrecto) {
                $('#resultado-respuesta').text("Correcto");
            } else {
                $('#resultado-respuesta').text(`Incorrecto. La respuesta correcta es: ${resultado.RespuestaCorrecta}`);
            }
        }).fail(function () {
            alert("Error al validar la respuesta");
        });
    }

    // Cargar todas las adivinanzas al iniciar la página
    cargarAdivinanzas();

    // Configurar el evento para cargar una nueva adivinanza
    $('#btnNuevaAdivinanza').on('click', function () {
        mostrarNuevaAdivinanza();
    });

    // Configurar el evento para enviar la respuesta
    $('#btnEnviarRespuesta').on('click', function () {
        enviarRespuesta();
    });
});
