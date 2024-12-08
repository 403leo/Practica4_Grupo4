$(document).ready(function () {
    const apiBaseUrl = 'https://localhost:44313/api/';
    let chistesCache = []; // Se genera una lista para almacenar los chistes y poder hacer la logica de poder mostrarlos aleatoriamente.
    function cargarChistes() {
        $.get(apiBaseUrl + 'chiste', function (chistes) {
            chistesCache = chistes; // Guardar los chistes en la cache
            $('#chistes-list').empty();
            chistes.forEach(chiste => {
                $('#chistes-list').append(`
                    <li>
                      <span>${chiste.Name}</span>
                      <span>${chiste.Description}</span>
                    </li>
                `);
            });
        }).fail(function () {
            alert("Error al cargar chistes");
        });
    }
    // Se crea la funcion para poder mostrar los chistes aletoriamente
    function mostrarChistesAletoriamente()
    {
        //Verifica si la cache (es decir la lista llamada ChistesCache) contiene chistes
        if (chistesCache.length > 0) {
            // Genera un indice aleatorio entre 0 y el tamano de la lista "ChistesCache"
            const indexRandom = Math.floor(Math.random() * chistesCache.length);

            // Se obtiene el chiste correspondiente al indice aleatorio
            const chiste = chistesCache[indexRandom];

            // Actualiza el elemento HTML con el chiste aleatorio
            $('#chiste-random').text(`${chiste.Name}: ${chiste.Description}`);
        } else {
            // Si no hay chistes, motrara un mensaje de error
            $('#chiste-random').text(`No hay chistes disponibles`);
        }

    }
    // Carga los chistes originales
    cargarChistes();

    // Se configura el eveento para que cuando se de click al boton de chiste aleatorio
    $('#btnChisteRandom').on('click', function () {
        mostrarChistesAletoriamente();
    });

});