Imports System.Windows.Forms.DataVisualization.Charting
Imports AG.AGClass
Public Class AG
    Public itemModCrossover As Integer
    Private Sub AG_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbCruzamento.SelectedIndex = 0
        cmbSelecao.SelectedIndex = 0
        Me.dgvResultado.Columns.Add("Interrupção", "Interrupção")
        Me.dgvResultado.Columns.Add("1", "1")
        Me.dgvResultado.Columns.Add("2", "2")
        Me.dgvResultado.Columns.Add("3", "3")
        Me.dgvResultado.Columns.Add("4", "4")


        Me.dgvResultado.Rows.Add("Gerador 1")
        Me.dgvResultado.Rows.Add("Gerador 2")
        Me.dgvResultado.Rows.Add("Gerador 3")
        Me.dgvResultado.Rows.Add("Gerador 4")
        Me.dgvResultado.Rows.Add("Gerador 5")
        Me.dgvResultado.Rows.Add("Gerador 6")
        Me.dgvResultado.Rows.Add("Gerador 7")

        Me.dgvResultado.Rows.Add("PT-PP")
        Me.dgvResultado.Rows.Add("PD")
        Me.dgvResultado.Rows.Add("PL")

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ag As New AGClass
        ag.problem = New GeneratorProblem() 'Instanciando a Classe Generator Problem
        ag.randPop()

        itemModCrossover = cmbCruzamento.SelectedIndex



        'Dim s3 As New Series
        's3.Points.Clear()
        's3.Name = "Média por Melhor Indivíduo"
        's3.ChartType = SeriesChartType.Point
        'Chart1.Series.Add(s3)

        'Dim s4 As New Series
        's4.Points.Clear()
        's4.Name = "Melhor Indivíduo"
        's4.ChartType = SeriesChartType.Line
        'Chart1.Series.Add(s4)

        For d As Integer = 0 To txtEvolve.Text
            System.Threading.Thread.Sleep(nupPausa.Value)

            ag.evolve(1)

            txtX.Text = CStr(ag.bestInd())
            txtfx.Text = CStr(ag.Fnfitness(ag.bestInd()))
            txtFitness.Text = ag.bestFitness()

        Next
        Dim bit As New bitArray(ag.bestInd())

        lblResult.Text = bit.toBinString
        Dim s As New Char
        Dim result As New List(Of String)
        For Each s In lblResult.Text
            result.Add(s)
        Next

        Dim bitsAr As New bitArray(ag.bestInd)

        Dim Val As UInt32
        Dim instante As Integer
        Dim gerador As Integer
        Dim potPerdida As New List(Of Integer)(New Integer() {0, 0, 0, 0})
        Dim potencias = ag.potencias
        Dim pl As New List(Of Integer)(New Integer() {0, 0, 0, 0})

        For i As Integer = 0 To 28 - 1

            Val = bitsAr(i)
            instante = i Mod 4
            gerador = Math.Floor(i / 4)

            dgvResultado.Rows(gerador).Cells(instante + 1).Value = Val

            If Val = 0 Then
                potPerdida(instante) += potencias(gerador)
            End If
            pl(instante) = ag.POTENCIA_TOTAL - potPerdida(instante) - ag.potenciaDemanda(instante)

        Next

        For i As Integer = 0 To 4 - 1

            dgvResultado.Rows(7).Cells(i + 1).Value = ag.POTENCIA_TOTAL - potPerdida(i)
            dgvResultado.Rows(8).Cells(i + 1).Value = ag.potenciaDemanda(i)
            dgvResultado.Rows(9).Cells(i + 1).Value = pl(i)

        Next
        Application.DoEvents()
    End Sub


End Class
