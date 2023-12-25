using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using EasyModbus;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;

namespace NewVer_Master
{
    public partial class Form1 : Form
    {
        ModbusClient client;
        SqlConnection connect = new SqlConnection("Data Source=TOEL;Initial Catalog=DATA_TPC;Integrated Security=True;Trusted_Connection=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            client = new ModbusClient();
            client.IPAddress = txtIP.Text;
            client.Port      = int.Parse(txtPort.Text);
            try
            {
                client.Connect();
                lblStatus1.Text = $"Status : Connect IP : {txtIP.Text}  Success. ";
                connect.Open();
                btnCon.Enabled = false;
                btnDis.Enabled = true;
                timer.Start();
                timer002.Start();

            }
            catch (Exception ex)
            {
                
                lblStatus1.Text = $"Status : Error {ex.Message} ";
                
            }
        }
        /*Data Source=TOEL;Initial Catalog=DATA_TPC;Integrated Security=True;Trusted_Connection=True*/


        private void btnDis_Click(object sender, EventArgs e)
        {
            connect.Close();
            timer.Stop();
            timer002.Stop();
            btnCon.Enabled = true;
            btnDis.Enabled = false;
            client.Disconnect();
            lblStatus1.Text = "Status : Disconnected Success";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                DateTime Date = DateTime.Now;
                lblDate.Text = Date.ToString("yyyy-MM-dd HH:mm:ss");
                int[] vals1 = client.ReadHoldingRegisters(0, 1);
                float[] vals2 = client.ReadHoldingRegisters(1, 1).Select(i => ((float)i) / 100).ToArray();
                bool[] vals3 = client.ReadCoils(0, 1);
                txtHol1.Text = vals1[0].ToString(); /*randomvalue001.ToString();*/
                txtHol2.Text = vals2[0].ToString("F2"); /*randomValue.ToString();*/ 
                txtCoil1.Text = vals3[0].ToString();

             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATA_TPCDataSet5.DATATeble2' table. You can move, or remove it, as needed.
            this.dATATeble2TableAdapter.Fill(this.dATA_TPCDataSet5.DATATeble2);
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Value",
                    PointGeometry = DefaultGeometries.Circle, // Set point geometry
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "DateTime",
                LabelFormatter = value => DateTime.FromOADate(value).ToString("HH:mm:ss")
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Value : Temp - Pressure",
                MinValue = -110,
                MaxValue = 110
            });
        }

        private void timer002_Tick(object sender, EventArgs e)
        {
            dATATeble2BindingSource.AddNew();
            dATATeble2TableAdapter.Update(dATA_TPCDataSet5.DATATeble2);
            lblStatus2.Text = "Status : Update Data Success.";

            cartesianChart1.Series.Clear();
            SeriesCollection seriesCollection = new SeriesCollection();

            var dates = dATA_TPCDataSet5.DATATeble2.Select(o => o.Datetime.Date).Distinct();

            foreach (var date in dates)
            {
                var temperatureData = dATA_TPCDataSet5.DATATeble2
                    .Where(o => o.Datetime.Date == date)
                    .OrderBy(o => o.Datetime)
                    .ToList();

                if (temperatureData.Any())
                {
                    ChartValues<ObservablePoint> temperatureValues = new ChartValues<ObservablePoint>(
                        temperatureData.Select(item => new ObservablePoint(item.Datetime.ToOADate(), Convert.ToDouble(item.Temperature)))
                    );

                    LineSeries temperatureSeries = new LineSeries
                    {
                        Title = "Temperature",
                        Values = temperatureValues
                    };

                    seriesCollection.Add(temperatureSeries);
                }

                var pressureData = dATA_TPCDataSet5.DATATeble2
                    .Where(o => o.Datetime.Date == date)
                    .OrderBy(o => o.Datetime)
                    .ToList();

                if (pressureData.Any())
                {
                    ChartValues<ObservablePoint> pressureValues = new ChartValues<ObservablePoint>(
                        pressureData.Select(item => new ObservablePoint(item.Datetime.ToOADate(), Convert.ToDouble(item.Pressure)))
                    );

                    LineSeries pressureSeries = new LineSeries
                    {
                        Title = "Pressure",
                        Values = pressureValues
                    };

                    seriesCollection.Add(pressureSeries);
                }
            }

            cartesianChart1.Series = seriesCollection;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dATATeble2BindingSource.RemoveCurrent();
            dATATeble2TableAdapter.Update(dATA_TPCDataSet5.DATATeble2);
            lblStatus2.Text = "Status : Delete Data Success.";
            btnLoad_Click(sender, e);   
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection seriesCollection = new SeriesCollection();

            var dates = dATA_TPCDataSet5.DATATeble2.Select(o => o.Datetime.Date).Distinct();

            foreach (var date in dates)
            {
                var temperatureData = dATA_TPCDataSet5.DATATeble2
                    .Where(o => o.Datetime.Date == date)
                    .OrderBy(o => o.Datetime)
                    .ToList();

                if (temperatureData.Any())
                {
                    ChartValues<ObservablePoint> temperatureValues = new ChartValues<ObservablePoint>(
                        temperatureData.Select(item => new ObservablePoint(item.Datetime.ToOADate(), Convert.ToDouble(item.Temperature)))
                    );

                    LineSeries temperatureSeries = new LineSeries
                    {
                        Title = "Temperature",
                        Values = temperatureValues
                    };

                    seriesCollection.Add(temperatureSeries);
                }

                var pressureData = dATA_TPCDataSet5.DATATeble2
                    .Where(o => o.Datetime.Date == date)
                    .OrderBy(o => o.Datetime)
                    .ToList();

                if (pressureData.Any())
                {
                    ChartValues<ObservablePoint> pressureValues = new ChartValues<ObservablePoint>(
                        pressureData.Select(item => new ObservablePoint(item.Datetime.ToOADate(), Convert.ToDouble(item.Pressure)))
                    );

                    LineSeries pressureSeries = new LineSeries
                    {
                        Title = "Pressure",
                        Values = pressureValues
                    };

                    seriesCollection.Add(pressureSeries);
                }
            }

            cartesianChart1.Series = seriesCollection;
        }
    }
}
