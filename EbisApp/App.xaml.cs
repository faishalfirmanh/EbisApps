namespace EbisApp
{
    public partial class App : Application
    {
        public App()
        {
           
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAwOTgwMkAzMjM0MmUzMDJlMzBWamJVOUcreGdOOFZ0RG0zaTdycUxOOHo3Q0dzTTV1bzhQOUt5VDVmZFB3PQ==");
            MainPage = new AppShell();
        }
    }
}