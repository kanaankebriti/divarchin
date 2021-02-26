Public NotInheritable Class AboutBox_divarchin
    Private repo_url As String = "https://github.com/kanaankebriti/divarchin"

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.Label_name_and_licence.Text = My.Application.Info.Description
        Me.Label_version.Text = String.Format("نسخه {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub Button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel_link_to_repo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_link_to_repo.LinkClicked
        System.Diagnostics.Process.Start(repo_url)
    End Sub
End Class
