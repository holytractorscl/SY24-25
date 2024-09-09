<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.BackColor = Color.Transparent
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(58, 139)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(174, 146)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(277, 58)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(181, 137)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(666, 90)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(86, 105)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(663, 267)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(89, 105)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(PictureBox2)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        TransparencyKey = Color.White
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox

End Class
