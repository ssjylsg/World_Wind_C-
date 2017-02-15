using System.Collections.Specialized;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System;
using WorldWind.Net;
using WorldWind;
using WorldWind.Renderable;
using WorldWind.VisualControl;
using Utility;
using CarbonTools.Core.Base;
using CarbonTools.Core.OGCCapabilities;

namespace WorldWind
{
    /// <summary>
    /// WMS Browser dialog.
    /// </summary>
    public class WMSBrowserNG : System.Windows.Forms.Form
    {
        string wms_skeleton_path = Path.Combine(
            Path.Combine(MainApplication.Settings.ConfigPath, "Earth"),
            Path.Combine("Tools", "wmsskeleton.xml"));

        private WorldWindow worldWindow;

        private System.Drawing.Point mouseLocationProgressBarAnimation = new Point(0, 0);

        private System.Timers.Timer animationTimer = new System.Timers.Timer();
        private System.Collections.ArrayList animationFrames = new ArrayList();
        private System.Collections.Queue downloadQueue = new Queue();
        private System.Windows.Forms.ContextMenu contextMenuLegendUrl;
        private ComboBox wmsGetCapstextbox;
        private Label label4;
        private Button wmsbutton;
        private ComboBox comboBox2;
        private Label label5;
        private GroupBox xmlsaveGroupBox;
        private Label label6;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Label label7;
        private Label label3;
        private TextBox textBox1;
        private Button savewmsbutton;
        private Label label2;
        private GroupBox groupBox1;
        private CarbonTools.Controls.PictureBoxOGC pictureBoxOGC1;
        private Panel panelLower;
        private Panel panelContents;
        private Label ConfLabel;
		private System.Windows.Forms.ProgressBar pictureBoxProgressBar;
		private System.Windows.Forms.ProgressBar treeViewProgressBar;
		private Label label9;
		private Label label8;
        private CarbonTools.Controls.TreeViewOGCCapabilities treeOgcCaps;


        public WMSBrowserNG(WorldWindow ww)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.worldWindow = ww;
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenuLegendUrl = new System.Windows.Forms.ContextMenu();
            this.treeOgcCaps = new CarbonTools.Controls.TreeViewOGCCapabilities();
            this.wmsGetCapstextbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wmsbutton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xmlsaveGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.savewmsbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxOGC1 = new CarbonTools.Controls.PictureBoxOGC();
            this.pictureBoxProgressBar = new System.Windows.Forms.ProgressBar();
            this.panelLower = new System.Windows.Forms.Panel();
            this.panelContents = new System.Windows.Forms.Panel();
            this.treeViewProgressBar = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfLabel = new System.Windows.Forms.Label();
            this.xmlsaveGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOGC1)).BeginInit();
            this.panelLower.SuspendLayout();
            this.panelContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeOgcCaps
            // 
            this.treeOgcCaps.Credentials = null;
            this.treeOgcCaps.Location = new System.Drawing.Point(4, 115);
            this.treeOgcCaps.Name = "treeOgcCaps";
            this.treeOgcCaps.Proxy = null;
            this.treeOgcCaps.Size = new System.Drawing.Size(610, 155);
            this.treeOgcCaps.TabIndex = 5;
            this.treeOgcCaps.URL = "";
            this.treeOgcCaps.OperationDone += new System.EventHandler(this.treeOgcCaps_OperationDone);
            this.treeOgcCaps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeOgcCaps_AfterSelect);
            // 
            // wmsGetCapstextbox
            // 
            this.wmsGetCapstextbox.DropDownWidth = 480;
            this.wmsGetCapstextbox.Items.AddRange(new object[] {
            "http://www.ga.gov.au/bin/getmap.pl?request=capabilities",
            "http://www.geosignal.org/cgi-bin/wmsmap?",
            "http://wms.globexplorer.com/gexservlets/wms?"});
            this.wmsGetCapstextbox.Location = new System.Drawing.Point(4, 67);
            this.wmsGetCapstextbox.Name = "wmsGetCapstextbox";
            this.wmsGetCapstextbox.Size = new System.Drawing.Size(488, 20);
            this.wmsGetCapstextbox.TabIndex = 20;
            this.wmsGetCapstextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter WMS url:";
            // 
            // wmsbutton
            // 
            this.wmsbutton.Location = new System.Drawing.Point(499, 67);
            this.wmsbutton.Name = "wmsbutton";
            this.wmsbutton.Size = new System.Drawing.Size(109, 22);
            this.wmsbutton.TabIndex = 1;
            this.wmsbutton.Text = "Get WMS Tree";
            this.wmsbutton.UseVisualStyleBackColor = true;
            this.wmsbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(235, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(143, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image Format";
            this.label5.Visible = false;
            // 
            // xmlsaveGroupBox
            // 
            this.xmlsaveGroupBox.Controls.Add(this.label6);
            this.xmlsaveGroupBox.Controls.Add(this.textBox3);
            this.xmlsaveGroupBox.Controls.Add(this.checkBox1);
            this.xmlsaveGroupBox.Controls.Add(this.label7);
            this.xmlsaveGroupBox.Controls.Add(this.label3);
            this.xmlsaveGroupBox.Controls.Add(this.textBox1);
            this.xmlsaveGroupBox.Controls.Add(this.savewmsbutton);
            this.xmlsaveGroupBox.Controls.Add(this.label2);
            this.xmlsaveGroupBox.Enabled = false;
            this.xmlsaveGroupBox.Location = new System.Drawing.Point(14, 18);
            this.xmlsaveGroupBox.Name = "xmlsaveGroupBox";
            this.xmlsaveGroupBox.Size = new System.Drawing.Size(322, 168);
            this.xmlsaveGroupBox.TabIndex = 14;
            this.xmlsaveGroupBox.TabStop = false;
            this.xmlsaveGroupBox.Text = "Create layer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Specify layer title:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(134, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "WMS Layer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(73, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 16);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Use default layer title from server";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Warning: overwrites existing files";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "XML filename:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "wms";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // savewmsbutton
            // 
            this.savewmsbutton.Location = new System.Drawing.Point(98, 115);
            this.savewmsbutton.Name = "savewmsbutton";
            this.savewmsbutton.Size = new System.Drawing.Size(131, 29);
            this.savewmsbutton.TabIndex = 5;
            this.savewmsbutton.Text = "Save as XML";
            this.savewmsbutton.UseVisualStyleBackColor = true;
            this.savewmsbutton.Click += new System.EventHandler(this.savewmsbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = ".xml";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxOGC1);
            this.groupBox1.Controls.Add(this.pictureBoxProgressBar);
            this.groupBox1.Location = new System.Drawing.Point(354, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 198);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pictureBoxOGC1
            // 
            this.pictureBoxOGC1.BackColor = System.Drawing.Color.White;
            this.pictureBoxOGC1.Credentials = null;
            this.pictureBoxOGC1.ImageFormat = "";
            this.pictureBoxOGC1.LayerName = "";
            this.pictureBoxOGC1.LayerNamespace = "";
            this.pictureBoxOGC1.LayerStyle = "";
            this.pictureBoxOGC1.Location = new System.Drawing.Point(4, 20);
            this.pictureBoxOGC1.MapToolRectColor = System.Drawing.Color.Red;
            this.pictureBoxOGC1.Name = "pictureBoxOGC1";
            this.pictureBoxOGC1.Proxy = null;
            this.pictureBoxOGC1.Size = new System.Drawing.Size(249, 160);
            this.pictureBoxOGC1.StyleBrushColor = System.Drawing.Color.White;
            this.pictureBoxOGC1.StylePenColor = System.Drawing.Color.Black;
            this.pictureBoxOGC1.TabIndex = 15;
            this.pictureBoxOGC1.TabStop = false;
            this.pictureBoxOGC1.URL = "";
            this.pictureBoxOGC1.ZoomEffectFrames = 0;
            // 
            // pictureBoxProgressBar
            // 
            this.pictureBoxProgressBar.Location = new System.Drawing.Point(4, 183);
            this.pictureBoxProgressBar.Name = "pictureBoxProgressBar";
            this.pictureBoxProgressBar.Size = new System.Drawing.Size(249, 11);
            this.pictureBoxProgressBar.TabIndex = 16;
            // 
            // panelLower
            // 
            this.panelLower.Controls.Add(this.groupBox1);
            this.panelLower.Controls.Add(this.xmlsaveGroupBox);
            this.panelLower.Controls.Add(this.label5);
            this.panelLower.Controls.Add(this.comboBox2);
            this.panelLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLower.Location = new System.Drawing.Point(0, 257);
            this.panelLower.Name = "panelLower";
            this.panelLower.Size = new System.Drawing.Size(589, 225);
            this.panelLower.TabIndex = 0;
            this.panelLower.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLower_Paint);
            // 
            // panelContents
            // 
            this.panelContents.Controls.Add(this.treeViewProgressBar);
            this.panelContents.Controls.Add(this.treeOgcCaps);
            this.panelContents.Controls.Add(this.label9);
            this.panelContents.Controls.Add(this.label8);
            this.panelContents.Controls.Add(this.wmsbutton);
            this.panelContents.Controls.Add(this.ConfLabel);
            this.panelContents.Controls.Add(this.label4);
            this.panelContents.Controls.Add(this.wmsGetCapstextbox);
            this.panelContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContents.Location = new System.Drawing.Point(0, 0);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(589, 257);
            this.panelContents.TabIndex = 4;
            // 
            // treeViewProgressBar
            // 
            this.treeViewProgressBar.Location = new System.Drawing.Point(359, 98);
            this.treeViewProgressBar.Name = "treeViewProgressBar";
            this.treeViewProgressBar.Size = new System.Drawing.Size(249, 11);
            this.treeViewProgressBar.TabIndex = 17;
            this.treeViewProgressBar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(503, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "?Fill in options and click \"Save as XML\" to add the all of the layers to World Wi" +
    "nd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(581, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "?Enter a WMS url in the url bar below and click \"Get WMS Tree\" to see the content" +
    "s of the server";
            // 
            // ConfLabel
            // 
            this.ConfLabel.AutoSize = true;
            this.ConfLabel.Location = new System.Drawing.Point(4, 98);
            this.ConfLabel.Name = "ConfLabel";
            this.ConfLabel.Size = new System.Drawing.Size(101, 12);
            this.ConfLabel.TabIndex = 4;
            this.ConfLabel.Text = "Available Layers";
            // 
            // WMSBrowserNG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(589, 482);
            this.Controls.Add(this.panelContents);
            this.Controls.Add(this.panelLower);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(605, 520);
            this.Name = "WMSBrowserNG";
            this.Text = "WMS Importer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.xmlsaveGroupBox.ResumeLayout(false);
            this.xmlsaveGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOGC1)).EndInit();
            this.panelLower.ResumeLayout(false);
            this.panelLower.PerformLayout();
            this.panelContents.ResumeLayout(false);
            this.panelContents.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TODO:Use regex to check getcapabilties URL
            //if (!wmsGetCapstextbox.Text.StartsWith("http://") && !wmsGetCapstextbox.Contains("(G|g)et(C|c)apabilities"))
                //Console.WriteLine("WMS GETCAPS URL VALIDATED");
                //MessageBox.Show("Invalid GetCaps URL");
        }

        private void button1_Click(object sender, EventArgs e)
        {

			treeOgcCaps.Nodes.Clear();
            treeOgcCaps.URL = wmsGetCapstextbox.Text;

			treeViewProgressBar.Visible = true;
			treeOgcCaps.GetCapabilities();

			System.Windows.Forms.Timer treeViewTimer = new System.Windows.Forms.Timer();
			treeViewTimer.Enabled = true;
			treeViewTimer.Interval = 50;
			treeViewTimer.Tick += new EventHandler(treeViewTimer_Tick);


        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void savewmsbutton_Click(object sender, EventArgs e)
        {
            
			string wmslayerset = "<LayerSet Name=\"" + textBox3.Text + "\" ShowOnlyOneLayer=\"false\" ShowAtStartup=\"true\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"LayerSet.xsd\">\n";


			wmslayerset += ParseNodeChildren(treeOgcCaps.Nodes[0]);

			wmslayerset += "</LayerSet>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(wmslayerset);
            string xmlFileName = textBox1.Text + ".xml";

			
            string wmsSave = Path.Combine(
            Path.Combine(MainApplication.Settings.ConfigPath, worldWindow.CurrentWorld.ToString()),
            xmlFileName);
			try
			{
				doc.Save(wmsSave);
			}
			catch (System.Xml.XmlException ex)
			{
				MessageBox.Show("Couldn't write \"" + wmsSave + "\":\n\n" + ex.Message);
			}

            RenderableObjectList layers = ConfigurationLoader.getRenderableFromLayerFile(wmsSave, worldWindow.CurrentWorld, worldWindow.Cache);
            worldWindow.CurrentWorld.RenderableObjects.Add(layers);

        }

        private string ConvertLayerToWMS(LayerItem layer)
        {

			//TODO: Add layer abstracts from wms as <Description> in xml
			//TODO: Add legends as screenoverlays where applicable

            string skeleton;
            string FILE_NAME = this.wms_skeleton_path;
            string mapfilepath;

            skeleton = ReadSkeleton(FILE_NAME);
            skeleton = skeleton.Replace(@"$NAME", ConvertToXMLEntities(layer.Title));
            skeleton = skeleton.Replace(@"$NBB", layer.LLBoundingBox.MaxY.ToString(CultureInfo.InvariantCulture));
			skeleton = skeleton.Replace(@"$SBB", layer.LLBoundingBox.MinY.ToString(CultureInfo.InvariantCulture));
			skeleton = skeleton.Replace(@"$EBB", layer.LLBoundingBox.MaxX.ToString(CultureInfo.InvariantCulture));
			skeleton = skeleton.Replace(@"$WBB", layer.LLBoundingBox.MinX.ToString(CultureInfo.InvariantCulture));
            //replace request getcapabilities with getmap
            //string wmsGetMap = wmsGetCapstextbox.Text.ToLowerInvariant().Replace("request=getcapabilities", "request=getmap");
            string wmsGetMap = Regex.Replace(wmsGetCapstextbox.Text.ToLowerInvariant(), "\\?.*$", "");

            //check for wms that requires path to .map file in url
            if (wmsGetCapstextbox.Text.ToLowerInvariant().Contains("map="))
            {
                mapfilepath = Regex.Match(wmsGetCapstextbox.Text, "map=.*\\.map").Value;
                skeleton = skeleton.Replace(@"$LAYERNAME", layer.Name + @"&amp;TRANSPARENT=TRUE&amp;BGCOLOR=0xFF00FF&amp;" + mapfilepath);
            }
            else
            {
                skeleton = skeleton.Replace(@"$LAYERNAME", layer.Name + @"&amp;TRANSPARENT=TRUE&amp;BGCOLOR=0xFF00FF");
            }

            skeleton = skeleton.Replace(@"$SERVER", ConvertToXMLEntities(wmsGetMap));

            return skeleton;


        }

        private static string ReadSkeleton(string FILE_NAME)
        {
            string skeleton = null;
            if (!File.Exists(FILE_NAME))
            {
                MessageBox.Show(FILE_NAME + " does not exist");
                return skeleton;
            }

            String input;
            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                while ((input = sr.ReadLine()) != null)
                {
                    skeleton += input + new string((Char)13, 1);
                }
                sr.Close();
            }
            return skeleton;
        }

        private string ConvertToXMLEntities(string text)
        {
            text = Regex.Replace(text, "&", "&amp;");
            text = Regex.Replace(text, "<", "&lt;");
            text = Regex.Replace(text, ">", "&gt;");
            text = Regex.Replace(text, "\"", "&quot;");
            //text = Regex.Replace( text, " ", "&nbsp;" );
            //text = Regex.Replace( text, "$", "<br />" );
            return text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
			treeOgcCaps.Nodes.Clear();
			wmsGetCapstextbox.Text = "";
			textBox3.Text = "";

            e.Cancel = true;
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void treeOgcCaps_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Check if selected node exists 
            if (treeOgcCaps.SelectedNode == null) return;
            // Get selected layer data 
            LayerItem layer = treeOgcCaps.SelectedNode.Tag as LayerItem;
            if (layer == null) return;

            // Set map view paramerters 

            pictureBoxOGC1.URL = treeOgcCaps.URL;
            pictureBoxOGC1.ServiceType = OGCServiceTypes.WMS;
            pictureBoxOGC1.LayerName = layer.Name;  // Set layer name 
			pictureBoxProgressBar.Value = 0;
            // Update image 
            pictureBoxOGC1.GetImage();

			System.Windows.Forms.Timer pictureBoxTimer = new System.Windows.Forms.Timer();
			pictureBoxTimer.Enabled = true;
			pictureBoxTimer.Interval = 50;
			pictureBoxTimer.Tick += new EventHandler(pictureBoxTimer_Tick);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label6.Enabled = true;
                textBox3.Enabled = true;
            }
            else if (checkBox1.Checked == true)
            {
				LayerItem li = treeOgcCaps.Nodes[0].Tag as LayerItem;
				textBox3.Text = li.Title;

                label6.Enabled = false;
                textBox3.Enabled = false;
            }

        }

		private void treeOgcCaps_OperationDone(object sender, EventArgs e)
		{
			TreeNode tn = treeOgcCaps.Nodes[0];
			LayerItem li = tn.Tag as LayerItem;

			textBox3.Text = li.Title;
			xmlsaveGroupBox.Enabled = true;

			treeViewProgressBar.Visible = false;
		}

		private string ParseNodeChildren(TreeNode node)
		{
			string returned = null;

			if (node.Nodes.Count != 0)
			{
				
				LayerItem li = node.Tag as LayerItem;

				if (node.Level != 0)
				{
					returned += "<ChildLayerSet Name=\"" + li.Title + "\" ShowOnlyOneLayer=\"false\" ShowAtStartup=\"true\">\n";
				}

				foreach (TreeNode subNode in node.Nodes)
				{
					returned += ParseNodeChildren(subNode);
				}

				if (node.Level != 0)
				{
					returned += "</ChildLayerSet>\n";
				}

				return returned;
			}
			else
			{

				LayerItem li = node.Tag as LayerItem;
				returned += ConvertLayerToWMS(li);
				return returned;
			}

		}

		private void pictureBoxTimer_Tick(object sender, EventArgs e)
		{
			pictureBoxProgressBar.Value = pictureBoxOGC1.GetProgress(100);
		}

		private void treeViewTimer_Tick(object sender, EventArgs e)
		{
			treeViewProgressBar.Value = treeOgcCaps.GetProgress(100);
		}

    }
}
