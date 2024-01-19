<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtWord = New TextBox()
        WordListBox = New ListBox()
        btnAdd = New Button()
        DisplayLabel = New Label()
        ToUpperRadioButton = New RadioButton()
        ToLowerRadioButton = New RadioButton()
        PurpleRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter a word"
        ' 
        ' txtWord
        ' 
        txtWord.Location = New Point(272, 57)
        txtWord.Name = "txtWord"
        txtWord.Size = New Size(187, 27)
        txtWord.TabIndex = 1
        ' 
        ' WordListBox
        ' 
        WordListBox.FormattingEnabled = True
        WordListBox.Location = New Point(571, 57)
        WordListBox.Name = "WordListBox"
        WordListBox.Size = New Size(150, 104)
        WordListBox.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(272, 124)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(113, 48)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DisplayLabel
        ' 
        DisplayLabel.AutoSize = True
        DisplayLabel.Location = New Point(310, 316)
        DisplayLabel.Name = "DisplayLabel"
        DisplayLabel.Size = New Size(40, 20)
        DisplayLabel.TabIndex = 4
        DisplayLabel.Text = "Case"
        ' 
        ' ToUpperRadioButton
        ' 
        ToUpperRadioButton.AutoSize = True
        ToUpperRadioButton.Location = New Point(310, 354)
        ToUpperRadioButton.Name = "ToUpperRadioButton"
        ToUpperRadioButton.Size = New Size(91, 24)
        ToUpperRadioButton.TabIndex = 5
        ToUpperRadioButton.TabStop = True
        ToUpperRadioButton.Text = "To Upper"
        ToUpperRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ToLowerRadioButton
        ' 
        ToLowerRadioButton.AutoSize = True
        ToLowerRadioButton.Location = New Point(310, 400)
        ToLowerRadioButton.Name = "ToLowerRadioButton"
        ToLowerRadioButton.Size = New Size(90, 24)
        ToLowerRadioButton.TabIndex = 6
        ToLowerRadioButton.TabStop = True
        ToLowerRadioButton.Text = "To Lower"
        ToLowerRadioButton.UseVisualStyleBackColor = True
        ' 
        ' PurpleRadioButton
        ' 
        PurpleRadioButton.AutoSize = True
        PurpleRadioButton.Location = New Point(600, 354)
        PurpleRadioButton.Name = "PurpleRadioButton"
        PurpleRadioButton.Size = New Size(72, 24)
        PurpleRadioButton.TabIndex = 7
        PurpleRadioButton.TabStop = True
        PurpleRadioButton.Text = "Purple"
        PurpleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(600, 400)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(59, 24)
        BlueRadioButton.TabIndex = 8
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(617, 316)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 9
        Label2.Text = "Colour"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(BlueRadioButton)
        Controls.Add(PurpleRadioButton)
        Controls.Add(ToLowerRadioButton)
        Controls.Add(ToUpperRadioButton)
        Controls.Add(DisplayLabel)
        Controls.Add(btnAdd)
        Controls.Add(WordListBox)
        Controls.Add(txtWord)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents WordListBox As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ToUpperRadioButton As RadioButton
    Friend WithEvents ToLowerRadioButton As RadioButton
    Friend WithEvents PurpleRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents Label2 As Label

End Class
