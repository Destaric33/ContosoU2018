$(function () {
    //wait for DOM to be loaded (ready function)

    //DataTables
    $("#tablesorted").DataTable({
        "columnDefs": [
            { "orderable": false, "targets": -1 },//stop sorting on last column
        ],
        "lengthMenu":[ [5,10,25,50,-1],[5,10,25,50,"all"] ] //Drop down for how many entries.
    });
});