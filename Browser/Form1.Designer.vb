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
        Me.UrlBox = New System.Windows.Forms.TextBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Faqja = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'UrlBox
        '
        Me.UrlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlBox.Location = New System.Drawing.Point(79, 13)
        Me.UrlBox.Name = "UrlBox"
        Me.UrlBox.Size = New System.Drawing.Size(960, 26)
        Me.UrlBox.TabIndex = 0
        '
        'GoButton
        '
        Me.GoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoButton.Location = New System.Drawing.Point(1045, 9)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 30)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(13, 13)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(60, 30)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Faqja
        '
        Me.Faqja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Faqja.Location = New System.Drawing.Point(12, 49)
        Me.Faqja.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.Faqja.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Faqja.Name = "Faqja"
        Me.Faqja.Size = New System.Drawing.Size(1108, 398)
        Me.Faqja.TabIndex = 3
        Me.Faqja.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 459)
        Me.Controls.Add(Me.Faqja)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.UrlBox)
        Me.Name = "Form1"
        Me.Text = "Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UrlBox As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Faqja As WebBrowser
End Class
