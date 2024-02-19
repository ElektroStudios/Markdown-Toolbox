''' <summary>
''' Provides the default directory and file paths for this application.
''' </summary>
Friend Module Paths

    ''' <summary>
    ''' Directory path where to save the Jot cache data.
    ''' </summary>
    Friend JotCachePath As String = $"{My.Application.Info.DirectoryPath}\cache\jot"

    ''' <summary>
    ''' Directory path where to save the CefSharp cache data.
    ''' </summary>
    Friend CefSharpCachePath As String = $"{My.Application.Info.DirectoryPath}\cache\CefSharp"

    ''' <summary>
    ''' File path where to save the CefSharp log file.
    ''' </summary>
    Friend CefSharpLogFilePath As String = $"{My.Application.Info.DirectoryPath}\CefSharp.log"

End Module
