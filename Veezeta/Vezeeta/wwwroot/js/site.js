
var updatedRow;
var table;

function OnModalSuccess(row) {
	$('#Modal').modal('hide');

	
	var $row = $(row);
	var rowData = [];

	// Extract all <td> cells HTML from the new row
	$row.find('td').each(function () {
		rowData.push($(this).html());
	});

	if (updatedRow === undefined) {
		table.row.add(rowData).draw(false)
	} else {
		table.row(updatedRow).data(rowData).draw(false);
		updatedRow = undefined;
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
	$(document).on('click', '.js-render-modal', function () {
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



	$(document).on('click', '.js-toggle-status', function () {
		var btn = $(this);
		$.post({
			url: btn.data('url'),
			success: function (row) {
				updatedRow = btn.parents('tr');
				OnModalSuccess(row);
			}
		})
	})


	table = $('.js-dataTable').DataTable();
})