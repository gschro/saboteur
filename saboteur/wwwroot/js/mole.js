$(function(){
    $('input').focus();
     $('input').bind("enterKey",function(e){
         if($('.black-screen').is(":visible") && $('input').val() !== ''){
            executePlayer();
        }
      }); 

    $(document).keydown( function(event) {
        if (event.which === 13) {
            if($('.black-screen').is(":hidden")){
                nextPlayer();
            }
        }
      }); 

      $(document).click(function(e){
        if(e.target.tagName !== 'Input' && $('.black-screen').is(":hidden")){
            nextPlayer();
        }
      });

      $('input').keyup(function(e){
        if(e.keyCode == 13)
        {
           $(this).trigger("enterKey");
        }
      });
});

function nextPlayer(){
    $('.black-screen').show();
    $('.color-screen').hide();
    $('.player-container input').val('')
    $('.player-container').show();
    $('input').focus();
}

function executePlayer(){
    $('.player-container').hide();
    let colorNum = Number(Math.random().toFixed(1));
    let bgColorClass = colorNum*10 >= 6 ? 'bg-color-red' : 'bg-color-green';
    $('.color-screen').removeClass('bg-color-red bg-color-green')
    $('.color-screen').addClass(bgColorClass)
    setTimeout(function(){
        $('.color-screen').slideDown(200, function(){
            $('.black-screen').hide();
        });   
    }, 3000);  
}