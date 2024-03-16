using FlowingIdeas.Presentation;
namespace FlowingIdeas
{
    public static class StartUp
    {
        /// <summary>
        ///  This is an app in which you can write and save your ideas 
        ///  in the following categories: artistic, work, philosophical.
        ///  It uses the entity framework and Microsoft SQL Server.
        ///  It requiers a username and a password.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Display display = new Display();
            ApplicationConfiguration.Initialize();
            Application.Run(new FlowingIdeasForm());
        }
    }
<<<<<<< Updated upstream
}//Test :)
=======
}
>>>>>>> Stashed changes
