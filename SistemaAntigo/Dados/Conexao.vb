Imports Microsoft.Data.SqlClient

Public Class Conexao

    Private Shared ReadOnly connectionString As String =
    "Server=SEU_SERVIDOR;" &
    "Database=SEU_BANCO;" &
    "User Id=SEU_USUARIO;" &
    "Password=SUA_SENHA;" &
    "TrustServerCertificate=True;"

    Public Shared Function AbrirConexao() As SqlConnection

        Dim conexao As New SqlConnection(connectionString)

        conexao.Open()

        Return conexao

    End Function

End Class
