Imports MaterialSkin.Controls
Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)


        Label1.ForeColor = Color.White
        Label2.Text = DateTime.Now.ToString("HH:mm:ss")
        Label2.ForeColor = Color.White
        Label1.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 1000
        Label2.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
End Class
