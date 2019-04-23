Public Class StaticsForm

    Dim panTotalcolor As Color
    Dim panMalecolor As Color
    Dim panFemalecolor As Color

    Private Sub StaticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panTotalcolor = PanelTotal.BackColor
        panMalecolor = PanelMale.BackColor
        panFemalecolor = PanelFemale.BackColor

        'Display the values
        Dim StudentTotal As New Student()
        Dim total As Integer = Convert.ToInt32(StudentTotal.TotalStudent())
        Dim totalMale As Integer = Convert.ToInt32(StudentTotal.TotalMaleStudent())
        Dim totalFemale As Integer = Convert.ToInt32(StudentTotal.TotalFemaleStudent())

        'Count the percentage male students
        '(total male/female X 100) /(student total)
        Dim maleStudentsPercent As Integer = (totalMale * 100) / total
        Dim femaleStudentsPercent As Integer = (totalFemale * 100) / total

        LabelTotal.Text = "Total Students: " & total.ToString()
        LabelMale.Text = "Male Students Percentage: " & maleStudentsPercent.ToString() & "%"
        LabelFemale.Text = "Female Students Percentage: " & femaleStudentsPercent.ToString() & "%"

    End Sub

    Private Sub LabelTotal_MouseEnter(sender As Object, e As EventArgs) Handles LabelTotal.MouseEnter

        LabelTotal.ForeColor = panTotalcolor
        PanelTotal.BackColor = Color.White

    End Sub

    Private Sub LabelTotal_MouseLeave(sender As Object, e As EventArgs) Handles LabelTotal.MouseLeave
        LabelTotal.ForeColor = Color.White
        PanelTotal.BackColor = panTotalcolor
    End Sub

    Private Sub LabelMale_MouseEnter(sender As Object, e As EventArgs) Handles LabelMale.MouseEnter
        LabelMale.ForeColor = panMalecolor
        PanelMale.BackColor = Color.White

    End Sub

    Private Sub LabelMale_MouseLeave(sender As Object, e As EventArgs) Handles LabelMale.MouseLeave
        LabelMale.ForeColor = Color.White
        PanelMale.BackColor = panMalecolor

    End Sub

    Private Sub LabelFemale_MouseEnter(sender As Object, e As EventArgs) Handles LabelFemale.MouseEnter
        LabelFemale.ForeColor = panFemalecolor
        PanelFemale.BackColor = Color.White

    End Sub

    Private Sub LabelFemale_MouseLeave(sender As Object, e As EventArgs) Handles LabelFemale.MouseLeave
        LabelFemale.ForeColor = Color.White
        PanelFemale.BackColor = panFemalecolor

    End Sub
End Class