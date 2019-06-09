namespace DavisSoftware.Constants
{
    public static class Views
    {
        public static class Layouts
        {
            public const string Main = "~/Views/Shared/_Layout.cshtml";
        }

        public static class Partials
        {
            public static class Organisms
            {
                public const string Header = "~/Views/Shared/Organisms/_Header.cshtml";
                public const string Navigation = "~/Views/Shared/Organisms/_Navigation.cshtml";
                public const string Footer = "~/Views/Shared/Organisms/_Footer.cshtml";
            }

            public static class Molecules
            {
                public const string HeaderScripts = "~/Views/Shared/Molecules/_HeaderScripts.cshtml";
                public const string FooterScripts = "~/Views/Shared/Molecules/_FooterScripts.cshtml";
                public const string ProgressBar = "~/Views/Shared/Molecules/_ProgressBar.cshtml";
            }
        }

    }
}