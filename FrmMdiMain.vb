Imports System.Windows.Forms

Public Class FrmMdiMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub



    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '   Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub


    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub StockEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockEntryToolStripMenuItem.Click

        FrmLoad(FrmStockIn)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub FrmMdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmLogin.MdiParent = Me

        FrmNewUser.MdiParent = Me
        FrmUserList.MdiParent = Me
        FrmEditUser.MdiParent = Me

        FrmStockIn.MdiParent = Me
        FrmStockList.MdiParent = Me

        FrmNewProduct.MdiParent = Me
        FrmEditProduct.MdiParent = Me
        FrmDeleteProduct.MdiParent = Me

        Bill.MdiParent = Me

        'If SplashWindow.Enabled = True Then
        'SplashWindow.Close()
        'End If


        FrmLogin.Show()






    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        FrmLoad(FrmNewUser)
    End Sub

    Private Sub NewProductToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProductToolStripMenuItem1.Click

        FrmLoad(FrmNewProduct)
    End Sub

    Private Sub EditProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProductToolStripMenuItem.Click
        FrmLoad(FrmEditProduct)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click


        'FrmEditUser.Show()
        'FrmEditUser.Enabled = True
        'FrmEditUser.BringToFront()

        FrmLoad(FrmEditUser)

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        FrmLoad(FrmUserList)
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        FrmLoad(FrmStockList)
    End Sub

    Private Sub NewProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProductToolStripMenuItem.Click

        FrmLogin.Close()
        FrmLoad(FrmLogin)
        FrmLogin.WindowState = 0

    End Sub


    Private Sub DeleteProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteProductToolStripMenuItem.Click
        FrmLoad(FrmDeleteProduct)
    End Sub

    Private Sub BillDeskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillDeskToolStripMenuItem.Click
        FrmLoad(Bill)

    End Sub


    Private Sub AboutWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutWindowToolStripMenuItem.Click
        SplashWindow.Show()

    End Sub

    
End Class
