$(document).ready(function () {

  $(".tablesorter").tablesorter();

  $('table.tablesorter th span').click(function () {

    if ($(this).hasClass('asc')) {
      $(this).removeClass('asc');
      $(this).addClass('desc');
    }
    else {
      $(this).removeClass('desc');
      $(this).addClass('asc');
    }

  });

});