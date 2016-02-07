Public Class Form1
    ' Navigo tek url e dhene.
    ' Kur klikojme enter shkojme ne url e dhene
    Private Sub toolStripTextBox1_KeyDown(
    ByVal sender As Object, ByVal e As KeyEventArgs) _
    Handles UrlBox.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Navigate(UrlBox.Text)
        End If

    End Sub

    ' Navigojme ne URL e dhene kur klikojme butonin GO
    Private Sub goButton_Click(
    ByVal sender As Object, ByVal e As EventArgs) _
    Handles GoButton.Click
        Navigate(UrlBox.Text)

    End Sub

    'Navigojme nese url e dhene  eshte e sakte
    Private Sub Navigate(ByVal address As String)

        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") And
        Not address.StartsWith("https://") Then
            address = "http://" & address
        End If

        Try
            Faqja.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            Return
        End Try

    End Sub

    ' Rifresko url e dhene nga perdoruesi
    Private Sub webBrowser1_Navigated(ByVal sender As Object,
    ByVal e As WebBrowserNavigatedEventArgs) _
    Handles Faqja.Navigated

        UrlBox.Text = Faqja.Url.ToString()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Faqja.GoBack()
    End Sub
End Class
