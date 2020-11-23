

Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim X, Wage, Y, Fica, Federal, State, Salary As Decimal
        X = 0
        If Not hours.Text = "" Then
            X = hours.Text
        End If
        Wage = Val(TextBox1.Text)
        Y = X * Wage
        Fica = Val(TextBox2.Text) * Y
        Federal = Val(TextBox3.Text) * Y
        State = Val(TextBox4.Text) * Y
        Salary = Y - (Fica + Federal + State)
        mfica.Text = Fica
        mfederal.Text = Federal
        mstate.Text = State
        net.Text = Salary
        gross.Text = Y
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub setup_Click(sender As Object, e As EventArgs) Handles setup.Click
        Dim Setup As New Form2
        Setup.ShowDialog()

        LoadData()
        ' EnableAndDisable()
    End Sub

    Private Sub LoadData()

        employees.Items.Clear()
        wages.Items.Clear()
        ficas.Items.Clear()
        fed.Items.Clear()
        states.Items.Clear()

        Dim SourcePath As String = "C:\Users\D00357535\source\repos\TaxCalc\employees.txt"

        If (My.Computer.FileSystem.FileExists(SourcePath)) Then
            Dim fileReader =
  My.Computer.FileSystem.OpenTextFileReader(SourcePath)
            Dim count As Integer
            Dim i As Integer
            Dim name As String
            Dim salary As String
            Dim fica As Decimal
            Dim federal As Decimal
            Dim State As Decimal

            count = fileReader.ReadLine
            For i = 1 To count
                name = fileReader.ReadLine
                salary = fileReader.ReadLine
                fica = fileReader.ReadLine
                federal = fileReader.ReadLine
                State = fileReader.ReadLine

                employees.Items.Add(name)
                wages.Items.Add(salary)
                ficas.Items.Add(fica)
                fed.Items.Add(federal)
                states.Items.Add(State)
            Next

            fileReader.Close()

        End If

        ' updateLabelsAndClearBoxes()
    End Sub

    Private Sub employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employees.SelectedIndexChanged
        Dim index As Integer
        index = employees.SelectedIndex()
        If (index >= 0) Then
            hours.Clear()
            mfica.Clear()
            mfederal.Clear()
            mstate.Clear()
            gross.Clear()
            gross.Clear()
            wages.SelectedIndex = index
            ficas.SelectedIndex = index
            fed.SelectedIndex = index
            states.SelectedIndex = index
            TextBox1.Text = wages.SelectedItem
            TextBox2.Text = ficas.SelectedItem
            TextBox3.Text = fed.SelectedItem
            TextBox4.Text = states.SelectedItem

        End If


    End Sub
End Class