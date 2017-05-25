var CChallenger = new Object();

CChallenger.loadFunctions = function () {
    CChallenger.searchAccion();
    CChallenger.changePageAccion();
}

CChallenger.searchAccion = function () {

    $('#input-buscar').keypress(function () {
         window.setTimeout(function () {
        CChallenger.searchURL = $('#getTitulosURL').val();
        var cadenaBuscar = $('#input-buscar').val(); 
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
         bindHandlers();
    });
}

function details(source) {
    var panelBody = $('.panel-body#'+ source);
    if (panelBody.attr('data-visible') === "false") {
        panelBody.removeClass('hide');
        panelBody.attr('data-visible', 'true');
    }
    else
    {
        panelBody.addClass('hide');
        panelBody.attr('data-visible', 'false');
    }
}

CChallenger.changePageAccion = function () {

    $('.pagination li').click(function () {
        var currentElement = $(this);
    })
} 