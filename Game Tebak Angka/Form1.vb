Public Class Form1

    Dim gameStarted As Boolean = False

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        If gameStarted Then
            Return
        End If
        gameStarted = True

        Dim angkaAcak1 As List(Of Integer) = AcakAngka()
        txtAngkaSatu.Text = angkaAcak1(0).ToString()

        txtOperator.Text = AcakOperator()

        Dim angkaAcak2 As List(Of Integer) = AcakAngka()
        txtAngkaDua.Text = angkaAcak2(0).ToString()
    End Sub

    Private Sub btnJawab_Click(sender As Object, e As EventArgs) Handles btnJawab.Click
        Dim angkaSatu As Integer
        If Not Integer.TryParse(txtAngkaSatu.Text, angkaSatu) Then
            MessageBox.Show("Masukkan angka yang valid untuk Angka Satu")
            Return
        End If

        Dim angkaDua As Integer
        If Not Integer.TryParse(txtAngkaDua.Text, angkaDua) Then
            MessageBox.Show("Masukkan angka yang valid untuk Angka Dua")
            Return
        End If

        Dim operatorStr As String = txtOperator.Text.Trim()
        Dim hasil As Integer

        Select Case operatorStr
            Case "+"
                hasil = angkaSatu + angkaDua
            Case "-"
                hasil = angkaSatu - angkaDua
            Case "*"
                hasil = angkaSatu * angkaDua
            Case Else
                MessageBox.Show("Operator tidak valid")
                Return
        End Select

        Dim jawaban As Integer
        If Not Integer.TryParse(txtJawaban.Text, jawaban) Then
            MessageBox.Show("Masukkan jawaban yang valid")
            Return
        End If

        If hasil = jawaban Then
            MessageBox.Show("Jawaban benar!")
            clearAll()
        Else
            MessageBox.Show("Jawaban salah. Coba lagi!")
        End If
    End Sub

    Function AcakAngka() As List(Of Integer)
        Dim angkaList As New List(Of Integer)
        For i As Integer = 1 To 20
            angkaList.Add(i)
        Next

        Dim rng As New Random()
        Dim n As Integer = angkaList.Count
        While n > 1
            n -= 1
            Dim k As Integer = rng.Next(n + 1)
            Dim value As Integer = angkaList(k)
            angkaList(k) = angkaList(n)
            angkaList(n) = value
        End While

        Return angkaList
    End Function

    Function AcakOperator() As String
        Dim operatorList As New List(Of String) From {"+", "-", "*"}
        Dim rng As New Random()
        Dim index As Integer = rng.Next(operatorList.Count)
        Return operatorList(index)
    End Function

    Private Sub clearAll()
        txtAngkaSatu.Text = Nothing
        txtAngkaDua.Text = Nothing
        txtOperator.Text = Nothing
        txtJawaban.Text = Nothing
        gameStarted = False
    End Sub
End Class
