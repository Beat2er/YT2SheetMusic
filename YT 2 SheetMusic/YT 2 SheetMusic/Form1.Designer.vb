<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.AnzahlAufSeite = New System.Windows.Forms.TrackBar()
        Me.CropLeft = New System.Windows.Forms.TrackBar()
        Me.CropTop = New System.Windows.Forms.TrackBar()
        Me.LogBox = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ComparisonSensitivity = New System.Windows.Forms.TrackBar()
        Me.CropRight = New System.Windows.Forms.TrackBar()
        Me.CropBottom = New System.Windows.Forms.TrackBar()
        Me.CheckStopForSelecting = New System.Windows.Forms.CheckBox()
        Me.GoOnButton = New System.Windows.Forms.Button()
        Me.LogPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ImagesPerTen = New System.Windows.Forms.TrackBar()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FileOpenDialogButton = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.OpenOutput = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AnzahlAufSeite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CropLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CropTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComparisonSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CropRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CropBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagesPerTen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(825, 20)
        Me.TextBox1.TabIndex = 0
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 40)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'AnzahlAufSeite
        '
        Me.AnzahlAufSeite.Location = New System.Drawing.Point(110, 42)
        Me.AnzahlAufSeite.Minimum = 1
        Me.AnzahlAufSeite.Name = "AnzahlAufSeite"
        Me.AnzahlAufSeite.Size = New System.Drawing.Size(104, 45)
        Me.AnzahlAufSeite.TabIndex = 2
        Me.AnzahlAufSeite.Value = 5
        '
        'CropLeft
        '
        Me.CropLeft.Location = New System.Drawing.Point(121, 3)
        Me.CropLeft.Maximum = 50
        Me.CropLeft.Name = "CropLeft"
        Me.CropLeft.Size = New System.Drawing.Size(75, 45)
        Me.CropLeft.TabIndex = 3
        '
        'CropTop
        '
        Me.CropTop.Location = New System.Drawing.Point(287, 3)
        Me.CropTop.Maximum = 50
        Me.CropTop.Name = "CropTop"
        Me.CropTop.Size = New System.Drawing.Size(75, 45)
        Me.CropTop.TabIndex = 4
        '
        'LogBox
        '
        Me.LogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogBox.Location = New System.Drawing.Point(0, 0)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(884, 130)
        Me.LogBox.TabIndex = 5
        Me.LogBox.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "One Long Page"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"best quality"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 60)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Load qualities"
        '
        'ComparisonSensitivity
        '
        Me.ComparisonSensitivity.Location = New System.Drawing.Point(6, 42)
        Me.ComparisonSensitivity.Maximum = 100
        Me.ComparisonSensitivity.Name = "ComparisonSensitivity"
        Me.ComparisonSensitivity.Size = New System.Drawing.Size(104, 45)
        Me.ComparisonSensitivity.TabIndex = 9
        Me.ComparisonSensitivity.Value = 10
        '
        'CropRight
        '
        Me.CropRight.Location = New System.Drawing.Point(121, 51)
        Me.CropRight.Maximum = 50
        Me.CropRight.Name = "CropRight"
        Me.CropRight.Size = New System.Drawing.Size(75, 45)
        Me.CropRight.TabIndex = 10
        '
        'CropBottom
        '
        Me.CropBottom.Location = New System.Drawing.Point(287, 51)
        Me.CropBottom.Maximum = 50
        Me.CropBottom.Name = "CropBottom"
        Me.CropBottom.Size = New System.Drawing.Size(75, 45)
        Me.CropBottom.TabIndex = 11
        '
        'CheckStopForSelecting
        '
        Me.CheckStopForSelecting.AutoSize = True
        Me.CheckStopForSelecting.Checked = True
        Me.CheckStopForSelecting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckStopForSelecting.Location = New System.Drawing.Point(6, 38)
        Me.CheckStopForSelecting.Name = "CheckStopForSelecting"
        Me.CheckStopForSelecting.Size = New System.Drawing.Size(161, 17)
        Me.CheckStopForSelecting.TabIndex = 12
        Me.CheckStopForSelecting.Text = "Halt to let user select images"
        Me.CheckStopForSelecting.UseVisualStyleBackColor = True
        '
        'GoOnButton
        '
        Me.GoOnButton.Location = New System.Drawing.Point(12, 69)
        Me.GoOnButton.Name = "GoOnButton"
        Me.GoOnButton.Size = New System.Drawing.Size(75, 23)
        Me.GoOnButton.TabIndex = 13
        Me.GoOnButton.Text = "Go on"
        Me.GoOnButton.UseVisualStyleBackColor = True
        Me.GoOnButton.Visible = False
        '
        'LogPanel
        '
        Me.LogPanel.Controls.Add(Me.LogBox)
        Me.LogPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogPanel.Location = New System.Drawing.Point(0, 271)
        Me.LogPanel.Name = "LogPanel"
        Me.LogPanel.Size = New System.Drawing.Size(884, 130)
        Me.LogPanel.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.FileOpenDialogButton)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.StartButton)
        Me.Panel2.Controls.Add(Me.GoOnButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 271)
        Me.Panel2.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.ImagesPerTen)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(463, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 100)
        Me.Panel1.TabIndex = 19
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Images per 10 sec"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(55, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "10"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(100, 81)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 9)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "100"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(9, 9)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "1"
        '
        'ImagesPerTen
        '
        Me.ImagesPerTen.Location = New System.Drawing.Point(9, 52)
        Me.ImagesPerTen.Maximum = 100
        Me.ImagesPerTen.Minimum = 1
        Me.ImagesPerTen.Name = "ImagesPerTen"
        Me.ImagesPerTen.Size = New System.Drawing.Size(104, 45)
        Me.ImagesPerTen.TabIndex = 18
        Me.ImagesPerTen.Value = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Video to Images"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(840, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Log"
        '
        'FileOpenDialogButton
        '
        Me.FileOpenDialogButton.Location = New System.Drawing.Point(843, 14)
        Me.FileOpenDialogButton.Name = "FileOpenDialogButton"
        Me.FileOpenDialogButton.Size = New System.Drawing.Size(31, 20)
        Me.FileOpenDialogButton.TabIndex = 19
        Me.FileOpenDialogButton.Text = "..."
        Me.FileOpenDialogButton.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.OpenOutput)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.CheckStopForSelecting)
        Me.Panel7.Location = New System.Drawing.Point(674, 45)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 100)
        Me.Panel7.TabIndex = 18
        '
        'OpenOutput
        '
        Me.OpenOutput.AutoSize = True
        Me.OpenOutput.Checked = True
        Me.OpenOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OpenOutput.Location = New System.Drawing.Point(6, 59)
        Me.OpenOutput.Name = "OpenOutput"
        Me.OpenOutput.Size = New System.Drawing.Size(85, 17)
        Me.OpenOutput.TabIndex = 18
        Me.OpenOutput.Text = "Open output"
        Me.OpenOutput.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Other"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.LinkLabel1)
        Me.Panel6.Location = New System.Drawing.Point(243, 46)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Video quality"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.CropLeft)
        Me.Panel5.Controls.Add(Me.CropRight)
        Me.Panel5.Controls.Add(Me.CropTop)
        Me.Panel5.Controls.Add(Me.CropBottom)
        Me.Panel5.Location = New System.Drawing.Point(463, 151)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(410, 100)
        Me.Panel5.TabIndex = 16
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(365, 60)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 13)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(199, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 13)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(365, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(199, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(296, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(9, 9)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(297, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(9, 9)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(130, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(9, 9)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(130, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(9, 9)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Bottom:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Top:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Right:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Left:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cropping"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ComparisonSensitivity)
        Me.Panel4.Location = New System.Drawing.Point(243, 151)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 16
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(47, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 13)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "10"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(86, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 9)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "High"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 9)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Low"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sensitivity comparing images"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.AnzahlAufSeite)
        Me.Panel3.Location = New System.Drawing.Point(12, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 100)
        Me.Panel3.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(151, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(196, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 9)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(118, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(9, 9)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Images per PDF page"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 401)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LogPanel)
        Me.MaximumSize = New System.Drawing.Size(900, 440)
        Me.MinimumSize = New System.Drawing.Size(900, 440)
        Me.Name = "Form1"
        Me.Text = "YT2SheetMusic"
        CType(Me.AnzahlAufSeite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CropLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CropTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComparisonSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CropRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CropBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImagesPerTen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents AnzahlAufSeite As TrackBar
    Friend WithEvents CropLeft As TrackBar
    Friend WithEvents CropTop As TrackBar
    Friend WithEvents LogBox As RichTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComparisonSensitivity As TrackBar
    Friend WithEvents CropRight As TrackBar
    Friend WithEvents CropBottom As TrackBar
    Friend WithEvents CheckStopForSelecting As CheckBox
    Friend WithEvents GoOnButton As Button
    Friend WithEvents LogPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FileOpenDialogButton As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenOutput As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ImagesPerTen As TrackBar
    Friend WithEvents Label20 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
End Class
