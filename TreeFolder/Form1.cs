namespace TreeFolder
{
    public partial class Form1 : Form
    {
        DirectoryInfo curDir;
        public Form1()
        {
            InitializeComponent();

            foreach (var Drives in Environment.GetLogicalDrives())
            {
                DriveInfo DriveInf = new DriveInfo(Drives);
                if (DriveInf.IsReady == true)
                {
                    cbbThuMuc.Items.Add(DriveInf.Name);
                }
            }


        }
        public String selectedOdia
        {
            get { return cbbThuMuc.SelectedItem as String; }
        }
        private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThuMuc.SelectedItem != null)
            {
                ListDirectory(twThuMuc, cbbThuMuc.SelectedItem.ToString());
            }

        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                    directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            catch (Exception ex)
            {
                UnauthorizedAccessException Uaex = new UnauthorizedAccessException();
                if (ex == Uaex)
                {
                    MessageBox.Show(Uaex.Message);
                }
            }
            return directoryNode;
        }

        private void twThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*  lwThuMuc.Items.Clear();
              lwThuMuc.Refresh();
              PopulateListBox(lwThuMuc, twThuMuc.SelectedNode.FullPath.ToString(), "*.pdf");*/
            TreeNode selectedNode = twThuMuc.SelectedNode;
            MessageBox.Show($"{selectedNode.FullPath}");

            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };

            lwThuMuc.Items.Clear();
            //Lay thong tin cua thu muc do
            DirectoryInfo directory = new DirectoryInfo(selectedNode.FullPath);

            //Lay danh sach file trong thu muc do (ko tinh cac thu muc con)
            var listFile = directory.GetFiles();

            //Show danh sach file ra listview
            foreach (var file in listFile)
            {
             
                if (exts.Contains(file.Extension.ToLower()))
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    item.SubItems.Add(file.Length.ToString());
                   
                    lwThuMuc.Items.Add(item);
                }

            }

            selectedNode.Expand();

        }

        private void lwThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lwThuMuc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItems = lwThuMuc.SelectedItems[0];

            var imagePath = selectedItems.SubItems[1].Text;

            frmDetail f = new frmDetail(imagePath);
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmSlideShow frm = new frmSlideShow(lwThuMuc);
            frm.ShowDialog();
        }
    }
}