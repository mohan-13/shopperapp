Imports System.Data.SqlClient
Public Class SQLCONTROL
    Public SQLcon As New SqlConnection("Server=MOHAN-PC\MOHANSQL;Database=smartshop;Integrated Security=True")
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
    Private DBcmd As SqlCommand
    'DB DATA
    Public DBDT As DataTable
    Public DBAD As SqlDataAdapter
    'Query Params
    Public Params As New List(Of SqlParameter)
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
            SQLcon.Open()

            'DB Command
            DBcmd = New SqlCommand(Query, SQLcon)

            'Load Params into SqlCommand
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))
            'Clear Param list
            Params.Clear()
            'Execute Query and store
            DBDT = New DataTable
            DBAD = New SqlDataAdapter(DBcmd)
            RecordCount = DBAD.Fill(DBDT)






        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exception = ex.Message
        Finally
            If SQLcon.State = ConnectionState.Open Then
                SQLcon.Close()
            End If

        End Try

    End Sub
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function


End Class
