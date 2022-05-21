
Public Class FrmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        UserLogin(TxtUser, Txtpsw)
        'SplashScreen1.Show()
        'SplashScreen1.BringToFront()
        'Me.Close()
        

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\dbLogin.accdb; ")
        Me.MdiParent = FrmMdiMain
        Me.BringToFront()
        FrmMdiMain.MainMenuStrip.Visible = False
        Txtpsw.Text = ""
        TxtUser.Text = ""
        TxtUser.Focus()
        Del()


    End Sub
    
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
End Class
