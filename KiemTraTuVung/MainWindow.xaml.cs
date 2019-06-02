using Notifications.Wpf;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace Học_tiếng_Nhật
{
    public partial class MainWindow : Window
    {
        CARD k,k_hoc;
        ArrayList arrayList = new ArrayList();
        ArrayList arrayList_hoc = new ArrayList();
        ExcelPackage package = new ExcelPackage(new FileInfo("dic.xlsx"));
        int vitri = 1;
        string eng;
        Color color = (Color)ColorConverter.ConvertFromString("#FF78909C");
        int vitri_dapan_dung;
        int cot_da = 2;
        int cot_cauhoi = 1;
        int diemso;
        bool loai_cau_hoi;
        bool cho_phep_nhan_nut = true;
        bool tra_loi_sai = false;
        int cau_hoi_da_sai = 1;
        int sheet_hientai = 1;
        int sheet_hientai_hoc = 1;
        int row_max_hoc;
        int sheet_min = 1;
        int vitri_hoc=1;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(10);
            dispatcherTimer.Tick += ticker;
            dispatcherTimer.Start();

            txtD.Text = Properties.Settings.Default.diem;
            loai_cau_hoi = Properties.Settings.Default.chedohoc;

            if (txtD.Text == "")
            {
                diemso = 0;
            }
            else
            {
                diemso = Convert.ToInt32(txtD.Text);
            }

            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            if (loai_cau_hoi == false)
            {
                cot_cauhoi = 1;
                cot_da = 2;
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
            else
            {
                cot_cauhoi = 2;
                cot_da = 1;
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
        }

        private void ticker(object sender, EventArgs e)
        {
            ExcelWorksheet WS;
            WS = package.Workbook.Worksheets[sheet_hientai_hoc];
            try
            {
                row_max_hoc = WS.Dimension.End.Row;
            }
            catch
            {
                sheet_hientai_hoc = 1;
                vitri_hoc = 1;
            }

            if (vitri_hoc > row_max_hoc)
            {
                try
                {
                    sheet_hientai_hoc++;
                    WS = package.Workbook.Worksheets[sheet_hientai_hoc];
                    int j = WS.Dimension.End.Row;
                    vitri_hoc = 1;
                }
                catch
                {
                    sheet_hientai = 1;
                    vitri_hoc = 1;
                }
            }

            HOCTM htm = new HOCTM(Properties.Settings.Default.hoctumoi);
            if (htm.hoc_tu_moi == true)
            {
                show_ntf(vitri_hoc);
                vitri_hoc++;
            }
            arrayList_hoc.Clear();
        }

        void dapan_ngaunhien()
        {
            ExcelWorksheet WS;
            WS = package.Workbook.Worksheets[1];
            Random rnd = new Random();
            vitri_dapan_dung = rnd.Next(1, 4);

            switch (vitri_dapan_dung)
            {
                case 1:
                    btnA.Content = WS.Cells[vitri, cot_da].Value.ToString();
                    btnA.ToolTip = WS.Cells[vitri, cot_da].Value.ToString();
                    break;
                case 2:
                    btnB.Content = WS.Cells[vitri, cot_da].Value.ToString();
                    btnB.ToolTip = WS.Cells[vitri, cot_da].Value.ToString();
                    break;
                case 3:
                    btnC.Content = WS.Cells[vitri, cot_da].Value.ToString();
                    btnC.ToolTip = WS.Cells[vitri, cot_da].Value.ToString();
                    break;
                case 4:
                    btnD.Content = WS.Cells[vitri, cot_da].Value.ToString();
                    btnD.ToolTip = WS.Cells[vitri, cot_da].Value.ToString();
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
                        btnA.Content = WS.Cells[a, cot_da].Value.ToString();
                        btnA.ToolTip = WS.Cells[a, cot_da].Value.ToString();
                        break;
                    case 2:
                        btnB.Content = WS.Cells[b, cot_da].Value.ToString();
                        btnB.ToolTip = WS.Cells[b, cot_da].Value.ToString();
                        break;
                    case 3:
                        btnC.Content = WS.Cells[c, cot_da].Value.ToString();
                        btnC.ToolTip = WS.Cells[c, cot_da].Value.ToString();
                        break;
                    case 4:
                        btnD.Content = WS.Cells[d, cot_da].Value.ToString();
                        btnD.ToolTip = WS.Cells[d, cot_da].Value.ToString();
                        break;
                }
            }
        }

        private void chuyen_cau_hoi()
        {
            ExcelWorksheet WS, WS1;
            WS = package.Workbook.Worksheets[sheet_hientai];

            if (tra_loi_sai == false)
            {
                chuyen_len_tren(sheet_hientai, vitri, k);
            }
            else
            {

            }

            if (vitri == WS.Dimension.End.Row)
            {
                vitri = 1;
                sheet_hientai++;
                WS1 = package.Workbook.Worksheets[sheet_hientai];
                if (WS1.Dimension.End.Row == 0)
                {
                    sheet_hientai = 1;
                }
            }
            else
            {
                vitri++;
            }
        }

        private void load_excel(int sheet_hientai)
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[sheet_hientai];
            for (int i = 1; i <= WS.Dimension.End.Row; i++)
            {
                arrayList.Add(new CARD(WS.Cells[i, 1].Value.ToString(), WS.Cells[i, 2].Value.ToString()));
            }
        }

        private void load_excel_hoc(int sheet_hientai)
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[sheet_hientai];
            for (int i = 1; i <= WS.Dimension.End.Row; i++)
            {
                arrayList_hoc.Add(new CARD(WS.Cells[i, 1].Value.ToString(), WS.Cells[i, 2].Value.ToString()));
            }
        }

        async Task tumoi_ngaunhien()
        {
            ExcelWorksheet WS;
            WS = package.Workbook.Worksheets[sheet_hientai];
            while (WS.Dimension.End.Row == 0)
            {
                WS = package.Workbook.Worksheets[sheet_hientai + 1];
                sheet_hientai++;
            }

            load_excel(sheet_hientai);
            int index = vitri - 1;
            k = arrayList[index] as CARD;
            txtCH.Text = k.ENG;
            await phat_am(k.ENG);
        }

        private void chuyen_len_tren(int sheet_hien_tai, int vitri, CARD the_eng_vie)
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[sheet_hien_tai];
            WS.DeleteRow(vitri, vitri, true);
            package.Save();
            ExcelWorksheet WS1 = package.Workbook.Worksheets[sheet_hien_tai + 1];

            try
            {
                int vitri_cuoi = WS1.Dimension.End.Row;
                WS1.Cells[vitri_cuoi, 1].Value = the_eng_vie.ENG.ToString();
                WS1.Cells[vitri_cuoi, 2].Value = the_eng_vie.VIE.ToString();
                package.Save();
            }
            catch
            {
                int vitri_cuoi = 1;
                WS1.Cells[vitri_cuoi, 1].Value = the_eng_vie.ENG.ToString();
                WS1.Cells[vitri_cuoi, 2].Value = the_eng_vie.VIE.ToString();
                package.Save();
            }
        }

        public Boolean kiemtra(string dapan)
        {
            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            Boolean kt = true;
            if (dapan == WS.Cells[vitri, cot_da].Value.ToString())
            {
                kt = true;
            }
            else
            {
                kt = false;
                _ = phat_am_dapan(WS.Cells[vitri, cot_da].Value.ToString());
                cau_hoi_da_sai = vitri;
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
            if (cho_phep_nhan_nut == true)
            {
                cho_phep_nhan_nut = false;
                if (kiemtra(btnA.Content.ToString()) == true)
                {
                    btnA.Background = Brushes.Green;
                    btnA.BorderBrush = Brushes.Green;
                    diemso++;
                    txtD.Text = diemso.ToString();
                    await phat_am_dapan(btnA.Content.ToString());
                    await Task.Delay(1000);
                    cho_phep_nhan_nut = true;
                }
                else
                {
                    tra_loi_sai = true;
                    hienthi_tudung();
                    btnA.Background = Brushes.Red;
                    btnA.BorderBrush = Brushes.Red;
                    await Task.Delay(3000);
                    cho_phep_nhan_nut = true;
                    doimau_chocausau();

                }
                btnA.BorderBrush = new SolidColorBrush(color);
                btnA.Background = new SolidColorBrush(color);
                chuyen_cau_hoi();
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }

        }

        async private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            if (cho_phep_nhan_nut == true)
            {
                cho_phep_nhan_nut = false;
                if (kiemtra(btnB.Content.ToString()) == true)
                {
                    btnB.Background = Brushes.Green;
                    btnB.BorderBrush = Brushes.Green;
                    diemso++;
                    txtD.Text = diemso.ToString();
                    await phat_am_dapan(btnB.Content.ToString());
                    await Task.Delay(1000);
                    cho_phep_nhan_nut = true;
                }
                else
                {
                    tra_loi_sai = true;
                    hienthi_tudung();
                    btnB.Background = Brushes.Red;
                    btnB.BorderBrush = Brushes.Red;
                    await Task.Delay(3000);
                    cho_phep_nhan_nut = true;
                    doimau_chocausau();
                }
                btnB.BorderBrush = new SolidColorBrush(color);
                btnB.Background = new SolidColorBrush(color);
                chuyen_cau_hoi();
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }

        }

        async private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            if (cho_phep_nhan_nut == true)
            {
                cho_phep_nhan_nut = false;
                if (kiemtra(btnC.Content.ToString()) == true)
                {
                    btnC.Background = Brushes.Green;
                    btnC.BorderBrush = Brushes.Green;
                    diemso++;
                    txtD.Text = diemso.ToString();
                    await phat_am_dapan(btnC.Content.ToString());
                    await Task.Delay(1000);
                    cho_phep_nhan_nut = true;
                    diemso++;
                    txtD.Text = diemso.ToString();
                }
                else
                {
                    tra_loi_sai = true;
                    hienthi_tudung();
                    btnC.Background = Brushes.Red;
                    btnC.BorderBrush = Brushes.Red;
                    await Task.Delay(3000);
                    cho_phep_nhan_nut = true;
                    doimau_chocausau();
                }
                btnC.BorderBrush = new SolidColorBrush(color);
                btnC.Background = new SolidColorBrush(color);
                chuyen_cau_hoi();
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
        }

        async private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            if (cho_phep_nhan_nut == true)
            {
                cho_phep_nhan_nut = false;
                if (kiemtra(btnD.Content.ToString()) == true)
                {
                    btnD.Background = Brushes.Green;
                    btnD.BorderBrush = Brushes.Green;
                    diemso++;
                    txtD.Text = diemso.ToString();
                    await phat_am_dapan(btnD.Content.ToString());
                    await Task.Delay(1000);
                    cho_phep_nhan_nut = true;
                }
                else
                {
                    tra_loi_sai = true;
                    hienthi_tudung();
                    btnD.Background = Brushes.Red;
                    btnD.BorderBrush = Brushes.Red;
                    await Task.Delay(3000);
                    cho_phep_nhan_nut = true;
                    doimau_chocausau();
                }
                btnD.BorderBrush = new SolidColorBrush(color);
                btnD.Background = new SolidColorBrush(color);
                chuyen_cau_hoi();
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.chedohoc = loai_cau_hoi;
            Properties.Settings.Default.diem = txtD.Text;
            Properties.Settings.Default.Save();

        }

        private void BtnA_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (loai_cau_hoi == true)
            {
                loai_cau_hoi = false;
                cot_cauhoi = 1;
                cot_da = 2;
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
            else
            {
                loai_cau_hoi = true;
                cot_cauhoi = 2;
                cot_da = 1;
                _ = tumoi_ngaunhien();
                dapan_ngaunhien();
            }
        }

        private void Button_next_Click(object sender, RoutedEventArgs e)
        {
            _ = tumoi_ngaunhien();
            dapan_ngaunhien();
        }

        private async Task phat_am(string text)
        {
            if (loai_cau_hoi == false)
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Zira Desktop");
                await Task.Run(() => speech.Speak(text));
            }
        }

        private async Task phat_am_dapan(string text)
        {
            if (loai_cau_hoi == true)
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Zira Desktop");
                await Task.Run(() => speech.Speak(text));
            }
        }

        async private void Button_Click_play(object sender, RoutedEventArgs e)
        {
            await phat_am(eng);
        }

        private void them_tu_moi(object sender, RoutedEventArgs e)
        {
            Them_tu_moi tumoi = new Them_tu_moi();
            tumoi.btn_htm.IsChecked = Properties.Settings.Default.hoctumoi;
            tumoi.ShowDialog();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private CARD hoc_tu_moi(int i)
        {
            ExcelWorksheet WS;
            WS = package.Workbook.Worksheets[sheet_hientai_hoc];
            try
            {
                row_max_hoc = WS.Dimension.End.Row;
            }
            catch
            {
                sheet_hientai_hoc = 1;
                WS = package.Workbook.Worksheets[sheet_hientai_hoc];
            }
            while (WS.Dimension.End.Row == 0)
            {
                WS = package.Workbook.Worksheets[sheet_hientai_hoc + 1];
                sheet_hientai++;
            }

            load_excel_hoc(sheet_hientai_hoc);
            int index_hoc = i;
            k_hoc = arrayList_hoc[index_hoc-1] as CARD;
            return k_hoc;
        }

        private void show_ntf(int i)
        {
            NotifyIcon ntf = new NotifyIcon();
            string ta = hoc_tu_moi(i).ENG;
            string tv = hoc_tu_moi(i).VIE;

            var notificationManager = new NotificationManager();

            notificationManager.Show(new NotificationContent
            {
                Title = ta,
                Message = tv,
                Type = NotificationType.Information
            });

        }

    }
}
