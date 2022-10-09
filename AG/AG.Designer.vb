<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtEvolve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFitness = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nMut = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nCruz = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNbits = New System.Windows.Forms.TextBox()
        Me.cmbCruzamento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSelecao = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaxPop = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nupPausa = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nupElitismo = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nupDP = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCruz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPausa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupElitismo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(739, 545)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(131, 40)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular AG"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtEvolve
        '
        Me.txtEvolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvolve.Location = New System.Drawing.Point(843, 66)
        Me.txtEvolve.Name = "txtEvolve"
        Me.txtEvolve.Size = New System.Drawing.Size(49, 30)
        Me.txtEvolve.TabIndex = 1
        Me.txtEvolve.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(745, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gerações ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X = "
        Me.Label2.Visible = False
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(110, 12)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(187, 30)
        Me.txtX.TabIndex = 3
        Me.txtX.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "f(x) = "
        Me.Label3.Visible = False
        '
        'txtfx
        '
        Me.txtfx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfx.Location = New System.Drawing.Point(357, 12)
        Me.txtfx.Name = "txtfx"
        Me.txtfx.Size = New System.Drawing.Size(197, 30)
        Me.txtfx.TabIndex = 5
        Me.txtfx.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(560, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fitness ="
        Me.Label4.Visible = False
        '
        'txtFitness
        '
        Me.txtFitness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitness.Location = New System.Drawing.Point(640, 12)
        Me.txtFitness.Name = "txtFitness"
        Me.txtFitness.Size = New System.Drawing.Size(210, 30)
        Me.txtFitness.TabIndex = 7
        Me.txtFitness.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(3, 6)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(127, 29)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Resultado"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 551)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvResultado)
        Me.TabPage1.Controls.Add(Me.lblResult)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(687, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resultado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvResultado
        '
        Me.dgvResultado.AllowUserToAddRows = False
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(8, 35)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.RowHeadersWidth = 51
        Me.dgvResultado.Size = New System.Drawing.Size(673, 484)
        Me.dgvResultado.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(687, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Aptidão"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(6, 6)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(675, 472)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(739, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Mut. ="
        '
        'nMut
        '
        Me.nMut.DecimalPlaces = 2
        Me.nMut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMut.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nMut.Location = New System.Drawing.Point(802, 332)
        Me.nMut.Name = "nMut"
        Me.nMut.Size = New System.Drawing.Size(90, 30)
        Me.nMut.TabIndex = 26
        Me.nMut.Value = New Decimal(New Integer() {3, 0, 0, 131072})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(733, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cruz. ="
        '
        'nCruz
        '
        Me.nCruz.DecimalPlaces = 2
        Me.nCruz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCruz.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nCruz.Location = New System.Drawing.Point(802, 300)
        Me.nCruz.Name = "nCruz"
        Me.nCruz.Size = New System.Drawing.Size(90, 30)
        Me.nCruz.TabIndex = 24
        Me.nCruz.Value = New Decimal(New Integer() {8, 0, 0, 65536})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(721, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Bit´s (Genes) ="
        '
        'txtNbits
        '
        Me.txtNbits.Enabled = False
        Me.txtNbits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbits.Location = New System.Drawing.Point(843, 98)
        Me.txtNbits.Name = "txtNbits"
        Me.txtNbits.Size = New System.Drawing.Size(49, 30)
        Me.txtNbits.TabIndex = 28
        Me.txtNbits.Text = "28"
        '
        'cmbCruzamento
        '
        Me.cmbCruzamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCruzamento.FormattingEnabled = True
        Me.cmbCruzamento.Items.AddRange(New Object() {"crossoverOnePoint", "crossoverTowPoints", "uniformCrossover"})
        Me.cmbCruzamento.Location = New System.Drawing.Point(707, 192)
        Me.cmbCruzamento.Name = "cmbCruzamento"
        Me.cmbCruzamento.Size = New System.Drawing.Size(185, 33)
        Me.cmbCruzamento.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(707, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Tipo Cruzamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(707, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Seleção"
        '
        'cmbSelecao
        '
        Me.cmbSelecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelecao.FormattingEnabled = True
        Me.cmbSelecao.Items.AddRange(New Object() {"Roleta", "Torneio", "Ranking"})
        Me.cmbSelecao.Location = New System.Drawing.Point(707, 252)
        Me.cmbSelecao.Name = "cmbSelecao"
        Me.cmbSelecao.Size = New System.Drawing.Size(185, 33)
        Me.cmbSelecao.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(754, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Max Pop ="
        '
        'txtMaxPop
        '
        Me.txtMaxPop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxPop.Location = New System.Drawing.Point(843, 130)
        Me.txtMaxPop.Name = "txtMaxPop"
        Me.txtMaxPop.Size = New System.Drawing.Size(49, 30)
        Me.txtMaxPop.TabIndex = 34
        Me.txtMaxPop.Text = "50"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(725, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 25)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Pausa = "
        '
        'nupPausa
        '
        Me.nupPausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupPausa.Location = New System.Drawing.Point(802, 429)
        Me.nupPausa.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupPausa.Name = "nupPausa"
        Me.nupPausa.Size = New System.Drawing.Size(90, 30)
        Me.nupPausa.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(715, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 25)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Elitismo = "
        '
        'nupElitismo
        '
        Me.nupElitismo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupElitismo.Location = New System.Drawing.Point(802, 364)
        Me.nupElitismo.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupElitismo.Name = "nupElitismo"
        Me.nupElitismo.Size = New System.Drawing.Size(90, 30)
        Me.nupElitismo.TabIndex = 40
        Me.nupElitismo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(733, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 25)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "DP ="
        '
        'nupDP
        '
        Me.nupDP.DecimalPlaces = 1
        Me.nupDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupDP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupDP.Location = New System.Drawing.Point(802, 396)
        Me.nupDP.Name = "nupDP"
        Me.nupDP.Size = New System.Drawing.Size(90, 30)
        Me.nupDP.TabIndex = 42
        Me.nupDP.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'AG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 602)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.nupDP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nupElitismo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.nupPausa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMaxPop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSelecao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCruzamento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNbits)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nMut)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nCruz)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFitness)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEvolve)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "AG"
        Me.Text = "AG"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCruz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPausa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupElitismo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtEvolve As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFitness As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label8 As Label
    Friend WithEvents nMut As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents nCruz As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNbits As TextBox
    Friend WithEvents cmbCruzamento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSelecao As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaxPop As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents nupPausa As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents nupElitismo As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents nupDP As NumericUpDown
End Class
