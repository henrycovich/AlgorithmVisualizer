using System;

public class Class1
{
    private void CmdOrdina_Click(object sender, EventArgs e)
    {
        string alg = "";

        if (cboAlg.SelectedItem != null)
            alg = cboAlg.SelectedItem.ToString();

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
}
