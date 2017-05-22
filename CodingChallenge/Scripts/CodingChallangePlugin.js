var CChallenger = new Object();

CChallenger.loadFunctions = function () {
    CChallenger.searchAccion();
}

CChallenger.searchAccion = function () {
    $('#input-buscar').keypress(function () {
        CChallenger.searchURL = $('#getTitulosURL').val();
        var cadenaBuscar = $('#input-buscar').val(); 
        window.setTimeout(function () {
            $.ajax({
                type: "POST",
                url : CChallenger.searchURL,
                data: { 'cadenaBuscar': cadenaBuscar },
                success : function (result) {
                    $('#listado-id').html(result);
                    CChallenger.data = result;
                }
            });
        }, 5)
    });
}