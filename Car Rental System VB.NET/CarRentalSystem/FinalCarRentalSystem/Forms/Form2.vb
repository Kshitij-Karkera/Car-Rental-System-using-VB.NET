Public Class Form2

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)

    End Sub

    Private Sub No_of_DaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_of_DaysTextBox.TextChanged
        Total_DueTextBox.Text = Val(Rent_DayTextBox.Text) * Val(No_of_DaysTextBox.Text)
    End Sub



    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        BindingNavigatorAddNewItem.PerformClick()


    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Hide()
    End Sub
End Class
