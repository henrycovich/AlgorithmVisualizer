using System;

public class Class1
{
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
}
