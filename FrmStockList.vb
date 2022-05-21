Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class FrmStockList

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        RefreshGrid(False)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub FrmStockList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = FrmMdiMain
        Me.BringToFront()
        Me.WindowState = 2

        RefreshGrid(True)

    End Sub
    Private Sub RefreshGrid(ByVal ShowAll As Boolean)
        Dim i, Count As Integer
        Dim Category, PName, Rate, Per, Quantity As String


        'con.Open()
        myDs = New DataSet
        Query = "select * from tblProduct"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblProduct")

        DataGridView1.Rows.Clear()

        For i = 0 To myDs.Tables("tblProduct").Rows.Count - 1
            Category = myDs.Tables("tblProduct").Rows(i)("Category")
            PName = myDs.Tables("tblProduct").Rows(i)("Name")
            Rate = myDs.Tables("tblProduct").Rows(i)("Rate")
            Per = myDs.Tables("tblProduct").Rows(i)("Per")
            Quantity = myDs.Tables("tblProduct").Rows(i)("Quantity")

            Count = DataGridView1.RowCount

            If ShowAll Then

                DataGridView1.Rows.Add(New String() {Count, Category, PName, Rate, Per, Quantity})

            Else
                If CboSelectCategory.Text = Category Then

                    DataGridView1.Rows.Add(New String() {Count, Category, PName, Rate, Per, Quantity})
                End If
            End If

        Next


    End Sub

    Private Sub BtnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAll.Click
        RefreshGrid(True)
    End Sub
End Class