using AXVLC;
using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Wpf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using RestSharp;
using System.Diagnostics;





namespace App_Practica_de_vlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
           // vlcControl1.VlcMediaPlayer.TimeChanged += vlcControl1_TimeChanged;

        }
       

        private void Organizar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                OrganizarArchivos(path);
            }

            

            
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Multiselect = true; //Permite seleccionar varios archivos
            //openFileDialog.Filter = "Archivos de video y audio|*.mp4;*.avi;*.mp3;*.wav|Todos los archivos|*.*";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (string file in openFileDialog.FileNames)
            //    {
            //        listBox1.Items.Add(file); //Agrega cada archivo seleccionado al ListBox
            //    }
            //}

        }

        private void OrganizarArchivos(string path)
        {
            string[] files = Directory.GetFiles(path);

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string imagenesPath = Path.Combine(path, "Imágenes");
            string videosPath = Path.Combine(path, "Videos");
            string mp3Path = Path.Combine(path, "Música");
            string pdfPath = Path.Combine(path, "PDF");
            string excelPath = Path.Combine(path, "Excel");
            string otrosPath = Path.Combine(path, "Otros");


            Directory.CreateDirectory(imagenesPath);
            Directory.CreateDirectory(videosPath);
            Directory.CreateDirectory(mp3Path);
            Directory.CreateDirectory(pdfPath);
            Directory.CreateDirectory(excelPath);
            Directory.CreateDirectory(otrosPath);

            foreach (var file in files)
            {
                string extension = Path.GetExtension(file).ToLower();

                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                    case ".gif":
                        File.Move(file, Path.Combine(imagenesPath, Path.GetFileName(file)));
                        break;
                    case ".mp4":
                    case ".avi":
                    case ".mov":
                    case ".wmv":
                        File.Move(file, Path.Combine(videosPath, Path.GetFileName(file)));
                        break;
                    case ".mp3":
                        File.Move(file, Path.Combine(mp3Path, Path.GetFileName(file)));
                        break;
                    case ".pdf":
                        File.Move(file, Path.Combine(pdfPath, Path.GetFileName(file)));
                        break;
                    case ".xlsx":
                    case ".xls":
                        File.Move(file, Path.Combine(excelPath, Path.GetFileName(file)));
                        break;
                    default:
                        File.Move(file, Path.Combine(otrosPath, Path.GetFileName(file)));
                        break;
                }
            }

            MessageBox.Show("Los archivos han sido organizados en carpetas.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Archivos de Imagen|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                  listBoxArchivos.Items.Add(file);
               }
            }
      
            //try
            //{
            //    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            //    {
            //        string filePath = openFileDialog.FileName;
            //        vlcControl1.Play(new Uri(filePath));
            //   }
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}






        }

            private void button2_Click(object sender, EventArgs e)
        {



            


            btnplay.SendToBack();
            vlcControl1.Play();

            /*
            if (btnplay.Text == "Pause")
            {
                vlcControl1.Pause();
                btnplay.Text = "Play";
            }
            else if (btnplay.Text == "Play")
            {
                vlcControl1.Play();
                btnplay.Text = "Pause";
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.SendToBack();
            vlcControl1.Pause();
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            vlcControl1.Audio.Volume = trackBar2.Value * 10;
        }

      
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBoxArchivos.DisplayMember = "Name";
            if (listBoxArchivos.SelectedItem != null)
            {
                string rutaArchivo = listBoxArchivos.SelectedItem.ToString();
                vlcControl1.SetMedia(new FileInfo(rutaArchivo));
                vlcControl1.Play();
            }
            
            //if (listBox1.SelectedIndex >= 0) //Verifica que se haya seleccionado un archivo
            //{
            //    var vlcLibDirectory = new DirectoryInfo(@"C:\Program Files (x86)\VideoLAN\VLC");//Carpeta donde está instalado VLC
            //    var options = new string[] { };
            //    var mediaPlayer = new Vlc.DotNet.Core.VlcMediaPlayer(vlcLibDirectory, options);
            //    var mediaList = new Vlc.DotNet.Core.Medialist(mediaPlayer);
            //    foreach (string file in listBox1.Items) //Agrega todos los archivos a la lista de reproducción
            //    {
            //        mediaList.AddMedia(new Uri(file));
            //    }
            //    mediaList.PlayItem(listBox1.SelectedIndex);
            //}


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
      
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentFileIndex++; // aumenta el índice

            if (currentFileIndex >= listBoxArchivos.Items.Count) // si el índice es mayor o igual al número de elementos en el ListBox, significa que estamos en el último archivo, así que establece el índice en el primer archivo en el ListBox
            {
                currentFileIndex = 0;
            }

            string filePath = listBoxArchivos.Items[currentFileIndex].ToString(); // obtiene la ruta del archivo correspondiente al índice actual
            vlcControl1.SetMedia(new Uri(filePath)); // establece la ruta del archivo en el control de VLC
            vlcControl1.Play(); // reproduce el archivo en el control de VLC
        }

        private int currentFileIndex = 0;
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            currentFileIndex--; // disminuye el índice

            if (currentFileIndex < 0) // si el índice es menor a 0, significa que estamos en el primer archivo, así que establece el índice en el último archivo en el ListBox
            {
                currentFileIndex = listBoxArchivos.Items.Count - 1;
            }

            string filePath = listBoxArchivos.Items[currentFileIndex].ToString(); // obtiene la ruta del archivo correspondiente al índice actual
            vlcControl1.SetMedia(new Uri(filePath)); // establece la ruta del archivo en el control de VLC
            vlcControl1.Play(); // reproduce el archivo en el control de VLC
        }

        [Obsolete]
        private void btnletra_Click(object sender, EventArgs e)
        {
            // Abrir el diálogo para seleccionar un archivo MP3
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos MP3 (*.mp3)|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer los metadatos del archivo MP3
                    TagLib.File file = TagLib.File.Create(openFileDialog.FileName);
                    string artist = file.Tag.FirstArtist;
                    string title = file.Tag.Title;

                    // Obtener la letra de la canción desde la API de Lyrics.ovh
                    string url = $"https://api.lyrics.ovh/v1/{artist}/{title}";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    dynamic jsonData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);

                    // Mostrar la letra en el TextBox
                    textBox1.Text = jsonData.lyrics;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }

        private void listBoxArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 
}












