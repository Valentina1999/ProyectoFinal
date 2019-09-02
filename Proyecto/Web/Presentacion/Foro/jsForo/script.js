$('.capa-data').hide();
$('.container-data').hide();

$('.container-data').css({
    
    bottom: '-450px'
    
});

$('.request').on('click', function(){
    $('.capa-data').fadeIn();

    $('.container-data').show();

    $('.container-data').animate({
    
        bottom: '0px'
        
    });
})

$('.capa-data').on('click', function(){
    
    $(this).fadeOut();
    
    $('.container-data').hide();

     $('.container-data').animate({

            bottom: '-450px'

        });
});

$('.capa-pregunta').hide();
$('.container-pregunta').hide();

$('.container-pregunta').css({
    
    bottom: '-450px'
    
});

$('.btn-comment-pregunta').on('click', function(){
    $('.capa-pregunta').fadeIn();

    $('.container-pregunta').show();

    $('.container-pregunta').animate({
    
        bottom: '0px'
        
    });
})

$('.capa-pregunta').on('click', function(){
    
    $(this).fadeOut();
    
    $('.container-pregunta').hide();

     $('.container-pregunta').animate({

            bottom: '-450px'

        });
});
