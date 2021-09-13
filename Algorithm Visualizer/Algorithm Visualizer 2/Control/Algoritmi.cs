using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace Algorithm_Visualizer_2
{
    public class Algoritmi
    {
        ArrayList arrayToSort;
        Graphics g;
        Bitmap bmpsave;
        PictureBox pnlSamples;

        public Algoritmi(ArrayList list, PictureBox pic, bool sp, string outFile)
        {
            arrayToSort = list;
            pnlSamples = pic;
            bmpsave = new Bitmap(pnlSamples.Width, pnlSamples.Height);
            g = Graphics.FromImage(bmpsave);
            pnlSamples.Image = bmpsave;
            DrawSamples();
        }

        public IList BubbleSort(IList arrayToSort)
        {
            int n = arrayToSort.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    if (((IComparable)arrayToSort[j - 1]).CompareTo(arrayToSort[j]) > 0)
                    {
                        object temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                        RedrawItem(j);
                        RedrawItem(j - 1);
                        RefreshPanel(pnlSamples);
                    }
                }
            }
            return arrayToSort;
        }

        public IList HeapSort(IList list)
        {
            for (int i = (list.Count - 1) / 2; i >= 0; i--)
            {
                Adjust(list, i, list.Count - 1);
            }
            for (int i = list.Count - 1; i >= 1; i--)
            {
                object Temp = list[0];
                list[0] = list[i];
                list[i] = Temp;
                RedrawItem(0);
                RedrawItem(i);
                RefreshPanel(pnlSamples);
                Adjust(list, 0, i - 1);
            }
            return list;
        }

        public void Adjust(IList list, int i, int m)
        {
            object Temp = list[i];
            int j = i * 2 + 1;
            while (j <= m)
            {
                if (j < m)
                    if (((IComparable)list[j]).CompareTo(list[j + 1]) < 0)
                        j += j;
                if (((IComparable)Temp).CompareTo(list[j]) < 0)
                {
                    list[i] = list[j];
                    RedrawItem(i);
                    RefreshPanel(pnlSamples);
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    j = m + 1;
                }
            }
            list[i] = Temp;
            RedrawItem(i);
            RefreshPanel(pnlSamples);
        }

        public IList InsertionSort(IList arrayToSort)
        {
            for (int i = 1; i < arrayToSort.Count; i++)
            {
                object val = arrayToSort[i];
                int j = i - 1;
                bool done = false;
                do
                {
                    if (((IComparable)arrayToSort[j]).CompareTo(val) > 0)
                    {
                        arrayToSort[j + 1] = arrayToSort[j];
                        RedrawItem(j + 1);
                        RefreshPanel(pnlSamples);
                        j--;
                        if (j < 0)
                        {
                            done = true;
                        }
                    }
                    else
                    {
                        done = true;
                    }
                } while (!done);
                arrayToSort[j + 1] = val;
                RedrawItem(j + 1);
                RefreshPanel(pnlSamples);
            }
            return arrayToSort;
        }

        public IList MergeSort(IList a, int low, int height)
        {
            int l = low;
            int h = height;

            if (l >= h)
            {
                return a;
            }

            int mid = (l + h) / 2;
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, h);

            int end_lo = mid;
            int start_hi = mid + 1;
            while ((l <= end_lo) && (start_hi <= h))
            {
                if (((IComparable)a[l]).CompareTo(a[start_hi]) < 0)
                {
                    l++;
                }
                else
                {
                    object temp = a[start_hi];
                    for (int k = start_hi - 1; k >= l; k--)
                    {
                        a[k + 1] = a[k];
                        RedrawItem(k + 1);
                        RefreshPanel(pnlSamples);
                    }
                    a[l] = temp;
                    RedrawItem(l);
                    RefreshPanel(pnlSamples);
                    l++;
                    end_lo++;
                    start_hi++;
                }
            }
            return a;
        }

        public IList QuickSort(IList a, int left, int right)
        {
            int i = left;
            int j = right;
            double pivotValue = ((left + right) / 2);
            int x = (int)a[int.Parse(pivotValue.ToString())];

            while (i <= j)
            {
                while (((IComparable)a[i]).CompareTo(x) < 0)
                {
                    i++;
                }
                while (((IComparable)x).CompareTo(a[j]) < 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    object temp = a[i];
                    a[i] = a[j];
                    RedrawItem(i);
                    i++;
                    a[j] = temp;
                    RedrawItem(j);
                    j--;
                    RefreshPanel(pnlSamples);
                }
            }
            if (left < j)
            {
                QuickSort(a, left, j);
            }
            if (i < right)
            {
                QuickSort(a, i, right);
            }
            return a;
        }

        public IList SelectionSort(IList arrayToSort)
        {
            int min;
            for (int i = 0; i < arrayToSort.Count; i++)
            {
                min = i;
                for (int j = i + 1; j < arrayToSort.Count; j++)
                {
                    if (((IComparable)arrayToSort[j]).CompareTo(arrayToSort[min]) < 0)
                    {
                        min = j;
                    }
                }
                object temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[min];
                arrayToSort[min] = temp;

                RedrawItem(i);
                RedrawItem(min);
                RefreshPanel(pnlSamples);
            }

            return arrayToSort;
        }

        private void DrawSamples()
        {
                g.Clear(Color.White);
                for (int i = 0; i < this.arrayToSort.Count; i++)
                {
                    int x = (int)(((double)pnlSamples.Width / arrayToSort.Count) * i);

                    Pen pen = new Pen(Color.Black);

                    g.DrawLine(pen, new Point(x, pnlSamples.Height), new Point(x, (int)(pnlSamples.Height - Convert.ToInt32(arrayToSort[i]))));
                }   
        }

        private void RedrawItem(int index1)
        {
            lock (this)
            {
                int x1 = (int)(((double)pnlSamples.Width / arrayToSort.Count) * index1);
                g.DrawLine(new Pen(Color.White), new Point(x1, 0), new Point(x1, pnlSamples.Height));
                g.DrawLine(new Pen(Color.Black), new Point(x1, pnlSamples.Height), new Point(x1, (int)(pnlSamples.Height - Convert.ToInt32(arrayToSort[index1]))));
            }
        }

        delegate void SetControlValueCallback(Control pnlSort);
        private void RefreshPanel(Control pnlSort)
        {
            if (pnlSort.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(RefreshPanel);
                pnlSort.Invoke(d, new object[] { pnlSort });
            }
            else
            {
                pnlSort.Refresh();
            }
        }
    }
}
