using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDbContext;
using EFDbContext.Entity;

namespace OrderGUI {
  public partial class MainForm : Form {
      readonly OrderService _orderService = new OrderService();
    public MainForm() {
      InitializeComponent();

      orderBindingSource.DataSource = _orderService.GetAllOrders();
    }

    private void button1_Click(object sender, EventArgs e) {
      QueryOrder();
    }


    private void button2_Click(object sender, EventArgs e) {
      var editForm = new EditForm(null);
      editForm.ShowDialog();
      QueryOrder();
    }

    private void button3_Click(object sender, EventArgs e) {
      if (orderBindingSource.Current != null) {
        var editForm = new EditForm((Order)orderBindingSource.Current);
        editForm.ShowDialog();
        QueryOrder();
      }
      else {
        MessageBox.Show(@"No Order is selected!");
      }
    }
    private void button4_Click(object sender, EventArgs e) {
      if (orderBindingSource.Current != null) {
        var order=(Order)orderBindingSource.Current;
        _orderService.Delete(order.Id);
        QueryOrder();
      }
      else {
        MessageBox.Show(@"No Order is selected!");
      }
    }

    private void QueryOrder() {
      switch (comboBox1.SelectedIndex) {
        
        case 1:
          orderBindingSource.DataSource =
            _orderService.GetOrder(textBox1.Text);
          break;
        case 2:
          orderBindingSource.DataSource =
            _orderService.QueryByCustormer(textBox1.Text);
          break;
        case 3:
          orderBindingSource.DataSource =
            _orderService.QueryByGoods(textBox1.Text);
          break;
        default:
          orderBindingSource.DataSource = _orderService.GetAllOrders();
          break;
      }
      orderBindingSource.ResetBindings(false);
      itemsBindingSource.ResetBindings(false);
    }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
