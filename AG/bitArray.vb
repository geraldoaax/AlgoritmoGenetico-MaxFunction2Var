Public Class bitArray
    '    Class BitArray(Of object) : 
    Public intVal As UInt32 = 0
    '    """Handles integers as bit arrays"""

    '    def __init__(self, intVal = 0) : 
    '        self.intVal = intVal
    Public Sub New(ByVal intVal As UInt32)
        Me.intVal = intVal
    End Sub


    '    def __getitem__(self, k)
    '        Return (self.intVal >> k) & 1

    '    def __setitem__(self, k, value)
    '        If value == 1 : 
    '            self.intVal |= (value << k)
    '        Else : 
    '            self.intVal &= ~(value << k)
    Default Public Property item(ByVal k As Integer) As UInt32
        Get
            Return (intVal >> k) And 1
        End Get
        Set(ByVal Value As UInt32)
            intVal = intVal And Not (Value << k)
        End Set
    End Property

    '    def toBinString(self) : 
    '        """Converts decimal number to binary string"""   
    '        Return '{:028b}'.format(self.intVal)

    Public Function toBinString()
        Return Convert.ToString(intVal, 2)
    End Function

    '    def fromBinString(self, binString) : 
    '        """Converts binary string to decimal number"""
    '        self.intVal = int('0b' + binString, 2)
    Public Sub fromBinString(ByVal binString As String)
        intVal = Convert.ToInt32(intVal, 2)
    End Sub

    'If __name__ == "__main__" : 
    '    individual = BitArray(0b1110011110111101111010011100)
    '    print("Normal dir: " + individual.toBinString())
    '    print("Reverse dir: " + individual.toBinString()[:-1])
End Class
