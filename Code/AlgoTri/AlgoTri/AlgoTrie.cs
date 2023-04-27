namespace AlgoTri
{
    public partial class AlgoTrie : Form
    {
        FrmInsert frmInsert = new FrmInsert();
        FrmBubble frmBubble = new FrmBubble();
        FrmSelect frmSelect = new FrmSelect();
        FrmComb frmComb = new FrmComb();
        FrmShell frmShell = new FrmShell();
        public AlgoTrie()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert.Show();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            frmBubble.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelect.Show();
        }

        private void btnComb_Click(object sender, EventArgs e)
        {
            frmComb.Show(); 
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            frmShell.Show();
        }

        private void AlgoTrie_Load(object sender, EventArgs e)
        {

        }
    }
}