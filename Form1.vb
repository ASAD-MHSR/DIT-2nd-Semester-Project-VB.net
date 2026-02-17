Public Class Form1
    ' Form Load Event: Runs when the program starts
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Star Group - Contact Management System"
        lblStatus.Text = "System Ready"
    End Sub
    
    ' Add Contact Button: Logic to add text from boxes to the list
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validation: Check if text boxes are empty
        If txtName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Please fill all fields before adding!", MsgBoxStyle.Exclamation, "Input Error")
            lblStatus.Text = "Error: Please fill all fields"
        Else
            ' Adding data to the ListBox with all three fields
            Dim contactInfo As String
            contactInfo = txtName.Text & " | " & txtPhone.Text & " | " & txtEmail.Text
            lstContacts.Items.Add(contactInfo)
            ' Success Message
            MsgBox("Contact Saved Successfully!", MsgBoxStyle.Information, "Success")
            lblStatus.Text = "Contact added successfully!"
            ' Automatic call to clear fields for next entry
            btnClear_Click(sender, e)
        End If
    End Sub
    
    ' Clear Button: Clears all input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtName.Focus() ' Sets cursor back to Name field
        lblStatus.Text = "System Ready"
    End Sub
    
    ' Exit Button: Closes the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit System")
        If result = DialogResult.Yes Then
            End
        End If
    End Sub
End Class
