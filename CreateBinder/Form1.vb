﻿Public Class Form1

    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form As String
        Dim Feld As String
        Dim Ergebnis As String

        Form = TextBox1.Text
        'Feld = TextBox2.Text
        Feld = My.Computer.Clipboard.GetText
        TextBox2.Text = Feld

        Ergebnis = "binder.forField(" & Feld & ")" & vbCrLf _
            & vbTab & vbTab & "//.withConverter(New StringToIntegerConverter( ""keine Zahl""))" & vbCrLf _
            & vbTab & vbTab & "//.asRequired(""Pflichtfeld"")" & vbCrLf _
            & vbTab & vbTab & ".bind(" & Form & "::get" & UppercaseFirstLetter(Feld) & ", " & Form & "::set" & UppercaseFirstLetter(Feld) & ");" & vbCrLf _
            & "TextField " & Feld & "_err = new TextField();" & vbCrLf _
            & Feld & "_err.setVisible(false);"

        TextBox3.Text = Ergebnis
        My.Computer.Clipboard.SetText(Ergebnis)

    End Sub
End Class
