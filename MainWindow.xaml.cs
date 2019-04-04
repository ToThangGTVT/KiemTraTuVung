using OfficeOpenXml;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;


namespace Học_tiếng_Nhật
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        ExcelPackage package = new ExcelPackage(new FileInfo("từ vựng minna.xlsx"));
        int vitri;
        string hiragana;
        Color color = (Color)ColorConverter.ConvertFromString("#FF78909C");
        int vitri_dapan_dung;
        int diemso;
        public MainWindow()
        {
            InitializeComponent();
            txtD.Text = Properties.Settings.Default.diem;
            if (txtD.Text == "")
            {
                diemso = 0;
            }
            else
            {
                diemso = Convert.ToInt32(txtD.Text);
            }

            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        void dapan_ngaunhien()
        {

            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            Random rnd = new Random();
            vitri_dapan_dung = rnd.Next(1, 4);

            switch (vitri_dapan_dung)
            {
                case 1:
                    btnA.Content = WS.Cells[vitri, 2].Value.ToString();
                    btnA.ToolTip = WS.Cells[vitri, 2].Value.ToString();
                    break;
                case 2:
                    btnB.Content = WS.Cells[vitri, 2].Value.ToString();
                    btnB.ToolTip = WS.Cells[vitri, 2].Value.ToString();
                    break;
                case 3:
                    btnC.Content = WS.Cells[vitri, 2].Value.ToString();
                    btnC.ToolTip = WS.Cells[vitri, 2].Value.ToString();
                    break;
                case 4:
                    btnD.Content = WS.Cells[vitri, 2].Value.ToString();
                    btnD.ToolTip = WS.Cells[vitri, 2].Value.ToString();
                    break;
            }

            int solan = 1;
            int a = 1;
            while ((a == 0 && a == vitri) || solan == 1)
            {
                a = rnd.Next(1, WS.Dimension.End.Row);
                solan++;
            }
            int b = 1;
            while ((b == a && b == 0 && b == vitri) || solan == 1)
            {
                b = rnd.Next(1, WS.Dimension.End.Row);
                solan++;
            }
            int c = 1;
            solan = 1;
            while ((c == a && c == b && c == 0 && c == vitri) || solan == 1)
            {
                c = rnd.Next(1, WS.Dimension.End.Row);
                solan++;
            }
            int d = 1;
            solan = 1;
            while ((d == c && d == b && d == a && d == 0 && d == vitri) || solan == 1)
            {
                d = rnd.Next(1, WS.Dimension.End.Row);
                solan++;
            }

            int[] vitri_dapan_sai = new int[5];
            for (int i = 1; i <= 4; i++)
            {
                if (i != vitri_dapan_dung)
                {
                    vitri_dapan_sai[i] = i;
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                switch (vitri_dapan_sai[i])
                {
                    case 1:
                        btnA.Content = WS.Cells[a, 2].Value.ToString();
                        btnA.ToolTip = WS.Cells[a, 2].Value.ToString();
                        break;
                    case 2:
                        btnB.Content = WS.Cells[b, 2].Value.ToString();
                        btnB.ToolTip = WS.Cells[b, 2].Value.ToString();
                        break;
                    case 3:
                        btnC.Content = WS.Cells[c, 2].Value.ToString();
                        btnC.ToolTip = WS.Cells[c, 2].Value.ToString();
                        break;
                    case 4:
                        btnD.Content = WS.Cells[d, 2].Value.ToString();
                        btnD.ToolTip = WS.Cells[d, 2].Value.ToString();
                        break;

                }
            }
        }
        void tumoi_ngaunhien()
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            Random rnd = new Random();
            vitri = rnd.Next(1, WS.Dimension.End.Row);
            hiragana = WS.Cells[vitri, 1].Value.ToString();
            txtCH.Text = hiragana;
        }
        public Boolean kiemtra(string dapan)
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            Boolean kt = true;
            if (dapan == WS.Cells[vitri, 2].Value.ToString())
            {
                kt = true;
            }
            else
            {
                kt = false;
            }
            return kt;
        }

        void hienthi_tudung()
        {
            switch (vitri_dapan_dung)
            {
                case 1:
                    btnA.Background = Brushes.Green;
                    btnA.BorderBrush = Brushes.Green;
                    break;
                case 2:
                    btnB.Background = Brushes.Green;
                    btnB.BorderBrush = Brushes.Green;
                    break;
                case 3:
                    btnC.Background = Brushes.Green;
                    btnC.BorderBrush = Brushes.Green;
                    break;
                case 4:
                    btnD.Background = Brushes.Green;
                    btnD.BorderBrush = Brushes.Green;
                    break;
            }
        }

        void doimau_chocausau()
        {
            switch (vitri_dapan_dung)
            {
                case 1:
                    btnA.Background = new SolidColorBrush(color);
                    btnA.BorderBrush = new SolidColorBrush(color);
                    break;
                case 2:
                    btnB.Background = new SolidColorBrush(color);
                    btnB.BorderBrush = new SolidColorBrush(color);
                    break;
                case 3:
                    btnC.Background = new SolidColorBrush(color);
                    btnC.BorderBrush = new SolidColorBrush(color);
                    break;
                case 4:
                    btnD.Background = new SolidColorBrush(color);
                    btnD.BorderBrush = new SolidColorBrush(color);
                    break;
            }
        }


        async private void BtnA_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra(btnA.Content.ToString()) == true)
            {
                btnA.Background = Brushes.Green;
                btnA.BorderBrush = Brushes.Green;
                diemso++;
                txtD.Text = diemso.ToString();
                await Task.Delay(1000);
            }
            else
            {
                hienthi_tudung();
                btnA.Background = Brushes.Red;
                btnA.BorderBrush = Brushes.Red;
                await Task.Delay(3000);
                doimau_chocausau();
            }
            btnA.BorderBrush = new SolidColorBrush(color);
            btnA.Background = new SolidColorBrush(color);
            tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        async private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra(btnB.Content.ToString()) == true)
            {
                btnB.Background = Brushes.Green;
                btnB.BorderBrush = Brushes.Green;
                diemso++;
                txtD.Text = diemso.ToString();
                await Task.Delay(1000);
            }
            else
            {
                hienthi_tudung();
                btnB.Background = Brushes.Red;
                btnB.BorderBrush = Brushes.Red;
                await Task.Delay(3000);
                doimau_chocausau();
            }
            btnB.BorderBrush = new SolidColorBrush(color);
            btnB.Background = new SolidColorBrush(color);
            tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        async private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra(btnC.Content.ToString()) == true)
            {
                btnC.Background = Brushes.Green;
                btnC.BorderBrush = Brushes.Green;
                diemso++;
                txtD.Text = diemso.ToString();
                await Task.Delay(1000);
                diemso++;
                txtD.Text = diemso.ToString();
            }
            else
            {
                hienthi_tudung();
                btnC.Background = Brushes.Red;
                btnC.BorderBrush = Brushes.Red;
                await Task.Delay(3000);
                doimau_chocausau();
            }
            btnC.BorderBrush = new SolidColorBrush(color);
            btnC.Background = new SolidColorBrush(color);
            tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        async private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra(btnD.Content.ToString()) == true)
            {
                btnD.Background = Brushes.Green;
                btnD.BorderBrush = Brushes.Green;
                diemso++;
                txtD.Text = diemso.ToString();
                await Task.Delay(1000);
            }
            else
            {
                hienthi_tudung();
                btnD.Background = Brushes.Red;
                btnD.BorderBrush = Brushes.Red;
                await Task.Delay(3000);
                doimau_chocausau();
            }
            btnD.BorderBrush = new SolidColorBrush(color);
            btnD.Background = new SolidColorBrush(color);
            tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.diem = txtD.Text;
            Properties.Settings.Default.Save();
        }
    }
}
