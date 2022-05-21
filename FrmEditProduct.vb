Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class FrmEditProduct
    Dim CurrentRow As Integer
    Private Sub FrmEditProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'con.Open()
        myDs = New DataSet
        Query = "select * from tblProduct"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblProduct")

        CboSelectCategory.Text = CboSelectCategory.Items(0)

        SEARCH()


        CboSelectCategory.Focus()


        CurrentRow = 0

    End Sub

    Private Sub Combo()
        Dim I As Integer
        For I = 0 To (myDs.Tables("TblProduct").Rows.Count) - 1
            CboCategory.Items.Add(myDs.Tables("TblProduct").Rows(I)("Category"))
        Next
    End Sub
    Private Sub ComboClear()
        Dim I As Integer
        For I = 0 To CboCategory.Items.Count - 1
            CboCategory.Items.Remove(CboCategory.Items(0))
        Next
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            'ServiceTextBox.Text = myDs.Tables("TblService").Rows(CurrentRow)("Service")
            'ChargesTextBox.Text = myDs.Tables("TblService").Rows(CurrentRow)("Charges")
            'CboCategory.Text = CboCategory.Items(CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CLEAR()
        CboCategory.Text = CboCategory.Items(0)
        TxtName.Text = ""
        TxtRate.Text = ""
        CboPer.Text = CboPer.Items(0)

        ImgPictureBox.Image = Nothing

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SEARCH()
        Dim I As Integer
        Dim bytes() As Byte
        Dim img As Image

        For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
            If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") _
                And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(I)("Name") Then

                CboCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category")
                TxtName.Text = myDs.Tables("TblProduct").Rows(I)("Name")
                TxtRate.Text = myDs.Tables("TblProduct").Rows(I)("Rate")
                CboPer.Text = myDs.Tables("TblProduct").Rows(I)("Per")
                TxtQuantity.Text = myDs.Tables("TblProduct").Rows(I)("Quantity")

                bytes = myDs.Tables("TblProduct").Rows(I)("Img")
                img = Image.FromStream(New System.IO.MemoryStream(bytes))
                ImgPictureBox.Image = img


            End If
        Next


    End Sub

    
    
    

    

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        CLEAR()
    End Sub



    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Dim cb As New OleDbCommandBuilder(Adpt)
        
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()

        If CboCategory.Text = "" Then
            MsgBox("Enter Category Description")
            CboCategory.Focus()
            Exit Sub
        End If

        If TxtName.Text = "" Then
            MsgBox("Enter Product Name")
            TxtName.Focus()
            Exit Sub
        End If
        If TxtRate.Text = "" Then
            MsgBox("Enter Rate of product")
            TxtRate.Focus()
            Exit Sub
        End If

        If CboPer.Text = "" Then
            MsgBox("Enter Select Rate/Per entry")
            CboPer.Focus()
            Exit Sub
        End If

        If TxtQuantity.Text = "" Then
            MsgBox("Enter Quantity of product")
            TxtQuantity.Focus()
            Exit Sub
        End If
        If IsNothing(ImgPictureBox.Image) Then
            MsgBox("Click on Picture box to insert an image")
            TxtName.Focus()
            Exit Sub
        End If
        Try

            For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
                If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") _
                    And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(I)("Name") Then

                    myDs.Tables("TblProduct").Rows(I)("Category") = CboCategory.Text
                    myDs.Tables("TblProduct").Rows(I)("Name") = TxtName.Text
                    myDs.Tables("TblProduct").Rows(I)("Rate") = TxtRate.Text
                    myDs.Tables("TblProduct").Rows(I)("Per") = CboPer.Text
                    myDs.Tables("TblProduct").Rows(I)("Quantity") = TxtQuantity.Text

                    '--------- image update ---------
                    ImgPictureBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length
                    mstream.Close()
                    '-----------------------------

                    myDs.Tables("TblProduct").Rows(I)("img") = arrImage

                    Adpt.Update(myDs, "tblProduct")

                    MsgBox("Record has been updated successfully")

                    SEARCH()

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Con.Close()
        End Try

    End Sub

    Private Sub CboSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectProduct.SelectedIndexChanged
        SEARCH()
    End Sub

    Private Sub CboSelectCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectCategory.SelectedIndexChanged

        Dim I As Integer
        CboSelectProduct.Items.Clear()

        'MsgBox(CmbService.Text)
        For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
            If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") Then
                CboSelectProduct.Items.Add(myDs.Tables("TblProduct").Rows(I)("Name"))
            End If
        Next

        'CboSelectProduct.Text = CboSelectProduct.Items.Count
        If CboSelectProduct.Items.Count > 0 Then
            CboSelectProduct.Text = CboSelectProduct.Items(0)
            SEARCH()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddImage(OpenFileDialog1, ImgPictureBox, Me)
    End Sub

    
End Class