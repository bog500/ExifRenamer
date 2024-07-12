using MetadataExtractor.Formats.Exif;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ExifRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Log("Rename starting");
            try
            {
                string imagePath = txtPath.Text;

                var files = Directory.GetFiles(imagePath);
                Log("Opening folder " + imagePath);
                foreach (var file in files)
                {
                    try
                    {
                        if (!file.ToLower().EndsWith(".jpeg") && !file.ToLower().EndsWith(".jpg"))
                        {
                            Log("Skipping non-jpeg file " + file);
                            continue;
                        }

                        DateTime date = GetExifDate(file);
                        DateTime adjustedDate = AdjusteDate(date);
                        string newfile = GetNewFilename(file, adjustedDate);

                        Log($"Renaming {file} to {newfile}");
                        File.Move(file, newfile);
                    }
                    catch(Exception ex)
                    {
                        Log(ex);
                    }
                }
            }
            catch(Exception ex)
            {
                Log(ex);
            }
            
        }

        private void Log(Exception ex)
        {
            Log(ex.Message);
            Log(ex.StackTrace);
            if (!(ex.InnerException is null))
                Log(ex.InnerException);
        }

        private DateTime AdjusteDate(DateTime date)
        {
            if (date == DateTime.MinValue || date == DateTime.MaxValue)
                return date;

            DateTime old = date;
            date = date
                .AddDays((int)NumDeltaDay.Value)
                .AddHours((int)NumDeltaHour.Value)
                .AddMinutes((int)NumDeltaMinute.Value)
                .AddSeconds((int) NumDeltaSecond.Value)
                ;

            if (!date.Equals(old))
                Log($"Date adjusted from {old.ToString("yyyy-MM-dd HH:mm:ss")} to {old.ToString("yyyy-MM-dd HH:mm:ss")}");

            return date;
        }

        private void Log(string txt)
        {
            txtLog.Text += "\r\n[" + DateTime.Now.ToString("HH:mm:ss") + "] " + txt;
        }

        private string GetNewFilename(string filepath, DateTime date)
        {
            string oldfilename = Path.GetFileName(filepath);
            string path = Path.GetDirectoryName(filepath);

            string format = dropFormat.Text;
            string newFileName = date.ToString(format) + oldfilename;
            string newFilepath = Path.Combine(path, newFileName);

            return newFilepath;
        }

        private DateTime ParseDate(string str)
        {
            try
            {
                string strDt = str;
                string strHr = "00:00:00";
                if (str.Length == 19)
                {
                    strDt = str.Substring(0, 10);
                    strHr = str.Substring(11, 8);
                }
                strDt = strDt.Replace(":", "-");
                DateTime d = DateTime.Parse(strDt + " " + strHr);
                return d;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        private DateTime GetExifDate(string filepath, bool logInfo = false)
        {
            DateTime date1 = DateTime.MinValue;
            DateTime date2 = DateTime.MinValue;
            DateTime date3 = DateTime.MinValue;
            DateTime date4 = DateTime.MinValue;

            IEnumerable<MetadataExtractor.Directory> directories = MetadataExtractor.ImageMetadataReader.ReadMetadata(filepath);

            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    bool tagFound = true;
                    if (tag.Name == "Date/Time Original")
                        date1 = ParseDate(tag.Description);
                    else if (tag.Name == "Date/Time Digitized")
                        date2 = ParseDate(tag.Description);
                    else if (tag.Name == "Date/Time")
                        date3 = ParseDate(tag.Description);
                    else if (tag.Name == "GPS Date Stamp")
                        date4 = ParseDate(tag.Description);
                    else
                        tagFound = false;


                    if (tagFound && logInfo)
                        Log($"{directory.Name} - {tag.Name} = {tag.Description}");
                }
            }

            if (date1 != DateTime.MinValue)
                return date1;

            if (date2 != DateTime.MinValue)
                return date2;

            if (date3 != DateTime.MinValue)
                return date3;

            if (date4 != DateTime.MinValue)
                return date4;

            throw new Exception("Date Exif not found for " + filepath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "version " + Assembly.GetEntryAssembly().GetName().Version.ToString();
            Log("Program starting");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Log("Info starting");
            try
            {
                string imagePath = txtPath.Text;

                var files = Directory.GetFiles(imagePath);
                Log("Opening folder " + imagePath);
                foreach (var file in files)
                {
                    try
                    {
                        if (!file.ToLower().EndsWith(".jpeg") && !file.ToLower().EndsWith(".jpg"))
                        {
                            Log("Skipping non-jpeg file " + file);
                            continue;
                        }
                        Log("Analyzing " + file);
                        GetExifDate(file, true);

                    }
                    catch (Exception ex)
                    {
                        Log(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }
    }
}
