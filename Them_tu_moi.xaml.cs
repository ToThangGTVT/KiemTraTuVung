using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using OfficeOpenXml;

namespace Học_tiếng_Nhật
{
    /// <summary>
    /// Interaction logic for Them_tu_moi.xaml
    /// </summary>
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
            if (txt_Eng.Text !="" & txt_Vie.Text != "")
            {
                lst_excel.Items.Add(new Items{ Eng = txt_Eng.Text, Vie = txt_Vie.Text });
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
    }

    public class Items
    {
        public string STT { get; set; }
        public string Eng { get; set; }
        public string Vie { get; set; }
    }
}
