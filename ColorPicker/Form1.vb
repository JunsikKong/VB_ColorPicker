Public Class frm_scan
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer '다른 프로그램에서도 키 입력가능
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal duFlage As Long) ' 마우스 동작 이벤트
    Private Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer '픽셀 입력받기
    Private Declare Function GetWindowDC Lib "user32" (ByVal hwnd As Integer) As Integer '좌표 입력받기
    Dim scan_on As Boolean = False, memo As String
    Dim Hex_R As String, Hex_G As String, Hex_B As String

    'RGB 출력 설정
    Dim bmp As New Bitmap(1, 1)

    Private ReH, ReS, ReV As Double

    Private Sub RGBToHSV(ByVal rr As Single, ByVal gg As Single, ByVal bb As Single)
        Dim delta As Double, min As Double
        Dim h As Double = 0, s As Double, v As Double

        min = Math.Min(Math.Min(rr, gg), bb) '55
        v = Math.Max(Math.Max(rr, gg), bb) '75
        delta = v - min '20

        If v = 0.0 Then
            s = 0
        Else '0.266666..., 0.0574712
            s = delta / v
        End If

        If s = 0 Then
            h = 0.0
        Else
            If rr = v Then
                h = (gg - bb) / delta
            ElseIf gg = v Then
                h = 2 + (bb - rr) / delta
            ElseIf bb = v Then
                h = 4 + (rr - gg) / delta '-0.8, 4.3
            End If

            h *= 60 '-48,258

            If h < 0.0 Then
                h = h + 360 '312
            End If
        End If

        ReH = Math.Round(h, 0)
        ReS = Math.Round(s * 100, 0)
        ReV = Math.Round(v * 100 / 255, 0)

    End Sub



    Private Sub tmr_scan_Tick(sender As Object, e As EventArgs) Handles tmr_scan.Tick
        'XY 출력 설정
        Dim mouse_pos As Point = MousePosition
        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(Windows.Forms.Cursor.Position, New Point(0, 0), New Size(1, 1))
        End Using
        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)

        'btn_scan에 색상 출력
        btn_scan.BackColor = pixel

        'XYRGB 값 텍스트박스에 출력
        txt_X.Text = mouse_pos.X
        txt_Y.Text = mouse_pos.Y
        txt_R.Text = bmp.GetPixel(0, 0).R
        txt_G.Text = bmp.GetPixel(0, 0).G
        txt_B.Text = bmp.GetPixel(0, 0).B
        RGBToHSV(bmp.GetPixel(0, 0).R, bmp.GetPixel(0, 0).G, bmp.GetPixel(0, 0).B)
        ToolStripLabel1.Text = "H : " & ReH & " ° / S : " & ReS & " % / V : " & ReV & " %"

        '10진수 RGB값 16진수의 두자리로 출력
        If bmp.GetPixel(0, 0).R < 16 Then
            Hex_R = "0" + Convert.ToString(bmp.GetPixel(0, 0).R, 16)
        Else
            Hex_R = Convert.ToString(bmp.GetPixel(0, 0).R, 16)
        End If

        If bmp.GetPixel(0, 0).G < 16 Then
            Hex_G = "0" + Convert.ToString(bmp.GetPixel(0, 0).G, 16)
        Else
            Hex_G = Convert.ToString(bmp.GetPixel(0, 0).G, 16)
        End If

        If bmp.GetPixel(0, 0).B < 16 Then
            Hex_B = "0" + Convert.ToString(bmp.GetPixel(0, 0).B, 16)
        Else
            Hex_B = Convert.ToString(bmp.GetPixel(0, 0).B, 16)
        End If

        txt_Code.Text = "#" & Hex_R & Hex_G & Hex_B
        btn_scan.Text = ""

        If GetAsyncKeyState(Keys.F9) Then 'F9키 누르면 클립보드에 XYRGB값 스캔
            btn_Add_Click(sender, New System.EventArgs())
        End If

        '마우스 포인터 수동이동
        If GetAsyncKeyState(Keys.NumPad8) Then
            Cursor.Position = New Point(mouse_pos.X, mouse_pos.Y - 1)
        ElseIf GetAsyncKeyState(Keys.NumPad2) Then
            Cursor.Position = New Point(mouse_pos.X, mouse_pos.Y + 1)
        ElseIf GetAsyncKeyState(Keys.NumPad4) Then
            Cursor.Position = New Point(mouse_pos.X - 1, mouse_pos.Y)
        ElseIf GetAsyncKeyState(Keys.NumPad6) Then
            Cursor.Position = New Point(mouse_pos.X + 1, mouse_pos.Y)
        End If

        Me.Invalidate()
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        If scan_on = True Then
            btn_scan.BackColor = Color.FromArgb(240, 240, 240)
            btn_scan.Text = "▶"
            tmr_scan.Enabled = False
            scan_on = False
        ElseIf scan_on = False Then
            tmr_scan.Enabled = True
            scan_on = True
        End If
    End Sub



    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txt_X.Text <> "" And txt_Y.Text <> "" And txt_R.Text <> "" And txt_G.Text <> "" And txt_B.Text <> "" Then
            If txt_index.Text <> "" Then
                memo = "[" & txt_index.Text & "] "
            ElseIf txt_index.Text = "" Then
                memo = ""
            End If
            lbx_xyrgb.Items.Add(memo & txt_X.Text & ", " & txt_Y.Text & ", " & txt_R.Text & ", " & txt_G.Text & ", " & txt_B.Text)
            txt_index.Focus()
            '리스트 추가할 때마다 마지막 아이템 선택
            lbx_xyrgb.SelectedIndex = lbx_xyrgb.Items.Count - 1
        End If
    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click
        lbx_xyrgb.Items.Remove(lbx_xyrgb.SelectedItem)
        '리스트박스 다중 선택시 다중 선택한 아이템 삭제
        'Dim del_count As Integer = 0
        'For del_count = 0 To lbx_xyrgb.SelectedItems.Count
        'lbx_xyrgb.Items.Remove(lbx_xyrgb.SelectedItem)
        'Next
    End Sub

    Private Sub btn_Copy_Click(sender As Object, e As EventArgs) Handles btn_Copy.Click
        If lbx_xyrgb.Items.Count > 0 Then
            Clipboard.SetText(lbx_xyrgb.SelectedItem)
        End If
    End Sub
End Class
