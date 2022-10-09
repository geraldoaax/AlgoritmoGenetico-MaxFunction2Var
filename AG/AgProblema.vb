Public Class AgProblema

    Public validPatternsA As New List(Of UInt32)
    Public validPatternsB As New List(Of UInt32)

    Public Function randomIndividual() As UInt32
        Return 0
    End Function

    Public Function individualToString(ByVal i As UInt32) As UInt32
        Return ""
    End Function

    Public rand As System.Random = New System.Random()


    'def randomIndividual(self)
    ''    """Creates and returns a random individual"""
    ''    g1 = self.r.choice(self.validPatternsA)
    ''    g2 = self.r.choice(self.validPatternsA)
    ''    individual = g1 + (g2 << 4)
    ''    For i in range(2,7):
    ''        individual += self.r.choice( self.validPatternsB ) << (4*i)
    ''    Return individual

    ''def individualToString(self, i)
    ''String = BitArray(i).toBinString()[:-1]
    ''    info = ' '.join(string[i:i+4] for i in range(0,len(string),4))
    ''    Return info
End Class
