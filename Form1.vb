Imports System.Data.SqlClient
'Imports System.Data


Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If (ComboBox2 Is Nothing) = False Then
            Me.Visible = False
            Dim box = New Form3()
            box.Show()
        Else : MsgBox("Please enter a valid account number.")
        End If
    End Sub

    Private Sub ComboBox1_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        'If cmd.ExecuteScalar Is DBNull.Value = True Then 'you can save up to 40% of the resources in this way
        'End If

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        'sqlConnection1.ConnectionString = ("Provider=SQLOLEDB;Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")

        cmd.CommandText = "SELECT DISTINCT WINDOWS_USER_ID, RTrim([MI_USER_FIRST_NM]) +' '+ LTrim(RTrim([MI_USER_LAST_NM])) AS FullName, ACTIVE_FLG FROM dbo.tbl_MI_USER_ID_MAP WHERE ACTIVE_FLG='Y'ORDER BY WINDOWS_USER_ID"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        'Console.WriteLine("Connection Opened")

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        'ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        'ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'Fill a combo box with the datareader
        ComboBox1.Items.Clear()
        Do While reader.Read = True

            'ComboBox1.Items.Add(reader.FullName)
            ComboBox1.Items.Add(reader.GetString(1))

        Loop

        sqlConnection1.Close()
    End Sub

    Private Sub ComboBox13_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox13.DropDown

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        cmd.Parameters.Add(New SqlParameter("@prevd", DateTimePicker1.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@forwd", DateTimePicker2.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select isnull(cast(cast(Billing_Acctno as decimal) as varchar(20)), 'N/A') +' - ' + isnull(BILLING_STATUS_DBA,'N/A') + ', AssignedTo: ' + isnull(Billing_Assigned_To, 'Unassigned') + ' BilledDt: ' + isnull(cast(Billed_Dt as varchar(10)),'N/A') + ' FollowUp Dt: ' + isnull(cast(BILLING_FOLLOW_UP_DT as varchar(10)),'N/A') as [DESC] from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid "

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        'Console.WriteLine("Connection Opened")

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        'Fill a combo box with the datareader

        ComboBox13.Items.Clear()
        Do While reader.Read = True


            'ComboBox1.Items.Add(reader.FullName)
            ComboBox13.Items.Add(reader.GetString(0))

        Loop

        sqlConnection1.Close()

    End Sub
    Private Sub ComboBox13_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox13.LostFocus
        ComboBox13.ResetText()
        'ComboBox13.ResetText()
        'ComboBox13.SelectedIndex = -1
    End Sub
    Private Sub ComboBox2_DropDown(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox2.DropDown

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader


        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select cast(cast(billing_acctno as decimal) as varchar(20)) + ', AssignedTo: ' + isnull(billing_assigned_to, 'Unassigned') + ' Biller: ' + isnull(biller_nm, 'N/A') + 'BilledDt: ' + isnull (cast(billed_dt as varchar(10)), 'N/A') as [Desc] from dbo.billing_log_new where billing_status_dba='enter Billing' and billing_assigned_to =@winid and biller_nm not in ('CRFS_DENIALS' , 'FNMA_DENIALS' , 'QCM_DENIAL') order by billed_dt"

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        'Console.WriteLine("Connection Opened")

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        'Fill a combo box with the datareader

        ComboBox2.Items.Clear()
        Do While reader.Read = True

            'ComboBox1.Items.Add(reader.FullName)
            ComboBox2.Items.Add(reader.GetString(0))

        Loop

        sqlConnection1.Close()

    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox2.LostFocus
        ComboBox2.ResetText()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable


        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "Select count(*) from (select cast(cast(billing_acctno as decimal) as varchar(20)) + ', AssignedTo: ' + isnull(billing_assigned_to, 'Unassigned') + ' Biller: ' + isnull(biller_nm, 'N/A') + ' ' + 'BilledDt: ' + isnull (cast(billed_dt as varchar(10)), 'N/A') as [Desc]from dbo.billing_log_new where billing_status_dba='enter billing' and billing_assigned_to =@winid and biller_nm not in ('CRFS_DENIALS' , 'FNMA_DENIALS' , 'QCM_DENIAL')) as count_tp; select count(*) from (select isnull(cast(cast(Billing_Acctno as decimal) as varchar(20)), 'N/A') +' - ' + isnull(BILLING_STATUS_DBA,'N/A') + ', AssignedTo: ' + isnull(Billing_Assigned_To, 'Unassigned') + ' BilledDt: ' + isnull(cast(Billed_Dt as varchar(10)),'N/A') + ' FollowUp Dt: ' + isnull(cast(BILLING_FOLLOW_UP_DT as varchar(10)),'N/A') as [DESC] from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid ) as count_ttp"

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        'Fill a combo box with the datareader

        TextBox1.Clear()

        Do While reader.Read = True

            TextBox1.Text = Convert.ToString(reader(0))


        Loop

        reader.NextResult()

        TextBox2.Clear()

        Do While reader.Read = True

            TextBox2.Text = Convert.ToString(reader(0))


        Loop


        sqlConnection1.Close()
    End Sub


End Class
