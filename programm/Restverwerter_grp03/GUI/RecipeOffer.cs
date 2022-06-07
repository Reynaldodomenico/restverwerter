using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;

namespace GUI
{
    public partial class RecipeOffer : UserControl
    {
        public static RecipeOffer recipeOffer = new RecipeOffer();

        public RecipeOffer()
        {
            InitializeComponent();
            this.Load += RecipeOffer_Load;
        }

        // Events mithilfe StackExchange geschrieben.
        private void RecipeOffer_Load(object sender, EventArgs e)
        {
            // Register the MouseClick event with the UC's surface.
            this.MouseClick += Control_MouseClick;
            // Register MouseClick with all child controls.
            RegisterMouseEvents(Controls);
        }

        // BEreich zustädnig für das Anklicken der gesamten generierten RecipeOffers
        #region ClickEvent and Functions to Open up the Introduction for each RecipeOffer
        // Event fires when the MouseClick event fires for the UC or any of its child controls.
        public event EventHandler<EventArgs> WasClicked;

        private void RegisterMouseEvents(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Subscribe the control to the 
                control.MouseClick += Control_MouseClick;
                if (control.HasChildren) RegisterMouseEvents(control.Controls);
            }
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }
            // Select this UC on click.
            IsSelected = true;
            if (this.IsSelected)
            {
                // Open Instruction
                InstructionForm.instructionForm.OpenRecipeData((this));
                InstructionForm.instructionForm.ShowDialog();
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.BorderStyle = IsSelected ? BorderStyle.FixedSingle : BorderStyle.None;
            }
        }
        #endregion

        // selbst erstelltes RecipeOffer (UserControl) gelernt via Youtube
        #region Customizable Properties
        // Properties for RecipeOffer und ermöglicht Die Eingabe von verschiedenen Eingaben in RecipeOffer im Eigenschaften Fenster vom Form.
        private string _title;
        private string _ingredientListOffer;
        private string _duration;
        private string _fittingRecipes;
        private Recipe.DietValue _diet;
        private TextBox _instruction;
        private Image _bild;

        [Category("Custom Properties")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                TitleRecipe.Text = value;
            }
        }

        public TextBox Instruction
        {
            get => _instruction;
            set => _instruction = value;
        }

        public string IngredientListOffer
        {
            get { return _ingredientListOffer; }
            set { _ingredientListOffer = value;
                Zutaten_Label.Text = value;
            }
        }

        public Recipe.DietValue Diet
        {
            get { return _diet; }
            set
            {
                _diet = value;
            }
        }

        public string FittingRecipes
        {
            get { return _fittingRecipes; }
            set
            {
                _fittingRecipes = value;
                Fitting_Recipes_Label.Text = value;
            }
        }

        [Category("Custom Properties")]
        public string Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                Cook_Duration_Label.Text = value;
            }
        }

        [Category("Custom Properties")]
        public Bitmap Bild
        {
            get { return (Bitmap) _bild; }
            set
            {
                _bild = value;
                RecipePicturebox.Image = value;
            }
        }
        #endregion
    }
}
