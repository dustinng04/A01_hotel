using ModelAndDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFNguyenMinhDuc
{
    /// <summary>
    /// Interaction logic for BookingHistoryView.xaml
    /// </summary>
    public partial class BookingHistoryView : Window
    {
        private readonly int _customerId;

        public BookingHistoryView(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }
    }
}
