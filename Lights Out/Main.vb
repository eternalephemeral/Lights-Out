Public Class Main

    Dim OnColor As Color
    Dim OffColor As Color
    Dim DotImage As Image
    Dim Switch(5, 5) As Byte
    Dim MaxLevelMoves(50) As Integer
    Dim MovesLeft As Integer
    Dim MovesLeftColourChg(3) As Integer
    Public CurrentLevel As Integer
    Public LevelsUnlocked(51) As Byte
    Public LeveltoLoad As Integer
    Public Colours(4) As Color
    Public LevelFinishedAction As Byte
    Public RecentStarRating As Byte
    Dim ALSwitch(5, 5) As Byte  'array for the solving algorism
    Dim ALMoves(4) As String    'array to store the moves solution
    Dim ALTop(5) As Byte        'another array for solving algorism
    Dim QPSet As Byte           '(Quiet Pattern)
    Dim version As String = "Version 2.1"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        OnColor = Color.Red
        OffColor = Color.Blue
        DotImage = My.Resources.dot
        Colours(0) = Color.White      'not beaten yet
        Colours(1) = Color.Red        '1 star
        Colours(2) = Color.DarkOrange '2 star
        Colours(3) = Color.Green      '3 star
        Colours(4) = Color.Blue       '4 star
        MovesLeftColourChg(1) = 14  '1-2 stars
        MovesLeftColourChg(2) = 10  '2-3 stars
        MovesLeftColourChg(3) = 6   '3-4 stars
        For a = 1 To 50
            MaxLevelMoves(a) = 18 + Int(a / 5 - 0.01)
        Next
        ClearLevel()
        CleanInterface()

        For a = 1 To 50 : LevelsUnlocked(a) = My.Settings.LevelsUnlocked(a) : Next a

    End Sub
    'Main Toggle Code
    Private Sub LightSwtich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                LS11.Click, LS12.Click, LS13.Click, LS14.Click, LS15.Click, _
                LS21.Click, LS22.Click, LS23.Click, LS24.Click, LS25.Click, _
                LS31.Click, LS32.Click, LS33.Click, LS34.Click, LS35.Click, _
                LS41.Click, LS42.Click, LS43.Click, LS44.Click, LS45.Click, _
                LS51.Click, LS52.Click, LS53.Click, LS54.Click, LS55.Click

        'If sender.backgroundimage.Equals(DotImage) Then
        '    MsgBox("t")
        'End If


        ToggleSurroundings(Mid(sender.Tag, 1, 1), Mid(sender.Tag, 2, 1))
    End Sub
    Private Sub ToggleSurroundings(ByVal X As Byte, ByVal Y As Byte)

        'If Controls("LS" & X & Y).BackgroundImage.Equals(DotImage) Then

        'End If

        ToggleBttn(X, Y, Controls("LS" & X & Y))
        If X + 1 <= 5 Then ToggleBttn(X + 1, Y, Controls("LS" & X + 1 & Y))
        If X - 1 >= 1 Then ToggleBttn(X - 1, Y, Controls("LS" & X - 1 & Y))
        If Y + 1 <= 5 Then ToggleBttn(X, Y + 1, Controls("LS" & X & Y + 1))
        If Y - 1 >= 1 Then ToggleBttn(X, Y - 1, Controls("LS" & X & Y - 1))
        If CurrentLevel = 0 Then Exit Sub
        MovesCounterDecrease()
        CheckIfCleared()
    End Sub

    'Toggle Code
    Private Sub ToggleBttn(ByVal X As Byte, ByVal Y As Byte, ByVal sender As System.Object)
        If Switch(X, Y) = 1 Then
            sender.BackColor = OffColor
            Switch(X, Y) = 0
        Else
            sender.BackColor = OnColor
            Switch(X, Y) = 1
        End If
    End Sub

    Private Sub RestartLevel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restartbttn.Click, menurestart.Click
        ClearLevel()
        ChangeLevel(CurrentLevel)
        ResetLights()
        If CurrentLevel = 0 Then Exit Sub
        levellbl.Text = "Level " & CurrentLevel
        ResetMovesCounter()
        ResetStarRating()
        DisableButtons()
    End Sub

    Private Sub NextLevel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbttn.Click
        If CurrentLevel = 0 Then Exit Sub
        ClearLevel()
        CurrentLevel = CurrentLevel + 1
        ChangeLevel(CurrentLevel)
        ResetLights()
        levellbl.Text = "Level " & CurrentLevel
        ResetMovesCounter()
        ResetStarRating()
        DisableButtons()
    End Sub

    Private Sub PreviousLevel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previousbttn.Click
        If CurrentLevel = 0 Then Exit Sub
        ClearLevel()
        CurrentLevel = CurrentLevel - 1
        ChangeLevel(CurrentLevel)
        ResetLights()
        levellbl.Text = "Level " & CurrentLevel
        ResetMovesCounter()
        ResetStarRating()
        DisableButtons()
    End Sub

    Private Sub LoadLevel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuselect.Click
        SelectLevelform.ShowDialog()
        CurrentLevel = LeveltoLoad
        If CurrentLevel = 0 Then Exit Sub
        ClearLevel()
        ChangeLevel(CurrentLevel)
        ResetLights()
        levellbl.Text = "Level " & CurrentLevel
        ResetMovesCounter()
        ResetStarRating()
        DisableButtons()
    End Sub

    Private Sub UnlockLevel(ByVal level As Integer, ByVal colourid As Byte)
        LevelsUnlocked(level) = colourid
    End Sub

    Private Sub ClearLevel()
        Dim a As Integer
        Dim b As Integer
        For a = 1 To 5
            For b = 1 To 5
                Switch(a, b) = 0
                Controls("LS" & a & b).BackColor = OffColor
                Controls("LS" & a & b).BackgroundImage = Nothing
            Next b
        Next a
        menusolve.Checked = False
    End Sub

    Sub ResetLights()
        Dim a As Integer
        Dim b As Integer
        For a = 1 To 5
            For b = 1 To 5
                If Switch(a, b) = 1 Then
                    Controls("LS" & a & b).BackColor = OnColor
                Else
                    Controls("LS" & a & b).BackColor = OffColor
                End If
                Controls("LS" & a & b).BackgroundImage = Nothing
            Next b
        Next a
        menusolve.Checked = False
    End Sub
    Private Sub DisableButtons()
        nextbttn.Enabled = True
        previousbttn.Enabled = True
        If CurrentLevel = 50 Then nextbttn.Enabled = False
        If CurrentLevel = 1 Then previousbttn.Enabled = False
        If LevelsUnlocked(CurrentLevel) = 0 Then nextbttn.Enabled = False
    End Sub
    Private Sub ResetMovesCounter()
        MovesLeft = 18 + Int(CurrentLevel / 5 - 0.01)
        movesleftlbl.Text = "Moves Available " & MovesLeft
        movesleftlbl.ForeColor = Colours(4)
    End Sub
    Private Sub ResetStarRating()
        Select Case LevelsUnlocked(CurrentLevel)
            Case 0
                starpb.Image = My.Resources._0star
            Case 1
                starpb.Image = My.Resources._1star
            Case 2
                starpb.Image = My.Resources._2star
            Case 3
                starpb.Image = My.Resources._3star
            Case 4
                starpb.Image = My.Resources._4star
        End Select
        starpb.Show()
    End Sub
    Private Sub MovesCounterDecrease()
        Dim a As Integer
        MovesLeft = MovesLeft - 1
        movesleftlbl.Text = "Moves Available " & MovesLeft
        movesleftlbl.ForeColor = Colours(4)
        For a = 3 To 1 Step -1
            If (MaxLevelMoves(CurrentLevel) - MovesLeft) > (MovesLeftColourChg(a) + Int(CurrentLevel / 5 - 0.01)) Then
                movesleftlbl.ForeColor = Colours(a)
            End If
        Next
    End Sub

    Private Sub CleanInterface()
        CurrentLevel = 0
        levellbl.Text = ""
        movesleftlbl.Text = ""
        nextbttn.Enabled = False
        previousbttn.Enabled = False
        movesleftlbl.ForeColor = Colours(4)
        starpb.Hide()
    End Sub

    Private Sub CheckIfCleared()
        Dim a As Integer
        Dim b As Integer
        Dim cleared = 1
        For a = 1 To 5
            For b = 1 To 5
                If Switch(a, b) = 1 Then cleared = 0 : Exit For
            Next b
        Next a

        If cleared = 1 Then
            For a = 1 To 4
                If movesleftlbl.ForeColor = Colours(a) Then
                    IsLevelCleared(a)
                    Exit For
                End If
            Next
        Else
            If MovesLeft <= 0 Then IsLevelCleared(0)
        End If
    End Sub

    Private Sub IsLevelCleared(ByVal colourid)
        LevelFinishedAction = 1
        RecentStarRating = colourid
        If LevelsUnlocked(CurrentLevel) < colourid Then UnlockLevel(CurrentLevel, colourid)
        If LevelsUnlocked(CurrentLevel) = 0 Then UnlockLevel(CurrentLevel + 1, 0)

        LevelFinishedform.ShowDialog()
        If LevelFinishedAction = 1 Then RestartLevel(Nothing, Nothing)
        If LevelFinishedAction = 2 Then NextLevel(Nothing, Nothing)
        If LevelFinishedAction = 3 Then LoadLevel(Nothing, Nothing)
    End Sub

    Private Sub menucleard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menucleard.Click
        Dim a As Integer
        If MsgBox("Clear Game Data?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            For a = 1 To 50 : LevelsUnlocked(a) = 0 : Next a
            ClearLevel()
            CleanInterface()
        End If
    End Sub

    Private Sub menusolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menusolve.Click
        Dim a As Integer
        Dim b As Integer
        If menusolve.Checked = False Then
            SolveAlgorithm()
            menusolve.Checked = True
        Else
            For a = 1 To 5
                For b = 1 To 5
                    Controls("LS" & a & b).BackgroundImage = Nothing
                Next
            Next
            menusolve.Checked = False
        End If
    End Sub

    Private Sub menuinst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuinst.Click
        Instructionsform.ShowDialog()
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''Solve Algorithm'''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub SolveAlgorithm() '0 = all steps, 1 = 1 step
        Dim mark As Byte
        Dim a As Integer
        Dim b As Integer
        Dim toptoggle As Byte
        Dim moveset As Integer
        Dim letter As Integer
        Dim X As Integer
        Dim Y As Integer
        QPSet = 1
        ResetAL("Top")
        ResetAL("Switch")
        ResetAL("Moves")

ChaseLights:

        mark = 0
        For b = 2 To 5
            For a = 1 To 5
                If ALSwitch(a, b - 1) = 1 Then
                    mark = 1
                    ALMoves(QPSet) = (ALMoves(QPSet) & a & b)
                    Exit For
                End If
            Next a
            If mark = 1 Then Exit For
        Next b
        If mark = 1 Then
            ALAdjacentToggle(a, b)
            GoTo [ChaseLights]
        End If

CheckLastRow:

        toptoggle = 1
        If ALSwitch(1, 5) = 1 Then
            If ALSwitch(2, 5) = 1 Then
                If ALSwitch(3, 5) = 1 Then
                    ALTop(2) = 1                                '1 1 1 0 0
                Else
                    ALTop(3) = 1                                '1 1 0 1 1
                End If
            Else
                If ALSwitch(3, 5) = 1 Then
                    ALTop(5) = 1                                '1 0 1 1 0
                Else
                    ALTop(1) = 1 : ALTop(2) = 1                 '1 0 0 0 1
                End If
            End If
        Else
            If ALSwitch(2, 5) = 1 Then
                If ALSwitch(3, 5) = 1 Then
                    ALTop(1) = 1                                '0 1 0 1 1
                Else
                    ALTop(1) = 1 : ALTop(2) = 1 : ALTop(3) = 1  '0 1 0 1 0
                End If
            Else
                If ALSwitch(3, 5) = 1 Then
                    ALTop(4) = 1                                '0 0 1 1 1
                Else
                    toptoggle = 0
                End If
            End If
        End If
        If toptoggle = 1 Then
            ResetAL("Switch")
            ResetAL("Moves")
            For a = 1 To 5
                If ALTop(a) = 1 Then
                    ALAdjacentToggle(a, 1)
                    ALMoves(QPSet) = (ALMoves(QPSet) & a & 1)
                End If
            Next a
            GoTo [ChaseLights]
        End If

ApplyQuietPatterns:
        ResetAL("Switch")
        QPSet = QPSet + 1
        Select Case QPSet
            Case 2
                QPToggle(0, 1)
                QPToggle(1, 2)
                QPToggle(0, 3)
                QPToggle(1, 4)
                QPToggle(0, 5)
            Case 3
                QPToggle(0, 1)
                QPToggle(0, 2)
                QPToggle(1, 3)
                QPToggle(0, 4)
                QPToggle(0, 5)
            Case 4
                QPToggle(1, 1)
                QPToggle(0, 2)
                QPToggle(0, 3)
                QPToggle(0, 4)
                QPToggle(1, 5)
        End Select
        If QPSet <= 4 Then GoTo [ChaseLights]

DiscardLongSolutions:
        moveset = 1
        For a = 2 To 4
            If Len(ALMoves(a)) < Len(ALMoves(moveset)) Then
                moveset = a
            End If
        Next

Finish:
        ResetLights()
        letter = 0
        While letter < Len(ALMoves(moveset))
            X = ALMoves(moveset).Substring(letter, 1)
            Y = ALMoves(moveset).Substring(letter + 1, 1)
            Controls("LS" & X & Y).BackgroundImage = DotImage
            letter = letter + 2
        End While
    End Sub

    Private Sub QPToggle(ByVal _set, ByVal X) 'Y is always 1
        If ALTop(X) = _set Then
            ALAdjacentToggle(X, 1)
            ALMoves(QPSet) = (ALMoves(QPSet) & X & 1)
        End If
    End Sub

    Private Sub ResetAL(ByVal Array)
        Dim a As Integer
        Dim b As Integer
        Select Case Array
            Case "Top"
                For a = 1 To 5
                    ALTop(a) = 0
                Next a
            Case "Switch"
                For a = 1 To 5
                    For b = 1 To 5
                        ALSwitch(a, b) = Switch(a, b)
                    Next b
                Next a
            Case "Moves"
                For a = 1 To 4
                    ALMoves(a) = ""
                Next a
        End Select
    End Sub

    Private Sub ALAdjacentToggle(ByVal X, ByVal Y)  'toggles the button and adjacent buttons
        ALToggle(X, Y)
        If X + 1 <= 5 Then ALToggle(X + 1, Y)
        If X - 1 >= 1 Then ALToggle(X - 1, Y)
        If Y + 1 <= 5 Then ALToggle(X, Y + 1)
        If Y - 1 >= 1 Then ALToggle(X, Y - 1)
    End Sub

    Private Sub ALToggle(ByVal X, ByVal Y) 'toggles chosen button
        If ALSwitch(X, Y) = 0 Then
            ALSwitch(X, Y) = 1
        Else
            ALSwitch(X, Y) = 0
        End If
    End Sub



#Region "Level Data - ChangeLevel - ChangeRow"
    '01 - 05     6 moves
    '06 - 10     7 moves
    '11 - 15     8 moves
    '16 - 20     9 moves
    '21 - 25    10 moves
    '26 - 30    11 moves
    '31 - 35    12 moves
    '36 - 40    13 moves
    '41 - 45    14 moves
    '46 - 50    15 moves
    Private Sub ChangeLevel(ByVal Level As Integer)
        Select Case Level
            Case 1
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 1, 1, 0, 1, 1)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 0, 1, 0, 1, 0)
                ChangeRow(5, 1, 1, 0, 1, 1)
            Case 2
                ChangeRow(1, 0, 1, 0, 1, 0)
                ChangeRow(2, 1, 1, 0, 1, 1)
                ChangeRow(3, 1, 1, 0, 1, 1)
                ChangeRow(4, 1, 1, 0, 1, 1)
                ChangeRow(5, 0, 1, 0, 1, 0)
            Case 3
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 1, 0, 1, 0, 1)
                ChangeRow(4, 0, 1, 1, 1, 0)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 4
                ChangeRow(1, 1, 0, 0, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 1, 1, 0, 1, 0)
                ChangeRow(4, 1, 0, 1, 1, 1)
                ChangeRow(5, 1, 0, 1, 0, 1)
            Case 5
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 0, 1, 1, 0)
                ChangeRow(3, 1, 1, 0, 1, 1)
                ChangeRow(4, 0, 1, 1, 0, 0)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 6
                ChangeRow(1, 0, 0, 1, 1, 0)
                ChangeRow(2, 0, 0, 0, 0, 1)
                ChangeRow(3, 0, 0, 1, 1, 1)
                ChangeRow(4, 0, 0, 0, 0, 1)
                ChangeRow(5, 0, 0, 1, 1, 0)
            Case 7
                ChangeRow(1, 1, 0, 0, 0, 0)
                ChangeRow(2, 1, 0, 0, 0, 0)
                ChangeRow(3, 1, 0, 0, 0, 0)
                ChangeRow(4, 0, 1, 0, 0, 0)
                ChangeRow(5, 0, 0, 1, 1, 1)
            Case 8
                ChangeRow(1, 0, 0, 1, 1, 0)
                ChangeRow(2, 0, 1, 0, 0, 1)
                ChangeRow(3, 0, 0, 0, 0, 1)
                ChangeRow(4, 0, 1, 0, 1, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 9
                ChangeRow(1, 0, 1, 1, 1, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 1, 1, 1, 0)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 10
                ChangeRow(1, 1, 1, 0, 1, 1)
                ChangeRow(2, 1, 1, 1, 1, 1)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 0, 1, 1, 1, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 11
                ChangeRow(1, 1, 1, 1, 1, 1)
                ChangeRow(2, 1, 0, 1, 0, 1)
                ChangeRow(3, 1, 1, 0, 1, 1)
                ChangeRow(4, 1, 0, 1, 0, 1)
                ChangeRow(5, 1, 1, 1, 1, 1)
            Case 12
                ChangeRow(1, 1, 1, 0, 1, 1)
                ChangeRow(2, 0, 0, 1, 0, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 1, 0, 0, 0, 1)
                ChangeRow(5, 1, 1, 1, 1, 1)
            Case 13
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 0, 1, 0, 1, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 14
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 0, 1, 0)
                ChangeRow(4, 0, 0, 0, 1, 0)
                ChangeRow(5, 0, 0, 0, 1, 0)
            Case 15
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 1, 0, 1)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 1, 0, 1, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 16
                ChangeRow(1, 1, 0, 1, 0, 1)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 1, 0, 1, 0, 1)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 1, 0, 1, 0, 1)
            Case 17
                ChangeRow(1, 0, 1, 0, 1, 1)
                ChangeRow(2, 0, 1, 1, 0, 1)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 1, 0, 1, 1, 0)
                ChangeRow(5, 1, 1, 0, 1, 0)
            Case 18
                ChangeRow(1, 0, 0, 1, 1, 1)
                ChangeRow(2, 0, 0, 1, 0, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 1, 0, 1, 0, 0)
                ChangeRow(5, 1, 1, 1, 1, 1)
            Case 19
                ChangeRow(1, 0, 0, 1, 1, 0)
                ChangeRow(2, 1, 0, 1, 0, 0)
                ChangeRow(3, 1, 0, 0, 0, 0)
                ChangeRow(4, 1, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 20
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 1, 0, 0, 0, 1)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 21
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 1, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 22
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 1, 1, 0, 1, 1)
            Case 23
                ChangeRow(1, 0, 1, 1, 1, 0)
                ChangeRow(2, 1, 0, 0, 0, 1)
                ChangeRow(3, 1, 0, 0, 0, 1)
                ChangeRow(4, 1, 0, 0, 0, 1)
                ChangeRow(5, 0, 1, 1, 1, 0)
            Case 24
                ChangeRow(1, 1, 1, 1, 1, 1)
                ChangeRow(2, 0, 0, 1, 0, 0)
                ChangeRow(3, 1, 1, 0, 1, 1)
                ChangeRow(4, 1, 0, 1, 0, 1)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 25
                ChangeRow(1, 0, 0, 0, 1, 0)
                ChangeRow(2, 0, 1, 0, 1, 0)
                ChangeRow(3, 0, 0, 1, 0, 1)
                ChangeRow(4, 1, 1, 0, 1, 1)
                ChangeRow(5, 0, 0, 1, 1, 1)
            Case 26
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 1, 0, 1, 0)
                ChangeRow(4, 0, 1, 1, 1, 0)
                ChangeRow(5, 0, 1, 0, 1, 0)
            Case 27
                ChangeRow(1, 1, 0, 0, 0, 1)
                ChangeRow(2, 1, 0, 0, 0, 1)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 1, 0, 0, 0, 1)
                ChangeRow(5, 1, 0, 0, 0, 1)
            Case 28
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 1, 0, 1, 0, 1)
                ChangeRow(5, 1, 1, 1, 1, 1)
            Case 29
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 30
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 0, 0, 0)
                ChangeRow(4, 0, 1, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 31
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 0, 1, 1, 1)
                ChangeRow(4, 0, 0, 0, 1, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 32
                ChangeRow(1, 1, 1, 1, 1, 1)
                ChangeRow(2, 0, 0, 0, 1, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 0, 1, 0, 0, 0)
                ChangeRow(5, 1, 1, 1, 1, 1)
            Case 33
                ChangeRow(1, 0, 0, 1, 1, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 0, 1, 1, 1)
                ChangeRow(4, 0, 1, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 1, 0)
            Case 34
                ChangeRow(1, 0, 0, 0, 1, 1)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 1, 1, 0)
                ChangeRow(4, 1, 1, 0, 0, 0)
                ChangeRow(5, 0, 1, 1, 1, 1)
            Case 35
                ChangeRow(1, 0, 1, 1, 0, 0)
                ChangeRow(2, 1, 1, 1, 1, 0)
                ChangeRow(3, 1, 1, 0, 1, 0)
                ChangeRow(4, 1, 0, 1, 1, 1)
                ChangeRow(5, 0, 1, 1, 0, 1)
            Case 36
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 0, 1, 1, 0)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 0, 1, 1, 0, 0)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 37
                ChangeRow(1, 0, 1, 0, 0, 1)
                ChangeRow(2, 1, 1, 0, 0, 1)
                ChangeRow(3, 0, 1, 1, 0, 1)
                ChangeRow(4, 0, 1, 0, 1, 0)
                ChangeRow(5, 0, 0, 0, 1, 1)
            Case 38
                ChangeRow(1, 1, 0, 1, 0, 1)
                ChangeRow(2, 0, 1, 0, 1, 0)
                ChangeRow(3, 1, 0, 1, 0, 1)
                ChangeRow(4, 0, 1, 0, 1, 0)
                ChangeRow(5, 1, 0, 1, 0, 1)
            Case 39
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 1, 0, 1, 0)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 40
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 1, 1, 1, 1, 1)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 1, 1, 1, 1, 1)
                ChangeRow(5, 0, 1, 0, 1, 0)
            Case 41
                ChangeRow(1, 0, 1, 1, 1, 0)
                ChangeRow(2, 1, 1, 0, 1, 1)
                ChangeRow(3, 1, 0, 0, 0, 1)
                ChangeRow(4, 1, 1, 0, 1, 1)
                ChangeRow(5, 0, 1, 1, 1, 0)
            Case 42
                ChangeRow(1, 1, 0, 1, 0, 1)
                ChangeRow(2, 1, 1, 0, 1, 0)
                ChangeRow(3, 1, 1, 1, 0, 1)
                ChangeRow(4, 0, 0, 1, 0, 1)
                ChangeRow(5, 0, 1, 1, 1, 1)
            Case 43
                ChangeRow(1, 1, 0, 0, 0, 1)
                ChangeRow(2, 0, 1, 0, 1, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 0, 0, 1, 0, 0)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 44
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 0, 1, 0, 1, 0)
                ChangeRow(4, 0, 1, 1, 1, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 45
                ChangeRow(1, 1, 1, 0, 0, 1)
                ChangeRow(2, 0, 0, 0, 1, 0)
                ChangeRow(3, 1, 1, 1, 0, 0)
                ChangeRow(4, 0, 1, 0, 0, 0)
                ChangeRow(5, 1, 0, 1, 0, 0)
            Case 46
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 0, 0, 0, 0, 0)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 47
                ChangeRow(1, 0, 1, 0, 1, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 0, 0, 1, 0, 0)
                ChangeRow(4, 1, 0, 0, 0, 1)
                ChangeRow(5, 1, 0, 0, 0, 1)
            Case 48
                ChangeRow(1, 0, 0, 0, 0, 0)
                ChangeRow(2, 0, 0, 0, 0, 0)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 1, 1, 0, 1, 1)
                ChangeRow(5, 0, 0, 0, 0, 0)
            Case 49
                ChangeRow(1, 0, 0, 1, 0, 0)
                ChangeRow(2, 0, 1, 1, 1, 0)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 0, 1, 1, 1, 0)
                ChangeRow(5, 0, 0, 1, 0, 0)
            Case 50
                ChangeRow(1, 1, 1, 1, 1, 1)
                ChangeRow(2, 1, 1, 1, 1, 1)
                ChangeRow(3, 1, 1, 1, 1, 1)
                ChangeRow(4, 1, 1, 1, 1, 1)
                ChangeRow(5, 1, 1, 1, 1, 1)
        End Select
    End Sub

    Private Sub ChangeRow(ByVal Row As Integer, ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer)
        If a = 1 Then Switch(1, Row) = 1
        If b = 1 Then Switch(2, Row) = 1
        If c = 1 Then Switch(3, Row) = 1
        If d = 1 Then Switch(4, Row) = 1
        If e = 1 Then Switch(5, Row) = 1
    End Sub

#End Region



    Private Sub menuabout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuabout.Click
        MsgBox("Lights Out was written and programmed by Patrick Wang" & Chr(13) & Chr(10) & "Copyright © 2010" & Chr(13) & Chr(10) & version)
    End Sub

    Private Sub FormExit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuexit.Click
        Application.Exit()
    End Sub

    Private Sub Main_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If My.Settings.ShowInstructions = True Then menuinst_Click(Nothing, Nothing)
    End Sub

    Private Sub Main_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        For a = 1 To 50 : My.Settings.LevelsUnlocked(a) = LevelsUnlocked(a) : Next a
        My.Settings.Save()
    End Sub

End Class
