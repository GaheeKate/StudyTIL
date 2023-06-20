Data tables: jQuery plugin for tables

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
