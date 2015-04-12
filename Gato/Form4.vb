Public Class Form4
    Dim mark(9), cuenta(8) As Integer
    Dim ia As New Random
    Dim cont, inc, ocu, y, n, x As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each obj In GroupBox1.Controls
            obj.image = ImageList1.Images(0)
            mark(obj.tag) = False
        Next
        cont = 1
        inc = 1
        ocu = 0
    End Sub
    Private Sub validar()
        Dim w As Integer = 0
        For i = 0 To 7
            If cuenta(i) = 3 Then
                MsgBox("X Wins", , "Game over")
                For j = 0 To 8
                    mark(j) = True
                Next
                ocu = 10
                Exit Sub
            End If
            If cuenta(i) = -3 Then
                MsgBox("O Wins", , "Game over")
                For t = 0 To 8
                    mark(t) = True
                Next
                ocu = 10
                Exit Sub
            End If
        Next
        If ocu = 9 Then
            MsgBox("Cat wins", , "Game over")

        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click
        If mark(sender.tag) = True Then
            Exit Sub
        End If

        mark(sender.tag) = True
        sender.image = ImageList1.Images(1)
        ocu = ocu + 1
        inc = 1
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
        validar()
        If ocu < 9 Then
            n = ia.Next(0, 9)
            Do While (mark(n) = True)
                n = ia.Next(0, 9)
            Loop
            inc = -1
            mark(n) = True
            If n = 0 Then
                PictureBox1.Image = ImageList1.Images(2)
            End If
            If n = 1 Then
                PictureBox2.Image = ImageList1.Images(2)
            End If
            If n = 2 Then
                PictureBox3.Image = ImageList1.Images(2)
            End If
            If n = 3 Then
                PictureBox4.Image = ImageList1.Images(2)
            End If
            If n = 4 Then
                PictureBox5.Image = ImageList1.Images(2)
            End If
            If n = 5 Then
                PictureBox6.Image = ImageList1.Images(2)
            End If
            If n = 6 Then
                PictureBox7.Image = ImageList1.Images(2)
            End If
            If n = 7 Then
                PictureBox8.Image = ImageList1.Images(2)
            End If
            If n = 8 Then
                PictureBox9.Image = ImageList1.Images(2)
            End If

            ocu = ocu + 1
            y = Int(n / 3)
            x = Int(n Mod 3)
            cuenta(y) = cuenta(y) + inc
            cuenta(x + 3) = cuenta(x + 3) + inc
            If x = y Then
                cuenta(6) = cuenta(6) + inc
            End If
            If x + y = 2 Then
                cuenta(7) = cuenta(7) + inc
            End If
            validar()
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