Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class FrmUserList


    Private Sub FrmUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMdiMain
        Me.BringToFront()
        Me.WindowState = 2

        RefreshGrid()

    End Sub
    Private Sub RefreshGrid()
        Dim i As Integer
        Dim Name, UName As String


        'con.Open()
        myDs = New DataSet
        Query = "select * from tblUser"
        Adpt = New OleDbDataAdapter(Query, Con)
        Adpt.SelectCommand.CommandText = Query
        CmdBld = New OleDbCommandBuilder(Adpt)
        Adpt.Fill(myDs, "tblUser")

        For i = 0 To myDs.Tables("TblUser").Rows.Count - 1
            Name = myDs.Tables("TblUser").Rows(i)("U_Name")
            UName = myDs.Tables("TblUser").Rows(i)("U_UName")

            DataGridView1.Rows.Add(New String() {i + 1, Name, UName})
        Next


    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub
End Class