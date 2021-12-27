using Aspose.Cells;
using Parser.Parserr;
using Parser.Parserr.Population;
using System.Text.RegularExpressions;

List<string[]> l = new List<string[]>();
string[] countries = { "belarus", "bulgaria", "hungary", "moldavia", "poland", "romania", "slovakia", "ukraine", "czech-republic", "turkey", "armenia", "georgia", "azerbaijan" };

ParserWorker<string[]> parser;

parser = new ParserWorker<string[]>(
    new PopulationParser()
    );

Console.WriteLine("Hello World!");
parser.OnNewData += Parser_OnNewData;
parser.Settings = new ParserSettings(0, 13);
parser.Start();
XLSX(l, countries);
Console.WriteLine();

static void XLSX(List<string[]> list, string[] countries)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        // Instantiate a Workbook object that represents Excel file.
        Workbook wb = new Workbook();

        // When you create a new workbook, a default "Sheet1" is added to the workbook.
        Worksheet sheet = wb.Worksheets[0];

        string[] s = list[i];

        // Access the "A1" cell in the sheet.
        Cell cell = sheet.Cells["A1"];

        // Input the "Hello World!" text into the "A1" cell.
        cell.PutValue($"{countries[i]}");

        cell = sheet.Cells["A2"];

        cell.PutValue("Город");

        cell = sheet.Cells["B2"];

        cell.PutValue("Население");

        for (int j = 0; j < s.Length; j++)
        {
            string[] spl = s[j].Split(" ");
            if (spl.Length == 3)
            {
                cell = sheet.Cells[$"A{j + 3}"];
                cell.PutValue($"{spl[1]}");
                cell = sheet.Cells[$"B{j + 3}"];
                cell.PutValue($"{spl[2]}");
            }
        }

        // Save the Excel as .xlsx file.
        wb.Save($"{countries[i]}.xlsx", SaveFormat.Xlsx);
    }
}

static void Parser_OnNewData(object arg1, string[] arg2)
{
    string[] str = HtmlToStrings(arg2[0]);
    str = str.Where(s => s != null).ToArray();
    //l.Add(str);

    Console.WriteLine(arg2[0]);
}

static void Parser_OnCompleted(object obj)
{
    Console.WriteLine("done!");
}

static string[] HtmlToStrings(string str)
{
    Regex regex = new Regex(@"\s");
    string[] bits = regex.Split(str);
    string[] res = new string[200];
    int j = 1;
    int n = 0;
    for (int i = 0; i < bits.Length - 1; i++)
    {
        res[n] = "";
        if (bits[i] == j.ToString())
        {
            while (bits[i] != (j + 1).ToString())
            {
                if (bits[i] != "")
                {
                    res[n] += bits[i];
                }
                i++;
                if (i == bits.Length - 1)
                {
                    break;
                }
            }
            i--;
            j++;
            n++;
        }
    }

    string s = "";

    for (int q = 0; q < res.Length - 1; q++)
    {
        string r = "";
        if (res[q] != null)
        {
            r = res[q];
            for (int i = 0; i < res[q].Length - 1; i++)
            {
                if (Char.IsDigit(r[i]) && !Char.IsDigit(r[i + 1]))
                {
                    s = r.Insert(i + 1, " ");
                }
                if (i > 3 && Char.IsDigit(r[i]) && !Char.IsDigit(r[i - 1]))
                {
                    s = s.Insert(i + 1, " ");
                }

            }
            res[q] = s;
        }
    }

    return res;
}