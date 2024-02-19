<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.LinkLabelProductUrl = New LinkLabel()
        Me.PictureBox1 = New PictureBox()
        Me.DataGridViewLoadedAssemblies = New DataGridView()
        Me.LabelProductName = New Label()
        Me.LabelVersion = New Label()
        Me.LabelArchitecture = New Label()
        Me.LabelCompany = New Label()
        Me.LabelCopyright = New Label()
        Me.LabelDescription = New Label()
        Me.LabelLoadedAssemblies = New Label()
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLoadedAssemblies, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' LinkLabelProductUrl
        ' 
        Me.LinkLabelProductUrl.AutoSize = True
        Me.LinkLabelProductUrl.Location = New Point(146, 125)
        Me.LinkLabelProductUrl.Name = "LinkLabelProductUrl"
        Me.LinkLabelProductUrl.Size = New Size(73, 15)
        Me.LinkLabelProductUrl.TabIndex = 0
        Me.LinkLabelProductUrl.TabStop = True
        Me.LinkLabelProductUrl.Text = "Product URL"
        ' 
        ' PictureBox1
        ' 
        Me.PictureBox1.BackgroundImage = My.Resources.Resources.Elektro
        Me.PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        Me.PictureBox1.Location = New Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(128, 128)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        ' 
        ' DataGridViewLoadedAssemblies
        ' 
        Me.DataGridViewLoadedAssemblies.AllowUserToAddRows = False
        Me.DataGridViewLoadedAssemblies.AllowUserToDeleteRows = False
        Me.DataGridViewLoadedAssemblies.AllowUserToOrderColumns = True
        Me.DataGridViewLoadedAssemblies.AllowUserToResizeRows = False
        Me.DataGridViewLoadedAssemblies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLoadedAssemblies.Location = New Point(12, 165)
        Me.DataGridViewLoadedAssemblies.MultiSelect = False
        Me.DataGridViewLoadedAssemblies.Name = "DataGridViewLoadedAssemblies"
        Me.DataGridViewLoadedAssemblies.ReadOnly = True
        Me.DataGridViewLoadedAssemblies.RowHeadersVisible = False
        Me.DataGridViewLoadedAssemblies.RowTemplate.Height = 25
        Me.DataGridViewLoadedAssemblies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLoadedAssemblies.Size = New Size(592, 185)
        Me.DataGridViewLoadedAssemblies.TabIndex = 4
        ' 
        ' LabelProductName
        ' 
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Me.LabelProductName.Location = New Point(146, 9)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New Size(120, 21)
        Me.LabelProductName.TabIndex = 5
        Me.LabelProductName.Text = "Product Name"
        ' 
        ' LabelVersion
        ' 
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Me.LabelVersion.Location = New Point(146, 47)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New Size(54, 19)
        Me.LabelVersion.TabIndex = 6
        Me.LabelVersion.Text = "Version"
        ' 
        ' LabelArchitecture
        ' 
        Me.LabelArchitecture.AutoSize = True
        Me.LabelArchitecture.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Me.LabelArchitecture.Location = New Point(146, 66)
        Me.LabelArchitecture.Name = "LabelArchitecture"
        Me.LabelArchitecture.Size = New Size(83, 19)
        Me.LabelArchitecture.TabIndex = 7
        Me.LabelArchitecture.Text = "Architecture"
        ' 
        ' LabelCompany
        ' 
        Me.LabelCompany.AutoSize = True
        Me.LabelCompany.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Me.LabelCompany.Location = New Point(146, 85)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New Size(68, 19)
        Me.LabelCompany.TabIndex = 8
        Me.LabelCompany.Text = "Company"
        ' 
        ' LabelCopyright
        ' 
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Me.LabelCopyright.Location = New Point(146, 104)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New Size(70, 19)
        Me.LabelCopyright.TabIndex = 9
        Me.LabelCopyright.Text = "Copyright"
        ' 
        ' LabelDescription
        ' 
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Me.LabelDescription.Location = New Point(146, 30)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New Size(76, 17)
        Me.LabelDescription.TabIndex = 10
        Me.LabelDescription.Text = "Description"
        ' 
        ' LabelLoadedAssemblies
        ' 
        Me.LabelLoadedAssemblies.AutoSize = True
        Me.LabelLoadedAssemblies.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Me.LabelLoadedAssemblies.Location = New Point(12, 143)
        Me.LabelLoadedAssemblies.Name = "LabelLoadedAssemblies"
        Me.LabelLoadedAssemblies.Size = New Size(128, 19)
        Me.LabelLoadedAssemblies.TabIndex = 11
        Me.LabelLoadedAssemblies.Text = "Loaded Assemblies:"
        ' 
        ' AboutForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(616, 362)
        Me.Controls.Add(Me.LabelLoadedAssemblies)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LabelCompany)
        Me.Controls.Add(Me.LabelArchitecture)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.DataGridViewLoadedAssemblies)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabelProductUrl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLoadedAssemblies, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LinkLabelProductUrl As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewLoadedAssemblies As DataGridView
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelArchitecture As Label
    Friend WithEvents LabelCompany As Label
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelLoadedAssemblies As Label
End Class
