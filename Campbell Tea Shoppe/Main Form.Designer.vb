<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.breakfastLabel = New System.Windows.Forms.Label()
        Me.chamomileLabel = New System.Windows.Forms.Label()
        Me.citrusLabel = New System.Windows.Forms.Label()
        Me.earlLabel = New System.Windows.Forms.Label()
        Me.spicedLabel = New System.Windows.Forms.Label()
        Me.breakfastTextBox = New System.Windows.Forms.TextBox()
        Me.chamomileTextBox = New System.Windows.Forms.TextBox()
        Me.citrusTextBox = New System.Windows.Forms.TextBox()
        Me.earlTextBox = New System.Windows.Forms.TextBox()
        Me.spicedTextBox = New System.Windows.Forms.TextBox()
        Me.totalBoxesLabel = New System.Windows.Forms.Label()
        Me.salesTaxLabel = New System.Windows.Forms.Label()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.boxesLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Campbell_Tea_Shoppe.My.Resources.Resources.Tea
        Me.PictureBox1.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'breakfastLabel
        '
        Me.breakfastLabel.AutoSize = True
        Me.breakfastLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breakfastLabel.Location = New System.Drawing.Point(165, 32)
        Me.breakfastLabel.Name = "breakfastLabel"
        Me.breakfastLabel.Size = New System.Drawing.Size(106, 19)
        Me.breakfastLabel.TabIndex = 0
        Me.breakfastLabel.Text = "&Breakfast Blend:"
        '
        'chamomileLabel
        '
        Me.chamomileLabel.AutoSize = True
        Me.chamomileLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chamomileLabel.Location = New System.Drawing.Point(165, 77)
        Me.chamomileLabel.Name = "chamomileLabel"
        Me.chamomileLabel.Size = New System.Drawing.Size(81, 19)
        Me.chamomileLabel.TabIndex = 2
        Me.chamomileLabel.Text = "&Chamomile:"
        '
        'citrusLabel
        '
        Me.citrusLabel.AutoSize = True
        Me.citrusLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citrusLabel.Location = New System.Drawing.Point(165, 122)
        Me.citrusLabel.Name = "citrusLabel"
        Me.citrusLabel.Size = New System.Drawing.Size(89, 19)
        Me.citrusLabel.TabIndex = 4
        Me.citrusLabel.Text = "Citrus &Green:"
        '
        'earlLabel
        '
        Me.earlLabel.AutoSize = True
        Me.earlLabel.Location = New System.Drawing.Point(165, 167)
        Me.earlLabel.Name = "earlLabel"
        Me.earlLabel.Size = New System.Drawing.Size(67, 19)
        Me.earlLabel.TabIndex = 6
        Me.earlLabel.Text = "&Earl Grey:"
        '
        'spicedLabel
        '
        Me.spicedLabel.AutoSize = True
        Me.spicedLabel.Location = New System.Drawing.Point(165, 212)
        Me.spicedLabel.Name = "spicedLabel"
        Me.spicedLabel.Size = New System.Drawing.Size(82, 19)
        Me.spicedLabel.TabIndex = 8
        Me.spicedLabel.Text = "&Spiced Chai:"
        '
        'breakfastTextBox
        '
        Me.breakfastTextBox.Location = New System.Drawing.Point(277, 29)
        Me.breakfastTextBox.Name = "breakfastTextBox"
        Me.breakfastTextBox.Size = New System.Drawing.Size(47, 25)
        Me.breakfastTextBox.TabIndex = 1
        '
        'chamomileTextBox
        '
        Me.chamomileTextBox.Location = New System.Drawing.Point(277, 74)
        Me.chamomileTextBox.Name = "chamomileTextBox"
        Me.chamomileTextBox.Size = New System.Drawing.Size(47, 25)
        Me.chamomileTextBox.TabIndex = 3
        '
        'citrusTextBox
        '
        Me.citrusTextBox.Location = New System.Drawing.Point(277, 119)
        Me.citrusTextBox.Name = "citrusTextBox"
        Me.citrusTextBox.Size = New System.Drawing.Size(47, 25)
        Me.citrusTextBox.TabIndex = 5
        '
        'earlTextBox
        '
        Me.earlTextBox.Location = New System.Drawing.Point(277, 164)
        Me.earlTextBox.Name = "earlTextBox"
        Me.earlTextBox.Size = New System.Drawing.Size(47, 25)
        Me.earlTextBox.TabIndex = 7
        '
        'spicedTextBox
        '
        Me.spicedTextBox.Location = New System.Drawing.Point(277, 209)
        Me.spicedTextBox.Name = "spicedTextBox"
        Me.spicedTextBox.Size = New System.Drawing.Size(47, 25)
        Me.spicedTextBox.TabIndex = 9
        '
        'totalBoxesLabel
        '
        Me.totalBoxesLabel.AutoSize = True
        Me.totalBoxesLabel.Location = New System.Drawing.Point(379, 32)
        Me.totalBoxesLabel.Name = "totalBoxesLabel"
        Me.totalBoxesLabel.Size = New System.Drawing.Size(80, 19)
        Me.totalBoxesLabel.TabIndex = 10
        Me.totalBoxesLabel.Text = "Total boxes:"
        '
        'salesTaxLabel
        '
        Me.salesTaxLabel.AutoSize = True
        Me.salesTaxLabel.Location = New System.Drawing.Point(379, 90)
        Me.salesTaxLabel.Name = "salesTaxLabel"
        Me.salesTaxLabel.Size = New System.Drawing.Size(64, 19)
        Me.salesTaxLabel.TabIndex = 12
        Me.salesTaxLabel.Text = "Sales tax:"
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.AutoSize = True
        Me.totalPriceLabel.Location = New System.Drawing.Point(379, 132)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(74, 19)
        Me.totalPriceLabel.TabIndex = 14
        Me.totalPriceLabel.Text = "Total price:"
        '
        'boxesLabel
        '
        Me.boxesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.boxesLabel.Location = New System.Drawing.Point(459, 25)
        Me.boxesLabel.Name = "boxesLabel"
        Me.boxesLabel.Size = New System.Drawing.Size(42, 28)
        Me.boxesLabel.TabIndex = 11
        Me.boxesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxLabel.Location = New System.Drawing.Point(459, 82)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(98, 28)
        Me.taxLabel.TabIndex = 13
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceLabel
        '
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Location = New System.Drawing.Point(459, 125)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(98, 28)
        Me.priceLabel.TabIndex = 15
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(375, 194)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(105, 37)
        Me.calculateButton.TabIndex = 16
        Me.calculateButton.Text = "Ca&lculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(495, 194)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(105, 37)
        Me.exitButton.TabIndex = 17
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 300)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.boxesLabel)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.salesTaxLabel)
        Me.Controls.Add(Me.totalBoxesLabel)
        Me.Controls.Add(Me.spicedTextBox)
        Me.Controls.Add(Me.earlTextBox)
        Me.Controls.Add(Me.citrusTextBox)
        Me.Controls.Add(Me.chamomileTextBox)
        Me.Controls.Add(Me.breakfastTextBox)
        Me.Controls.Add(Me.spicedLabel)
        Me.Controls.Add(Me.earlLabel)
        Me.Controls.Add(Me.citrusLabel)
        Me.Controls.Add(Me.chamomileLabel)
        Me.Controls.Add(Me.breakfastLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Campbell Tea Shoppe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents breakfastLabel As Label
    Friend WithEvents chamomileLabel As Label
    Friend WithEvents citrusLabel As Label
    Friend WithEvents earlLabel As Label
    Friend WithEvents spicedLabel As Label
    Friend WithEvents breakfastTextBox As TextBox
    Friend WithEvents chamomileTextBox As TextBox
    Friend WithEvents citrusTextBox As TextBox
    Friend WithEvents earlTextBox As TextBox
    Friend WithEvents spicedTextBox As TextBox
    Friend WithEvents totalBoxesLabel As Label
    Friend WithEvents salesTaxLabel As Label
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents boxesLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
End Class
