using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceView
{
    public partial class SelectLoaderType : Form
    {
        private readonly IEnumerable<Type> loaderTypes;

        public Type SelectedType { get; private set; }

        public SelectLoaderType(IEnumerable<Type> loaderTypes)
        {
            InitializeComponent();

            this.loaderTypes = loaderTypes;

            SelectedType = null;
        }

        private void selectLoaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = loaderTypes.First(type => type.Name == selectLoaderComboBox.SelectedItem.ToString());
            agreeButton.Enabled = true;
        }

        private void SelectLoaderType_Load(object sender, EventArgs e)
        {
            
            selectLoaderComboBox.Items.AddRange(loaderTypes.Select(type => type.Name).ToArray());
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
          
            if (SelectedType == null)
                MessageBox.Show("Вы не выбрали тип погрузчика");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
