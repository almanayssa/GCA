Imports SGS.Model.Entidades

Public Class Helper

    Public Shared Function ObtenerFrecuenciaDiaria(ByVal num_dias As Integer, ByVal searchedMonthYear As DateTime, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime, ByRef oListadoActividad As List(Of ActividadBE)) As List(Of ActividadBE)
        Dim oActividad As ActividadBE
        Dim tempDate As DateTime     ' This date will be the moving date

        ' Calculates the last day of the searched month
        Dim lastDayOfSearchedMonth As DateTime
        lastDayOfSearchedMonth = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1).AddMonths(1).AddDays(-1)

        ' If enddate is not specified (forever) end date becomes the last day of the searched month
        If fec_fin = Nothing Then fec_fin = lastDayOfSearchedMonth

        ' Temporary date starts on the start date
        tempDate = fec_ini

        ' Iterates while the temporary date is lower or equal than the last day of the month or less or equal than the end date
        While (tempDate <= lastDayOfSearchedMonth) And (tempDate <= fec_fin)
            oActividad = New ActividadBE

            ' If the temp date is within the searched month, then it adds the date to the collection
            If tempDate.Month = searchedMonthYear.Month And tempDate.Year = searchedMonthYear.Year Then
                If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                    oActividad.fec_ini = tempDate
                    oListadoActividad.Add(oActividad)
                End If
            End If

            ' Temporary dates advances according to the periodic days entered
            tempDate = tempDate.AddDays(num_dias)

        End While

        Return oListadoActividad

    End Function

    Public Shared Function ObtenerFrecuenciaMensual(ByVal monthsNumber As Integer, ByVal ordinal As Integer, ByVal dayNumber As DayOfWeek, ByVal searchedMonthYear As DateTime, ByVal startDate As DateTime, ByVal endDate As DateTime, ByRef oListadoActividad As List(Of ActividadBE)) As List(Of ActividadBE)
        Dim tempDate As DateTime       ' This date will be the moving date
        Dim initialDate As DateTime    ' This date can be the start date or the first day of the searched month       
        Dim isMonthInPeriod As Boolean ' Flag that will tell whether the searched month is one of those in the period (ex. if monthsNumber is 2 and startDate is on January, then months that will raise this flag are: January, March, May, July, etc).
        Dim dom_cont As Integer = 0 ' Individual counters
        Dim lun_cont As Integer = 0
        Dim mar_cont As Integer = 0
        Dim mie_cont As Integer = 0
        Dim jue_cont As Integer = 0
        Dim vie_cont As Integer = 0
        Dim sab_cont As Integer = 0

        ' Calculates the last day of the searched month
        Dim lastDayOfSearchedMonth As DateTime
        lastDayOfSearchedMonth = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1).AddMonths(1).AddDays(-1)

        ' Gets the date of the last searched day (e.g. last sunday or last thrusday)
        Dim dateOfLastDay As DateTime = ObtenerUltimoDiaMes(dayNumber, searchedMonthYear.Year, searchedMonthYear.Month)

        ' First day of the searched month
        Dim firstDayOfSearchedMonth As New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1)
        Dim firstDayOfStartMonth As New DateTime(startDate.Year, startDate.Month, 1)
        Dim firstDayOfTempDate As DateTime

        ' If enddate is not specified (forever) end date becomes the last day of the searched month
        If endDate = Nothing Then endDate = lastDayOfSearchedMonth

        ' This portion validates that this month has dates to print or if this is a jumping month (that should not include dates)
        isMonthInPeriod = False
        firstDayOfTempDate = firstDayOfStartMonth
        While firstDayOfTempDate <= firstDayOfSearchedMonth
            If firstDayOfTempDate = firstDayOfSearchedMonth Then
                isMonthInPeriod = True
            End If
            firstDayOfTempDate = firstDayOfTempDate.AddMonths(monthsNumber)
        End While

        ' If searched month is greater or equal than start month then calculates, else it should return empty
        If firstDayOfSearchedMonth >= firstDayOfStartMonth And isMonthInPeriod Then

            ' Calculates the first date of the searched month
            initialDate = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1)

            ' Temporary date starts on previous sunday of first day of the month
            tempDate = initialDate.AddDays(-DatePart(DateInterval.Weekday, initialDate, Microsoft.VisualBasic.FirstDayOfWeek.Sunday) + 1)
            '  End If

        Else
            ' Forces the while not to execute
            tempDate = endDate.AddDays(1)
        End If

        ' While temp date is less than the end of the month and is less than the end date
        While (tempDate <= lastDayOfSearchedMonth) And (tempDate <= endDate)

            ' If temporary date is greater than the initial date, analizes that day
            If tempDate >= initialDate Then

                Select Case tempDate.DayOfWeek
                    Case DayOfWeek.Sunday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Sunday, dom_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Monday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Monday, lun_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Tuesday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Tuesday, mar_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Wednesday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Wednesday, mie_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Thursday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Thursday, jue_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Friday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Friday, vie_cont, searchedMonthYear, tempDate, oListadoActividad)
                    Case DayOfWeek.Saturday
                        EvaluarOrdinal(ordinal, dayNumber, dateOfLastDay, DayOfWeek.Saturday, sab_cont, searchedMonthYear, tempDate, oListadoActividad)
                End Select

            End If

            tempDate = tempDate.AddDays(1)

        End While

        Return oListadoActividad

    End Function

    Public Shared Function ObtenerFrecuenciaMensual(ByVal monthsNumber As Integer, ByVal dayOfMonth As Integer, ByVal searchedMonthYear As DateTime, ByVal startDate As DateTime, ByVal endDate As DateTime, ByRef oEventCollection As List(Of ActividadBE)) As List(Of ActividadBE)
        Dim oActividad As ActividadBE
        Dim tempDate As DateTime     ' This date will be the moving date
        Dim daysInMonth As Integer

        ' Calculates the last day of the searched month
        Dim lastDayOfSearchedMonth As DateTime
        lastDayOfSearchedMonth = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1).AddMonths(1).AddDays(-1)

        ' If enddate is not specified (forever) end date becomes the last day of the searched month
        If endDate = Nothing Then endDate = lastDayOfSearchedMonth

        ' Temporary date starts on the start date
        tempDate = New DateTime(startDate.Year, startDate.Month, dayOfMonth)

        ' Iterates while the temporary date is lower or equal than the last day of the month or less or equal than the end date
        While (tempDate <= lastDayOfSearchedMonth) And (tempDate <= endDate)
            oActividad = New ActividadBE

            ' If the temp date is within the searched month, then it adds the date to the collection
            If tempDate.Month = searchedMonthYear.Month And tempDate.Year = searchedMonthYear.Year Then
                If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                    oActividad.fec_ini = tempDate
                    oEventCollection.Add(oActividad)
                End If
            End If

            ' Temporary dates advances according to the periodic monhts entered
            tempDate = tempDate.AddMonths(monthsNumber)

            ' Gets the number of days in the next month
            daysInMonth = DateTime.DaysInMonth(tempDate.Year, tempDate.Month)

            ' If the dayOfMonth is one of the last days and the dayOfMonth is greater than days in month, resets to dayOfMonth
            If daysInMonth >= dayOfMonth And dayOfMonth >= 28 Then
                tempDate = New DateTime(tempDate.Year, tempDate.Month, dayOfMonth)
            End If

        End While

        Return oEventCollection

    End Function

    Private Shared Function ObtenerUltimoDiaMes(ByVal dia_semana As DayOfWeek, ByVal anio As Integer, ByVal mes As Integer) As DateTime

        Dim days As Integer = DateTime.DaysInMonth(anio, mes)

        For i As Integer = days - 6 To days
            Dim cd As DateTime = New DateTime(anio, mes, i)
            If cd.DayOfWeek = dia_semana Then
                Return cd
            End If
        Next

    End Function

    Public Shared Sub EvaluarOrdinal(ByVal ordinal As Integer, ByVal dia_num As DayOfWeek, ByVal dateOfLastDay As DateTime, ByVal dayOfWeek As DayOfWeek, ByRef counter As Integer, ByVal searchedMonthYear As DateTime, ByVal tempDate As DateTime, ByRef oListadoActividad As List(Of ActividadBE))
        Dim oActividad As New ActividadBE

        ' If ordinal less or equal to zero, then it looks for the last day of the month
        If ordinal > 0 Then

            ' If temp date is within the same month of the searched month, adds individual counter for this day
            If tempDate.Month >= searchedMonthYear.Month Then counter += 1

            ' If the ordinal matches the counter and the day is the day we are looking for then proceeds
            If ordinal = counter And dia_num = dayOfWeek Then
                If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                    oActividad.fec_ini = tempDate
                    oListadoActividad.Add(oActividad)
                End If
            End If
        Else

            ' Gets the last day of the one specified for the searched month and year and compares it to the temp Date that iterates
            If DateTime.Compare(dateOfLastDay.Date, tempDate.Date) = 0 Then
                oActividad.fec_ini = tempDate
                oListadoActividad.Add(oActividad)
            End If

        End If

    End Sub

    Public Shared Function ObtenerFrecuenciaSemanal(ByVal weeksNumber As Integer, ByVal flg_dom As Boolean, ByVal flg_lun As Boolean, ByVal flg_mar As Boolean, ByVal flg_mie As Boolean, ByVal flg_jue As Boolean, ByVal flg_vie As Boolean, ByVal flg_sab As Boolean, ByVal searchedMonthYear As DateTime, ByVal startDate As DateTime, ByVal endDate As DateTime, ByRef oListadoActividad As List(Of ActividadBE)) As List(Of ActividadBE)
        Dim oActividad As ActividadBE
        Dim tempDate As DateTime      ' This date will be the moving date
        Dim initialDate As DateTime   ' This date can be the start date or the first day of the searched month       

        ' Calculates the last day of the searched month
        Dim lastDayOfSearchedMonth As DateTime
        lastDayOfSearchedMonth = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1).AddMonths(1).AddDays(-1)

        ' First day of the searched month
        Dim firstDayOfSearchedMonth As New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1)
        Dim firstDayOfStartMonth As New DateTime(startDate.Year, startDate.Month, 1)

        ' If enddate is not specified (forever) end date becomes the last day of the searched month
        If endDate = Nothing Then endDate = lastDayOfSearchedMonth

        ' If searched month is greater or equal than start month then calculates, else it should return empty
        If firstDayOfSearchedMonth >= firstDayOfStartMonth Then

            ' If the start date is within the searched month initial date is the start date, else initial date is first day of searched month
            If searchedMonthYear.Month = startDate.Month And searchedMonthYear.Year = startDate.Year Then
                ' Initial date is the start date
                initialDate = startDate

                ' Temporary date starts on previous sunday of the start date
                tempDate = startDate.AddDays(-DatePart(DateInterval.Weekday, startDate, Microsoft.VisualBasic.FirstDayOfWeek.Sunday) + 1)
            Else
                ' Calculates the first date of the searched month
                initialDate = New DateTime(searchedMonthYear.Year, searchedMonthYear.Month, 1)

                ' Temporary date starts on previous sunday of first day of the month
                tempDate = initialDate.AddDays(-DatePart(DateInterval.Weekday, initialDate, Microsoft.VisualBasic.FirstDayOfWeek.Sunday) + 1)
            End If

        Else
            ' Forces the while not to execute
            tempDate = endDate.AddDays(1)
        End If

        ' While temp date is less than the end of the month and is less than the end date
        While (tempDate <= lastDayOfSearchedMonth) And (tempDate <= endDate)
            oActividad = New ActividadBE

            ' If temporary date is greater than the intial date, analizes that day
            If tempDate >= initialDate Then

                ' Checks what day is temp date and then checks if that day was required
                Select Case tempDate.DayOfWeek
                    Case DayOfWeek.Sunday
                        If flg_dom = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Monday
                        If flg_lun = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Tuesday
                        If flg_mar = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Wednesday
                        If flg_mie = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Thursday
                        If flg_jue = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Friday
                        If flg_vie = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                    Case DayOfWeek.Saturday
                        If flg_sab = True Then
                            If DateDiff(DateInterval.Day, tempDate, Today) <= 0 Then
                                oActividad.fec_ini = tempDate
                                oListadoActividad.Add(oActividad)
                            End If
                        End If
                End Select
            End If

            ' If it is the the last day of the week
            If tempDate.DayOfWeek = DayOfWeek.Saturday Then
                ' If weeksNumber is one, continue to the next day, else it will add the number of weeks in difference
                If weeksNumber = 1 Then
                    tempDate = tempDate.AddDays(1)
                Else
                    tempDate = tempDate.AddDays((7 * (weeksNumber - 1)) + 1)
                End If
            Else
                ' If temp date is still iterating the week, just goes to the next day
                tempDate = tempDate.AddDays(1)
            End If

        End While

        Return oListadoActividad

    End Function

End Class
