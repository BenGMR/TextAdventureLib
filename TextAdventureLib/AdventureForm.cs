using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextAdventureLib
{
    public partial class AdventureForm : Form
    {
        Graphics gfx;

        string _startChoiceA;
        string _startChoiceB;
        string _startChoiceC;
        string _startDisplayText;
        bool _startedAdventure = false;
        string _startImageName;
        string _gameOverStoryPart = "gameover";
        string _firstStoryPart;
        Dictionary<string, Image> _images;
        /// <summary>
        /// The string representing which part of the story you're on.
        /// </summary>
        public string StoryPart = "0";

        public AdventureForm()
        {
            InitializeComponent();
            _images = new Dictionary<string, Image>();
            gfx = CreateGraphics();

        }
        /// <summary>
        /// Adds an image with a name to a collection of images.
        /// </summary>
        /// <param name="name">The name representing the image.</param>
        /// <param name="filePath">The full filepath of the image.</param>
        public void AddImage(string name, string filePath)
        {
            Image img = null;
            try
            {
                img = Image.FromFile(filePath);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Filepath not valid. Check path or spelling");
            }

            _images.Add(name, img);
        }

        /// <summary>
        /// Adds an image with a name to a collection of images.
        /// </summary>
        /// <param name="name">The name representing the image.</param>
        /// <param name="filePath">The full filepath of the image.</param>
        public void AddImage(string name, Image image)
        {
            if (_images.ContainsKey(name))
            {
                throw new ArgumentException("The entered name already exists. Change the name to something else");
            }
            _images.Add(name, image);
        }
        /// <summary>
        /// Updates the adventure to a new story part.
        /// </summary>
        /// <param name="imageName">The name of the new image to show</param>
        /// <param name="displayText">The text to display to the user</param>
        /// <param name="choiceA">The text for choice A</param>
        /// <param name="choiceB">The text for choice B</param>
        /// <param name="choiceC">The text for choice C</param>
        /// <param name="newStoryPart">The new story part</param>
        public void UpdateAdventure(string imageName, string displayText, string choiceA, string choiceB, string choiceC, string newStoryPart)
        {
            ChangeImage(imageName);
            ChangeText(displayText);
            ChoiceA.Text = choiceA;
            ChoiceB.Text = choiceB;
            ChoiceC.Text = choiceC;
            StoryPart = newStoryPart;
        }

        
        /// <summary>
        /// Returns the image with the entered name from the collection of images.
        /// </summary>
        /// <param name="name">The name representing the image.</param>
        /// <returns></returns>
        public Image GetImage(string name)
        {
            Image img;
            try
            {
                img = _images[name];
            }
            catch (KeyNotFoundException e)
            {
                throw new KeyNotFoundException("Could not find the image. Make sure you added it and spelled it correctly");
            }
            return img;
        }
        /// <summary>
        /// Begins the text adventure and sets the starting point for Restart().
        /// </summary>
        /// <param name="imageName">The name of the starting image of the text adventure. Use AddImage to add it first.</param>
        /// <param name="displayText">The starting text of the text adventure.</param>
        /// <param name="choiceA">Choice A for the first part of the story.</param>
        /// <param name="choiceB">Choice B for the first part of the story.</param>
        /// <param name="choiceC">Choice C for the first part of the story.</param>
        /// /// <param name="firstStoryPart">The story part that represents the beginning of the text adventure.</param>
        /// <param name="gameoverStoryPart">The story part that represents the lose state of the text adventure. "gameover" by default.</param>
        public void StartAdventure(string imageName, string displayText, string choiceA, string choiceB, string choiceC, string firstStoryPart, string gameoverStoryPart = "gameover")
        {
            if (_startedAdventure)
            {
                throw new Exception("You already started your text adventure");
            }
            _startImageName = imageName;
            _startChoiceA = choiceA;
            _startChoiceB = choiceB;
            _startChoiceC = choiceC;
            _startDisplayText = displayText;
            ChoiceA.Text = _startChoiceA;
            ChoiceB.Text = _startChoiceB;
            ChoiceC.Text = _startChoiceC;
            ChangeText(displayText);
            _gameOverStoryPart = gameoverStoryPart;
            _firstStoryPart = firstStoryPart;
            StoryPart = _firstStoryPart;
            ChangeImage(imageName);
            _startedAdventure = true;
        }
        /// <summary>
        /// Sets the adventure in a "lose state" where only the middle button is visible and says "restart".
        /// </summary>
        /// <param name="losetext">The display text to change to.</param>
        public void Lose(string losetext)
        {
            ChangeText(losetext);
            ChoiceA.Visible = false;
            ChoiceC.Visible = false;
            ChoiceB.Text = "Restart";
            StoryPart = "gameover";
        }
        /// <summary>
        /// Restarts the text adventure to the first part.
        /// </summary>
        public void Restart()
        {
            if (!_startedAdventure)
            {
                throw new Exception("Adventure not started. Call the StartAdventure function!");
            }
            DisplayLabel.Text = _startDisplayText;
            ChoiceA.Text = _startChoiceA;
            ChoiceB.Text = _startChoiceB;
            ChoiceC.Text = _startChoiceC;
            ChoiceA.Visible = true;
            ChoiceC.Visible = true;
            ChangeImage(_startImageName);
            StoryPart = _firstStoryPart;
        }
        /// <summary>
        /// Changes the text of the display label and centers it.
        /// </summary>
        /// <param name="text"></param>
        public void ChangeText(string text)
        {
            DisplayLabel.Text = text;
        }
        /// <summary>
        /// Changes the image of the DisplayBox to the image with the entered name. The image must be added through AddImage.
        /// </summary>
        /// <param name="name">The name representing the image.</param>
        public void ChangeImage(string name)
        {
            ImageBox.BackgroundImage = _images[name];
        }


        private void DisplayLabel_TextChanged(object sender, EventArgs e)
        {
            DisplayLabel.Location = new Point(ClientSize.Width / 2 - (int)(gfx.MeasureString(DisplayLabel.Text, DisplayLabel.Font).Width / 2), DisplayLabel.Location.Y);
        }


        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void ChoiceB_Click(object sender, EventArgs e)
        {
            
        }

        private void ChoiceC_Click(object sender, EventArgs e)
        {
            
        }

        private void ChoiceA_Click(object sender, EventArgs e)
        {
           
        }

        private void AdventureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
