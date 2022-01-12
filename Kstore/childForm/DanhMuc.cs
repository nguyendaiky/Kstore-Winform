using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kstore.childForm
{
    public partial class DanhMuc : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        string[] strData;
        List<ItemData> itemsData = new List<ItemData>();
        string currentSearch;

        public DanhMuc()
        {
            InitializeComponent();
            strData = File.ReadAllLines("ItemData.txt");
            foreach (string line in strData)
            {
                itemsData.Add(JsonConvert.DeserializeObject<ItemData>(line));
            }
            currentSearch = "Tất cả";
            ShowAllProduct(itemsData);
        }

        private void ShowAllProduct(List<ItemData> itemsData)
        {
            pnl_Container.Controls.Clear();
            foreach (ItemData itemData in itemsData)
            {
                Item item = new Item();
                item.ItemId = itemData.id;
                item.ItemName = itemData.name;
                item.ItemType = itemData.type;
                item.ItemMaterial = "Chất liệu: " + itemData.material;
                item.ItemPrice = itemData.price.ToString("#,##0") + "đ";
                item.ItemImage = Image.FromFile(@"ItemImage\" + item.ItemId + ".jpg");
                pnl_Container.Controls.Add(item);
            }
        }

        private void ShowProductWithType(List<ItemData> itemsData, string typeSearch)
        {
            pnl_Container.Controls.Clear();
            foreach (ItemData itemData in itemsData)
            {
                if (itemData.type == typeSearch)
                {
                    Item item = new Item();
                    item.ItemId = itemData.id;
                    item.ItemName = itemData.name;
                    item.ItemType = itemData.type;
                    item.ItemMaterial = "Chất liệu: " + itemData.material;
                    item.ItemPrice = itemData.price.ToString("#,##0") + "đ";
                    item.ItemImage = Image.FromFile(@"ItemImage\" + item.ItemId + ".jpg");
                    pnl_Container.Controls.Add(item);
                }
            }
        }

        private void ShowProductWithName(List<ItemData> itemsData, string nameSearch)
        {
            pnl_Container.Controls.Clear();
            foreach (ItemData itemData in itemsData)
            {
                if (itemData.name.Contains(nameSearch.ToUpper()))
                {
                    Item item = new Item();
                    item.ItemId = itemData.id;
                    item.ItemName = itemData.name;
                    item.ItemType = itemData.type;
                    item.ItemMaterial = "Chất liệu: " + itemData.material;
                    item.ItemPrice = itemData.price.ToString("#,##0") + "đ";
                    item.ItemImage = Image.FromFile(@"ItemImage\" + item.ItemId + ".jpg");
                    pnl_Container.Controls.Add(item);
                }
            }
        }

        private void ShowProductWithMaterial(List<ItemData> itemsData, string materialSearch)
        {
            pnl_Container.Controls.Clear();
            foreach (ItemData itemData in itemsData)
            {
                if (itemData.material.Contains(materialSearch))
                {
                    Item item = new Item();
                    item.ItemId = itemData.id;
                    item.ItemName = itemData.name;
                    item.ItemType = itemData.type;
                    item.ItemMaterial = "Chất liệu: " + itemData.material;
                    item.ItemPrice = itemData.price.ToString("#,##0") + "đ";
                    item.ItemImage = Image.FromFile(@"ItemImage\" + item.ItemId + ".jpg");
                    pnl_Container.Controls.Add(item);
                }
            }
        }

        private void ShowProductWithPrice(List<ItemData> itemsData, string priceSearch)
        {
            double lowPrice = 0;
            double highPrice = 10000000;
            if (priceSearch == "< 200,000đ")
            {
                highPrice = 200000;
            }
            else if (priceSearch == "200,000đ - 350,000đ")
            {
                lowPrice = 200000;
                highPrice = 350000;
            }
            else if (priceSearch == "350,000đ - 500,000đ")
            {
                lowPrice = 350000;
                highPrice = 500000;
            }
            else if (priceSearch == "> 500,000đ")
            {
                lowPrice = 500000;
            }

            pnl_Container.Controls.Clear();
            foreach (ItemData itemData in itemsData)
            {
                if (itemData.price > lowPrice && itemData.price <= highPrice)
                {
                    Item item = new Item();
                    item.ItemId = itemData.id;
                    item.ItemName = itemData.name;
                    item.ItemType = itemData.type;
                    item.ItemMaterial = "Chất liệu: " + itemData.material;
                    item.ItemPrice = itemData.price.ToString("#,##0") + "đ";
                    item.ItemImage = Image.FromFile(@"ItemImage\" + item.ItemId + ".jpg");
                    pnl_Container.Controls.Add(item);
                }
            }
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            pic_TatCa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_TatCa.Width, pic_TatCa.Height, 20, 20));
            pic_Ao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_Ao.Width, pic_Ao.Height, 20, 20));
            pic_Quan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_Quan.Width, pic_Quan.Height, 20, 20));
            pic_AoKhoac.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_AoKhoac.Width, pic_AoKhoac.Height, 20, 20));
            pic_Non.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_Non.Width, pic_Non.Height, 20, 20));
            pic_Cap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_Cap.Width, pic_Cap.Height, 20, 20));
        }

        private void pic_TatCa_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Tất cả")
            {
                currentSearch = "Tất cả";
                ShowAllProduct(itemsData);
            }
        }

        private void pic_Ao_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Áo")
            {
                currentSearch = "Áo";
                ShowProductWithType(itemsData,currentSearch);
            }
        }

        private void pic_Quan_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Quần")
            {
                currentSearch = "Quần";
                ShowProductWithType(itemsData, currentSearch);
            }
        }

        private void pic_AoKhoac_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Áo khoác")
            {
                currentSearch = "Áo khoác";
                ShowProductWithType(itemsData, currentSearch);
            }
        }

        private void pic_Non_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Nón")
            {
                currentSearch = "Nón";
                ShowProductWithType(itemsData, currentSearch);
            }
        }

        private void pic_Cap_Click(object sender, EventArgs e)
        {
            if (currentSearch != "Túi")
            {
                currentSearch = "Túi";
                ShowProductWithType(itemsData, currentSearch);
            }
        }

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (currentSearch != txt_SearchBox.Text)
            {
                currentSearch = txt_SearchBox.Text;
                ShowProductWithName(itemsData, currentSearch);
            }
        }

        private void cb_ChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSearch != cb_ChatLieu.Text)
            {
                currentSearch = cb_ChatLieu.Text;
                ShowProductWithMaterial(itemsData, currentSearch);
            }
        }

        private void cb_MucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSearch != cb_MucGia.Text)
            {
                currentSearch = cb_MucGia.Text;
                ShowProductWithPrice(itemsData, currentSearch);
            }
        }
    }
}
