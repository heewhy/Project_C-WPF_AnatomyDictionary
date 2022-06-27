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


namespace 해부학사전
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static int access;                                         //이미지 제어 변수(인체도)

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ver = "";

            ver += "ver 1.0 : 메인메뉴 작성, 검색메뉴 작성, 인체도 뼈 틀 작성\n";
            ver += "ver 1.1 : 모든 메뉴 틀 완성(근육,뼈,신경,전문가,끝내기), 버튼이벤트 완성 \n";
            ver += "ver 1.2 : DB연결, 이미지파일 연결(error) \n";

            MessageBox.Show(ver+"버전정보");
        }
  private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            access = 1;
            Window bMenu1 = new BodyImage();
            this.Close();
            bMenu1.ShowDialog();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            access = 2;
            Window bMenu1 = new BodyImage();
            this.Close();
            bMenu1.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            access = 3;
            Window bMenu1 = new BodyImage();
            this.Close();
            bMenu1.ShowDialog();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Window sMenu = new Window1();
            this.Close();
            sMenu.ShowDialog();            
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window expert = new expert();
            this.Close();
            expert.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
