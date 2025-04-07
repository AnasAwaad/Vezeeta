function ShowSuccessMessage(response) {
    $('#Modal').modal('hide');
    $('table tbody').append(response); // if response is a <tr>
}

function ShowErrorMessage(response) {
    alert("Something went wrong."+response);
}


function SaveClinic() {
	let formData = {
		Name: $("#ClinicName").val(),
		Location: $("#ClinicLocation").val(),
	}
	$.ajax({
		url: "/Admin/Clinic/Create",
		type: "POST",
		data: formData,
		success: function (response) {
			ShowSuccessMessage(response);
		},
		error: function (request, status, error) {
			ShowErrorMessage(response);
		}
	});
}

$(document).ready(function () {
	$('.js-render-modal').on('click', function () {
		var item = $(this);
		var myModal = $('#Modal');
		var title = item.data('title');
		var url = item.data('url')

		myModal.find('#ModalTitle').text(title);

		$.get({
			url: url,
			success: function (form) {
				myModal.find('#ModalBody').html(form);
				$.validator.unobtrusive.parse(myModal);
			},
			error: function (e) {
				alert(e);
			}
		})
		myModal.modal('show');


	})
})