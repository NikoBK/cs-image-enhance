using Emgu.CV;
using Emgu.CV.Structure;

namespace VideoEnhancer
{
    public partial class ImageProcessor : Form
    {
        public Image Image { get; private set; }

        public ImageProcessor()
        {
            InitializeComponent();
        }

        public void CacheFrame(Image img)
        {
            Image = img;
            SetImage(Image);
        }

        private void SetImage(Image img)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = img;
        }
    }
}
