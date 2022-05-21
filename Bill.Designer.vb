<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Me.LblBillDesk = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.CboSelectProduct = New System.Windows.Forms.ComboBox()
        Me.CboSelectCategory = New System.Windows.Forms.ComboBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblRate = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblAvailable = New System.Windows.Forms.Label()
        Me.TxtAvailable = New System.Windows.Forms.TextBox()
        Me.LblPer = New System.Windows.Forms.Label()
        Me.ImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNew = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBillDesk
        '
        Me.LblBillDesk.AutoSize = True
        Me.LblBillDesk.BackColor = System.Drawing.Color.White
        Me.LblBillDesk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBillDesk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblBillDesk.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillDesk.Location = New System.Drawing.Point(147, 9)
        Me.LblBillDesk.Name = "LblBillDesk"
        Me.LblBillDesk.Size = New System.Drawing.Size(76, 15)
        Me.LblBillDesk.TabIndex = 184
        Me.LblBillDesk.Text = "Cash Memo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 39)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "M Bakery"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameHead, Me.RateHead, Me.QuantityHead, Me.AmountHead})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(-25, 114)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(382, 269)
        Me.DataGridView1.TabIndex = 201
        '
        'NameHead
        '
        Me.NameHead.HeaderText = "Name"
        Me.NameHead.Name = "NameHead"
        Me.NameHead.Width = 160
        '
        'RateHead
        '
        Me.RateHead.HeaderText = "Rate"
        Me.RateHead.Name = "RateHead"
        Me.RateHead.Width = 80
        '
        'QuantityHead
        '
        Me.QuantityHead.HeaderText = "Quantity"
        Me.QuantityHead.Name = "QuantityHead"
        Me.QuantityHead.Width = 50
        '
        'AmountHead
        '
        Me.AmountHead.HeaderText = "Amount"
        Me.AmountHead.Name = "AmountHead"
        Me.AmountHead.Width = 50
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(13, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(218, 380)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(139, 22)
        Me.TxtTotal.TabIndex = 203
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(14, 421)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(169, 35)
        Me.BtnPrint.TabIndex = 204
        Me.BtnPrint.Text = "&Print Bill"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'CboSelectProduct
        '
        Me.CboSelectProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectProduct.FormattingEnabled = True
        Me.CboSelectProduct.Location = New System.Drawing.Point(479, 152)
        Me.CboSelectProduct.Name = "CboSelectProduct"
        Me.CboSelectProduct.Size = New System.Drawing.Size(94, 21)
        Me.CboSelectProduct.TabIndex = 208
        Me.CboSelectProduct.TabStop = False
        '
        'CboSelectCategory
        '
        Me.CboSelectCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboSelectCategory.FormattingEnabled = True
        Me.CboSelectCategory.Items.AddRange(New Object() {"Bread", "Cake", "Cookies", "Toast", "Khari"})
        Me.CboSelectCategory.Location = New System.Drawing.Point(375, 153)
        Me.CboSelectCategory.Name = "CboSelectCategory"
        Me.CboSelectCategory.Size = New System.Drawing.Size(102, 21)
        Me.CboSelectCategory.TabIndex = 206
        Me.CboSelectCategory.TabStop = False
        '
        'TxtRate
        '
        Me.TxtRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRate.Enabled = False
        Me.TxtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRate.Location = New System.Drawing.Point(575, 154)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(34, 14)
        Me.TxtRate.TabIndex = 205
        Me.TxtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Location = New System.Drawing.Point(657, 152)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(49, 20)
        Me.TxtQuantity.TabIndex = 211
        Me.TxtQuantity.Text = "1"
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(372, 180)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 32)
        Me.BtnAdd.TabIndex = 213
        Me.BtnAdd.Text = "<<<<  &Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LblCategory
        '
        Me.LblCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.Location = New System.Drawing.Point(372, 135)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(109, 15)
        Me.LblCategory.TabIndex = 214
        Me.LblCategory.Text = "Select Category"
        Me.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(482, 134)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(92, 15)
        Me.LblName.TabIndex = 215
        Me.LblName.Text = "Select Name"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRate
        '
        Me.LblRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblRate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRate.Location = New System.Drawing.Point(573, 134)
        Me.LblRate.Name = "LblRate"
        Me.LblRate.Size = New System.Drawing.Size(76, 15)
        Me.LblRate.TabIndex = 216
        Me.LblRate.Text = "Rate"
        Me.LblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblQuantity
        '
        Me.LblQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblQuantity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(648, 134)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(58, 15)
        Me.LblQuantity.TabIndex = 217
        Me.LblQuantity.Text = "Quantity"
        Me.LblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(7, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(357, 10)
        Me.Button1.TabIndex = 218
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 114)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 287)
        Me.TextBox1.TabIndex = 220
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(356, 116)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 287)
        Me.TextBox2.TabIndex = 221
        '
        'LblAvailable
        '
        Me.LblAvailable.BackColor = System.Drawing.Color.White
        Me.LblAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblAvailable.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvailable.Location = New System.Drawing.Point(707, 177)
        Me.LblAvailable.Name = "LblAvailable"
        Me.LblAvailable.Size = New System.Drawing.Size(45, 15)
        Me.LblAvailable.TabIndex = 223
        Me.LblAvailable.Text = "Available"
        Me.LblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAvailable
        '
        Me.TxtAvailable.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAvailable.Enabled = False
        Me.TxtAvailable.Location = New System.Drawing.Point(657, 174)
        Me.TxtAvailable.Name = "TxtAvailable"
        Me.TxtAvailable.Size = New System.Drawing.Size(48, 20)
        Me.TxtAvailable.TabIndex = 222
        Me.TxtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPer
        '
        Me.LblPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPer.Location = New System.Drawing.Point(611, 152)
        Me.LblPer.Name = "LblPer"
        Me.LblPer.Size = New System.Drawing.Size(44, 17)
        Me.LblPer.TabIndex = 224
        Me.LblPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgPictureBox
        '
        Me.ImgPictureBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.ImgPictureBox.Location = New System.Drawing.Point(421, 211)
        Me.ImgPictureBox.Name = "ImgPictureBox"
        Me.ImgPictureBox.Size = New System.Drawing.Size(251, 226)
        Me.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPictureBox.TabIndex = 225
        Me.ImgPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 21)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "M.G. Road, Opp. Akola Mahanagar Palika, Akola"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(198, 421)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(169, 35)
        Me.BtnNew.TabIndex = 227
        Me.BtnNew.Text = "&New Bill"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(372, 513)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ImgPictureBox)
        Me.Controls.Add(Me.LblPer)
        Me.Controls.Add(Me.LblAvailable)
        Me.Controls.Add(Me.TxtAvailable)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.LblRate)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.CboSelectProduct)
        Me.Controls.Add(Me.CboSelectCategory)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblBillDesk)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Bill"
        Me.Text = "Bill"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblBillDesk As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents CboSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents CboSelectCategory As System.Windows.Forms.ComboBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents LblRate As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblAvailable As System.Windows.Forms.Label
    Friend WithEvents TxtAvailable As System.Windows.Forms.TextBox
    Friend WithEvents LblPer As System.Windows.Forms.Label
    Friend WithEvents NameHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
