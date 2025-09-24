namespace PA_3_Tri_av1___individual
{
    public partial class FormSharedValues : Form
    {
        public static FormSharedValues Instance;
        public FormSharedValues()
        {
            InitializeComponent();
            Instance = this;
        }
        public string usuario;
        private void FormSharedValues_Load(object sender, EventArgs e)
        {

        }
    }
}
