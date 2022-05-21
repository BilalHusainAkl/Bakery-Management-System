<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockIn
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CboCategory = New System.Windows.Forms.ComboBox()
        Me.CboPer = New System.Windows.Forms.ComboBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.CboSelectCategory = New System.Windows.Forms.ComboBox()
        Me.CboSelectProduct = New System.Windows.Forms.ComboBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtNewQuantity = New System.Windows.Forms.TextBox()
        Me.ImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Label1 = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        MileageLabel = New System.Windows.Forms.Label()
        FuelTypeLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label1.Location = New System.Drawing.Point(121, 157)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 13)
        Label1.TabIndex = 183
        Label1.Text = "Category"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelLabel
        '
        ModelLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ModelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ModelLabel.Location = New System.Drawing.Point(167, 183)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 184
        ModelLabel.Text = "Name"
        ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MileageLabel
        '
        MileageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        MileageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        MileageLabel.Location = New System.Drawing.Point(135, 209)
        MileageLabel.Name = "MileageLabel"
        MileageLabel.Size = New System.Drawing.Size(71, 13)
        MileageLabel.TabIndex = 185
        MileageLabel.Text = "Rate"
        MileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FuelTypeLabel
        '
        FuelTypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        FuelTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        FuelTypeLabel.Location = New System.Drawing.Point(149, 235)
        FuelTypeLabel.Name = "FuelTypeLabel"
        FuelTypeLabel.Size = New System.Drawing.Size(57, 13)
        FuelTypeLabel.TabIndex = 186
        FuelTypeLabel.Text = "Per"
        FuelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label3.Location = New System.Drawing.Point(212, 98)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(104, 18)
        Label3.TabIndex = 188
        Label3.Text = "Select Category"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label4.Location = New System.Drawing.Point(322, 98)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(134, 18)
        Label4.TabIndex = 190
        Label4.Text = "Select Product Name"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label5.Location = New System.Drawing.Point(97, 261)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(107, 13)
        Label5.TabIndex = 192
        Label5.Text = "Old Stock (Quantity)"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label6.Location = New System.Drawing.Point(87, 287)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(115, 13)
        Label6.TabIndex = 196
        Label6.Text = "New Stok Recieved"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 47)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "New Stock Entry"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(212, 374)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(128, 23)
        Me.BtnClose.TabIndex = 179
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CboCategory
        '
        Me.CboCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboCategory.Enabled = False
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboCategory.Location = New System.Drawing.Point(212, 153)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(153, 21)
        Me.CboCategory.TabIndex = 173
        Me.CboCategory.TabStop = False
        '
        'CboPer
        '
        Me.CboPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboPer.Enabled = False
        Me.CboPer.FormattingEnabled = True
        Me.CboPer.Items.AddRange(New Object() {"Kg", "Piece"})
        Me.CboPer.Location = New System.Drawing.Point(212, 231)
        Me.CboPer.Name = "CboPer"
        Me.CboPer.Size = New System.Drawing.Size(153, 21)
        Me.CboPer.TabIndex = 176
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(212, 345)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(132, 23)
        Me.BtnClear.TabIndex = 180
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(212, 315)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(132, 23)
        Me.BtnUpdate.TabIndex = 178
        Me.BtnUpdate.Text = "Add && Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.Enabled = False
        Me.TxtName.Location = New System.Drawing.Point(212, 180)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(153, 20)
        Me.TxtName.TabIndex = 174
        '
        'TxtRate
        '
        Me.TxtRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRate.Enabled = False
        Me.TxtRate.Location = New System.Drawing.Point(212, 206)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(153, 20)
        Me.TxtRate.TabIndex = 175
        '
        'CboSelectCategory
        '
        Me.CboSelectCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectCategory.FormattingEnabled = True
        Me.CboSelectCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboSelectCategory.Location = New System.Drawing.Point(212, 119)
        Me.CboSelectCategory.Name = "CboSelectCategory"
        Me.CboSelectCategory.Size = New System.Drawing.Size(104, 21)
        Me.CboSelectCategory.TabIndex = 187
        Me.CboSelectCategory.TabStop = False
        '
        'CboSelectProduct
        '
        Me.CboSelectProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectProduct.FormattingEnabled = True
        Me.CboSelectProduct.Location = New System.Drawing.Point(322, 119)
        Me.CboSelectProduct.Name = "CboSelectProduct"
        Me.CboSelectProduct.Size = New System.Drawing.Size(134, 21)
        Me.CboSelectProduct.TabIndex = 189
        Me.CboSelectProduct.TabStop = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQuantity.Enabled = False
        Me.TxtQuantity.Location = New System.Drawing.Point(212, 258)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(153, 20)
        Me.TxtQuantity.TabIndex = 191
        '
        'TxtNewQuantity
        '
        Me.TxtNewQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtNewQuantity.Location = New System.Drawing.Point(212, 284)
        Me.TxtNewQuantity.Name = "TxtNewQuantity"
        Me.TxtNewQuantity.Size = New System.Drawing.Size(153, 20)
        Me.TxtNewQuantity.TabIndex = 195
        '
        'ImgPictureBox
        '
        Me.ImgPictureBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.ImgPictureBox.Location = New System.Drawing.Point(371, 153)
        Me.ImgPictureBox.Name = "ImgPictureBox"
        Me.ImgPictureBox.Size = New System.Drawing.Size(228, 214)
        Me.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPictureBox.TabIndex = 182
        Me.ImgPictureBox.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(745, 494)
        Me.ShapeContainer1.TabIndex = 197
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(81, 87)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(582, 322)
        '
        'FrmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 494)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TxtNewQuantity)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.CboSelectProduct)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.CboSelectCategory)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.CboCategory)
        Me.Controls.Add(Me.CboPer)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(MileageLabel)
        Me.Controls.Add(FuelTypeLabel)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.ImgPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmStockIn"
        Me.Text = "Form1"
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboPer As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents ImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CboSelectCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewQuantity As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
