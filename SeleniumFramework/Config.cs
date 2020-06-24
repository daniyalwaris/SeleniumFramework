

namespace SeleniumFramework
{
    public static class config
    {
        public static string BaseURL = "http://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "";
                public static string Password = "";
                public static string RepeatPassword = "";
                public static string Email = "";
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
    }
}
