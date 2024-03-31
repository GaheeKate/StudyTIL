### Laravel review 
## Controllers
Create controllers based on the MVC pattern located in `app->Http->Controllers`.

## Models
Set up models required for the database (`db`).

## Views
Configure frontend views located in `resources->views`.

## Middleware
Implement defensive and supplementary behaviors.

## Hierarchical Structure
Ensure dependency on routers without fail.
Configure web settings, web routes, and channels such as socket communication.

```
composer create-project --prefer-dist laravel/laravel review_crud

php artisan serve
```

Setting up the database through migration will automatically generate it even if the database language changes
```
php artisan make:migration create_boards_table --create=boards

php artisan migrate

php artisan make:controller BoardsController --resource --model=Board
```
--resource
Route::resource('boards', BoardsController::class);

Use Blade template
```
<?php > -> {{ }}
```

Declare in the parent place and bring as content to be the child
```
@yield('content')
```
Child content
```
@extends('boards.layout')
@section('content')
@endsection
```
Can't just send a form, it would give an error
419 PAGE EXPIRED
```
@csrf
```
$_get $_post -> Request $request

$request->all()
Define fillable in the model

Query builder
Eloquent
Define data to be fetched in advance
```
$board = Board::all();
return view('boards.index')->with('lists', $board);

@foreach ($lists as $ls)
<tr>
    <td>{{$ls->id}}</td>
    <td>{{$ls->subject}}</td>
    <td>{{$ls->contents}}</td>
    <td>{{$ls->created_at}}</td>
</tr>
@endforeach
route('boards.show', $ls->id)

```
```
$board = Board::where('id',$board->id)->first();
return view('boards.show')->with('board',$board);
{{$board->id}}

```
edit
@method('put')

$board->delete();
<form action="{{route('boards.destroy', $ls->id)}}" method="post">
@csrf
@method('delete')

<button type="submit">delete</button>
</form>