@ModelType IEnumerable(Of PracticaClase.Alumno)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Lista de Alumnos</title>
</head>
<body>
    <h2>Lista de Alumnos</h2>

    <ul>
        @For Each item In Model
        @<li>
            @item.Nombre
        </li>
        Next
    </ul>
   
</body>
</html>
