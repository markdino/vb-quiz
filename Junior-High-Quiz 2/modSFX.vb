Module modSFX
    Public vidcount As Integer = 0
    Public Sub hover()
        My.Computer.Audio.Play(My.Resources.hover, AudioPlayMode.Background)
    End Sub
    Public Sub cring()
        My.Computer.Audio.Play(My.Resources.cring, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_tick()
        My.Computer.Audio.Play(My.Resources.tick, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_boom()
        My.Computer.Audio.Play(My.Resources.boom, AudioPlayMode.Background)
    End Sub
End Module
