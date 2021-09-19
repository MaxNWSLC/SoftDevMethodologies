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
        public string maintenenceInfo = "\n\n\n" + "   The product has been delivered to the client and is being used.\nAs issues arise, your team may need to create patches and\nupdates may to address them.\nAgain, big issues may necessitate a return to phase one.";
        public string testingInfo = "\n\n\n" + "   Once all coding is done, testing of the product can begin.\nTesters methodically find and report any problems.\nIf serious issues arise, your project may need to return to\nphase one for reevaluation.";
        public string implementationInfo = "\n\n\n" + "   Coding takes place in this phase.\nProgrammers take information from the previous stage and create\na functional product.\nThey typically implement code in small pieces, which are integrated\nat the end of this phase or the beginning of the next.";
        public string requirementsInfo = "\n\n\n" + "   In this stage, you should gather comprehensive information about\nwhat this project requires. You can gather this information in\na variety of ways, from interviews to questionnaires to\ninteractive brainstorming. " +
                                         "By the end of this phase, the project\nrequirements should be clear, and you should have a requirements\ndocument that has been distributed to your team.";
        public string designInfo = "\n\n\n" + "   Using the established requirements, your team designs the system.\nNo coding takes place during this phase, but the team establishes\nspecs such as programming language or hardware requirements.";
        public string waterInfo = "   Simply put, waterfall project management is a sequential,\nlinear process of project management. It consists of several\ndiscrete phases. No phase begins until the prior phase is complete,\nand each phase’s completion is terminal—waterfall management\n"+
                                  "does not allow you to return to a previous phase. The only way to revisit\na phase is to start over at phase one.\n" +
                                  "   If waterfall methodology sounds strict, that’s because\nthe system’s history demanded it. Waterfall project management has\nits roots in non-software industries like manufacturing and construction,\nwhere the system arose out of necessity. In these fields, project\n"+
                                  "phases must happen sequentially. You can’t put up drywall if you\nhaven’t framed a house. Likewise, it’s impossible to revisit a phase.\nThere’s no good way to un-pour a concrete foundation.\n" +
                                  "   Proper planning is a must in the waterfall system. A project’s\nrequirements must be clear upfront, and everyone involved in a project\nmust be well aware of those requirements. Each team member should\nalso understand what their role will be in the project and what\nthat role entails.\n"+
                                  "   Consequently, thorough documentation is a priority in the waterfall\nproject management methodology. Documentation should take place\nthroughout every phase of the process, ensuring that everyone involved\nis on the same page despite the sequential progression of the project.";
        public string prosWindow = "*  It’s easily understood because it follows the same pattern for each project\n  and requires no prior knowledge or training to get started. Each of the five phases\n   has specific components that need to be met and reviewed, making it easy to\n  maintain control over each step.\n"+
                                   "*  Because the start and end points of each step are determined at the onset of\n  a project, it’s easy to share progress, report on missed deadlines, and eliminate\n  risk associated with project management.";
        public string consWindow = "*  Once a phase is completed, there is no way to go back and change the outcome\n  without repeating the entire process from the beginning. It is both time-consuming\n  and costly to allow room for change within this process, making it difficult\n  "+
                                   "for teams to maintain strict timelines if not everything goes as planned.\n"+ "*  There are extensive steps that a project must go through before it even begins the\n  execution phase. As a result, it takes longer to see a product begin production\n  until late in the life cycle.";

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
        //check if we need Pros and Cons windows 
        public void ProCons(int num)
        {
            if (num == 1)
            {
                prosGroupBoxWat.Visible = true;
                consGroupBoxWat.Visible = true;
            }
            else
            {
                prosGroupBoxWat.Visible = false;
                consGroupBoxWat.Visible = false;
            }
        }

        public void WaterfallStep()
        {
            ResetButtons();
            ProCons(1);
            waterfallTextLabel.Text = waterInfo;
            label1.Text = "Waterfall";
            waterrfallLink.Visible = false;
            prosLabel.Text = prosWindow;
            consLabel.Text = consWindow;
        }
        public void DesignStep()
        {
            ResetButtons();
            ProCons(0);
            waterfallTextLabel.Text = designInfo;
            button1.BackColor = Color.DodgerBlue;
            label1.Text = "Design";
            waterrfallLink.Visible = true;
        }
        public void RequirementsStep()
        {
            ResetButtons();
            ProCons(0);
            waterfallTextLabel.Text = requirementsInfo;
            WaterStage.BackColor = Color.DodgerBlue;
            label1.Text = "Requirements";
            waterrfallLink.Visible = true;
        }
        public void ImplementationStep()
        {
            ResetButtons();
            ProCons(0);
            waterfallTextLabel.Text = implementationInfo;
            button2.BackColor = Color.DodgerBlue;
            label1.Text = "Implementation";
            waterrfallLink.Visible = true;
        }
        public void TestingStep()
        {
            ResetButtons();
            ProCons(0);
            waterfallTextLabel.Text = testingInfo;
            button3.BackColor = Color.DodgerBlue;
            label1.Text = "Testing";
            waterrfallLink.Visible = true;
        }
        public void MaintenenceStep()
        {
            ResetButtons();
            ProCons(0);
            waterfallTextLabel.Text = maintenenceInfo;
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
