Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filePath As String = "authors.xml"

        AuthorsDataSet1.ReadXml(filePath)

        DataGridView1.DataSource = AuthorsDataSet1
        DataGridView1.DataMember = "authors"

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class