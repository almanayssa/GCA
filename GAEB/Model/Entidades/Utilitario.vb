Namespace SGS.Model.Entidades
    Public Class Utilitario

        Public Shared Function getDefaultOrIntDBValue(ByVal obj As [Object]) As Integer
            If obj IsNot Nothing AndAlso Not Convert.IsDBNull(obj) Then
                Return Convert.ToInt32(obj)
            Else
                Return 0
            End If
        End Function

        Public Shared Function getDefaultOrDoubleDBValue(ByVal obj As [Object]) As Double
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToDouble(obj)
            Else
                Return 0.0
            End If
        End Function

        Public Shared Function getDefaultOrDecimalDBValue(ByVal obj As [Object]) As Decimal
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToDecimal(obj)
            Else
                Return 0.0
            End If
        End Function

        Public Shared Function getDefaultOrStringDBValue(ByVal obj As [Object]) As [String]
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToString(obj)
            Else
                Return ""
            End If
        End Function

        Public Shared Function getDefaultOrDatetimeDBValue(ByVal obj As [Object]) As DateTime
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToDateTime(obj)
            Else
                Return DateTime.Now
            End If
        End Function

        Public Shared Function getDefaultOrBooleanDBValue(ByVal obj As [Object]) As Boolean
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToBoolean(obj)
            Else
                Return False
            End If
        End Function

        Public Shared Function getDefaultOrDateDBValue(ByVal obj As [Object]) As Date
            If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
                Return Convert.ToDateTime(obj)
            Else
                Return DateTime.Today
            End If
        End Function

        Public Shared Function getDefaultOrTimeDBValue(ByVal obj As [Object]) As TimeSpan
            'If obj IsNot Nothing OrElse Convert.IsDBNull(obj) Then
            '    Return Convert.ToDateTime(obj).TimeOfDay
            'Else
            Return DateTime.Now.TimeOfDay
            'End If
        End Function
    End Class
End Namespace
