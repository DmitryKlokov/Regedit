using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace reg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView_reg.Nodes.Add(Registry.ClassesRoot.Name, Registry.ClassesRoot.Name);
            treeView_reg.Nodes[Registry.ClassesRoot.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.ClassesRoot.Name].Tag = Registry.ClassesRoot;

            treeView_reg.Nodes.Add(Registry.CurrentUser.Name, Registry.CurrentUser.Name);
            treeView_reg.Nodes[Registry.CurrentUser.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.CurrentUser.Name].Tag = Registry.CurrentUser;

            treeView_reg.Nodes.Add(Registry.LocalMachine.Name, Registry.LocalMachine.Name);
            treeView_reg.Nodes[Registry.LocalMachine.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.LocalMachine.Name].Tag = Registry.LocalMachine;

            treeView_reg.Nodes.Add(Registry.Users.Name, Registry.Users.Name);
            treeView_reg.Nodes[Registry.Users.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.Users.Name].Tag = Registry.Users;

            treeView_reg.Nodes.Add(Registry.CurrentConfig.Name, Registry.CurrentConfig.Name);
            treeView_reg.Nodes[Registry.CurrentConfig.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.CurrentConfig.Name].Tag = Registry.CurrentConfig;

            treeView_reg.Nodes.Add(Registry.PerformanceData.Name, Registry.PerformanceData.Name);
            treeView_reg.Nodes[Registry.PerformanceData.Name].Nodes.Add(string.Empty);
            treeView_reg.Nodes[Registry.PerformanceData.Name].Tag = Registry.PerformanceData;
        }

        private void GetValuesAndData(RegistryKey registryKey)
        {
            try
            {
                dataGridView_data.Rows.Clear();
                string[] values = registryKey.GetValueNames();
                if (registryKey.ValueCount != 0)
                {
                    foreach (string value in values)
                    {
                        object data = registryKey.GetValue(value);
                        if (data != null && value != string.Empty)
                        {
                            dataGridView_data.Rows.Add(value, data.ToString());
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
        private void treeView_reg_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == string.Empty)
            {
                e.Node.Nodes.Clear();
                var key = e.Node.Tag as RegistryKey;
                if (key != null)
                {
                    foreach (string name in key.GetSubKeyNames())
                    {
                        e.Node.Nodes.Add(name, name);
                        if (name != "SECURITY" && name != "SAM")
                        {
                            RegistryKey subkey = key.OpenSubKey(name);
                            e.Node.Nodes[name].Tag = subkey;
                            if (subkey != null && subkey.SubKeyCount > 0)
                                e.Node.Nodes[name].Nodes.Add(string.Empty);
                        }
                    }
                }
            }
        }
        private void treeView_reg_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView_reg.SelectedNode = e.Node;
                contextMenuStrip1.Show(treeView_reg, e.Location);
            }

            var key = e.Node.Tag as RegistryKey;
            GetValuesAndData(key);

            treeView_reg.SelectedNode = e.Node;
        }

        

        private void разделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = treeView_reg.SelectedNode.FullPath;
            int i =path.IndexOf("\\", StringComparison.Ordinal);
            string reg = path.Substring(0, i);
            path = path.Substring(i +1 , path.Length - i - 1);//ds

            string value = Interaction.InputBox("Name folder");

            ChooseReg(reg, path + "\\"+value);

            treeView_reg.SelectedNode.Nodes.Add(value,value);
            treeView_reg.SelectedNode.Nodes[value].Tag = value;
        }


        public RegistryKey ChooseReg(string reg, string path)
        {
            switch (reg)
            {
                case "HKEY_CLASSES_ROOT":
                    {
                        return Registry.ClassesRoot.CreateSubKey(path);
                    }
                case "HKEY_CURRENT_USER":
                    {
                        return Registry.CurrentUser.CreateSubKey(path);
                    }
                case "HKEY_LOCAL_MACHINE":
                    {
                        return Registry.LocalMachine.CreateSubKey(path);
                    }
                case "HKEY_USERS":
                    {
                        return  Registry.Users.CreateSubKey(path);
                    }
                default: 
                    {
                        return Registry.CurrentConfig.CreateSubKey(path);
                    }//"HKEY_CURRENT_CONFIG":
            }
        }


        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = treeView_reg.SelectedNode.Parent.FullPath;
            int i = path.IndexOf("\\", StringComparison.Ordinal);
            string reg = path.Substring(0, i);
            path = path.Substring(i + 1, path.Length - i - 1);//ds

            ChooseReg(reg,path).DeleteSubKeyTree(treeView_reg.SelectedNode.Name);

            treeView_reg.SelectedNode.Remove();

        }

        private void строковыйПараметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = treeView_reg.SelectedNode.FullPath;
            int i = path.IndexOf("\\", StringComparison.Ordinal);
            string reg = path.Substring(0, i);
            path = path.Substring(i + 1, path.Length - i - 1);//ds

            var key = ChooseReg(reg,path);
            string name = Interaction.InputBox("Name");
            string value = Interaction.InputBox("Value");
            key.SetValue(name, value);
            GetValuesAndData(key);
        }
        
        private void dataGridView_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

           if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                string path = treeView_reg.SelectedNode.FullPath;
                int i = path.IndexOf("\\", StringComparison.Ordinal);
                string reg = path.Substring(0, i);
                path = path.Substring(i + 1, path.Length - i - 1); //ds

                var key = ChooseReg(reg, path);

                if (e.ColumnIndex == 3)
                {
                    key.DeleteValue(key.GetValueNames()[e.RowIndex]);
                }
                if (e.ColumnIndex == 2)
                {

                    string value = Interaction.InputBox("Value");
                    key.SetValue(key.GetValueNames()[e.RowIndex], value);
                }


                GetValuesAndData(key);
            }

        }
    }
}
