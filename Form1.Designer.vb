<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.hours = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gross = New System.Windows.Forms.TextBox()
        Me.mfica = New System.Windows.Forms.TextBox()
        Me.mfederal = New System.Windows.Forms.TextBox()
        Me.mstate = New System.Windows.Forms.TextBox()
        Me.net = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.setup = New System.Windows.Forms.Button()
        Me.wages = New System.Windows.Forms.ListBox()
        Me.ficas = New System.Windows.Forms.ListBox()
        Me.fed = New System.Windows.Forms.ListBox()
        Me.states = New System.Windows.Forms.ListBox()
        Me.employees = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'hours
        '
        Me.hours.Location = New System.Drawing.Point(332, 65)
        Me.hours.Margin = New System.Windows.Forms.Padding(2)
        Me.hours.Name = "hours"
        Me.hours.Size = New System.Drawing.Size(76, 20)
        Me.hours.TabIndex = 0
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(428, 64)
        Me.calculate.Margin = New System.Windows.Forms.Padding(2)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(74, 19)
        Me.calculate.TabIndex = 1
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hours Worked:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gross:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FICA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Federal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 209)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Net Salary:"
        '
        'gross
        '
        Me.gross.BackColor = System.Drawing.Color.GhostWhite
        Me.gross.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gross.Location = New System.Drawing.Point(332, 102)
        Me.gross.Margin = New System.Windows.Forms.Padding(2)
        Me.gross.Name = "gross"
        Me.gross.Size = New System.Drawing.Size(76, 20)
        Me.gross.TabIndex = 8
        '
        'mfica
        '
        Me.mfica.BackColor = System.Drawing.Color.GhostWhite
        Me.mfica.ForeColor = System.Drawing.SystemColors.Desktop
        Me.mfica.Location = New System.Drawing.Point(332, 143)
        Me.mfica.Margin = New System.Windows.Forms.Padding(2)
        Me.mfica.Name = "mfica"
        Me.mfica.Size = New System.Drawing.Size(76, 20)
        Me.mfica.TabIndex = 9
        '
        'mfederal
        '
        Me.mfederal.BackColor = System.Drawing.Color.GhostWhite
        Me.mfederal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.mfederal.Location = New System.Drawing.Point(332, 173)
        Me.mfederal.Margin = New System.Windows.Forms.Padding(2)
        Me.mfederal.Name = "mfederal"
        Me.mfederal.Size = New System.Drawing.Size(76, 20)
        Me.mfederal.TabIndex = 10
        '
        'mstate
        '
        Me.mstate.BackColor = System.Drawing.Color.GhostWhite
        Me.mstate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.mstate.Location = New System.Drawing.Point(332, 209)
        Me.mstate.Margin = New System.Windows.Forms.Padding(2)
        Me.mstate.Name = "mstate"
        Me.mstate.Size = New System.Drawing.Size(76, 20)
        Me.mstate.TabIndex = 11
        '
        'net
        '
        Me.net.BackColor = System.Drawing.Color.GhostWhite
        Me.net.ForeColor = System.Drawing.SystemColors.Desktop
        Me.net.Location = New System.Drawing.Point(332, 249)
        Me.net.Margin = New System.Windows.Forms.Padding(2)
        Me.net.Name = "net"
        Me.net.Size = New System.Drawing.Size(76, 20)
        Me.net.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Employee:"
        '
        'setup
        '
        Me.setup.Location = New System.Drawing.Point(134, 43)
        Me.setup.Name = "setup"
        Me.setup.Size = New System.Drawing.Size(48, 23)
        Me.setup.TabIndex = 15
        Me.setup.Text = "Setup"
        Me.setup.UseVisualStyleBackColor = True
        '
        'wages
        '
        Me.wages.FormattingEnabled = True
        Me.wages.Location = New System.Drawing.Point(47, 275)
        Me.wages.Name = "wages"
        Me.wages.Size = New System.Drawing.Size(67, 43)
        Me.wages.TabIndex = 16
        Me.wages.Visible = False
        '
        'ficas
        '
        Me.ficas.FormattingEnabled = True
        Me.ficas.Location = New System.Drawing.Point(121, 275)
        Me.ficas.Name = "ficas"
        Me.ficas.Size = New System.Drawing.Size(61, 43)
        Me.ficas.TabIndex = 17
        Me.ficas.Visible = False
        '
        'fed
        '
        Me.fed.FormattingEnabled = True
        Me.fed.Location = New System.Drawing.Point(48, 325)
        Me.fed.Name = "fed"
        Me.fed.Size = New System.Drawing.Size(66, 43)
        Me.fed.TabIndex = 18
        Me.fed.Visible = False
        '
        'states
        '
        Me.states.FormattingEnabled = True
        Me.states.Location = New System.Drawing.Point(121, 325)
        Me.states.Name = "states"
        Me.states.Size = New System.Drawing.Size(61, 43)
        Me.states.TabIndex = 19
        Me.states.Visible = False
        '
        'employees
        '
        Me.employees.FormattingEnabled = True
        Me.employees.Location = New System.Drawing.Point(48, 67)
        Me.employees.Name = "employees"
        Me.employees.Size = New System.Drawing.Size(134, 199)
        Me.employees.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(449, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(449, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(53, 20)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(449, 173)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(53, 20)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(449, 209)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(53, 20)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(634, 384)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.employees)
        Me.Controls.Add(Me.states)
        Me.Controls.Add(Me.fed)
        Me.Controls.Add(Me.ficas)
        Me.Controls.Add(Me.wages)
        Me.Controls.Add(Me.setup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.net)
        Me.Controls.Add(Me.mstate)
        Me.Controls.Add(Me.mfederal)
        Me.Controls.Add(Me.mfica)
        Me.Controls.Add(Me.gross)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.hours)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hours As TextBox
    Friend WithEvents calculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gross As TextBox
    Friend WithEvents mfica As TextBox
    Friend WithEvents mfederal As TextBox
    Friend WithEvents mstate As TextBox
    Friend WithEvents net As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents setup As Button
    Friend WithEvents wages As ListBox
    Friend WithEvents ficas As ListBox
    Friend WithEvents fed As ListBox
    Friend WithEvents states As ListBox
    Friend WithEvents employees As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
