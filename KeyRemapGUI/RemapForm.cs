using System;
using System.Windows.Forms;
using KeyRemap;

namespace KeyboardRemapping
{
    public partial class RemapForm : Form
    {
        public RemapForm()
        {
            InitializeComponent();
        }

        private void RemapForm_Load(object sender, EventArgs e)
        {
            foreach (var key in ScancodeMapBuilder.GetKeyNameToScancode().Keys)
            {
                listBoxFromKey.Items.Add(key);
                listBoxToKey.Items.Add(key);
            }
        }

        private void btnWriteToRegistry_Click(object sender, EventArgs e)
        {
            if (listBoxFromKey.SelectedItem == null || listBoxToKey.SelectedItem == null)
            {
                MessageBox.Show("Please select both keys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string originalKey = listBoxFromKey.SelectedItem.ToString();
            string newKey = listBoxToKey.SelectedItem.ToString();

            int originalScancode = ScancodeMapBuilder.GetScancodeFromKeyName(originalKey);
            int newScancode = ScancodeMapBuilder.GetScancodeFromKeyName(newKey);

            if (originalScancode == -1 || newScancode == -1)
            {
                MessageBox.Show("Invalid key selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] scancodeMap = ScancodeMapBuilder.BuildScancodeMap(originalScancode, newScancode);
            RegistryManager registryManager = new RegistryManager();
            registryManager.RemapKeyInRegistry(scancodeMap);

            MessageBox.Show("Key remapping successful. Please restart your computer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxFromKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFromKey.SelectedItem != null)
            {
                labelFromKey.Text = $"Map this key (From key): {listBoxFromKey.SelectedItem}";
            }
        }

        private void listBoxToKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxToKey.SelectedItem != null)
            {
                labelToKey.Text = $"To this key (To key): {listBoxToKey.SelectedItem}";
            }
        }

        private void labelFromKey_Click(object sender, EventArgs e)
        {

        }

        private void labelToKey_Click(object sender, EventArgs e)
        {

        }
    }
}