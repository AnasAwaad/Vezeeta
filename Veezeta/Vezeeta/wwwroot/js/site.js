function ShowSuccessMessage(response) {
    $('#Modal').modal('hide');
    $('table tbody').append(response); // if response is a <tr>
}

function ShowErrorMessage(xhr) {
    alert("Something went wrong.");
}

function onBegin() {
    console.log("Submitting...");
}

function onComplete() {
    console.log("Done.");
}
