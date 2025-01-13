Public Class Form1

    Private Sub Rent_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rent_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rent_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)
    End Sub

End Class