using ConnectionStringCryptographyHelper;
using System;
using System.Windows;

namespace EncryptionDecryptionConnectionString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, RoutedEventArgs e)
        {
            var planText = txt_PlanText.Text;
            if(!string.IsNullOrEmpty(planText))
            {
                try
                {
                    var encryptedText = CryptographyHelper.Encrypt(planText);
                    txt_EncryptedText.Text = encryptedText;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter data which you want to Encrypt!");
            }
           
        }

        private void btn_Decrypt_Click(object sender, RoutedEventArgs e)
        {
            var encryptedText = txt_EncryptedText.Text;
            if (!string.IsNullOrEmpty(encryptedText))
            {
                try
                {
                    var decryptText = CryptographyHelper.Decrypt(encryptedText);
                   txt_Decrypted.Text = decryptText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter data which you want to Encrypt!");
            }
        }
    }
}
