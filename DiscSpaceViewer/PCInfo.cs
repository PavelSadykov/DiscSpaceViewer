using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscSpaceViewer
{
    public class PCInfo
    {
        public double GetDiskFreeSpace(string driveName)
        {
            try
            {
                DriveInfo drive = new DriveInfo(driveName);
                if (drive.IsReady)
                {
                    return drive.TotalFreeSpace / (1024.0 * 1024.0 * 1024.0); // GB
                }
                return -1; 
            }
            catch (Exception)
            {
                return -2; 
            }
        }

        public double GetFolderSize(string folderPath)
        {
            long size = 0;

            try
            {
                foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                }
                return size / (1024.0 * 1024.0 * 1024.0); // GB
            }
            catch (Exception)
            {
                return -1; 
            }
        }

        public Color GetFillColor(double value)
        {
            if (value < 70)
                return Color.Green;
            else if (value < 85)
                return Color.Yellow;
            else
                return Color.Red;
        }
    }
}
