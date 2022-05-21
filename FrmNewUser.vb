Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class FrmNewUser

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim newRow As DataRow = myDs.Tables("tblUser").NewRow
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()

        If TxtName.Text = "" Then
            MsgBox("Enter User Name")
            TxtName.Focus()
            Exit Sub
        End If
        If TxtUserName.Text = "" Then
            MsgBox("Enter user ID Name")
            TxtUserName.Focus()
            Exit Sub
        End If
        If TxtPass.Text = "" Then
            MsgBox("Enter Password")
            TxtPass.Focus()
            Exit Sub
        End If
        If CboType.Text = "" Then
            MsgBox("Select Role")
            TxtPass.Focus()
            Exit Sub
        End If
        If IsNothing(ImgPictureBox.Image) Then
            MsgBox("Click on Picture box to insert an image")
            TxtName.Focus()
            Exit Sub
        End If

        '        sqlStr = "insert into tblcompany(img) values(@img)"
        Try
            ImgPictureBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            newRow("U_Name") = TxtName.Text
            newRow("U_Uname") = TxtUserName.Text
            newRow("U_Pass") = TxtPass.Text
            newRow("U_type") = CboType.Text


            newRow("img") = arrImage

            Con.Open()

            myDs.Tables("tblUser").Rows.Add(newRow)
            Adpt.Update(myDs, "tblUser")


            MsgBox("Record has been save successfully")

            CLEAR()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub


    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMdiMain
        Me.BringToFront()
        Me.WindowState = 2

        'con.Open()
        myDs = New DataSet
        Query = "select * from tblUser"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(adpt)
        adpt.Fill(myDs, "tblUser")

        'FrmNewUser_Load
    End Sub
    Private Sub CLEAR()
        TxtName.Text = ""
        TxtUserName.Text = ""
        TxtPass.Text = ""
        CboType.Text = "Staff"

        ImgPictureBox.Image = Nothing

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgPictureBox.Click

    End Sub
    Private Sub BtnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddImage.Click
        AddImage(OpenFileDialog1, ImgPictureBox, Me)
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        CLEAR()
    End Sub
End Class