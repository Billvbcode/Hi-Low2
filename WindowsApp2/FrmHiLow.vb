Public Class FrmHiLow
    Dim iCount As Integer 'Counter

    Private Sub BtnStart_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        Dim i As Integer
        LblAns.BackColor = DefaultBackColor ' Default Back Color
        iCount = 0             ' Set counter to Zero
        LblGuess.Text = "Guess Count= " & iCount  ' Display Counter
        ' Number from 0 to 25
        i = Rnd() * 26000
        i = i Mod 26             ' Mod return remainder
        LblAns.Tag = i           ' Invisible Text Field
        LblAns.Text = "?"         ' Visible Text Field
        TxtGuess.Focus() 'Put Cursor out in TxtGuess
        TxtGuess.Text = "" ' Blank out the guess
        LblHi.Text = "25"  ' Set hi to 25
        LblLow.Text = "0"  ' Set Low to 0
        BtnStart.Visible = False ' Make Start Button Invisible
        'BtnGuess.Visible = True ' Make Guess Button Visible
    End Sub



    Private Sub TxtGuess_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtGuess.KeyDown
        If e.KeyCode = Keys.Enter Then  'Enter Key will Check Guess
            iCount += 1             ' Increment iCount by 1
            LblGuess.Text = "Guess Count= " & iCount  ' Display Counter
            If Val(TxtGuess.Text) = Val(LblAns.Tag) Then 'Guess Equal to Answer
                LblAns.Text = LblAns.Tag         ' Display Anwser
                LblAns.BackColor = Color.LimeGreen ' Lime Green
                MsgBox("Correct Guess Count= " & iCount, MsgBoxStyle.OkOnly, "Correct Ans")
                BtnStart.Visible = True ' Make Start Button Visible
                ' BtnGuess.Visible = False ' Make Guess Button Invisible
                BtnStart.Focus() ' Move cursor to Start button
                Exit Sub ' Exit if you win
            ElseIf Val(TxtGuess.Text) < Val(LblAns.Tag) Then 'Guess less than Answer
                '          Update Low Value
                If Val(TxtGuess.Text) > Val(LblLow.Text) Then _
          LblLow.Text = TxtGuess.Text 'NewLowValue
                LblAns.Text = TxtGuess.Text & " too low"
                LblAns.BackColor = Color.Aqua  ' Aqua
            ElseIf Val(TxtGuess.Text) > Val(LblAns.Tag) Then 'Guess higher than Answer
                '       Update Hi Value
                If Val(TxtGuess.Text) < Val(LblHi.Text) Then _
          LblHi.Text = TxtGuess.Text 'NewHi
                LblAns.Text = TxtGuess.Text & " too hi"
                LblAns.BackColor = Color.Orange ' Orange
            End If
            TxtGuess.Text = "" ' Blank out the guess
            TxtGuess.Focus() 'Put Cursor out in TxtGuess
        End If
    End Sub
    Private Sub FrmHiLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize() 'Seed for RND function        
    End Sub
End Class