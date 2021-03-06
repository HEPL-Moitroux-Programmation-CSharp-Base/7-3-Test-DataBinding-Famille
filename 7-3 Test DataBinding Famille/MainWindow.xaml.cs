﻿using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace _8_Test_DataBinding_Famille
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Personne> listpersonne = new ObservableCollection<Personne>();
        public MainWindow()
        {
            InitializeComponent();
            listpersonne.Add(new Personne("Simpson", "Homer", new DateTime(2051, 5, 21),
                @"Images\HomerSimpson.png"));
            listpersonne.Add(new Personne("Simpson", "Marge", new DateTime(2050, 5, 30),
                @"Images\MargeSimpson.png"));
            listpersonne.Add(new Personne("Simpson", "Maggie", new DateTime(2018, 5, 15)));
            listpersonne.Add(new Personne("Simpson", "Bart", new DateTime(2018, 5, 30)));

            lbFamille.DataContext = listpersonne;
            lbFamillecustom.DataContext = listpersonne;
            dgBase.ItemsSource = listpersonne;
            dgFamille.DataContext = listpersonne;

            CustomPanel.Visibility = Visibility.Visible;

            System.Diagnostics.PresentationTraceSources.DataBindingSource.Switch.Level = System.Diagnostics.SourceLevels.Critical;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Ajouter une personne à la liste et regarder ce qui se passe
            listpersonne.Add(new Personne("Sparrow", "Jack", new DateTime(1985, 4, 21), @"Images\JackSparrow.png"));
        }

        private void ModifButton_Click(object sender, RoutedEventArgs e)
        {
            // Mettre les noms et prénoms en majuscule
            foreach (Personne p in listpersonne)
            {
                p.Nom = p.Nom.ToUpper();
                p.Prenom = p.Prenom.ToUpper();
            }

            CustomPanel.Visibility = Visibility.Visible;
        }
    }
}
