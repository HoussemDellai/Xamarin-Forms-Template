using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTemplate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [ContentProperty("Child")]
    public partial class MainTemplate : ContentView
    {
        public MainTemplate()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get => HeaderLabel.Text;
            set => HeaderLabel.Text = value;
        }

        public View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }

        public View Footer
        {
            get => FooterContent.Content;
            set => FooterContent.Content = value;
        }
    }
}