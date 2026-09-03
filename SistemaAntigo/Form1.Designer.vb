<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        lblSolicitacao = New Label()
        txtSolicitacao = New TextBox()
        lblFavorecido = New Label()
        txtFavorecido = New TextBox()
        lblDocumento = New Label()
        lblValor = New Label()
        lblVencimento = New Label()
        lblTipo = New Label()
        lblStatus = New Label()
        btnNovo = New Button()
        btnSalvar = New Button()
        btnConsultar = New Button()
        btnSair = New Button()
        txtDocumento = New TextBox()
        txtValor = New TextBox()
        cmbTipo = New ComboBox()
        cmbStatus = New ComboBox()
        txtVencimento = New TextBox()
        btnLimparConsulta = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(139, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 20)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de Pagamentos"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSolicitacao
        ' 
        lblSolicitacao.AutoSize = True
        lblSolicitacao.Location = New Point(12, 65)
        lblSolicitacao.Name = "lblSolicitacao"
        lblSolicitacao.Size = New Size(106, 20)
        lblSolicitacao.TabIndex = 1
        lblSolicitacao.Text = "Nº Solicitação:"
        ' 
        ' txtSolicitacao
        ' 
        txtSolicitacao.Location = New Point(121, 62)
        txtSolicitacao.Name = "txtSolicitacao"
        txtSolicitacao.Size = New Size(247, 27)
        txtSolicitacao.TabIndex = 2
        ' 
        ' lblFavorecido
        ' 
        lblFavorecido.AutoSize = True
        lblFavorecido.Location = New Point(34, 108)
        lblFavorecido.Name = "lblFavorecido"
        lblFavorecido.Size = New Size(84, 20)
        lblFavorecido.TabIndex = 3
        lblFavorecido.Text = "Favorecido:"
        ' 
        ' txtFavorecido
        ' 
        txtFavorecido.Location = New Point(121, 105)
        txtFavorecido.Name = "txtFavorecido"
        txtFavorecido.Size = New Size(247, 27)
        txtFavorecido.TabIndex = 4
        ' 
        ' lblDocumento
        ' 
        lblDocumento.AutoSize = True
        lblDocumento.Location = New Point(36, 154)
        lblDocumento.Name = "lblDocumento"
        lblDocumento.Size = New Size(82, 20)
        lblDocumento.TabIndex = 5
        lblDocumento.Text = "CNPJ / CPF:"
        ' 
        ' lblValor
        ' 
        lblValor.AutoSize = True
        lblValor.Location = New Point(51, 202)
        lblValor.Name = "lblValor"
        lblValor.Size = New Size(67, 20)
        lblValor.TabIndex = 6
        lblValor.Text = "Valor: R$"
        ' 
        ' lblVencimento
        ' 
        lblVencimento.AutoSize = True
        lblVencimento.Location = New Point(28, 248)
        lblVencimento.Name = "lblVencimento"
        lblVencimento.Size = New Size(90, 20)
        lblVencimento.TabIndex = 7
        lblVencimento.Text = "Vencimento:"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Location = New Point(76, 300)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(42, 20)
        lblTipo.TabIndex = 8
        lblTipo.Text = "Tipo:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(66, 349)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 20)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status:"
        ' 
        ' btnNovo
        ' 
        btnNovo.Location = New Point(15, 409)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(94, 29)
        btnNovo.TabIndex = 10
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(15, 444)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(94, 29)
        btnSalvar.TabIndex = 11
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(315, 444)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(94, 29)
        btnConsultar.TabIndex = 12
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnSair
        ' 
        btnSair.Location = New Point(315, 409)
        btnSair.Name = "btnSair"
        btnSair.Size = New Size(94, 29)
        btnSair.TabIndex = 13
        btnSair.Text = "Sair"
        btnSair.UseVisualStyleBackColor = True
        ' 
        ' txtDocumento
        ' 
        txtDocumento.Location = New Point(121, 151)
        txtDocumento.Name = "txtDocumento"
        txtDocumento.Size = New Size(247, 27)
        txtDocumento.TabIndex = 14
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(121, 199)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(247, 27)
        txtValor.TabIndex = 15
        ' 
        ' cmbTipo
        ' 
        cmbTipo.FormattingEnabled = True
        cmbTipo.Items.AddRange(New Object() {"Selecione...", "Honorários", "Custas Processuais", "Reembolso", "Prestador de Seviço", "Fornecedor", "Outros"})
        cmbTipo.Location = New Point(121, 297)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(247, 28)
        cmbTipo.TabIndex = 17
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Selecione...", "Pendente", "Aprovado", "Pago", "Cancelado"})
        cmbStatus.Location = New Point(121, 346)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(247, 28)
        cmbStatus.TabIndex = 18
        ' 
        ' txtVencimento
        ' 
        txtVencimento.Location = New Point(121, 245)
        txtVencimento.Name = "txtVencimento"
        txtVencimento.Size = New Size(247, 27)
        txtVencimento.TabIndex = 19
        ' 
        ' btnLimparConsulta
        ' 
        btnLimparConsulta.Location = New Point(169, 409)
        btnLimparConsulta.Name = "btnLimparConsulta"
        btnLimparConsulta.Size = New Size(94, 64)
        btnLimparConsulta.TabIndex = 20
        btnLimparConsulta.Text = "Limpar Consulta"
        btnLimparConsulta.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 511)
        Controls.Add(btnLimparConsulta)
        Controls.Add(txtVencimento)
        Controls.Add(cmbStatus)
        Controls.Add(cmbTipo)
        Controls.Add(txtValor)
        Controls.Add(txtDocumento)
        Controls.Add(btnSair)
        Controls.Add(btnConsultar)
        Controls.Add(btnSalvar)
        Controls.Add(btnNovo)
        Controls.Add(lblStatus)
        Controls.Add(lblTipo)
        Controls.Add(lblVencimento)
        Controls.Add(lblValor)
        Controls.Add(lblDocumento)
        Controls.Add(txtFavorecido)
        Controls.Add(lblFavorecido)
        Controls.Add(txtSolicitacao)
        Controls.Add(lblSolicitacao)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Sistema de Pagamentos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSolicitacao As Label
    Friend WithEvents txtSolicitacao As TextBox
    Friend WithEvents lblFavorecido As Label
    Friend WithEvents txtFavorecido As TextBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblVencimento As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtVencimento As TextBox
    Friend WithEvents btnLimparConsulta As Button

End Class
