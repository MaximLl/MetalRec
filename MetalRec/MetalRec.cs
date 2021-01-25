using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetalRecDLL;
using System.Xml.Serialization;

namespace MetalRec
{
    public partial class MetalRec : Form
    {
        // Главный объект, который включает в себя все нужные объекты
        public MathLib ML = new MathLib();

        private List<Param> _allParamsInput = new List<Param>(), _paramsToReportInput = new List<Param>();
        private List<Param> _allParamsOutput = new List<Param>(), _paramsToReportOutput = new List<Param>();

        public myReport Rpt;

        public MetalRec()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmMainBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProgramExit();
        }

        private void ProgramExit()
        {
            string path = Application.UserAppDataPath.ToString();

            // Сохранить данные объекта на диск для последующего вызова
            ML.SaveData(ML, path + @"\\default.xml");

            #region -- сохранить параметры отчета в файле: исходные данные в отчет
            XmlSerializer xmls = new XmlSerializer(typeof(List<Param>));
            FileStream fs = null;
            try
            {
                fs = new FileStream("cfgInputToRep.xml", FileMode.Create);
                xmls.Serialize(fs, _allParamsInput);
            }
            catch
            {
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            #endregion

            #region -- сохранить параметры отчета в файле: результаты в отчет
            XmlSerializer xmlsOut = new XmlSerializer(typeof(List<Param>));
            FileStream fsOut = null;
            try
            {
                fsOut = new FileStream("cfgOutputToRep.xml", FileMode.Create);
                xmlsOut.Serialize(fsOut, _allParamsOutput);
            }
            catch
            {
            }
            finally
            {
                if (fsOut != null) fsOut.Close();
            }
            #endregion

            Application.Exit();
        }


        private void FormOptionDefault()
        {
            // Показать в заголовке главного окна номер текущей версии и пользвателя
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";

            // Установить редактируемый объект в PropertyGrid
            propertyGrid1.SelectedObject = new DataInput(ML);


            #region -- Заполнить перечень показателей в отчет: исходные данные
            if (File.Exists("cfgInputToRep.xml"))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Param>));
                FileStream fs = null;
                try
                {
                    fs = new FileStream("cfgInputToRep.xml", FileMode.Open);
                    _allParamsInput = (List<Param>)xmls.Deserialize(fs);
                }
                catch
                {
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            else
            {
                PropertyInfo[] pArr = propertyGrid1.SelectedObject.GetType().GetProperties();
                if (pArr != null)
                    foreach (PropertyInfo p in pArr)
                    {
                        string descr = "";
                        object[] attr = p.GetCustomAttributes(false);
                        if (attr != null)
                            foreach (object a in attr)
                            {
                                if (a is DisplayNameAttribute) descr += (a as DisplayNameAttribute).DisplayName;
                                if (a is CategoryAttribute) descr = descr.Insert(0, (a as CategoryAttribute).Category + ". ");
                            }
                        Param par = new Param(0);
                        par.Description = descr;
                        par.IsReport = false;
                        par.PropertyName = p.Name;
                        _allParamsInput.Add(par);
                    }
            }
            #endregion

            #region -- Заполнить перечень показателей в отчет: результаты расчета
            //if (File.Exists("cfgOutputToRep.xml"))
            //{
            //    XmlSerializer xmls = new XmlSerializer(typeof(List<Param>));
            //    FileStream fsOut = null;
            //    try
            //    {
            //        fsOut = new FileStream("cfgOutputToRep.xml", FileMode.Open);
            //        _allParamsOutput = (List<Param>)xmls.Deserialize(fsOut);
            //    }
            //    catch
            //    {
            //    }
            //    finally
            //    {
            //        if (fsOut != null) fsOut.Close();
            //    }
            //}
            //else
            {
                DataOutput _dataOut = new DataOutput(ML);
                PropertyInfo[] pArrOut = _dataOut.GetType().GetProperties();
                if (pArrOut != null)
                    foreach (PropertyInfo p in pArrOut)
                    {
                        string descrOut = "";
                        object[] attrOut = p.GetCustomAttributes(false);
                        if (attrOut != null)
                            foreach (object a in attrOut)
                            {
                                if (a is DisplayNameAttribute) descrOut += (a as DisplayNameAttribute).DisplayName;
                                if (a is CategoryAttribute) descrOut = descrOut.Insert(0, (a as CategoryAttribute).Category + ", ");
                            }
                        Param parOut = new Param(0);
                        parOut.Description = descrOut;
                        parOut.IsReport = false;
                        parOut.PropertyName = p.Name;
                        _allParamsOutput.Add(parOut);
                    }
            }
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                MathLib MLL = new MathLib();
                this.ML = MLL.LoadData(fileDefaultUserAppDataPath.ToString());              
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений

                ML.tв2 = 300;
                ML.tв1 = 20;
                ML.tд1 = 800;
                ML.Vв = 7.5;
                ML.Vд = 9.9;
                ML.СO2 = 12.47;
                ML.H2O = 11.89;
                ML.Kl = 1;
                ML.Co = 5.7;
                ML.Ки = 1.148;
                ML.A = 0.023;
                ML.n = 0.8;
                ML.m = 0.4;
                ML.A1 = 0.2;
                ML.n1 = 0.64;
                ML.m1 = 0.35;
                ML.λ = 0.0393;
                ML.ν10 = 34.9;
                ML.Pr = 0.68;
                ML.ν_10 = 124.9;
                ML.Pr1 = 0.603;
                ML.λ1 = 0.0885;
                ML.d = 0.076;
                ML.dэ = 0.068;
                ML.wв = 0.62;
                ML.wд = 3.7;
                ML.ɛdt = 0.99;
                ML.Kl1 = 1;
                ML.Kz = 1;
                ML.Kt = 1;
                ML.ɛг = 0.162;
                ML.αг2 = 0.66;
                ML.αст2 = 0.734;
                ML.r = 1850;

                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                ML.SaveData(ML, fileDefaultUserAppDataPath.ToString());
            }

            // Настроить элементы формы
            FormOptionDefault();
            btnOtchet.Enabled = false;
            btnPostr_Graf.Enabled = false;

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 13);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, 14654.43);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

        }

        private void btnRaschet_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show("Расчет успешно завершён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedIndex = 1;
            dataGridView1.Visible = true;
            btnOtchet.Enabled = true;
            btnPostr_Graf.Enabled = true;


            dataGridView1.Rows.Add("Cв", Math.Round(ML.get_Св(), 2), "Теплоемкость воздуха", "Дж/(м3K)");
            dataGridView1.Rows.Add("Сд", Math.Round(ML.get_Сд(), 2), "Теплоемкость дыма", "Дж/(м3K)");
            dataGridView1.Rows.Add("I'в", Math.Round(ML.get_Iв1(), 1), "Энтальпия воздуха при начальной температуре", "кДж/м3");
            dataGridView1.Rows.Add("I''в", Math.Round(ML.get_Iв2()), "Энтальпия воздуха при конечной температуре", "кДж/м3");
            dataGridView1.Rows.Add("I'д", Math.Round(ML.get_Iд1()), "Энтальпия дыма при начальной температуре", "кДж/м3");
            dataGridView1.Rows.Add("Тв", Math.Round(ML.get_Tв()), "Средняя температура воздуха", "оС");
            dataGridView1.Rows.Add("Wво", Math.Round(ML.get_Wво(), 3), "Фактическая скорость воздуха", "м/с");
            dataGridView1.Rows.Add("Wдо", Math.Round(ML.get_Wдо(), 3), "Фактическая скорость продуктов сгорания", "м/с");
            dataGridView1.Rows.Add("Wв", Math.Round(ML.get_Wв(), 3), "Действительная скорость воздуха", "м/с");
            dataGridView1.Rows.Add("Wд", Math.Round(ML.get_Wд(), 3), "Действительная скорость продуктов сгорания", "м/с");
            dataGridView1.Rows.Add("Qв", Math.Round(ML.get_Qв(), 2), "Количество тепла, переданного воздуху", "Квт");
            dataGridView1.Rows.Add("Q'д", Math.Round(ML.get_Qд1(), 2), "Количество тепла,вносимое в теплообменный аппарат продуктами сгорания", "Квт");
            dataGridView1.Rows.Add("Q''д", Math.Round(ML.get_Qд2(), 1), "Количество тепла,уносимое продуктами сгорания", "Квт");
            dataGridView1.Rows.Add("i''д", Math.Round(ML.get_iд2(), 2), "Энтальпия продуктов сгорания", "кДж/м3");
            dataGridView1.Rows.Add("t''д", Math.Round(ML.get_Tд2(), 2), "Температура продуктов сгорания после рекуператора", "оС");
            dataGridView1.Rows.Add("⌂tср", Math.Round(ML.get_tср(), 2), "Cреднелогарифмическая разность температур", "");
            dataGridView1.Rows.Add("R", Math.Round(ML.get_R(), 2), "Параметр", "");
            dataGridView1.Rows.Add("P", Math.Round(ML.get_P(), 2), "Параметр", "");
            dataGridView1.Rows.Add("Re", Math.Round(ML.get_Re(), 2), "Число Рейнольдса 1", "");
            dataGridView1.Rows.Add("Tд", Math.Round(ML.get_Tд(), 3), "Средняя температура дыма", "оС");
            dataGridView1.Rows.Add("Tст", Math.Round(ML.get_Tст(), 3), "Средняя температура стенки рекуператора", "оС");
            dataGridView1.Rows.Add("Тст/Тв", Math.Round(ML.get_Тст_Тв(), 2), "Отношение Тст/Тв", "");
            dataGridView1.Rows.Add("Kt", Math.Round(ML.get_kt(), 2), "Поправочный коэффициент", "");
            dataGridView1.Rows.Add("Ки", Math.Round(ML.get_Ku(), 2), "Поправочный коэффициент (если изогнута труба)", "");
            dataGridView1.Rows.Add("Крек", Math.Round(ML.get_К_рек(), 2), "Суммарный поправочный коэффициент 1", "");
            dataGridView1.Rows.Add("Nu", Math.Round(ML.get_Nu(), 2), "Число Нуссельта 1", "");
            dataGridView1.Rows.Add("αв'", Math.Round(ML.get_aв1(), 1), "Коэффициент теплоотдачи конвекцией на пути движения воздуха", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("aв", Math.Round(ML.get_aв(), 2), "Коэффициент теплоотдачи конвекцией в пересчете на поверхность наружной трубы", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("Re", Math.Round(ML.get_Re1(), 2), "Число Рейнольдса 2", "");
            dataGridView1.Rows.Add("Крек", Math.Round(ML.get_К_рек1()), "Суммарный поправочный коэффициент 2", "");
            dataGridView1.Rows.Add("Nu", Math.Round(ML.get_Nu1(), 2), "Число Нуссельта 2", "");
            dataGridView1.Rows.Add("αкд", Math.Round(ML.get_αкд(), 1), "Коэффициент конвективной теплоотдачи", "");
            dataGridView1.Rows.Add("Sэф", Math.Round(ML.get_Sэф(), 2), "Эффективная длина луча", "");
            dataGridView1.Rows.Add("kг", Math.Round(ML.get_kг(), 3), "Коэффициент для газовой части печной среды", "");
            dataGridView1.Rows.Add("Ср/Нр", Math.Round(ML.get_Cp_Hp(), 2), "Отношение Ср/Нр", "");
            dataGridView1.Rows.Add("kc", Math.Round(ML.get_kc(), 3), "Коэффициент", "");
            dataGridView1.Rows.Add("x", Math.Round(ML.get_x(), 3), "Связующая величина", "");
            dataGridView1.Rows.Add("ɛ''г", Math.Round(ML.get_ɛг2(), 2), "Расчетное значение доли излучения АЧТ", "");
            dataGridView1.Rows.Add("αдл", Math.Round(ML.get_αдл(), 1), "Коэффициент лучистой теплоотдачи", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("αд", Math.Round(ML.get_αд(), 1), "Суммарный коэффициент теплоотдачи от пс к стенке", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("K*", Math.Round(ML.get_Кзвезд(), 3), "Суммарный коэффициент теплоотдачи от пс к стенке", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("K", Math.Round(ML.get_K(), 2), "Коэффициент теплопередачи с учетом загрязнения труб", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("F*", Math.Round(ML.get_Fзвезд(), 3), "Коэффициент теплопередачи с учетом загрязнения труб", "Вт/(м^2*оС)");
            dataGridView1.Rows.Add("q", Math.Round(ML.get_q(), 2), "Плотность теплового потока от продуктов сгорания к воздуху", "Вт/м2");
            dataGridView1.Rows.Add("tст.max", Math.Round(ML.get_t_ст_max(), 2), "Плотность теплового потока от продуктов сгорания к воздуху", "Вт/м2");
        }

        private void btnOptionsReport_Click(object sender, EventArgs e)
        {
            frmReportOptions _ro = new frmReportOptions(_allParamsInput, _allParamsOutput);
            _ro.ShowDialog();
        }

        private void btnOtchet_Click(object sender, EventArgs e)
        {
            CreateReportViewer();
        }

        private void btnO_programme_Click(object sender, EventArgs e)
        {
            O_programme О_программе = new O_programme();
            О_программе.ShowDialog();
        }

        private void lb_Rashod_prod_Click(object sender, EventArgs e)
        {

        }

        private void btnPostr_Graf_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[0].Points.AddXY(0.5, 563.63);
            chart1.Series[0].Points.AddXY(1, 1127.6);
            chart1.Series[0].Points.AddXY(1.5, 1690.9);
            chart1.Series[0].Points.AddXY(2, 2254.53);
            chart1.Series[0].Points.AddXY(2.5, 2818.16);
            chart1.Series[0].Points.AddXY(3, 3381.79);
            chart1.Series[0].Points.AddXY(3.5, 3945.42);
            chart1.Series[0].Points.AddXY(4, 4509.06);
            chart1.Series[0].Points.AddXY(4.5, 5072.69);
            chart1.Series[0].Points.AddXY(5, 5636.32);
            chart1.Series[0].Points.AddXY(5.5, 6199.95);
            chart1.Series[0].Points.AddXY(6, 6763.58);
            chart1.Series[0].Points.AddXY(6.5, 7327.22);
            chart1.Series[0].Points.AddXY(7, 7890.85);
            chart1.Series[0].Points.AddXY(7.5, 8454.48);
            chart1.Series[0].Points.AddXY(8, 9018.11);
            chart1.Series[0].Points.AddXY(8.5, 9581.74);
            chart1.Series[0].Points.AddXY(9, 10145.38);
            chart1.Series[0].Points.AddXY(9.5, 10709.01);
            chart1.Series[0].Points.AddXY(9.9, 11159.91);
            chart1.Series[0].Points.AddXY(10.5, 11836.27);
            chart1.Series[0].Points.AddXY(11, 12399.9);
            chart1.Series[0].Points.AddXY(11.5, 12963.54);
            chart1.Series[0].Points.AddXY(12, 13527.17);
            chart1.Series[0].Points.AddXY(12.5, 14090.8);
            chart1.Series[0].Points.AddXY(13, 14654.43);
        }

        private void btnDelete_Graf_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            propertyGrid1.Text = "";
            btnOtchet.Enabled = false;
            dataGridView1.Visible = false;

        }

        private void CreateReportViewer()
        {
            Rpt = new myReport();

            #region Закомментировал Лавров В.В. Подготовка данных для вывода в отчет 

            //// Исходные данные для отчета
            //List<cReportList> RepListInput = new List<cReportList>();
            //RepListInput.Add(new cReportList("Температура воздуха на выходе из рекуператора, °C", ML.tв2.ToString()));
            //RepListInput.Add(new cReportList("Температура воздуха на входе в рекуператор, °C", ML.tв1.ToString()));
            //RepListInput.Add(new cReportList("Температура продуктов сгорания перед рекуператором, °C", ML.tд1.ToString()));
            //RepListInput.Add(new cReportList("Расход воздуха, м3/с", ML.Vв.ToString()));
            //RepListInput.Add(new cReportList("Расход продуктов сгорания, м3/с", ML.Vд.ToString()));
            //RepListInput.Add(new cReportList("Количество вещества, %", ML.СO2.ToString()));
            //RepListInput.Add(new cReportList("Количество вещества, %", ML.H2O.ToString()));
            //RepListInput.Add(new cReportList("Поправка на длину канала для Крек", ML.Kl.ToString()));
            //RepListInput.Add(new cReportList("Коэффициент излучения АЧТ, Вт/(м2*К4)", ML.Co.ToString()));
            //RepListInput.Add(new cReportList("Поправка для Крек", ML.Ки.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для воздуха 1", ML.A.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для воздуха 2", ML.n.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для воздуха 3", ML.m.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для продуктов сгорания 1", ML.A1.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для продуктов сгорания 2", ML.n1.ToString()));
            //RepListInput.Add(new cReportList("Эмпирический коэффициент для продуктов сгорания 3", ML.m1.ToString()));
            //RepListInput.Add(new cReportList("Коэффициент теплопроводности 1, Вт/(м3*оС)", ML.λ.ToString()));
            //RepListInput.Add(new cReportList("Коэффициент кинематической вязкости 1, м2/с", ML.ν10.ToString()));
            //RepListInput.Add(new cReportList("Число Прандтля 1", ML.Pr.ToString()));
            //RepListInput.Add(new cReportList("Коэффициент кинематической вязкости 2, м2/с", ML.ν_10.ToString()));
            //RepListInput.Add(new cReportList("Число Прандтля 2", ML.Pr1.ToString()));
            //RepListInput.Add(new cReportList("Коэффициент теплопроводности 2, Вт/(м3*оС)", ML.λ1.ToString()));
            //RepListInput.Add(new cReportList("Внешний диаметр трубы, м", ML.d.ToString()));
            //RepListInput.Add(new cReportList("Внутренний диаметр трубы, м", ML.dэ.ToString()));
            //RepListInput.Add(new cReportList("Проходное сечение для воздуха, м2", ML.wв.ToString()));
            //RepListInput.Add(new cReportList("Проходное сечение для продуктов сгорания, м2", ML.wд.ToString()));
            //RepListInput.Add(new cReportList("Поправочный коэффициент", ML.ɛdt.ToString()));
            //RepListInput.Add(new cReportList("Поправочный коэффициент на длину канала", ML.Kl1.ToString()));
            //RepListInput.Add(new cReportList("Поправочный коэффициент на число труб", ML.Kz.ToString()));
            //RepListInput.Add(new cReportList("Поправочный коэффициент 1", ML.Kt.ToString()));
            //RepListInput.Add(new cReportList("Интегральная степень черноты", ML.ɛг.ToString()));
            //RepListInput.Add(new cReportList("Значение доли излучения АЧТ", ML.αг2.ToString()));
            //RepListInput.Add(new cReportList("Значение доли излучения АЧТ", ML.αст2.ToString()));
            //RepListInput.Add(new cReportList("Радиус", ML.r.ToString()));


            //// Результаты расчета 
            //List<cReportList> RepListOutput = new List<cReportList>();
            //RepListOutput.Add(new cReportList("Теплоемкость воздуха, Дж/(м3K)", Math.Round(ML.get_Св(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Теплоемкость дыма, Дж/(м3K)", Math.Round(ML.get_Сд(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Энтальпия воздуха при начальной температуре, кДж/м3", Math.Round(ML.get_Iв1(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Энтальпия воздуха при конечной температуре, кДж/м3", Math.Round(ML.get_Iв2()).ToString()));
            //RepListOutput.Add(new cReportList("Энтальпия дыма при начальной температуре, кДж/м3", Math.Round(ML.get_Iд1()).ToString()));
            //RepListOutput.Add(new cReportList("Средняя температура воздуха, оС", Math.Round(ML.get_Tв()).ToString()));
            //RepListOutput.Add(new cReportList("Фактическая скорость воздуха, м/с", Math.Round(ML.get_Wво(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Фактическая скорость продуктов сгорания, м/с", Math.Round(ML.get_Wдо(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Действительная скорость воздуха, м/с", Math.Round(ML.get_Wв(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Действительная скорость продуктов сгорания, м/с", Math.Round(ML.get_Wд(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Количество тепла, переданного воздуху, Квт", Math.Round(ML.get_Qв(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Количество тепла,вносимое в теплообменный аппарат продуктами сгорания, Квт", Math.Round(ML.get_Qд1(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Количество тепла,уносимое продуктами сгорания, Квт", Math.Round(ML.get_Qд2(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Энтальпия продуктов сгорания, кДж/м3", Math.Round(ML.get_iд2(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Температура продуктов сгорания после рекуператора, оС", Math.Round(ML.get_Tд2(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Cреднелогарифмическая разность температур", Math.Round(ML.get_tср(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Параметр", Math.Round(ML.get_R(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Параметр", Math.Round(ML.get_P(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Число Рейнольдса 1", Math.Round(ML.get_Re(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Средняя температура дыма, °C", Math.Round(ML.get_Tд(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Средняя температура стенки рекуператора, °C", Math.Round(ML.get_Tст(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Отношение Тст/Тв", Math.Round(ML.get_Тст_Тв(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Поправочный коэффициент", Math.Round(ML.get_kt(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Поправочный коэффициент (если изогнута труба)", Math.Round(ML.get_Ku(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Суммарный поправочный коэффициент 1", Math.Round(ML.get_К_рек(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Число Нуссельта 1", Math.Round(ML.get_Nu(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент теплоотдачи конвекцией на пути движения воздуха, Вт/(м^2*оС)", Math.Round(ML.get_aв1(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент теплоотдачи конвекцией в пересчете на поверхность наружной трубы, Вт/(м^2*оС)", Math.Round(ML.get_aв1(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Число Рейнольдса 2", Math.Round(ML.get_Re1(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Суммарный поправочный коэффициент 2", Math.Round(ML.get_К_рек1()).ToString()));
            //RepListOutput.Add(new cReportList("Число Нуссельта 2", Math.Round(ML.get_Nu1(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент конвективной теплоотдачи", Math.Round(ML.get_αкд(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Эффективная длина луча", Math.Round(ML.get_Sэф(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент для газовой части печной среды", Math.Round(ML.get_kг(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Отношение Ср/Нр", Math.Round(ML.get_Cp_Hp(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент", Math.Round(ML.get_kc(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Связующая величина", Math.Round(ML.get_x(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Расчетное значение доли излучения АЧТ", Math.Round(ML.get_ɛг2(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент лучистой теплоотдачи, Вт/(м^2*оС)", Math.Round(ML.get_αдл(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Суммарный коэффициент теплоотдачи от пс к стенке, Вт/(м^2*оС)", Math.Round(ML.get_αд(), 1).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент теплопередачи, Вт/(м^2*оС)", Math.Round(ML.get_Кзвезд(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Коэффициент теплопередачи с учетом загрязнения труб, Вт/(м^2*оС)", Math.Round(ML.get_K(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Поверхность нагрева", Math.Round(ML.get_Fзвезд(), 3).ToString()));
            //RepListOutput.Add(new cReportList("Плотность теплового потока от продуктов сгорания к воздуху, Вт/м2", Math.Round(ML.get_q(), 2).ToString()));
            //RepListOutput.Add(new cReportList("Максимальная температура стенки", Math.Round(ML.get_t_ст_max(), 2).ToString()));

            #endregion Закомментировал Лавров В.В. Подготовка данных для вывода в отчет 

            #region Подготовить данные для вывода в отчет

            // Исходные данные в отчет только те, которые отметил пользователь (IsReport=true)
            List<cReportList> RepListInput = new List<cReportList>();
            foreach (Param par in _allParamsInput)
            {
                if (par.IsReport)
                {
                    double d = Math.Round(Convert.ToDouble(
                        propertyGrid1.SelectedObject.GetType().GetProperty(par.PropertyName).GetValue(
                        propertyGrid1.SelectedObject, null)), 3);
                    RepListInput.Add(new cReportList(par.Description, d.ToString()));
                }
            }
            // Результаты расчета в отчет только те, которые отметил пользователь (IsReport=true)
            DataOutput _dataOutput = new DataOutput(ML);
            List<cReportList> RepListOutput = new List<cReportList>();
            foreach (Param par in _allParamsOutput)
            {
                if (par.IsReport)
                {
                    double d = Math.Round(Convert.ToDouble(
                        _dataOutput.GetType().GetProperty(par.PropertyName).GetValue(_dataOutput, null)), 3);
                    RepListOutput.Add(new cReportList(par.Description, d.ToString()));
                }
            }
            #endregion Подготовить данные для вывода в отчет


            // Указать отчету источники данных                
            Rpt.cReportInputBindingSource.DataSource = RepListInput; ;
            Rpt.cReportOutputBindingSource.DataSource = RepListOutput;

            // Показать окно отчета на весь экран
            Rpt.WindowState = FormWindowState.Maximized;
            Rpt.ShowDialog(this);
        }
    }
}
