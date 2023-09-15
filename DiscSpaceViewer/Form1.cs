using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiscSpaceViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Отображение информации о дисках C: и D
            DriveInfo driveC = new DriveInfo("C");
            DriveInfo driveD = new DriveInfo("D");

            double totalSpaceC = driveC.TotalSize;
            double freeSpaceC = driveC.TotalFreeSpace;

            double totalSpaceD = driveD.TotalSize;
            double freeSpaceD = driveD.TotalFreeSpace;

            progressBarC.Value = (int)((totalSpaceC - freeSpaceC) / totalSpaceC * 100);
           progressBarD.Value = (int)((totalSpaceD - freeSpaceD) / totalSpaceD * 100);

            labelC.Text = $"C: {freeSpaceC / (1024 * 1024 * 1024):N2} GB свободно";
           labelD.Text = $"D: {freeSpaceD / (1024 * 1024 * 1024):N2} GB свободно";

            // Отображение информации о размере папок
            string tempFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp");
            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Загрузки";
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string desktopFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            double tempFolderSize = GetFolderSize(tempFolderPath) / (1024 * 1024 * 1024);
            double downloadsFolderSize = GetFolderSize(downloadsFolderPath) / (1024 * 1024 * 1024);
            double appDataFolderSize = GetFolderSize(appDataFolderPath) / (1024 * 1024 * 1024);
            double desktopFolderSize = GetFolderSize(desktopFolderPath) / (1024 * 1024 * 1024);

            labelTemp.Text = $"Temp: {tempFolderSize:N2} GB";
            labelDownloads.Text = $"Загрузки: {downloadsFolderSize:N2} GB";
            labelAppData.Text = $"AppData: {appDataFolderSize:N2} GB";
            labelDesktop.Text = $"Рабочий стол: {desktopFolderSize:N2} GB";
        }
        //метод получения раз-ра папки
        private long GetFolderSize(string folderPath)
        {
            long size = 0;

            try
            {
                foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении размера папки: {ex.Message}");
            }

            return size;
        }
    }
}