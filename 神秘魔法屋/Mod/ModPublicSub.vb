Module ModPublicSub
    Public Sub sawp(ByRef a, ByRef b)
        Dim tmp
        tmp = a : a = b : b = tmp
    End Sub
    Public Sub ClearArrRank2(ByRef arr As Array, Optional ByVal n As Integer = 0)
        For i = 0 To UBound(arr, 1)
            For j = 0 To UBound(arr, 2)
                arr(i, j) = n
            Next
        Next
    End Sub

End Module
