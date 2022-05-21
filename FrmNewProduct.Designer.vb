<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim MileageLabel As System.Windows.Forms.Label
        Dim FuelTypeLabel As System.Windows.Forms.Label
        Dim ImgLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.CboCategory = New System.Windows.Forms.ComboBox()
        Me.CboPer = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.ImgPictureBox = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        MileageLabel = New System.Windows.Forms.Label()
        FuelTypeLabel = New System.Windows.Forms.Label()
        ImgLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Label1.Location = New System.Drawing.Point(134, 82)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 13)
        Label1.TabIndex = 154
        Label1.Text = "Category"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelLabel
        '
        ModelLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        ModelLabel.Location = New System.Drawing.Point(180, 108)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 155
        ModelLabel.Text = "Name"
        ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MileageLabel
        '
        MileageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        MileageLabel.Location = New System.Drawing.Point(148, 134)
        MileageLabel.Name = "MileageLabel"
        MileageLabel.Size = New System.Drawing.Size(71, 13)
        MileageLabel.TabIndex = 156
        MileageLabel.Text = "Rate"
        MileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FuelTypeLabel
        '
        FuelTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        FuelTypeLabel.Location = New System.Drawing.Point(162, 160)
        FuelTypeLabel.Name = "FuelTypeLabel"
        FuelTypeLabel.Size = New System.Drawing.Size(57, 13)
        FuelTypeLabel.TabIndex = 157
        FuelTypeLabel.Text = "Per"
        FuelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImgLabel
        '
        ImgLabel.AutoSize = True
        ImgLabel.Location = New System.Drawing.Point(381, 307)
        ImgLabel.Name = "ImgLabel"
        ImgLabel.Size = New System.Drawing.Size(84, 13)
        ImgLabel.TabIndex = 150
        ImgLabel.Text = "Add Image Here"
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label5.Location = New System.Drawing.Point(118, 186)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(100, 13)
        Label5.TabIndex = 194
        Label5.Text = "Quantity Recieved"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboCategory
        '
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboCategory.Location = New System.Drawing.Point(225, 78)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(153, 21)
        Me.CboCategory.TabIndex = 0
        Me.CboCategory.TabStop = False
        '
        'CboPer
        '
        Me.CboPer.FormattingEnabled = True
        Me.CboPer.Items.AddRange(New Object() {"Kg", "Piece"})
        Me.CboPer.Location = New System.Drawing.Point(225, 156)
        Me.CboPer.Name = "CboPer"
        Me.CboPer.Size = New System.Drawing.Size(153, 21)
        Me.CboPer.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(95, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 47)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "New Product Entry"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(225, 263)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(132, 23)
        Me.CmdClear.TabIndex = 8
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(225, 205)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(132, 23)
        Me.CmdSave.TabIndex = 6
        Me.CmdSave.Text = "Save"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(225, 105)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(153, 20)
        Me.TxtName.TabIndex = 1
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(225, 131)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(153, 20)
        Me.TxtRate.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(225, 234)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(128, 23)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(746, 555)
        Me.ShapeContainer1.TabIndex = 172
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(93, 66)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(582, 292)
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(225, 183)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(153, 20)
        Me.TxtQuantity.TabIndex = 4
        Me.TxtQuantity.Text = "0"
        '
        'ImgPictureBox
        '
        Me.ImgPictureBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.ImgPictureBox.Location = New System.Drawing.Point(384, 78)
        Me.ImgPictureBox.Name = "ImgPictureBox"
        Me.ImgPictureBox.Size = New System.Drawing.Size(253, 218)
        Me.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPictureBox.TabIndex = 151
        Me.ImgPictureBox.TabStop = False
        '
        'FrmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 555)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.CboCategory)
        Me.Controls.Add(Me.CboPer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(MileageLabel)
        Me.Controls.Add(FuelTypeLabel)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(ImgLabel)
        Me.Controls.Add(Me.ImgPictureBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboPer As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents ImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
End Class
