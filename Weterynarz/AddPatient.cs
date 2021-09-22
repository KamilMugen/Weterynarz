using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weterynarz
{
    public partial class AddPatient : Form
    {

        private Model.Patient patient;
        public AddPatient()
        {
            InitializeComponent();
            patient = new Model.Patient();
            comboBoxSpecies.DataSource = Enum.GetValues(typeof( Model.Species));
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Species readedSpecies;
            Enum.TryParse<Model.Species>(comboBoxSpecies.SelectedValue.ToString(), out readedSpecies);
            patient.species = readedSpecies;
            string readedName;
            readedName = textBoxName.Text;
            if (readedName.Length == 0)
                MessageBox.Show("Pole \"Imię\" nie może być puste", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            readedName = textBoxName.Text;
            patient.Age = (uint)numericUpDownAge.Value;
        }
    }
}
