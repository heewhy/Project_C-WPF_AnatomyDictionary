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

namespace 해부학사전
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        
        string connStr = null;
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        private string bsys;

        public Window1()
        {
            InitializeComponent();
            DBConnect();
            makecombo();
            txtVerb.Focus();
          
          
        }

        

        private void makecombo()
        {
            string[] system = { "뼈대계통", "근육계통", "순환계통", "신경계통", "특수감각계통", "소화계통", "호흡계통", "비뇨계통", "생식계통", "순환계통", "외피계통" };

            foreach (string p in system)
                cbBody.Items.Add(p);
            cbBody.SelectedIndex = 0;
        }

        private void DBConnect()
        {
            connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\윤성희\Desktop\해부학사전\해부학사전\bin\Debug\DB\해부학사전 용어검색 DB.accdb; Persist Security Info=False";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Window2.re == 0) {
                MainWindow.access = 0;
                Window Main = new MainWindow();
                this.Close();
                Main.ShowDialog();
            }
            else
            {
                Window2.re = 0;
                Window gosys = new Window2();
                this.Close();
                gosys.ShowDialog();
            }
        }

        private void cbBody_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbBody.SelectedIndex == 0)
                return;

            var comboBox = sender as ComboBox;
            string cbbody = comboBox.SelectedItem as string;
            bsys = cbbody;

            string sql = string.Format("SELECT * FROM " + cbbody, cbbody);
            conn = new OleDbConnection(connStr);
            
                conn.Open();
                cmd = new OleDbCommand(sql, conn);

                reader = cmd.ExecuteReader();
                nameAnto.Items.Clear();

                while (reader.Read())
                {
                    nameAnto.Items.Add((reader["신용어"].ToString()));
                }

                reader.Close();
                conn.Close();
            
        }

        private void nameAnto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem == null)
                return;


            string sql = string.Format("SELECT * FROM " + bsys + " WHERE 신용어='{0}'" ,lb.SelectedItem.ToString());
            conn = new OleDbConnection(connStr);

            

            conn.Open();
                cmd = new OleDbCommand(sql, conn);

                reader = cmd.ExecuteReader();

            try {
                while (reader.Read())
                {
                    txt신용어.Text = reader["신용어"].ToString();
                    txt구용어.Text = reader["구용어"].ToString();
                    txt영어.Text = reader["영어"].ToString();
                    txt기능.Text = reader["기능"].ToString();

                    string antoname = @"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\" + txt신용어.Text + ".png";
                    Uri myUri = new Uri(antoname, UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    phtAnto.Source = image;
                }

                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearTextBoxes()
        {
            txt신용어.Text = "";
            txt구용어.Text = "";
            txt영어.Text = "";
            txt기능.Text = "";
          
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            

            string sql = null;
            if (txtVerb.Text == "")
            {
                MessageBox.Show(" 신용어를 입력해주세요.", "Search Warning!!");
                return;
            }

            
            nameAnto.Items.Clear();
            cbBody.SelectedIndex = 0;

            clearTextBoxes();
            sql = string.Format("SELECT * FROM 검색 WHERE 신용어='{0}'", txtVerb.Text);
           

            conn = new OleDbConnection(connStr);

            int cnt = 0;
            
                conn.Open();
                cmd = new OleDbCommand(sql, conn);

                reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    cnt++;
                }
                if (cnt > 1)
                    MessageBox.Show("두개 이상이 존재합니다\n검색할 수 없습니다.\n\n");
                else
                {
                    reader.Close();
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    txt신용어.Text = reader["신용어"].ToString();
                    txt구용어.Text = reader["구용어"].ToString();
                    txt영어.Text = reader["영어"].ToString();
                    txt기능.Text = reader["기능"].ToString();

                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
