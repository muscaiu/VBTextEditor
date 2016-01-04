Imports System.Security.Cryptography

Public Class Form1

    'Undo
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub
    'Redo
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub
    'Copy
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub
    'Paste
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
    'Cut
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub
    'Select All
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub
    'Exit
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'Select Text Color
    Private Sub SelectedForeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color

    End Sub
    'Save As ...
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If RichTextBox1.Text.Length > 0 Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
        End If
    End Sub

    'Open Txt File
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    'TO Uppercase
    Private Sub ChangeToUppercaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToUppercaseToolStripMenuItem.Click
        RichTextBox1.Text = StrConv(RichTextBox1.Text, VbStrConv.Uppercase)
    End Sub

    'TO Lowercase
    Private Sub ChangeToLowercaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToLowercaseToolStripMenuItem.Click
        RichTextBox1.Text = StrConv(RichTextBox1.Text, VbStrConv.Lowercase)
    End Sub

    'TO Propercase
    Private Sub ChangeToPropercaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToPropercaseToolStripMenuItem.Click
        RichTextBox1.Text = StrConv(RichTextBox1.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub EncryptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptToolStripMenuItem.Click
        MsgBox(Text)
    End Sub

    'Public Function SimpleCrypt(ByVal Text As String) As String
    '    Dim strTempChar As String, i As Integer
    '    For i = 1 To Len(Text)
    '        If Asc(Mid$(Text, i, 1)) < 128 Then
    '            strTempChar =
    '      CType(Asc(Mid$(Text, i, 1)) + 128, String)
    '        ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
    '            strTempChar =
    '      CType(Asc(Mid$(Text, i, 1)) - 128, String)
    '        End If
    '        Mid$(Text, i, 1) =
    '            Chr(CType(strTempChar, Integer))
    '    Next i
    '    Return Text
    'End Function

    'Public Shared Function Decrypt(ByVal strText As String, ByVal strKey As String) As String
    '    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    '    Dim inputByteArray(strText.Length) As Byte
    '    Dim result As String
    '    Try
    '        Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Left(strKey, 8))
    '        Using des As New DESCryptoServiceProvider
    '            inputByteArray = Convert.FromBase64String(strText)
    '            Using ms As New IO.MemoryStream(inputByteArray)
    '                Using cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Read)
    '                    Using srDecrypt As = New StreamReader(cs)
    '                        result = srDecrypt.ReadToEnd()
    '                    End Using
    '                End Using
    '            End Using
    '        End Using
    '        Return result
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    'End Function

End Class
