Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(70, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 270)
        Me.DataGridView1.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(618, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(238, 270)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(625, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.Location = New System.Drawing.Point(628, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Enter Billing"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.Location = New System.Drawing.Point(628, 93)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Appeal Needed"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton3.Location = New System.Drawing.Point(628, 116)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(131, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Supplemental Pending"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton4.Location = New System.Drawing.Point(628, 139)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Pending Biller Response"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton5.Location = New System.Drawing.Point(628, 162)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "More Info Needed"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton6.Location = New System.Drawing.Point(628, 185)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(151, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Additional Review Needed"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton7.Location = New System.Drawing.Point(628, 208)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton7.TabIndex = 11
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Closed By Biller"
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton8.Location = New System.Drawing.Point(628, 231)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton8.TabIndex = 12
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Concur/Agree"
        Me.RadioButton8.UseVisualStyleBackColor = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton9.Location = New System.Drawing.Point(628, 254)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton9.TabIndex = 13
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Resolved"
        Me.RadioButton9.UseVisualStyleBackColor = False
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton10.Location = New System.Drawing.Point(628, 277)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton10.TabIndex = 14
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Denial"
        Me.RadioButton10.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(795, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(46, 20)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(795, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(46, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(795, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(46, 20)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(795, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(46, 20)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(795, 185)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(46, 20)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(795, 162)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(46, 20)
        Me.TextBox6.TabIndex = 20
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(795, 208)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(46, 20)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(795, 254)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(46, 20)
        Me.TextBox8.TabIndex = 22
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(795, 277)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(46, 20)
        Me.TextBox9.TabIndex = 23
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(795, 231)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(46, 20)
        Me.TextBox10.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(806, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Count"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Label4"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(408, 13)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 27
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(907, 321)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton

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
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True
        RadioButton10.Enabled = True


        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable
        'Dim ds As New DataSet()
        'Dim da As New SqlDataAdapter(


        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select COUNT(*) from(select billing_acctno from dbo.billing_log_new where billing_assigned_to =@winid and BILLING_STATUS_DBA in ('enter billing'))as count_tp;" & _
        "select COUNT(*) from(select billing_acctno from dbo.billing_log_new where billing_assigned_to =@winid and BILLING_STATUS_DBA in ('Appeal Needed'))as count_tp;" & _
        "select billing_acctno, fnma_nbr, billing_assigned_to, billing_status_dba from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid"
        '"select count(*) from (select isnull(cast(cast(Billing_Acctno as decimal) as varchar(20)), 'N/A') +' - ' + isnull(BILLING_STATUS_DBA,'N/A') + ', AssignedTo: ' + isnull(Billing_Assigned_To, 'Unassigned') + ' BilledDt: ' + isnull(cast(Billed_Dt as varchar(10)),'N/A') + ' FollowUp Dt: ' + isnull(cast(BILLING_FOLLOW_UP_DT as varchar(10)),'N/A') as [DESC] from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid ) as count_ttp;" & _

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

        reader.NextResult()

        DataGridView1.ClearSelection()

        'Do While reader.Read = True

        dt.Load(reader)

        DataGridView1.DataSource = dt



        'Loop



        sqlConnection1.Close()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable

        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select billing_acctno, fnma_nbr, billing_assigned_to, billing_status_dba from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid and billing_status_dba='enter billing'"

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        'Console.WriteLine("Connection Opened")



        reader = cmd.ExecuteReader()

        ' Data is accessible through the DataReader object here.

        'Fill a combo box with the datareader

        DataGridView1.ClearSelection()

        'Do While reader.Read = True

        'ComboBox1.Items.Add(reader.FullName)

        If reader.HasRows = True Then


            dt.Load(reader)
        End If




        DataGridView1.DataSource = dt





        'Loop

        sqlConnection1.Close()


    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable

        If Len(TextBox11.Text) < 8 Then
            'MsgBox("enter word to search for")
            Exit Sub
        End If

        cmd.Parameters.Add(New SqlParameter("@serch", TextBox11.Text().ToString))
        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select billing_acctno, fnma_nbr, billing_assigned_to, billing_status_dba from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid and billing_acctno=@serch"

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()


        'Do While reader.Read = True

        'ComboBox1.Items.Add(reader.FullName)
        dt.Load(reader)

        If dt.Rows Is Nothing Then
            MsgBox("No result found")
            Exit Sub
        End If

        DataGridView1.DataSource = dt



        DataGridView1.ClearSelection()

        sqlConnection1.Close()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Dim sqlConnection1 As New SqlConnection("Data Source=rc110605\rapva;Initial Catalog=MI_Temp_Data;User ID =RecourseUser; Password=Recourse#123;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable


        cmd.Parameters.Add(New SqlParameter("@winid", ComboBox1.Text))

        cmd.CommandText = "select billing_acctno, fnma_nbr, billing_assigned_to, billing_status_dba from dbo.BILLING_LOG_NEW where billing_assigned_to =@winid and billing_status_dba='Appeal Needed'"

        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        'Console.WriteLine("Connection Opened")

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        'Fill a combo box with the datareader

        DataGridView1.ClearSelection()

        'Do While reader.Read = True

        'ComboBox1.Items.Add(reader.FullName)
        dt.Load(reader)

        DataGridView1.DataSource = dt




        'Loop

        sqlConnection1.Close()
    End Sub

    'Private Sub RadioButton1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.LostFocus
    '    RadioButton1.Checked = False
    'End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        ''If ComboBox1.Text = "" Then RadioButton1.Enabled = False Else RadioButton1.Enabled = True
        'If ComboBox1.Text = "" Then
        '    RadioButton1.Enabled = False
        '    MsgBox("Fill the associate name first")
        '    RadioButton1.ResumeLayout()
        'Else
        '    ComboBox1.Text = Me.Text
        '    RadioButton1.Enabled = True
        '    If ComboBox1.Text = " " Then
        '        RadioButton1.Enabled = False
        '        MsgBox("Fill the associate name first")
        'End If
    End Sub

    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        RadioButton7.Enabled = False
        RadioButton8.Enabled = False
        RadioButton9.Enabled = False
        RadioButton10.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index 'gets a collection that contains all the rows

        Form3.TextBox4.Text = DataGridView1.Item("billing_acctno", i).Value.ToString
        'Me.txtSupplierName.Text = DataGridView1.Item(1, i).Value.ToString
        'Me.txtSupplierSurname.Text = DataGridView1.Item(2, i).Value
        'Me.txtAddress.Text = DataGridView1.Item(3, i).Value
        'Me.txtPhoneNumber.Text = DataGridView1.Item(4, i).Value
        'Me.txtEmailAddress.Text = DataGridView1.Item(5, i).Value

        'MsgBox("cell clicked")
        'Form1.TextBox1.Text = DataGridView1.Item("column name/column index", DataGridView1.CurrentRow.Index).Value.ToString()
        Form3.Show()
        Me.Hide()

    End Sub


End Class
