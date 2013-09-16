Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        fullname = txtFullName.Text

        Dim fullnametrimmed As String
        fullnametrimmed = fullname.Trim

        Dim idxspace As Integer
        idxspace = fullnametrimmed.IndexOf(" ")

        Dim firstname As String
        firstname = fullnametrimmed.Substring(0, idxspace)

        txtFirstName.Text = firstname

    End Sub
End Class
