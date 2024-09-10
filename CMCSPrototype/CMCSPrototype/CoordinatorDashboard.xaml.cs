using System.Windows.Controls; // Use this namespace for Page
using System.Windows; // Use this namespace for MessageBox

namespace CMCSPrototype
{
    public partial class CoordinatorDashboard : Page
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
        }

        // Event handler for approving a claim
        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved");
        }

        // Event handler for rejecting a claim
        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Rejected");
        }

        // Event handler for claim selection (pending claim details)
        private void OnClaimSelected(object sender, SelectionChangedEventArgs e)
        {
            // Placeholder for logic when a claim is selected from the DataGrid
        }
    }
}
