using MaterialSkin;
using System;
using System.Windows.Forms;

namespace NO._4
{
    public partial class SplashScreen : MaterialSkin.Controls.MaterialForm      //Nuget: Material Skin
        {
        public SplashScreen()
        {
                InitializeComponent();
                Application.EnableVisualStyles();
                StartPosition = FormStartPosition.CenterScreen;
                var skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
