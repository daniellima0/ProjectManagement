using System;
using ProjectManagement.BLL;
using ProjectManagement.MODEL;

namespace ProjectManagement.APP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        // 1 - On the first time the app starts, iterate through the database and fill the list view
        // 2 - When the new project button is clicked -> opens up the New Project window.
        // If the Cancel button is pressed, closes the window
        // If the OK button is pressed, checks if all fields were added and if finish date > start date,
        // add a new item with the info inserted and closes the window
        // 3 - When the edit button is clicked -> opens up the Edit Project window which identic to the New Project
        // window but with the current info filled.
        // If Cancel button is pressed, closes the window
        // If OK button is pressed, update info of the respective project on the database and on the list view
        // 4 - When the delete button is clicked -> delete the project from the list view and from the database
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());
        }
    }
}