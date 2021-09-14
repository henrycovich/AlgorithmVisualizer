using System;

public class Class1
{
    private void CmdSalva_Click(object sender, EventArgs e)
    {
        var stringBuilder = new StringBuilder();

        foreach (var arrayElement in ArrayToSort)
        {
            stringBuilder.AppendLine(arrayElement.ToString());
        }

        File.AppendAllText(@"C:\array.txt", stringBuilder.ToString());
        this.Close();
    }
}
