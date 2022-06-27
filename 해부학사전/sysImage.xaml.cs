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
    /// Window2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window2 : Window
    {
        internal static int re;                     //serch메뉴에서 다시 sys로 돌아오기위한 변수
        string connStr = null;
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        public Window2()
        {
            InitializeComponent();
            btnset();
            DBConnect();
        }

        private void DBConnect()
        {
            connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\윤성희\Desktop\해부학사전\해부학사전\bin\Debug\DB\해부학사전 용어검색 DB.accdb; Persist Security Info=False";
        }

        private void btnset()
        {
            if (MainWindow.access == 1)
            {
                if (BodyImage.reverce == 0)
                { 
                    if (BodyImage.choice == 1)       //근육 앞 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육머리앞.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "머리덮개근";
                        btnsys2.Content = "이마근";
                        btnsys3.Content = "눈둘레근";
                        btnsys4.Content = "눈살근";
                        btnsys5.Content = "입둘레근";
                        btnsys6.Content = "볼근";

                    }

                    if ( BodyImage.choice == 2)       //근육 앞 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육목앞.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "목빗근";
                        btnsys2.Content = "목세모근";
                        btnsys3.Content = "넓은목근";
                        btnsys4.Content = "어깨올림근";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 3)       //근육 앞 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육가슴앞.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "큰가슴근";
                        btnsys2.Content = "앞톱니근";
                        btnsys3.Content = "바깥갈비사이근";
                        btnsys4.Content = "속갈비사이근";
                        btnsys5.Content = "빗장아래근";
                        btnsys6.Content = "";
                    }

                    if ( BodyImage.choice == 4)       //근육 앞 배 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육배앞.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "배바깥빗근";
                        btnsys2.Content = "배속빗근";
                        btnsys3.Content = "배가로근";
                        btnsys4.Content = "배곧은근";
                        btnsys5.Content = "배세모근";
                        btnsys6.Content = "";
                    }

                    if ( BodyImage.choice == 5)       //근육 앞 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "짧은발가락폄근";
                        btnsys2.Content = "짧은엄지폄근";
                        btnsys3.Content = "엄지외향근";
                        btnsys4.Content = "새끼벌림근";
                        btnsys5.Content = "엄지모음근";
                        btnsys6.Content = "짧은새끼굽힘근";
                    }

                    if (BodyImage.choice == 6)       //근육 앞 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "어깨밑근";
                        btnsys2.Content = "어깨세모근";
                        btnsys3.Content = "가시위근";
                        btnsys4.Content = "가시아래근";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //근육 앞 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "네모엎침근";
                        btnsys2.Content = "얕은손가락굽힘근";
                        btnsys3.Content = "손가락폄근";
                        btnsys4.Content = "자쪽손목폄근";
                        btnsys5.Content = "자쪽손목굽힘근";
                        btnsys6.Content = "위팔세갈레근";
                    }

                    if (BodyImage.choice == 8)       //근육 앞 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육골반앞.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "엉덩근";
                        btnsys2.Content = "큰허리근";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //근육 앞 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "담모지외전근";
                        btnsys2.Content = "소지외전근";
                        btnsys3.Content = "골간근";
                        btnsys4.Content = "집게폄근";
                        btnsys5.Content = "긴엄지폄근";
                        btnsys6.Content = "짧은엄지폄근";
                    }

                    if (BodyImage.choice == 10)       //근육 앞 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "넙다리빗근";
                        btnsys2.Content = "넙다리네갈래근";
                        btnsys3.Content = "넙다리곧은근";
                        btnsys4.Content = "안쪽넓은근";
                        btnsys5.Content = "중간넓은근";
                        btnsys6.Content = "가쪽넓은근";
                    }
                }
                if (BodyImage.reverce == 1)
                {
                    if (BodyImage.choice == 1)       //근육 뒤 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육머리뒤.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "뒤통수근";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";

                    }

                    if (BodyImage.choice == 2)       //근육 뒤 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육목뒤.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "긴목근";
                        btnsys2.Content = "중간목갈비근";
                        btnsys3.Content = "긴머리근";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 3)       //근육 뒤 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육가슴뒤.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "등세모근";
                        btnsys2.Content = "넓은등근";
                        btnsys3.Content = "머리가장긴근";
                        btnsys4.Content = "목엉덩갈비근";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 4)       //근육 뒤 배 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육배뒤.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "허리사각근";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 5)       //근육 뒤 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "짧은발가락폄근";
                        btnsys2.Content = "짧은엄지폄근";
                        btnsys3.Content = "엄지외향근";
                        btnsys4.Content = "새끼벌림근";
                        btnsys5.Content = "엄지모음근";
                        btnsys6.Content = "짧은새끼굽힘근";
                    }

                    if (BodyImage.choice == 6)       //근육 뒤 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "어깨밑근";
                        btnsys2.Content = "어깨세모근";
                        btnsys3.Content = "가시위근";
                        btnsys4.Content = "가시아래근";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //근육 뒤 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "네모엎침근";
                        btnsys2.Content = "얕은손가락굽힘근";
                        btnsys3.Content = "손가락폄근";
                        btnsys4.Content = "자쪽손목폄근";
                        btnsys5.Content = "자쪽손목굽힘근";
                        btnsys6.Content = "위팔세갈레근";
                    }

                    if (BodyImage.choice == 8)       //근육 뒤 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육골반뒤.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "대둔근";
                        btnsys2.Content = "중둔근";
                        btnsys3.Content = "소둔근";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //근육 뒤 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "담모지외전근";
                        btnsys2.Content = "소지외전근";
                        btnsys3.Content = "골간근";
                        btnsys4.Content = "집게폄근";
                        btnsys5.Content = "긴엄지폄근";
                        btnsys6.Content = "짧은엄지폄근";
                    }

                    if (BodyImage.choice == 10)       //근육 뒤 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\근육다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "넙다리빗근";
                        btnsys2.Content = "넙다리네갈래근";
                        btnsys3.Content = "넙다리곧은근";
                        btnsys4.Content = "안쪽넓은근";
                        btnsys5.Content = "중간넓은근";
                        btnsys6.Content = "가쪽넓은근";
                    }
                }
            }
            if (MainWindow.access == 2)
            {
                if (BodyImage.reverce == 0)
                {
                    if (BodyImage.choice == 1)       //뼈 앞 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\뼈머리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "이마뼈";
                        btnsys2.Content = "광대뼈";
                        btnsys3.Content = "코뼈";
                        btnsys4.Content = "위턱뼈";
                        btnsys5.Content = "아래턱뼈";
                        btnsys6.Content = "";

                    }

                    if (BodyImage.choice == 2)       //뼈 앞 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\목뼈.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "목뿔뼈";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 3)       //뼈 앞 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\가슴.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "복장뼈";
                        btnsys2.Content = "갈비뼈";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 4)       //뼈 앞 배 btn
                    {
                        sysimage.Source = null;
                       
                        btnsys1.Content = "";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 5)       //뼈 앞 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "발목뼈";
                        btnsys2.Content = "발허리뼈";
                        btnsys3.Content = "발가락뼈";
                        btnsys4.Content = "쐐기뼈";
                        btnsys5.Content = "입방뼈";
                        btnsys6.Content = "발꿈치뼈";
                    }

                    if (BodyImage.choice == 6)       //뼈 앞 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "어깨뼈";
                        btnsys2.Content = "빗장뼈";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //뼈 앞 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "노뼈";
                        btnsys2.Content = "자뼈";
                        btnsys3.Content = "위팔뼈";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 8)       //뼈 앞 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\골반.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "엉덩뼈";
                        btnsys2.Content = "엉치뼈";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //뼈 앞 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "손목뼈";
                        btnsys2.Content = "손허리뼈";
                        btnsys3.Content = "손가락뼈";
                        btnsys4.Content = "반달뼈";
                        btnsys5.Content = "세모뼈";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 10)       //뼈 앞 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "무릎뼈";
                        btnsys2.Content = "정강뼈";
                        btnsys3.Content = "종아리뼈";
                        btnsys4.Content = "넙다리뼈";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }
                }
                if (BodyImage.reverce == 1)
                {
                    if (BodyImage.choice == 1)       //뼈 뒤 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\뒤통수.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "마루뼈";
                        btnsys2.Content = "뒤통수뼈";
                        btnsys3.Content = "관자뼈";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";

                    }

                    if (BodyImage.choice == 2)       //뼈 뒤 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\목뼈.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "목뼈";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 3)       //뼈 뒤 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\등.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "척주";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 4)       //뼈 뒤 배 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\등.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "척주";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 5)       //뼈 뒤 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "발목뼈";
                        btnsys2.Content = "발허리뼈";
                        btnsys3.Content = "발가락뼈";
                        btnsys4.Content = "쐐기뼈";
                        btnsys5.Content = "입방뼈";
                        btnsys6.Content = "발꿈치뼈";
                    }

                    if (BodyImage.choice == 6)       //뼈 뒤 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "어깨뼈";
                        btnsys2.Content = "빗장뼈";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //뼈 뒤 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "노뼈";
                        btnsys2.Content = "자뼈";
                        btnsys3.Content = "위팔뼈";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 8)       //뼈 뒤 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\엉덩이.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "꼬리뼈";
                        btnsys2.Content = "두덩뼈";
                        btnsys3.Content = "궁둥뼈";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //뼈 뒤 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "손목뼈";
                        btnsys2.Content = "손허리뼈";
                        btnsys3.Content = "손가락뼈";
                        btnsys4.Content = "반달뼈";
                        btnsys5.Content = "세모뼈";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 10)       //뼈 뒤 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "무릎뼈";
                        btnsys2.Content = "정강뼈";
                        btnsys3.Content = "종아리뼈";
                        btnsys4.Content = "넙다리뼈";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }
                }
            }
            if (MainWindow.access == 3)
            {
                if (BodyImage.reverce == 0)
                {
                    if (BodyImage.choice == 1)       //신경 앞 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경머리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "척수";
                        btnsys2.Content = "시각신경";
                        btnsys3.Content = "후각신경";
                        btnsys4.Content = "미주신경";
                        btnsys5.Content = "눈돌림신경";
                        btnsys6.Content = "대뇌";

                    }

                    if (BodyImage.choice == 2)       //신경 앞 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경목.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "더부신경";
                        btnsys2.Content = "혀밑신경";
                        btnsys3.Content = "가로막신경";
                        btnsys4.Content = "빗장위신경";
                        btnsys5.Content = "가로목신경";
                        btnsys6.Content = "목신경";
                    }

                    if (BodyImage.choice == 3)       //신경 앞 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경가슴.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "가슴신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 4)       //신경 앞 배 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경가슴.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "내장신경";
                        btnsys2.Content = "가로막신경";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 5)       //신경 앞 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "경골신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 6)       //신경 앞 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "겨드랑신경";
                        btnsys2.Content = "빗장위신경";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //신경 앞 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "노신경";
                        btnsys2.Content = "자신경";
                        btnsys3.Content = "정중신경";
                        btnsys4.Content = "근육피부신경";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 8)       //신경 앞 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경골반.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "엉치신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //신경 앞 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "정중신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 10)       //신경 앞 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "넙다리신경";
                        btnsys2.Content = "패쇄신경";
                        btnsys3.Content = "두렁신경";
                        btnsys4.Content = "볼기신경";
                        btnsys5.Content = "음부넙다리신경";
                        btnsys6.Content = "";
                    }
                }
                if (BodyImage.reverce == 1)
                {
                    if (BodyImage.choice == 1)       //신경 뒤 머리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경머리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "작은뒤통수신경";
                        btnsys2.Content = "큰뒤통수신경";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";

                    }

                    if (BodyImage.choice == 2)       //신경 뒤 목 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경목.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "더부신경";
                        btnsys2.Content = "혀밑신경";
                        btnsys3.Content = "가로막신경";
                        btnsys4.Content = "빗장위신경";
                        btnsys5.Content = "가로목신경";
                        btnsys6.Content = "목신경";
                    }

                    if (BodyImage.choice == 3)       //신경 뒤 가슴 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경가슴.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "등신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 4)       //신경 뒤 배 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경가슴.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "척수";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 5)       //신경 뒤 발 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경발.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "경골신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 6)       //신경 뒤 어깨 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경어깨.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "겨드랑신경";
                        btnsys2.Content = "빗장위신경";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 7)       //신경 뒤 팔 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경팔.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "노신경";
                        btnsys2.Content = "자신경";
                        btnsys3.Content = "정중신경";
                        btnsys4.Content = "근육피부신경";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 8)       //신경 뒤 골반 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경엉덩이.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "궁둥신경";
                        btnsys2.Content = "꼬리신경";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 9)       //신경 뒤 손 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경손.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "정중신경";
                        btnsys2.Content = "";
                        btnsys3.Content = "";
                        btnsys4.Content = "";
                        btnsys5.Content = "";
                        btnsys6.Content = "";
                    }

                    if (BodyImage.choice == 10)       //신경 뒤 다리 btn
                    {
                        sysimage.Source = null;
                        Uri myUri = new Uri(@"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\신경다리.png", UriKind.Absolute);
                        BitmapImage image = new BitmapImage(myUri);
                        sysimage.Source = image;

                        btnsys1.Content = "넙다리신경";
                        btnsys2.Content = "패쇄신경";
                        btnsys3.Content = "두렁신경";
                        btnsys4.Content = "볼기신경";
                        btnsys5.Content = "음부넙다리신경";
                        btnsys6.Content = "";
                    }
                }
            }
        }

        private void retu_Click(object sender, RoutedEventArgs e)   //돌아가기
        {
            Window2.re = 0;
            BodyImage.choice = 0;
            Window bMenu1 = new BodyImage();
            this.Close();
            bMenu1.ShowDialog();
        }

        private void btnsys_Click(object sender, RoutedEventArgs e) //serch메뉴로
        {
            Window2.re = 1;
            string content = (string)((Button)sender).Content;
            string table = null;

            if (MainWindow.access == 1) {
               table = "근육계통";
                    }
            if (MainWindow.access == 2)
            {
                table = "뼈대계통";
            }
            if (MainWindow.access == 3)
            {
                table = "신경계통";
            }

            string sql = string.Format("SELECT * FROM " +table+ " WHERE 신용어='{0}'", content);
            conn = new OleDbConnection(connStr);



            conn.Open();
            cmd = new OleDbCommand(sql, conn);

            reader = cmd.ExecuteReader();

            Window1 gosear = new Window1();

            try {

                while (reader.Read())
                {
                    gosear.txt신용어.Text = reader["신용어"].ToString();
                    gosear.txt구용어.Text = reader["구용어"].ToString();
                    gosear.txt영어.Text = reader["영어"].ToString();
                    gosear.txt기능.Text = reader["기능"].ToString();

                    string antoname = @"C:\Users\윤성희\Desktop\해부학사전\해부학사전\이미지파일\" + gosear.txt신용어.Text + ".png";
                    Uri myUri = new Uri(antoname, UriKind.Absolute);
                    BitmapImage image = new BitmapImage(myUri);
                    gosear.phtAnto.Source = image;
                }

                this.Close();
                gosear.ShowDialog();
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
