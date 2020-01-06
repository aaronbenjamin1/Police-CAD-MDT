Imports MySql.Data.MySqlClient

Public Class civilianreg

    'MYSQL SHIT
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            pdlogin.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label3_MouseUp(sender As Object, e As MouseEventArgs) Handles Label3.MouseUp
        drag = False
    End Sub


    'MYSQL SHIT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
            "server=107.180.40.154;userid=pierce;password=pierce;database=database"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "insert into database.table2 (username,password) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Registration Success!")
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            For Each Control As Control In Me.Controls
                If TypeOf Control Is TextBox Then
                    Control.Text = String.Empty
                End If
            Next
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
            "server=107.180.40.154;userid=pierce;password=pierce;database=database"

        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Successful")
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            pdlogin.Show()
        End If
    End Sub

    Private Sub civilianreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.Ping("103.195.100.31") Then
            PictureBox3.Image = My.Resources.yes
        Else
            PictureBox3.Image = My.Resources.no
        End If

        If My.Computer.Network.Ping("107.180.40.154") Then
            PictureBox1.Image = My.Resources.yes
        Else
            PictureBox1.Image = My.Resources.no
        End If
    End Sub
End Class