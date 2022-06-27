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

namespace 해부학사전
{
    /// <summary>
    /// BodyImage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BodyImage : Window
    {
        internal static int reverce=0;              //반전을 알수있는 변수
        internal static int choice = 0;             //버튼을 알기위한 변수

        public BodyImage()
        {
            InitializeComponent();
            imageset();
        }

        private void imageset()
        {
            if (MainWindow.access == 1 && BodyImage.reverce == 0)       //근육 앞 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도근육앞.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri);
                bodyi.Source = image;
            }

            if (MainWindow.access == 1 && BodyImage.reverce == 1)       //근육 뒤 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도근육뒤.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri);
                bodyi.Source = image;
            }

            if (MainWindow.access == 2 && BodyImage.reverce==0)         //뼈 앞 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도뼈앞.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri);
                bodyi.Source = image;
            }

            if (MainWindow.access == 2 && BodyImage.reverce == 1)       //뼈 뒤 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도뼈뒤.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri);
                bodyi.Source = image;
            }

            if (MainWindow.access == 3 && BodyImage.reverce == 0)       //신경 앞 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도신경.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri);
                bodyi.Source = image;
            }

            if (MainWindow.access == 3 && BodyImage.reverce == 1)       //신경 뒤 image
            {
                bodyi.Source = null;
                Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도신경.png", UriKind.Absolute);
                BitmapImage image = new BitmapImage(myUri); 
                bodyi.Source = image;
            }
        }



        private void Button_ehead(object sender, MouseEventArgs e)      //mouseenter 이벤트
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 80;
            head.Height = 75;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(55, 10, 0, 0);
            bodyif.Children.Add(head);
            
        }

        private void Button_eneck(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 40;
            head.Height = 20;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(75, 80, 0, 0);
            bodyif.Children.Add(head);
        }

        

        private void Button_echest(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 110;
            head.Height = 100;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(40, 110, 0, 0);
            bodyif.Children.Add(head);
        }

        private void Button_esto(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 50;
            head.Height = 50;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(70, 180, 0, 0);
            bodyif.Children.Add(head);
        }

        private void Button_efoot(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 45;
            head.Height = 45;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(45, 500, 0, 0);
            bodyif.Children.Add(head);
            Rectangle head1 = new Rectangle();
            head1.Stroke = Brushes.Red;
            head1.Width = 45;
            head1.Height = 45;
            head1.StrokeThickness = 5;
            head1.Margin = new Thickness(105, 500, 0, 0);
            bodyif.Children.Add(head1);
        }

        private void Button_esho(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 120;
            head.Height = 20;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(40, 100, 0, 0);
            bodyif.Children.Add(head);
        }

        private void Button_earm(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 45;
            head.Height = 200;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(20, 100, 0, 0);
            bodyif.Children.Add(head);
            Rectangle head1 = new Rectangle();
            head1.Stroke = Brushes.Red;
            head1.Width = 45;
            head1.Height = 200;
            head1.StrokeThickness = 5;
            head1.Margin = new Thickness(130, 100, 0, 0);
            bodyif.Children.Add(head1);
        }

        private void Button_ewaist(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 80;
            head.Height = 50;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(55, 215, 0, 0);
            bodyif.Children.Add(head);
        }

        private void Button_ehand(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 45;
            head.Height = 45;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(0, 280, 0, 0);
            bodyif.Children.Add(head);
            Rectangle head1 = new Rectangle();
            head1.Stroke = Brushes.Red;
            head1.Width = 45;
            head1.Height = 45;
            head1.StrokeThickness = 5;
            head1.Margin = new Thickness(150, 280, 0, 0);
            bodyif.Children.Add(head1);
        }

        private void Button_eleg(object sender, MouseEventArgs e)
        {
            Rectangle head = new Rectangle();
            head.Stroke = Brushes.Red;
            head.Width = 45;
            head.Height = 230;
            head.StrokeThickness = 5;
            head.Margin = new Thickness(45, 270, 0, 0);
            bodyif.Children.Add(head);
            Rectangle head1 = new Rectangle();
            head1.Stroke = Brushes.Red;
            head1.Width = 45;
            head1.Height = 230;
            head1.StrokeThickness = 5;
            head1.Margin = new Thickness(105, 270, 0, 0);
            bodyif.Children.Add(head1);
        }

        private void Button_ccanvas(object sender, MouseEventArgs e)    //mouseleave이벤트
        {
            bodyif.Children.Clear();
        }

        private void Button_sysImage(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 1;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage2(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 2;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage3(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 3;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage4(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 4;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage5(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 5;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage6(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 6;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage7(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 7;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage8(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 8;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage9(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 9;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_sysImage10(object sender, RoutedEventArgs e)  //머리,어깨,팔등의 메뉴 클릭시
        {
            BodyImage.choice = 10;
            Window sysImage = new Window2();
            this.Close();
            sysImage.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)   //반전
        {
            if (BodyImage.reverce == 0)
            {
                BodyImage.reverce = 1;
                if (MainWindow.access == 1)       //근육 뒤 image
                {
                    bodyi.Source = null;
                    Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도근육뒤.png", UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    bodyi.Source = image;
                }

                if (MainWindow.access == 2)       //뼈 뒤 image
                {
                    bodyi.Source = null;
                    Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도뼈뒤.png", UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    bodyi.Source = image;
                }
            }
            else
            {
                BodyImage.reverce = 0;
                BodyImage.reverce = 1;

                if (MainWindow.access == 1)       //근육 앞 image
                {
                    bodyi.Source = null;
                    Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도근육앞.png", UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    bodyi.Source = image;
                }

                if (MainWindow.access == 2)       //뼈 앞 image
                {
                    bodyi.Source = null;
                    Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\인체도뼈앞.png", UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    bodyi.Source = image;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)      //돌아가기
        {
            MainWindow.access = 0;
            BodyImage.reverce = 0;
            Window Main = new MainWindow();
            this.Close();
            Main.ShowDialog();
        }
    }
}
