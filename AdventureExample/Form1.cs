using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextAdventureLib;

namespace AdventureExample
{
    public partial class Form1 : AdventureForm
    {
        public Form1()
        {
            InitializeComponent();
            AddImage("room", Properties.Resources.toddler_kids_bedroom_furniture_1);
            AddImage("stan", Properties.Resources.stansHead);
            AddImage("explosion", Properties.Resources.Operation_Upshot_Knothole___Badger_001);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartAdventure("room", "You're in your room. What do you do?", "Go to sleep", "Play video games", "Jump out of the window", "room");
        }

        private void ChoiceA_Click(object sender, EventArgs e)
        {
            if (StoryPart == "room")
            {
                Lose("Your house exploded! THE END");
                ChangeImage("explosion");
            }
            else if (StoryPart == "stan")
            {
                Lose("YOU CAN'T RUN FROM STAN. THE END");
            }
        }

        private void ChoiceB_Click(object sender, EventArgs e)
        {
            if (StoryPart == "gameover")
            {
                Restart();
            }
            else if (StoryPart == "room")
            {
                ChangeImage("explosion");
                Lose("Your console exploded. THE END");
            }
            else if (StoryPart == "stan")
            {
                Lose("You turned to stone. THE END");
            }
        }

        private void ChoiceC_Click(object sender, EventArgs e)
        {
            if (StoryPart == "room")
            {
                UpdateAdventure("stan", "You jumped out and realized stan was watching you the\nwhole time. What next?", "Run away", "Stare at him", "Play video games", "stan");
               
            }
            else if (StoryPart == "stan")
            {
                Lose("Stan is terrible at video games. YOU WIN!");
            }
        }
    }
}