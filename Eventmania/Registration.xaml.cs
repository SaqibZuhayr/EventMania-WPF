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

namespace Eventmania
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Registration()
        {
            InitializeComponent();

        }

     
        private void confirmb_Click(object sender, RoutedEventArgs e)
        {
            if (Nametb.Text != "" && lastnametb.Text != "" && emailtb.Text != "" && usernametb.Text != "" &&
                passwordtb.Text != "" && repasswordtb.Text != "" && phonenumbertb.Text!="")
            {
                if (passwordtb.Text != repasswordtb.Text)
                {
                    MessageBox.Show("Password doesnot match");
                }
                else
                {
                    User user = new User();

                    user.firstname = Nametb.Text;
                    user.lastname = lastnametb.Text;
                    user.email = emailtb.Text;
                    user.password = passwordtb.Text;
                    user.username = usernametb.Text;
                    user.repassword = repasswordtb.Text;
                    user.phoneno = phonenumbertb.Text;

                    dc.Users.InsertOnSubmit(user);
                    dc.SubmitChanges();

                    
                }
            }
            else
            {
                MessageBox.Show("*Please complete all fields");

            }
        }
    }
}
