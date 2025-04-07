
var updatedRow;
function OnModalSuccess(row) {
	$('#Modal').modal('hide');

	if (updatedRow == undefined) {
		$('table tbody').append(row); // if response is a <tr>
	} else {
		$(updatedRow).replaceWith(row);
	}
}

function OnModalError(response) {
    alert("Something went wrong."+response);
}


function SaveClinic(url) {
	let formData = {
		Id : $('#clinicId').val(),
		Name: $("#ClinicName").val(),
		Location: $("#ClinicLocation").val(),
	}
	$.ajax({
		url,
		type: "POST",
		data: formData,
		success: function (response) {
			OnModalSuccess(response);
		},
		error: function (request, status, error) {
			OnModalError(error);
		}
	});
}

$(document).ready(function () {
	$('.js-render-modal').on('click', function () {
		var item = $(this);
		var myModal = $('#Modal');
		var title = item.data('title');
		var url = item.data('url');

		// replace old row with new row when update clinic 
		if (item.data('update') != undefined) {
			updatedRow = item.parents('tr');
		}

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