using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string registrationNumber = txtRegistrationNumber.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string favoriteMovie = txtFavoriteMovie.Text;
            string excludedChar = txtExcludedChar.Text;

            // Generate password and display it
            string password = generatePassword(registrationNumber, firstName, lastName, favoriteMovie, excludedChar);
            txtPassword.Text = password;
        }


        private string generatePassword(string registrationNumber, string firstName, string lastName, string favoriteMovie, string excludedChar)
        {
            // Ensure the registration number is at least 2 digits
            if (registrationNumber.Length < 2)
            {
                throw new Exception("Registration number must be at least 2 digits.");
            }

            // Extract required parts
            string digits = registrationNumber.Substring(0, 2); // First 2 digits of the registration number
            char secondLetterFirstName = firstName.Length > 1 ? firstName[1] : ' '; // Second letter from the first name
            char secondLetterLastName = lastName.Length > 1 ? lastName[1] : ' '; // Second letter from the last name

            // Ensure the favorite movie has at least 2 characters
            if (favoriteMovie.Length < 2)
            {
                throw new Exception("Favorite movie must have at least 2 characters.");
            }

            string movieChars = favoriteMovie.Substring(0, 2); // First 2 characters of the favorite movie

            // Create a list of special characters, excluding the specified one
            string specialChars = "!@#$%^&*()_+[]{}|;:',.<>?/~`";

            // Ensure excludedChar is at least one character
            if (string.IsNullOrEmpty(excludedChar) || excludedChar.Length > 1)
            {
                throw new Exception("Please provide a single special character to exclude.");
            }

            string availableSpecialChars = specialChars.Replace(excludedChar[0], ' '); // Exclude the specified character

            // Check if there are available special characters after exclusion
            if (string.IsNullOrWhiteSpace(availableSpecialChars))
            {
                throw new Exception("No available special characters to use.");
            }

            Random random = new Random();
            char specialChar = availableSpecialChars[random.Next(availableSpecialChars.Length)]; // Select a random special character

            // Combine all parts
            string password = $"{digits}{secondLetterFirstName}{secondLetterLastName}{movieChars}{specialChar}";

            // Ensure the password length is 14
            while (password.Length < 14)
            {
                password += random.Next(0, 10).ToString(); // Adding random digits to reach 14 characters
            }

            // Randomize the password
            char[] passwordArray = password.ToCharArray();
            Array.Sort(passwordArray, (x, y) => random.Next(-1, 2)); // Shuffle the password
            password = new string(passwordArray);

            // Ensure the final password length is 14 and does not contain excluded character
            password = password.Length > 14 ? password.Substring(0, 14) : password.Replace(excludedChar[0], ' ');

            return password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
