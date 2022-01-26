using CookIT.BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookIT.Model;
using CookIT.Model.Repositories;

namespace CookIT.PresentationLayer
{
    public partial class frmViewMenus : Form, IViewMenusView
    {
        private IMainFormController _controller = null;
        private IMenuRepository _repository = null;
        private List<Meni> _menuList = null;
        public frmViewMenus()
        {
            InitializeComponent();
        }
        public void ShowMenus(IMainFormController inMainController, IMenuRepository inListRec)
        {
            _controller = inMainController;
            _repository = inListRec;
            _menuList = inListRec.GetAllMenus();

            UpdateList();

            this.Show();
        }


        private void addMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.AddMenu();
            _menuList = this._repository.GetAllMenus();
            UpdateList();
            this.Show();
        }

        private void UpdateList()
        {
            for (int i = 0; i < _menuList.Count(); i++)
            {
                Meni acc = _menuList[i];
            
                if (menuList.Items.ContainsKey(acc.Name))
                    continue;
              
                ListViewItem lvt = new ListViewItem(acc.Name);
                lvt.Name = acc.Name;
                lvt.SubItems.Add(acc.Entree);
                
                lvt.SubItems.Add(acc.MainCourse);
                lvt.SubItems.Add(acc.Desert);

                menuList.Items.Add(lvt);
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Menu_Click(object sender, EventArgs e)
        {
            if(menuList.SelectedItems.Count > 0)
            {
                string name = menuList.SelectedItems[0].Text;
                int ind = _repository.getMenuByName(name).Id;

                _controller.DeleteMenu(ind);
                menuList.Items.Clear();
                UpdateList();
            }
            else
            {
                MessageBox.Show("Please choose a menu to delete");
            }
            
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Call FindItemWithText with the contents of the textbox.
            ListViewItem foundItem =
                menuList.FindItemWithText(searchBox.Text, false, 0, true);
            if (foundItem != null)
            {
                menuList.TopItem = foundItem;
                menuList.Items.Clear();
                menuList.Items.Add(foundItem);
                UpdateList();
            }
            else
            {
                MessageBox.Show("No such menu... :(");
            }
        }
    }
}
