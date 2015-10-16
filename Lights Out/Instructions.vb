Public Class Instructionsform

    Private Sub Instructionsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InstCB.Checked = My.Settings.ShowInstructions
    End Sub

    Private Sub InstCB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstCB.Click
        My.Settings.ShowInstructions = InstCB.Checked
        My.Settings.Save()
    End Sub

    Private Sub instructionsok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instructionsok.Click
        Me.Close()
    End Sub
End Class