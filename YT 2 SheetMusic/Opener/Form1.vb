Public Class Opener
    Private Sub Opener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\YT2SheetMusic") Then
            FileSystem.MkDir(My.Application.Info.DirectoryPath & "\YT2SheetMusic")
            My.Computer.FileSystem.WriteAllBytes(My.Application.Info.DirectoryPath & "\YT2SheetMusic\YT2SheetMusic.exe", My.Resources.YT_2_SheetMusic, False)
            My.Computer.FileSystem.WriteAllBytes(My.Application.Info.DirectoryPath & "\YT2SheetMusic\IronPdf.dll", My.Resources.IronPdf, False)
            My.Computer.FileSystem.WriteAllBytes(My.Application.Info.DirectoryPath & "\YT2SheetMusic\libvideo.compat.dll", My.Resources.libvideo_compat, False)
            My.Computer.FileSystem.WriteAllBytes(My.Application.Info.DirectoryPath & "\YT2SheetMusic\libvideo.dll", My.Resources.libvideo, False)
            My.Computer.FileSystem.WriteAllBytes(My.Application.Info.DirectoryPath & "\YT2SheetMusic\Magick.NET-Q8-AnyCPU.dll", My.Resources.Magick_NET_Q8_AnyCPU, False)

        End If
        Process.Start(My.Application.Info.DirectoryPath & "\YT2SheetMusic\YT2SheetMusic.exe")
        Environment.Exit(0)
    End Sub
End Class
