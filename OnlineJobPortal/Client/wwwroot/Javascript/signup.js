$('#emp-reg-form').hide();
$('#candidate-regForm-btn').click(function (e) {
    $('#cand-reg-form').show();
    $('#emp-reg-form').hide();
});
$('#employer-regForm-btn').click(function (e) {
    $('#emp-reg-form').show();
    $('#cand-reg-form').hide();
});