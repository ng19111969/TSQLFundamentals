Public Class frmGestionProduits

    Private Sub frmGestionProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' remplir les listes déroulantes
        cboCategorie_RECH.DataSource = P_SELECT_CategoriesTableAdapter.GetData(True)
        cboFournisseur_RECH.DataSource = P_SELECT_SuppliersTableAdapter.GetData(True)

        cboCategorie.DataSource = P_SELECT_CategoriesTableAdapter.GetData(False)
        cboFournisseur.DataSource = P_SELECT_SuppliersTableAdapter.GetData(False)

        cboCategorie.SelectedIndex = -1
        cboFournisseur.SelectedIndex = -1

    End Sub
 
    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click

        EffectuerRecherche()

    End Sub

    Private Sub dgvProduits_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProduits.SelectionChanged

        AfficherDetail()

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim rangee As DataGridViewRow
    '    For Each rangee In dgvProduits.Rows
    '        MsgBox("produit: " + rangee.Cells(1).Value)
    '        rangee.Selected = True
    '    Next
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qtaRequete As New TSQLDataSetTableAdapters.QueriesTableAdapter

        qtaRequete.P_UPDATE_Products(dgvProduits.SelectedRows(0).Cells(0).Value,
            txtNomProduit.Text, cboFournisseur.SelectedValue, cboCategorie.SelectedValue, _
            txtPrix.Text, cbxDiscontinue.Checked)

        EffectuerRecherche()
    End Sub

    Private Sub EffectuerRecherche()
        Dim intDiscontinue As Integer

        ' détermine si on recherche les produits discontinués, non-discontinués ou peu importe
        If rbNonDiscontinues.Checked Then
            intDiscontinue = 0
        ElseIf rbDiscontinues.Checked Then
            intDiscontinue = 1
        Else
            intDiscontinue = 2
        End If

        ' effectue la recherche et remplit la datagridview des produits
        dgvProduits.DataSource = P_SELECT_ProductsTableAdapter.GetData(txtNomProduit_RECH.Text, _
                                                                       cboCategorie_RECH.SelectedValue, _
                                                                       cboFournisseur_RECH.SelectedValue, _
                                                                       intDiscontinue)

        ' affiche le nombre de produits retournés
        gbResultats.Text = dgvProduits.RowCount.ToString() + " produit(s)"
    End Sub

    Private Sub AfficherDetail()
        Dim taProduit As New TSQLDataSetTableAdapters.P_SELECT_Products_IDTableAdapter
        Dim dtProduit As DataTable

        If dgvProduits.SelectedRows.Count > 0 Then
            dtProduit = taProduit.GetData(dgvProduits.SelectedRows(0).Cells(0).Value)

            If dtProduit.Rows.Count > 0 Then
                ' affiche le détail du produit
                txtNomProduit.Text = dtProduit.Rows(0)("productname")
                txtPrix.Text = FormatNumber(dtProduit.Rows(0)("unitprice"), 2)
                cboCategorie.SelectedValue = dtProduit.Rows(0)("categoryid")
                cboFournisseur.SelectedValue = dtProduit.Rows(0)("supplierid")
                cbxDiscontinue.Checked = dtProduit.Rows(0)("discontinued")
            Else
                ' ?
                MsgBox("Oups!")
            End If
        Else
            ' vide les champs
            txtNomProduit.Clear()
            txtPrix.Clear()
            cbxDiscontinue.Checked = False
            cboCategorie.SelectedIndex = -1
            cboFournisseur.SelectedIndex = -1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AfficherDetail()
    End Sub
End Class
