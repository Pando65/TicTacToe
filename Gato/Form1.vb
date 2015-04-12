Public Class Form1
    Dim mark(10) As Boolean
    Dim cuenta(10) As Integer
    Dim cont, x, y, ocu, inc As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each obj In GroupBox1.Controls
            obj.image = ImageList1.Images(0)
            mark(obj.tag) = False
        Next
        cont = 1
        inc = 1
        ocu = 0


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click
        If mark(sender.tag) = True Then
            Exit Sub
        End If
        mark(sender.tag) = True
        If cont = 1 Then
            inc = 1
            cont = 2
        Else
            inc = -1
            cont = 1
        End If
        sender.image = ImageList1.Images(cont)
        ocu = ocu + 1
        y = Int(sender.tag / 3)
        x = Int(sender.tag Mod 3)
        cuenta(y) = cuenta(y) + inc
        cuenta(x + 3) = cuenta(x + 3) + inc
        If x = y Then
            cuenta(6) = cuenta(6) + inc
        End If
        If x + y = 2 Then
            cuenta(7) = cuenta(7) + inc
        End If

        Dim w As Integer = 0
        For i = 0 To 7
            If cuenta(i) = 3 Then
                MsgBox("Gana O")
                For j = 0 To 8
                    mark(j) = True
                Next
                Exit Sub
            End If
            If cuenta(i) = -3 Then
                MsgBox("Gana X")
                For t = 0 To 8
                    mark(t) = True
                Next
                Exit Sub
            End If
        Next
        If ocu = 9 Then
            MsgBox("Gano Gato")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each obj In GroupBox1.Controls
            obj.image = ImageList1.Images(0)
            mark(obj.tag) = False
        Next
        For g = 0 To 7
            cuenta(g) = 0
        Next
        cont = 1
        inc = 1
        ocu = 0
    End Sub

End Class
