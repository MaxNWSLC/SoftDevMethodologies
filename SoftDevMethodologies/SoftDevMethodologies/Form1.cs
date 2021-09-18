using System;
using System.Windows.Forms;

namespace SoftDevMethodologies
{
    public partial class Form1 : Form
    {
        public Form2 waterfall = new Form2();
        public Form3 agile = new Form3();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ConceptBtn(agile)
        private void Button5_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        //waterfallLink
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 waterfallInfo = new Form2("waterInfo");
            waterfallInfo.ShowDialog();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            agile.ShowDialog();
        }

        //ScrumBtn(agile)
        private void scrumButton_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //KanbanBtn(agile)
        private void kanbanButton_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //Extreme programing Methodology Button (agile)
        private void xpButton_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //DesignBtn(agile)
        private void button7_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //PlanBtn(agile)
        private void button6_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //DeployBtn(agile)
        private void button10_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //TestBtn(agile)
        private void button9_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //DevelopBtn(agile)
        private void button8_Click(object sender, EventArgs e)
        {
            agile.ShowDialog();
        }

        //RequirementsBtn(waterfall)
        private void WaterStage_Click(object sender, EventArgs e)
        {
            Form2 requirementsInfo = new Form2("RequirementsInfo");
            requirementsInfo.ShowDialog();
        }

        //DesignBtn(waterfall)
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 designInfo = new Form2("designInfo");
            designInfo.ShowDialog();
        }

        //ImplementationBtn(waterfall)
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 implementationInfo = new Form2("ImplementationInfo");
            implementationInfo.ShowDialog();
        }

        //TestingBtn(waterfall)
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 testingInfo = new Form2("TestingInfo");
            testingInfo.ShowDialog();
        }

        //MaintenenceBtn(waterfall)
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 maintenenceInfo = new Form2("MaintenenceInfo");
            maintenenceInfo.ShowDialog();
        }
    }
}
