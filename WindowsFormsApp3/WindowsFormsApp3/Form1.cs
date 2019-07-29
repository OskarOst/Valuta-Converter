using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        WebClient web;
        ListValuta listValuta;
        string html = String.Empty;
        string valuta1;
        string valuta2;
        int oldSelect;
        double värde;

        public Form1()
        {
            valuta1 = "SEK";
            valuta2 = "USD";
            InitializeComponent();
            web = new WebClient();
            listValuta = new ListValuta();
            cbFROM.Items.AddRange(listValuta.Output());
            cbFROM.SelectedIndex = 1;
            oldSelect = cbFROM.SelectedIndex;
            ReCalculate();
        }
        private string[] Date()
        {
            var end = DateTime.Today;
            var start = end.AddDays(-14);
            return new string[] {start.ToString().Replace(" 00:00:00",""), end.ToString().Replace(" 00:00:00", "") };
        }
        private string HTMLstring(string[]date)
        {
            string output = "https://www.riksbank.se/sv/statistik/sok-rantor--valutakurser/?c=cAverage&f=Day&from=" + date[0];
            output += "&g130-" + valuta1 + valuta2 + "PMI=on&=Comma&to=" + date[1] + "&export=txt";
            return output;
        }
        private void ReCalculate()
        {
            html = HTMLstring(Date());
            värde = Currency();
        }
        private double Currency()
        {
            string thisPath = Assembly.GetExecutingAssembly().Location;
            web.DownloadFile(html, "text.txt");
            string text = File.ReadAllText("text.txt");
            text = text.Replace("Valutor mot svenska kronor", "");
            text = text.Replace("Period", "");
            text = text.Replace("Grupp", "");
            text = text.Replace("Serie", "");
            text = text.Replace("Värde", "");
            text = text.Replace("\t", "|");
            text = text.Replace("\r\n", "|");
            string[] text2 = text.Split('|');
            List<double> Tempstring = new List<double>();
            List<int> conversionrate = new List<int>();
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i] != "" && !text2[i].Contains(valuta2) && !text2[i].Contains("-"))
                {
                    Tempstring.Add(double.Parse(text2[i]));
                }
                else if (text2[i].Contains(valuta2))
                {
                    string input = text2[i];
                    input = input.Replace(" ", "");
                    input = input.Replace(valuta2, "");
                    conversionrate.Add(int.Parse(input));
                }
            }
            return Tempstring[Tempstring.Count - 1] / conversionrate[Tempstring.Count - 1];
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double add = double.Parse(tbVALUE.Text) * värde;
            LBlistbox.Items.Add(add.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbFROM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFROM.SelectedItem.ToString() == "")
            {
                cbFROM.SelectedIndex = oldSelect;
            }
            else
            {
                valuta2 = cbFROM.SelectedItem.ToString();
                oldSelect = cbFROM.SelectedIndex;
                ReCalculate();
            }
        }
    }
}
