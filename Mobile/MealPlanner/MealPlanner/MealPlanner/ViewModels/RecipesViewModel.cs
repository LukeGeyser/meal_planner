﻿using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.ViewModels
{
    public class RecipesViewModel : INotifyPropertyChanged
    {
        private int recipeID { get; set; }
        private string recipeName { get; set; }
        private string shortDescription { get; set; }
        private string instructions { get; set; }
        private string difficulty { get; set; }
        private int timeToPrepare { get; set; }
        private string imagePreview { get; set; }
        private string difficultyColor { get; set; }

        private List<Products> products { get; set; }

        public int RecipeID
        {
            get { return recipeID; }
            set
            {
                recipeID = value;
                OnPropertyChanged();
            }
        }
        public string RecipeName
        {
            get { return recipeName; }
            set
            {
                recipeName = value;
                OnPropertyChanged();
            }
        }
        public string ShortDescription
        {
            get { return shortDescription; }
            set
            {
                shortDescription = value;
                OnPropertyChanged();
            }
        }
        public string Instructions
        {
            get { return instructions; }
            set
            {
                instructions = value;
                OnPropertyChanged();
            }
        }
        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                OnPropertyChanged();
            }
        }
        public int TimeToPrepare
        {
            get { return timeToPrepare; }
            set
            {
                timeToPrepare = value;
                OnPropertyChanged();
            }
        }
        public string ImagePreview
        {
            get { return imagePreview; }
            set
            {
                imagePreview = value;
                OnPropertyChanged();
            }
        }

        public List<Products> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        public string DifficultyColor
        {
            get { return difficultyColor; }
            set
            {
                difficultyColor = value;
                OnPropertyChanged();
            }
        }

        public RecipesViewModel()
        {

        }

        public RecipesViewModel(int id, string name, string des, string instruct, string difficult, int time, string imagePreview)
        {
            recipeID = id;
            recipeName = name;
            shortDescription = des;
            instructions = instruct;
            difficulty = difficult;
            timeToPrepare = time;
            this.imagePreview = imagePreview;
            difficultyColor = ChoseDifficultyColor();
        }

        private string ChoseDifficultyColor()
        {
            if (difficulty == "Easy")
            {
                return "#669e2f";
            }
            else if (difficulty == "Medium")
            {
                return "#ffb73b";
            }
            else if (difficulty == "Hard")
            {
                return "#db5151";
            }
            else return "#2d2d2d";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
