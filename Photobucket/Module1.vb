Imports System.Data.OleDb
Module Module1
    Public Cnn As New OleDbConnection
    Public Com As New OleDbCommand
    Public Dr As OleDbDataReader
    Public Cnn1 As New OleDbConnection
    Public Com2 As New OleDbCommand
    Public Sub OpenConnect()
        Try
            Cnn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" & _
            "Data Source=" & Application.StartupPath & "\DB.mdb"
            Cnn.Open()
            Com.Connection = Cnn
            Com.CommandType = CommandType.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub OpenConnect1()
        Try
            Cnn1.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" & _
            "Data Source=" & Application.StartupPath & "\Library.mdb"
            Cnn1.Open()
            Com2.Connection = Cnn1
            Com2.CommandType = CommandType.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Message(ByVal Mess As String)
        MsgBox(Mess, MsgBoxStyle.Information, "Photobucket")
    End Sub
    Public Function Getid(ByVal tablename As String, ByVal fieldname As String, Optional ByVal cond As String = "") As Double
        Try
            Dim com1 As New OleDbCommand
            Dim dr1 As OleDbDataReader
            com1.Connection = Cnn
            Com.CommandText = "select top 1 " & fieldname & " from " & tablename & IIf(cond <> "", " where " & cond, "") & " order by 1 desc"
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                Getid = dr1(0) + 1
            Else
                Getid = 1
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function Getid1(ByVal tablename As String, ByVal fieldname As String) As Double
        Try
            Dim com1 As New OleDbCommand
            Dim dr1 As OleDbDataReader
            com1.Connection = Cnn1
            Com2.CommandText = "select top 1 " & fieldname & " from " & tablename & " order by 1 desc"
            dr1 = Com2.ExecuteReader
            If dr1.Read = True Then
                Getid1 = dr1(0) + 1
            Else
                Getid1 = 1
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
End Module
