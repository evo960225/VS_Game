
Module ModWinAPI
    Public Declare Function GetCursorPos Lib "user32" Alias "GetCursorPos" (ByRef lpPoint As POINTAPI) As Long
    Public Declare Function BitBlt Lib "gdi32.dll" Alias "BitBlt" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, _
                                                                   ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, _
                                                                   ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Long

    Public Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure
End Module
