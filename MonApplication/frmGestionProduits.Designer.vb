<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProduits
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cboCategorie_RECH = New System.Windows.Forms.ComboBox()
        Me.PSELECTCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSQLDataSet = New MonApplication.TSQLDataSet()
        Me.P_SELECT_CategoriesTableAdapter = New MonApplication.TSQLDataSetTableAdapters.P_SELECT_CategoriesTableAdapter()
        Me.cboFournisseur_RECH = New System.Windows.Forms.ComboBox()
        Me.PSELECTSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_SuppliersTableAdapter = New MonApplication.TSQLDataSetTableAdapters.P_SELECT_SuppliersTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomProduit_RECH = New System.Windows.Forms.TextBox()
        Me.Nom = New System.Windows.Forms.Label()
        Me.rbNonDiscontinues = New System.Windows.Forms.RadioButton()
        Me.rbDiscontinues = New System.Windows.Forms.RadioButton()
        Me.rbTous = New System.Windows.Forms.RadioButton()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProduits = New System.Windows.Forms.DataGridView()
        Me.ProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PSELECTProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_ProductsTableAdapter = New MonApplication.TSQLDataSetTableAdapters.P_SELECT_ProductsTableAdapter()
        Me.gbResultats = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNomProduit = New System.Windows.Forms.TextBox()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.cboFournisseur = New System.Windows.Forms.ComboBox()
        Me.cboCategorie = New System.Windows.Forms.ComboBox()
        Me.cbxDiscontinue = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PSELECTCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCategorie_RECH
        '
        Me.cboCategorie_RECH.DataSource = Me.PSELECTCategoriesBindingSource
        Me.cboCategorie_RECH.DisplayMember = "categoryname"
        Me.cboCategorie_RECH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorie_RECH.FormattingEnabled = True
        Me.cboCategorie_RECH.Location = New System.Drawing.Point(254, 72)
        Me.cboCategorie_RECH.Name = "cboCategorie_RECH"
        Me.cboCategorie_RECH.Size = New System.Drawing.Size(121, 21)
        Me.cboCategorie_RECH.TabIndex = 0
        Me.cboCategorie_RECH.ValueMember = "categoryid"
        '
        'PSELECTCategoriesBindingSource
        '
        Me.PSELECTCategoriesBindingSource.DataMember = "P_SELECT_Categories"
        Me.PSELECTCategoriesBindingSource.DataSource = Me.TSQLDataSet
        '
        'TSQLDataSet
        '
        Me.TSQLDataSet.DataSetName = "TSQLDataSet"
        Me.TSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_SELECT_CategoriesTableAdapter
        '
        Me.P_SELECT_CategoriesTableAdapter.ClearBeforeFill = True
        '
        'cboFournisseur_RECH
        '
        Me.cboFournisseur_RECH.DataSource = Me.PSELECTSuppliersBindingSource
        Me.cboFournisseur_RECH.DisplayMember = "companyname"
        Me.cboFournisseur_RECH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFournisseur_RECH.FormattingEnabled = True
        Me.cboFournisseur_RECH.Location = New System.Drawing.Point(254, 38)
        Me.cboFournisseur_RECH.Name = "cboFournisseur_RECH"
        Me.cboFournisseur_RECH.Size = New System.Drawing.Size(121, 21)
        Me.cboFournisseur_RECH.TabIndex = 1
        Me.cboFournisseur_RECH.ValueMember = "supplierid"
        '
        'PSELECTSuppliersBindingSource
        '
        Me.PSELECTSuppliersBindingSource.DataMember = "P_SELECT_Suppliers"
        Me.PSELECTSuppliersBindingSource.DataSource = Me.TSQLDataSet
        '
        'P_SELECT_SuppliersTableAdapter
        '
        Me.P_SELECT_SuppliersTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fournisseur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Catégorie"
        '
        'txtNomProduit_RECH
        '
        Me.txtNomProduit_RECH.Location = New System.Drawing.Point(64, 38)
        Me.txtNomProduit_RECH.Name = "txtNomProduit_RECH"
        Me.txtNomProduit_RECH.Size = New System.Drawing.Size(100, 20)
        Me.txtNomProduit_RECH.TabIndex = 4
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Location = New System.Drawing.Point(29, 41)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(29, 13)
        Me.Nom.TabIndex = 5
        Me.Nom.Text = "Nom"
        '
        'rbNonDiscontinues
        '
        Me.rbNonDiscontinues.AutoSize = True
        Me.rbNonDiscontinues.Checked = True
        Me.rbNonDiscontinues.Location = New System.Drawing.Point(32, 73)
        Me.rbNonDiscontinues.Name = "rbNonDiscontinues"
        Me.rbNonDiscontinues.Size = New System.Drawing.Size(107, 17)
        Me.rbNonDiscontinues.TabIndex = 6
        Me.rbNonDiscontinues.TabStop = True
        Me.rbNonDiscontinues.Text = "Non-discontinués"
        Me.rbNonDiscontinues.UseVisualStyleBackColor = True
        '
        'rbDiscontinues
        '
        Me.rbDiscontinues.AutoSize = True
        Me.rbDiscontinues.Location = New System.Drawing.Point(32, 97)
        Me.rbDiscontinues.Name = "rbDiscontinues"
        Me.rbDiscontinues.Size = New System.Drawing.Size(86, 17)
        Me.rbDiscontinues.TabIndex = 7
        Me.rbDiscontinues.Text = "Discontinués"
        Me.rbDiscontinues.UseVisualStyleBackColor = True
        '
        'rbTous
        '
        Me.rbTous.AutoSize = True
        Me.rbTous.Location = New System.Drawing.Point(32, 121)
        Me.rbTous.Name = "rbTous"
        Me.rbTous.Size = New System.Drawing.Size(49, 17)
        Me.rbTous.TabIndex = 8
        Me.rbTous.Text = "Tous"
        Me.rbTous.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(380, 23)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(75, 23)
        Me.btnRechercher.TabIndex = 9
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRechercher)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 137)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche"
        '
        'dgvProduits
        '
        Me.dgvProduits.AllowUserToAddRows = False
        Me.dgvProduits.AllowUserToDeleteRows = False
        Me.dgvProduits.AllowUserToResizeColumns = False
        Me.dgvProduits.AllowUserToResizeRows = False
        Me.dgvProduits.AutoGenerateColumns = False
        Me.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductidDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn, Me.DiscontinuedDataGridViewCheckBoxColumn})
        Me.dgvProduits.DataSource = Me.PSELECTProductsBindingSource
        Me.dgvProduits.Location = New System.Drawing.Point(19, 178)
        Me.dgvProduits.Name = "dgvProduits"
        Me.dgvProduits.ReadOnly = True
        Me.dgvProduits.RowHeadersVisible = False
        Me.dgvProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduits.Size = New System.Drawing.Size(577, 147)
        Me.dgvProduits.TabIndex = 11
        '
        'ProductidDataGridViewTextBoxColumn
        '
        Me.ProductidDataGridViewTextBoxColumn.DataPropertyName = "productid"
        Me.ProductidDataGridViewTextBoxColumn.HeaderText = "productid"
        Me.ProductidDataGridViewTextBoxColumn.Name = "ProductidDataGridViewTextBoxColumn"
        Me.ProductidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductidDataGridViewTextBoxColumn.Visible = False
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Produit"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "companyname"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "Fournisseur"
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        Me.CompanynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "categoryname"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Catégorie"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscontinuedDataGridViewCheckBoxColumn
        '
        Me.DiscontinuedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DiscontinuedDataGridViewCheckBoxColumn.DataPropertyName = "discontinued"
        Me.DiscontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinué"
        Me.DiscontinuedDataGridViewCheckBoxColumn.Name = "DiscontinuedDataGridViewCheckBoxColumn"
        Me.DiscontinuedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DiscontinuedDataGridViewCheckBoxColumn.Width = 69
        '
        'PSELECTProductsBindingSource
        '
        Me.PSELECTProductsBindingSource.DataMember = "P_SELECT_Products"
        Me.PSELECTProductsBindingSource.DataSource = Me.TSQLDataSet
        '
        'P_SELECT_ProductsTableAdapter
        '
        Me.P_SELECT_ProductsTableAdapter.ClearBeforeFill = True
        '
        'gbResultats
        '
        Me.gbResultats.Location = New System.Drawing.Point(13, 157)
        Me.gbResultats.Name = "gbResultats"
        Me.gbResultats.Size = New System.Drawing.Size(589, 180)
        Me.gbResultats.TabIndex = 12
        Me.gbResultats.TabStop = False
        Me.gbResultats.Text = "0 produit(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Prix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fournisseur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Catégorie"
        '
        'txtNomProduit
        '
        Me.txtNomProduit.Location = New System.Drawing.Point(51, 19)
        Me.txtNomProduit.Name = "txtNomProduit"
        Me.txtNomProduit.Size = New System.Drawing.Size(100, 20)
        Me.txtNomProduit.TabIndex = 17
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(51, 45)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(100, 20)
        Me.txtPrix.TabIndex = 18
        '
        'cboFournisseur
        '
        Me.cboFournisseur.DataSource = Me.PSELECTSuppliersBindingSource
        Me.cboFournisseur.DisplayMember = "companyname"
        Me.cboFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFournisseur.FormattingEnabled = True
        Me.cboFournisseur.Location = New System.Drawing.Point(241, 19)
        Me.cboFournisseur.Name = "cboFournisseur"
        Me.cboFournisseur.Size = New System.Drawing.Size(121, 21)
        Me.cboFournisseur.TabIndex = 19
        Me.cboFournisseur.ValueMember = "supplierid"
        '
        'cboCategorie
        '
        Me.cboCategorie.DataSource = Me.PSELECTCategoriesBindingSource
        Me.cboCategorie.DisplayMember = "categoryname"
        Me.cboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorie.FormattingEnabled = True
        Me.cboCategorie.Location = New System.Drawing.Point(241, 45)
        Me.cboCategorie.Name = "cboCategorie"
        Me.cboCategorie.Size = New System.Drawing.Size(121, 21)
        Me.cboCategorie.TabIndex = 20
        Me.cboCategorie.ValueMember = "categoryid"
        '
        'cbxDiscontinue
        '
        Me.cbxDiscontinue.AutoSize = True
        Me.cbxDiscontinue.Location = New System.Drawing.Point(51, 71)
        Me.cbxDiscontinue.Name = "cbxDiscontinue"
        Me.cbxDiscontinue.Size = New System.Drawing.Size(82, 17)
        Me.cbxDiscontinue.TabIndex = 21
        Me.cbxDiscontinue.Text = "Discontinué"
        Me.cbxDiscontinue.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbxDiscontinue)
        Me.GroupBox2.Controls.Add(Me.cboFournisseur)
        Me.GroupBox2.Controls.Add(Me.cboCategorie)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPrix)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNomProduit)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 102)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Détails"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Sauvegarder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(487, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmGestionProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 459)
        Me.Controls.Add(Me.dgvProduits)
        Me.Controls.Add(Me.rbTous)
        Me.Controls.Add(Me.rbDiscontinues)
        Me.Controls.Add(Me.rbNonDiscontinues)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.txtNomProduit_RECH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFournisseur_RECH)
        Me.Controls.Add(Me.cboCategorie_RECH)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbResultats)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmGestionProduits"
        Me.Text = "Gestion des produits"
        CType(Me.PSELECTCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCategorie_RECH As System.Windows.Forms.ComboBox
    Friend WithEvents PSELECTCategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TSQLDataSet As MonApplication.TSQLDataSet
    Friend WithEvents P_SELECT_CategoriesTableAdapter As MonApplication.TSQLDataSetTableAdapters.P_SELECT_CategoriesTableAdapter
    Friend WithEvents cboFournisseur_RECH As System.Windows.Forms.ComboBox
    Friend WithEvents PSELECTSuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_SuppliersTableAdapter As MonApplication.TSQLDataSetTableAdapters.P_SELECT_SuppliersTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomProduit_RECH As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.Label
    Friend WithEvents rbNonDiscontinues As System.Windows.Forms.RadioButton
    Friend WithEvents rbDiscontinues As System.Windows.Forms.RadioButton
    Friend WithEvents rbTous As System.Windows.Forms.RadioButton
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProduits As System.Windows.Forms.DataGridView
    Friend WithEvents PSELECTProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ProductsTableAdapter As MonApplication.TSQLDataSetTableAdapters.P_SELECT_ProductsTableAdapter
    Friend WithEvents ProductidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents gbResultats As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNomProduit As System.Windows.Forms.TextBox
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents cboFournisseur As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDiscontinue As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
