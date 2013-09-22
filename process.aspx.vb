Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.SqlTypes

Partial Class process
    Inherits System.Web.UI.Page
    Dim Name, Phone, Email, Message, MailVar, SubjectVar As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Name = Request.Form("name")
            Phone = Request.Form("phone")
            Email = Request.Form("email")
            Message = Request.Form("message")
            SubjectVar = Request.Form("SubjectVar")

           

            MailVar = " Name = " & Name & vbCrLf
            MailVar = MailVar & " phone = " & Phone & vbCrLf
            MailVar = MailVar & " email = " & Email & vbCrLf
            MailVar = MailVar & " message = " & Message & vbCrLf


            mailMessage.Text = MailVar


            '*  Second try

            Dim MyMailMessage As New System.Net.Mail.MailMessage(Email, "sales@imperialtrees.com", SubjectVar, Message)
            MyMailMessage.IsBodyHtml = False
            MyMailMessage.Body = MailVar
            'provide Authentication Details need to be passed when sending email from gmail
            Dim mailAuthentication As New System.Net.NetworkCredential("sales@imperialtrees.com", "imperial3")
            'Sender password

            'Smtp Mail server of Gmail is "smpt.gmail.com" and it uses port no. 587
            ' Dim mailClient As New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            'Dim mailClient As New System.Net.Mail.SmtpClient("smtp.emailsrvr.com", 25)
            Dim mailClient As New System.Net.Mail.SmtpClient("mymail5.myregisteredsite.com", 25)
            'Enable SSL

            'mailClient.EnableSsl = True
            mailClient.UseDefaultCredentials = False
            mailClient.Credentials = mailAuthentication
            mailClient.Send(MyMailMessage)


            '*  End Second try


            ' Response.Redirect("thank-you.html")
        Catch ex As Exception
            errorMessage.Text = ex.Message
        End Try
        
    End Sub



End Class
