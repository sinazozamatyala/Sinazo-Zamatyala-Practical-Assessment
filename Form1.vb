
Public Class Form1
    Private wordList As New List(Of String)

    Private Sub btnAddButton_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim word As String = txtWord.Text.Trim()

        If Not String.IsNullOrEmpty(word) AndAlso Not wordList.Contains(word) Then
            wordList.Add(word)
            RefreshWordList()
        Else
            MsgBox("word already exist, please enter new word.")
        End If
    End Sub

    Private Sub RefreshWordList()
        WordListBox.Items.Clear()
        WordListBox.Items.AddRange(wordList.ToArray())
    End Sub

    Private Sub WordListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WordListBox.SelectedIndexChanged
        If WordListBox.SelectedIndex <> -1 Then
            Dim selectedWord As String = WordListBox.SelectedItem.ToString()
            DisplayLabel.Text = selectedWord
            DisplayLabel.BackColor = Color.White
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ToUpperRadioButton.CheckedChanged,
                                                                                   ToLowerRadioButton.CheckedChanged,
                                                                                   PurpleRadioButton.CheckedChanged,
                                                                                   BlueRadioButton.CheckedChanged

        If WordListBox.SelectedIndex <> -1 Then
            Dim selectedWord As String = WordListBox.SelectedItem.ToString()

            If ToUpperRadioButton.Checked Then
                DisplayLabel.Text = selectedWord.ToUpper()
            ElseIf ToLowerRadioButton.Checked Then
                DisplayLabel.Text = selectedWord.ToLower()
            ElseIf PurpleRadioButton.Checked Then
                DisplayLabel.ForeColor = Color.Purple
            ElseIf BlueRadioButton.Checked Then
                DisplayLabel.ForeColor = Color.Blue
            End If
        End If
    End Sub
End Class
