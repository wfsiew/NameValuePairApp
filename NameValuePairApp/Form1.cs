using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using NameValuePairApp.Models;
using NameValuePairApp.Helpers;

namespace NameValuePairApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The BindingList used for the listbox datasource
        /// </summary>
        private BindingList<NameValue> bindingList;

        /// <summary>
        /// Name sort direction
        /// </summary>
        private SortDir NameSortDir = SortDir.DEFAULT;

        /// <summary>
        /// Value sort direction
        /// </summary>
        private SortDir ValueSortDir = SortDir.DEFAULT;

        /// <summary>
        /// Current sort field, either Name or Value
        /// </summary>
        private SortField CurrentSort = SortField.DEFAULT;

        public Form1()
        {
            InitializeComponent();
            bindingList = new BindingList<NameValue>();
            BindListBox();
        }

        /// <summary>
        /// This event handler adds the name-value entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NameValue o = ValidateEntry();

                bindingList.Add(o);
                SortList();
                txtVal.Text = "";
                btnDelete.Enabled = true;
            }

            catch (UIException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// This event handler sorts the bindingList by Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortName_Click(object sender, EventArgs e)
        {
            CurrentSort = SortField.NAME;
            NameSortDir = SortDir.ASC;
            bindingList = new BindingList<NameValue>(bindingList.OrderBy(k => k.Name).ToList()); 

            BindListBox();
        }

        /// <summary>
        /// This event handler sorts the bindingList by Value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortValue_Click(object sender, EventArgs e)
        {
            CurrentSort = SortField.VALUE;
            ValueSortDir = SortDir.ASC;
            bindingList = new BindingList<NameValue>(bindingList.OrderBy(k => k.Value).ToList());

            BindListBox();
        }

        /// <summary>
        /// This event handler deletes the selected name-value pairs from the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedIndexCollection selectedIndexes = listBox1.SelectedIndices;
                List<int> li = new List<int>();

                if (listBox1.SelectedIndex != -1)
                {
                    for (int i = 0; i < selectedIndexes.Count; i++)
                        li.Add(selectedIndexes[i]);
                }

                for (int i = 0; i < li.Count; i++)
                {
                    bindingList.RemoveAt(li[i] - i);
                }

                if (bindingList.Count < 1)
                    btnDelete.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// This event handler saves the current name-value pair to a config.xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            XmlWriter writer = null;

            try
            {
                string path = "data/config.xml";
                string filepath = string.Format("../../{0}", path);
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Read);

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;

                writer = XmlWriter.Create(fs, xmlWriterSettings);

                writer.WriteStartDocument();

                writer.WriteStartElement("pairs");

                foreach (NameValue o in bindingList)
                {
                    writer.WriteStartElement("pair");
                    writer.WriteAttributeString("name", o.Name);
                    writer.WriteAttributeString("value", o.Value);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show(string.Format("File has been saved to {0}", path), "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        /// <summary>
        /// This event handler terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            Application.Exit();
        }

        /// <summary>
        /// This event handler checks for ENTER key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAdd_Click(sender, e);
        }

        /// <summary>
        /// This method binds the listbox
        /// </summary>
        private void BindListBox()
        {
            listBox1.DataSource = bindingList;
        }

        /// <summary>
        /// This method validates the name-value entry.
        /// It throws UIException is the entry is invalid
        /// </summary>
        /// <returns>NameValue object if the entry is valid</returns>
        private NameValue ValidateEntry()
        {
            string val = txtVal.Text;
            NameValue o = null;

            if (string.IsNullOrEmpty(val))
                throw new UIException(string.Format("{0} is required", label1.Text));

            if (!IsValidEntry(val, out o))
                throw new UIException("Invalid key-value pair");

            return o;
        }

        /// <summary>
        /// This method validates the name-value entry
        /// </summary>
        /// <param name="val">The name-value entry</param>
        /// <param name="o">The NameValue object that should be return if the name-value entry is valid</param>
        /// <returns>True if name-value entry is valid, False otherwise</returns>
        private bool IsValidEntry(string val, out NameValue o)
        {
            bool b = false;
            o = null;

            if (string.IsNullOrEmpty(val))
                return b;

            if (val.IndexOf('=') > 0)
            {
                string[] arr = val.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (arr != null && arr.Length == 2)
                {
                    if (!string.IsNullOrEmpty(arr[0]) && arr[0].Trim().IsAlphaNumeric() && 
                        !string.IsNullOrEmpty(arr[1]) && arr[1].Trim().IsAlphaNumeric())
                    {
                        o = new NameValue(arr[0].Trim(), arr[1].Trim());
                        b = true;
                    }
                }
            }

            return b;
        }

        /// <summary>
        /// This method sort the bindingList according to the current sort setting
        /// </summary>
        private void SortList()
        {
            if (CurrentSort == SortField.NAME)
            {
                bindingList = new BindingList<NameValue>(bindingList.OrderBy(k => k.Name).ToList());
                BindListBox();
            }

            else if (CurrentSort == SortField.VALUE)
            {
                bindingList = new BindingList<NameValue>(bindingList.OrderBy(k => k.Value).ToList());
                BindListBox();
            }
        }
    }
}
