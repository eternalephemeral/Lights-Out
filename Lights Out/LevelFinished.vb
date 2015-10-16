Public Class LevelFinishedform

    Private Sub LevelFinishedform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LFlbl.Text = "Level Cleared!"
        LFlbl.Location = New Point(93, 66)

        LFContinue.Show()
        Select Case Main.RecentStarRating
            Case 0
                LFStar.Image = My.Resources._0star
                LFlbl.Location = New Point(85, 66)
                LFlbl.Text = "Too Many Moves!"
                LFContinue.Hide()
                Exit Sub
            Case 1
                LFStar.Image = My.Resources._1star
            Case 2
                LFStar.Image = My.Resources._2star
            Case 3
                LFStar.Image = My.Resources._3star
            Case 4
                LFStar.Image = My.Resources._4star
        End Select
        If Main.CurrentLevel = 50 Then
            LFlbl.Location = New Point(20, 66)
            LFlbl.Text = "Congratulations, You Have Beaten Light's Out!"
            LFContinue.Hide()
        End If

    End Sub

    Private Sub LFRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFRestart.Click
        Main.LevelFinishedAction = 1
        Me.Close()
    End Sub

    Private Sub LFContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFContinue.Click
        Main.LevelFinishedAction = 2
        Me.Close()
    End Sub

    Private Sub LFSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFSelect.Click
        Main.LevelFinishedAction = 3
        Me.Close()
    End Sub
End Class