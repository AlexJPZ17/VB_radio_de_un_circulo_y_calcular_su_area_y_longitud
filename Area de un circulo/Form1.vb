Public Class Form1
    Private Sub Circulo()
        'Declaramos las variables
        Dim area, longitud, radio As Double
        'Obtenemos el datos ingresado
        radio = Convert.ToDouble(TextBox_Radio.Text)
        'Formula para calcular el área del circulo
        area = Math.PI * (radio ^ 2)
        'Formula para calcular la longitud del circulo
        longitud = 2 * Math.PI * radio
        'Mostramos los resultados en las label
        Label_Area.Text = area.ToString() & " cm"
        Label_Longitud.Text = longitud.ToString() & " cm"
    End Sub

    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Circulo()
    End Sub
End Class
