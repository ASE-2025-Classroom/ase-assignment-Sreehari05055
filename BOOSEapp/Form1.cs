using BOOSE;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;

namespace BOOSEapp
{
    public partial class BooseApp : Form
    {
        ICanvas myCanvas;
        ICommandFactory factory;
        IParser parser;
        StoredProgram Program;


        public  BooseApp()
        {
            InitializeComponent();
            Debug.WriteLine("BooseApp initialized");
            myCanvas = new BooseCanvas();
            factory = new AppCommandFactory();
            Program = new StoredProgram(myCanvas);
            parser = new Parser((BOOSE.CommandFactory)factory, Program);
        }

        public string UserInput
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            string input = UserInput;
            
        }

    }
}
