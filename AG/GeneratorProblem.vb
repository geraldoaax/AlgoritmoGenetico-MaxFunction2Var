Option Explicit Off

Imports AG.AgProblema

Public Class GeneratorProblem
    Inherits AgProblema

    Public Sub New()

        'todo =  validPatternsA = [ 0b0011, 0b1001, 0b1100 ]
        validPatternsA.Add(3)
        validPatternsA.Add(9)
        validPatternsA.Add(12)
        'todo =     ''validPatternsB = [ 0b0111, 0b1011, 0b1101, 0b1110 ]
        validPatternsB.Add(7)
        validPatternsB.Add(11)
        validPatternsB.Add(13)
        validPatternsB.Add(14)



    End Sub
    ''  

    ''r = SystemRandom()

    ''def randomIndividual(self) : 
    ''    """Creates and returns a random individual"""
    ''    g1 = self.r.choice(self.validPatternsA)
    ''    g2 = self.r.choice(self.validPatternsA)
    ''    individual = g1 + (g2 << 4)
    ''    For i in range(2,7):
    ''        individual += self.r.choice( self.validPatternsB ) << (4*i)
    ''    Return individual
    Public Overloads Function randomIndividual() As UInt32
        Dim g1 = rand.Next(validPatternsA.Count)
        g1 = validPatternsA(g1) 'Retorna o Valor na Lista
        Dim g2 = rand.Next(validPatternsA.Count)
        g2 = validPatternsA(g2) 'Retorna o Valor na Lista

        Dim individual As UInt32
        individual = g1 + (g2 << 4)
        Dim idx As New Integer
        For i As Integer = 2 To 6
            'Pode-se Criar o choise
            idx = rand.Next(validPatternsB.Count)
            individual += validPatternsB(idx) << (4 * i)
        Next
        Return individual
    End Function

    Public Overloads Function individualToString(ByVal i As UInt32) As String
        'Dim info As String

        Return ""
    End Function

    ''def individualToString(self, i)
    ''String = BitArray(i).toBinString()[:-1]
    ''    info = ' '.join(string[i:i+4] for i in range(0,len(string),4))
    ''    Return info





End Class
