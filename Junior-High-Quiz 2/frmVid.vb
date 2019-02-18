Imports AxWMPLib

Public Class frmVid
    Private Sub frmVid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.AxWMP.Ctlcontrols.stop()
        'vidcount += 1
        'If System.IO.File.Exists(Application.StartupPath + "\vid\vid" + vidcount.ToString + ".mp4") = False Then vidcount = 1
        'AxWindowsMediaPlayer1.URL = Application.StartupPath + "\vid\vid" + vidcount.ToString + ".mp4"
        'AxWindowsMediaPlayer1.Ctlcontrols.play()
        vidSubj()
    End Sub
    Private Sub vidSubj()
        Dim vidSubjFile As String = Application.StartupPath + "\vid\" + frmQuiz.lblTitle.Text + ".mp4"
        If System.IO.File.Exists(vidSubjFile) = True Then
            AxWindowsMediaPlayer1.URL = vidSubjFile
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            exitMe()
        End If
    End Sub
    Private Sub exitMe()
        Form1.AxWMP.Ctlcontrols.play()
        frmQuiz.Timer1.Enabled = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        exitMe()
    End Sub
    Private Sub AxWindowsMediaPlayer1_EndOfStream(sender As Object, e As _WMPOCXEvents_EndOfStreamEvent) Handles AxWindowsMediaPlayer1.EndOfStream
        Form1.AxWMP.Ctlcontrols.play()
        frmQuiz.Timer1.Enabled = True
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
End Class