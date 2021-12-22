<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBNetSQlite
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
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonMakeID = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.CheckBoxSearchByName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSearchByID = New System.Windows.Forms.CheckBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripEditor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(54, 41)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 0
        '
        'TextBoxCity
        '
        Me.TextBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCity.Location = New System.Drawing.Point(54, 93)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxCity.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Location = New System.Drawing.Point(54, 67)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'ButtonMakeID
        '
        Me.ButtonMakeID.Location = New System.Drawing.Point(160, 39)
        Me.ButtonMakeID.Name = "ButtonMakeID"
        Me.ButtonMakeID.Size = New System.Drawing.Size(84, 23)
        Me.ButtonMakeID.TabIndex = 3
        Me.ButtonMakeID.Text = "IDMaker"
        Me.ButtonMakeID.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(269, 91)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(84, 23)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "Clear All"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City"
        '
        'TextBoxMobilePhone
        '
        Me.TextBoxMobilePhone.Location = New System.Drawing.Point(449, 39)
        Me.TextBoxMobilePhone.Name = "TextBoxMobilePhone"
        Me.TextBoxMobilePhone.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxMobilePhone.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(449, 65)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Gender"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {" - choose gender -", "Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(449, 91)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(190, 21)
        Me.ComboBoxGender.TabIndex = 14
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(54, 119)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(84, 23)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(160, 119)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(84, 23)
        Me.ButtonRefresh.TabIndex = 16
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchByName
        '
        Me.CheckBoxSearchByName.AutoSize = True
        Me.CheckBoxSearchByName.Checked = True
        Me.CheckBoxSearchByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSearchByName.Location = New System.Drawing.Point(247, 123)
        Me.CheckBoxSearchByName.Name = "CheckBoxSearchByName"
        Me.CheckBoxSearchByName.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxSearchByName.TabIndex = 17
        Me.CheckBoxSearchByName.Text = "Search By Name"
        Me.CheckBoxSearchByName.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchByID
        '
        Me.CheckBoxSearchByID.AutoSize = True
        Me.CheckBoxSearchByID.Location = New System.Drawing.Point(354, 123)
        Me.CheckBoxSearchByID.Name = "CheckBoxSearchByID"
        Me.CheckBoxSearchByID.Size = New System.Drawing.Size(89, 17)
        Me.CheckBoxSearchByID.TabIndex = 18
        Me.CheckBoxSearchByID.Text = "Search By ID"
        Me.CheckBoxSearchByID.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(449, 119)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(84, 23)
        Me.ButtonUpdate.TabIndex = 19
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(555, 119)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(84, 23)
        Me.ButtonSave.TabIndex = 20
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxSearch.Location = New System.Drawing.Point(54, 148)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(585, 20)
        Me.TextBoxSearch.TabIndex = 21
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.ContextMenuStrip = Me.ContextMenuStripEditor
        Me.DataGridViewTable.Location = New System.Drawing.Point(12, 174)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(627, 150)
        Me.DataGridViewTable.TabIndex = 22
        '
        'ContextMenuStripEditor
        '
        Me.ContextMenuStripEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDitToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStripEditor.Name = "ContextMenuStripEditor"
        Me.ContextMenuStripEditor.Size = New System.Drawing.Size(123, 70)
        '
        'EDitToolStripMenuItem
        '
        Me.EDitToolStripMenuItem.Name = "EDitToolStripMenuItem"
        Me.EDitToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.EDitToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 337)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'VBNetSQlite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 351)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.CheckBoxSearchByID)
        Me.Controls.Add(Me.CheckBoxSearchByName)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxMobilePhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonMakeID)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxCity)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VBNetSQlite"
        Me.Text = "VB Net SQLite"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEditor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonMakeID As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxMobilePhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents CheckBoxSearchByName As CheckBox
    Friend WithEvents CheckBoxSearchByID As CheckBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents ContextMenuStripEditor As ContextMenuStrip
    Friend WithEvents EDitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
End Class
