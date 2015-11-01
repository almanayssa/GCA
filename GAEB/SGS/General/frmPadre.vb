Public Class frmPadre
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSGS As System.Windows.Forms.Label
    Friend WithEvents lblBarra3 As System.Windows.Forms.Label
    Friend WithEvents lblBarra2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBarra1 As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadre))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSGS = New System.Windows.Forms.Label()
        Me.lblBarra3 = New System.Windows.Forms.Label()
        Me.lblBarra2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBarra1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.My.Resources.Resources.diseño_login
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblSGS
        '
        Me.lblSGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblSGS.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSGS.ForeColor = System.Drawing.Color.Transparent
        Me.lblSGS.Location = New System.Drawing.Point(957, 11)
        Me.lblSGS.Name = "lblSGS"
        Me.lblSGS.Size = New System.Drawing.Size(58, 23)
        Me.lblSGS.TabIndex = 4
        Me.lblSGS.Text = "SGS"
        '
        'lblBarra3
        '
        Me.lblBarra3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarra3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBarra3.Location = New System.Drawing.Point(57, 35)
        Me.lblBarra3.Name = "lblBarra3"
        Me.lblBarra3.Size = New System.Drawing.Size(1000, 4)
        Me.lblBarra3.TabIndex = 7
        '
        'lblBarra2
        '
        Me.lblBarra2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBarra2.Location = New System.Drawing.Point(57, 9)
        Me.lblBarra2.Name = "lblBarra2"
        Me.lblBarra2.Size = New System.Drawing.Size(1000, 25)
        Me.lblBarra2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(70, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(959, 4)
        Me.Label1.TabIndex = 5
        '
        'lblBarra1
        '
        Me.lblBarra1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarra1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBarra1.Location = New System.Drawing.Point(57, 4)
        Me.lblBarra1.Name = "lblBarra1"
        Me.lblBarra1.Size = New System.Drawing.Size(1000, 4)
        Me.lblBarra1.TabIndex = 5
        '
        'frmPadre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 738)
        Me.Controls.Add(Me.lblSGS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBarra3)
        Me.Controls.Add(Me.lblBarra2)
        Me.Controls.Add(Me.lblBarra1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmPadre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
     Private Shared Sub ReleaseCapture()
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
   Private Shared Sub SendMessage( _
           ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
           ByVal wParam As Integer, ByVal lParam As Integer _
           )
    End Sub
    Public Sub moverForm(ByVal panel As Panel)
        ReleaseCapture()
        SendMessage(panel.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub

End Class
