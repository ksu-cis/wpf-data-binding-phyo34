using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UniversityRegistry.Data;
using System.Collections.ObjectModel;



namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl


    {

        /// <summary>
        /// A proxy event handler
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged;

        public PersonList()
        {
            InitializeComponent();

        }
    

        /// <summary>
        /// A proxy event listener that passes on SelectionChanged events
        /// </summary>
        /// <param name="sender">The ListView that had its selection changed</param>
        /// <param name="e">The event arguments</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }


        /// <summary>
        /// Event listener that listens for changes
        /// </summary>
        /// <param name="sender">Changes made to data</param>
        /// <param name="e">The event argument</param>
        private void AddNewPersonButtonClick(object sender, RoutedEventArgs e)
        {
            var person = new Person();
            person.FirstName = "First";
            person.LastName = "Last";
            person.Role = Role.Staff;
            person.DateOfBirth = DateTime.Now;
            person.Active = true;

            if (DataContext is ObservableCollection<Person> people)
            {
                people.Add(person);
            }
        }
    }
}
