Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class SQLCONTROL
    Public mysqlcon As New MySqlConnection("server=db4free.net;Port=3306;user id=******;password=****** ;database=myshop;old guids=true")

    'Public SQLcon As New SqlConnection("Server=MOHAN-PC\MOHANSQL;Database=smartshop;Integrated Security=True")
    'Public Function Status() As Boolean
    'Try
    'SQLcon.Open()

    'SQLcon.Close()

    'Return True
    'Catch ex As Exception
    'MessageBox.Show(ex.Message)
    'End Try
    'Return False
    'End Function
    Private DBcmd As MySqlCommand
    'DB DATA
    Public DBDT As DataTable
    Public DBAD As MySqlDataAdapter
    'Query Params
    Public Params As New List(Of MySqlParameter)
    'Query Statistics
    Public RecordCount As Integer
    Public Exception As String
    Public Sub New()

    End Sub

    'Execut Query Sub
    Public Sub ExecQuery(Query As String)
        'Reset
        RecordCount = 0
        Exception = ""
        Try
            mysqlcon.Open()

            'DB Command
            DBcmd = New MySqlCommand(Query, mysqlcon)

            'Load Params into SqlCommand
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))
            'Clear Param list
            Params.Clear()
            'Execute Query and store
            DBDT = New DataTable
            DBAD = New MySqlDataAdapter(DBcmd)
            RecordCount = DBAD.Fill(DBDT)






        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exception = ex.Message
        Finally
            If mysqlcon.State = ConnectionState.Open Then
                mysqlcon.Close()
            End If

        End Try

    End Sub
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New MySqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function


End Class
