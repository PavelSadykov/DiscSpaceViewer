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
        private PCInfo pcInfo;
        private Timer timer;
        public MainForm()
        {
            InitializeComponent();
            pcInfo = new PCInfo();
            timer = new Timer();
            timer.Interval = 5000; // 5 сек
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            double freeSpaceC = pcInfo.GetDiskFreeSpace("C");
            double freeSpaceD = pcInfo.GetDiskFreeSpace("D");

            progressBarC.Value = (int)((1 - (freeSpaceC / 100)) * 100);
            progressBarC.BackColor = pcInfo.GetFillColor(progressBarC.Value);
            labelC.Text = $"C: {freeSpaceC:N2} GB свободно";

             progressBarD.Value = (int)((1 - (freeSpaceD / 100)) * 100);
             progressBarD.BackColor = pcInfo.GetFillColor(progressBarD.Value);
             labelD.Text = $"D: {freeSpaceD:N2} GB свободно";
            
              double tempFolderSize = pcInfo.GetFolderSize(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp"));
              double downloadsFolderSize = pcInfo.GetFolderSize(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Загрузки");
              double appDataFolderSize = pcInfo.GetFolderSize(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
              double desktopFolderSize = pcInfo.GetFolderSize(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            
            labelTemp.Text = $"Temp: {tempFolderSize:N2} GB";
            labelDownloads.Text = $"Загрузки: {downloadsFolderSize:N2} GB";
            labelAppData.Text = $"AppData: {appDataFolderSize:N2} GB";
            labelDesktop.Text = $"Рабочий стол: {desktopFolderSize:N2} GB";
          
            // Всплывающие подсказки 
            toolTip1.SetToolTip(progressBarC, $"C: {freeSpaceC:N2} GB свободно");
            toolTip1.SetToolTip(progressBarD, $"D: {freeSpaceD:N2} GB свободно");
            toolTip1.SetToolTip(labelTemp, $"Temp: {tempFolderSize:N2} GB");
            toolTip1.SetToolTip(labelDownloads, $"Загрузки: {downloadsFolderSize:N2} GB");
            toolTip1.SetToolTip(labelAppData, $"AppData: {appDataFolderSize:N2} GB");
            toolTip1.SetToolTip(labelDesktop, $"Рабочий стол: {desktopFolderSize:N2} GB");
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