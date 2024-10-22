// function showDialog() {
//     document.getElementById('overlay').style.display = 'block';
//   }
  
//   function closeDialog() {
//     document.getElementById('overlay').style.display = 'none';
//   }
//   showDialog();
 
    $(document).ready(function() {
        var nav = $("#nav-css");
        var sticky = nav.offset().top;

        $(window).scroll(function() {
            if (window.pageYOffset >= sticky) {
                nav.addClass("sticky");
            } else {
                nav.removeClass("sticky");
            }
        });
    });
    // myscript.js

$(document).ready(function() {
    $('#rememberMe').change(function() {
        if ($(this).is(':checked')) {
            console.log('Người dùng đã chọn Ghi nhớ tôi');
            // Thực hiện các hành động khác khi người dùng chọn ô Ghi nhớ tôi
        } else {
            console.log('Người dùng đã bỏ chọn Ghi nhớ tôi');
            // Thực hiện các hành động khác khi người dùng bỏ chọn ô Ghi nhớ tôi
        }
    });
});

