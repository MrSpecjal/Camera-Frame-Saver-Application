using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CameraSaver
{
    public partial class CameraSaver : Form
    {
        private FilterInfoCollection devices;
        private List<VideoCaptureDevice> videoSources = new List<VideoCaptureDevice>();
        Dictionary<int, Bitmap> camerasVideoBuffer = new Dictionary<int, Bitmap>();

        private int framesToSave = 0;

        public CameraSaver()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            try
            {
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.HeaderText = "Image";
                img.ImageLayout = DataGridViewImageCellLayout.Zoom;

                preview.SizeMode = captured.SizeMode = PictureBoxSizeMode.Zoom;

                Frames.Columns.Add("ID", "ID");
                Frames.Columns.Add("Device", "Device");
                Frames.Columns.Add("DeviceID", "Device ID");
                Frames.Columns.Add("Date", "Date");
                Frames.Columns.Add(img);
                Frames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Frames.RowTemplate.MinimumHeight = 105;
                Frames.ReadOnly = true;

                Frames.AllowUserToAddRows = false;

                savingMode.SelectedIndex = 1;
                formats.SelectedIndex = 4;
                menuFormats.SelectedIndex = 4;

                cameraDevices.DropDownStyle = savingMode.DropDownStyle = formats.DropDownStyle = menuFormats.DropDownStyle = menuDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetCamera()
        {
            for (int i = 0; i < videoSources.Count; i++)
            {
                videoSources[i].Stop();
            }

            preview.Image = null;
            preview.Invalidate();
            captured.Image = null;
            captured.Invalidate();
        }

        private void CameraSaver_Load(object sender, EventArgs e)
        {
            try
            {
                devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo device in devices)
                {
                    cameraDevices.Items.Add(device.Name);
                    menuDevices.Items.Add(device.Name);
                }

                for (int i = 0; i < devices.Count; i++)
                {
                    videoSources.Add(new VideoCaptureDevice(devices[i].MonikerString));
                }

                cameraDevices.SelectedIndex = 0;
                menuDevices.SelectedIndex = 0;
                cameraPageName.Text = $"Current Camera:{devices[cameraDevices.SelectedIndex].Name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                videoSources.Add(new VideoCaptureDevice(devices[i].MonikerString));
                if(savingMode.SelectedIndex == 0)
                    videoSources[i].NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                if(savingMode.SelectedIndex == 1)
                videoSources[i].NewFrame += new NewFrameEventHandler(VideoSource_MultipleFrames);
                videoSources[i].Start();
            }
        }

        private void CaptureFromAllCameras()
        {
            ResetCamera();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            preview.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void VideoSource_MultipleFrames(object sender, NewFrameEventArgs eventArgs)
        {
            if (camerasVideoBuffer[GetCameraId(sender as VideoCaptureDevice)] == null)
                camerasVideoBuffer.Add(GetCameraId(sender as VideoCaptureDevice), (Bitmap)eventArgs.Frame.Clone());
            else
                camerasVideoBuffer[GetCameraId(sender as VideoCaptureDevice)] = (Bitmap)eventArgs.Frame.Clone();
        }

        int GetCameraId(VideoCaptureDevice camera)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                if (videoSources[i] == camera)
                    return i;
            }
            return 0;
        }

        private void Stop_button_Click(object sender, EventArgs e) => ResetCamera();

        private void Pause_button_Click(object sender, EventArgs e) => videoSources[cameraDevices.SelectedIndex].Stop();

        private void Capture_button_Click(object sender, EventArgs e)
        {
            if (preview.Image == null)
            {
                Start_button_Click(sender, e);
                MessageBox.Show("Before capturing camera view, switch on device!");
                return;
            }
            if (savingMode.SelectedIndex == 1)
            {
                captured.Image = (Bitmap)preview.Image.Clone();
                try
                {
                    DateTime captureDate = DateTime.Now;
                    string dateFormated = captureDate.ToString("MM-dd-yyyy_HH-mm-ss");

                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    Frames.Rows.Add(Frames.Rows.Count.ToString(), cameraDevices.Text, cameraDevices.SelectedIndex, dateFormated, captured.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (savingMode.SelectedIndex == 0)
            {
                for (int i = 0; i < devices.Count; i++)
                {
                    int currentSelect = cameraDevices.SelectedIndex;
                    cameraDevices.SelectedIndex = i;
                    captured.Image = camerasVideoBuffer[i];
                    try
                    {
                        DateTime captureDate = DateTime.Now;
                        string dateFormated = captureDate.ToString("MM-dd-yyyy_HH-mm-ss");

                        DataGridViewImageColumn img = new DataGridViewImageColumn();

                        Frames.Rows.Add(Frames.Rows.Count.ToString(), cameraDevices.Text, i, dateFormated, captured.Image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    cameraDevices.SelectedIndex = currentSelect;
                }
            }
        }

        private void CaptureAll_button_Click(object sender, EventArgs e)
        {
            framesToSave = (int)framesToCapture.Value;
            savingInterval.Interval = 1000 / videoSources[cameraDevices.SelectedIndex].VideoCapabilities[0].MaximumFrameRate;
            savingInterval.Enabled = true;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                if (videoSources[i].IsRunning)
                    videoSources[i].Stop();
            }
            Application.Exit(null);
        }

        private void cameraDevices_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                if (videoSources[i] != null)
                    videoSources[i].Stop();
            }
        }

        private void savingInterval_Tick(object sender, EventArgs e)
        {
            if (framesToSave <= 0)
            {
                savingInterval.Enabled = false;
                return;
            }
            framesToSave--;
            Capture_button_Click(sender, e);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Frames.Rows.Count == 0)
                return;

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    for (int i = 0; i < Frames.Rows.Count; i++)
                    {
                        ImageFormat imageFormat;
                        string filename = $"{fbd.SelectedPath}\\Kamera_{Frames.Rows[i].Cells[2].Value}_{Frames.Rows[i].Cells[3].Value}_Id_{Frames.Rows[i].Cells[0].Value}.{GetFormat(formats.SelectedIndex, out imageFormat)}";

                        Bitmap picture = (Bitmap)Frames.Rows[i].Cells[4].Value;
                        picture.Save(filename, imageFormat);
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e) => Frames.Rows.Clear();

        private void formats_SelectedIndexChanged(object sender, EventArgs e) => menuFormats.SelectedIndex = formats.SelectedIndex;

        private void menuFormats_SelectedIndexChanged(object sender, EventArgs e) => formats.SelectedIndex = menuFormats.SelectedIndex;

        private void menuDevices_SelectedIndexChanged(object sender, EventArgs e) => cameraDevices.SelectedIndex = menuDevices.SelectedIndex;

        private void cameraDevices_SelectedIndexChanged(object sender, EventArgs e) => menuDevices.SelectedIndex = cameraDevices.SelectedIndex;

        private string GetFormat(int formatIndex, out ImageFormat imageFormat)
        {
            switch (formatIndex)
            {
                default:
                    imageFormat = ImageFormat.Png;
                    return "png";
                case 0:
                    imageFormat = ImageFormat.Bmp;
                    return "bmp";
                case 1:
                    imageFormat = ImageFormat.Gif;
                    return "gif";
                case 2:
                    imageFormat = ImageFormat.Icon;
                    return "ico";
                case 3:
                    imageFormat = ImageFormat.Jpeg;
                    return "jpeg";
                case 4:
                    imageFormat = ImageFormat.Png;
                    return "png";
                case 5:
                    imageFormat = ImageFormat.Tiff;
                    return "tiff";
            }
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Author: Szymon Miś\nhttps://szymon-mis.pl");

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Small program for capturing camera view for single and multiple devices.");
    }
}
