using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // 1. Daten aus Formular auslesen
            InputData inputData = Input();
            // 2. Daten validieren (Wertebereich prüfen)
            if (CheckData(inputData)) // prüft automatisch auf true
            {
                // 3. Berechnung durchführen
                OutputData[] outputData = Calc(inputData);
                // 4. Daten an Formular ausgeben
                Output(outputData);
            }
        }

        private bool CheckData(InputData inputData)
        {
            if ((CheckValue(1000, 1000000, inputData.KreditBetrag, "Der Kreditbetrag")) &&
               (CheckValue(1, 10, inputData.Zinssatz, "Der Zinssatz")) &&
               (CheckValue(1, 10, inputData.Tilgungssatz, "Der Tilgungssatz")) &&
               (CheckValue(1, 20, inputData.Laufzeit, "Die Laufzeit")))
            { 
                return true;
            }
            else
                return false;
        }

        private static bool CheckValue(double minValue, double maxValue, double value, string message)
        {
            if ((value < minValue) || (value > maxValue))
            {
                MessageBox.Show(message+" muss zwischen "+minValue.ToString()+" und "+maxValue.ToString()+" liegen!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Es werden die Daten aus dem Formular entgegengenommen
        /// </summary>
        /// <returns></returns>
        private InputData Input()
        {
            InputData data = new InputData();

            data.KreditBetrag = double.Parse(textBoxKreditbetrag.Text);
            data.Zinssatz = double.Parse(textBoxZinsatz.Text);
            data.Tilgungssatz = double.Parse(textBoxTilgungssatz.Text);
            data.Laufzeit = int.Parse(textBoxLaufzeit.Text);
            data.Date = dateTimePicker.Value;
            
            return data;
        }

        /// <summary>
        /// Hier erfolgt die Berechnung
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private OutputData[] Calc(InputData value)
        {
            OutputData[] data = new OutputData[value.Laufzeit];
           
            // Berechnung Jahr 1
            OutputData dataYear1 = new OutputData();
            dataYear1.Kreditbetrag = value.KreditBetrag;
            dataYear1.Zinsen = value.KreditBetrag * value.Zinssatz / 100;
            dataYear1.Tilgung = value.KreditBetrag * value.Tilgungssatz / 100;
            dataYear1.Annuitaet = dataYear1.Tilgung + dataYear1.Zinsen;
            dataYear1.Restbetrag = dataYear1.Kreditbetrag - dataYear1.Tilgung;
            dataYear1.Date = value.Date;

            data[0] = dataYear1;


            // Berechnung Jahr 2-n
            double lastRestbetrag = dataYear1.Restbetrag;
            for (int i = 2; i <=value.Laufzeit; i++)
            {
                OutputData dataYearN = new OutputData();
                dataYearN.Kreditbetrag = lastRestbetrag;
                dataYearN.Zinsen = dataYearN.Kreditbetrag * value.Zinssatz / 100;
                dataYearN.Tilgung = dataYear1.Annuitaet - dataYearN.Zinsen;
                dataYearN.Annuitaet = dataYear1.Annuitaet;
                dataYearN.Restbetrag = dataYearN.Kreditbetrag - dataYearN.Tilgung;
                lastRestbetrag = dataYearN.Restbetrag;
                dataYearN.Date = value.Date.AddYears(i - 1);

                data[i - 1] = dataYearN;
            }

            return data;
        }

        /// <summary>
        /// Hier erfolgt die Ausgabe in das Formular
        /// </summary>
        /// <param name="data"></param>
        private void Output(OutputData[] value)
        {
            // Anzahl an Reihen im Ausgabefeld an der dynamischen Länge der Variable value fest machen
            dataGridView.RowCount = value.Length;
            // Befüllung des Ausgabefeldes mit den Daten aus der Berechnung
            for (int i = 0; i < value.Length; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = value[i].Date.Year;
                dataGridView.Rows[i].Cells[1].Value = value[i].Kreditbetrag.ToString("#.00 €");
                dataGridView.Rows[i].Cells[2].Value = value[i].Zinsen.ToString("#.00 €");
                dataGridView.Rows[i].Cells[3].Value = value[i].Tilgung.ToString("#.00 €");
                dataGridView.Rows[i].Cells[4].Value = value[i].Annuitaet.ToString("#.00 €");
                dataGridView.Rows[i].Cells[5].Value = value[i].Restbetrag.ToString("#.00 €");
            }
        }
    }
}