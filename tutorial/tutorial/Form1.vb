Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Form2.Show()
	End Sub

	Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
		If (txtPassword.Text = "12345") Then
			Form2.Show()
		End If
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		txtTimer.Text = txtTimer.Text + 1
		lblDateTime.Text = Date.Now.ToString("dd MMM yyyy hh:mm:ss")
	End Sub

	Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
		Timer1.Start()
	End Sub

	Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
		Timer1.Stop()
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Timer1.Enabled = True
	End Sub

	Private Sub btnOpenFileDia_Click(sender As Object, e As EventArgs) Handles btnOpenFileDia.Click
		If opFlDiag_1.ShowDialog = DialogResult.OK Then
			txtOpenFile.Text = opFlDiag_1.FileName
		End If
	End Sub
End Class
