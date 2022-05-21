Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class FrmDeleteProduct
    Dim CurrentRow As Integer
    Dim eA As System.EventArgs
    Dim senderObj As System.Object

    Private Sub FrmDeleteProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myDs = New DataSet
        Query = "select * from tblProduct"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblProduct")

        LoadMe()

    End Sub
    Private Sub LoadMe()

        CboSelectCategory.Text = CboSelectCategory.Items(0)
        CboSelectProduct.Items.Clear()
        ComboFill()

        SEARCH()

        CboSelectCategory.Focus()
        CurrentRow = 0
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
    Private Sub ComboFill()
        Dim I As Integer
        For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
            If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") Then
                CboSelectProduct.Items.Add(myDs.Tables("TblProduct").Rows(I)("Name"))
            End If
        Next
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CboSelectCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectCategory.SelectedIndexChanged

        CboSelectProduct.Items.Clear()
        ComboFill()

        'CboSelectProduct.Text = CboSelectProduct.Items.Count
        If CboSelectProduct.Items.Count > 0 Then
            CboSelectProduct.Text = CboSelectProduct.Items(0)
            SEARCH()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim cb As New OleDbCommandBuilder(Adpt)
        Dim I As Integer
        Dim response As Integer

        If CboSelectCategory.Text = "" Then
            MsgBox("Select Category ")
            CboSelectCategory.Focus()
            Exit Sub
        End If
        If CboSelectProduct.Text = "" Then
            MsgBox("Select Product")
            CboSelectProduct.Focus()
            Exit Sub
        End If

        response = MsgBox("do you really want to delete it?", vbCritical + vbYesNo)
        If response = 6 Then
            Try

                For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
                    If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") _
                        And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(I)("Name") Then

                        myDs.Tables("TblProduct").Rows(I).Delete()

                        Adpt.Update(myDs, "tblProduct")

                        MsgBox("Record has been updated successfully")
                        CboSelectProduct.Items.Clear()
                        ComboFill()

                        If CboSelectProduct.Items.Count > 0 Then
                            CboSelectProduct.Text = CboSelectProduct.Items(0)
                        End If
                        SEARCH()
                    End If

                Next

            Catch ex As Exception
                'MsgBox(ex.Message)
            Finally
                'Con.Close()
            End Try
        End If

    End Sub
    Private Sub CboSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectProduct.SelectedIndexChanged
        SEARCH()
    End Sub
End Class