using EasyCaptcha.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
        }
        public enum LetterOption
        {
            Number,
            Alphabet,
            Alphanumeric,
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "" || password.Password == "" || myanswer.Text == "")
            {
                MessageBox.Show("Поля пустые");
            }
            else
            {
                int Loginn = int.Parse(login.Text);
                using (lastprakEntities1 db = new lastprakEntities1())
                {
                    User user = db.User.Where(x => x.Iduser == Loginn && x.password == password.Password).FirstOrDefault();
                    if (user != null) 
                    {
                        if (myanswer.Text != MyCaptcha.CaptchaText)
                        {
                            MessageBox.Show("Неверная капща");
                        }
                        else
                        {
                            CurrentUser.Id = user.Iduser;
                            switch (user.roleID)
                            {
                                case 1:
                                    WindowYch ych = new WindowYch();
                                    ych.Show();
                                    this.Close();
                                    break;
                                case 2:
                                    WindowZhury Zhury = new WindowZhury();
                                    Zhury.Show();
                                    this.Close();
                                    break;
                                case 3:
                                    WindowModer Moder = new WindowModer();
                                    Moder.Show();
                                    this.Close();
                                    break;
                                case 4:
                                    WindowOrgan organ = new WindowOrgan();
                                    organ.Show();   
                                    this.Close();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("неверные данные");
                    }
                }
            }
        }
    }
}
