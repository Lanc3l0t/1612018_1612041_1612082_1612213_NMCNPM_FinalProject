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

namespace NMCNPM_FinalProject_ChessGame
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {// Thoát chương trình khi người dùng ấn CANCEL
            this.Close();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {// Xử lý nạp chương trình khi người dùng ấn OK

        }
    }
}
