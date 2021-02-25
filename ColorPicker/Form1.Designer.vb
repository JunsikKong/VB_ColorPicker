<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_scan
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txt_index = New System.Windows.Forms.TextBox()
        Me.lbl_index = New System.Windows.Forms.Label()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Copy = New System.Windows.Forms.Button()
        Me.lbl_Code = New System.Windows.Forms.Label()
        Me.lbl_B = New System.Windows.Forms.Label()
        Me.lbl_G = New System.Windows.Forms.Label()
        Me.lbl_R = New System.Windows.Forms.Label()
        Me.lbl_X = New System.Windows.Forms.Label()
        Me.lbx_xyrgb = New System.Windows.Forms.ListBox()
        Me.txt_Code = New System.Windows.Forms.TextBox()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.txt_G = New System.Windows.Forms.TextBox()
        Me.txt_R = New System.Windows.Forms.TextBox()
        Me.txt_Y = New System.Windows.Forms.TextBox()
        Me.txt_X = New System.Windows.Forms.TextBox()
        Me.tmr_scan = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Y = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 276)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(304, 25)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txt_index
        '
        Me.txt_index.Location = New System.Drawing.Point(230, 244)
        Me.txt_index.Name = "txt_index"
        Me.txt_index.Size = New System.Drawing.Size(64, 21)
        Me.txt_index.TabIndex = 39
        Me.txt_index.TabStop = False
        '
        'lbl_index
        '
        Me.lbl_index.AutoSize = True
        Me.lbl_index.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_index.Location = New System.Drawing.Point(186, 244)
        Me.lbl_index.Name = "lbl_index"
        Me.lbl_index.Size = New System.Drawing.Size(41, 17)
        Me.lbl_index.TabIndex = 40
        Me.lbl_index.Text = "Index"
        '
        'btn_scan
        '
        Me.btn_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scan.Font = New System.Drawing.Font("굴림", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn_scan.Location = New System.Drawing.Point(16, 178)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(60, 60)
        Me.btn_scan.TabIndex = 38
        Me.btn_scan.Text = "▶"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_Del
        '
        Me.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Del.Location = New System.Drawing.Point(230, 217)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(64, 21)
        Me.btn_Del.TabIndex = 37
        Me.btn_Del.Text = "DEL"
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Add.Location = New System.Drawing.Point(90, 217)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(64, 21)
        Me.btn_Add.TabIndex = 36
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Copy
        '
        Me.btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Copy.Location = New System.Drawing.Point(160, 217)
        Me.btn_Copy.Name = "btn_Copy"
        Me.btn_Copy.Size = New System.Drawing.Size(64, 21)
        Me.btn_Copy.TabIndex = 35
        Me.btn_Copy.Text = "COPY"
        Me.btn_Copy.UseVisualStyleBackColor = True
        '
        'lbl_Code
        '
        Me.lbl_Code.AutoSize = True
        Me.lbl_Code.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_Code.Location = New System.Drawing.Point(11, 244)
        Me.lbl_Code.Name = "lbl_Code"
        Me.lbl_Code.Size = New System.Drawing.Size(105, 17)
        Me.lbl_Code.TabIndex = 34
        Me.lbl_Code.Text = "Color HEX Code"
        '
        'lbl_B
        '
        Me.lbl_B.AutoSize = True
        Me.lbl_B.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_B.Location = New System.Drawing.Point(14, 138)
        Me.lbl_B.Name = "lbl_B"
        Me.lbl_B.Size = New System.Drawing.Size(16, 17)
        Me.lbl_B.TabIndex = 33
        Me.lbl_B.Text = "B"
        '
        'lbl_G
        '
        Me.lbl_G.AutoSize = True
        Me.lbl_G.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_G.Location = New System.Drawing.Point(14, 111)
        Me.lbl_G.Name = "lbl_G"
        Me.lbl_G.Size = New System.Drawing.Size(17, 17)
        Me.lbl_G.TabIndex = 32
        Me.lbl_G.Text = "G"
        '
        'lbl_R
        '
        Me.lbl_R.AutoSize = True
        Me.lbl_R.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_R.Location = New System.Drawing.Point(14, 84)
        Me.lbl_R.Name = "lbl_R"
        Me.lbl_R.Size = New System.Drawing.Size(16, 17)
        Me.lbl_R.TabIndex = 31
        Me.lbl_R.Text = "R"
        '
        'lbl_X
        '
        Me.lbl_X.AutoSize = True
        Me.lbl_X.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_X.Location = New System.Drawing.Point(14, 15)
        Me.lbl_X.Name = "lbl_X"
        Me.lbl_X.Size = New System.Drawing.Size(16, 17)
        Me.lbl_X.TabIndex = 29
        Me.lbl_X.Text = "X"
        '
        'lbx_xyrgb
        '
        Me.lbx_xyrgb.FormattingEnabled = True
        Me.lbx_xyrgb.ItemHeight = 12
        Me.lbx_xyrgb.Location = New System.Drawing.Point(90, 15)
        Me.lbx_xyrgb.Name = "lbx_xyrgb"
        Me.lbx_xyrgb.ScrollAlwaysVisible = True
        Me.lbx_xyrgb.Size = New System.Drawing.Size(204, 196)
        Me.lbx_xyrgb.TabIndex = 28
        '
        'txt_Code
        '
        Me.txt_Code.Location = New System.Drawing.Point(116, 244)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(64, 21)
        Me.txt_Code.TabIndex = 27
        Me.txt_Code.TabStop = False
        Me.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_B
        '
        Me.txt_B.Location = New System.Drawing.Point(36, 138)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.ReadOnly = True
        Me.txt_B.Size = New System.Drawing.Size(40, 21)
        Me.txt_B.TabIndex = 26
        Me.txt_B.TabStop = False
        '
        'txt_G
        '
        Me.txt_G.Location = New System.Drawing.Point(36, 111)
        Me.txt_G.Name = "txt_G"
        Me.txt_G.ReadOnly = True
        Me.txt_G.Size = New System.Drawing.Size(40, 21)
        Me.txt_G.TabIndex = 25
        Me.txt_G.TabStop = False
        '
        'txt_R
        '
        Me.txt_R.Location = New System.Drawing.Point(36, 84)
        Me.txt_R.Name = "txt_R"
        Me.txt_R.ReadOnly = True
        Me.txt_R.Size = New System.Drawing.Size(40, 21)
        Me.txt_R.TabIndex = 24
        Me.txt_R.TabStop = False
        '
        'txt_Y
        '
        Me.txt_Y.Location = New System.Drawing.Point(36, 42)
        Me.txt_Y.Name = "txt_Y"
        Me.txt_Y.ReadOnly = True
        Me.txt_Y.Size = New System.Drawing.Size(40, 21)
        Me.txt_Y.TabIndex = 23
        Me.txt_Y.TabStop = False
        '
        'txt_X
        '
        Me.txt_X.Location = New System.Drawing.Point(36, 15)
        Me.txt_X.Name = "txt_X"
        Me.txt_X.ReadOnly = True
        Me.txt_X.Size = New System.Drawing.Size(40, 21)
        Me.txt_X.TabIndex = 22
        Me.txt_X.TabStop = False
        '
        'tmr_scan
        '
        Me.tmr_scan.Interval = 200
        '
        'lbl_Y
        '
        Me.lbl_Y.AutoSize = True
        Me.lbl_Y.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_Y.Location = New System.Drawing.Point(14, 42)
        Me.lbl_Y.Name = "lbl_Y"
        Me.lbl_Y.Size = New System.Drawing.Size(15, 17)
        Me.lbl_Y.TabIndex = 30
        Me.lbl_Y.Text = "Y"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frm_scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 301)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_index)
        Me.Controls.Add(Me.lbl_index)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_Copy)
        Me.Controls.Add(Me.lbl_Code)
        Me.Controls.Add(Me.lbl_B)
        Me.Controls.Add(Me.lbl_G)
        Me.Controls.Add(Me.lbl_R)
        Me.Controls.Add(Me.lbl_X)
        Me.Controls.Add(Me.lbx_xyrgb)
        Me.Controls.Add(Me.txt_Code)
        Me.Controls.Add(Me.txt_B)
        Me.Controls.Add(Me.txt_G)
        Me.Controls.Add(Me.txt_R)
        Me.Controls.Add(Me.txt_Y)
        Me.Controls.Add(Me.txt_X)
        Me.Controls.Add(Me.lbl_Y)
        Me.MaximizeBox = False
        Me.Name = "frm_scan"
        Me.Text = "XYRGB SCANNER / F9 -ADD"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txt_index As TextBox
    Friend WithEvents lbl_index As Label
    Friend WithEvents btn_scan As Button
    Friend WithEvents btn_Del As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Copy As Button
    Friend WithEvents lbl_Code As Label
    Friend WithEvents lbl_B As Label
    Friend WithEvents lbl_G As Label
    Friend WithEvents lbl_R As Label
    Friend WithEvents lbl_X As Label
    Friend WithEvents lbx_xyrgb As ListBox
    Friend WithEvents txt_Code As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents txt_G As TextBox
    Friend WithEvents txt_R As TextBox
    Friend WithEvents txt_Y As TextBox
    Friend WithEvents txt_X As TextBox
    Friend WithEvents tmr_scan As Timer
    Friend WithEvents lbl_Y As Label
    Friend WithEvents ImageList1 As ImageList
End Class
