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

namespace Last_Project
{
    public partial class Form : System.Windows.Forms.Form
    {
        //define a pic box to add on the form later
        PictureBox boxpic = new PictureBox();
        //function to call the single mode
        private void singlePic()
        {//checking if there is a pic selected
           
            if (picsList.SelectedItems.Count > 0)
                boxpic.Image = Image.FromFile(picsList.GetItemText(picsList.SelectedItem));
        }
        //function to call the multi mode
        private void multiPics()
        {
            //define the starting point x,y 
            int x = 285, y = 50;
            //call remove function that was defined down to delete all pic boxs int the form 
            RemovePictureBoxs(this);
            //define the number of columns and rows to fit the number of pics needed to show 
            int row=1, cloumn=1;
            //count the number of items selected
            int itemsSelected = picsList.SelectedItems.Count;
            //finding the number of rows and coloums to fit the number of pics
            for (int i=1; ; i++)
            {
                if (i * i >= itemsSelected)
                {
                    row = i;
                    cloumn = i;
                    break;
                }
               else if(i*(i+1)>=itemsSelected)
                {
                    row = i+1;
                    cloumn = i;
                    break;
                }
            }
            //defind the width of every pic box and height
            int width = 820 / cloumn;
            int height = 500 / row;
            foreach (String s in picsList.SelectedItems)
            {
                PictureBox box = new PictureBox();
                box.Size = new Size(width,height);
                box.Location = new Point(x, y);
                box.Image = Image.FromFile(s);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(box);
                //checking if we have reached the limit in x axis 
                if (x+width*2>285+820)
                {
                    x = 285;
                    y += height;
                }
                else
                    x += width;

            }
    }
       //define integer index to use it in the slide show mode
        int idx = 0;
        public Form()
        {
            InitializeComponent();
        }
        private void upload_Click(object sender, EventArgs e)
        {
            if (uploadFiles.ShowDialog() == DialogResult.OK)
            {
                picsList.Items.AddRange(uploadFiles.FileNames);
            }
        }

        private void single_Click(object sender, EventArgs e)
        {
            picsList.SelectedIndex = -1;
            if (single.Checked == false)
            {
                hints.Text = "Right click to choose the view mode";
                RemovePictureBoxs(this);
            }
            else
            {
                //making the mode of selection single only as it is single pic view
                picsList.SelectionMode = SelectionMode.One;
                hints.Text = "Single Pic";
                label1.Text = null;
                //stopping the timer of the slide show and remove the check of the others if they were working
                timer.Stop();
                multi.Checked = false;
                SlideShow.Checked = false;
                RemovePictureBoxs(this);
                boxpic = new PictureBox();
                boxpic.Size = new Size(820,480);
                boxpic.Location = new Point(285, 50);
                boxpic.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(boxpic);
                singlePic();
              }
        }
        private void multi_Click(object sender, EventArgs e)
        {
            picsList.SelectedIndex = -1;
            if(multi.Checked==false)
            {
                RemovePictureBoxs(this);
                hints.Text = "Right click to choose the view mode";
                picsList.SelectionMode = SelectionMode.One;
            }
            else
            {
                hints.Text = "Multi picture (use ctrl to mark multi pics)";
                picsList.SelectionMode = SelectionMode.MultiExtended;
                label1.Text = null;
                timer.Stop();
                single.Checked = false;
                SlideShow.Checked = false;
                multiPics();
            }
        }
        private void SlideShow_Click(object sender, EventArgs e)
        {
            picsList.SelectedIndex = -1;
            if (SlideShow.Checked==false)
            {
                timer.Stop();
                label1.Text = null;
                RemovePictureBoxs(this);
                hints.Text = "Right click to choose the view mode";
            }
            else
            {
                picsList.SelectedIndex=-1;
                idx = 0;
                hints.Text = "Slide show ";
                single.Checked = false;
                multi.Checked = false;
                RemovePictureBoxs(this);
                boxpic = new PictureBox();
                boxpic.Size = new Size(820, 480);
                boxpic.Location = new Point(285, 50);
                boxpic.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(boxpic);
                timer.Start();
            }
        }
        //using the timeer function to call the next pic every second in slidshow mode
        private void timer_Tick(object sender, EventArgs e)
        {//called every second and everytime we change the index of the pic list that is selected
            if (picsList.Items.Count != 0)
            {
                if (SlideShow.Checked == true)
                {
                    boxpic.Image = Image.FromFile(picsList.GetItemText(picsList.Items[idx]));
                    label1.Text = Path.GetFileName(picsList.GetItemText(picsList.Items[idx]));
                    if (idx == picsList.Items.Count - 1)
                        idx = 0;
                    else
                        idx++;
                }
            }
        }
        private void picsList_SelectedIndexChanged(object sender, EventArgs e)
        {//if any selected items changed check if what is the mode that is working and call its function 
            if(single.Checked && picsList.SelectedItems.Count>0)
            {
                singlePic();
            }
            if (multi.Checked && picsList.SelectedItems.Count >= 0)
            {
                multiPics();
            }
           

        }
        //close the program 
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //function to remove all pic boxs on the form by giving it the form name 
        private void RemovePictureBoxs(Form control)
        {//making list to store all pic boxs avaliable int the form
            List<PictureBox> allPicBoxs = new List<PictureBox>();

            foreach (Control pic in control.Controls)
            {//check if the control is a pic box
                if (pic.GetType() == typeof(PictureBox))

                {
                    PictureBox delet = (PictureBox)pic;
                    allPicBoxs.Add(delet);

                }

            }
            //deleting all picture boxs by making sure the the image in the picture box is diposed
            foreach (PictureBox ctrl in allPicBoxs)
            {
                control.Controls.Remove(ctrl);
                if (ctrl.Image != null)
                    ctrl.Image.Dispose();
            }
        }
        
        
        //Mohamed Ahmed Taha CS section 2
    }
}
