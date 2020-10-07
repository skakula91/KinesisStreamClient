using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace KinesisClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbRegion.DataSource = Enum.GetValues(typeof(AwsRegion));
            cmbEventNotification.DataSource = Utility.GetAllEntities().Select(x => $"{x.EventNotificationType}-{x.EventNotificationName}").ToList();
            rchAdditionalFilter.Text = Utility.GetAllEntities().First().Payload;
            cmbTimeperiod.DataSource = Enum.GetValues(typeof(TimePeriod));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Loading loadingForm = new Loading();
            loadingForm.TopMost = true;
            loadingForm.StartPosition = FormStartPosition.CenterScreen;
            loadingForm.Show();
            loadingForm.Refresh();
            Application.DoEvents();

            var region = Utility.GetRegion(cbRegion.SelectedItem.ToString());
            var streamName = tbStreamName.Text.ToString();
            var timePeriod = Utility.GetStreamFromPeriod(cmbTimeperiod.SelectedItem.ToString());
            var awsAccessKey = tbAccessKeyId.Text.ToString();
            var awsSecretKey = tbAccessKeySecret.Text.ToString();
            var action = new Actions(region, streamName, timePeriod, awsAccessKey, awsSecretKey);

            var canParseSubscriberId = int.TryParse(tbSubscriberId.Text, out int id);
            var canParseBusinessUnitId = int.TryParse(tbBusinessUnit.Text, out int buid);
            var eventNotificationType = int.Parse(cmbEventNotification.SelectedItem.ToString().Split('-')[0]);
            var additionalFilter = (!string.IsNullOrWhiteSpace(rchAdditionalFilter.Text)) ? rchAdditionalFilter.Text : "{}";

            var filter = new Filter()
            {
                SubscriberId = canParseSubscriberId ? id : (int?) null,
                BusinessUnitId = canParseBusinessUnitId ? buid : 0,
                EventNotificationType = eventNotificationType
            };

            var response = action.GetRecords(filter, additionalFilter);
            HandleSearchResponse(response);

            loadingForm.Close();
            this.Show();
        }

        protected void HandleSearchResponse(List<JObject> kinesisResponse)
        {
            try
            {
                rchJson.Text = Utility.PrettyJson(kinesisResponse);
                Deserialize();
            }
            catch (Exception ex)
            {

                //Show message that something failed
            }
        }

        private void cmbEventNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchAdditionalFilter.Text = Utility.EventNotificationEntites?.FirstOrDefault(x => $"{x.EventNotificationType}-{x.EventNotificationName}" == cmbEventNotification.SelectedItem.ToString())?.Payload;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Utility.CopyClipBoard(rchJson.Text));
                MessageBox.Show("Successfully copied to clipboard!");
            }
            catch (Exception)
            {

                //Show message that something failed
            }
        }
        private void Deserialize()
        {
            jsonTreeView.Nodes.Clear();

            try
            {
                JObject obj = JObject.Parse(rchJson.Text);

                TreeNode parent = Json2Tree(obj);
                parent.Text = "JSON Tree View";
                jsonTreeView.Nodes.Add(parent);

                jsonTreeView.Nodes[0].EnsureVisible();
            }
            catch (ArgumentException argE)
            {
                MessageBox.Show("JSON data is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private TreeNode Json2Tree(JObject obj)
        {
            //create the parent node
            TreeNode parent = new TreeNode();
            //loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                //change the display Content of the parent
                parent.Text = token.Key.ToString();
                //create the child node
                TreeNode child = new TreeNode();
                child.Text = token.Key.ToString();
                //check if the value is of type obj recall the method
                if (token.Value.Type.ToString() == "Object")
                {
                    // child.Text = token.Key.ToString();
                    //create a new JObject using the the Token.value
                    JObject o = (JObject)token.Value;
                    //recall the method
                    child = Json2Tree(o);
                    child.Text = token.Key.ToString();
                    //add the child to the parentNode
                    parent.Nodes.Add(child);
                }
                //if type is of array
                else if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    //  child.Text = token.Key.ToString();
                    //loop though the array
                    foreach (var itm in token.Value)
                    {
                        //check if value is an Array of objects
                        if (itm.Type.ToString() == "Object")
                        {
                            TreeNode objTN = new TreeNode();
                            //child.Text = token.Key.ToString();
                            //call back the method
                            ix++;

                            JObject o = (JObject)itm;
                            objTN = Json2Tree(o);
                            objTN.Text = token.Key.ToString() + "[" + ix + "]";
                            child.Nodes.Add(objTN);
                            //parent.Nodes.Add(child);
                        }
                        //regular array string, int, etc
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            TreeNode dataArray = new TreeNode();
                            foreach (var data in itm)
                            {
                                dataArray.Text = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Nodes.Add(data.ToString());
                            }
                            child.Nodes.Add(dataArray);
                        }

                        else
                        {
                            child.Nodes.Add(itm.ToString());
                        }
                    }
                    parent.Nodes.Add(child);
                }
                else
                {
                    //if token.Value is not nested
                    // child.Text = token.Key.ToString();
                    //change the value into N/A if value == null or an empty string 
                    if (token.Value.ToString() == "")
                        child.Nodes.Add("N/A");
                    else
                        child.Nodes.Add(token.Value.ToString());
                    parent.Nodes.Add(child);
                }
            }
            return parent;

        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            jsonTreeView.CollapseAll();
        }
    }
}
