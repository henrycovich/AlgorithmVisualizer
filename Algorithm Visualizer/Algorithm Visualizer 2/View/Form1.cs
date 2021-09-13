using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Algorithm_Visualizer_2
{
    public partial class Form1 : Form
    {
        Bitmap bmpsave1;
        Graphics g1;
        ArrayList ArrayToSort;
        
        static Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void Randomize(IList list) // Metodo che genera valori casuali da ordinare
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int swapIndex = rng.Next(i + 1);
                if (swapIndex != i)
                {
                    object tmp = list[swapIndex];
                    list[swapIndex] = list[i];
                    list[i] = tmp;
                }
            }
        }

        private void DrawSamples() //Metodo per rappresentare graficamente i valori da ordinare
        {
            g1.Clear(Color.White);

            for (int i = 0; i < ArrayToSort.Count; i++)
            {
                int x = (int)(((double)pnlSort.Width / ArrayToSort.Count) * i);

                Pen pen = new Pen(Color.Black);
                g1.DrawLine(pen, new Point(x, pnlSort.Height), new Point(x, (int)(pnlSort.Height - Convert.ToInt32(ArrayToSort[i]))));
            }
        }

        private void CmdGenera_Click(object sender, EventArgs e)
        {
            bmpsave1 = new Bitmap(pnlSort.Width, pnlSort.Height); // crea una classe bitmap delle dimensioni del picturebox
            g1 = Graphics.FromImage(bmpsave1); // crea un oggetto Graphics dall'immagine bitmap appena creata
            pnlSort.Image = bmpsave1;

            ArrayToSort = new ArrayList(tbElementi.Value);
            for (int i = 0; i < ArrayToSort.Capacity; i++)
            {
                int y = (int)((double)i / ArrayToSort.Capacity * pnlSort.Height);
                ArrayToSort.Add(y);
            }
            Randomize(ArrayToSort);
            DrawSamples();
        }

        private void CmdOrdina_Click(object sender, EventArgs e)
        {
            string alg = "";
            if (cboAlg.SelectedItem != null)
            {
                alg = cboAlg.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Seleziona un algoritmo di ordinamento!");
                return;
            }
            Algoritmi sa = new Algoritmi(ArrayToSort, pnlSort, true, alg);
            ThreadStart ts = delegate ()
            {
                try
                {
                    switch (alg)
                    {
                        case "Bubble Sort":
                            sa.BubbleSort(ArrayToSort);
                            break;
                        case "Heap Sort":
                            sa.HeapSort(ArrayToSort);
                            break;
                        case "Insertion Sort":
                            sa.InsertionSort(ArrayToSort);
                            break;
                        case "Merge Sort":
                            sa.MergeSort(ArrayToSort, 0, ArrayToSort.Count - 1);
                            break;
                        case "Quick Sort":
                            sa.QuickSort(ArrayToSort, 0, ArrayToSort.Count - 1);
                            break;
                        case "Selection Sort":
                            sa.SelectionSort(ArrayToSort);
                            break;
                    }
                    MessageBox.Show("Ordinamento completato!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            };
            if (alg != "")
            {
                Thread t = new Thread(ts);
                t.Start();
            }
        }

        private void CmdEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSalva_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            foreach (var arrayElement in ArrayToSort)
            {
                stringBuilder.AppendLine(arrayElement.ToString());
            }
            try
            {
                File.WriteAllText(@"C:\array.txt", stringBuilder.ToString());
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CmdRiprendi_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\array.txt")){
                MessageBox.Show("Il file è stato trovato");
                string[] stringArray = System.IO.File.ReadAllLines(@"C:\array.txt");
                int[] intArray = Array.ConvertAll(stringArray, int.Parse);
                ArrayToSort = new ArrayList(intArray);
                bmpsave1 = new Bitmap(pnlSort.Width, pnlSort.Height); // crea una classe bitmap delle dimensioni del picturebox
                g1 = Graphics.FromImage(bmpsave1); // crea un oggetto Graphics dall'immagine bitmap appena creata
                pnlSort.Image = bmpsave1;
                DrawSamples();
            }
            else
            {
                MessageBox.Show("Impossibile trovare il file");
            }
        
        }

        private void tbElementi_Scroll(object sender, EventArgs e)
        {

        }
        
    }
}