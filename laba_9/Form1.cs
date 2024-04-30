using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace laba_9
{
    public partial class Form1 : Form
    {
        double[] a;
        double[] b;
        public int count = 2;
        private List<DataGridView> dataGrids = new List<DataGridView>();
        private GraphPane graphPane;
        private ZedGraphControl zedGraphControl;


        public Form1()
        {
            InitializeComponent();
            InitializeGraph();
        }
        private void InitializeGraph()
        {
            zedGraphControl = new ZedGraphControl();
            graphPane = zedGraphControl.GraphPane;
            graphPane.Title.Text = "График";
            graphPane.XAxis.Title.Text = "X";
            graphPane.YAxis.Title.Text = "Y";

            tabControl2.TabPages[0].Controls.Add(zedGraphControl);
        }


        private void AddData_button_Click(object sender, EventArgs e)
        {
            
            TabPage newPage = new TabPage(count.ToString());
            count++;

            // Копируем все элементы с первой вкладки на новую вкладку
            foreach (Control control in tabControl1.TabPages[0].Controls)
            {
                Control newControl = (Control)Activator.CreateInstance(control.GetType()); // Создаем новый экземпляр контрола
                newControl.Location = control.Location; // Устанавливаем позицию нового контрола
                newControl.Size = control.Size; // Устанавливаем размер нового контрола

                // Копируем специфичные свойства для DataGridView
                if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    DataGridView newDataGridView = (DataGridView)newControl;
                    newDataGridView.Columns.Add("X", "X");
                    newDataGridView.Columns.Add("Y", "Y");
                }

                newPage.Controls.Add(newControl); // Добавляем новый контрол на новую вкладку
            }

            tabControl1.TabPages.Add(newPage); // Добавляем новую вкладку на tabControl1

        }

        private void DeleteData_button_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1) // Проверяем, что вкладок больше одной
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab); // Удаляем текущую выбранную вкладку
            }
            else
            {
                MessageBox.Show("Нельзя удалить последнюю вкладку!");
            }
        }


        private void BuiltGraph_button_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            GraphPane pane2 = zedGraphControl2.GraphPane;
            pane.CurveList.Clear();

            a = new double[dataGridView1.RowCount];
            b = new double[dataGridView1.RowCount];
            PointPairList list = new PointPairList();

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                a[i] = Convert.ToDouble(dataGridView1[0, i].Value);
                b[i] = Convert.ToDouble(dataGridView1[1, i].Value);
                list.Add(a[i], b[i]);

            }
            LineItem myCurve = pane.AddCurve("Dots", list, Color.Blue, SymbolType.Circle);
            LineItem myCurve2 = pane2.AddCurve("Line", list, Color.Blue, SymbolType.Circle);
            myCurve.Line.IsVisible = false;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            pane2.XAxis.MajorGrid.IsVisible = true;
            pane2.YAxis.MajorGrid.IsVisible = true;

            pane.YAxis.Title.Text = "Ось Y"; pane.XAxis.Title.Text = "Ось X";
            pane.Title.Text = "Вариант 27";

            pane2.YAxis.Title.Text = "Ось Y"; pane2.XAxis.Title.Text = "Ось X";
            pane2.Title.Text = "Вариант 27";

            

            //myCurve.Symbol.Fill.Type = FillType.Solid;
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
            zedGraphControl2.AxisChange();

            // Обновляем график
            zedGraphControl2.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GritColor_button_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            int number = tabControl2.SelectedIndex;
            if (number == 0)
            {
                GraphPane pane = zedGraphControl1.GraphPane;
                if (dlg.ShowDialog() == DialogResult.OK)
                    pane.XAxis.MajorGrid.Color = dlg.Color;
                    pane.YAxis.MajorGrid.Color = dlg.Color;
                    zedGraphControl1.Invalidate();
            }
            else
            {
                GraphPane pane = zedGraphControl2.GraphPane;
                if (dlg.ShowDialog() == DialogResult.OK)
                    pane.XAxis.MajorGrid.Color = dlg.Color;
                    pane.YAxis.MajorGrid.Color = dlg.Color;
                    zedGraphControl2.Invalidate();
            }

        }

        private void Point_button_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            int number = tabControl2.SelectedIndex;
            if (number == 0)
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (var curve in zedGraphControl1.GraphPane.CurveList)
                    {
                        curve.Color = dlg.Color;
                    }
                }
                zedGraphControl1.Invalidate();

            }
            else
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (var curve in zedGraphControl2.GraphPane.CurveList)
                    {
                        curve.Color = dlg.Color;
                    }
                }
                zedGraphControl2.Invalidate();
            }
        }

        private void Lines_button_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            int number = tabControl2.SelectedIndex;
            if (number == 0)
            {
                MessageBox.Show("Невозможно применить изменение к выбранному типу графика");
            }
            else
            {
                LineItem curve = zedGraphControl2.GraphPane.CurveList[0] as LineItem;
                if (dlg.ShowDialog() == DialogResult.OK) {curve.Line.Color = dlg.Color; }
                    
                zedGraphControl2.Invalidate();
            }
        }

        private void Legend_button_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            int number = tabControl2.SelectedIndex;
            if (number == 1)
            {
                zedGraphControl2.GraphPane.Legend.Position = LegendPos.Bottom;
                zedGraphControl2.AxisChange();
                zedGraphControl2.Invalidate();


            }
            else
            {
                zedGraphControl1.GraphPane.Legend.Position = LegendPos.Bottom;
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
        }
    }
}
