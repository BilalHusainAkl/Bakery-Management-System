Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class FrmNewProduct

    Private Sub FrmNewProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'con.Open()
        myDs = New DataSet
        Query = "select * from tblProduct"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblProduct")

        CboCategory.Text = CboCategory.Items(0)
        CboPer.Text = CboPer.Items(0)
        CboCategory.Focus()

        'FrmNewUser_Load
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click


        Dim newRow As DataRow = myDs.Tables("tblProduct").NewRow

        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()

        If CboCategory.Text = "" Then
            MsgBox("Select Category")
            CboCategory.Focus()
            Exit Sub
        End If
        If TxtName.Text = "" Then
            MsgBox("Enter Name of Product")
            TxtName.Focus()
            Exit Sub
        End If
        If TxtRate.Text = "" Then
            MsgBox("Enter Rate of Product")
            TxtRate.Focus()
            Exit Sub
        End If
        If CboPer.Text = "" Then
            MsgBox("Select Per Kg or Per Piece")
            CboPer.Focus()
            Exit Sub
        End If
        If TxtQuantity.Text = "" Then
            MsgBox("Enter Quantity of Product")
            TxtQuantity.Focus()
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

            newRow("Category") = CboCategory.Text
            newRow("Name") = TxtName.Text
            newRow("Rate") = TxtRate.Text
            newRow("Per") = CboPer.Text
            newRow("img") = arrImage
            newRow("Quantity") = TxtQuantity.Text

            Con.Open()

            myDs.Tables("tblProduct").Rows.Add(newRow)
            Adpt.Update(myDs, "tblProduct")

            MsgBox("Record has been save successfully")

            CLEAR()
            CboCategory.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddImage(OpenFileDialog1, ImgPictureBox, Me)
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        CLEAR()
    End Sub
    Private Sub CLEAR()
        CboCategory.Text = CboCategory.Items(0)
        TxtName.Text = ""
        TxtRate.Text = ""
        CboPer.Text = CboPer.Items(0)
        TxtQuantity.Text = ""
        ImgPictureBox.Image = Nothing

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub
End Class