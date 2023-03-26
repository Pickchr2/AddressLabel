'Christopher Pickens
'RCET0265
'Spring 2023
'Address Label
'https://github.com/Pickchr2/AddressLabel.git

Option Explicit On
Option Strict On

Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
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

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FirstNameTextBox.Text.ToString() & " " & LastNameTextBox.Text.ToString() & vbCrLf _
        & StreetAddressTextBox.Text.ToString() & vbCrLf _
        & CityTextBox.Text.ToString() & ", " & StateTextBox.Text.ToString() & " " & ZipTextBox.Text.ToString()
    End Sub
End Class
