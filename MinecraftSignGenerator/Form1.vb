Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 5
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 0
        Dim dKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", True).GetValue("AppsUseLightTheme", "0")
        If dKey = 0 Then '如果是深色主题
            BackColor = Color.FromArgb(53, 54, 58) '窗口背景色

            Label1.ForeColor = Color.FromArgb(218, 220, 224) '标签前景色
            Label2.ForeColor = Color.FromArgb(218, 220, 224)
            Label3.ForeColor = Color.FromArgb(218, 220, 224)
            Label4.ForeColor = Color.FromArgb(218, 220, 224)
            Label5.ForeColor = Color.FromArgb(218, 220, 224)
            Label6.ForeColor = Color.FromArgb(218, 220, 224)
            Label7.ForeColor = Color.FromArgb(218, 220, 224)
            Label8.ForeColor = Color.FromArgb(218, 220, 224)

            CheckBox1.ForeColor = Color.FromArgb(218, 220, 224) '检查框前景色
            CheckBox2.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox3.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox4.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox5.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox6.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox7.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox8.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox9.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox10.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox11.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox12.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox13.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox14.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox15.ForeColor = Color.FromArgb(218, 220, 224)
            CheckBox16.ForeColor = Color.FromArgb(218, 220, 224)


            Button2.ForeColor = Color.FromArgb(218, 220, 224) '按钮前景颜色
            Button3.ForeColor = Color.FromArgb(218, 220, 224)
            Button4.ForeColor = Color.FromArgb(218, 220, 224)
            Button5.ForeColor = Color.FromArgb(218, 220, 224)
            Button6.ForeColor = Color.FromArgb(218, 220, 224)
            Button7.ForeColor = Color.FromArgb(218, 220, 224)

            Button2.BackColor = Color.FromArgb(53, 54, 58) '按钮背景颜色
            Button3.BackColor = Color.FromArgb(53, 54, 58)
            Button4.BackColor = Color.FromArgb(53, 54, 58)
            Button5.BackColor = Color.FromArgb(53, 54, 58)
            Button6.BackColor = Color.FromArgb(53, 54, 58)
            Button7.BackColor = Color.FromArgb(53, 54, 58)

            Button2.FlatStyle = FlatStyle.Flat '扁平化
            Button3.FlatStyle = FlatStyle.Flat
            Button4.FlatStyle = FlatStyle.Flat
            Button5.FlatStyle = FlatStyle.Flat
            Button6.FlatStyle = FlatStyle.Flat
            Button7.FlatStyle = FlatStyle.Flat

            TextBox1.ForeColor = Color.FromArgb(218, 220, 224) '文本框前景色
            TextBox2.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox3.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox4.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox5.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox6.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox7.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox8.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox9.ForeColor = Color.FromArgb(218, 220, 224)
            TextBox10.ForeColor = Color.FromArgb(218, 220, 224)

            TextBox1.BackColor = Color.FromArgb(32, 33, 36) '文本框背景色
            TextBox2.BackColor = Color.FromArgb(32, 33, 36)
            TextBox3.BackColor = Color.FromArgb(32, 33, 36)
            TextBox4.BackColor = Color.FromArgb(32, 33, 36)
            TextBox5.BackColor = Color.FromArgb(32, 33, 36)
            TextBox6.BackColor = Color.FromArgb(32, 33, 36)
            TextBox7.BackColor = Color.FromArgb(32, 33, 36)
            TextBox8.BackColor = Color.FromArgb(32, 33, 36)
            TextBox9.BackColor = Color.FromArgb(32, 33, 36)
            TextBox10.BackColor = Color.FromArgb(32, 33, 36)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Command As String, NBT As String
        Command = "/give"
        Select Case ComboBox2.SelectedIndex
            Case 0
                Command += " @p"'最近的玩家
            Case 1
                Command += " @r"'随机玩家
            Case 2
                Command += " @a"'所有玩家
            Case 3
                Command += " @s" '最近实体
        End Select
        Select Case ComboBox1.SelectedIndex
            Case 0
                Command += " minecraft:acacia_sign"'金合欢木告示牌
            Case 1
                Command += " minecraft:birch_sign"'白桦木告示牌
            Case 2
                Command += " minecraft:crimson_sign"'绯红木告示牌
            Case 3
                Command += " minecraft:dark_oak_sign"'深色橡木告示牌
            Case 4
                Command += " minecraft:jungle_sign"'从林木告示牌
            Case 5
                Command += " minecraft:oak_sign"'橡木告示牌
            Case 6
                Command += " minecraft:spruce_sign" '云杉木告示牌
            Case 7
                Command += " minecraft:warped_sign" '诡异木告示牌
        End Select
        NBT = "{BlockEntityTag:{"

        If TextBox1.Text <> "" Then '第一行文字
            NBT += "Text1:" + TextGen(TextBox1.Text, ComboBox3.SelectedIndex, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox13.Checked, TextBox5.Text)
        End If
        If TextBox2.Text <> "" Then '第二行文字
            If TextBox1.Text <> "" Then
                NBT += ","
            End If
            NBT += "Text2:" + TextGen(TextBox2.Text, ComboBox4.SelectedIndex, CheckBox6.Checked, CheckBox5.Checked, CheckBox4.Checked, CheckBox14.Checked, TextBox6.Text)
        End If
        If TextBox3.Text <> "" Then '第三行文字
            If TextBox1.Text <> "" Or TextBox2.Text <> "" Then
                NBT += ","
            End If
            NBT += "Text3:" + TextGen(TextBox3.Text, ComboBox5.SelectedIndex, CheckBox12.Checked, CheckBox11.Checked, CheckBox10.Checked, CheckBox15.Checked, TextBox7.Text)
        End If
        If TextBox4.Text <> "" Then '第四行文字
            If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Then
                NBT += ","
            End If
            NBT += "Text4:" + TextGen(TextBox4.Text, ComboBox6.SelectedIndex, CheckBox9.Checked, CheckBox8.Checked, CheckBox7.Checked, CheckBox16.Checked, TextBox8.Text)
        End If
        NBT += "}}"
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Or TextBox4.Text <> "" Then
            Command += NBT 'NBT与前缀合并指令
        End If
        If Val(TextBox10.Text) > 64 Then
            Command += " 64" '限制大小最多64个
            MsgBox("物品数量不能超过64个，已为你自动设置为64个", vbInformation, "提示")
            TextBox10.Text = "64"
        Else
            If Val(TextBox10.Text) > 1 And Val(TextBox10.Text) <= 64 Then
                Command += " " & Val(TextBox10.Text)
            End If
            If Val(TextBox10.Text) = 0 Then '限制大小最少1个
                MsgBox("物品数量不能少于1个，已为你自动设置为1个", vbInformation, "提示")
                TextBox10.Text = 1
            End If
        End If
        TextBox9.Text = Command '将指令传递给文本框
        Button3.Enabled = True
        Button6.Enabled = True
    End Sub
    Private Function TextGen(a As String, b As Integer, c As Boolean, d As Boolean, e As Boolean, f As Boolean, g As String) '自定义一个函数，为了减小体积
        TextGen = """{\""text\"":\""" + a '文本
        Select Case b'颜色
            Case 1
                TextGen += "\"",\""color\"":\""dark_blue"
            Case 2
                TextGen += "\"",\""color\"":\""dark_green"
            Case 3
                TextGen += "\"",\""color\"":\""dark_aqua"
            Case 4
                TextGen += "\"",\""color\"":\""dark_red"
            Case 5
                TextGen += "\"",\""color\"":\""dark_purple"
            Case 6
                TextGen += "\"",\""color\"":\""gold"
            Case 7
                TextGen += "\"",\""color\"":\""gray"
            Case 8
                TextGen += "\"",\""color\"":\""dark_gray"
            Case 9
                TextGen += "\"",\""color\"":\""blue"
            Case 10
                TextGen += "\"",\""color\"":\""green"
            Case 11
                TextGen += "\"",\""color\"":\""aqua"
            Case 12
                TextGen += "\"",\""color\"":\""red"
            Case 13
                TextGen += "\"",\""color\"":\""light_purple"
            Case 14
                TextGen += "\"",\""color\"":\""yellow"
        End Select
        If c = True Then '粗体
            TextGen += "\"",\""bold\"":\""true"
        End If
        If d = True Then '斜体
            TextGen += "\"",\""italic\"":\""true"
        End If
        If e = True Then '删除线
            TextGen += "\"",\""strikethrough\"":\""true"
        End If
        If f = True Then '下划线
            TextGen += "\"",\""underlined\"":\""true"
        End If
        If g <> "" Then '执行的命令
            TextGen += "\"",\""clickEvent\"":{\""action\"":\""run_command\"",\""value\"":\""" + g + "\""}}"""
        Else
            TextGen += "\""}"""
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox9.Text) '复制到剪贴板
        MsgBox("嗷呜~~(^・ω・^ )指令已复制到剪贴板" & vbCrLf & "去Minecraft的聊天栏或者命令方块里按下Ctrl+V来输入指令吧~" & vbCrLf & "如果指令过长，建议输入在命令方块内", vbInformation, "提示")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged '以下代码为了保证设置正确，防止指令出错
        If TextBox1.Text <> "" Then
            ComboBox3.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox13.Enabled = True
            TextBox5.Enabled = True
        Else
            ComboBox3.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox13.Enabled = False
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            ComboBox4.Enabled = True
            CheckBox6.Enabled = True
            CheckBox5.Enabled = True
            CheckBox4.Enabled = True
            CheckBox14.Enabled = True
            TextBox6.Enabled = True
        Else
            ComboBox4.Enabled = False
            CheckBox6.Enabled = False
            CheckBox5.Enabled = False
            CheckBox4.Enabled = False
            CheckBox14.Enabled = False
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            ComboBox5.Enabled = True
            CheckBox12.Enabled = True
            CheckBox11.Enabled = True
            CheckBox10.Enabled = True
            CheckBox15.Enabled = True
            TextBox7.Enabled = True
        Else
            ComboBox5.Enabled = False
            CheckBox12.Enabled = False
            CheckBox11.Enabled = False
            CheckBox10.Enabled = False
            CheckBox15.Enabled = False
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> "" Then
            ComboBox6.Enabled = True
            CheckBox9.Enabled = True
            CheckBox8.Enabled = True
            CheckBox7.Enabled = True
            CheckBox16.Enabled = True
            TextBox8.Enabled = True
        Else
            ComboBox6.Enabled = False
            CheckBox9.Enabled = False
            CheckBox8.Enabled = False
            CheckBox7.Enabled = False
            CheckBox16.Enabled = False
            TextBox8.Enabled = False
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then '检测0-9，退格键
            e.Handled = False '处理
        Else
            e.Handled = True '程序认为已经处理过了，于是不会处理
        End If '进行检测处理，禁止输入0-9以及退格键以外的东西
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim SaveFileDialog1 As New SaveFileDialog()
        '创建一个保存对话框
        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt" '设置扩展名
        SaveFileDialog1.FileName = "新告示牌指令.txt" '默认文件名
        SaveFileDialog1.Title = "将指令保存在..." '设置保存窗口标题
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            '如果确定保存
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox9.Text, False)
            '保存文本,False表示不追加文本，直接覆盖其内容
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim t = MsgBox("是否退出", vbExclamation + vbYesNo, "提示")
        If t = vbYes Then
            Me.Dispose() '退出
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim t As Integer
        t = MsgBox("是否重置所有选项为初始状态？", vbExclamation + vbYesNo, "提示")
        If t = vbYes Then
            ComboBox1.SelectedIndex = 5
            ComboBox2.SelectedIndex = 0
            ComboBox3.SelectedIndex = 0
            ComboBox4.SelectedIndex = 0
            ComboBox5.SelectedIndex = 0
            ComboBox6.SelectedIndex = 0
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            Button3.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim t = MsgBox("是否退出", vbExclamation + vbYesNo, "提示")
        If t = vbNo Then
            e.Cancel = True '不退出
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("作者：雄龙ztz，转载请注意出处" & vbCrLf & "该程序适用版本：Java版 1.14+" & vbCrLf & "（这是已发现的最早可以兼容的版本，不保证以后nbt会改变）" & vbCrLf & "该程序需要.Net Framework 4.7.2支持，低于此版本可能无法正常运行", vbInformation, "(^・ω・^ )")
    End Sub
End Class
