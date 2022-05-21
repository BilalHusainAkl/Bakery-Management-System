Imports System.IO
Imports System.Data.OleDb
Imports System.Data


Public Class Bill
    Dim CurrentRow As Integer
    Dim T As Single


    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'con.Open()
        T = 0
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

    Private Sub SEARCH()
        Dim I As Integer
        Dim bytes() As Byte
        Dim img As Image

        Dim R, P, Q As String

        For I = 0 To myDs.Tables("TblProduct").Rows.Count - 1
            If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(I)("Category") _
                And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(I)("Name") Then

                R = myDs.Tables("TblProduct").Rows(I)("Rate")
                P = myDs.Tables("TblProduct").Rows(I)("Per")
                TxtRate.Text = R
                LblPer.Text = "/ " & P
                
                Q = myDs.Tables("TblProduct").Rows(I)("Quantity")
                '-------------- image -----------------
                bytes = myDs.Tables("TblProduct").Rows(I)("Img")
                img = Image.FromStream(New System.IO.MemoryStream(bytes))
                ImgPictureBox.Image = img
                '---------------------

                TxtAvailable.Text = Q



            End If
        Next


    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Me.WindowState = 0

        HideContent()

        PrintForm1.Print()
        Me.WindowState = 2

        ShowContent()

    End Sub
    Private Sub HideContent()
        LblCategory.Visible = False
        LblName.Visible = False
        LblRate.Visible = False
        LblQuantity.Visible = False
        LblAvailable.Visible = False
        LblPer.Visible = False

        CboSelectCategory.Visible = False
        CboSelectProduct.Visible = False
        TxtRate.Visible = False
        TxtQuantity.Visible = False
        TxtAvailable.Visible = False

        ImgPictureBox.Visible = False

        BtnPrint.Visible = False
        BtnAdd.Visible = False
        BtnNew.Visible = False

    End Sub
    Private Sub ShowContent()
        LblCategory.Visible = True
        LblName.Visible = True
        LblRate.Visible = True
        LblQuantity.Visible = True
        LblAvailable.Visible = True
        LblPer.Visible = True

        CboSelectCategory.Visible = True
        CboSelectProduct.Visible = True
        TxtRate.Visible = True
        TxtQuantity.Visible = True
        TxtAvailable.Visible = True

        ImgPictureBox.Visible = True

        BtnPrint.Visible = True
        BtnAdd.Visible = True
        BtnNew.Visible = True
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

    Private Sub CboSelectProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelectProduct.SelectedIndexChanged
        SEARCH()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim A, B, AMT As Single
        Dim N, R, P, Q As String
        A = Val(TxtAvailable.Text)
        B = Val(TxtQuantity.Text)

        If TxtQuantity.Text = "" Then
            MsgBox("Enter Required Quantity")
            TxtQuantity.Focus()
            Exit Sub

        End If


        If A >= B Then
            N = CboSelectCategory.Text & " : " & CboSelectProduct.Text
            R = TxtRate.Text
            P = LblPer.Text
            Q = TxtQuantity.Text
            AMT = Val(R) * Q
            T = T + AMT

            DataGridView1.Rows.Add(New String() {N, R & " " & P, Q, AMT})
            TxtTotal.Text = T

            updateTable()
            TxtQuantity.Text = 1
        Else
            MsgBox("Required Quantity " & B & " is not available of the product")
            TxtQuantity.Focus()
            TxtQuantity.SelectAll()
        End If

        'updateTable()
    End Sub
    Private Sub updateTable()
        Dim i As Integer
        Dim NewQuantity As Single

        Dim cb As New OleDbCommandBuilder(Adpt)
        
        Try
            For i = 0 To myDs.Tables("TblProduct").Rows.Count - 1
                If CboSelectCategory.Text = myDs.Tables("TblProduct").Rows(i)("Category") _
                    And CboSelectProduct.Text = myDs.Tables("TblProduct").Rows(i)("Name") Then
                    NewQuantity = Val(TxtAvailable.Text) - Val(TxtQuantity.Text)

                    myDs.Tables("TblProduct").Rows(i)("Quantity") = NewQuantity

                    Adpt.Update(myDs, "tblProduct")

                    'MsgBox("Quantity updated successfully")

                    SEARCH()

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Con.Close()
        End Try

    End Sub

    
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        DataGridView1.Rows.Clear()
        T = 0
        TxtQuantity.Text = 1
        TxtTotal.Text = 0

    End Sub
End Class