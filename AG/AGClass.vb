Public Class AGClass
    Public pop As New List(Of UInt32) 'Lista de População - Inteiro
    Public nbits As UInt32 = (AG.txtNbits.Text)  'Número de Bit´s (Genes)
    Public limSup As Integer = 512 'Limte Superior
    Public limInf As Integer = 0 'Limite Inferior
    Public popSz As Integer = AG.txtMaxPop.Text 'Tamanho Limite da População - Fixo
    Public pc As Double = AG.nCruz.Value 'Probabilidade de Cruzamento - Fixa 0.6
    Public pm As Double = AG.nMut.Value 'Probabilidade de Mutação - Fixa 0.01 
    Private totalFitness As Double = 0 'Total de Aptidão
    Public rand As System.Random = New System.Random() 'Função Randômica
    Public fitness As New List(Of Double) 'Aptidão - Lista de Double
    Public iProb As New List(Of Double) 'Probabilidade - Lista de Double
    Public acumProb As New List(Of Double) 'Probabilidade Acumulada - Lista de Double
    Public geration As Integer = 1 'Start de Geração -1 Porque? Contador do Looping
    Public problem As New GeneratorProblem

    Public potencias As New List(Of Integer)(New Integer() {20, 15, 35, 40, 15, 15, 10})
    Public potenciaDemanda As New List(Of Integer)(New Integer() {80, 90, 65, 70})
    Public POTENCIA_TOTAL As Integer
    Public Sub New()
        '=Propriedades do Indivíduo (Gene)
        'Método que inicializa o AG

        rand = New Random()
        pop = New List(Of UInt32)
        Dim fitness = New List(Of Double)
        iProb = New List(Of Double)
        acumProb = New List(Of Double)

        POTENCIA_TOTAL = 0
        For i As Integer = 0 To potencias.Count - 1
            POTENCIA_TOTAL += potencias(i)
        Next
    End Sub

    'Converte Binário para Decimal
    Private Function bin2dec(value As String) As UInt32
        Return Convert.ToInt32(value, 2)
    End Function

    'Converte Decimal para Binário (porque e como converter?)
    'Usa para achar o ponto de fazer o cruzamento [0101100|10]
    Private Function dec2bin(value As UInt32) As String
        Dim s As String = Convert.ToString(value, 2)
        While s.Length < nbits
            ' ajusta número de casas
            s = Convert.ToString("0"c) & s
        End While
        Return s
    End Function

    'Método que Inicializa População
    Public Sub randPop()

        pop.Clear()  'Limpa a população
        Dim cromo As UInt32 = 0 'Seta o cromossomo para 0
        'Dim max As Integer = CInt(Math.Pow(2, nbits)) - 1 '??Criando a faixa de elementos (exemplo escada)
        For i As Integer = 0 To popSz - 1
            Do
                cromo = problem.randomIndividual
            Loop While pop.IndexOf(cromo) <> -1  'Exemplo do Maicon - SE tiver forma de gerar número aleató
            'rio sem repetir substituir por esta
            'Otimiza eliminando os números repetidos - Melhor explicação
            pop.Add(cromo) 'Adiciona o cromossomo a população
        Next

    End Sub
    'Função de Aptidão - Passada no Exemplo Citado
    'Função de maximização do x - depois multiplicavamos para o 01
    'No AG sempre vai achar a max, para ser min multiplicar por -1
    Public Overridable Function Fnfitness(x As UInt32) As Double
        '        """Fitness function"""
        'AG.dgvResultado.Columns.Clear()
        Dim bits As New bitArray(x)
        '#Evaluating wasted power
        Dim Val As UInt32
        Dim potPerdida As New List(Of Integer)(New Integer() {0, 0, 0, 0})
        Dim instante As Integer
        Dim gerador As Integer
        '        For i in range(28)
        '            Val = bits[i]
        '            If Val() == 0
        '                instante = i % 4 
        '                gerador = i // 4
        '                potPerdida[instante] += POTENCIAS[gerador]
        For i As Integer = 0 To 28 - 1
            Val = bits(i)

            If Val = 0 Then
                instante = i Mod 4
                gerador = Math.Floor(i / 4)
                potPerdida(instante) += potencias(gerador)
            End If
        Next
        '        #Evaluating fitness
        '#Criteria 1: Total PL average value  
        '                fitness = 130       #offset: eliminar valores negativos
        Dim fit = 130
        'pl = [0] * 4
        Dim pl As New List(Of Integer)(New Integer() {0, 0, 0, 0})
        '       
        '        For i in range(4)
        '            pl[i] = POTENCIA_TOTAL - potPerdida[i] - DEMANDAS[i]
        '            If pl Then[i] <= 0:  	 #restrição
        '                fitness -= 40    #penalidade
        '        fitness += sum(pl)
        '#Criteria 2: Standard Deviation Of PL
        '                        avg = sum(pl) / Len(pl)
        '                        variance = sum((avg - Val()) ** 2 For val In pl) / Len(pl)
        '                        stdDev = sqrt(variance)
        '                        fitness += (180 - stdDev) * 1.5
        '                    Return 0.5 * fitness

        For i As Integer = 0 To 4 - 1
            pl(i) = POTENCIA_TOTAL - potPerdida(i) - potenciaDemanda(i)
            If pl(i) <= 0 Then      '#restrição
                fit -= 40           '#penalidade
            End If
        Next

        Dim sum As Integer
        For j As Integer = 0 To pl.Count - 1
            sum += pl(j)
        Next
        fit += sum
        '#Criteria 2: Standard Deviation Of PL
        'variance = sum((avg - Val()) ** 2 For val In pl) / Len(pl)
        Dim avg = sum / pl.Count
        Dim variance As Integer = 0
        For i As Integer = 0 To pl.Count - 1
            variance += Math.Pow(avg - Val, 2)
        Next
        variance /= pl.Count
        'stdDev = sqrt(variance)
        Dim stdDev = Math.Sqrt(variance)
        'fitness += (180 - stdDev) * 1.5
        fit += (180 - stdDev) * 1.5
        'Return 0.5 * fitness
        Return 0.5 * fit

        'AG.preencherDataGrid()

    End Function

    'Função de decodificação do indvíduo
    'Porque decodificar o indivíduo? Indivíuo é = cromossomo
    'Para achar os intervalos possiveis no caso de 1024 entre -512 a 512 (-1) 
    'Neste caso ele ignora a parte negativa (-512) porém ele passa como 0.5 (Fator de PArticionamento
    'Limita a região e setoriza elas atráves de 1024 partes (contando o 0)
    'Porem na hora do calculo ignoramos o 0 (sendo assim 1024-1)
    Public Function decodeInd(ind As UInt32) As UInt32
        Return ind
        'Não muda dentro desse tipo de codificação
        'Passa de um setor para o valor
    End Function


    'Cálculo da Aptidão
    'Usa a função de aptidão.. mas como? e Porque? Ela represnta que cada indivíduo
    'é selecionado por ela
    'È para provar porque um individuo é melhor que o outro 
    'É o cálculo da qualidade 
    'Muitas vezes tem restrições e a função deixa de ser matemática e pode
    'ser um algorítmo (Baseado nas restrições)
    Private Sub CalcFitness()
        Dim x As UInt32 = 0
        Dim fts As Double = 0 'Resultado da FUnção de Aptidão
        totalFitness = 0
        fitness.Clear()
        For Each ind As UInt32 In pop
            x = decodeInd(ind)
            fts = Fnfitness(x)
            fitness.Add(fts)
            totalFitness += fts
        Next
    End Sub
    Private Sub sort(dec As Boolean)

        Dim tmp As New Double ' Fitness é sempre um decimal
        Dim tmp2 As New Integer 'Indivíduo passa a ser lista
        For i As Integer = 0 To popSz - 2
            For j As Integer = i + 1 To popSz - 1
                If dec = False Then
                    If fitness(j) < fitness(i) Then 'Ordenar em order crescente >
                        'troca de valores
                        tmp = fitness(i)
                        fitness(i) = fitness(j)
                        fitness(j) = tmp
                        tmp2 = pop(i)
                        pop(i) = pop(j)
                        pop(j) = tmp2
                    End If
                Else
                    If fitness(j) > fitness(i) Then 'Ordenar em order decrescente >
                        'troca de valores
                        tmp = fitness(i)
                        fitness(i) = fitness(j)
                        fitness(j) = tmp
                        tmp2 = pop(i)
                        pop(i) = pop(j)
                        pop(j) = tmp2
                    End If
                End If
            Next
        Next
    End Sub

#Region "Roleta - Função de Seleção"
    'Roleta - Dentro da Seleção (Só no caso da roleta)
    'Calculo da Probabilidade Individual e Acumulada
    Private Sub CalcProb()
        Dim acum As Double = 0
        Dim p As Double = 0
        iProb.Clear()
        acumProb.Clear()
        For i As Integer = 0 To popSz - 1
            p = CDbl(fitness(i) / totalFitness)
            iProb.Add(p)
            acum += p
            acumProb.Add(acum)
        Next
    End Sub

    'Função de Torneio
    'select
    'Criar um vetor que sortei N elementos randomicamente
    'DIm ELE as Integer
    'DIm FTN as double = 0
    'Variavel Ntor (Número de Elementos no Torneio)
    'For i  as integer = 0 to ntor -1
    'index = rand.popsz
    'IF (Ftn < fitness(index)
    'elm = index
    'Ftn = fitness(index)
    'end if
    'next


    ' Função de Seleção  ' Sai função da Roleta
    Private Function SelInd() As Integer 'Mudar o Nome para SelInd
        Dim roleta As Double = rand.NextDouble()
        For i As Integer = 0 To popSz - 1
            If roleta < acumProb(i) Then
                Return i
            End If
        Next
        Return -1
    End Function
#End Region

#Region "Cruzamento"
    'Função de Cruzamento

    Private Sub crossoverOnePoint(ByVal p1Idx As Integer, ByVal p2Idx As Integer, ByRef child1 As UInt32, ByRef child2 As UInt32)

        Dim p1 As UInt32 = pop(p1Idx)

        Dim p2 As UInt32 = pop(p2Idx)

        Dim crossIdx = rand.Next(1, 6)

        '# Mask creation
        '# Example: If crossIdx = 2 Then mask = 0b 1111 1111
        '#          alternatively, mask = 0b 1 0000 0000 - 1

        Dim mask As UInt32 = (1 << (4 * crossIdx)) - 1

        '# Child creation

        child1 = (p1 And mask) Or (p2 And (Not mask))
        'child1 = (p1 & mask) Or (p2 & (Not mask))
        child2 = (p1 And (Not mask)) Or (p2 And mask)

    End Sub

    Private Sub crossoverTwoPoints(ByVal p1Idx As Integer, ByVal p2Idx As Integer, ByRef child1 As Integer, ByRef child2 As Integer)
        '                """Two points crossover"""
        Dim p1 = pop(p1Idx)
        Dim p2 = pop(p2Idx)

        '# Random cross points

        Dim crossIdx1 = rand.Next(0, 6)
        Dim crossIdx2 = rand.Next(1, 6)

        If crossIdx1 > crossIdx2 Then
            '#asserting correct order
            Dim tmp = crossIdx1
            crossIdx1 = crossIdx2
            crossIdx2 = tmp
        End If

        '# Mask creation
        Dim bitRange = 4 * (crossIdx2 - crossIdx1)
        Dim mask = ((1 << bitRange) - 1) << (4 * crossIdx1)

        '#Children creation

        child1 = (p1 And mask) + (p2 And (Not mask))
        child2 = (p1 And (Not mask)) + (p2 And mask)

    End Sub

    Private Sub uniformCrossover(ByVal p1Idx As Integer, ByVal p2Idx As Integer, ByRef child1 As Integer, ByRef child2 As Integer)
        'Todo """Uniform crossover"""
        'p1 = self.population[p1Idx]
        'p2 = self.population[p2Idx]
        '#Mask creation
        'mask = 0
        'For i in range(7)
        '    If round(self.r.random()) == 1 Then
        '        mask |= ( 0b1111 << (4*i) )
        '#Children creation
        'child1 = (p1 & mask) + (p2 & (~mask) )
        'child2 = (p1 & (~mask) ) + ( p2 & mask )
        'Return (child1, child2)

    End Sub

    Private Sub crossover2(ByVal p1Idx As Integer, ByVal p2Idx As Integer, ByRef child1 As Integer, ByRef child2 As Integer)
        Dim crossmod As Integer
        Select Case crossMod
            Case 1
                crossoverOnePoint(p1Idx, p2Idx, child1, child2)
            ' The following is the only Case clause that evaluates to True.
            Case 2
                crossoverTwoPoints(p1Idx, p2Idx, child1, child2)
            Case 3
                uniformCrossover(p1Idx, p2Idx, child1, child2)
            Case Else
                crossoverTwoPoints(p1Idx, p2Idx, child1, child2)
        End Select
    End Sub
    Private Sub Crossover()

        Dim nPop As New List(Of UInt32)

#Region "Elitismo"
        'Ordenar(Fitness) OrdeyBy
        'Função de ordenar (método da bolha)
        sort(True)
        'Elitismo
        Dim elite As Integer = AG.nupElitismo.Value 'Valor de Elitismo

        For i As Integer = 0 To elite - 1 '(Só varrer a elite)
            'Vr se vai aceitar elite = 0
            nPop.Add(pop(i))
        Next

#End Region
        CalcProb()

        Dim pai1Idx As Integer = -1
        Dim pai2Idx As Integer = -1
        Dim pntCross As Integer = 0
        Dim fil1 As UInt32, fil2 As UInt32
        'Dim sPai1 As String, sPai2 As String, sFil1 As String, sFil2 As String

        While nPop.Count < pop.Count
            pai1Idx = -1
            pai2Idx = -1
            While pai1Idx = pai2Idx
                ' envita repetição
                pai1Idx = SelInd()
                pai2Idx = SelInd()
            End While
            If rand.NextDouble() <= pc Then
                ' probabilidade de cruzamento
                crossover2(pai1Idx, pai2Idx, fil1, fil2)
            Else
                fil1 = pop(pai1Idx)
                fil2 = pop(pai2Idx)
            End If

            nPop.Add(fil1)
            nPop.Add(fil2)

        End While
        If nPop.Count > 50 Then
            nPop.RemoveAt(0)
        End If
        pop = nPop
    End Sub
#End Region

#Region "Mutação"
    'Função de Mutação
    Private Sub Mutate()
        Dim newValue As Integer
        Dim Val As Integer

        Dim idx As New Integer
        For i As Integer = 0 To popSz - 1
            For b As Integer = 0 To 6
                If rand.NextDouble() < pm Then

                    '#Chosing New gene value
                    If b = 0 Or b = 1 Then
                        idx = rand.Next(problem.validPatternsA.Count)
                        newValue = problem.validPatternsA(idx)
                    Else
                        idx = rand.Next(problem.validPatternsB.Count)
                        newValue = problem.validPatternsB(idx)

                        '#Mutating individual
                        Val = pop(i)
                        Val = Val And Not (&H0F << (4 * b))   '#clearing bits from chosen gene
                        Val = Val Or (newValue << (4 * b)) '#adding New random gene
                        pop(i) = Val  '#replacing individual
                    End If
                End If
            Next
        Next

    End Sub
#End Region

#Region "Melhor Indivíduo"
    'Verificação do Melhor indivíduo
    'Resultado do Melhor individuo
    Private Function BestIndIdx() As Integer
        Dim bestIdx As Integer = 0
        For i As Integer = 1 To popSz - 1
            If fitness(bestIdx) < fitness(i) Then
                bestIdx = i
            End If
        Next

        Return bestIdx
    End Function


    Public Function bestInd() As Integer
        Return decodeInd(pop(BestIndIdx()))
    End Function
    'Sai a solução do problema.
    'Melhor função da aptidão.
#End Region

    'Função de Melhor aptidão aplicada para o melhor indivíduo?
    'Ver qual a aptidão do melhor indivíduo
    'identifica as melhoras propriedades do cronossomo que foi selecionado.
    Public Function bestFitness() As Double
        Return fitness(BestIndIdx())
    End Function

#Region "Evolução"
    'evolução por uma geração
    Private Sub evolve()
        If geration = 1 Then 'Otimiza para não ficar mais lento
            CalcFitness() 'Função de apatidão Incial para não calcular o ftnes
        End If
        Crossover() 'Cruzamento
        Mutate() 'Mutação
        geration += 1 'Incrementa uma geração
        CalcFitness()
    End Sub

    'Calcula para várias gerações
    Public Sub evolve(gerations As Integer)
        For i As Integer = 0 To gerations - 1 'Como funciona?
            evolve()
        Next
    End Sub
#End Region
End Class
