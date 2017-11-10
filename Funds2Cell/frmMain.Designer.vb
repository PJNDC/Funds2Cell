<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSubmitBatch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHttpClient = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 702)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1161, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(158, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(997, 446)
        Me.DataGridView1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.264957!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.73505!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(152, 702)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnSubmitBatch, Me.ToolStripSeparator1, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripButton15, Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripButton20, Me.ToolStripButton21, Me.ToolStripButton22})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 50)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(152, 652)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 37
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(145, 20)
        Me.ToolStripLabel1.Text = "Menu"
        '
        'btnSubmitBatch
        '
        Me.btnSubmitBatch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitBatch.ForeColor = System.Drawing.Color.Black
        Me.btnSubmitBatch.Image = CType(resources.GetObject("btnSubmitBatch.Image"), System.Drawing.Image)
        Me.btnSubmitBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmitBatch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSubmitBatch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSubmitBatch.Name = "btnSubmitBatch"
        Me.btnSubmitBatch.Size = New System.Drawing.Size(145, 36)
        Me.btnSubmitBatch.Text = "Submit Batch"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.Enabled = False
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton13.Text = "Confirm Identify"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton14.Text = "Match"
        Me.ToolStripButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton15.Text = "Authorise Match"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton16.Text = "Transfer"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton17.Text = "Transmit"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton18.Text = "Change Date"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton19.Text = "Cancel Batch"
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton20.Text = "Cancel&&CSV Files"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton21.Text = "Contra"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.Size = New System.Drawing.Size(145, 24)
        Me.ToolStripButton22.Text = "Export To CSV"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(158, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(991, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtHttpClient
        '
        Me.txtHttpClient.Location = New System.Drawing.Point(158, 61)
        Me.txtHttpClient.Multiline = True
        Me.txtHttpClient.Name = "txtHttpClient"
        Me.txtHttpClient.Size = New System.Drawing.Size(394, 186)
        Me.txtHttpClient.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1161, 724)
        Me.Controls.Add(Me.txtHttpClient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSubmitBatch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHttpClient As System.Windows.Forms.TextBox

End Class
