Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Xml

Public Class PlayerAPIForm
    Dim statlist As List(Of PlyStats)
    Private Sub PlayerAPIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtSearch.Select()

        Dim Str As System.IO.Stream
        Dim srRead As System.IO.StreamReader
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("https://thedivinityrp.net/RP/PlayerAPI.php?id=" & MainForm.TxtAPI.Text)
        Dim resp As System.Net.WebResponse = req.GetResponse
        Str = resp.GetResponseStream
        srRead = New System.IO.StreamReader(Str)
        Dim divapi As String = srRead.ReadToEnd
        srRead.Close()
        Str.Dispose()
        If divapi.ToString <> "null" Then
            Dim json As JObject = JObject.Parse(divapi)
            statlist = JsonConvert.DeserializeObject(Of List(Of PlyStats))(json.SelectToken("stats").ToString)

            'SteamID
            TxtSteamID.Text = json.SelectToken("SteamID")
            'Name
            TxtName.Text = json.SelectToken("Name")
            'Access Group
            TxtAccessGroup.Text = json.SelectToken("AccessGroup")
            'Access Group Start Time
            Dim startTime = TimestampToDateTime(json.SelectToken("AGStartTime"))
            TxtAGStartTime.Text = TimestampToDateTime(json.SelectToken("AGStartTime"))
            'Access Group Expire Time
            Dim expireTime = json.SelectToken("AGExpireTime")
            Dim expireDate = TimestampToDateTime(CType(json.SelectToken("AGStartTime"), Integer) + CType(json.SelectToken("AGExpireTime"), Integer))
            If expireTime.ToString = "0" Then
                TxtAGExpireTime.Text = "Permanent"
            Else
                TxtAGExpireTime.Text = expireDate
            End If
            'First Joined
            TxtJoined.Text = TimestampToDateTime(json.SelectToken("Joined"))
            'Last Played
            TxtLastPlayed.Text = TimestampToDateTime(json.SelectToken("LastPlayed"))
            'Total Time Played
            '---------------------------------------------------------------------------------------
            Dim hours = json.SelectToken("Hours").ToString
            Dim minutes = json.SelectToken("Minutes").ToString
            Dim seconds = json.SelectToken("Seconds").ToString
            TxtTimePlayed.Text = hours & ":" & minutes & ":" & seconds
            '---------------------------------------------------------------------------------------
            'In Steam Group
            '---------------------------------------------------------------------------------------
            If CInt(json.SelectToken("InSteamGroup")) = 1 Then
                TxtSteamGroup.Text = "Yes"
            ElseIf CInt(json.SelectToken("InSteamGroup")) = 0 Then
                TxtSteamGroup.Text = "No"
            Else
                TxtSteamGroup.Text = "Error"
            End If
            '---------------------------------------------------------------------------------------
            'Credits
            TxtCredits.Text = json.SelectToken("Points").ToString
            'Money
            '---------------------------------------------------------------------------------------
            Dim money As Double = json.SelectToken("Money")
            TxtMoney.Text = money.ToString("C")
            '---------------------------------------------------------------------------------------
            'Perms
            '---------------------------------------------------------------------------------------
            Dim PermString As String = json.SelectToken("Guns").ToString
            PermString = PermString.Replace("[", "")
            PermString = PermString.Replace("]", "")
            PermString = PermString.Replace("""", "")
            Dim PermInfo() As String = PermString.Split(",")
            If PermInfo(0).ToString <> vbCrLf & "  " & vbCrLf Then
                For Each perm In PermInfo
                    CboPerms.Items.Add(perm.ToString)
                Next
                CboPerms.Text = PermInfo.Length.ToString
            Else
                CboPerms.Text = "None"
            End If

            '---------------------------------------------------------------------------------------
            'Hats
            '---------------------------------------------------------------------------------------
            Dim HatString = json.SelectToken("Hats").ToString
            Dim HatInfo() As String = HatString.Split(",")
            If HatString <> "" Then
                For Each hat In HatInfo
                    CboHats.Items.Add(hat.ToString)
                    CboHats.Text = HatInfo.Length
                Next
            Else
                CboHats.Text = "None"
            End If
            '---------------------------------------------------------------------------------------
            'Pocket
            '---------------------------------------------------------------------------------------
            If json.SelectToken("Pocket").ToString <> "" Then
                TxtPocket.Text = json.SelectToken("Pocket").SelectToken("Class").ToString
            Else
                TxtPocket.Text = "None"
            End If
            '---------------------------------------------------------------------------------------
            'Melon Information
            Dim MelonInfo() As String = json.SelectToken("Melon").ToString.Split(";")
            If MelonInfo.Length > 1 Then
                TxtMelonName.Text = MelonInfo(0)
                TxtMelonAge.Text = MelonInfo(1)
                Dim mr As Integer = MelonInfo(2)
                Dim mg As Integer = MelonInfo(3)
                Dim mb As Integer = MelonInfo(4)
                TxtMelonColor.Text = mr & ", " & mg & ", " & mb
                PnlMelonColor.BackColor = Color.FromArgb(255, mr, mg, mb)
            Else
                TxtMelonName.Text = "N/A"
                TxtMelonAge.Text = "N/A"
                TxtMelonColor.Text = "N/A"
                PnlMelonColor.BackColor = Color.FromArgb(255, 26, 26, 26)
            End If
            '---------------------------------------------------------------------------------------
            'Karma
            TxtKarma.Text = json.SelectToken("Karma").ToString
            'Last Login Reward
            TxtLoginReward.Text = TimestampToDateTime(json.SelectToken("LastReward"))
            'Organization Name
            '---------------------------------------------------------------------------------------
            If IsNothing(json.SelectToken("Organizationz")) <> True Then
                TxtOrganizationName.Text = json.SelectToken("Organizationz").ToString
            Else
                TxtOrganizationName.Text = "N/A"
            End If
            '---------------------------------------------------------------------------------------
            'Organization Rank
            '---------------------------------------------------------------------------------------
            If json.SelectToken("OrganizationRank").ToString <> "null" Then
                TxtOrganizationRank.Text = json.SelectToken("OrganizationRank").ToString
            Else
                TxtOrganizationRank.Text = "N/A"
            End If
            '---------------------------------------------------------------------------------------
            If statlist.Count < 1 Then
                MsgBox("This player has played before, but they have not logged in since the API update. They have no statistics available.")
            Else
                TxtDeaths.Text = CInt(statlist.Item(GetStatIndex("total_deaths")).Value).ToString("N0")
                TxtSuicides.Text = CInt(statlist.Item(GetStatIndex("total_suicides")).Value).ToString("N0")
                TxtKills.Text = CInt(statlist.Item(GetStatIndex("total_kills")).Value).ToString("N0")
                TxtPoops.Text = CInt(statlist.Item(GetStatIndex("times_pooped")).Value).ToString("N0")
                TxtPoopsEaten.Text = CInt(statlist.Item(GetStatIndex("times_ate_poop")).Value).ToString("N0")
                TxtShoesThrown.Text = CInt(statlist.Item(GetStatIndex("times_shoed")).Value).ToString("N0")
                TxtSteps.Text = CInt(statlist.Item(GetStatIndex("total_steps")).Value).ToString("N0")
                TxtDances.Text = CInt(statlist.Item(GetStatIndex("total_dances")).Value).ToString("N0")
                TxtWanted.Text = CInt(statlist.Item(GetStatIndex("times_wanted")).Value).ToString("N0")
                TxtWantsIssued.Text = CInt(statlist.Item(GetStatIndex("times_set_wanted")).Value).ToString("N0")
                TxtArrests.Text = CInt(statlist.Item(GetStatIndex("total_arrests")).Value).ToString("N0")
                TxtHitsCompleted.Text = CInt(statlist.Item(GetStatIndex("total_completed_hits")).Value).ToString("N0")
                TxtHitlist.Text = CInt(statlist.Item(GetStatIndex("total_hits")).Value).ToString("N0")
                Dim job As Integer = CInt(statlist.Item(GetStatIndex("last_job")).Value)
                Dim JobName As String = "Error"
                Select Case job
                    Case 1
                        JobName = "Citizen"
                    Case 2
                        JobName = "Police Officer"
                    Case 3
                        JobName = "Gangster"
                    Case 4
                        JobName = "Mob Boss"
                    Case 5
                        JobName = "Gun Dealer"
                    Case 6
                        JobName = "Doctor"
                    Case 7
                        JobName = "Cook"
                    Case 8
                        JobName = "Police Officer"
                    Case 9
                        JobName = "Mayor"
                    Case 10
                        JobName = "Hobo"
                    Case 11
                        JobName = "Drug Dealer"
                    Case 12
                        JobName = "Hotel Manager"
                    Case 13
                        JobName = "Movie Theater Manager"
                    Case 14
                        JobName = "Bartender"
                    Case 16
                        JobName = "Hacker"
                    Case 15
                        JobName = "Security Guard"
                    Case 17
                        JobName = "Anarchist"
                    Case 18
                        JobName = "Black Market Dealer"
                    Case 19
                        JobName = "Professional Thief"
                    Case 20
                        JobName = "Admin Police"
                    Case 21
                        JobName = "Mercenary"
                    Case 22
                        JobName = "Vigilante"
                    Case 23
                        JobName = "Hitman"
                    Case 24
                        JobName = "Sharp Shooter"
                    Case 25
                        JobName = "Thug"
                    Case 26
                        JobName = "Super Pro Thief"
                    Case 27
                        JobName = "Rapist"
                    Case 28
                        JobName = "Landman"
                    Case 29
                        JobName = "Prostitute"
                    Case 30
                        JobName = "Pimp"
                    Case 31
                        JobName = "Zombie"
                    Case 32
                        JobName = "Survivor"
                    Case 33
                        JobName = "Staff Member"
                End Select
                TxtLastJob.Text = JobName
                TxtRapesInitiated.Text = CInt(statlist.Item(GetStatIndex("times_done_rape")).Value).ToString("N0")
                TxtTimesRaped.Text = CInt(statlist.Item(GetStatIndex("times_been_rape")).Value).ToString("N0")
                TxtTimesAssassinated.Text = CInt(statlist.Item(GetStatIndex("total_assasinated")).Value).ToString("N0")
                TxtMKWins.Text = CInt(statlist.Item(GetStatIndex("total_mk_won")).Value).ToString("N0")
                TxtMKWinnings.Text = CInt(statlist.Item(GetStatIndex("total_mk_winnings")).Value).ToString("N0")
                TxtAssassinations.Text = CInt(statlist.Item(GetStatIndex("total_assassinations")).Value).ToString("N0")
                TxtPaidForSex.Text = CInt(statlist.Item(GetStatIndex("total_paid_prostitution")).Value).ToString("N0")
                TxtGotPaidForSex.Text = CInt(statlist.Item(GetStatIndex("total_prostitution")).Value).ToString("N0")
                TxtMayorTerms.Text = CInt(statlist.Item(GetStatIndex("total_mayor")).Value).ToString("N0")
                TxtChiefTerms.Text = CInt(statlist.Item(GetStatIndex("total_chief")).Value).ToString("N0")
                TxtHotelTerms.Text = CInt(statlist.Item(GetStatIndex("total_hotel")).Value).ToString("N0")
                TxtLottosWon.Text = CInt(statlist.Item(GetStatIndex("lottos_won")).Value).ToString("N0")
                TxtLottoLosses.Text = CInt(statlist.Item(GetStatIndex("lottos_cash_lost")).Value).ToString("C")
                TxtLottoWinnings.Text = CInt(statlist.Item(GetStatIndex("lottos_cash_won")).Value).ToString("N0")
                TxtGamblesWon.Text = CInt(statlist.Item(GetStatIndex("total_gamble_won")).Value).ToString("N0")
                TxtGamblesLost.Text = CInt(statlist.Item(GetStatIndex("total_gamble_lost")).Value).ToString("N0")
                TxtSlotWinnings.Text = CInt(statlist.Item(GetStatIndex("total_slots_won")).Value).ToString("C")
                TxtGambleWinnings.Text = CInt(statlist.Item(GetStatIndex("total_gamble_cash_won")).Value).ToString("C")
                TxtGambleLosses.Text = CInt(statlist.Item(GetStatIndex("total_gamble_cash_lost")).Value).ToString("C")
                TxtSlotLosses.Text = CInt(statlist.Item(GetStatIndex("total_slots_lost")).Value).ToString("C")
                TxtDrugs.Text = CInt(statlist.Item(GetStatIndex("total_drugs")).Value).ToString("N0")
                TxtDrugShipments.Text = CInt(statlist.Item(GetStatIndex("total_drug_shipments")).Value).ToString("N0")
                TxtDrugFactories.Text = CInt(statlist.Item(GetStatIndex("total_drug_factories")).Value).ToString("N0")
                TxtFoodSpawned.Text = CInt(statlist.Item(GetStatIndex("total_food")).Value).ToString("N0")
                TxtFoodShipmentsSpawned.Text = CInt(statlist.Item(GetStatIndex("total_food_shipments")).Value).ToString("N0")
                TxtMedicShipments.Text = CInt(statlist.Item(GetStatIndex("total_medic_shipments")).Value).ToString("N0")
                TxtGunsSpawned.Text = CInt(statlist.Item(GetStatIndex("total_guns")).Value).ToString("N0")
                TxtGunShipments.Text = CInt(statlist.Item(GetStatIndex("total_gun_shipments")).Value).ToString("N0")
                MainForm.TxtAPI.Text = String.Empty
            End If
        Else
                MainForm.TxtAPI.Text = String.Empty
            MsgBox("The SteamID you entered did not get any API results.")
            Me.Close()
        End If
    End Sub

    Public Function TimestampToDateTime(ByVal _UnixTimeStamp As Long) As DateTime
        Return (New DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(_UnixTimeStamp)
    End Function

    Public Function GetStatIndex(statname As String) As Integer
        Dim index As Integer
        For Each item In statlist
            If item.Name = statname Then
                index = statlist.IndexOf(item)
                Return index
            End If
        Next
        Return Nothing
    End Function

    Public Function Similarity(ByVal s As String, ByVal t As String) As Integer
        Dim n As Integer = s.Length
        Dim m As Integer = t.Length
        Dim d(n + 1, m + 1) As Integer

        If n = 0 Then
            Return m
        End If
        If m = 0 Then
            Return n
        End If

        Dim i As Integer
        Dim j As Integer

        For i = 0 To n
            d(i, 0) = i
        Next
        For j = 0 To m
            d(0, j) = j
        Next
        For i = 1 To n
            For j = 1 To m
                Dim cost As Integer
                If t(j - 1) = s(i - 1) Then
                    cost = 0
                Else
                    cost = 1
                End If
                d(i, j) = Math.Min(Math.Min(d(i - 1, j) + 1, d(i, j - 1) + 1), d(i - 1, j - 1) + cost)
            Next
        Next
        Return d(n, m)
    End Function

    Private Sub CboPerms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboPerms.KeyPress
        e.Handled = True
    End Sub

    Private Sub CboHats_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboHats.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSearch.PerformClick()
            TxtSearch.Select()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        For Each objCtrl As Control In PlayerInformationGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
        For Each objCtrl As Control In RoleplayGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
        For Each objCtrl As Control In GeneralGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
        For Each objCtrl As Control In JobsGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
        For Each objCtrl As Control In MoneyGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
        For Each objCtrl As Control In SpawnsGroupbox.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Dim txtString() As String = Lbl.Text.Split(" ")
                Dim LabelAccepted As Boolean = False
                For Each word In txtString
                    If CInt(Similarity(word.ToString.ToLower, TxtSearch.Text.ToLower)) < 2 Or LabelAccepted = True Then
                        Lbl.Enabled = True
                        Lbl.ForeColor = Color.Red
                        LabelAccepted = True
                    Else
                        Lbl.ForeColor = Color.White
                        LabelAccepted = False
                    End If
                Next
            End If
        Next
    End Sub
End Class

Public Class PlyStats
    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set
            m_name = Value
        End Set
    End Property
    Private m_name As String
    Public Property Value() As String
        Get
            Return m_value
        End Get
        Set
            m_value = Value
        End Set
    End Property
    Private m_value As String
    Public Property Firstadded() As String
        Get
            Return m_firstadded
        End Get
        Set
            m_firstadded = Value
        End Set
    End Property
    Private m_firstadded As String
    Public Property Lastupdated() As String
        Get
            Return m_lastupdated
        End Get
        Set
            m_lastupdated = Value
        End Set
    End Property
    Private m_lastupdated As String
End Class