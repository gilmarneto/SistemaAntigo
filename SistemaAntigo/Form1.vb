Public Class Form1
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        funcLimparConsulta()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            PagamentoDAO.SalvarPagamento(
                CInt(txtSolicitacao.Text),
                txtFavorecido.Text,
                txtDocumento.Text,
                CDec(txtValor.Text),
                txtVencimento.Text,
                cmbTipo.Text,
                cmbStatus.Text
            )
            MessageBox.Show("Pagamento salvo com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Esta solicitação já está cadastrada para este favorecido.")
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim pagamento As Pagamento = PagamentoDAO.ConsultaPagamento(CInt(txtSolicitacao.Text))
        If pagamento IsNot Nothing Then
            txtFavorecido.Text = pagamento.Favorecido
            txtDocumento.Text = pagamento.Documento
            txtValor.Text = pagamento.Valor.ToString()
            txtVencimento.Text = pagamento.Vencimento.ToString("dd/MM/yyyy")
            cmbTipo.Text = pagamento.Tipo
            cmbStatus.Text = pagamento.Status
        Else
            MsgBox("Solicitação não encontrada.")
            funcLimparConsulta()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnLimparConsulta_Click(sender As Object, e As EventArgs) Handles btnLimparConsulta.Click
        funcLimparConsulta()
    End Sub

    Public Sub funcLimparConsulta()
        txtSolicitacao.Clear()
        txtFavorecido.Clear()
        txtDocumento.Clear()
        txtValor.Clear()
        txtVencimento.Clear()

        cmbTipo.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0

        txtSolicitacao.Focus()
    End Sub

End Class
