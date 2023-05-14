using BLL;
using DTO;
using GUI.Admin;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace GUI
{
    public partial class frmMenuPreview : Form
    {
        TabPage currentTabPage = new TabPage();
        PhanLoaiTD[] pltd;
        PhanLoaiTDBLL pltd_bll = new PhanLoaiTDBLL();
        ThucDonBLL td_bll = new ThucDonBLL();
        ThamSoBLL ts_bll = new ThamSoBLL();

        public frmMenuPreview()
        {
            InitializeComponent();
            this.Load += frmMenuPreview_Load;
            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            btnPrint.Click += btnPrint_Click;
        }

        private void frmMenuPreview_Load(object sender, EventArgs e)
        {
            tabMenu_Load();
            currentTabPage = tabMenu.TabPages[0];
        }

        private void tabMenu_Load()
        {
            pltd = pltd_bll.GetList(new PhanLoaiTD());
            if (pltd == null) { return; }
            foreach (PhanLoaiTD category in pltd)
            {
                // Create new TabPage
                TabPage newPage = new TabPage(category.TenLoai);
                newPage.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
                newPage.BackgroundImageLayout = ImageLayout.Stretch;
                Guna2VScrollBar scroll = new Guna2VScrollBar();
                scroll.BindingContainer = newPage;
                scroll.AutoRoundedCorners = true;

                // Load menu of each TabPage
                ThucDon td_find = new ThucDon();
                td_find.MaLoai = category.MaLoai;
                ThucDon[] td = td_bll.GetList(td_find);

                // If this catogery has no dish added
                if (td == null)
                {
                    newPage.Controls.Add(new Label()
                    {
                        Anchor = AnchorStyles.Top,
                        Text = "Chưa có món ăn nào được thêm vào phân loại thực đơn này!",
                        Font = new Font("Times New Roman", 14F, FontStyle.Bold)
                    });
                    tabMenu.Controls.Add(newPage);
                    // Skip to next category
                    continue;
                }

                // Add TableLayoutPanel to TabPage
                TableLayoutPanel newTable = new TableLayoutPanel();
                newTable.Name = String.Format("tblMenu{0}", category.MaLoai);
                newTable.AutoSize = true;
                newTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                newTable.BackColor = Color.Transparent;
                newTable.Dock = DockStyle.Top;
                newPage.Controls.Add(newTable);

                // Generate columns
                ThamSo ts_MenuColumns = new ThamSo();
                ts_MenuColumns.TenTS = "MenuColumns";
                ThamSo[] ts = ts_bll.GetList(ts_MenuColumns);
                if (ts == null)
                {
                    ShowError("Bạn chưa cài đặt số cột hiển thị cho thực đơn!");
                    return;
                }
                int numberOfColumns = ts[0].GiaTri;
                newTable.ColumnCount = numberOfColumns;
                float columnWidth = (float)(100 / numberOfColumns);
                for (int i = 0; i < numberOfColumns; i++)
                {
                    newTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidth));
                }

                int columnIndex = 0;
                foreach (ThucDon dish in td)
                {
                    if (columnIndex == numberOfColumns)
                    {
                        columnIndex = 0;
                    }
                    if (columnIndex % numberOfColumns == 0)
                    {
                        newTable.RowCount++;
                        newTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 300));
                    }

                    // Add TableLayoutPanel for each cell of menu
                    TableLayoutPanel cell = new TableLayoutPanel();
                    cell.AutoSize = true;
                    cell.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    cell.BackColor = Color.Transparent;
                    cell.Dock = DockStyle.Fill;
                    cell.ColumnCount = 1;
                    cell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    cell.RowCount = 3;
                    cell.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                    Guna2PictureBox img = new Guna2PictureBox();
                    img.Image = new Bitmap(dish.AnhMon);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Anchor = AnchorStyles.None;

                    cell.Controls.Add(img, 0, 0);
                    cell.Controls.Add(new Guna2HtmlLabel()
                    {
                        Anchor = AnchorStyles.None,
                        Text = dish.TenMon,
                        Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                    }, 0, 1);
                    cell.Controls.Add(new Guna2HtmlLabel()
                    {
                        Anchor = AnchorStyles.None,
                        Text = String.Format("{0} VNĐ", dish.GiaBan.ToString()),
                        Font = new Font("Times New Roman", 13F)
                    }, 0, 2);

                    newTable.Controls.Add(cell, columnIndex, newTable.RowCount - 1);

                    columnIndex++;
                }

                // Add new TabPage to TabControl 'tabMenu'
                tabMenu.Controls.Add(newPage);
            }
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;
            currentTabPage = tab.TabPages[tab.SelectedIndex];
        }

        Bitmap[] printMenu;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printMenu = new Bitmap[pltd.Length];
            for (int i = 0; i < pltd.Length; i++)
            {
                TableLayoutPanel tbl = (TableLayoutPanel)(tabMenu.TabPages[i].Controls[0]);
                printMenu[i] = new Bitmap(tbl.Width, tbl.Height);
                tbl.DrawToBitmap(printMenu[i], new Rectangle(0, 0, printMenu[i].Width, printMenu[i].Height));
            }
            
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += document_PrintPage;

            previewDialog.Document = document;
            previewDialog.ShowDialog();
        }

        int pageNumber = 0;
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = e.PageBounds;
            if ((double)printMenu[pageNumber].Width / (double)printMenu[pageNumber].Height > (double)rect.Width / (double)rect.Height)
            {
                rect.Height = (int)((double)printMenu[pageNumber].Height / (double)printMenu[pageNumber].Width * (double)rect.Width);
            }
            else
            {
                rect.Width = (int)((double)printMenu[pageNumber].Width / (double)printMenu[pageNumber].Height * (double)rect.Height);
            }
            e.Graphics.DrawImage(printMenu[pageNumber], rect);
            if (pageNumber < printMenu.Length - 1)
            {
                pageNumber++;
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
