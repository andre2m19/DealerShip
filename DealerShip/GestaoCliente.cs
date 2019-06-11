using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerShip
{
    public partial class GestaoCliente : Form
    {
        private DealerModelContainer DealerShip;    
        public GestaoCliente()
        {
            InitializeComponent();

            DealerShip = new DealerModelContainer();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                DealerShip.Dispose();
                DealerShip = new DealerModelContainer();
                (from pessoa in DealerShip.ClienteSet
                 where pessoa.Nome.ToUpper().Contains(textBoxFilter.Text.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).ToList();
                clienteBindingSource.DataSource = DealerShip.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;
                DealerShip.Dispose();
                DealerShip = new DealerModelContainer();
                (from pessoa in DealerShip.ClienteSet
                 orderby pessoa.Nome
                 select pessoa).Load();
                clienteBindingSource.DataSource = DealerShip.ClienteSet.Local.ToBindingList();
            }

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DealerShip.SaveChanges();
        }
    }
}
