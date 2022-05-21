Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class FrmStockIn
    Dim CurrentRow As Integer

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

    Private Sub FrmStockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
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


        'Combo()
        'ShowData(CurrentRow)


        'FrmStockIn_Load
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        CLEAR()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim cb As New OleDbCommandBuilder(Adpt)
        Dim I As Integer
        Dim OldQuantity As Single

        If CboCategory.Text = "" Then
            MsgBox("Enter Category Description")
            CboCategory.Focus()
            Exit Sub
        End If

        If TxtNewQuantity.Text = "" Then
            MsgBox("Enter Quantity Recieved")
            TxtNewQuantity.Focus()
            Exit Sub
        End If

        Try

            For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
                If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") _
                    And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(I)("Name") Then
                    OldQuantity = myDs.Tables("TblProduct").Rows(I)("Quantity")
                    myDs.Tables("TblProduct").Rows(I)("Quantity") = Val(TxtNewQuantity.Text) + OldQuantity

                    Adpt.Update(myDs, "tblProduct")

                    MsgBox("Record has been updated successfully")
                    TxtNewQuantity.Text = ""
                    SEARCH()

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Con.Close()
        End Try

    End Sub

    Private Sub CboSelectCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectCategory.SelectedIndexChanged

        Dim I As Integer
        CboSelectProduct.Items.Clear()
        TxtNewQuantity.Text = ""
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

    Private Sub CboSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectProduct.SelectedIndexChanged
        SEARCH()

    End Sub

    Private Sub SEARCH()
        Dim I As Integer
        Dim bytes() As Byte
        Dim img As Image
        'MsgBox(CmbService.Text)
        For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
            '            If CmbService.Text = myDs.Tables("TblService").Rows(I)("Service") Then
            'CurrentRow = I
            'ShowData(CurrentRow)
            'End If
        Next


        'MsgBox(CmbService.Text)
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

End Class