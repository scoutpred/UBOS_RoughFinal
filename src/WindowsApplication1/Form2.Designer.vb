<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchedulerProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FCFSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SJFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundRobinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllocationStrategiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskSchedulingAlgorithmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.TimeToolStripMenuItem, Me.CalculatorToolStripMenuItem1, Me.NotepadToolStripMenuItem1, Me.CommandPromptToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 677)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchedulerProgramsToolStripMenuItem, Me.ProgramsToolStripMenuItem, Me.ShutdownToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.menu1
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'SchedulerProgramsToolStripMenuItem
        '
        Me.SchedulerProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FCFSToolStripMenuItem, Me.SJFToolStripMenuItem, Me.PriorityToolStripMenuItem, Me.RoundRobinToolStripMenuItem, Me.AllocationStrategiesToolStripMenuItem, Me.DiskSchedulingAlgorithmsToolStripMenuItem})
        Me.SchedulerProgramsToolStripMenuItem.Name = "SchedulerProgramsToolStripMenuItem"
        Me.SchedulerProgramsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SchedulerProgramsToolStripMenuItem.Text = "Scheduler Programs"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.CommandPromptToolStripMenuItem1})
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProgramsToolStripMenuItem.Text = "Programs"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'CommandPromptToolStripMenuItem1
        '
        Me.CommandPromptToolStripMenuItem1.Name = "CommandPromptToolStripMenuItem1"
        Me.CommandPromptToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.CommandPromptToolStripMenuItem1.Text = "Command Prompt"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ShutDownOSToolStripMenuItem})
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShutdownToolStripMenuItem.Text = "Power Options"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ShutDownOSToolStripMenuItem
        '
        Me.ShutDownOSToolStripMenuItem.Name = "ShutDownOSToolStripMenuItem"
        Me.ShutDownOSToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ShutDownOSToolStripMenuItem.Text = "Shut Down OS"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TimeToolStripMenuItem.Enabled = False
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.TimeToolStripMenuItem.Text = "time"
        '
        'CalculatorToolStripMenuItem1
        '
        Me.CalculatorToolStripMenuItem1.Name = "CalculatorToolStripMenuItem1"
        Me.CalculatorToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.CalculatorToolStripMenuItem1.Text = "Calculator"
        '
        'NotepadToolStripMenuItem1
        '
        Me.NotepadToolStripMenuItem1.Name = "NotepadToolStripMenuItem1"
        Me.NotepadToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.NotepadToolStripMenuItem1.Text = "Notepad"
        '
        'CommandPromptToolStripMenuItem
        '
        Me.CommandPromptToolStripMenuItem.Name = "CommandPromptToolStripMenuItem"
        Me.CommandPromptToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.CommandPromptToolStripMenuItem.Text = "Command Prompt"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.dedicate
        Me.PictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Text = "Appearance Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Appearance Settings"
        '
        'FCFSToolStripMenuItem
        '
        Me.FCFSToolStripMenuItem.Name = "FCFSToolStripMenuItem"
        Me.FCFSToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FCFSToolStripMenuItem.Text = "FCFS"
        '
        'SJFToolStripMenuItem
        '
        Me.SJFToolStripMenuItem.Name = "SJFToolStripMenuItem"
        Me.SJFToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SJFToolStripMenuItem.Text = "SJF"
        '
        'PriorityToolStripMenuItem
        '
        Me.PriorityToolStripMenuItem.Name = "PriorityToolStripMenuItem"
        Me.PriorityToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PriorityToolStripMenuItem.Text = "Priority"
        '
        'RoundRobinToolStripMenuItem
        '
        Me.RoundRobinToolStripMenuItem.Name = "RoundRobinToolStripMenuItem"
        Me.RoundRobinToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RoundRobinToolStripMenuItem.Text = "Round Robin"
        '
        'AllocationStrategiesToolStripMenuItem
        '
        Me.AllocationStrategiesToolStripMenuItem.Name = "AllocationStrategiesToolStripMenuItem"
        Me.AllocationStrategiesToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.AllocationStrategiesToolStripMenuItem.Text = "Allocation Strategies"
        '
        'DiskSchedulingAlgorithmsToolStripMenuItem
        '
        Me.DiskSchedulingAlgorithmsToolStripMenuItem.Name = "DiskSchedulingAlgorithmsToolStripMenuItem"
        Me.DiskSchedulingAlgorithmsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.DiskSchedulingAlgorithmsToolStripMenuItem.Text = "Disk Scheduling Algorithms"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.wpp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 701)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UBOS GUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommandPromptToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CommandPromptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchedulerProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FCFSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SJFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriorityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundRobinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllocationStrategiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiskSchedulingAlgorithmsToolStripMenuItem As ToolStripMenuItem
End Class
