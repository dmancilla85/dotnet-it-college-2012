Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim outputFileName As String = "C:\clientes.xml"
        'Dim returnValue As XmlWriter

        'returnValue = XmlWriter.Create(outputFileName)

        'ds.WriteXml(returnValue, XmlWriteMode.IgnoreSchema)

        'Dim ds As New DataSet1

        Dim conn As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\gabriela\Facturacion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        Dim da As New SqlClient.SqlDataAdapter("sELECT * FROM CLIENTES", conn)
        Dim ds As New Data.DataSet

        da.Fill(ds, "CLIENTES")


        If ds Is Nothing Then
            Return
        End If

        ' Write the XML schema and data to file with FileStream.
        Dim xmlFilename As String = "ClientesXML.xml"

        ' Create FileStream    
        Dim fsWriteXml As New System.IO.FileStream _
            (xmlFilename, System.IO.FileMode.Create)

        ' Create an XmlTextWriter to write the file.
        Dim xmlWriter2 As New System.Xml.XmlTextWriter _
            (fsWriteXml, System.Text.Encoding.Unicode)

        ' Use WriteXml to write the document.
        ds.WriteXml(xmlWriter2)

        ' Close the FileStream.
        fsWriteXml.Close()

        ' Dispose of the original DataSet.
        ds.Dispose()






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
