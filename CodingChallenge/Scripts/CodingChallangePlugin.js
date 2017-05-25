var CChallenger = new Object();

CChallenger.loadFunctions = function () {
    CChallenger.searchAccion();
    CChallenger.changePageAccion();
    CChallenger.changePageProceses('1');
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
                    CChallenger.changePageAccion();
                    CChallenger.setDefaultPag();
                }
            });
         }, 5)
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
    var pagination = $('.pagination li')
    pagination.click(function () {
        pagination.removeClass('active')
        var currentElement = $(this);
        currentElement.addClass('active');
        var currentPag = currentElement.attr('id');
        CChallenger.changePageProceses(currentPag);
    });
} 

CChallenger.changePageProceses = function (pageId) {
    $('.panel-default').addClass('hide');
    $('.page-' + pageId).removeClass('hide');
   
}

CChallenger.setDefaultPag = function () {
    var pagination = $('.pagination li');
    pagination.removeClass('active')
    $('.pagination li#1').addClass('active');
    CChallenger.changePageProceses('1');
}