Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class PagamentoDAO

    Public Shared Sub SalvarPagamento(
        solicitacao As Integer,
        favorecido As String,
        documento As String,
        valor As Decimal,
        vencimento As Date,
        tipo As String,
        status As String
    )

        Using conn As SqlConnection = Conexao.AbrirConexao()

            Using comando As New SqlCommand("sp_SalvarPagamento", conn)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@Solicitacao", solicitacao)
                comando.Parameters.AddWithValue("@Favorecido", favorecido)
                comando.Parameters.AddWithValue("@Documento", documento)
                comando.Parameters.AddWithValue("@Valor", valor)
                comando.Parameters.AddWithValue("@Vencimento", vencimento)
                comando.Parameters.AddWithValue("@Tipo", tipo)
                comando.Parameters.AddWithValue("@Status", status)

                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Shared Function ConsultaPagamento(solicitacao As Integer) As Pagamento

        Using conn As SqlConnection = Conexao.AbrirConexao()

            Using comando As New SqlCommand("sp_ConsultaPagamento", conn)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@Solicitacao", solicitacao)

                Using reader As SqlDataReader = comando.ExecuteReader()

                    If reader.Read() Then

                        Dim pagamento As New Pagamento()

                        pagamento.Solicitacao = CInt(reader("Solicitacao"))
                        pagamento.Favorecido = reader("Favorecido").ToString()
                        pagamento.Documento = reader("Documento").ToString()
                        pagamento.Valor = CDec(reader("Valor"))
                        pagamento.Vencimento = CDate(reader("Vencimento"))
                        pagamento.Tipo = reader("Tipo").ToString()
                        pagamento.Status = reader("Status").ToString()

                        Return pagamento

                    End If

                End Using

            End Using

        End Using

        Return Nothing

    End Function

End Class

