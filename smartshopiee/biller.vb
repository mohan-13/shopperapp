Imports System.IO
Public Class biller
    Public SQL As New SQLCONTROL
    Dim subtotal As Integer = 0
    Dim up As Integer
    Dim pname As String
    Dim catg As String
    Dim id1 As Integer
    Dim stock As Integer
    Dim qnty As Integer
    Dim tot As Integer
    Dim ibyte As Byte()
    Dim grntotal As Integer


    Public Sub fillprt()
        prtidtxt.Text = id1.ToString
        prtnametxt.Text = pname
        prtstocktxt.Text = stock.ToString
        prtuptxt.Text = up.ToString
        Dim ms As New MemoryStream(ibyte)
        prtimage.Image = Image.FromStream(ms)
        ms.Close()
    End Sub
    Public Sub clearprt()
        prtidtxt.Clear()
        prtnametxt.Clear()
        prtstocktxt.Clear()
        prtuptxt.Clear()
        prtqntytxt.Clear()
        prtimage.Image = prtimage.InitialImage
    End Sub
    Public Sub LoadGrid(Query As String)

        SQL.ExecQuery(Query)
        If SQL.HasException(True) Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            id1 = r("ID")
            pname = r("ProductName")
            catg = r("Category")
            up = r("Price")
            stock = r("Quantity")
            ibyte = r("itemphoto")

            dgviewbiller.CurrentRow.Cells(1).Value = id1
            dgviewbiller.CurrentRow.Cells(0).Value = pname
            dgviewbiller.CurrentRow.Cells(2).Value = catg
            dgviewbiller.CurrentRow.Cells(3).Value = up
            fillprt()

            'dgviewbiller.Rows.Add(id, name, catg, up, qnty, tot)
            calc(tot)



        Next

    End Sub
    Private Sub tp(q As Integer)
        prtqntytxt.Text = q.ToString
        If stock > q Then
            tot = q * up
            dgviewbiller.CurrentRow.Cells(5).Value = tot
            calc(tot)
        Else
            MsgBox("Product Out of Stock...." + Environment.NewLine + "Available Stock: " + stock.ToString, MsgBoxStyle.Information)
            dgviewbiller.Rows.RemoveAt(dgviewbiller.CurrentRow.Index)
            clearprt()
            Exit Sub
        End If
    End Sub

    Private Sub calc(total As Integer)
        Dim vat As Double
        Dim disc As Double
        subtotal = subtotal + tot
        vat = subtotal * (4 / 100)
        disc = subtotal * (10 / 100)
        subtottxt.Text = subtotal
        vattxt.Text = vat
        disctxt.Text = disc
        grntotal = subtotal + vat - disc
        grndtxt.Text = grntotal.ToString


    End Sub
    Private Sub FindItem(na As String)
        SQL.AddParam("@item", "%" & na & "%")

        LoadGrid("SELECT * FROM Products WHERE ProductName like @item;")

    End Sub

    Private Sub loadcbx()
        'Refresh
        cidtxt.AutoCompleteCustomSource.Clear()

        'Querying
        SQL.ExecQuery("SELECT * from customer ORDER BY c_id ASC")

        If SQL.HasException(True) Then Exit Sub
        'ROWS MERGING
        For Each r In SQL.DBDT.Rows

            cidtxt.AutoCompleteCustomSource.Add(r("c_id").ToString)

        Next


        If SQL.HasException(True) Then Exit Sub
    End Sub



    Private Sub biller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcbx()
        subtotal = 0
        cidtxt.Select()
        Timer1.Enabled = True
        Me.WindowState = FormWindowState.Normal

        Form3.WindowState = FormWindowState.Minimized



    End Sub






    Private Sub nametxt_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dtlbl.Text = Date.Now.ToShortDateString


    End Sub



    Private Sub dgviewbiller_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgviewbiller.EditingControlShowing
        If (dgviewbiller.CurrentCell.ColumnIndex = 0) Then
            Dim autotext As TextBox = TryCast(e.Control, TextBox)
            If autotext IsNot Nothing Then
                autotext.AutoCompleteMode = AutoCompleteMode.Suggest

                autotext.AutoCompleteSource = AutoCompleteSource.CustomSource
                SQL.ExecQuery("SELECT * from Products ORDER BY ProductName ASC")
                If SQL.HasException(True) Then Exit Sub
                For Each r In SQL.DBDT.Rows
                    autotext.AutoCompleteCustomSource.Add(r("ProductName").ToString)
                Next

            End If
        Else
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = Nothing
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteMode = AutoCompleteMode.None



        End If
    End Sub

    Private Sub dgviewbiller_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgviewbiller.CellEndEdit
        If (dgviewbiller.CurrentCell.ColumnIndex = 0 AndAlso Not String.IsNullOrEmpty(dgviewbiller.CurrentCell.ToString)) Then
            FindItem(dgviewbiller.CurrentCell.Value.ToString)
            dgviewbiller.CurrentCell = dgviewbiller.CurrentRow.Cells(4)
            SendKeys.Send("{up}")

        ElseIf (dgviewbiller.CurrentCell.ColumnIndex = 4 AndAlso Not String.IsNullOrEmpty(dgviewbiller.CurrentCell.ToString)) Then
            tp(dgviewbiller.CurrentCell.Value)
            dgviewbiller.CurrentCell = dgviewbiller.CurrentRow.Cells(5)
            SendKeys.Send("{up}")
        End If
    End Sub

    Private Sub dgviewbiller_KeyDown(sender As Object, e As KeyEventArgs) Handles dgviewbiller.KeyDown

        If e.KeyCode = Keys.Enter Then
            dgviewbiller.CurrentCell = dgviewbiller.CurrentRow.Cells(0)
        End If

    End Sub

    Private Sub cidtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cidtxt.KeyDown
        If e.KeyCode = Keys.Enter Then


            SQL.AddParam("@custid", cidtxt.Text)
            SQL.ExecQuery("SELECT * from customer where c_id=@custid")
            If SQL.HasException(True) Then Exit Sub
            If SQL.DBDT.Rows.Count = 1 Then
                For Each r In SQL.DBDT.Rows
                    caddress.Text = r("c_address")
                    cnametxt.Text = r("c_name")
                    dgviewbiller.Select()


                Next
            ElseIf SQL.DBDT.Rows.Count = 0 Then
                cnametxt.ReadOnly = False
                caddress.ReadOnly = False
                SendKeys.Send("{TAB}")

            End If
        End If
    End Sub

    Private Sub cnametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cnametxt.KeyDown
        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub caddress_KeyDown(sender As Object, e As KeyEventArgs) Handles caddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            SQL.AddParam("@custadd", caddress.Text.ToUpper)
            SQL.AddParam("@custid", cidtxt.Text)
            SQL.AddParam("@custname", cnametxt.Text.ToUpper)
            SQL.ExecQuery("INSERT INTO CUSTOMER VALUES(@custid,@custname,@custadd,0,0);")

            If SQL.HasException(True) Then Exit Sub
            MsgBox("Customer Added..", MsgBoxStyle.OkOnly)
            SendKeys.Send("{TAB}")
            cnametxt.Text = cnametxt.Text.ToUpper()
            caddress.Text = caddress.Text.ToUpper()
            cnametxt.ReadOnly = True
            caddress.ReadOnly = True
        End If
    End Sub

    Private Sub cnfrmbtn_Click(sender As Object, e As EventArgs) Handles prntbtn.Click
        MsgBox("ARAVIND")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles amtrcvtxt.TextChanged
        If Not String.IsNullOrWhiteSpace(amtrcvtxt.Text) Then
            amtchgtxt.Text = (amtrcvtxt.Text - grntotal).ToString
        End If
    End Sub
End Class