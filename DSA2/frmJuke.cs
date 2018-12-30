using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSA2
{
    public partial class frmJuke : Form
    {
        Stack primarySpindle = new Stack();
        Stack secondarySpindle = new Stack();

        public frmJuke()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                StackNode newNode = new StackNode(txtAlbumName.Text, txtArtistName.Text);
                newNode.noOfTracks = Convert.ToInt32(txtTracks.Text);
                newNode.duration = Convert.ToInt32(txtDuration.Text);

                if (primarySpindle.push(newNode))
                {
                    cbToRemove.Items.Insert(0, newNode.album);  // adds the new CD to the "Remove" dropdown list
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("ERROR: All fields must have a value (\"No. Of Tracks\" & \"Duration\" should be a number!)");
                String printError = DateTime.Now + " - " + "ERROR at: Push" + " - " + fex.Message + Environment.NewLine;
                printError += "INPUT: " + Environment.NewLine + "Album: " + txtAlbumName.Text + Environment.NewLine + "Artist: " + txtArtistName.Text + Environment.NewLine;
                printError += "No of Tracks: " + txtTracks.Text + Environment.NewLine + "Duration: " + txtDuration.Text;
                printError += Environment.NewLine + "" + Environment.NewLine;
                File.AppendAllText(@"..\..\log.txt", printError);
            }
            

            // clear fields
            txtAlbumName.Text = "";
            txtArtistName.Text = "";
            txtTracks.Text = "";
            txtDuration.Text = "";

            // print list
            lblContents.Text = primarySpindle.list();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lblContents.Text = primarySpindle.list();
            //lblContents.Text += "";
            //lblContents.Text += primarySpindle.count().ToString();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            StackNode removed = primarySpindle.pop();
            if (removed != null)
            {
                //lblOutput.Text = "Removed " + removed.album + " by " + removed.artist;
            }

            // print list
            lblContents.Text = primarySpindle.list();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            StackNode peeking = primarySpindle.peek();
            if (peeking != null)
            {
                lblPeek.Text = "The record at the top is " + peeking.album + " by " + peeking.artist;
            }
            else
            {
                lblPeek.Text = "There are no records on the spindle";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            if (primarySpindle.contains(search))
            {
                lblPlaying.Text = "Now playing: \"" + search + "\"";
            }
            else
            {
                lblPlaying.Text = "Could not find an album named \"" + search + "\"";
            }
        }

        private void btnPopSelect_Click(object sender, EventArgs e)
        {
            int noToRemove = cbToRemove.SelectedIndex;

            for(int index = 0; index < noToRemove; index++)
            {
                StackNode toSecond = primarySpindle.pop();
                secondarySpindle.push(toSecond);
            }

            if (cbToRemove.SelectedItem != null)
            {
                StackNode removed = primarySpindle.pop();
                //lblOutput.Text = "Removed " + removed.album + " by " + removed.artist;
                cbToRemove.Items.Remove(cbToRemove.SelectedItem);
            }
            else
            {
                MessageBox.Show("ERROR: You must select an item to remove!");
                String printError = DateTime.Now + " - " + "ERROR at: Remove" + " - " + "An item must be selected before it can remove." + Environment.NewLine + Environment.NewLine;
                File.AppendAllText(@"..\..\log.txt", printError);
            }
            

            while(secondarySpindle.peek() != null)
            {
                StackNode toPrimary = secondarySpindle.pop();
                primarySpindle.push(toPrimary);
            }

            // print list
            lblContents.Text = primarySpindle.list();
        }
    }
}
