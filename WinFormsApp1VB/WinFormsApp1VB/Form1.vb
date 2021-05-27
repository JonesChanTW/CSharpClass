Imports System.Threading

Public Class Form1
    Private oCardTable As Hashtable
    Private oCardTableBack As Hashtable
    Private leftNum As Integer
    Private rightNum As Integer
    Private iScoreCom As Integer = 0
    Private iScorePlayer As Integer = 0
    Private iSeed As Integer = 0
    Private backCardImage As Image

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        backCardImage = Image.FromFile(".\\pic\\bicycle_backs.jpg")
        Initial()
        Start()
    End Sub

    Private Sub Initial()
        oCardTable = New Hashtable
        oCardTableBack = New Hashtable


        For i = 1 To 13
            oCardTable.Add(i, New ArrayList)
            oCardTableBack.Add(i, New ArrayList)
        Next

        LoadCardPicture(oCardTable)

        Reset()
    End Sub

    Private Sub Reset(Optional bSwap As Boolean = False)
        Dim rnd As Random = New Random()
        Dim tmpTable As Hashtable

        iScoreCom = 0
        iScorePlayer = 0
        lblGameFinish.Text = ""
        picLeft.Image = backCardImage
        picRight.Image = backCardImage
        picMiddle.Image = backCardImage
        lblScoreCom.Text = iScoreCom
        lblScorePlayer.Text = iScorePlayer
        Timer1.Interval = 3000
        iSeed = rnd.Next()
        picMiddle.Enabled = True
        btnRoundOne.Enabled = False
        btnRoundOne.Visible = False

        If bSwap Then
            tmpTable = oCardTable
            oCardTable = oCardTableBack
            oCardTableBack = tmpTable
            For i = 1 To 13
                oCardTableBack.Add(i, New ArrayList)
            Next
        End If
    End Sub

    Private Sub LoadCardPicture(ByRef table As Hashtable)
        Dim path = ""


        For i = 1 To 13
            Dim picList As ArrayList = table(i)
            For j = 0 To 3
                path = ".\\pic\\p" & ((i + j * 13)).ToString("D2") & ".jpg"
                picList.Add(Image.FromFile(path))
            Next
        Next
    End Sub

    Private Sub Start()

        SelectCard(picLeft, leftNum)
        SelectCard(picRight, rightNum)

    End Sub

    Private Sub SelectCard(ByRef pic As PictureBox, ByRef val As Integer, Optional bRemoveSelect As Boolean = True)
        Dim rnd As Random = New Random(iSeed)
        Dim cards As ArrayList
        Dim sn
        Dim cardImg

        Dim keys = oCardTable.Keys


        sn = rnd.Next(oCardTable.Count)
        Dim key = keys(sn)
        val = key
        cards = oCardTable(key)

        sn = rnd.Next(cards.Count)
        cardImg = cards(sn)

        pic.Image = cardImg
        If bRemoveSelect Then
            cards.Remove(cardImg)
            Dim tmpCardList = oCardTableBack(key)
            tmpCardList.Add(cardImg)
        End If

        If cards.Count <= 0 Then
            oCardTable.Remove(key)
        End If
        iSeed = rnd.Next()
    End Sub

    Private Sub picMiddle_Click(sender As Object, e As EventArgs) Handles picMiddle.Click
        Dim rnd As Random = New Random
        Dim middle As Integer


        SelectCard(picMiddle, middle, False)

        If leftNum < middle And rightNum > middle Then
            iScorePlayer += 50
            iScoreCom -= 50
            lblGameFinish.Text = "勝 +50分"
        ElseIf leftNum > middle And rightNum < middle Then
            iScorePlayer += 50
            iScoreCom -= 50
            lblGameFinish.Text = "勝 +50分"
        Else
            iScorePlayer -= 50
            iScoreCom += 50
            lblGameFinish.Text = "負 -50分"
        End If

        lblScoreCom.Text = iScoreCom
        lblScorePlayer.Text = iScorePlayer

        Timer1.Start()


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim remainCards As Integer
        Dim keys = oCardTable.Keys

        Timer1.Stop()

        picMiddle.Image = backCardImage
        remainCards = 0
        For Each key In keys
            Dim list As ArrayList = oCardTable(key)
            remainCards += list.Count
        Next

        If remainCards > 2 Then
            lblGameFinish.Text = ""
            Start()
        Else
            GameFinish()

        End If
    End Sub

    Private Sub GameFinish()
        Dim keys
        Dim list As ArrayList
        Dim tmpList As ArrayList
        Dim img As Image

        keys = oCardTable.Keys
        For Each key In keys
            list = oCardTable(key)
            tmpList = oCardTableBack(key)
            For Each img In list
                tmpList.Add(img)
            Next
            list.Clear()
        Next
        oCardTable.Clear()
        picMiddle.Enabled = False
        lblGameFinish.Text = "遊戲結束"
        btnRoundOne.Enabled = True
        btnRoundOne.Visible = True
        picLeft.Image = backCardImage
        picRight.Image = backCardImage
    End Sub

    Private Sub btnRoundOne_Click(sender As Object, e As EventArgs) Handles btnRoundOne.Click
        Reset(True)
        Start()
    End Sub

End Class
