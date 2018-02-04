<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QUANLYNHANVIEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QUANLYNHANVIEN))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tracuu = New System.Windows.Forms.Button()
        Me.tracuutennhanvien = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chon = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hotennhanvien = New System.Windows.Forms.TextBox()
        Me.manhanvien = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dienthoai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tienluong = New System.Windows.Forms.TextBox()
        Me.diachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Them = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.Khongluu = New System.Windows.Forms.Button()
        Me.Luu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Import = New System.Windows.Forms.Button()
        Me.HIENTHI = New System.Windows.Forms.Button()
        Me.Xoatrang = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tracuu
        '
        Me.tracuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tracuu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tracuu.Location = New System.Drawing.Point(74, 50)
        Me.tracuu.Name = "tracuu"
        Me.tracuu.Size = New System.Drawing.Size(112, 40)
        Me.tracuu.TabIndex = 44
        Me.tracuu.Text = "Tra cứu"
        Me.tracuu.UseVisualStyleBackColor = True
        '
        'tracuutennhanvien
        '
        Me.tracuutennhanvien.BackColor = System.Drawing.Color.White
        Me.tracuutennhanvien.Cursor = System.Windows.Forms.Cursors.Default
        Me.tracuutennhanvien.ForeColor = System.Drawing.Color.Black
        Me.tracuutennhanvien.Location = New System.Drawing.Point(117, 18)
        Me.tracuutennhanvien.Name = "tracuutennhanvien"
        Me.tracuutennhanvien.Size = New System.Drawing.Size(141, 26)
        Me.tracuutennhanvien.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 14)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "TÊN NHÂN VIÊN"
        '
        'chon
        '
        Me.chon.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.chon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chon.Location = New System.Drawing.Point(846, 536)
        Me.chon.Name = "chon"
        Me.chon.Size = New System.Drawing.Size(112, 37)
        Me.chon.TabIndex = 56
        Me.chon.Text = "Chọn"
        Me.chon.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tracuu)
        Me.GroupBox4.Controls.Add(Me.tracuutennhanvien)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox4.Location = New System.Drawing.Point(840, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 108)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tra cứu"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(421, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 31)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "QUẢN LÝ NHÂN VIÊN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Luoi)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(17, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 422)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.BackgroundColor = System.Drawing.Color.Gray
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Luoi.GridColor = System.Drawing.Color.White
        Me.Luoi.Location = New System.Drawing.Point(6, 13)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(788, 403)
        Me.Luoi.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Manhanvien"
        Me.Column1.HeaderText = "Mã nhân viên"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Hotennhanvien"
        Me.Column2.HeaderText = "Họ tên nhân viên"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Diachi"
        Me.Column3.HeaderText = "Địa chỉ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Dienthoai"
        Me.Column4.HeaderText = "Điện thoại"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "Email"
        Me.Column5.HeaderText = "Email"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Tienluong"
        Me.Column6.HeaderText = "Tiền lương"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.hotennhanvien)
        Me.GroupBox1.Controls.Add(Me.manhanvien)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dienthoai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tienluong)
        Me.GroupBox1.Controls.Add(Me.diachi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 117)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin nhân viên"
        '
        'email
        '
        Me.email.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(581, 47)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(204, 26)
        Me.email.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "EMAIL"
        '
        'hotennhanvien
        '
        Me.hotennhanvien.BackColor = System.Drawing.Color.White
        Me.hotennhanvien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hotennhanvien.ForeColor = System.Drawing.Color.Black
        Me.hotennhanvien.Location = New System.Drawing.Point(187, 50)
        Me.hotennhanvien.Name = "hotennhanvien"
        Me.hotennhanvien.Size = New System.Drawing.Size(204, 26)
        Me.hotennhanvien.TabIndex = 22
        '
        'manhanvien
        '
        Me.manhanvien.BackColor = System.Drawing.Color.White
        Me.manhanvien.Enabled = False
        Me.manhanvien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manhanvien.ForeColor = System.Drawing.Color.Black
        Me.manhanvien.Location = New System.Drawing.Point(187, 16)
        Me.manhanvien.Name = "manhanvien"
        Me.manhanvien.Size = New System.Drawing.Size(108, 26)
        Me.manhanvien.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "MÃ NHÂN VIÊN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "HỌ TÊN NHÂN VIÊN"
        '
        'dienthoai
        '
        Me.dienthoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dienthoai.BackColor = System.Drawing.Color.White
        Me.dienthoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dienthoai.ForeColor = System.Drawing.Color.Black
        Me.dienthoai.Location = New System.Drawing.Point(581, 15)
        Me.dienthoai.Name = "dienthoai"
        Me.dienthoai.Size = New System.Drawing.Size(204, 26)
        Me.dienthoai.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ĐỊA CHỈ"
        '
        'tienluong
        '
        Me.tienluong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tienluong.BackColor = System.Drawing.Color.White
        Me.tienluong.Enabled = False
        Me.tienluong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tienluong.ForeColor = System.Drawing.Color.Black
        Me.tienluong.Location = New System.Drawing.Point(581, 79)
        Me.tienluong.Name = "tienluong"
        Me.tienluong.Size = New System.Drawing.Size(204, 26)
        Me.tienluong.TabIndex = 25
        '
        'diachi
        '
        Me.diachi.BackColor = System.Drawing.Color.White
        Me.diachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diachi.ForeColor = System.Drawing.Color.Black
        Me.diachi.Location = New System.Drawing.Point(187, 82)
        Me.diachi.Name = "diachi"
        Me.diachi.Size = New System.Drawing.Size(204, 26)
        Me.diachi.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ĐIỆN THOẠI"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(471, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TIỀN LƯƠNG"
        '
        'Thoat
        '
        Me.Thoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(986, 536)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(112, 37)
        Me.Thoat.TabIndex = 50
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Them
        '
        Me.Them.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Them.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Them.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Them.Location = New System.Drawing.Point(6, 19)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(112, 37)
        Me.Them.TabIndex = 23
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Xoa
        '
        Me.Xoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Xoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Xoa.Location = New System.Drawing.Point(146, 19)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(112, 37)
        Me.Xoa.TabIndex = 32
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Sua
        '
        Me.Sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sua.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sua.Location = New System.Drawing.Point(6, 72)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(112, 37)
        Me.Sua.TabIndex = 33
        Me.Sua.Text = "Sửa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'Khongluu
        '
        Me.Khongluu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Khongluu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Khongluu.Location = New System.Drawing.Point(6, 244)
        Me.Khongluu.Name = "Khongluu"
        Me.Khongluu.Size = New System.Drawing.Size(112, 37)
        Me.Khongluu.TabIndex = 48
        Me.Khongluu.Text = "Kết thúc"
        Me.Khongluu.UseVisualStyleBackColor = True
        '
        'Luu
        '
        Me.Luu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Luu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Luu.Location = New System.Drawing.Point(146, 244)
        Me.Luu.Name = "Luu"
        Me.Luu.Size = New System.Drawing.Size(112, 37)
        Me.Luu.TabIndex = 43
        Me.Luu.Text = "Lưu"
        Me.Luu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Import)
        Me.GroupBox2.Controls.Add(Me.HIENTHI)
        Me.GroupBox2.Controls.Add(Me.Xoatrang)
        Me.GroupBox2.Controls.Add(Me.Khongluu)
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.Xoa)
        Me.GroupBox2.Controls.Add(Me.Sua)
        Me.GroupBox2.Controls.Add(Me.Luu)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Location = New System.Drawing.Point(840, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 352)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'Import
        '
        Me.Import.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Import.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Import.Location = New System.Drawing.Point(6, 127)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(112, 37)
        Me.Import.TabIndex = 51
        Me.Import.Text = "Tải dữ liệu"
        Me.Import.UseVisualStyleBackColor = True
        '
        'HIENTHI
        '
        Me.HIENTHI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HIENTHI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HIENTHI.Location = New System.Drawing.Point(61, 287)
        Me.HIENTHI.Name = "HIENTHI"
        Me.HIENTHI.Size = New System.Drawing.Size(142, 37)
        Me.HIENTHI.TabIndex = 50
        Me.HIENTHI.Text = "Hiển thị tất cả"
        Me.HIENTHI.UseVisualStyleBackColor = True
        '
        'Xoatrang
        '
        Me.Xoatrang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoatrang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Xoatrang.Location = New System.Drawing.Point(146, 72)
        Me.Xoatrang.Name = "Xoatrang"
        Me.Xoatrang.Size = New System.Drawing.Size(112, 37)
        Me.Xoatrang.TabIndex = 49
        Me.Xoatrang.Text = "Xóa trắng"
        Me.Xoatrang.UseVisualStyleBackColor = True
        '
        'QUANLYNHANVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(1116, 589)
        Me.Controls.Add(Me.chon)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QUANLYNHANVIEN"
        Me.Text = "QUANLYNHANVIEN"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tracuu As Button
    Friend WithEvents tracuutennhanvien As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents chon As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Luoi As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents email As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents hotennhanvien As TextBox
    Friend WithEvents manhanvien As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents dienthoai As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents tienluong As TextBox
    Private WithEvents diachi As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents Thoat As Button
    Friend WithEvents Them As Button
    Friend WithEvents Xoa As Button
    Friend WithEvents Sua As Button
    Friend WithEvents Khongluu As Button
    Friend WithEvents Luu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Import As Button
    Friend WithEvents HIENTHI As Button
    Friend WithEvents Xoatrang As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
