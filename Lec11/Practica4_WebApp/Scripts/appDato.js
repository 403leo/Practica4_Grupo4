// Creo que no era necesario otro doc pero más facil y seguro

$(document).ready(function () {
    const apiBaseUrl = 'https://localhost:44313/api/';
    let datosCache = []; // Se genera una lista para almacenar los datos y poder hacer la logica de poder mostrarlos aleatoriamente.
    function cargarDatos() {
        $.get(apiBaseUrl + 'dato', function (datos) {
            datosCache = datos; // Guardar los datos en la cache Dato
            $('#datos-list').empty();
            datos.forEach(dato => {
                $('#datos-list').append(`
                    <li>
                      <span>${dato.Name}</span>
                      <span>${dato.Description}</span>
                    </li>
                `);
            });
        }).fail(function () {
            alert("Error al cargar datos");
        });
    }
    // Se crea la funcion para poder mostrar los datos aletoriamente
    function mostrarDatosAletoriamente()
    {
        //Verifica si la cache (es decir la lista llamada DatosCache) contiene datos
        if (datosCache.length > 0) {
            // Genera un indice aleatorio entre 0 y el tamano de la lista "DatosCache"
            const indexRandom = Math.floor(Math.random() * datosCache.length);

            // Se obtiene el dato correspondiente al indice aleatorio
            const dato = datosCache[indexRandom];

            // Actualiza el elemento HTML con el dato aleatorio
            $('#dato-random').text(`${dato.Name}: ${dato.Description}`);
        } else {
            // Si no hay datos, motrara un mensaje de error
            $('#dato-random').text(`No hay datos disponibles`);
        }

    }

    cargarDatos();


    $('#btnDatoRandom').on('click', function () {
        mostrarDatosAletoriamente();
    });

});