Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Dim db As ColegioEntities = New ColegioEntities


            Dim objAlumno As New Alumno

            'objAlumno.Nombre = "Carolina Montiel"
            'objAlumno.CarreraID = 3
            'objAlumno.NroDocumento = "85544"
            'objAlumno.Email = "carol@empresa.com.py"
            'objAlumno.Telefono = "0991837655"
            'db.Alumno.Add(objAlumno)
            'db.SaveChanges()

            objAlumno = db.Alumno.Find(4)
            'objAlumno.Nombre = "Pedro Gonzalez Romero"
            'db.Entry(objAlumno).State = System.Data.Entity.EntityState.Modified
            'db.SaveChanges()

            db.Alumno.Remove(objAlumno)
            db.SaveChanges()


            Dim ListAlumnos As New List(Of Alumno)
            ListAlumnos = db.Alumno.ToList


            Return View(ListAlumnos)
        End Function
    End Class
End Namespace