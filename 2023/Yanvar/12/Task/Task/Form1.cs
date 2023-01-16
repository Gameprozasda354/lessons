using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            switch (itemName.Text)
            {
                case "Button":
                    Button btn = new Button();
                    btn.Name = "Button" + count;
                    btn.Text = count.ToString();
                    
                    listOfItems.Items.Add("Button" + count);
                    elements.Controls.Add(btn);
                    itemName.Text = "";
                    count++;
                    break;
                case "CheckBox":
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "CheckBox" + count;
                    checkBox.Text = count.ToString();

                    listOfItems.Items.Add("CheckBox" + count);
                    elements.Controls.Add(checkBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "CheckedListBox":
                    CheckedListBox checkedListBox = new CheckedListBox();
                    checkedListBox.Name = "CheckedListBox" + count;
                    checkedListBox.Text = count.ToString();

                    listOfItems.Items.Add("CheckedListBox" + count);
                    elements.Controls.Add(checkedListBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "ComboBox":
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = "ComboBox" + count;
                    comboBox.Text = count.ToString();

                    listOfItems.Items.Add("ComboBox" + count);
                    elements.Controls.Add(comboBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "DateTimePicker":
                    DateTimePicker dateTimePicker = new DateTimePicker();
                    dateTimePicker.Name = "DateTimePicker" + count;
                    dateTimePicker.Text = count.ToString();

                    listOfItems.Items.Add("DateTimePicker" + count);
                    elements.Controls.Add(dateTimePicker);
                    itemName.Text = "";
                    count++;
                    break;
                case "DomainUpDown":
                    DomainUpDown domainUpDown = new DomainUpDown();
                    domainUpDown.Name = "DomainUpDown" + count;
                    domainUpDown.Text = count.ToString();

                    listOfItems.Items.Add("DomainUpDown" + count);
                    elements.Controls.Add(domainUpDown);
                    itemName.Text = "";
                    count++;
                    break;
                case "FlowLayoutPanel":
                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    flowLayoutPanel.Name = "FlowLayoutPanel" + count;
                    flowLayoutPanel.Text = count.ToString();

                    listOfItems.Items.Add("flowLayoutPanel" + count);
                    elements.Controls.Add(flowLayoutPanel);
                    itemName.Text = "";
                    count++;
                    break;
                case "GroupBox":
                    GroupBox groupBox = new GroupBox();
                    groupBox.Name = "GroupBox" + count;
                    groupBox.Text = count.ToString();

                    listOfItems.Items.Add("GroupBox" + count);
                    elements.Controls.Add(groupBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "HScrollBar":
                    HScrollBar hScrollBar = new HScrollBar();
                    hScrollBar.Name = "HScrollBar" + count;
                    hScrollBar.Text = count.ToString();

                    listOfItems.Items.Add("HScrollBar" + count);
                    elements.Controls.Add(hScrollBar);
                    itemName.Text = "";
                    count++;
                    break;
                case "Label":
                    Label label = new Label();
                    label.Name = "Label" + count;
                    label.Text = count.ToString();

                    listOfItems.Items.Add("Label" + count);
                    elements.Controls.Add(label);
                    itemName.Text = "";
                    count++;
                    break;
                case "LinkLabel":
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Name = "LinkLabel" + count;
                    linkLabel.Text = count.ToString();

                    listOfItems.Items.Add("LinkLabel" + count);
                    elements.Controls.Add(linkLabel);
                    itemName.Text = "";
                    count++;
                    break;
                case "ListBox":
                    ListBox listBox = new ListBox();
                    listBox.Name = "ListBox" + count;
                    listBox.Text = count.ToString();

                    listOfItems.Items.Add("ListBox" + count);
                    elements.Controls.Add(listBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "ListView":
                    ListView listView = new ListView();
                    listView.Name = "ListView" + count;
                    listView.Text = count.ToString();

                    listOfItems.Items.Add("ListView" + count);
                    elements.Controls.Add(listView);
                    itemName.Text = "";
                    count++;
                    break;
                case "MaskedTextBox":
                    MaskedTextBox maskedTextBox = new MaskedTextBox();
                    maskedTextBox.Name = "MaskedTextBox" + count;
                    maskedTextBox.Text = count.ToString();

                    listOfItems.Items.Add("MaskedTextBox" + count);
                    elements.Controls.Add(maskedTextBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "MenuStrip":
                    MenuStrip menuStrip = new MenuStrip();
                    menuStrip.Name = "MenuStrip" + count;
                    menuStrip.Text = count.ToString();

                    listOfItems.Items.Add("MenuStrip" + count);
                    elements.Controls.Add(menuStrip);
                    itemName.Text = "";
                    count++;
                    break;
                case "MonthCalendar":
                    MonthCalendar monthCalendar = new MonthCalendar();
                    monthCalendar.Name = "MonthCalendar" + count;
                    monthCalendar.Text = count.ToString();

                    listOfItems.Items.Add("MonthCalendar" + count);
                    elements.Controls.Add(monthCalendar);
                    itemName.Text = "";
                    count++;
                    break;
                case "NumericUpDown":
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Name = "NumericUpDown" + count;
                    numericUpDown.Text = count.ToString();

                    listOfItems.Items.Add("NumericUpDown" + count);
                    elements.Controls.Add(numericUpDown);
                    itemName.Text = "";
                    count++;
                    break;
                case "Panel":
                    Panel panel = new Panel();
                    panel.Name = "Panel" + count;
                    panel.Text = count.ToString();

                    listOfItems.Items.Add("Panel" + count);
                    elements.Controls.Add(panel);
                    itemName.Text = "";
                    count++;
                    break;
                case "PictureBox":
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = "PictureBox" + count;
                    pictureBox.Text = count.ToString();

                    listOfItems.Items.Add("PictureBox" + count);
                    elements.Controls.Add(pictureBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "PrintPreviewDialog":
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Name = "PrintPreviewDialog" + count;
                    printPreviewDialog.Text = count.ToString();

                    listOfItems.Items.Add("PrintPreviewDialog" + count);
                    elements.Controls.Add(printPreviewDialog);
                    itemName.Text = "";
                    count++;
                    break;
                case "ProgressBar":
                    ProgressBar progressBar = new ProgressBar();
                    progressBar.Name = "ProgressBar" + count;
                    progressBar.Text = count.ToString();

                    listOfItems.Items.Add("ProgressBar" + count);
                    elements.Controls.Add(progressBar);
                    itemName.Text = "";
                    count++;
                    break;
                case "PropertyGrid":
                    PropertyGrid propertyGrid = new PropertyGrid();
                    propertyGrid.Name = "PropertyGrid" + count;
                    propertyGrid.Text = count.ToString();

                    listOfItems.Items.Add("PropertyGrid" + count);
                    elements.Controls.Add(propertyGrid);
                    itemName.Text = "";
                    count++;
                    break;
                case "RadioButton":
                    RadioButton radioButton = new RadioButton();
                    radioButton.Name = "RadioButton" + count;
                    radioButton.Text = count.ToString();

                    listOfItems.Items.Add("RadioButton" + count);
                    elements.Controls.Add(radioButton);
                    itemName.Text = "";
                    count++;
                    break;
                case "RichTextBox":
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.Name = "RichTextBox" + count;
                    richTextBox.Text = count.ToString();

                    listOfItems.Items.Add("RichTextBox" + count);
                    elements.Controls.Add(richTextBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "SplitContainer":
                    SplitContainer splitContainer = new SplitContainer();
                    splitContainer.Name = "SplitContainer" + count;
                    splitContainer.Text = count.ToString();

                    listOfItems.Items.Add("SplitContainer" + count);
                    elements.Controls.Add(splitContainer);
                    itemName.Text = "";
                    count++;
                    break;
                case "Splitter":
                    Splitter splitter = new Splitter();
                    splitter.Name = "Splitter" + count;
                    splitter.Text = count.ToString();

                    listOfItems.Items.Add("Splitter" + count);
                    elements.Controls.Add(splitter);
                    itemName.Text = "";
                    count++;
                    break;
                case "TabControl":
                    TabControl tabControl = new TabControl();
                    tabControl.Name = "TabControl" + count;
                    tabControl.Text = count.ToString();

                    listOfItems.Items.Add("TabControl" + count);
                    elements.Controls.Add(tabControl);
                    itemName.Text = "";
                    count++;
                    break;
                case "TableLayoutPanel":
                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.Name = "TableLayoutPanel" + count;
                    tableLayoutPanel.Text = count.ToString();

                    listOfItems.Items.Add("TableLayoutPanel" + count);
                    elements.Controls.Add(tableLayoutPanel);
                    itemName.Text = "";
                    count++;
                    break;
                case "TextBox":
                    TextBox textBox = new TextBox();
                    textBox.Name = "TextBox" + count;
                    textBox.Text = count.ToString();

                    listOfItems.Items.Add("TextBox" + count);
                    elements.Controls.Add(textBox);
                    itemName.Text = "";
                    count++;
                    break;
                case "ToolStripContainer":
                    ToolStripContainer toolStripContainer = new ToolStripContainer();
                    toolStripContainer.Name = "ToolStripContainer" + count;
                    toolStripContainer.Text = count.ToString();

                    listOfItems.Items.Add("ToolStripContainer" + count);
                    elements.Controls.Add(toolStripContainer);
                    itemName.Text = "";
                    count++;
                    break;
                case "TrackBar":
                    TrackBar trackBar = new TrackBar();
                    trackBar.Name = "TrackBar" + count;
                    trackBar.Text = count.ToString();

                    listOfItems.Items.Add("TrackBar" + count);
                    elements.Controls.Add(trackBar);
                    itemName.Text = "";
                    count++;
                    break;
                case "TreeView":
                    TreeView treeView = new TreeView();
                    treeView.Name = "TreeView" + count;
                    treeView.Text = count.ToString();

                    listOfItems.Items.Add("TreeView" + count);
                    elements.Controls.Add(treeView);
                    itemName.Text = "";
                    count++;
                    break;
                case "VScrollBar":
                    VScrollBar vScrollBar = new VScrollBar();
                    vScrollBar.Name = "VScrollBar" + count;
                    vScrollBar.Text = count.ToString();

                    listOfItems.Items.Add("VScrollBar" + count);
                    elements.Controls.Add(vScrollBar);
                    itemName.Text = "";
                    count++;
                    break;
                case "WebBrowser":
                    WebBrowser webBrowser = new WebBrowser();
                    webBrowser.Name = "WebBrowser" + count;
                    webBrowser.Text = count.ToString();

                    listOfItems.Items.Add("WebBrowser" + count);
                    elements.Controls.Add(webBrowser);
                    itemName.Text = "";
                    count++;
                    break;

                default:
                    break;
            }
        }

        private void DeleteElement(object sender, EventArgs e)
        {
            foreach (Control item in elements.Controls)
            {
                if(item.Name == listOfItems.SelectedItem.ToString())
                {
                    listOfItems.Items.RemoveAt(listOfItems.SelectedIndex);
                    elements.Controls.Remove(item);
                }
            }
        }
    }
}
