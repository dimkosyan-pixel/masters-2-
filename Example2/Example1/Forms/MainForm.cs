using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1.Forms
{
    public partial class MainForm : Form
    {
        private List<string> imagePathes = new List<string>();
        private List<double> expectedResults = new List<double>();
        private List<int> blackWhitePixels;
        private PictureConverter pictureConverter = new PictureConverter();

        private int currentIndex = -1;

        private NeuralNetwork neuralNetwork;

        public MainForm()
        {
            InitializeComponent();
            nudHiddenLayerCount.Value = PictureConverter.DEFAULT_CONVERTED_IMAGE_SIZE / 5;
            nudImageSide.Value = PictureConverter.DEFAULT_CONVERTED_IMAGE_SIDE;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                ShowImage(currentIndex - 1);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePathes.Count - 1)
            {
                ShowImage(currentIndex + 1);
            }
        }

        private void btnSaveCurrent_Click(object sender, EventArgs e)
        {
            SaveExpectedResult();
        }

        // покажет изображение в pictureBox и изменит значение в text box
        private void ShowImage(int index)
        {
            currentIndex = index;
            pbImage.ImageLocation = imagePathes[index];
            tbExpectedResult.Text = expectedResults[index].ToString();


            var imageSide = (int)nudImageSide.Value;
            pictureConverter.ConvertedImageSide = imageSide;
            blackWhitePixels = pictureConverter.Convert(imagePathes[currentIndex]);
            pbBlackWhite.Image = pictureConverter.ToBitmap(blackWhitePixels);

            lblFilePath.Text = imagePathes[index];
            lblCurrentIndex.Text = (index + 1).ToString();
            lblTotal.Text = imagePathes.Count.ToString();
            lblResult.Visible = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdInputFile.ShowDialog() == DialogResult.OK)
            {
                imagePathes.Add(ofdInputFile.FileName);
                expectedResults.Add(1);
                ShowImage(imagePathes.Count - 1);
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fbdInputFolder.ShowDialog() == DialogResult.OK)
            {
                var fileNames = Directory.GetFiles(fbdInputFolder.SelectedPath);
                var lastIndex = imagePathes.Count;
                foreach (var fileName in fileNames)
                {
                    imagePathes.Add(fileName);
                    expectedResults.Add(1);
                }
                ShowImage(lastIndex);
            }
        }

        private void SaveExpectedResult()
        {
            try
            {
                expectedResults[currentIndex] = Convert.ToDouble(tbExpectedResult.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // избавляюсь от сглаживания картинки
        private void pbBlackWhite_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            if (pbBlackWhite.Image != null)
            {
                var imageRectangle = new Rectangle(0, 0, pbBlackWhite.Width, pbBlackWhite.Height);
                e.Graphics.DrawImage(pbBlackWhite.Image, imageRectangle);
            }
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            if (pbImage.Image != null)
            {
                var imageRectangle = new Rectangle(0, 0, pbBlackWhite.Width, pbBlackWhite.Height);
                e.Graphics.DrawImage(pbImage.Image, imageRectangle);
            }
        }

        private async void btnLearn_Click(object sender, EventArgs e)
        {
            var hiddenLayerCount = (int)nudHiddenLayerCount.Value;
            var epochCount = (int)nudEpochCount.Value;
            double learningRate = 0.1;

            try
            {
                learningRate = Convert.ToDouble(tbLearningRate.Text);
                if (learningRate > 0)
                {
                    var imageSide = (int)nudImageSide.Value;
                    var imageSize = imageSide * imageSide;
                    pictureConverter.ConvertedImageSide = imageSide;
                    var inputs = GetData(imageSize);

                    var topology = new Topology(imageSize, 1, learningRate, hiddenLayerCount);
                    neuralNetwork = new NeuralNetwork(topology);

                    StartLoading();
                    await Learn(expectedResults.ToArray(), inputs, epochCount);
                    MessageBox.Show("Learning ended");
                    StopLoading();
                }
                else
                {
                    MessageBox.Show("Learning rate should be greater then 0");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Task Learn(double[] expected, double[,] inputs, int epochCount)
        {
            return Task.Run(() =>
            {
                neuralNetwork.Learn(expected, inputs, epochCount);
            });
        }

        private void StartLoading()
        {
            // выключает кнопку для показа результатов и добавления записи
            btnLearn.Enabled = false;
            btnShowResults.Enabled = false;
        }

        private void StopLoading()
        {
            btnLearn.Enabled = true;
            btnShowResults.Enabled = true;
        }

        private double[,] GetData(int imageSize)
        {
            var size = imagePathes.Count;
            var result = new double[size, imageSize];
            for (int i = 0; i < size; i++)
            {
                var image = pictureConverter.Convert(imagePathes[i]);
                for (int j = 0; j < image.Count; j++)
                {
                    result[i, j] = image[j];
                }
            }
            return result;
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            var result = neuralNetwork.Predict(blackWhitePixels.Select(t => (double)t).ToArray());
            lblResult.Text = Math.Round(result.Output, 2).ToString();
            lblResult.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
