# Data tables: jQuery plugin for tables

use cases
to refer a data from other colomns in a same row
mind that $this is pointing to where
let id = tablename.row($(this).parents('tr')).data();
console.log(id["tableid"])

calculating numbers in a same row
{
    data: null,
    render: function ( data, type, row ) {
        return Math.round( ( row.price - row.cost ) / row.price * 100 )+'%';
    }
}

#### datatable_name.ajax.reload() method is a function provided by the DataTables library to reload the table data from the server using AJAX. It allows to refresh the table's content without having to recreate the entire DataTable.

ex) tbl_resource.ajax.reload(null, false):

- null (optional): Allows to specify additional data to be sent to the server when making the AJAX request. Pass null when sending extra data is not required.

- false (optional): This parameter controls whether or not to reset the current paging position of the table after the reload. If set to false, the current page will be preserved, and the data will be reloaded without changing the page. If set to true, the table will go back to the first page after the reload. 


