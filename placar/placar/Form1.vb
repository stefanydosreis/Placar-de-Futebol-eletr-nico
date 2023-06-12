Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCasa.SelectedIndexChanged
        If CbCasa.Text = "Botafogo" Then
            PictureBox1.Image = My.Resources.Botafogo
        End If
        If CbCasa.Text = "Flamengo" Then
            PictureBox1.Image = My.Resources.Flamengo
        End If
        If CbCasa.Text = "Fluminense" Then
            PictureBox1.Image = My.Resources.Sem_título
        End If
        If CbCasa.Text = "Vasco" Then
            PictureBox1.Image = My.Resources.vasco
        End If
        If CbCasa.Text <> "" And CbVisistante.Text <> "" Then
            BtGol1.Enabled = True
        End If
    End Sub

    Private Sub BtGol1_Click(sender As Object, e As EventArgs) Handles BtGol1.Click
        LbPlaca1.Text = LbPlaca1.Text * 1 + 1

    End Sub

    Private Sub BtGol2_Click(sender As Object, e As EventArgs) Handles BtGol2.Click
        LbPlaca2.Text = LbPlaca2.Text * 1 + 1
    End Sub


    Private Sub CbVisistante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVisistante.SelectedIndexChanged
        If CbVisistante.Text = "Botafogo" Then
            PictureBox2.Image = My.Resources.Botafogo
        End If
        If CbVisistante.Text = "Flamengo" Then
            PictureBox2.Image = My.Resources.Flamengo
        End If
        If CbVisistante.Text = "Fluminense" Then
            PictureBox2.Image = My.Resources.Sem_título
        End If
        If CbVisistante.Text = "Vasco" Then
            PictureBox2.Image = My.Resources.vasco
        End If
        If CbCasa.Text <> "" And CbVisistante.Text <> "" Then
            BtGol1.Enabled = True
        End If
    End Sub

    Private Sub btComecar_Click(sender As Object, e As EventArgs) Handles btComecar.Click
        BtGol1.Enabled = True
        BtGol2.Enabled = True
        LbPlaca1.Text = "0"
        LbPlaca2.Text = "0"
        LbMinutos.Text = "0"
        ProgressBar1.Value = 0
        CbCasa.Enabled = False
        CbVisistante.Enabled = False


        For cont As Integer = 1 To 90
            LbMinutos.Text = LbMinutos.Text * 1 + 1
            LbMinutos.Refresh()
            System.Threading.Thread.Sleep(200)
            ProgressBar1.Increment(1)
            Application.DoEvents()
        Next

        If Val(LbPlaca1.Text) > Val(LbPlaca2.Text) Then
            MsgBox(CbCasa.Text + " venceu por " + LbPlaca1.Text + " X " + LbPlaca2.Text)
        Else
            If Val(LbPlaca2.Text) > Val(LbPlaca1.Text) Then
                MsgBox(CbVisistante.Text + " venceu por " + LbPlaca2.Text + " X " + LbPlaca1.Text)
            Else
                MsgBox("O jogo empatou em " + LbPlaca1.Text + " X " + LbPlaca2.Text)
            End If
        End If
        BtGol2.Enabled = False
        btComecar.Enabled = False
        CbCasa.Enabled = True
        CbVisistante.Enabled = True
        BtGol1.Enabled = False
    End Sub
End Class
