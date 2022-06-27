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
using System.Data.OleDb;
using ADOX;

namespace 해부학사전
{
    /// <summary>
    /// expert.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class expert : Window
    {
        
        string connStr = null;
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
 
        public expert()
        {
            InitializeComponent();
            DBConnect();
            makecombo();
            
        }      

        private void DBConnect()
        {
            connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\윤성희\Desktop\해부학사전\해부학사전\bin\Debug\DB\해부학사전 용어검색 DB.accdb; Persist Security Info=False";
        }

        private void makecombo()
        {
            string[] system = { "이제훈","홍세표","유광식","김병섭","박태준" };

            foreach (string p in system)
                cbexpert.Items.Add(p);

            cbexpert.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.access = 0;
            BodyImage.reverce = 0;
            Window Main = new MainWindow();
            this.Close();
            Main.ShowDialog();
        }

        private void cbexpert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbexpert.SelectedIndex == 0)
                return;

            var comboBox = sender as ComboBox;
            string epName = comboBox.SelectedItem as string;

            string sql = string.Format("SELECT * FROM 전문가 WHERE 성명='{0}'", epName);

            conn = new OleDbConnection(connStr);

    
                conn.Open();
                cmd = new OleDbCommand(sql, conn);

                reader = cmd.ExecuteReader();
          

            while (reader.Read())
                {
                    ename.Text = reader["성명"].ToString();
                    esex.Text = reader["성별"].ToString();
                    esys.Text = reader["진료과목"].ToString();
                    email.Text = reader["email"].ToString();
                
                    string iname = @"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\" + ename.Text + ".png";
                    Uri myUri = new Uri(iname, UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    experti.Source = image;
            }
            
            reader.Close();
                conn.Close();
        }

    }
}
