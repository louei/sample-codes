Public Class Form2

	Dim I As Integer = 0
	Private Sub btnAddNode_Click(sender As Object, e As EventArgs) Handles btnAddNode.Click
		Dim N As String
		N = InputBox("Enter the name of the new node")
		I = (I + 1) Mod 4
		If trVw1Form2.SelectedNode Is Nothing Then
			trVw1Form2.Nodes.Add(N, N, I, I)
		Else
			trVw1Form2.SelectedNode.Nodes.Add(N, N, I, I)
		End If

	End Sub
End Class