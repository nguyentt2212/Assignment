Imports System.Data.SqlClient

Module mldcommon
    Public Acc As String
    Public chuoiconnect As String = "workstation id=nguyentt2212.mssql.somee.com;packet size=4096;user id=nguyentt2212_SQLLogin_1;pwd=7z2ab6x4q2;data source=nguyentt2212.mssql.somee.com;persist security info=False;initial catalog=nguyentt2212"

    Public connect As SqlConnection = New SqlConnection(chuoiconnect)
End Module
