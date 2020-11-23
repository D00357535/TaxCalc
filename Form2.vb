Imports System.IO
Imports System.Text
Public Class Form2

    ' Dim DataChanged As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveData()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub SaveData()
        Dim SourcePath As String = "C:\Users\D00357535\source\repos\TaxCalc\employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(SourcePath)
        Dim count, i As Integer
        count = ListBox1.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(ListBox1.Items(i))
            fStreamWriter.WriteLine(ListBox2.Items(i))
            fStreamWriter.WriteLine(ListBox3.Items(i))
            fStreamWriter.WriteLine(ListBox4.Items(i))
            fStreamWriter.WriteLine(ListBox5.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

        ' dataChanged = False
        ' EnableAndDisable()
    End Sub

    Private Sub LoadData()

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

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

                ListBox1.Items.Add(name)
                ListBox2.Items.Add(salary)
                ListBox3.Items.Add(fica)
                ListBox4.Items.Add(federal)
                ListBox5.Items.Add(State)
            Next

            fileReader.Close()

        End If

        ' updateLabelsAndClearBoxes()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index As Integer
        index = ListBox1.SelectedIndex()
        If (index >= 0) Then
            ListBox2.SelectedIndex = index
            ListBox3.SelectedIndex = index
            ListBox4.SelectedIndex = index
            ListBox5.SelectedIndex = index
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = ListBox2.SelectedItem
            TextBox3.Text = ListBox3.SelectedItem
            TextBox4.Text = ListBox4.SelectedItem
            TextBox5.Text = ListBox5.SelectedItem

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SourcePath As String = "C:\Users\D00357535\source\repos\TaxCalc\employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(SourcePath)
        Dim count, i As Integer
        count = ListBox1.Items.Count + 1
        fStreamWriter.WriteLine(count)
        If count > 1 Then
            For i = 0 To count - 2
                fStreamWriter.WriteLine(ListBox1.Items(i))
                fStreamWriter.WriteLine(ListBox2.Items(i))
                fStreamWriter.WriteLine(ListBox3.Items(i))
                fStreamWriter.WriteLine(ListBox4.Items(i))
                fStreamWriter.WriteLine(ListBox5.Items(i))
            Next
        End If
        fStreamWriter.WriteLine(TextBox1.Text)
        fStreamWriter.WriteLine(TextBox2.Text)
        fStreamWriter.WriteLine(TextBox3.Text)
        fStreamWriter.WriteLine(TextBox4.Text)
        fStreamWriter.WriteLine(TextBox5.Text)
        fStreamWriter.Flush()
        fStreamWriter.Close()
        LoadData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim SourcePath As String = "C:\Users\D00357535\source\repos\TaxCalc\employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(SourcePath)
        Dim count, i, si As Integer
        si = ListBox1.SelectedIndex
        count = ListBox1.Items.Count - 1
        fStreamWriter.WriteLine(count)
        For i = 0 To count
            If Not i = si Then
                fStreamWriter.WriteLine(ListBox1.Items(i))
                fStreamWriter.WriteLine(ListBox2.Items(i))
                fStreamWriter.WriteLine(ListBox3.Items(i))
                fStreamWriter.WriteLine(ListBox4.Items(i))
                fStreamWriter.WriteLine(ListBox5.Items(i))
            End If
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()
        LoadData()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SourcePath As String = "C:\Users\D00357535\source\repos\TaxCalc\employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(SourcePath)
        Dim count, i, si As Integer
        si = ListBox1.SelectedIndex
        count = ListBox1.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            If i = si Then
                fStreamWriter.WriteLine(TextBox1.Text)
                fStreamWriter.WriteLine(TextBox2.Text)
                fStreamWriter.WriteLine(TextBox3.Text)
                fStreamWriter.WriteLine(TextBox4.Text)
                fStreamWriter.WriteLine(TextBox5.Text)
            End If
            If Not i = si Then
                fStreamWriter.WriteLine(ListBox1.Items(i))
                fStreamWriter.WriteLine(ListBox2.Items(i))
                fStreamWriter.WriteLine(ListBox3.Items(i))
                fStreamWriter.WriteLine(ListBox4.Items(i))
                fStreamWriter.WriteLine(ListBox5.Items(i))
            End If
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()
        LoadData()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim index As Integer
        index = ListBox2.SelectedIndex()
        If (index >= 0) Then
            ListBox1.SelectedIndex = index
            ListBox3.SelectedIndex = index
            ListBox4.SelectedIndex = index
            ListBox5.SelectedIndex = index
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = ListBox2.SelectedItem
            TextBox3.Text = ListBox3.SelectedItem
            TextBox4.Text = ListBox4.SelectedItem
            TextBox5.Text = ListBox5.SelectedItem

        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim index As Integer
        index = ListBox3.SelectedIndex()
        If (index >= 0) Then
            ListBox2.SelectedIndex = index
            ListBox1.SelectedIndex = index
            ListBox4.SelectedIndex = index
            ListBox5.SelectedIndex = index
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = ListBox2.SelectedItem
            TextBox3.Text = ListBox3.SelectedItem
            TextBox4.Text = ListBox4.SelectedItem
            TextBox5.Text = ListBox5.SelectedItem

        End If
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        Dim index As Integer
        index = ListBox4.SelectedIndex()
        If (index >= 0) Then
            ListBox2.SelectedIndex = index
            ListBox3.SelectedIndex = index
            ListBox1.SelectedIndex = index
            ListBox5.SelectedIndex = index
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = ListBox2.SelectedItem
            TextBox3.Text = ListBox3.SelectedItem
            TextBox4.Text = ListBox4.SelectedItem
            TextBox5.Text = ListBox5.SelectedItem

        End If
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        Dim index As Integer
        index = ListBox5.SelectedIndex()
        If (index >= 0) Then
            ListBox2.SelectedIndex = index
            ListBox3.SelectedIndex = index
            ListBox4.SelectedIndex = index
            ListBox1.SelectedIndex = index
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = ListBox2.SelectedItem
            TextBox3.Text = ListBox3.SelectedItem
            TextBox4.Text = ListBox4.SelectedItem
            TextBox5.Text = ListBox5.SelectedItem

        End If
    End Sub
End Class