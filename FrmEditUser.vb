Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class FrmEditUser
    Dim CurrentRow As Integer

    Private Sub FrmEditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = FrmMdiMain
        'Me.BringToFront()
        'Me.WindowState = 2

        RefreshCombo()
    End Sub

    Private Sub RefreshCombo()
        Dim i As Integer

        'con.Open()
        myDs = New DataSet
        Query = "select * from tblUser"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblUser")

        For i = 0 To myDs.Tables("TblUser").Rows.Count - 1
            CboSelectUser.Items.Add(myDs.Tables("TblUser").Rows(i)("U_Name"))

        Next
        If CboSelectUser.Items.Count > 0 Then
            CboSelectUser.Text = CboSelectUser.Items(0)
        End If

        CboSelectUser.Focus()

        CurrentRow = 0


        'Combo()
        'ShowData(CurrentRow)


        'FrmEditUser_Load
    End Sub


    Private Sub SEARCH()

        Dim I As Integer
        Dim bytes() As Byte
        Dim img As Image

        'MsgBox(CmbService.Text)
        For I = 0 To myDs.Tables("TblUser").Rows.Count - 1
            If CboSelectUser.Text = myDs.Tables("TblUser").Rows(I)("U_Name") Then
                CurrentRow = I

                TxtName.Text = myDs.Tables("TblUser").Rows(I)("U_Name")
                TxtUserName.Text = myDs.Tables("TblUser").Rows(I)("U_UName")
                TxtPass.Text = myDs.Tables("TblUser").Rows(I)("U_Pass")
                CboType.Text = myDs.Tables("TblUser").Rows(I)("U_Type")


                bytes = myDs.Tables("TblUser").Rows(I)("Img")
                img = Image.FromStream(New System.IO.MemoryStream(bytes))
                ImgPictureBox.Image = img


            End If
        Next




    End Sub

    
    Private Sub CboSelectUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectUser.SelectedIndexChanged
        SEARCH()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDbCommandBuilder(Adpt)
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

        Try
            ImgPictureBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            'Dim FileSize As UInt32
            'FileSize = mstream.Length
            mstream.Close()

            myDs.Tables("TblUser").Rows(CurrentRow)("U_Name") = TxtName.Text
            myDs.Tables("TblUser").Rows(CurrentRow)("U_UName") = TxtUserName.Text
            myDs.Tables("TblUser").Rows(CurrentRow)("U_Pass") = TxtPass.Text
            myDs.Tables("TblUser").Rows(CurrentRow)("U_Type") = CboType.Text

            myDs.Tables("tbluser").Rows(CurrentRow)("img") = arrImage

            Adpt.Update(myDs, "TblUser")
            MsgBox("Record has been updated successfully")
            CboSelectUser.Text = ""

            CboSelectUser.Items.Clear()

            RefreshCombo()

            CLEAR()
            CboSelectUser.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Con.Close()
        End Try

    End Sub

    Private Sub CLEAR()
        TxtName.Text = ""
        TxtUserName.Text = ""
        TxtPass.Text = ""
        CboType.Text = "Staff"
        ImgPictureBox.Image = Nothing

    End Sub



    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        CLEAR()
    End Sub

    Private Sub BtnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddImage.Click
        AddImage(OpenFileDialog1, ImgPictureBox, Me)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    
End Class