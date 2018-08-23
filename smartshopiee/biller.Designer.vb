<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class biller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(biller))
        Me.dgviewbiller = New System.Windows.Forms.DataGridView()
        Me.Productnme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subtottxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vattxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.disctxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grndtxt = New System.Windows.Forms.TextBox()
        Me.prntbtn = New System.Windows.Forms.Button()
        Me.dtlbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.cnametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.caddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cidtxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Billerinfo = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.emppos = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.empname = New System.Windows.Forms.Label()
        Me.empid = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.amtchgtxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.amtrcvtxt = New System.Windows.Forms.TextBox()
        Me.cnfrmbtn = New System.Windows.Forms.Button()
        Me.rmvbtn = New System.Windows.Forms.Button()
        Me.cnclbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.prtuptxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.prtstocktxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.prtimage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prtnametxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.prtidtxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prtqntytxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.dgviewbiller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Billerinfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.prtimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgviewbiller
        '
        Me.dgviewbiller.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewbiller.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgviewbiller.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewbiller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewbiller.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgviewbiller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgviewbiller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewbiller.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgviewbiller.ColumnHeadersHeight = 55
        Me.dgviewbiller.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Productnme, Me.ID, Me.Category, Me.UnitPrice, Me.Quantity, Me.Total})
        Me.dgviewbiller.Location = New System.Drawing.Point(37, 542)
        Me.dgviewbiller.Name = "dgviewbiller"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewbiller.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewbiller.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgviewbiller.RowTemplate.Height = 24
        Me.dgviewbiller.Size = New System.Drawing.Size(1123, 432)
        Me.dgviewbiller.TabIndex = 4
        '
        'Productnme
        '
        Me.Productnme.HeaderText = "Product Name"
        Me.Productnme.Name = "Productnme"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sub Total: "
        '
        'subtottxt
        '
        Me.subtottxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subtottxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtottxt.Location = New System.Drawing.Point(35, 339)
        Me.subtottxt.Name = "subtottxt"
        Me.subtottxt.ReadOnly = True
        Me.subtottxt.Size = New System.Drawing.Size(183, 35)
        Me.subtottxt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 472)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "VAT @ 4% : "
        '
        'vattxt
        '
        Me.vattxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vattxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vattxt.Location = New System.Drawing.Point(35, 501)
        Me.vattxt.Name = "vattxt"
        Me.vattxt.ReadOnly = True
        Me.vattxt.Size = New System.Drawing.Size(183, 35)
        Me.vattxt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Discount : -"
        '
        'disctxt
        '
        Me.disctxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.disctxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disctxt.Location = New System.Drawing.Point(35, 412)
        Me.disctxt.Name = "disctxt"
        Me.disctxt.Size = New System.Drawing.Size(183, 35)
        Me.disctxt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Grand Total: "
        '
        'grndtxt
        '
        Me.grndtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grndtxt.BackColor = System.Drawing.Color.Blue
        Me.grndtxt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grndtxt.ForeColor = System.Drawing.Color.White
        Me.grndtxt.Location = New System.Drawing.Point(35, 591)
        Me.grndtxt.Name = "grndtxt"
        Me.grndtxt.ReadOnly = True
        Me.grndtxt.Size = New System.Drawing.Size(183, 49)
        Me.grndtxt.TabIndex = 14
        '
        'prntbtn
        '
        Me.prntbtn.BackColor = System.Drawing.Color.YellowGreen
        Me.prntbtn.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prntbtn.ForeColor = System.Drawing.Color.Black
        Me.prntbtn.Image = CType(resources.GetObject("prntbtn.Image"), System.Drawing.Image)
        Me.prntbtn.Location = New System.Drawing.Point(31, 873)
        Me.prntbtn.Name = "prntbtn"
        Me.prntbtn.Size = New System.Drawing.Size(223, 74)
        Me.prntbtn.TabIndex = 15
        Me.prntbtn.Text = "Print Bill"
        Me.prntbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.prntbtn.UseVisualStyleBackColor = False
        '
        'dtlbl
        '
        Me.dtlbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtlbl.AutoSize = True
        Me.dtlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtlbl.Location = New System.Drawing.Point(141, 32)
        Me.dtlbl.Name = "dtlbl"
        Me.dtlbl.Size = New System.Drawing.Size(53, 19)
        Me.dtlbl.TabIndex = 20
        Me.dtlbl.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(132, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Label10"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(15, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(120, 17)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Current Date:"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.HideSelection = False
        Me.TextBox5.Location = New System.Drawing.Point(6, 60)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(120, 17)
        Me.TextBox5.TabIndex = 25
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "Invoice No:"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cnametxt
        '
        Me.cnametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cnametxt.Location = New System.Drawing.Point(139, 55)
        Me.cnametxt.Name = "cnametxt"
        Me.cnametxt.ReadOnly = True
        Me.cnametxt.Size = New System.Drawing.Size(298, 22)
        Me.cnametxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cust.Name:"
        '
        'caddress
        '
        Me.caddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.caddress.Location = New System.Drawing.Point(138, 97)
        Me.caddress.Multiline = True
        Me.caddress.Name = "caddress"
        Me.caddress.ReadOnly = True
        Me.caddress.Size = New System.Drawing.Size(299, 37)
        Me.caddress.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Address:"
        '
        'cidtxt
        '
        Me.cidtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cidtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cidtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cidtxt.Location = New System.Drawing.Point(139, 18)
        Me.cidtxt.Name = "cidtxt"
        Me.cidtxt.Size = New System.Drawing.Size(298, 22)
        Me.cidtxt.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cust.ID:"
        '
        'Timer1
        '
        '
        'Billerinfo
        '
        Me.Billerinfo.BackColor = System.Drawing.Color.White
        Me.Billerinfo.Controls.Add(Me.TextBox3)
        Me.Billerinfo.Controls.Add(Me.TextBox1)
        Me.Billerinfo.Controls.Add(Me.emppos)
        Me.Billerinfo.Controls.Add(Me.TextBox2)
        Me.Billerinfo.Controls.Add(Me.empname)
        Me.Billerinfo.Controls.Add(Me.empid)
        Me.Billerinfo.Controls.Add(Me.TextBox4)
        Me.Billerinfo.Controls.Add(Me.dtlbl)
        Me.Billerinfo.Controls.Add(Me.Label10)
        Me.Billerinfo.Controls.Add(Me.TextBox5)
        Me.Billerinfo.Location = New System.Drawing.Point(26, 85)
        Me.Billerinfo.Name = "Billerinfo"
        Me.Billerinfo.Size = New System.Drawing.Size(679, 137)
        Me.Billerinfo.TabIndex = 28
        Me.Billerinfo.TabStop = False
        Me.Billerinfo.Text = "Biller Info : "
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(397, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(260, 22)
        Me.TextBox3.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(397, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(260, 22)
        Me.TextBox1.TabIndex = 8
        '
        'emppos
        '
        Me.emppos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emppos.AutoSize = True
        Me.emppos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emppos.Location = New System.Drawing.Point(235, 100)
        Me.emppos.Name = "emppos"
        Me.emppos.Size = New System.Drawing.Size(157, 20)
        Me.emppos.TabIndex = 28
        Me.emppos.Text = "Employee Position: "
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.Location = New System.Drawing.Point(397, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(260, 22)
        Me.TextBox2.TabIndex = 7
        '
        'empname
        '
        Me.empname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empname.AutoSize = True
        Me.empname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empname.Location = New System.Drawing.Point(235, 62)
        Me.empname.Name = "empname"
        Me.empname.Size = New System.Drawing.Size(136, 20)
        Me.empname.TabIndex = 27
        Me.empname.Text = "Employee Name:"
        '
        'empid
        '
        Me.empid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empid.AutoSize = True
        Me.empid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.Location = New System.Drawing.Point(235, 27)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(114, 20)
        Me.empid.TabIndex = 26
        Me.empid.Text = "Employee ID: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cnametxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cidtxt)
        Me.GroupBox1.Controls.Add(Me.caddress)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(711, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 137)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1455, 73)
        Me.Panel1.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Courier New", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(632, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(282, 49)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "SALES BILL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.amtchgtxt)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.amtrcvtxt)
        Me.Panel2.Controls.Add(Me.cnfrmbtn)
        Me.Panel2.Controls.Add(Me.rmvbtn)
        Me.Panel2.Controls.Add(Me.cnclbtn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.subtottxt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.disctxt)
        Me.Panel2.Controls.Add(Me.prntbtn)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.grndtxt)
        Me.Panel2.Controls.Add(Me.vattxt)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1189, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 964)
        Me.Panel2.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(27, 740)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(199, 19)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Change Returned : -"
        '
        'amtchgtxt
        '
        Me.amtchgtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.amtchgtxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtchgtxt.Location = New System.Drawing.Point(35, 768)
        Me.amtchgtxt.Name = "amtchgtxt"
        Me.amtchgtxt.ReadOnly = True
        Me.amtchgtxt.Size = New System.Drawing.Size(183, 35)
        Me.amtchgtxt.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 660)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 19)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Amount Received : -"
        '
        'amtrcvtxt
        '
        Me.amtrcvtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.amtrcvtxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtrcvtxt.Location = New System.Drawing.Point(39, 688)
        Me.amtrcvtxt.Name = "amtrcvtxt"
        Me.amtrcvtxt.Size = New System.Drawing.Size(183, 35)
        Me.amtrcvtxt.TabIndex = 20
        '
        'cnfrmbtn
        '
        Me.cnfrmbtn.BackColor = System.Drawing.Color.DarkOrange
        Me.cnfrmbtn.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnfrmbtn.ForeColor = System.Drawing.Color.White
        Me.cnfrmbtn.Image = CType(resources.GetObject("cnfrmbtn.Image"), System.Drawing.Image)
        Me.cnfrmbtn.Location = New System.Drawing.Point(31, 188)
        Me.cnfrmbtn.Name = "cnfrmbtn"
        Me.cnfrmbtn.Size = New System.Drawing.Size(223, 83)
        Me.cnfrmbtn.TabIndex = 18
        Me.cnfrmbtn.Text = "Confirm Bill"
        Me.cnfrmbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cnfrmbtn.UseVisualStyleBackColor = False
        '
        'rmvbtn
        '
        Me.rmvbtn.BackColor = System.Drawing.Color.HotPink
        Me.rmvbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rmvbtn.ForeColor = System.Drawing.Color.White
        Me.rmvbtn.Image = CType(resources.GetObject("rmvbtn.Image"), System.Drawing.Image)
        Me.rmvbtn.Location = New System.Drawing.Point(31, 100)
        Me.rmvbtn.Name = "rmvbtn"
        Me.rmvbtn.Size = New System.Drawing.Size(223, 83)
        Me.rmvbtn.TabIndex = 17
        Me.rmvbtn.Text = "Remove Item"
        Me.rmvbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rmvbtn.UseVisualStyleBackColor = False
        '
        'cnclbtn
        '
        Me.cnclbtn.BackColor = System.Drawing.Color.Purple
        Me.cnclbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnclbtn.ForeColor = System.Drawing.Color.White
        Me.cnclbtn.Image = CType(resources.GetObject("cnclbtn.Image"), System.Drawing.Image)
        Me.cnclbtn.Location = New System.Drawing.Point(31, 12)
        Me.cnclbtn.Name = "cnclbtn"
        Me.cnclbtn.Size = New System.Drawing.Size(223, 83)
        Me.cnclbtn.TabIndex = 16
        Me.cnclbtn.Text = "CANCEL BILL"
        Me.cnclbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cnclbtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.prtuptxt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.prtstocktxt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.prtimage)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.prtnametxt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.prtidtxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1128, 214)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info : "
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(914, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 23)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Quantity : "
        '
        'prtuptxt
        '
        Me.prtuptxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prtuptxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.prtuptxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.prtuptxt.Location = New System.Drawing.Point(1026, 54)
        Me.prtuptxt.Name = "prtuptxt"
        Me.prtuptxt.ReadOnly = True
        Me.prtuptxt.Size = New System.Drawing.Size(86, 22)
        Me.prtuptxt.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(914, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 23)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Unit Price : "
        '
        'prtstocktxt
        '
        Me.prtstocktxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prtstocktxt.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prtstocktxt.Location = New System.Drawing.Point(754, 143)
        Me.prtstocktxt.Name = "prtstocktxt"
        Me.prtstocktxt.ReadOnly = True
        Me.prtstocktxt.Size = New System.Drawing.Size(143, 45)
        Me.prtstocktxt.TabIndex = 33
        Me.prtstocktxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label12.Location = New System.Drawing.Point(779, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "STOCKED"
        '
        'prtimage
        '
        Me.prtimage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prtimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prtimage.Image = CType(resources.GetObject("prtimage.Image"), System.Drawing.Image)
        Me.prtimage.InitialImage = CType(resources.GetObject("prtimage.InitialImage"), System.Drawing.Image)
        Me.prtimage.Location = New System.Drawing.Point(495, 57)
        Me.prtimage.Name = "prtimage"
        Me.prtimage.Size = New System.Drawing.Size(178, 134)
        Me.prtimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prtimage.TabIndex = 32
        Me.prtimage.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(550, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "IMAGE"
        '
        'prtnametxt
        '
        Me.prtnametxt.Location = New System.Drawing.Point(195, 123)
        Me.prtnametxt.Name = "prtnametxt"
        Me.prtnametxt.ReadOnly = True
        Me.prtnametxt.Size = New System.Drawing.Size(260, 22)
        Me.prtnametxt.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 23)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "PRODUCT ID: "
        '
        'prtidtxt
        '
        Me.prtidtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.prtidtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.prtidtxt.Location = New System.Drawing.Point(184, 53)
        Me.prtidtxt.Name = "prtidtxt"
        Me.prtidtxt.ReadOnly = True
        Me.prtidtxt.Size = New System.Drawing.Size(260, 22)
        Me.prtidtxt.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "PRODUCT NAME:"
        '
        'prtqntytxt
        '
        Me.prtqntytxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prtqntytxt.Location = New System.Drawing.Point(1058, 392)
        Me.prtqntytxt.Name = "prtqntytxt"
        Me.prtqntytxt.ReadOnly = True
        Me.prtqntytxt.Size = New System.Drawing.Size(86, 22)
        Me.prtqntytxt.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Location = New System.Drawing.Point(26, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 6)
        Me.Panel3.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(26, 520)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1128, 6)
        Me.Panel4.TabIndex = 39
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 993)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1189, 44)
        Me.Panel5.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label18.Location = New System.Drawing.Point(856, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 17)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Mohankumar T-9842270418"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label19.Location = New System.Drawing.Point(1050, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 17)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "All Rights Reserved"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label20.Location = New System.Drawing.Point(498, -18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 17)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Copyright @2018"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label21.Location = New System.Drawing.Point(12, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 17)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Copyright @2018"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Script", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(499, -2)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(333, 46)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "HAPPY SHOPPING!!!"
        '
        'biller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1455, 1037)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.prtqntytxt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Billerinfo)
        Me.Controls.Add(Me.dgviewbiller)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "biller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgviewbiller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Billerinfo.ResumeLayout(False)
        Me.Billerinfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.prtimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgviewbiller As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents subtottxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents vattxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents disctxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grndtxt As TextBox
    Friend WithEvents prntbtn As Button
    Friend WithEvents dtlbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents caddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cidtxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Productnme As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cnametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Billerinfo As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents emppos As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents empname As Label
    Friend WithEvents empid As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents prtuptxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents prtstocktxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents prtimage As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents prtnametxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents prtidtxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents prtqntytxt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cnfrmbtn As Button
    Friend WithEvents rmvbtn As Button
    Friend WithEvents cnclbtn As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents amtchgtxt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents amtrcvtxt As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
End Class
