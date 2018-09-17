<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Button1 = New System.Windows.Forms.Button()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnLogIn = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtTimer = New System.Windows.Forms.TextBox()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblDateTime = New System.Windows.Forms.Label()
		Me.btnOpenFileDia = New System.Windows.Forms.Button()
		Me.txtOpenFile = New System.Windows.Forms.TextBox()
		Me.opFlDiag_1 = New System.Windows.Forms.OpenFileDialog()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Go to form 2"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(12, 56)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(53, 13)
		Me.lblPassword.TabIndex = 1
		Me.lblPassword.Text = "Password"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(71, 53)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(66, 20)
		Me.txtPassword.TabIndex = 2
		'
		'btnLogIn
		'
		Me.btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), System.Drawing.Image)
		Me.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLogIn.Location = New System.Drawing.Point(71, 79)
		Me.btnLogIn.Name = "btnLogIn"
		Me.btnLogIn.Size = New System.Drawing.Size(66, 25)
		Me.btnLogIn.TabIndex = 3
		Me.btnLogIn.Text = "Log in"
		Me.btnLogIn.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(15, 110)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(122, 91)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'txtTimer
		'
		Me.txtTimer.Location = New System.Drawing.Point(15, 216)
		Me.txtTimer.Name = "txtTimer"
		Me.txtTimer.Size = New System.Drawing.Size(122, 20)
		Me.txtTimer.TabIndex = 5
		Me.txtTimer.Text = "1"
		'
		'btnStart
		'
		Me.btnStart.Location = New System.Drawing.Point(15, 242)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(50, 23)
		Me.btnStart.TabIndex = 6
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = True
		'
		'btnStop
		'
		Me.btnStop.Location = New System.Drawing.Point(82, 242)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(55, 23)
		Me.btnStop.TabIndex = 7
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		Me.Timer1.Interval = 1000
		'
		'lblDateTime
		'
		Me.lblDateTime.AutoSize = True
		Me.lblDateTime.Location = New System.Drawing.Point(12, 283)
		Me.lblDateTime.Name = "lblDateTime"
		Me.lblDateTime.Size = New System.Drawing.Size(56, 13)
		Me.lblDateTime.TabIndex = 8
		Me.lblDateTime.Text = "Date Time"
		'
		'btnOpenFileDia
		'
		Me.btnOpenFileDia.Location = New System.Drawing.Point(161, 49)
		Me.btnOpenFileDia.Name = "btnOpenFileDia"
		Me.btnOpenFileDia.Size = New System.Drawing.Size(66, 27)
		Me.btnOpenFileDia.TabIndex = 9
		Me.btnOpenFileDia.Text = "Open File"
		Me.btnOpenFileDia.UseVisualStyleBackColor = True
		'
		'txtOpenFile
		'
		Me.txtOpenFile.Location = New System.Drawing.Point(138, 14)
		Me.txtOpenFile.Name = "txtOpenFile"
		Me.txtOpenFile.Size = New System.Drawing.Size(114, 20)
		Me.txtOpenFile.TabIndex = 10
		'
		'opFlDiag_1
		'
		Me.opFlDiag_1.FileName = "OpenFileDialog1"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.txtOpenFile)
		Me.Controls.Add(Me.btnOpenFileDia)
		Me.Controls.Add(Me.lblDateTime)
		Me.Controls.Add(Me.btnStop)
		Me.Controls.Add(Me.btnStart)
		Me.Controls.Add(Me.txtTimer)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnLogIn)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.Button1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents lblPassword As Label
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents btnLogIn As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtTimer As TextBox
	Friend WithEvents btnStart As Button
	Friend WithEvents btnStop As Button
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblDateTime As Label
	Friend WithEvents btnOpenFileDia As Button
	Friend WithEvents txtOpenFile As TextBox
	Friend WithEvents opFlDiag_1 As OpenFileDialog
End Class
