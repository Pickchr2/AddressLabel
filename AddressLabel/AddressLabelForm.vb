'Christopher Pickens
'RCET0265
'Spring 2023
'Address Label
'https://github.com/Pickchr2/AddressLabel.git

Option Explicit On
Option Strict On

Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetAddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()

        FirstNameErrorLabel.Visible = False
        LastNameErrorLabel.Visible = False
        StreetAddressErrorLabel.Visible = False
        CityErrorLabel.Visible = False
        StateErrorLabel.Visible = False
        ZipErrorLabel.Visible = False

        DisplayLabel.Text = ""

        FirstNameTextBox.Select()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click, DisplayLabelToolStripMenuItem.Click
        Dim errorFlag As Boolean = False

        FirstNameErrorLabel.Visible = False
        LastNameErrorLabel.Visible = False
        StreetAddressErrorLabel.Visible = False
        CityErrorLabel.Visible = False
        StateErrorLabel.Visible = False
        ZipErrorLabel.Visible = False

        If ZipTextBox.Text = "" Then
            ZipErrorLabel.Visible = True
            errorFlag = True
            ZipTextBox.Select()
        End If

        If StateTextBox.Text = "" Then
            StateErrorLabel.Visible = True
            errorFlag = True
            StateTextBox.Select()
        End If

        If CityTextBox.Text = "" Then
            CityErrorLabel.Visible = True
            errorFlag = True
            CityTextBox.Select()
        End If

        If StreetAddressTextBox.Text = "" Then
            StreetAddressErrorLabel.Visible = True
            errorFlag = True
            StreetAddressTextBox.Select()
        End If

        If LastNameTextBox.Text = "" Then
            LastNameErrorLabel.Visible = True
            errorFlag = True
            LastNameTextBox.Select()
        End If

        If FirstNameTextBox.Text = "" Then
            FirstNameErrorLabel.Visible = True
            errorFlag = True
            FirstNameTextBox.Select()
        End If

        If errorFlag = False Then
            DisplayLabel.Text = FirstNameTextBox.Text.ToString() & " " & LastNameTextBox.Text.ToString() & vbCrLf _
            & StreetAddressTextBox.Text.ToString() & vbCrLf _
            & CityTextBox.Text.ToString() & ", " & StateTextBox.Text.ToString() & " " & ZipTextBox.Text.ToString()
        End If
    End Sub
End Class
