namespace SeleniumFramework
{
    public static class config
    {
        // The base URL
        public static string BaseURL = "https://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@gmail.com";
            }
            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacter = "AsdfAsdfAsdfAsdf";
                }

                public static class Password
                {
                    public static string WrongPassword = "12345";
                }

                public static class Email
                {
                    public static string WrongEmailAddress = "idk@yahoo.com";

                }
            }
        }

        public static class AlertMessages
        {
            public static string Successfullogin = "Succesful login!";
            public static string FailedLogin = "Failed Login";
        }
    }
}
