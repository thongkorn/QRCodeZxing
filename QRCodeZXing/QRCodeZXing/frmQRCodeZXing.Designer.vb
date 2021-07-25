<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeZXing
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(36, 21)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(114, 18)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Text to encode:"
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Location = New System.Drawing.Point(40, 469)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(376, 32)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load QR Code"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(40, 429)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(376, 32)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save QR Code"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(40, 98)
        Me.picBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(376, 301)
        Me.picBarcode.TabIndex = 6
        Me.picBarcode.TabStop = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(40, 43)
        Me.txtData.Margin = New System.Windows.Forms.Padding(4)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(376, 26)
        Me.txtData.TabIndex = 0
        '
        'btnCopy
        '
        Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopy.Location = New System.Drawing.Point(40, 512)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(376, 32)
        Me.btnCopy.TabIndex = 10
        Me.btnCopy.Text = "Copy to clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'frmQRCodeZXing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 557)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.txtData)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQRCodeZXing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Code with ZXing.Net - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnLoad As Button
    Private WithEvents btnSave As Button
    Private WithEvents picBarcode As PictureBox
    Private WithEvents txtData As TextBox
    Private WithEvents btnCopy As System.Windows.Forms.Button
End Class
