Public Class pdcharges

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            main.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        drag = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sent As String
        Dim sent1 As String
        sent = TextBox3.Text
        sent1 = Val(TextBox4.Text)
        Select Case ComboBox1.SelectedIndex
            Case 0
                TextBox4.Text = "" + sent1
            Case 1
                TextBox4.Text = sent1 + 50
            Case 2
                TextBox4.Text = sent1 + 100
            Case 3
                TextBox4.Text = sent1 + 200
            Case 4
                TextBox4.Text = sent1 + 150
            Case 5
                TextBox4.Text = sent1 + 250
            Case 6
                TextBox4.Text = sent1 + 50
            Case 7
                TextBox4.Text = sent1 + 500
            Case 8
                TextBox4.Text = sent1 + 100
            Case 9
                TextBox4.Text = sent1 + 500
            Case 10
                TextBox4.Text = sent1 + 100
            Case 11
                TextBox4.Text = sent1 + 250
            Case 12
                TextBox4.Text = sent1 + 250
            Case 13
                TextBox4.Text = sent1 + 100
            Case 14
                TextBox4.Text = sent1 + 50
            Case 15
                TextBox4.Text = sent1 + 50
            Case 16
                TextBox4.Text = sent1 + 50
            Case 17
                TextBox4.Text = sent1 + 50
            Case 18
                TextBox4.Text = sent1 + 0
            Case 19
                TextBox4.Text = sent1 + 50
            Case 20
                TextBox4.Text = sent1 + 250
            Case 21
                TextBox4.Text = sent1 + 100
            Case 22
                TextBox4.Text = sent1 + 150
            Case 23
                TextBox4.Text = sent1 + 100
            Case 24
                TextBox4.Text = sent1 + 50
            Case 25
                TextBox4.Text = sent1 + 100
            Case 26
                TextBox4.Text = sent1 + 250
            Case 27
                TextBox4.Text = sent1 + 250
            Case 28
                TextBox4.Text = sent1 + 50
            Case 29
                TextBox4.Text = sent1 + 250
            Case 30
                TextBox4.Text = sent1 + 250
            Case 31
                TextBox4.Text = sent1 + 500
            Case 32
                TextBox4.Text = sent1 + 100
            Case 34
                TextBox4.Text = sent1 + 50
            Case 35
                TextBox4.Text = sent1 + 100
            Case 36
                TextBox4.Text = sent1 + 50
            Case 37
                TextBox4.Text = sent1 + 75
            Case 38
                TextBox4.Text = sent + 150
            Case 39
                TextBox4.Text = sent1 + 50
            Case 40
                TextBox4.Text = sent1 + 100
            Case 41
                TextBox4.Text = sent1 + 50
            Case 42
                TextBox4.Text = sent1 + 150
            Case 43
                TextBox4.Text = sent1 + 300
            Case 44
                TextBox4.Text = sent1 + 250
            Case 45
                TextBox4.Text = sent1 + 100
            Case 46
                TextBox4.Text = sent1 + 250
            Case 47
                TextBox4.Text = sent1 + 250
            Case 48
                TextBox4.Text = sent1 + 250
            Case 49
                TextBox4.Text = sent1 + 150
            Case 50
                TextBox4.Text = sent1 + 200
            Case 51
                TextBox4.Text = sent1 + 150
            Case 52
                TextBox4.Text = sent1 + 150
            Case 53
                TextBox4.Text = sent1 + 250
            Case 54
                TextBox4.Text = sent1 + 250
            Case 55
                TextBox4.Text = sent1 + 150
            Case 56
                TextBox4.Text = sent1 + 100
            Case 57
                TextBox4.Text = sent1 + 75
            Case 58
                TextBox4.Text = sent1 + 100
            Case 59
                TextBox4.Text = sent1 + 100
            Case 60
                TextBox4.Text = sent1 + 250
            Case 61
                TextBox4.Text = sent1 + 50
            Case 62
                TextBox4.Text = sent1 + 150
            Case 63
                TextBox4.Text = sent1 + 150
            Case 64
                TextBox4.Text = sent1 + 100
            Case 65
                TextBox4.Text = sent1 + 100
            Case 66
                TextBox4.Text = sent1 + 250
            Case 67
                TextBox4.Text = sent1 + 100
            Case 68
                TextBox4.Text = sent1 + 100
            Case 69
                TextBox4.Text = sent1 + 100
            Case 70
                TextBox4.Text = sent1 + 150
            Case 71
                TextBox4.Text = sent1 + 50
            Case 72
                TextBox4.Text = sent1 + 0
            Case 73
                TextBox4.Text = sent1 + 75
            Case 74
                TextBox4.Text = sent1 + 50
        End Select


        TextBox3.Text = ComboBox1.SelectedItem & " " + sent
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sent As String
        Dim sent1 As String
        sent1 = Val(TextBox4.Text)
        Select Case ComboBox2.SelectedIndex
            Case 0
                TextBox4.Text = "" + sent1
            Case 1
                TextBox4.Text = sent1 + 500
            Case 2
                TextBox4.Text = sent1 + 1500
            Case 3
                TextBox4.Text = sent1 + 1000
            Case 4
                TextBox4.Text = sent1 + 1100
            Case 5
                TextBox4.Text = sent1 + 1000
            Case 6
                TextBox4.Text = sent1 + 500
            Case 7
                TextBox4.Text = sent1 + 8000
            Case 8
                TextBox4.Text = sent1 + 10000
            Case 9
                TextBox4.Text = sent1 + 400
            Case 10
                TextBox4.Text = sent1 + 2100
            Case 11
                TextBox4.Text = sent1 + 950
            Case 12
                TextBox4.Text = sent1 + 500
            Case 13
                TextBox4.Text = sent1 + 250
            Case 14
                TextBox4.Text = sent1 + 900
            Case 15
                TextBox4.Text = sent1 + 750
            Case 16
                TextBox4.Text = " " + sent1
            Case 17
                TextBox4.Text = sent1 + 1500
            Case 18
                TextBox4.Text = sent1 + 1750
            Case 19
                TextBox4.Text = sent1 + 2250
            Case 20
                TextBox4.Text = sent1 + 250
            Case 21
                TextBox4.Text = sent1 + 1500
            Case 22
                TextBox4.Text = sent1 + 500
            Case 23
                TextBox4.Text = sent1 + 1000
            Case 24
                TextBox4.Text = sent1 + 1000
            Case 25
                TextBox4.Text = sent1 + 750
            Case 26
                TextBox4.Text = sent1 + 750
            Case 27
                TextBox4.Text = sent1 + 750
            Case 28
                TextBox4.Text = sent1 + 750
            Case 29
                TextBox4.Text = sent1 + 900
            Case 30
                TextBox4.Text = sent1 + 750
            Case 31
                TextBox4.Text = " " + sent1
            Case 32
                TextBox4.Text = sent1 + 1750
            Case 33
                TextBox4.Text = sent1 + 15000
            Case 34
                TextBox4.Text = sent1 + 250
            Case 35
                TextBox4.Text = sent1 + 500
            Case 36
                TextBox4.Text = sent1 + 900
            Case 37
                TextBox4.Text = sent1 + 2500
            Case 38
                TextBox4.Text = sent1 + 500
            Case 39
                TextBox4.Text = sent1 + 3000
            Case 40
                TextBox4.Text = sent1 + 3000
            Case 41
                TextBox4.Text = sent1 + 2500
            Case 42
                TextBox4.Text = sent1 + 500
            Case 43
                TextBox4.Text = sent1 + 1000
            Case 44
                TextBox4.Text = sent1 + 1500
            Case 45
                TextBox4.Text = sent1 + 500
            Case 46
                TextBox4.Text = sent1 + 1000
            Case 47
                TextBox4.Text = sent1 + 750
            Case 48
                TextBox4.Text = sent1 + 500
            Case 49
                TextBox4.Text = sent1 + 500
            Case 50
                TextBox4.Text = sent1 + 500
            Case 51
                TextBox4.Text = sent1 + 1500
            Case 52
                TextBox4.Text = sent1 + 10000
            Case 53
                TextBox4.Text = sent1 + 750
            Case 54
                TextBox4.Text = sent1 + 2250
            Case 55
                TextBox4.Text = sent1 + 1000
            Case 56
                TextBox4.Text = sent1 + 2250
            Case 57
                TextBox4.Text = sent1 + 2500
            Case 58
                TextBox4.Text = sent1 + 4000
            Case 59
                TextBox4.Text = sent1 + 400
            Case 60
                TextBox4.Text = sent1 + 1750
            Case 61
                TextBox4.Text = sent1 + 500
            Case 62
                TextBox4.Text = sent1 + 2500
        End Select
        sent = TextBox3.Text
        TextBox3.Text = ComboBox2.SelectedItem & " " + sent
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                TextBox3.Text = String.Empty
                TextBox4.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub OpEquals_Click(sender As Object, e As EventArgs) Handles OpEquals.Click
        Dim test As String
        Dim equation As String = TextBox4.Text
        test = 0.0725 * equation
        Dim result = test + New DataTable().Compute(equation, Nothing)
        TextBox6.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Are you sure you want to deduct $" & TextBox6.Text & " from this person?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("$" & TextBox6.Text & " has been deducted.")
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox6.Text = String.Empty
            ComboBox1.Text = String.Empty
            ComboBox2.Text = String.Empty
        End If
    End Sub

    Private Sub Pdcharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("The charges area is still in its Alpha stage.", MsgBoxStyle.OkOnly)
    End Sub
End Class