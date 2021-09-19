using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftDevMethodologies
{
    public partial class Form3 : Form
    {
        public string conceptInfo = "\n\n\n\n" + @"   The first step in an Agile process is to determine the project vision.
The product owner usually performs this step, which clearly states 
what the project is, who will benefit from it, how it will support 
the business, and how it will benefit others.";
        public string planInfo = "\n\n\n\n" + @"   The planing step is when we plan the features the app will have,
the end result of the project and some aditional features that may be 
implemented at later stages when the main ap will be ready.";
        public string designInfo = "\n\n\n\n" + @"   Designing stage would include choosing of the programming language
at the early stages and the rough sketch of how the app will be. 
At the later stages team would refine the design and add new features.";
        public string developInfo = "\n\n\n\n" + @"   The development phase is about writing code and converting design 
documentation into the actual software within the software development
process. This stage of SDLC is generally the longest as it’s the backbone 
of the whole process.
   There aren’t many changes between the iterations here. ";
        public string testInfo = "\n\n\n\n" + @"Testing stage is spent on making sure that the software is bug-free
and compatible with everything else that the developers have written before.
The Quality Assurance team conducts a series of tests in order to ensure
the code is clean and business goals of the solution are met.";
        public string deployInfo = "\n\n\n\n" + @"   The application is deployed on the servers and provided to 
the customers — either for the demo or the actual use. Further 
iterations update the already installed software, introducing 
new features and resolving bugs.
   Once all previous development phases are complete, the Product Owner 
gathers the Development Team once again and reviews the progress made
towards completing the requirements. The team introduces their ideas 
toward resolving the problems that arose during the previous phases 
and the Product Owner takes their propositions into consideration.

   Afterwards, the Agile software development lifecycle phases 
start anew — either with a new iteration or by moving toward the
next stage and scaled Agile.";
        
        public string agileInfo = @"   Agile is a methodology that follows the set of principles.
It is an iterative approach to software development and project
management that enables teams to deliver results to their customers
in less time and with fewer problems.
   Rather than betting everything on one major launch at the end, 
Agile teams deliver work in smaller increments. Plans, requirements, 
and results are evaluated on a regular basis, which means teams will, 
naturally, have time and a way to respond to changes along the way.

    Agile Methodology have many different types, but I'll describe 
just 3 of them: Scrum, Kanban and Extreme Programing(XP). 
They are probably the most polpular Agile frameworks ";

        public string scrumInfo = @"   The Scrum framework is one of the main Agile methodology frameworks 
used in projects by the teams to deliver a finished product in sprints.
After each sprint gets over, the product gets reviewed, feedback is 
produced, and the next sprint begins. The iterative approach to project 
completion helps improve the product with each iteration and helps deliver 
maximum value to the end-user.
   Since the scrum method consists of short sprints with constant feedback,
it is easier to cope with the changes required by the customer. To have 
successful sprint planning, the team must consist of members who are well 
aware of the agile scrum.
   Scrum projects work best with a limited number of teams and team members 
at the time of daily scrums. The Scrum method works best when used in a team 
of at least 10-15 people and when used in conjunction with other teams, such 
as a small or large team.
   Agile Scrum is one of the main causes of scope creep, as there is no 
specific end date, and project management teams are tempted to keep demanding
new functionality. Agile crowding can be one of the main causes of scopes 
slipping through, as there is no definitive end data and project management 
stakeholders are tempted to keep demanding new functionality that needs to be 
provided. Agile scrum could be one of the main causes of scoping crawling 
because there is a certain end date.";
        public string scrumPros = @"* The product more often than not gets delivered at 
  the right time.
* Scrum methodology incorporates daily meetings, which 
  helps in identifying problems and resolving them in time.
* By involving customers, Scrum methodology ensures 
  best results.
* Removing mistakes or rectifying them is considerably easy
  with scrum methodology.
* Fast results and simple testing procedure for better work 
  output and quality.
* Clients get access to a transparent process which allows 
  them to trace the entire procedure and measure individual 
  productivity.";
        public string scrumCons = @"* There is a greater pressure on team members and 
  they have to spend a large amount of time on project 
  development.
* Requires strong commitment from all members of the team.
  In case some members are not up to the task, it can lead
  to grave problems.
* Mostly suited for small teams that have great cohesion 
  and understanding.
* Does not come with any predicted time limit and cost 
  valuations, which can make it to expand to several sprints.
* If a member of the team leaves the process, it may have a 
  negative impact on the project development.";
        public string kanbanInfo = @"   Kanban is a popular framework used to implement agile in 
software development. It requires real-time communication of capacity and
full transparency of work. Work items are represented visually on a kanban
board, allowing team members to see the state of every piece of work 
at any time.
   A kanban board is an management tool designed to help visualize work,
limit work-in-progress, and maximize efficiency. It can help teams establish
order in their daily work. Kanban boards use cards, columns, and continuous 
improvement to help technology and service teams commit to the right 
amount of work, and get it done! There can be physical bords or digital ones.
   Kanban work in progress (WIP) limits the maximum amount of work that can 
exist in each status of a workflow. Limiting the amount of work in progress
makes it easier to identify inefficiency in a team's workflow. Bottlenecks in a
team's delivery pipeline are clearly visible before a situation becomes dire.
   WIP limits guarantee un-reviewed code doesn't pile up. 
   The code doesn't rot as team members check in new code
   The developer doesn't lose the context he or she gained in writing 
the original code
   The feature can be merged into the main branch for release";
        public string kanbanPros = @"* Kanban is a very simple and easy to understand 
  approach, which makes it practical for the management of 
  a company to apply effectively. You do not have to be an 
  expert to work with the Kanban approach.
* It not only consists of manual guidelines or cards but 
  also draws visualizations of the process outputs which 
  makes the analysis of work easier. This could also highlight 
  other potentially uncertain areas where additional focus 
  is needed.
* Kanban system upgrades the flow and management by directly
  helping the company to engage the company’s existing systems
  which decreases carrying or holding costs.";
        public string kanbanCons = @"* There are no timeframes associated with each phase,
  which can be disadvantageous.
* If you don’t update the Kanban Board, it may not reflect 
  the things accurately.
* Kanban approach assumes the plans that are stable and 
  consistent to a certain level, it may become feeble in 
  industries where the activities are not still.";
        public string extremeInfo = @"   Extreme Programming (XP) is an agile software development framework 
that aims to produce higher quality software, and higher quality of life
for the development team. XP is the most specific of the agile frameworks 
regarding appropriate engineering practices for software development.
   Software development is inherently a team sport that relies on 
communication to transfer knowledge from one team member to everyone 
else on the team. XP stresses the importance of the appropriate kind of 
communication – face to face discussion with the aid of a white board or
other drawing mechanism.
   One of the XP values is Simplicity. The purpose of this is to avoid
waste and do only absolutely necessary things such as keep the design of 
the system as simple as possible so that it is easier to maintain, support, 
and revise. Simplicity also means address only the requirements that you know
about don’t try to predict the future. 
   Through constant feedback about their previous efforts, teams can identify
areas for improvement and revise their practices. Feedback also supports 
simple design. Your team builds something, gathers feedback on your design 
and implementation, and then adjust your product going forward.";
        public string extremePros = @"* The main advantage of Extreme Programming is that this 
  methodology allows software development companies to 
  save costs and time required for project realization. 
  Time savings are available because of the fact that XP 
  focuses on the timely delivery of final products. 
  Extreme Programming teams save lots of money because 
  they don’t use too much documentation.
* Constant feedback is also the strong side.It is necessary 
  to listen and make any changes needed in time.
* XP assists to create software faster thanks to the regular 
  testing at the development stage.";
        public string extremeCons = @"* Some specialists say that Extreme Programming is focused
  on the code rather than on design. That may be a problem 
  because good design is extremely important for software 
  applications. It helps sell them in the software market. 
  Additionally, in XP projects the defect documentation is 
  not always good. Lack of defect documentation may lead to 
  the occurrence of similar bugs in the future.
* One more disadvantage of XP is that this methodology does
  not measure code quality assurance. It may cause defects 
  in the initial code.
* XP is not the best option if programmers are separated 
  geographically.";
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string str)
        {
            InitializeComponent();
            switch (str)
            {
                case "ConceptInfo":
                    ConceptStep();
                    break;
                case "PlanInfo":
                    PlanStep();
                    break;
                case "DevelopInfo":
                    DevelopStep();
                    break;
                case "TestInfo":
                    TestingStep();
                    break;
                case "DesignInfo":
                    DesignStep();
                    break;
                case "DeployInfo":
                    DeployStep();
                    break;
                case "ScrumInfo":
                    ScrumStep();
                    break;
                case "KanbanInfo":
                    KanbanStep();
                    break;
                case "ExtremeInfo":
                    ExtremeStep();
                    break;
                default:
                    AgileStep();
                    break;
            }
        }
        public void ProCons(int num)
        {
            if (num == 1)
            {
                prosGroupBox.Visible = true;
                consGroupBox.Visible = true;
            }else
            {
                prosGroupBox.Visible = false;
                consGroupBox.Visible = false;
            }
        }
        public void ResetButtons()
        {
            button5.BackColor = Color.LightSalmon;
            button6.BackColor = Color.LightSalmon;
            button7.BackColor = Color.LightSalmon;
            button8.BackColor = Color.LightSalmon;
            button9.BackColor = Color.LightSalmon;
            button10.BackColor = Color.LightSalmon;

            scrumButton.BackColor = Color.Coral;
            kanbanButton.BackColor = Color.Coral;
            xpButton.BackColor = Color.Coral;
        }

        public void ConceptStep()
        {
            ResetButtons();
            agileTextLabel.Text = conceptInfo;
            ProCons(0);
            label2.Text = "Concept";
            agileLink.Visible = true;
            button5.BackColor = Color.DeepSkyBlue;
        }
        public void PlanStep()
        {
            ResetButtons();
            agileTextLabel.Text = planInfo;
            ProCons(0);
            label2.Text = "Plan";
            agileLink.Visible = true;
            button6.BackColor = Color.DeepSkyBlue;
        }
        public void DevelopStep()
        {
            ResetButtons();
            agileTextLabel.Text = developInfo;
            ProCons(0);
            label2.Text = "Develop";
            agileLink.Visible = true;
            button8.BackColor = Color.DeepSkyBlue;
        }
        public void TestingStep()
        {
            ResetButtons();
            agileTextLabel.Text = testInfo;
            ProCons(0);
            label2.Text = "Test";
            agileLink.Visible = true;
            button9.BackColor = Color.DeepSkyBlue;
        }
        public void DesignStep()
        {
            ResetButtons();
            agileTextLabel.Text = designInfo;
            ProCons(0);
            label2.Text = "Design";
            agileLink.Visible = true;
            button7.BackColor = Color.DeepSkyBlue;
        }
        public void DeployStep()
        {
            ResetButtons();
            agileTextLabel.Text = deployInfo;
            ProCons(0);
            label2.Text = "Deploy";
            agileLink.Visible = true;
            button10.BackColor = Color.DeepSkyBlue;
        }
        public void ScrumStep()
        {
            ResetButtons();
            ProCons(1);
            prosLabel.Text = scrumPros;
            consLabel.Text = scrumCons;
            agileTextLabel.Text = scrumInfo;
            label2.Text = "Scrum";
            agileLink.Visible = true;
            scrumButton.BackColor = Color.DodgerBlue;
        }
        public void KanbanStep()
        {
            ResetButtons();
            ProCons(1);
            agileTextLabel.Text = kanbanInfo;
            prosLabel.Text = kanbanPros;
            consLabel.Text = kanbanCons;
            label2.Text = "Kanban";
            agileLink.Visible = true;
            kanbanButton.BackColor = Color.DodgerBlue;
        }
        public void ExtremeStep()
        {
            ResetButtons();
            ProCons(1);
            agileTextLabel.Text = extremeInfo;
            prosLabel.Text = extremePros;
            consLabel.Text = extremeCons;
            label2.Text = "Extreme";
            agileLink.Visible = true;
            xpButton.BackColor = Color.DodgerBlue;
        }
        public void AgileStep()
        {
            ResetButtons();
            agileTextLabel.Text = agileInfo;
            ProCons(0);
            label2.Text = "Agile";
            agileLink.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConceptStep();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlanStep();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DesignStep();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DevelopStep();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TestingStep();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeployStep();
        }

        private void scrumButton_Click(object sender, EventArgs e)
        {
            ScrumStep();
        }

        private void kanbanButton_Click(object sender, EventArgs e)
        {
            KanbanStep();
        }

        private void xpButton_Click(object sender, EventArgs e)
        {
            ExtremeStep();
        }

        private void agileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgileStep();
        }
    }
}
