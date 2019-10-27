Imports System.IO
Imports VideoLibrary
Imports ImageMagick
Imports System.Collections
Imports System.Xml
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.Globalization
Imports Org.pdfclown
Imports System.Text
Imports System.ComponentModel

Public Class Form1
    Dim livingThread As Thread
    Dim wait = True
    Sub keepingAlive()
        Do
            Thread.Sleep(100)
            Application.DoEvents()
        Loop
    End Sub
    Sub log(ByVal log As String)
        LogBox.Text += log & Environment.NewLine
        LogBox.SelectionStart = LogBox.Text.Length
        LogBox.ScrollToCaret()
    End Sub

    Sub toggleinput(ByVal enable As Boolean)
        StartButton.Enabled = enable
        CheckBox1.Enabled = enable
        ComboBox1.Enabled = enable
        LinkLabel1.Enabled = enable
        AnzahlAufSeite.Enabled = enable
        ComparisonSensitivity.Enabled = enable
        CropBottom.Enabled = enable
        CropLeft.Enabled = enable
        CropRight.Enabled = enable
        CropTop.Enabled = enable
        CheckStopForSelecting.Enabled = enable
        TextBox1.Enabled = enable
        ImagesPerTen.Enabled = enable
        OpenOutput.Enabled = enable
        FileOpenDialogButton.Enabled = enable
    End Sub
    Sub task()
        toggleinput(False)

        log("Starting...")

        Dim tmpPath = My.Application.Info.DirectoryPath & "\tmp\"
        Dim picsPath = My.Application.Info.DirectoryPath & "\tmp\pics\"
        Dim pics2Path = My.Application.Info.DirectoryPath & "\tmp\pics2\"
        Dim pics3Path = My.Application.Info.DirectoryPath & "\tmp\pics3\"
        Dim videoPath = tmpPath & "video.mp4"

        If My.Computer.FileSystem.DirectoryExists(tmpPath) Then
            log("Deleting tmp Folder...")
            My.Computer.FileSystem.DeleteDirectory(tmpPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Thread.Sleep(100)

        End If
        log("Creating tmp Folder...")
        FileSystem.MkDir(tmpPath)
        If My.Computer.FileSystem.FileExists(TextBox1.Text) Then
            videoPath = tmpPath & "video." & New FileInfo(TextBox1.Text).Extension
            My.Computer.FileSystem.CopyFile(TextBox1.Text, videoPath)
        Else
            SaveVideoToDisk(TextBox1.Text, videoPath)
        End If

        log("Creating pics Folder...")
        FileSystem.MkDir(picsPath)

        video_to_pics(videoPath, picsPath)
        delete_images(picsPath)

        resize_images(picsPath)
        If CheckStopForSelecting.Checked Then
            wait = True
            GoOnButton.Visible = True
            MsgBox("After you press ""OK"" a folder will open. Delete all images you don't want in the PDF (e.g. intro frames). When you are finished press ""Go on"".")
            Process.Start(picsPath)
            While wait
                Application.DoEvents()
            End While
            GoOnButton.Visible = False
        End If
        log("Creating pics2 Folder...")
        FileSystem.MkDir(pics2Path)
        images_format(picsPath, pics2Path)
        log("Creating pics3 Folder...")
        FileSystem.MkDir(pics3Path)
        convert_pics(pics2Path, pics3Path)
        images_to_pdf(pics3Path, tmpPath & "finished.pdf")
        If OpenOutput.Checked Then
            Process.Start(tmpPath & "finished.pdf")
        End If
        log("Finished...")
        toggleinput(True)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        task()
        Exit Sub
        Dim t As New Thread(AddressOf task)
        t.Start()
    End Sub
    Sub SaveVideoToDisk(ByVal link As String, ByVal output As String)
        log("Getting Video Data...")
        Dim videos = YouTube.Default.GetAllVideos(link)
        Dim max = -100
        For Each video In videos
            max = Math.Max(max, video.Resolution)
        Next
        For Each video In videos
            If ComboBox1.Text = "best quality" Then
                If video.Resolution = max Then
                    log("Downloading Video...")
                    File.WriteAllBytes(output, video.GetBytes())
                    log("Download finished...")
                    Exit Sub
                End If
            Else
                If video.Resolution = ComboBox1.Text Then
                    log("Downloading Video...")
                    File.WriteAllBytes(output, video.GetBytes())
                    log("Download finished...")
                    Exit Sub
                End If
            End If


        Next

    End Sub
    Sub video_to_pics(ByVal input As String, ByVal output As String)
        log("Converting video to pictures...")
        Dim _ffmpeg = My.Application.Info.DirectoryPath & "\Resources\ffmpeg.exe"
        If Not My.Computer.FileSystem.FileExists(_ffmpeg) Then
            If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Resources") Then
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Resources")
            End If
            My.Computer.FileSystem.WriteAllBytes(_ffmpeg, My.Resources.ffmpeg, False)
        End If
        Dim params = "-i """ & input & """ -r " & (ImagesPerTen.Value / 10).ToString("0.00", New CultureInfo("en-US")) & " """ & output & "/%05d.png"""
        Dim FFmpegProcess As New Process
        FFmpegProcess.StartInfo.FileName = _ffmpeg
        FFmpegProcess.StartInfo.Arguments = params
        FFmpegProcess.StartInfo.UseShellExecute = False
        FFmpegProcess.StartInfo.RedirectStandardOutput = True
        FFmpegProcess.StartInfo.RedirectStandardError = True
        FFmpegProcess.StartInfo.CreateNoWindow = True
        FFmpegProcess.EnableRaisingEvents = True
        AddHandler FFmpegProcess.ErrorDataReceived, AddressOf proc_OutputDataReceived
        AddHandler FFmpegProcess.OutputDataReceived, AddressOf proc_OutputDataReceived
        log("Starting Process...")
        FFmpegProcess.Start()
        FFmpegProcess.BeginErrorReadLine()
        FFmpegProcess.BeginOutputReadLine()

        While FFmpegProcess.HasExited = False

            Application.DoEvents()
        End While
        log("Process finished...")
    End Sub

    Sub convert_pics(ByVal inputfolder As String, ByVal outputfolder As String)
        log("Converting pictures...")
        Dim di As New IO.DirectoryInfo(inputfolder)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
        Dim fi As IO.FileInfo
        Dim toDelete As List(Of String) = New List(Of String)
        Dim last As IO.FileInfo
        Dim encoderParameters = New EncoderParameters(1)
        Dim encoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
        Dim encoderParameter = New EncoderParameter(encoder, 100L)

        encoderParameters.Param(0) = encoderParameter
        For Each fi In aryFi
            Dim SourceImg As Image
            SourceImg = Image.FromFile(fi.FullName)

            SourceImg.Save(outputfolder & fi.Name.Substring(0, fi.Name.Length - 3) & "jpg", GetEncoder(ImageFormat.Jpeg), encoderParameters)
        Next
        log("Converting pictures finished...")
    End Sub

    Function GetEncoder(format As ImageFormat) As ImageCodecInfo
        Dim codecs = ImageCodecInfo.GetImageEncoders()

        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next


        Return Nothing
    End Function

    Delegate Sub UpdateTextBoxDelg(text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTextBox)
    Public Sub UpdateTextBox(text As String)
        LogBox.Text += text & Environment.NewLine
        LogBox.SelectionStart = LogBox.Text.Length
        LogBox.ScrollToCaret()
    End Sub

    Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If Me.InvokeRequired = True Then
            Me.Invoke(myDelegate, e.Data)
        Else
            UpdateTextBox(e.Data)
        End If
    End Sub

    Sub delete_images(ByVal folder As String)
        log("Comparing pictures and deleting similar ones...")
        Dim di As New IO.DirectoryInfo(folder)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
        Dim fi As IO.FileInfo
        Dim toDelete As List(Of String) = New List(Of String)
        Dim last As IO.FileInfo
        For Each fi In aryFi
            If last Is Nothing Then
            Else

                Dim oldfile = New MagickImage(last.FullName)
                Dim newfile = New MagickImage(fi.FullName)
                log(last.FullName & " & " & fi.FullName & " Similarity: " & oldfile.Compare(newfile, ErrorMetric.RootMeanSquared))
                If oldfile.Compare(newfile, ErrorMetric.RootMeanSquared) < ComparisonSensitivity.Value / 100 Then
                    log("Deleting...")
                    toDelete.Add(fi.FullName)
                End If
                oldfile.Dispose()
                newfile.Dispose()
            End If
            last = fi
        Next
        For Each file In toDelete
            My.Computer.FileSystem.DeleteFile(file)
        Next
        log("Comparing finished")
    End Sub
    Sub images_format(ByVal folder As String, ByVal outputfolder As String)
        log("Formatting pictures")
        Dim di As New IO.DirectoryInfo(folder)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
        Dim fi As IO.FileInfo
        Dim list As List(Of IO.FileInfo) = New List(Of FileInfo)
        For Each fi In aryFi
            list.Add(fi)
        Next

        For i = 0 To list.Count + AnzahlAufSeite.Value Step AnzahlAufSeite.Value
            Dim images = New MagickImageCollection()

            For e = 0 To AnzahlAufSeite.Value - 1
                If list.Count > i + e Then
                    Dim img = New MagickImage(list.Item(i + e).FullName)
                    images.Add(img)
                End If
            Next
            Dim m = New MontageSettings()
            m.BackgroundColor = MagickColors.None
            m.Shadow = False
            m.Geometry = New MagickGeometry(0, AnzahlAufSeite.Value, 0, 0)
            Try
                Dim result = images.AppendVertically()
                result.Write(outputfolder & list.Item(i).Name)
                result.Dispose()
            Catch
            End Try
            images.Dispose()

        Next
        log("Formatting finished")
    End Sub

    Sub resize_images(ByVal folder As String)
        log("Resizing pictures")


        Dim di As New IO.DirectoryInfo(folder)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
        Dim fi As IO.FileInfo
        For Each fi In aryFi

            Dim img = New MagickImage(fi.FullName)
            Dim width = img.Width
            Dim height = img.Height

            Dim m1 As New MagickGeometry(CInt(CropLeft.Value / 100 * width), CInt(CropTop.Value / 100 * height), CInt(CropRight.Value / 100 * width), CInt(CropBottom.Value / 100 * height))
            img.Crop(m1)

            img.Write(fi.FullName)
        Next



        log("Resizing finished")
    End Sub

    '    Sub images_to_pdf(ByVal folder As String, ByVal output As String)
    '        log("Creating PDF")
    '
    '
    '
    '        Dim di As New IO.DirectoryInfo(folder)
    '        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
    '        Dim fi As IO.FileInfo
    '        Dim images As List(Of String) = New List(Of String)
    '
    '        For Each fi In aryFi
    '            log("File: " & fi.FullName)
    '            images.Add(fi.FullName)
    '        Next
    '        ImageToPdfConverter.ImageToPdf(images).SaveAs(output)
    '        log("Creating PDF finished")
    '    End Sub




    Sub images_to_pdf(ByVal folder As String, ByVal output As String)
        log("Creating PDF")
        Dim jpeg2pdf = My.Application.Info.DirectoryPath & "\Resources\jpeg2pdf.exe"
        If Not My.Computer.FileSystem.FileExists(jpeg2pdf) Then
            If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Resources") Then
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Resources")
            End If
            My.Computer.FileSystem.WriteAllBytes(jpeg2pdf, My.Resources.jpeg2pdf, False)
        End If
        Dim params = "-o """ & output & """ -z fw -r height *.jpg"
        Dim jpeg2pdfProcess As New Process
        jpeg2pdfProcess.StartInfo.FileName = jpeg2pdf
        jpeg2pdfProcess.StartInfo.Arguments = params
        jpeg2pdfProcess.StartInfo.UseShellExecute = False
        jpeg2pdfProcess.StartInfo.RedirectStandardOutput = True
        jpeg2pdfProcess.StartInfo.RedirectStandardError = True
        jpeg2pdfProcess.StartInfo.CreateNoWindow = True
        jpeg2pdfProcess.EnableRaisingEvents = True
        jpeg2pdfProcess.StartInfo.WorkingDirectory = folder
        AddHandler jpeg2pdfProcess.ErrorDataReceived, AddressOf proc_OutputDataReceived
        AddHandler jpeg2pdfProcess.OutputDataReceived, AddressOf proc_OutputDataReceived
        log("Starting Process...")
        jpeg2pdfProcess.Start()
        jpeg2pdfProcess.BeginErrorReadLine()
        jpeg2pdfProcess.BeginOutputReadLine()

        While jpeg2pdfProcess.HasExited = False

            Application.DoEvents()
        End While
        log("Process finished...")
        log("Creating PDF finished")
    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        AnzahlAufSeite.Enabled = CheckBox1.Checked + 1
        If CheckBox1.Checked Then
            AnzahlAufSeite.Maximum = 9999
            AnzahlAufSeite.Value = 9999
        Else
            AnzahlAufSeite.Maximum = 10
            AnzahlAufSeite.Value = 3
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        log("Getting Video Data...")
        Dim videos = YouTube.Default.GetAllVideos(TextBox1.Text)
        ComboBox1.Items.Clear()
        For Each video In videos
            If video.Resolution > 0 Then
                log("Adding to Combobox: " & video.Resolution)
                ComboBox1.Items.Add(video.Resolution)
            End If
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboBox1.SelectedIndex = 0
        Label10_Click(sender, e)
        livingThread = New Thread(AddressOf keepingAlive)
        livingThread.Start()
    End Sub


    Private Sub GoOnButton_Click(sender As Object, e As EventArgs) Handles GoOnButton.Click
        wait = False
    End Sub

    Private Sub FileOpenDialogButton_Click(sender As Object, e As EventArgs) Handles FileOpenDialogButton.Click
        Dim fod = New OpenFileDialog
        fod.Filter = "Standard Videos|*.mp4;*.webm;*.avi;*.gif;*.mpg;*.mpeg;*.m4p;*.m4v;*.wmv;*.flv"
        Dim result = fod.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = fod.FileName
            TextBox1.Text = path
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        LogPanel.Visible += 1
        If LogPanel.Visible Then
            Dim s = New Size(900, 440)
            Me.MinimumSize = s
            Me.MaximumSize = s
            Me.Size = s
        Else
            Dim s = New Size(900, 440 - LogPanel.Size.Height)
            Me.MinimumSize = s
            Me.MaximumSize = s
            Me.Size = s
        End If
    End Sub

    Private Sub AnzahlAufSeite_Scroll(sender As Object, e As EventArgs) Handles AnzahlAufSeite.Scroll
        Label19.Text = AnzahlAufSeite.Value
    End Sub

    Private Sub ImagesPerTen_Scroll(sender As Object, e As EventArgs) Handles ImagesPerTen.Scroll
        Label21.Text = ImagesPerTen.Value
    End Sub


    Private Sub CropLeft_Scroll(sender As Object, e As EventArgs) Handles CropLeft.Scroll
        Label25.Text = CropLeft.Value
    End Sub

    Private Sub CropTop_Scroll(sender As Object, e As EventArgs) Handles CropTop.Scroll
        Label26.Text = CropTop.Value
    End Sub

    Private Sub CropRight_Scroll(sender As Object, e As EventArgs) Handles CropRight.Scroll
        Label27.Text = CropRight.Value
    End Sub

    Private Sub CropBottom_Scroll(sender As Object, e As EventArgs) Handles CropBottom.Scroll
        Label28.Text = CropBottom.Value
    End Sub

    Private Sub ComparisonSensitivity_Scroll(sender As Object, e As EventArgs) Handles ComparisonSensitivity.Scroll
        Label29.Text = ComparisonSensitivity.Value
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        livingThread.Suspend()
    End Sub
End Class
