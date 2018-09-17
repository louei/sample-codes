<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.trVw1Form2 = New System.Windows.Forms.TreeView()
		Me.btnAddNode = New System.Windows.Forms.Button()
		Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(254, 349)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.btnAddNode)
		Me.TabPage1.Controls.Add(Me.trVw1Form2)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(246, 323)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(246, 126)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(246, 126)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "TabPage3"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'trVw1Form2
		'
		Me.trVw1Form2.ImageIndex = 0
		Me.trVw1Form2.ImageList = Me.imgLst
		Me.trVw1Form2.Location = New System.Drawing.Point(8, 26)
		Me.trVw1Form2.Name = "trVw1Form2"
		Me.trVw1Form2.SelectedImageIndex = 0
		Me.trVw1Form2.Size = New System.Drawing.Size(222, 251)
		Me.trVw1Form2.TabIndex = 0
		'
		'btnAddNode
		'
		Me.btnAddNode.Location = New System.Drawing.Point(62, 283)
		Me.btnAddNode.Name = "btnAddNode"
		Me.btnAddNode.Size = New System.Drawing.Size(87, 26)
		Me.btnAddNode.TabIndex = 1
		Me.btnAddNode.Text = "Add Node"
		Me.btnAddNode.UseVisualStyleBackColor = True
		'
		'imgLst
		'
		Me.imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
		Me.imgLst.Images.SetKeyName(0, "4.jpg")
		Me.imgLst.Images.SetKeyName(1, "5.jpg")
		Me.imgLst.Images.SetKeyName(2, "6.jpg")
		Me.imgLst.Images.SetKeyName(3, "9.jpg")
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Form2"
		Me.Text = "Form2"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents btnAddNode As Button
	Friend WithEvents trVw1Form2 As TreeView
	Friend WithEvents imgLst As ImageList
End Class
