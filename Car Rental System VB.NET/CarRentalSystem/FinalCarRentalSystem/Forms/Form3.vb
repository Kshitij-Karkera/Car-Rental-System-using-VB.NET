Public Class Form3

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)

    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.Validate()
            Me.RentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)


            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Return
        End If
    End Sub

End Class