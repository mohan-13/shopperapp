Imports System.ComponentModel

Public Class Form3
    Private Sub hmecloser()
        pnlhome.Visible = False
    End Sub



    Private Sub promngcloser()
        productlister.Close()
        additem.Close()
        updateitem.Close()
        delete.Close()

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlhome.Visible = True
        Timer1.Enabled = True
    End Sub



    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        pnlbutton.Height = btnhome.Height
        pnlbutton.Top = btnhome.Top
        pnlhome.Visible = True
        pnlproduct.Visible = False
        promngcloser()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        pnlbutton.Height = btnsearch.Height
        pnlbutton.Top = btnsearch.Top
        productlister.Show()
        hmecloser()
        pnlproduct.Visible = False


    End Sub

    Private Sub btnbill_Click(sender As Object, e As EventArgs) Handles btnbill.Click
        pnlbutton.Height = btnbill.Height
        pnlbutton.Top = btnbill.Top
        hmecloser()

        promngcloser()
    End Sub

    Private Sub btnmng_Click(sender As Object, e As EventArgs) Handles btnmng.Click
        pnlbutton.Height = btnmng.Height
        pnlbutton.Top = btnmng.Top
        pnlproduct.Visible = True
        pnlhome.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        additem.Show()

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        additem.Show()
    End Sub

    Private Sub pricebtn_Click(sender As Object, e As EventArgs) Handles pricebtn.Click
        updateitem.Show()

    End Sub

    Private Sub stockbtn_Click(sender As Object, e As EventArgs) Handles stockbtn.Click
        updateitem.Show()

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        delete.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timelabel.Text = Date.Now.ToLongTimeString
        datelabl.Text = Date.Now.ToLongDateString

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class