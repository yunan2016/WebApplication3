Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (textbox1.Text = "" Or textbox2.Text = "") Then
            errormsg.Visible = True
        Else



            Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
            Using con As New SqlConnection(constr)
                Using cmd As New SqlCommand("SELECT TimeDate,EnteredBy,Contacted,Outcome,Action,Bywhom,DueDate FROM TContactLog where CRESID ='" & textbox1.Text & "'", con)
                    Using sda As New SqlDataAdapter()
                        cmd.Connection = con
                        sda.SelectCommand = cmd
                        Using dt As New DataTable()
                            sda.Fill(dt)
                            gridview1.DataSource = dt
                            gridview1.DataBind()

                        End Using
                    End Using
                End Using
            End Using
            Dim ename As String
            Dim strConnString1 As [String] = System.Configuration.ConfigurationManager.ConnectionStrings("conString").ConnectionString
            Dim con1 As New SqlConnection(strConnString1)
            con1.Open()
            Dim myReader1 As SqlDataReader = Nothing
            Dim myCommand1 As SqlCommand = New SqlCommand("select EName from TACode where ACode='" & textbox2.Text & "'", con1)
            myReader1 = myCommand1.ExecuteReader()
            While myReader1.Read()

                Textboxval.Text = (myReader1("EName").ToString())
                ename = TextBox3.Text
            End While
            con1.Close()
        End If
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub button2_Click(sender As Object, e As EventArgs)
        If (textbox1.Text = "" Or textbox2.Text = "") Then
            errormsg.Visible = True
        Else
            Dim ename As String
            Dim strConnString1 As [String] = System.Configuration.ConfigurationManager.ConnectionStrings("conString").ConnectionString
            Dim con1 As New SqlConnection(strConnString1)
            con1.Open()
            Dim myReader1 As SqlDataReader = Nothing
            Dim myCommand1 As SqlCommand = New SqlCommand("select EName from TACode where ACode='" & textbox2.Text & "'", con1)
            myReader1 = myCommand1.ExecuteReader()
            While myReader1.Read()

                Textboxval.Text = (myReader1("EName").ToString())
                ename = TextBox3.Text
            End While
            con1.Close()
            label1.Visible = True
            label2.Visible = True
            label3.Visible = True
            label4.Visible = True
            label5.Visible = True
            Label6.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            button3.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            Dim t As Date = Today
            label1.Text = t
            label2.Text = Textboxval.Text
        End If
    End Sub
    Protected Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click


        label1.Visible = True
    End Sub

End Class