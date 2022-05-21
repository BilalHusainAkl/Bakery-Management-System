<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditProduct
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
        Dim ImgLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim MileageLabel As System.Windows.Forms.Label
        Dim FuelTypeLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.CboSelectProduct = New System.Windows.Forms.ComboBox()
        Me.CboSelectCategory = New System.Windows.Forms.ComboBox()
        Me.CboCategory = New System.Windows.Forms.ComboBox()
        Me.CboPer = New System.Windows.Forms.ComboBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.ImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        ImgLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        MileageLabel = New System.Windows.Forms.Label()
        FuelTypeLabel = New System.Windows.Forms.Label()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgLabel
        '
        ImgLabel.AutoSize = True
        ImgLabel.Location = New System.Drawing.Point(379, 386)
        ImgLabel.Name = "ImgLabel"
        ImgLabel.Size = New System.Drawing.Size(84, 13)
        ImgLabel.TabIndex = 204
        ImgLabel.Text = "Add Image Here"
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label5.Location = New System.Drawing.Point(97, 269)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(107, 13)
        Label5.TabIndex = 223
        Label5.Text = "Stock (Quantity)"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label4.Location = New System.Drawing.Point(322, 106)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(134, 18)
        Label4.TabIndex = 221
        Label4.Text = "Select Product Name"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label3.Location = New System.Drawing.Point(212, 106)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(104, 18)
        Label3.TabIndex = 219
        Label3.Text = "Select Category"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label1.Location = New System.Drawing.Point(121, 165)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 13)
        Label1.TabIndex = 214
        Label1.Text = "Category"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelLabel
        '
        ModelLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ModelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ModelLabel.Location = New System.Drawing.Point(167, 191)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 215
        ModelLabel.Text = "Name"
        ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MileageLabel
        '
        MileageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        MileageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        MileageLabel.Location = New System.Drawing.Point(135, 217)
        MileageLabel.Name = "MileageLabel"
        MileageLabel.Size = New System.Drawing.Size(71, 13)
        MileageLabel.TabIndex = 216
        MileageLabel.Text = "Rate"
        MileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FuelTypeLabel
        '
        FuelTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        FuelTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        FuelTypeLabel.Location = New System.Drawing.Point(149, 243)
        FuelTypeLabel.Name = "FuelTypeLabel"
        FuelTypeLabel.Size = New System.Drawing.Size(57, 13)
        FuelTypeLabel.TabIndex = 217
        FuelTypeLabel.Text = "Per"
        FuelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 200
        Me.Button1.Text = "Add Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(199, 329)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(128, 23)
        Me.BtnClose.TabIndex = 202
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(199, 358)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(132, 23)
        Me.CmdClear.TabIndex = 203
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(199, 300)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(132, 23)
        Me.BtnUpdate.TabIndex = 201
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQuantity.Location = New System.Drawing.Point(212, 266)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(153, 20)
        Me.TxtQuantity.TabIndex = 222
        '
        'CboSelectProduct
        '
        Me.CboSelectProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectProduct.FormattingEnabled = True
        Me.CboSelectProduct.Location = New System.Drawing.Point(322, 127)
        Me.CboSelectProduct.Name = "CboSelectProduct"
        Me.CboSelectProduct.Size = New System.Drawing.Size(134, 21)
        Me.CboSelectProduct.TabIndex = 220
        Me.CboSelectProduct.TabStop = False
        '
        'CboSelectCategory
        '
        Me.CboSelectCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectCategory.FormattingEnabled = True
        Me.CboSelectCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboSelectCategory.Location = New System.Drawing.Point(212, 127)
        Me.CboSelectCategory.Name = "CboSelectCategory"
        Me.CboSelectCategory.Size = New System.Drawing.Size(104, 21)
        Me.CboSelectCategory.TabIndex = 218
        Me.CboSelectCategory.TabStop = False
        '
        'CboCategory
        '
        Me.CboCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboCategory.Location = New System.Drawing.Point(212, 161)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(153, 21)
        Me.CboCategory.TabIndex = 206
        Me.CboCategory.TabStop = False
        '
        'CboPer
        '
        Me.CboPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboPer.FormattingEnabled = True
        Me.CboPer.Items.AddRange(New Object() {"Kg", "Piece"})
        Me.CboPer.Location = New System.Drawing.Point(212, 239)
        Me.CboPer.Name = "CboPer"
        Me.CboPer.Size = New System.Drawing.Size(153, 21)
        Me.CboPer.TabIndex = 209
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(212, 188)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(153, 20)
        Me.TxtName.TabIndex = 207
        '
        'TxtRate
        '
        Me.TxtRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRate.Location = New System.Drawing.Point(212, 214)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(153, 20)
        Me.TxtRate.TabIndex = 208
        '
        'ImgPictureBox
        '
        Me.ImgPictureBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.ImgPictureBox.Location = New System.Drawing.Point(371, 161)
        Me.ImgPictureBox.Name = "ImgPictureBox"
        Me.ImgPictureBox.Size = New System.Drawing.Size(228, 214)
        Me.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPictureBox.TabIndex = 213
        Me.ImgPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 47)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Edit Product Detail"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 449)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.CboSelectProduct)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.CboSelectCategory)
        Me.Controls.Add(Me.CboCategory)
        Me.Controls.Add(Me.CboPer)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(MileageLabel)
        Me.Controls.Add(FuelTypeLabel)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.ImgPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(ImgLabel)
        Me.Name = "FrmEditProduct"
        Me.Text = "Form1"
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents CboSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents CboSelectCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboPer As System.Windows.Forms.ComboBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents ImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
