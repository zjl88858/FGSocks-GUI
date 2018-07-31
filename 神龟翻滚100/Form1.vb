Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        Dim ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        Me.Top = (ScreenHeight - Me.Height) / 2
        Me.Left = (ScreenWidth - Me.Width) / 2
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Label5.Text = "抱歉开了个小小的玩笑...请放心神龟翻滚是不会收费的！永远！"
        Label6.Text = "——by 爱你们的神龟"
        Label7.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("unset.exe")
        Label5.Text = "修复LSP完毕..."
        Label6.Text = ""
        Label7.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            My.Computer.FileSystem.DeleteFile("launcher.exe")
            FileSystem.FileCopy("pak_4249.dat", "launcher.exe")
            Process.Start("launcher.exe")
            Process.Start("set_lsp64.exe")
            Button1.Enabled = False
            Button2.Enabled = True
            Label5.Text = "已经连接到:凤凰城02 模式1 端口80"
            Label6.Text = "不要忘记在关机之前断开连接哦！"
            Label7.Text = ""
        End If
        'If RadioButton2.Checked Then
        '    My.Computer.FileSystem.DeleteFile("launcher.exe")
        '    FileSystem.FileCopy("pak_4243.dat", "launcher.exe")
        '    Process.Start("launcher.exe")
        '    Process.Start("set_lsp64.exe")
        '    Button1.Enabled = False
        '    Button2.Enabled = True
        '    Label5.Text = "已经连接到:Railgun中转新泽西01 模式2 端口80→端口80"
        '    Label6.Text = "不要忘记在关机之前断开连接哦！"
        'End If
        'If jd3.Checked Then
        '    My.Computer.FileSystem.DeleteFile("gui-config.json")
        '    FileSystem.FileCopy("pak_2015.dat", "gui-config.json")
        '    Process.Start("shadowsocks.exe")
        '    Button1.Enabled = False
        '    Button2.Enabled = True
        '    Label5.Text = "已经连接到:西雅图01 模式3 端口443"
        '    Label6.Text = "不要忘记在关机之前断开连接哦！"
        'End If
        If jd4.Checked Then
            My.Computer.FileSystem.DeleteFile("launcher.exe")
            FileSystem.FileCopy("pak_10009.dat", "launcher.exe")
            Process.Start("launcher.exe")
            Process.Start("set_lsp64.exe")
            Button1.Enabled = False
            Button2.Enabled = True
            Label5.Text = "已经连接到:洛杉矶01 模式4 端口8080"
            Label6.Text = "不要忘记在关机之前断开连接哦！"
        End If
        If jd5.Checked Then
            My.Computer.FileSystem.DeleteFile("launcher.exe")
            FileSystem.FileCopy("pak_10067.dat", "launcher.exe")
            Process.Start("launcher.exe")
            Process.Start("set_lsp64.exe")
            Button1.Enabled = False
            Button2.Enabled = True
            Label5.Text = "已经连接到:圣何塞01 模式4 端口8080"
            Label6.Text = "不要忘记在关机之前断开连接哦！"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("kps.exe"）
        Process.Start("unset.exe"）
        Button2.Enabled = False
        Button1.Enabled = True
        Label5.Text = "准备就绪"
        Label6.Text = ""
        Label7.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("update.exe"）
        Process.GetCurrentProcess().Kill()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("http://shang.qq.com/wpa/qunwpa?idkey=fd330a4cde723adbc4483a56c9db1118a3fd9e6a26b80e41f566448b05ca4da0"）
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://ss.nacg.top"）
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://t667.com"）
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        My.Computer.FileSystem.DeleteFile("kps.exe")
        FileSystem.FileCopy("pak_kb99.dat", "brook.exe")
        FileSystem.FileCopy("pak_kb01.dat", "kps.exe")
        Label5.Text = "模式4、5安装成功！"
        Label9.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
