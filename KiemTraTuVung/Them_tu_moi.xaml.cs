using OfficeOpenXml;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Học_tiếng_Nhật
{ 
    public partial class Them_tu_moi : Window
    {
        
        ExcelPackage package = new ExcelPackage(new FileInfo("dic.xlsx"));

        public Them_tu_moi()
        {
            InitializeComponent();
            ExcelWorksheet WS = package.Workbook.Worksheets[1];
            for (int i = 1; i <= WS.Dimension.End.Row; i++)
            {
                lst_excel.Items.Add(new Items
                {
                    STT = i.ToString(),
                    Vie = WS.Cells[i, 2].Value.ToString(),
                    Eng = WS.Cells[i, 1].Value.ToString()
                });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Eng.Text != "" & txt_Vie.Text != "")
            {
                lst_excel.Items.Add(new Items { Eng = txt_Eng.Text, Vie = txt_Vie.Text });
            }
            txt_Eng.Text = null;
            txt_Vie.Text = null;
            txt_Eng.Focus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //cập nhật vào CSDL
        {
            capnhatExcel();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //xóa bảng
        {
            lst_excel.Items.RemoveAt(lst_excel.Items.IndexOf(lst_excel.SelectedItem));
        }

        private void Them_tu_moi_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hoc;
            if (btn_htm.IsChecked == true)
            {
                hoc = true;
            }else
            {
                hoc = false;
            }
            Properties.Settings.Default.hoctumoi = hoc;
            capnhatExcel();
        }

        private void capnhatExcel()
        {
            Items k;
            ExcelWorksheet WS = package.Workbook.Worksheets[1];

            WS.DeleteRow(1, WS.Dimension.End.Row, true);

            for (int i = 0; i <= lst_excel.Items.Count - 1; i++)
            {
                k = lst_excel.Items[i] as Items;
                WS.Cells[i + 1, 1].Value = k.Eng.ToString();
                WS.Cells[i + 1, 2].Value = k.Vie.ToString();
            }
            package.Save();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (txt_Eng.Text != "" & txt_Vie.Text != "")
            {
                lst_excel.Items.Add(new Items { Eng = txt_Eng.Text, Vie = txt_Vie.Text });
            }
            txt_Eng.Text = null;
            txt_Vie.Text = null;
            txt_Eng.Focus();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            HOCTM hOCTM = new HOCTM(Properties.Settings.Default.hoctumoi);
            if (hOCTM.hoc_tu_moi == true)
            {
                hOCTM.hoc_tu_moi = false;
            }
            else
            {
                hOCTM.hoc_tu_moi = true;
            }
        }
    }

    public class Items
    {
        public string STT { get; set; }
        public string Eng { get; set; }
        public string Vie { get; set; }
    }
}
