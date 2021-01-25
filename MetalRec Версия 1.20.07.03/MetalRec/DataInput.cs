using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MetalRecDLL;

namespace MetalRec
{
    [Serializable]
    class DataInput
    {
        // Главный объект, который включает в себя все нужные объекты
        private MathLib _ML = new MathLib();

        public DataInput(MathLib ML)
        {
            _ML = ML;
        }

        [Description("Температура воздуха на выходе из рекупратора, °C")]
        [DisplayName("t''в, °C")]
        [Category("Теплотехнические параметры")]
        public double tв2
        {
            get { return _ML.tв2; }
            set { _ML.tв2 = value; }
        }

        [Description("Температура воздуха на входе в рекуператор, °C")]
        [DisplayName("t'в, °C")]
        [Category("Теплотехнические параметры")]
        public double tв1
        {
            get { return _ML.tв1; }
            set { _ML.tв1 = value; }
        }

        [Description("Температура продуктов сгорания перед рекуператором, °C")]
        [DisplayName("t'д, °C")]
        [Category("Теплотехнические параметры")]
        public double tд1
        {
            get { return _ML.tд1; }
            set { _ML.tд1 = value; }
        }

        [Description("Расход воздуха, м3/с")]
        [DisplayName("Vв, м3/с")]
        [Category("Теплотехнические параметры")]
        public double Vв
        {
            get { return _ML.Vв; }
            set { _ML.Vв = value; }
        }

        [Description("Расход продуктов сгорания, м3/с")]
        [DisplayName("Vд, м3/с")]
        [Category("Теплотехнические параметры")]
        public double Vд
        {
            get { return _ML.Vд; }
            set { _ML.Vд = value; }
        }

        [Description("Количество вещества, %")]
        [DisplayName("СO2, %")]
        [Category("Процентное содержание веществ")]
        public double СO2
        {
            get { return _ML.СO2; }
            set { _ML.СO2 = value; }
        }

        [Description("Количество вещества, %")]
        [DisplayName("H2O, %")]
        [Category("Процентное содержание веществ")]
        public double H2O
        {
            get { return _ML.H2O; }
            set { _ML.H2O = value; }
        }

        [Description("Поправка на длину канала для Крек")]
        [DisplayName("Kl")]
        [Category("Поправки")]
        public double Kl
        {
            get { return _ML.Kl; }
            set { _ML.Kl = value; }
        }

        [Description("Коэфициент излучения АЧТ, Вт/(м2*К4)")]
        [DisplayName("Co")]
        [Category("Коэффициенты")]
        public double Co
        {
            get { return _ML.Co; }
            set { _ML.Co = value; }
        }

        [Description("Поправка  для Крек")]
        [DisplayName("Ки")]
        [Category("Поправки")]
        public double Ки
        {
            get { return _ML.Ки; }
            set { _ML.Ки = value; }
        }

        [Description("Эмпирический коэффициент для воздуха")]
        [DisplayName("A")]
        [Category("Коэффициенты")]
        public double A
        {
            get { return _ML.A; }
            set { _ML.A = value; }
        }

        [Description("Эмпирический коэффициент для воздуха")]
        [DisplayName("n")]
        [Category("Коэффициенты")]
        public double n
        {
            get { return _ML.n; }
            set { _ML.n = value; }
        }

        [Description("Эмпирический коэффициент для воздуха")]
        [DisplayName("m")]
        [Category("Коэффициенты")]
        public double m
        {
            get { return _ML.m; }
            set { _ML.m = value; }
        }

        [Description("Эмпирический коэффициент для продуктов сгорания")]
        [DisplayName("A")]
        [Category("Коэффициенты")]
        public double A1
        {
            get { return _ML.A1; }
            set { _ML.A1 = value; }
        }

        [Description("Эмпирический коэффициент для продуктов сгорания")]
        [DisplayName("n")]
        [Category("Коэффициенты")]
        public double n1
        {
            get { return _ML.n1; }
            set { _ML.n1 = value; }
        }

        [Description("Эмпирический коэффициент для продуктов сгорания")]
        [DisplayName("m")]
        [Category("Коэффициенты")]
        public double m1
        {
            get { return _ML.m1; }
            set { _ML.m1 = value; }
        }

        [Description("Коэффициент теплопроводности, Вт/(м3*оС)")]
        [DisplayName("λ, Вт/(м3*оС)")]
        [Category("Коэффициенты")]
        public double λ
        {
            get { return _ML.λ; }
            set { _ML.λ = value; }
        }

        [Description("Коэффициент кинематической вязкости, м2/с")]
        [DisplayName("ν * 10^-6, м2/с")]
        [Category("Коэффициенты")]
        public double ν10
        {
            get { return _ML.ν10; }
            set { _ML.ν10 = value; }
        }

        [Description("Число Прандтля")]
        [DisplayName("Pr")]
        [Category("Коэффициенты")]
        public double Pr
        {
            get { return _ML.Pr; }
            set { _ML.Pr = value; }
        }

        [Description("Коэффициент кинематической вязкости, м2/с")]
        [DisplayName("ν * 10^-6, м2/с")]
        [Category("Коэффициенты")]
        public double ν_10
        {
            get { return _ML.ν_10; }
            set { _ML.ν_10 = value; }
        }

        [Description("Число Прандтля")]
        [DisplayName("Pr")]
        [Category("Прочие параметры")]
        public double Pr1
        {
            get { return _ML.Pr1; }
            set { _ML.Pr1 = value; }
        }

        [Description("Коэффициент теплопроводности, Вт/(м3*оС)")]
        [DisplayName("λ, Вт/(м3*оС)")]
        [Category("Коэффициенты")]
        public double λ1
        {
            get { return _ML.λ1; }
            set { _ML.λ1 = value; }
        }

        [Description("Внешний диаметр трубы, м")]
        [DisplayName("d, м")]
        [Category("Геометрические параметры")]
        public double d
        {
            get { return _ML.d; }
            set { _ML.d = value; }
        }

        [Description("Внутренний диаметр трубы, м")]
        [DisplayName("dэ, м")]
        [Category("Геометрические параметры")]
        public double dэ
        {
            get { return _ML.dэ; }
            set { _ML.dэ = value; }
        }

        [Description("Проходное сечение для воздуха, м2")]
        [DisplayName("wв, м2")]
        [Category("Геометрические параметры")]
        public double wв
        {
            get { return _ML.wв; }
            set { _ML.wв = value; }
        }

        [Description("Проходное сечение для продуктов сгорания, м2")]
        [DisplayName("wд, м2")]
        [Category("Геометрические параметры")]
        public double wд
        {
            get { return _ML.wд; }
            set { _ML.wд = value; }
        }

        [Description("Поправочный коэффициент")]
        [DisplayName("ɛdt")]
        [Category("Коэффициенты")]
        public double ɛdt
        {
            get { return _ML.ɛdt; }
            set { _ML.ɛdt = value; }
        }

        [Description("Поправочный коэффициент на длину канала")]
        [DisplayName("Kl")]
        [Category("Коэффициенты")]
        public double Kl1
        {
            get { return _ML.Kl1; }
            set { _ML.Kl1 = value; }
        }

        [Description("Поправочный коэффициент на число труб")]
        [DisplayName("Kz")]
        [Category("Коэффициенты")]
        public double Kz
        {
            get { return _ML.Kz; }
            set { _ML.Kz = value; }
        }

        [Description("Поправочный коэффициент")]
        [DisplayName("Kt")]
        [Category("Коэффициенты")]
        public double Kt
        {
            get { return _ML.Kt; }
            set { _ML.Kt = value; }
        }

        [Description("Интегральная степень черноты")]
        [DisplayName("ɛг")]
        [Category("Теплотехнические параметры")]
        public double ɛг
        {
            get { return _ML.ɛг; }
            set { _ML.ɛг = value; }
        }

        [Description("Значение доли излучения АЧТ")]
        [DisplayName("α''г")]
        [Category("Теплотехнические параметры")]
        public double αг2
        {
            get { return _ML.αг2; }
            set { _ML.αг2 = value; }
        }

        [Description("Значение доли излучения АЧТ")]
        [DisplayName("α''ст")]
        [Category("Теплотехнические параметры")]
        public double αст2
        {
            get { return _ML.αст2; }
            set { _ML.αст2 = value; }
        }

        [Description("Радиус")]
        [DisplayName("R")]
        [Category("Радиусы")]
        public double r
        {
            get { return _ML.r; }
            set { _ML.r = value; }
        }
    }
}
