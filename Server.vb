Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Threading.Tasks

Module HttpSerrver
    Public Class HttpServer
        Public Static Dim listener As HttpListener
        Public Static Dim url As String = "http://localhost:5601"
        Public Static Dim pageViews As Integer = 0
        Public Static Dim requestCount As Integer = 0

        ' temporary shit '
        Public Static Dim page As String = "<html><body><h2>it works!</h2></body></html>" 

        Public Static ASync Sub Task HandleIncomingConnections()

            Dim runServer As Boolean = True 
            
            While runServer
                Dim ctx As HttpListenerContext = Await listener.GetContextAsync()
                
                Dim req As HttpListenerRequest = ctx.Request
                Dim resp As HttpListenerResponse = ctx.Response

                Console.WriteLine("Request!!!!!")
                Console.WriteLine(req.Url.ToString())
                Console.WriteLine(req.HttpMethod)
                Console.WriteLine(req.UserHostName)
                Console.WriteLine(req.UserAgent)

                

            End While

        End Sub
    End Class
End Module
