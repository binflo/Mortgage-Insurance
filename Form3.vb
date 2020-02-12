Imports System.Data.SqlClient
Imports System.Data
Public Class Form3


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick

    End Sub
    'Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
    '    Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
    '    Dim cmd As New SqlCommand
    '    Dim reader As SqlDataReader
    '    Dim dt As New DataTable
    '    'Dim ds As New DataSet()
    '    'Dim da As New SqlDataAdapter(

    '    cmd.Parameters.Add(New SqlParameter("@acctno", TextBox4.Text))

    '    cmd.CommandText = "SELECT BILLING_RESPONSIBLE_PARTY_NM,RESPONSIBLE_PARTY_NM, BILLED_BY_INVESTOR_AMT, BILLING_CAUSE_NM FROM dbo.ResponsibilityAssignment_LOG WHERE BE_ACCTNO =@acctno"
    '    cmd.CommandType = CommandType.Text
    '    cmd.Connection = sqlConnection1

    '    sqlConnection1.Open()

    '    reader = cmd.ExecuteReader()

    '    dt.Load(reader)

    '    Do While reader.Read = True

    '        CheckedListBox1.DataSource = dt

    '        sqlConnection1.Close()

    '    Loop


    '    For i = 0 To CheckedListBox1.Items.Count - 1
    '        CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
    '    Next
    '    CheckedListBox1.SetItemCheckState(CheckedListBox1.SelectedIndex, CheckState.Checked)





    'End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'For i = 0 To CheckedListBox1.Items.Count - 1
        '    CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
        'Next
        'CheckedListBox1.SetItemCheckState(CheckedListBox1.SelectedIndex, CheckState.Checked)

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable
        'Dim ds As New DataSet()
        'Dim da As New SqlDataAdapter(

        cmd.Parameters.Add(New SqlParameter("@acctno", TextBox4.Text))

        cmd.CommandText = "SELECT BILLING_RESPONSIBLE_PARTY_NM,RESPONSIBLE_PARTY_NM, BILLED_BY_INVESTOR_AMT, BILLING_CAUSE_NM FROM dbo.ResponsibilityAssignment_LOG WHERE BE_ACCTNO =@acctno"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        dt.Load(reader)

        'Do While reader.Read = True

        ListBox1.DataSource = dt

        sqlConnection1.Close()

        'Loop
    End Sub
End Class
