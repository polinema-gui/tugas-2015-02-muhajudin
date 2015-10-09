
Public Class Form1
    Dim Masukan1 As Integer
    Dim Masukan2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub inputNomor(ByVal masukan As Char)
        If Me.status = True Then
            If (Me.textHasil.Text = "0") Then
                Me.textHasil.Text = Convert.ToString(masukan)
            Else
                Dim textHasil As TextBox = Me.textHasil
                textHasil.Text = (textHasil.Text & Convert.ToString(masukan))
            End If
        Else
            Me.textHasil.Text = Convert.ToString(masukan)
            Me.status = True
        End If
    End Sub

    Private Sub inputOperator(ByVal oprator As String)
        If (Me.textHasil.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.Masukan1 = Convert.ToInt32(Me.textHasil.Text)
                Me.textHasil.Text = Me.Masukan1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub

    Private Sub hitung()
        Me.Masukan2 = Convert.ToInt32(Me.textHasil.Text)
        Select Case Me.operasi
            Case "+"
                Me.Masukan1 = (Me.Masukan1 + Me.Masukan2)
                Exit Select
            Case "-"
                Me.Masukan1 = (Me.Masukan1 - Me.Masukan2)
                Exit Select
        End Select
        Me.textHasil.Text = Me.Masukan1.ToString
        Me.status = False
    End Sub
    Private Sub tombolNol_Click(sender As Object, e As EventArgs) Handles tombolNol.Click
        If (Me.status AndAlso (Me.textHasil.Text <> "0")) Then
            Dim textHasil As TextBox = Me.textHasil
            textHasil.Text = (textHasil.Text & "0")
        End If
    End Sub

    Private Sub tombolSatu_Click(sender As Object, e As EventArgs) Handles tombolSatu.Click
        Me.inputNomor("1")
    End Sub

    Private Sub tombolDua_Click(sender As Object, e As EventArgs) Handles tombolDua.Click
        Me.inputNomor("2")
    End Sub

    Private Sub tombolTiga_Click(sender As Object, e As EventArgs) Handles tombolTiga.Click
        Me.inputNomor("3")
    End Sub

    Private Sub tombolEmpat_Click(sender As Object, e As EventArgs) Handles tombolEmpat.Click
        Me.inputNomor("4")
    End Sub

    Private Sub tombolLima_Click(sender As Object, e As EventArgs) Handles tombolLima.Click
        Me.inputNomor("5")
    End Sub

    Private Sub tombolEnam_Click(sender As Object, e As EventArgs) Handles tombolEnam.Click
        Me.inputNomor("6")
    End Sub

    Private Sub tombolTujuh_Click(sender As Object, e As EventArgs) Handles tombolTujuh.Click
        Me.inputNomor("7")
    End Sub

    Private Sub tombolDelapan_Click(sender As Object, e As EventArgs) Handles tombolDelapan.Click
        Me.inputNomor("8")
    End Sub

    Private Sub tombolSembilan_Click(sender As Object, e As EventArgs) Handles tombolSembilan.Click
        Me.inputNomor("9")
    End Sub
    Private Sub tombolHapus_Click_1(sender As Object, e As EventArgs) Handles tombolHapus.Click
        Me.textHasil.Text = 0
        Me.Masukan1 = 0
        Me.operasi = String.Empty
    End Sub
    Private Sub tombolKurang_Click_1(sender As Object, e As EventArgs) Handles tombolKurang.Click
        Me.inputOperator("-")
    End Sub
    Private Sub tombolTambah_Click_1(sender As Object, e As EventArgs) Handles tombolTambah.Click
        Me.inputOperator("+")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.hitung()
        Me.operasi = String.Empty
    End Sub
End Class
