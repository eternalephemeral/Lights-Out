Imports System.Windows.Forms

Public Class SelectLevelform

    Public page As Integer = 1
    Dim button As String = "sl"
    Dim avgstar As Integer

    Private Sub SelectLevelform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        avgstar = 0
        HideLockedLevels()
        LevelColour()

        For a = 1 To 50
            avgstar = avgstar + Main.LevelsUnlocked(a)
        Next

        avgstar = Int(avgstar / 50)

        Select Case avgstar
            Case 0
                avgstarpb.Image = My.Resources._0star
            Case 1
                avgstarpb.Image = My.Resources._1star
            Case 2
                avgstarpb.Image = My.Resources._2star
            Case 3
                avgstarpb.Image = My.Resources._3star
            Case 4
                avgstarpb.Image = My.Resources._4star
            Case Else
                avgstarpb.Image = My.Resources._0star
        End Select

    End Sub


    Private Sub LevelClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                sl1.Click, sl2.Click, sl3.Click, sl4.Click, sl5.Click, _
                sl6.Click, sl7.Click, sl8.Click, sl9.Click, sl10.Click, _
                sl11.Click, sl12.Click, sl13.Click, sl14.Click, sl15.Click, _
                sl16.Click, sl17.Click, sl18.Click, sl19.Click, sl20.Click, _
                sl21.Click, sl22.Click, sl23.Click, sl24.Click, sl25.Click
        Main.LeveltoLoad = sender.text
        Me.Close()
    End Sub

    Private Sub SwitchSelectLevelPage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slnext.Click

        Dim a As Integer

        If page = 1 Then
            page = 2
            slnext.Text = "Previous"
        Else
            page = 1
            slnext.Text = "Next"
        End If

        For a = 1 To 25
            Controls(button & a).Text = a + (page - 1) * 25
        Next

        HideLockedLevels()
        LevelColour()

    End Sub

    Private Sub HideLockedLevels()
        Dim a As Integer
        Dim b As Integer
        Dim lockpoint As Integer

        For a = 1 To 51
            If Main.LevelsUnlocked(a) = 0 Then
                lockpoint = a + 1
                Exit For
            End If
        Next
        If lockpoint > 26 Then
            slnext.Show()
            lockpoint = 26
            If page = 2 Then
                For a = 1 To 25
                    If Main.LevelsUnlocked(a + 25) = 0 Then
                        lockpoint = a + 1
                        Exit For
                    End If
                Next
            End If
        Else
            slnext.Hide()
        End If


        For b = 1 To lockpoint - 1
            Controls(button & b).Show()
        Next

        For b = lockpoint To 25
            Controls(button & b).Hide()
        Next



    End Sub
    Private Sub LevelColour()
        Dim a As Integer
        For a = 1 To 25
            Controls(button & a).BackColor = Main.Colours(Main.LevelsUnlocked(a + (page - 1) * 25))
        Next
    End Sub

End Class
