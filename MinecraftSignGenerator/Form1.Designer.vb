<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "木牌种类"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"金合欢木告示牌", "白桦木告示牌", "绯红木告示牌", "深色橡木告示牌", "丛林木告示牌", "橡木告示牌", "云杉木告示牌", "诡异木告示牌"})
        Me.ComboBox1.Location = New System.Drawing.Point(85, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "目标选择器变量"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"选择最近的玩家(@p)"})
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"最近的玩家(@p)", "随机玩家(@r)", "所有玩家(@a)", "当前实体(@s)"})
        Me.ComboBox2.Location = New System.Drawing.Point(389, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 23)
        Me.ComboBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 25)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 25)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 137)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 25)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(85, 178)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(183, 25)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(687, 54)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(250, 25)
        Me.TextBox5.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "第一行"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"黑色", "蓝色", "绿色", "浅绿色", "红色", "紫色", "黄色", "白色", "灰色", "淡蓝色", "淡绿色", "淡浅绿色", "淡红色", "淡紫色", "淡黄色"})
        Me.ComboBox3.Location = New System.Drawing.Point(274, 55)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(90, 23)
        Me.ComboBox3.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(383, 57)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "粗体"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(458, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "斜体"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(527, 57)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "删除线"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(527, 98)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "删除线"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(458, 98)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox5.TabIndex = 14
        Me.CheckBox5.Text = "斜体"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(383, 98)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox6.TabIndex = 13
        Me.CheckBox6.Text = "粗体"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(527, 183)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox7.TabIndex = 29
        Me.CheckBox7.Text = "删除线"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Enabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(458, 181)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox8.TabIndex = 28
        Me.CheckBox8.Text = "斜体"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Enabled = False
        Me.CheckBox9.Location = New System.Drawing.Point(383, 181)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox9.TabIndex = 27
        Me.CheckBox9.Text = "粗体"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Enabled = False
        Me.CheckBox10.Location = New System.Drawing.Point(527, 140)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox10.TabIndex = 22
        Me.CheckBox10.Text = "删除线"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Enabled = False
        Me.CheckBox11.Location = New System.Drawing.Point(458, 140)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox11.TabIndex = 21
        Me.CheckBox11.Text = "斜体"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Enabled = False
        Me.CheckBox12.Location = New System.Drawing.Point(383, 140)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox12.TabIndex = 20
        Me.CheckBox12.Text = "粗体"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"黑色", "蓝色", "绿色", "浅绿色", "红色", "紫色", "黄色", "白色", "灰色", "淡蓝色", "淡绿色", "淡浅绿色", "淡红色", "淡紫色", "淡黄色"})
        Me.ComboBox4.Location = New System.Drawing.Point(274, 97)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(90, 23)
        Me.ComboBox4.TabIndex = 12
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"黑色", "蓝色", "绿色", "浅绿色", "红色", "紫色", "黄色", "白色", "灰色", "淡蓝色", "淡绿色", "淡浅绿色", "淡红色", "淡紫色", "淡黄色"})
        Me.ComboBox5.Location = New System.Drawing.Point(274, 140)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(90, 23)
        Me.ComboBox5.TabIndex = 19
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Enabled = False
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"黑色", "蓝色", "绿色", "浅绿色", "红色", "紫色", "黄色", "白色", "灰色", "淡蓝色", "淡绿色", "淡浅绿色", "淡红色", "淡紫色", "淡黄色"})
        Me.ComboBox6.Location = New System.Drawing.Point(274, 179)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(90, 23)
        Me.ComboBox6.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "第二行"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "第三行"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "第四行"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(652, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 40)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "生成指令(&G)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(652, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 40)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "复制到剪贴板(&C)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(687, 95)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(250, 25)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(687, 138)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(250, 25)
        Me.TextBox7.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(687, 178)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(250, 25)
        Me.TextBox8.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(676, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 15)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "点击执行的命令(多行的话会依次执行)"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(797, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 40)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "关于(&A)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(13, 221)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox9.Size = New System.Drawing.Size(633, 131)
        Me.TextBox9.TabIndex = 39
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Enabled = False
        Me.CheckBox13.Location = New System.Drawing.Point(607, 59)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox13.TabIndex = 9
        Me.CheckBox13.Text = "下划线"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Enabled = False
        Me.CheckBox14.Location = New System.Drawing.Point(607, 101)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox14.TabIndex = 16
        Me.CheckBox14.Text = "下划线"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Enabled = False
        Me.CheckBox15.Location = New System.Drawing.Point(607, 142)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox15.TabIndex = 23
        Me.CheckBox15.Text = "下划线"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Enabled = False
        Me.CheckBox16.Location = New System.Drawing.Point(607, 184)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox16.TabIndex = 30
        Me.CheckBox16.Text = "下划线"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(534, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "数量"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(584, 11)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(81, 25)
        Me.TextBox10.TabIndex = 3
        Me.TextBox10.Text = "1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(652, 313)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 39)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "重置所有(&R)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(795, 267)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 40)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "输出为txt...(&E)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Location = New System.Drawing.Point(796, 313)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 39)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "退出(&X)"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button7
        Me.ClientSize = New System.Drawing.Size(945, 364)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minecraft 自定义告示牌生成器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
