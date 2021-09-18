using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftDevMethodologies
{
    public partial class Form2 : Form
    {
        public string maintenenceInfo = "Maintenence Info\n bla-bla-bla";
        public string testingInfo = "Testing Info\n bla-bla-bla";
        public string implementationInfo = "Implementation Info\n bla-bla-bla";
        public string requirementsInfo = "Requirements Info\n bla-bla-bla";
        public string designInfo = "Design Info\n bla-bla-bla";
        public string waterInfo = "Waterfall \n https://en.wikipedia.org/wiki/Waterfall_model";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string str)
        {
            InitializeComponent();
            switch (str)
            {
                case "designInfo":
                    DesignStep();
                    break;
                case "RequirementsInfo":
                    RequirementsStep();
                    break;
                case "ImplementationInfo":
                    ImplementationStep();
                    break;
                case "TestingInfo":
                    TestingStep();
                    break;
                case "MaintenenceInfo":
                    MaintenenceStep();
                    break;
                default:
                    WaterfallStep();
                    break;
            }
        }

        private void DesignBtn_Click(object sender, EventArgs e)
        {
            DesignStep();
        }

        public void ResetButtons()
        {
            WaterStage.BackColor = Color.Coral;
            button1.BackColor = Color.Coral;
            button2.BackColor = Color.Coral;
            button3.BackColor = Color.Coral;
            button4.BackColor = Color.Coral;
        }

        public void WaterfallStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = waterInfo;
            prosGroupBoxWat.Visible = true;
            consGroupBoxWat.Visible = true;
            label1.Text = "Waterfall";
            waterrfallLink.Visible = false;
        }
        public void DesignStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = designInfo;
            prosGroupBoxWat.Visible = false;
            consGroupBoxWat.Visible = false;
            button1.BackColor = Color.DodgerBlue;
            label1.Text = "Design";
            waterrfallLink.Visible = true;
        }
        public void RequirementsStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = requirementsInfo;
            prosGroupBoxWat.Visible = false;
            consGroupBoxWat.Visible = false;
            WaterStage.BackColor = Color.DodgerBlue;
            label1.Text = "Requirements";
            waterrfallLink.Visible = true;
        }
        public void ImplementationStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = implementationInfo;
            prosGroupBoxWat.Visible = false;
            consGroupBoxWat.Visible = false;
            button2.BackColor = Color.DodgerBlue;
            label1.Text = "Implementation";
            waterrfallLink.Visible = true;
        }
        public void TestingStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = testingInfo;
            prosGroupBoxWat.Visible = false;
            consGroupBoxWat.Visible = false;
            button3.BackColor = Color.DodgerBlue;
            label1.Text = "Testing";
            waterrfallLink.Visible = true;
        }
        public void MaintenenceStep()
        {
            ResetButtons();
            waterfallTextLabel.Text = maintenenceInfo;
            prosGroupBoxWat.Visible = false;
            consGroupBoxWat.Visible = false;
            button4.BackColor = Color.DodgerBlue;
            label1.Text = "Maintenence";
            waterrfallLink.Visible = true;
        }
        private void RequirementsBtn_Click(object sender, EventArgs e)
        {
            RequirementsStep();
        }

        private void waterrfallLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WaterfallStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImplementationStep();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestingStep();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaintenenceStep();
        }
    }
}
