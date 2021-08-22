<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxMoshimo = New System.Windows.Forms.TextBox()
        Me.tbxWord = New System.Windows.Forms.TextBox()
        Me.tbxResult = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "↓「もしもアフィリエイト」　リンク貼り付け場所"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "↓各ショッピングサイトでの検索ワード"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "↓出力結果"
        '
        'tbxMoshimo
        '
        Me.tbxMoshimo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxMoshimo.Location = New System.Drawing.Point(40, 62)
        Me.tbxMoshimo.Name = "tbxMoshimo"
        Me.tbxMoshimo.Size = New System.Drawing.Size(315, 25)
        Me.tbxMoshimo.TabIndex = 3
        '
        'tbxWord
        '
        Me.tbxWord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxWord.Location = New System.Drawing.Point(40, 166)
        Me.tbxWord.Name = "tbxWord"
        Me.tbxWord.Size = New System.Drawing.Size(264, 25)
        Me.tbxWord.TabIndex = 4
        '
        'tbxResult
        '
        Me.tbxResult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxResult.Location = New System.Drawing.Point(40, 360)
        Me.tbxResult.Name = "tbxResult"
        Me.tbxResult.Size = New System.Drawing.Size(286, 25)
        Me.tbxResult.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(134, 246)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(94, 42)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go！"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(357, 352)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(94, 40)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "コピー"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 421)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.tbxResult)
        Me.Controls.Add(Me.tbxWord)
        Me.Controls.Add(Me.tbxMoshimo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "カエレバリンク置き換えツール"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxMoshimo As System.Windows.Forms.TextBox
    Friend WithEvents tbxWord As System.Windows.Forms.TextBox
    Friend WithEvents tbxResult As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button

End Class
