namespace AlgoTri
{
    public partial class AlgoTri : Form
    {
        FrmInsert frmInsert;
        FrmBubble frmBubble;
        FrmSelect frmSelect;
        FrmComb frmComb;
        FrmShell frmShell;
        public AlgoTri()
        {  
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert = new FrmInsert();
            frmInsert.Show();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            frmBubble = new FrmBubble();
            frmBubble.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelect = new FrmSelect();
            frmSelect.Show();
        }

        private void btnComb_Click(object sender, EventArgs e)
        {
            frmComb = new FrmComb();
            frmComb.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            frmShell = new FrmShell();
            frmShell.Show();
        }

        private void AlgoTrie_Load(object sender, EventArgs e)
        {

        }
    }
}