using System;
using System.Windows.Controls;
using Tema3.View_Model;

namespace RestaurantSQL.View
{
    /// <summary>
    /// Interaction logic for CartView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        public OrderView()
        {
             InitializeComponent();
            DataContext = new Order();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
