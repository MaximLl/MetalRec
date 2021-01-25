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

namespace MetalRec
{
    public partial class MetalRec : Form
    {
        // Главный объект, который включает в себя все нужные объекты
        public MathLib ML = new MathLib();

        public Report Rpt;

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

            Application.Exit();
        }


        private void FormOptionDefault()
        {
            // Показать в заголовке главного окна номер текущей версии и пользвателя
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";

            // Установить редактируемый объект в PropertyGrid
            propertyGrid1.SelectedObject = new DataInput(ML);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                MathLib MLL = new MathLib();
                this.ML = MLL.LoadData(fileDefaultUserAppDataPath.ToString());
                FormOptionDefault();
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



        

        }

        private void btnRaschet_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show("Расчет успешно завершён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedIndex = 1;
            dataGridView1.Visible = true;


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

        private void btnOtchet_Click(object sender, EventArgs e)
        {
            CreateReportViewer();
        }

        private void CreateReportViewer()
        {
            Rpt = new Report();

            #region Подготовка данных для вывода в отчет

            // Исходные данные для отчета
            //List<cReportList> RepListInput = new List<cReportList>();
            //RepListInput.Add(new cReportList("Температура воздуха на выходе из рекуператора, °C", ML.tв2.ToString()));



            #endregion Подготовка данных для вывода в отчет
        }
    }
}
