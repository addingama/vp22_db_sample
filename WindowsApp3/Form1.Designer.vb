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
        Me.tb_fullname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_fullname
        '
        Me.tb_fullname.Location = New System.Drawing.Point(70, 9)
        Me.tb_fullname.Name = "tb_fullname"
        Me.tb_fullname.Size = New System.Drawing.Size(202, 20)
        Me.tb_fullname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(70, 35)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(202, 20)
        Me.tb_username.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(70, 61)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(202, 20)
        Me.tb_password.TabIndex = 4
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(110, 87)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(278, 87)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 7
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'dgv_data
        '
        Me.dgv_data.AllowUserToDeleteRows = False
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Location = New System.Drawing.Point(12, 127)
        Me.dgv_data.MultiSelect = False
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.ReadOnly = True
        Me.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_data.Size = New System.Drawing.Size(364, 161)
        Me.dgv_data.TabIndex = 8
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(197, 87)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 9
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 311)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.dgv_data)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_fullname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_fullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_password As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents btn_update As Button
End Class
