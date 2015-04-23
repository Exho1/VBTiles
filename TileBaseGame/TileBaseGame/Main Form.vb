Public Class frmMain

    ' TODO:
    ' - Enemies which go back and forth and kill you on contact
    ' - Some sort of gold coins to collect and then a counter on the screen

    ' Returns the map array
    Private Function loadMap(Optional level = 1)

        ' Map tile key
        ' r = rock (wall)
        ' w = water (wall)
        ' s = sand
        ' g = grass
        ' d = dirt
        ' a = gravel
        ' b = snow
        ' s = spawn point (grass)
        ' e = finish point (gold)

        ' Multidimensional arrays which represent each of the map's levels
        Dim rows()() As String = New String(10)() {}
        Select Case level
            Case 1 ' Land
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"r", "p", "r", "g", "r", "d", "d", "g", "g", "r"}
                rows(2) = New String() {"r", "g", "r", "g", "d", "d", "r", "g", "r", "r"}
                rows(3) = New String() {"r", "g", "r", "g", "r", "r", "r", "g", "r", "r"}
                rows(4) = New String() {"r", "g", "g", "g", "r", "g", "g", "g", "d", "r"}
                rows(5) = New String() {"r", "g", "r", "g", "r", "g", "r", "r", "d", "r"}
                rows(6) = New String() {"r", "r", "r", "g", "r", "g", "r", "d", "d", "r"}
                rows(7) = New String() {"r", "d", "r", "g", "r", "g", "r", "r", "r", "r"}
                rows(8) = New String() {"r", "d", "d", "g", "r", "g", "g", "g", "e", "r"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
            Case 2 ' Beach
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "w", "w", "w"}
                rows(1) = New String() {"r", "g", "g", "g", "d", "d", "s", "s", "w", "w"}
                rows(2) = New String() {"r", "g", "r", "g", "r", "s", "r", "s", "w", "w"}
                rows(3) = New String() {"r", "g", "r", "r", "r", "s", "r", "s", "w", "w"}
                rows(4) = New String() {"r", "g", "g", "g", "r", "s", "s", "s", "s", "w"}
                rows(5) = New String() {"r", "r", "r", "g", "r", "s", "w", "w", "s", "w"}
                rows(6) = New String() {"r", "g", "g", "g", "r", "s", "w", "w", "s", "w"}
                rows(7) = New String() {"r", "g", "r", "g", "r", "r", "r", "w", "s", "w"}
                rows(8) = New String() {"r", "p", "r", "d", "d", "s", "s", "w", "e", "w"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "w", "w", "w", "w"}
            Case 3 ' Ocean
                rows(0) = New String() {"w", "w", "w", "w", "w", "w", "w", "w", "w", "w"}
                rows(1) = New String() {"w", "p", "w", "s", "s", "s", "s", "s", "s", "w"}
                rows(2) = New String() {"w", "s", "w", "s", "w", "s", "w", "w", "s", "w"}
                rows(3) = New String() {"w", "s", "s", "s", "w", "s", "s", "w", "w", "w"}
                rows(4) = New String() {"w", "s", "w", "s", "w", "w", "s", "w", "e", "w"}
                rows(5) = New String() {"w", "s", "w", "s", "s", "w", "s", "w", "s", "w"}
                rows(6) = New String() {"w", "s", "w", "w", "s", "w", "s", "w", "s", "w"}
                rows(7) = New String() {"w", "s", "w", "w", "w", "w", "s", "s", "s", "w"}
                rows(8) = New String() {"w", "s", "s", "s", "w", "s", "s", "w", "w", "w"}
                rows(9) = New String() {"w", "w", "w", "w", "w", "w", "w", "w", "w", "w"}
            Case 4 ' Beach
                rows(0) = New String() {"w", "w", "w", "w", "w", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"w", "s", "s", "s", "s", "r", "g", "r", "r", "r"}
                rows(2) = New String() {"w", "s", "w", "s", "r", "r", "g", "g", "g", "r"}
                rows(3) = New String() {"w", "s", "w", "s", "d", "r", "g", "r", "g", "r"}
                rows(4) = New String() {"w", "p", "w", "s", "d", "r", "g", "r", "g", "r"}
                rows(5) = New String() {"w", "s", "w", "w", "d", "d", "g", "r", "g", "r"}
                rows(6) = New String() {"w", "s", "s", "s", "r", "r", "g", "r", "e", "r"}
                rows(7) = New String() {"w", "s", "w", "s", "r", "g", "g", "r", "r", "r"}
                rows(8) = New String() {"w", "w", "w", "s", "r", "d", "g", "g", "g", "r"}
                rows(9) = New String() {"w", "w", "w", "w", "w", "r", "r", "r", "r", "r"}
            Case 5 ' Land
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"r", "d", "r", "g", "g", "g", "g", "r", "e", "r"}
                rows(2) = New String() {"r", "g", "r", "g", "r", "r", "g", "r", "g", "r"}
                rows(3) = New String() {"r", "g", "g", "g", "r", "d", "g", "r", "g", "r"}
                rows(4) = New String() {"r", "g", "r", "g", "r", "d", "g", "r", "g", "r"}
                rows(5) = New String() {"r", "g", "r", "r", "r", "r", "g", "r", "g", "r"}
                rows(6) = New String() {"r", "g", "r", "d", "d", "r", "g", "r", "g", "r"}
                rows(7) = New String() {"r", "g", "r", "r", "d", "r", "g", "r", "g", "r"}
                rows(8) = New String() {"r", "p", "g", "g", "g", "r", "g", "g", "g", "r"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
            Case 6 ' Mountain side
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"r", "d", "g", "g", "d", "d", "r", "a", "a", "r"}
                rows(2) = New String() {"r", "d", "r", "g", "r", "d", "a", "a", "r", "r"}
                rows(3) = New String() {"r", "r", "r", "g", "r", "r", "r", "r", "r", "r"}
                rows(4) = New String() {"r", "p", "g", "g", "r", "a", "a", "a", "a", "r"}
                rows(5) = New String() {"r", "r", "r", "g", "r", "d", "r", "r", "a", "r"}
                rows(6) = New String() {"r", "g", "g", "g", "r", "d", "a", "r", "a", "r"}
                rows(7) = New String() {"r", "g", "r", "r", "r", "r", "a", "r", "a", "r"}
                rows(8) = New String() {"r", "g", "g", "g", "d", "d", "a", "r", "e", "r"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
            Case 7 ' Mountain side - higher
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"r", "p", "r", "a", "b", "b", "r", "b", "e", "r"}
                rows(2) = New String() {"r", "d", "r", "r", "a", "r", "r", "b", "r", "r"}
                rows(3) = New String() {"r", "d", "d", "r", "a", "a", "r", "b", "b", "r"}
                rows(4) = New String() {"r", "r", "d", "r", "r", "a", "r", "r", "b", "r"}
                rows(5) = New String() {"r", "d", "d", "r", "a", "a", "a", "b", "b", "r"}
                rows(6) = New String() {"r", "d", "r", "r", "r", "a", "r", "r", "b", "r"}
                rows(7) = New String() {"r", "d", "r", "d", "a", "a", "r", "r", "b", "r"}
                rows(8) = New String() {"r", "d", "d", "d", "r", "a", "r", "r", "b", "r"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
            Case 8 ' Mountain top
                rows(0) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
                rows(1) = New String() {"r", "b", "r", "r", "r", "b", "b", "b", "b", "r"}
                rows(2) = New String() {"r", "b", "b", "b", "b", "b", "r", "b", "b", "r"}
                rows(3) = New String() {"r", "b", "r", "r", "r", "b", "r", "r", "b", "r"}
                rows(4) = New String() {"r", "b", "b", "b", "r", "b", "b", "r", "b", "r"}
                rows(5) = New String() {"r", "r", "r", "b", "r", "r", "b", "r", "b", "r"}
                rows(6) = New String() {"r", "b", "b", "b", "r", "r", "b", "b", "b", "r"}
                rows(7) = New String() {"r", "b", "r", "b", "r", "b", "b", "r", "b", "r"}
                rows(8) = New String() {"r", "p", "r", "b", "r", "b", "b", "r", "e", "r"}
                rows(9) = New String() {"r", "r", "r", "r", "r", "r", "r", "r", "r", "r"}
            Case 9 ' Finish
                rows(0) = New String() {"e", "e", "e", "e", "e", "e", "e", "e", "e", "e"}
                rows(1) = New String() {"e", "r", "r", "r", "r", "r", "r", "r", "r", "e"}
                rows(2) = New String() {"e", "r", "g", "g", "g", "g", "g", "g", "r", "e"}
                rows(3) = New String() {"e", "r", "g", "g", "g", "g", "g", "g", "r", "e"}
                rows(4) = New String() {"e", "r", "g", "g", "p", "g", "g", "g", "r", "e"}
                rows(5) = New String() {"e", "r", "g", "g", "g", "g", "g", "g", "r", "e"}
                rows(6) = New String() {"e", "r", "g", "g", "g", "g", "g", "g", "r", "e"}
                rows(7) = New String() {"e", "r", "g", "g", "g", "g", "g", "g", "r", "e"}
                rows(8) = New String() {"e", "r", "r", "r", "r", "r", "r", "r", "r", "e"}
                rows(9) = New String() {"e", "e", "e", "e", "e", "e", "e", "e", "e", "e"}
        End Select

        Return rows
    End Function

    Dim mapArray
    Dim ply
    Dim winLabel
    Dim pressEnter
    Dim winGameLabel
    Dim tileSize = 70
    Dim wonLevel = False
    Dim currentLevel = 1
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create the label which will announce wins
        Dim announcementFont As New Font("Sans Serif", 18, FontStyle.Regular)
        winLabel = New Label()
        Me.Controls.Add(winLabel)
        With winLabel
            .Size = New Size(380, 30)
            .Font = announcementFont
            .Location = New Point(Me.Width / 2 - 380 / 2, Me.Height / 2 - 90)
            .Visible = False ' Hide it
        End With

        ' Create the label that tells the user to press enter
        pressEnter = New Label()
        Me.Controls.Add(pressEnter)
        With pressEnter
            .Size = New Size(380, 30)
            .Font = announcementFont
            .Location = New Point(Me.Width / 2 - 380 / 2, Me.Height / 2)
            .Visible = False ' Hide it
        End With

        ' Create the label which will announce when you beat the game
        Dim winFont As New Font("Sans Serif", 26, FontStyle.Regular)
        winGameLabel = New Label()
        Me.Controls.Add(winGameLabel)
        With winGameLabel
            .Text = "You win!"
            .Size = New Size(150, 35)
            .Font = winFont
            .Location = New Point(Me.Width / 2 - 150 / 2, Me.Height / 2 - 35)
            .Visible = False ' Hide it
        End With

        ' Set up the game environment
        setupGame()
    End Sub

    ' Prepares the windows form for the game
    Private Sub setupGame()
        ' Get the map
        mapArray = loadMap(currentLevel)

        ' Win condition
        If currentLevel = 9 Then
            winGameLabel.visible = True
        End If

        ' Create the player
        ply = New player(0, 0)
        Me.Controls.Add(ply)

        Dim xBuffer = 0
        Dim yBuffer = 0

        ' Creates the physical map
        For intRow As Integer = 0 To mapArray.GetUpperBound(0) - 1
            Dim row = mapArray(intRow)
            For intCol As Integer = 0 To row.GetUpperBound(0)
                Dim type = mapArray(intRow)(intCol)

                ' Handle designated spawnpoints
                If type = "p" Then
                    ' Restore this to a grass texture
                    mapArray(intRow)(intCol) = "g"
                    type = "g"

                    ' Set the player's position
                    Dim pos = getTile(intCol, intRow)
                    ply.Location = New Point(pos(0) + 10, pos(1) + 10)
                End If

                ' Create the tile image
                Dim tile = New tile()
                Me.Controls.Add(tile)
                With tile
                    .Image = My.Resources.ResourceManager.GetObject("tile_" + type)

                    .BackColor = Color.Black
                    .Location = New Point(xBuffer, yBuffer)
                    .Size = New Size(tileSize, tileSize)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With
                xBuffer += tile.Width
            Next
            xBuffer = 0
            yBuffer += tileSize
        Next
    End Sub

    ' Handle key press events to move the player
    Private Sub frmMain_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        Dim dir As String = ""

        Dim x = ply.Location.X
        Dim y = ply.Location.Y

        ' Set the player's destination
        If e.KeyChar.ToString() = "w" Then
            ply.endY = y - tileSize
        ElseIf e.KeyChar.ToString() = "s" Then
            ply.endY = y + tileSize
        ElseIf e.KeyChar.ToString() = "a" Then
            ply.endX = x - tileSize
        ElseIf e.KeyChar.ToString() = "d" Then
            ply.endX = x + tileSize
        End If

        ' Restart the round when enter is pressed
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If wonLevel Then
                wonLevel = False
                winLabel.Visible = False
                pressEnter.Visible = False

                startNextLevel()
            End If
        End If

        movePlayer(dir)
    End Sub

    ' Removes all the tiles from the current map and tells the game to set up the next level
    Private Sub startNextLevel()
        currentLevel += 1

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is tile Or TypeOf Me.Controls(i) Is player Then
                Me.Controls.RemoveAt(i)
            End If
        Next

        setupGame()
    End Sub

    ' Moves the player towards their destination
    Private Sub movePlayer(dir As String)
        Dim x = ply.Location.X
        Dim y = ply.Location.Y
        Dim w = ply.Size.Width
        Dim h = ply.Size.Height

        If Not wonLevel Then

            'ply.lastX = x
            'ply.lastY = y

            If ply.endX = 0 Then
                ply.endX = x
            End If

            If ply.endY = 0 Then
                ply.endY = y
            End If

            ' Get the tile the player is about to move to
            Dim output = getTilePos(ply.endX, ply.endY)
            Dim col = output(0)
            Dim row = output(1)
            Dim type = output(2)

            Label1.Text = "Row: " + row.ToString() + " Col: " + col.ToString() + " Type: " + type

            ' If its rock, don't move there
            If type = "r" Or type = "w" Then
                ply.endY = 0
                ply.endX = 0
            End If

            ' Made it to the end of a level
            If type = "e" Then
                wonLevel = True

                pressEnter.Visible = True
                pressEnter.Text = "Press Enter to go to the next level"

                winLabel.Visible = True
                winLabel.Text = "You made it to the end of level: " + currentLevel.ToString() + "!!!"
            End If
        Else
            ply.endY = y
            ply.endX = x
        End If
    End Sub

    ' Updates the game 
    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
            Dim x = ply.Location.X
            Dim y = ply.Location.Y

            If ply.endY <> 0 Then
                y = lerp(0.1, y, ply.endY)
            End If

            If ply.endX <> 0 Then
                x = lerp(0.1, x, ply.endX)
            End If

            If Math.Abs(ply.endY - y) < 0.01 Then
                ply.endY = 0
            End If

            If Math.Abs(ply.endX - x) < 0.01 Then
                ply.endX = 0
            End If

            ply.Location = New Point(x, y)
    End Sub

    ' Returns the X, Y point of the type at the position
    Private Function getTile(column, row)
        Dim letter = mapArray(row)(column)
        Dim x = column * tileSize
        Dim y = row * tileSize

        Return {x, y, letter}
    End Function

    ' Returns the tile object closest the given point
    Private Function getTilePos(x, y)
        Dim col = Math.Round(x / tileSize)
        Dim row = Math.Round(y / tileSize)

        Dim type = mapArray(row)(col)

        Return {col, row, type}
    End Function

    ' Interpolates between 2 numbers 
    Private Function lerp(dt, start, finish)
        If dt > 1 Then
            Return finish
        ElseIf dt < 0 Then
            Return start
        End If

        Return start + (finish - start) '* dt
    End Function

    ' Clamps a value between a minimum and maximum number
    Private Function clamp(val, min, max)
        If val > max Then
            val = max
        ElseIf val < min Then
            val = min
        End If

        Return val
    End Function
End Class

' Tile class
Public Class tile
    Inherits PictureBox

End Class

' Player class
Public Class player
    Inherits PictureBox

    Public endX As Integer = 0
    Public endY As Integer = 0

    Public lastX As Integer = 0
    Public lastY As Integer = 0

    Public Sub New(x, y)
        'Image = My.Resources.winship
        SizeMode = PictureBoxSizeMode.StretchImage
        Size = New Size(50, 50)
        BackColor = Color.Blue
        Location = New Point(x, y)
    End Sub
End Class
