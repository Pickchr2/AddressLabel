<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabelForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipErrorLabel = New System.Windows.Forms.Label()
        Me.StateErrorLabel = New System.Windows.Forms.Label()
        Me.CityErrorLabel = New System.Windows.Forms.Label()
        Me.StreetAddressErrorLabel = New System.Windows.Forms.Label()
        Me.LastNameErrorLabel = New System.Windows.Forms.Label()
        Me.FirstNameErrorLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AddressLabelToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddressLabelMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputGroupBox.SuspendLayout()
        Me.InputGroupBox.SuspendLayout()
        Me.AddressLabelMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisplayLabel.Location = New System.Drawing.Point(6, 23)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(357, 296)
        Me.DisplayLabel.TabIndex = 0
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(394, 45)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(369, 332)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Display Your Address Label"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZipErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.StateErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.CityErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameErrorLabel)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 45)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(369, 426)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Enter Your Address Information"
        '
        'ZipErrorLabel
        '
        Me.ZipErrorLabel.AutoSize = True
        Me.ZipErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ZipErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ZipErrorLabel.Location = New System.Drawing.Point(141, 375)
        Me.ZipErrorLabel.Name = "ZipErrorLabel"
        Me.ZipErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.ZipErrorLabel.TabIndex = 17
        Me.ZipErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.ZipErrorLabel, "You must enter a zip code.")
        Me.ZipErrorLabel.Visible = False
        '
        'StateErrorLabel
        '
        Me.StateErrorLabel.AutoSize = True
        Me.StateErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StateErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.StateErrorLabel.Location = New System.Drawing.Point(141, 309)
        Me.StateErrorLabel.Name = "StateErrorLabel"
        Me.StateErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.StateErrorLabel.TabIndex = 14
        Me.StateErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.StateErrorLabel, "You must enter a state.")
        Me.StateErrorLabel.Visible = False
        '
        'CityErrorLabel
        '
        Me.CityErrorLabel.AutoSize = True
        Me.CityErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CityErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.CityErrorLabel.Location = New System.Drawing.Point(243, 239)
        Me.CityErrorLabel.Name = "CityErrorLabel"
        Me.CityErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.CityErrorLabel.TabIndex = 11
        Me.CityErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.CityErrorLabel, "You must enter a city.")
        Me.CityErrorLabel.Visible = False
        '
        'StreetAddressErrorLabel
        '
        Me.StreetAddressErrorLabel.AutoSize = True
        Me.StreetAddressErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StreetAddressErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.StreetAddressErrorLabel.Location = New System.Drawing.Point(243, 173)
        Me.StreetAddressErrorLabel.Name = "StreetAddressErrorLabel"
        Me.StreetAddressErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.StreetAddressErrorLabel.TabIndex = 8
        Me.StreetAddressErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.StreetAddressErrorLabel, "You must enter a street address.")
        Me.StreetAddressErrorLabel.Visible = False
        '
        'LastNameErrorLabel
        '
        Me.LastNameErrorLabel.AutoSize = True
        Me.LastNameErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LastNameErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.LastNameErrorLabel.Location = New System.Drawing.Point(243, 112)
        Me.LastNameErrorLabel.Name = "LastNameErrorLabel"
        Me.LastNameErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.LastNameErrorLabel.TabIndex = 5
        Me.LastNameErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.LastNameErrorLabel, "You must enter a last name.")
        Me.LastNameErrorLabel.Visible = False
        '
        'FirstNameErrorLabel
        '
        Me.FirstNameErrorLabel.AutoSize = True
        Me.FirstNameErrorLabel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirstNameErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.FirstNameErrorLabel.Location = New System.Drawing.Point(243, 52)
        Me.FirstNameErrorLabel.Name = "FirstNameErrorLabel"
        Me.FirstNameErrorLabel.Size = New System.Drawing.Size(35, 45)
        Me.FirstNameErrorLabel.TabIndex = 2
        Me.FirstNameErrorLabel.Text = "*"
        Me.AddressLabelToolTip.SetToolTip(Me.FirstNameErrorLabel, "You must enter a first name.")
        Me.FirstNameErrorLabel.Visible = False
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(0, 381)
        Me.ZipTextBox.MaxLength = 5
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(139, 27)
        Me.ZipTextBox.TabIndex = 16
        Me.AddressLabelToolTip.SetToolTip(Me.ZipTextBox, "Enter zip code of the address label.")
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(6, 358)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(70, 20)
        Me.ZipLabel.TabIndex = 15
        Me.ZipLabel.Text = "Zip Code"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(0, 314)
        Me.StateTextBox.MaxLength = 2
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(139, 27)
        Me.StateTextBox.TabIndex = 13
        Me.AddressLabelToolTip.SetToolTip(Me.StateTextBox, "Enter state abbreviation of the address label.")
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(6, 291)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(133, 20)
        Me.StateLabel.TabIndex = 12
        Me.StateLabel.Text = "State Abbreviation"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(0, 244)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(241, 27)
        Me.CityTextBox.TabIndex = 10
        Me.AddressLabelToolTip.SetToolTip(Me.CityTextBox, "Enter city of the address label.")
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 221)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(34, 20)
        Me.CityLabel.TabIndex = 9
        Me.CityLabel.Text = "City"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(0, 178)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(241, 27)
        Me.StreetAddressTextBox.TabIndex = 7
        Me.AddressLabelToolTip.SetToolTip(Me.StreetAddressTextBox, "Enter street address of the address label.")
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(6, 155)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(105, 20)
        Me.StreetAddressLabel.TabIndex = 6
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(0, 117)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(241, 27)
        Me.LastNameTextBox.TabIndex = 4
        Me.AddressLabelToolTip.SetToolTip(Me.LastNameTextBox, "Enter last name of the address label.")
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 94)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(79, 20)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(0, 57)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(241, 27)
        Me.FirstNameTextBox.TabIndex = 1
        Me.AddressLabelToolTip.SetToolTip(Me.FirstNameTextBox, "Enter first name of the address label.")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 34)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(80, 20)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name"
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(394, 383)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(122, 88)
        Me.DisplayButton.TabIndex = 2
        Me.DisplayButton.Text = "&Display Label"
        Me.AddressLabelToolTip.SetToolTip(Me.DisplayButton, "Click to display your generated address label.")
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(522, 383)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(123, 88)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.AddressLabelToolTip.SetToolTip(Me.ClearButton, "click to clear all fields.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(651, 383)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 88)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.AddressLabelToolTip.SetToolTip(Me.ExitButton, "Click to exit the application.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddressLabelMenuStrip
        '
        Me.AddressLabelMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AddressLabelMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.AddressLabelMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AddressLabelMenuStrip.Name = "AddressLabelMenuStrip"
        Me.AddressLabelMenuStrip.Size = New System.Drawing.Size(777, 28)
        Me.AddressLabelMenuStrip.TabIndex = 19
        Me.AddressLabelMenuStrip.Text = "AddressLabelMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayLabelToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplayLabelToolStripMenuItem
        '
        Me.DisplayLabelToolStripMenuItem.Name = "DisplayLabelToolStripMenuItem"
        Me.DisplayLabelToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DisplayLabelToolStripMenuItem.Text = "Display Label"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddressLabelForm
        '
        Me.AcceptButton = Me.DisplayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(777, 483)
        Me.Controls.Add(Me.AddressLabelMenuStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Name = "AddressLabelForm"
        Me.Text = "Address Label Generator"
        Me.OutputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.AddressLabelMenuStrip.ResumeLayout(False)
        Me.AddressLabelMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayLabel As Label
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents ZipErrorLabel As Label
    Friend WithEvents StateErrorLabel As Label
    Friend WithEvents CityErrorLabel As Label
    Friend WithEvents StreetAddressErrorLabel As Label
    Friend WithEvents LastNameErrorLabel As Label
    Friend WithEvents FirstNameErrorLabel As Label
    Friend WithEvents AddressLabelToolTip As ToolTip
    Friend WithEvents AddressLabelMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayLabelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
