Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            'Dim AppLanguageID As String
            'AppLanguageID = "de"  ' "de", ... 
            'Dim Culture As System.Globalization.CultureInfo
            'Culture = New System.Globalization.CultureInfo(AppLanguageID)
            'System.Threading.Thread.CurrentThread.CurrentUICulture = Culture
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show("Fehler!" & vbNewLine & e.Exception.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

    End Class


End Namespace

