﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteProduct
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToevoegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerwijderenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerechtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToevoegenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerwijderenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LijstenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.producten = New System.Windows.Forms.ListView()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventToolStripMenuItem, Me.GerechtToolStripMenuItem, Me.ProductToolStripMenuItem, Me.LijstenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(877, 38)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToevoegenToolStripMenuItem, Me.VerwijderenToolStripMenuItem, Me.WijzigenToolStripMenuItem})
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(76, 34)
        Me.EventToolStripMenuItem.Text = "&event"
        '
        'ToevoegenToolStripMenuItem
        '
        Me.ToevoegenToolStripMenuItem.Name = "ToevoegenToolStripMenuItem"
        Me.ToevoegenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.ToevoegenToolStripMenuItem.Text = "&toevoegen"
        '
        'VerwijderenToolStripMenuItem
        '
        Me.VerwijderenToolStripMenuItem.Name = "VerwijderenToolStripMenuItem"
        Me.VerwijderenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.VerwijderenToolStripMenuItem.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem
        '
        Me.WijzigenToolStripMenuItem.Name = "WijzigenToolStripMenuItem"
        Me.WijzigenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem.Text = "&wijzigen"
        '
        'GerechtToolStripMenuItem
        '
        Me.GerechtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WijzigenToolStripMenuItem1, Me.WijzigenToolStripMenuItem2, Me.WijzigenToolStripMenuItem4})
        Me.GerechtToolStripMenuItem.Name = "GerechtToolStripMenuItem"
        Me.GerechtToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.GerechtToolStripMenuItem.Text = "&gerecht"
        '
        'WijzigenToolStripMenuItem1
        '
        Me.WijzigenToolStripMenuItem1.Name = "WijzigenToolStripMenuItem1"
        Me.WijzigenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem1.Text = "&toevoegen"
        '
        'WijzigenToolStripMenuItem2
        '
        Me.WijzigenToolStripMenuItem2.Name = "WijzigenToolStripMenuItem2"
        Me.WijzigenToolStripMenuItem2.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem2.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem4
        '
        Me.WijzigenToolStripMenuItem4.Name = "WijzigenToolStripMenuItem4"
        Me.WijzigenToolStripMenuItem4.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem4.Text = "&wijzigen"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToevoegenToolStripMenuItem1, Me.VerwijderenToolStripMenuItem1, Me.WijzigenToolStripMenuItem3})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(97, 34)
        Me.ProductToolStripMenuItem.Text = "&product"
        '
        'ToevoegenToolStripMenuItem1
        '
        Me.ToevoegenToolStripMenuItem1.Name = "ToevoegenToolStripMenuItem1"
        Me.ToevoegenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.ToevoegenToolStripMenuItem1.Text = "&toevoegen"
        '
        'VerwijderenToolStripMenuItem1
        '
        Me.VerwijderenToolStripMenuItem1.Name = "VerwijderenToolStripMenuItem1"
        Me.VerwijderenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.VerwijderenToolStripMenuItem1.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem3
        '
        Me.WijzigenToolStripMenuItem3.Name = "WijzigenToolStripMenuItem3"
        Me.WijzigenToolStripMenuItem3.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem3.Text = "&wijzigen"
        '
        'LijstenToolStripMenuItem
        '
        Me.LijstenToolStripMenuItem.Name = "LijstenToolStripMenuItem"
        Me.LijstenToolStripMenuItem.Size = New System.Drawing.Size(79, 34)
        Me.LijstenToolStripMenuItem.Text = "&lijsten"
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(630, 65)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(158, 25)
        Me.lblNaam.TabIndex = 30
        Me.lblNaam.Text = "voornaam  naam"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(23, 65)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(99, 25)
        Me.lblUsername.TabIndex = 29
        Me.lblUsername.Text = "username"
        '
        'producten
        '
        Me.producten.HideSelection = False
        Me.producten.Location = New System.Drawing.Point(45, 134)
        Me.producten.Name = "producten"
        Me.producten.Size = New System.Drawing.Size(743, 264)
        Me.producten.TabIndex = 31
        Me.producten.UseCompatibleStateImageBehavior = False
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Location = New System.Drawing.Point(325, 421)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(184, 62)
        Me.btnDeleteSelected.TabIndex = 32
        Me.btnDeleteSelected.Text = "delete selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        '
        'deleteProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 536)
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.producten)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "deleteProduct"
        Me.Text = "deleteProduct"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerwijderenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerechtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerwijderenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LijstenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNaam As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents producten As ListView
    Friend WithEvents btnDeleteSelected As Button
End Class
