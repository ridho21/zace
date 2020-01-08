using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

public class OpenFileDialogForm : Form
{
    [STAThread]
    public static void utama()
    {
        Application.SetCompatibleTextRenderingDefault(false);
        Application.EnableVisualStyles();
        Application.Run(new OpenFileDialogForm());
    }

    private Button selectButton;
    private OpenFileDialog openFileDialog1;

    public OpenFileDialogForm()
    {
        openFileDialog1 = new OpenFileDialog()
        {
            FileName = "Select a text file",
            Filter = "Text files (*.png)|*.png",
            Title = "Open text file"
        };

        selectButton = new Button()
        {
            Size = new Size(100, 20),
            Location = new Point(15, 15),
            Text = "Select file"
        };
        selectButton.Click += new EventHandler(selectButton_Click);
        Controls.Add(selectButton);
    }

    private void selectButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var filePath = openFileDialog1.FileName;
                using (Stream str = openFileDialog1.OpenFile())
                {
                    MessageBox.Show($"File Sudah Terupload\nTunggu Konfirmasi Selanjutnya\nAkan Dihubungi Lewat Email Atau Nomor HP");
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }
}