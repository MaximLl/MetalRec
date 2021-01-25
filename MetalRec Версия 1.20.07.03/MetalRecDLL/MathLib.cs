using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalRecDLL
{
    [Serializable]
    public class MathLib
    {

        #region Исходные данные

        /// <summary>
        /// Температура воздуха на выходе из рекуператора, °C
        /// </summary>
        private double _tв2; 
        public double tв2
        {
            get { return _tв2; }
            set { _tв2 = value; }
        }

        /// <summary>
        /// Температура воздуха на входе в рекуператор, °C
        /// </summary>
        private double _tв1;
        public double tв1
        {
            get { return _tв1; }
            set { _tв1 = value; }
        }


        /// <summary>
        /// Температура продуктов сгорания перед рекуператором, °C
        /// </summary>
        private double _tд1;
        public double tд1
        {
            get { return _tд1; }
            set { _tд1 = value; }
        }

        /// <summary>
        /// Расход воздуха, м3/с
        /// </summary>
        private double _Vв;
        public double Vв
        {
            get { return _Vв; }
            set { _Vв = value; }
        }

        /// <summary>
        /// Расход продуктов сгорания, м3/с
        /// </summary>
        private double _Vд;
        public double Vд
        {
            get { return _Vд; }
            set { _Vд = value; }
        }

        /// <summary>
        /// Количество вещества, %
        /// </summary>
        private double _СO2;
        public double СO2
        {
            get { return _СO2; }
            set { _СO2 = value; }
        }

        /// <summary>
        /// Количество вещества, %
        /// </summary>
        private double _H2O;
        public double H2O
        {
            get { return _H2O; }
            set { _H2O = value; }
        }

        /// <summary>
        /// Поправка на длину канала для Крек
        /// </summary>
        private double _Kl;
        public double Kl
        {
            get { return _Kl; }
            set { _Kl = value; }
        }

        /// <summary>
        /// Коэффициент излучения АЧТ, Вт/(м2*К4)
        /// </summary>
        private double _Co;
        public double Co
        {
            get { return _Co; }
            set { _Co = value; }
        }

        /// <summary>
        /// Поправка для Крек
        /// </summary>
        private double _Ки;
        public double Ки
        {
            get { return _Ки; }
            set { _Ки = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для воздуха 1
        /// </summary>
        private double _A;
        public double A
        {
            get { return _A; }
            set { _A = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для воздуха 2
        /// </summary>
        private double _n;
        public double n
        {
            get { return _n; }
            set { _n = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для воздуха 3
        /// </summary>
        private double _m;
        public double m
        {
            get { return _m; }
            set { _m = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для продуктов сгорания 1
        /// </summary>
        private double _A1;
        public double A1
        {
            get { return _A1; }
            set { _A1 = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для продуктов сгорания 2
        /// </summary>
        private double _n1;
        public double n1
        {
            get { return _n1; }
            set { _n1 = value; }
        }

        /// <summary>
        /// Эмпирический коэффициент для продуктов сгорания 3
        /// </summary>
        private double _m1;
        public double m1
        {
            get { return _m1; }
            set { _m1 = value; }
        }

        /// <summary>
        /// Коэффициент теплопроводности 1, Вт/(м3*оС)
        /// </summary>
        private double _λ;
        public double λ
        {
            get { return _λ; }
            set { _λ = value; }
        }

        /// <summary>
        /// Коэффициент кинематической вязкости 1, м2/с
        /// </summary>
        private double _ν10;
        public double ν10
        {
            get { return _ν10; }
            set { _ν10 = value; }
        }

        /// <summary>
        /// Число Прандтля 1
        /// </summary>
        private double _Pr;
        public double Pr
        {
            get { return _Pr; }
            set { _Pr = value; }
        }

        /// <summary>
        /// Коэффициент кинематической вязкости 2, м2/с
        /// </summary>
        private double _ν_10;
        public double ν_10
        {
            get { return _ν_10; }
            set { _ν_10 = value; }
        }

        /// <summary>
        /// Число Прандтля 2
        /// </summary>
        private double _Pr1;
        public double Pr1
        {
            get { return _Pr1; }
            set { _Pr1 = value; }
        }

        /// <summary>
        /// Коэффициент теплопроводности 2, Вт/(м3*оС)
        /// </summary>
        private double _λ1;
        public double λ1
        {
            get { return _λ1; }
            set { _λ1 = value; }
        }

        /// <summary>
        /// Внешний диаметр трубы, м
        /// </summary>
        private double _d;
        public double d
        {
            get { return _d; }
            set { _d = value; }
        }

        /// <summary>
        /// Внутренний диаметр трубы, м
        /// </summary>
        private double _dэ;
        public double dэ
        {
            get { return _dэ; }
            set { _dэ = value; }
        }

        /// <summary>
        /// Проходное сечение для воздуха, м2
        /// </summary>
        private double _wв;
        public double wв
        {
            get { return _wв; }
            set { _wв = value; }
        }

        /// <summary>
        /// Проходное сечение для продуктов сгорания, м2
        /// </summary>
        private double _wд;
        public double wд
        {
            get { return _wд; }
            set { _wд = value; }
        }

        /// <summary>
        /// Поправочный коэффициент
        /// </summary>
        private double _ɛdt;
        public double ɛdt
        {
            get { return _ɛdt; }
            set { _ɛdt = value; }
        }

        /// <summary>
        /// Поправочный коэффициент на длину канала 
        /// </summary>
        private double _Kl1;
        public double Kl1
        {
            get { return _Kl1; }
            set { _Kl1 = value; }
        }

        /// <summary>
        /// Поправочный коэффициент на число труб 
        /// </summary>
        private double _Kz;
        public double Kz
        {
            get { return _Kz; }
            set { _Kz = value; }
        }

        /// <summary>
        /// Поправочный коэффициент 1
        /// </summary>
        private double _Kt;
        public double Kt
        {
            get { return _Kt; }
            set { _Kt = value; }
        }

        /// <summary>
        /// Интегральная степень черноты 
        /// </summary>
        private double _ɛг;
        public double ɛг
        {
            get { return _ɛг; }
            set { _ɛг = value; }
        }

        /// <summary>
        /// Значение доли излучения АЧТ
        /// </summary>
        private double _αг2;
        public double αг2
        {
            get { return _αг2; }
            set { _αг2 = value; }
        }

        /// <summary>
        /// Значение доли излучения АЧТ
        /// </summary>
        private double _αст2;
        public double αст2
        {
            get { return _αст2; }
            set { _αст2 = value; }
        }

        /// <summary>
        /// Радиус
        /// </summary>
        private double _r;
        public double r
        {
            get { return _r; }
            set { _r = value; }
        }
        #endregion

        #region Методы сериализации/десериализации

        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public MathLib LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            MathLib _s = (MathLib)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _s;
        }

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(MathLib s, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, s);
            myStream.Close();
        }

        #endregion Методы сериализации/десериализации

        #region Расчет показателей
        /// <summary>
        /// Теплоемкость воздуха, Дж/(м3K)
        /// </summary> 
        private double _Св;    // закрытая переменная класса 
        public double get_Св()
        {
            return _Св = (0.1251 * _tв2) + 1309;
        }

        /// <summary>
        /// Теплоемкость дыма, Дж/(м3K)
        /// </summary> 
        private double _Сд;    // закрытая переменная класса 
        public double get_Сд()
        {
            return _Сд = (0.1251 * _tд1) + 1309;
        }

        /// <summary>
        /// Энтальпия воздуха при начальной температуре, кДж/м3
        /// </summary> 
        private double _Iв1;    // закрытая переменная класса 
        public double get_Iв1()
        {
            return _Iв1 = _Св * _tв1;
        }

        /// <summary>
        /// Энтальпия воздуха при конечной температуре, кДж/м3
        /// </summary> 
        private double _Iв2;    // закрытая переменная класса 
        public double get_Iв2()
        {
            return _Iв2 = _Св * _tв2;
        }

        /// <summary>
        /// Энтальпия дыма при начальной температуре, кДж/м3
        /// </summary> 
        private double _Iд1;    // закрытая переменная класса 
        public double get_Iд1()
        {
            return _Iд1 = _Сд * _tд1;
        }

        /// <summary>
        /// Средняя температура воздуха
        /// </summary> 
        private double _Tв;    // закрытая переменная класса 
        public double get_Tв()
        {
            return _Tв = 0.5 * (_tв2 + _tв1);
        }

        /// <summary>
        /// Фактическая скорость воздуха, м/с
        /// </summary> 
        private double _Wво;    // закрытая переменная класса 
        public double get_Wво()
        {
            return _Wво = _Vв / _wв;
        }

        /// <summary>
        /// Фактическая скорость продуктов сгорания, м/с
        /// </summary> 
        private double _Wдо;    // закрытая переменная класса 
        public double get_Wдо()
        {
            return _Wдо = _Vд / _wд;
        }

        /// <summary>
        /// Действительная скорость воздуха, м/с
        /// </summary> 
        private double _Wв;    // закрытая переменная класса 
        public double get_Wв()
        {
            return _Wв =  _Wво * (1 + 200 / 273);
        }

        /// <summary>
        /// Действительная скорость продуктов сгорания, м/с
        /// </summary> 
        private double _Wд;    // закрытая переменная класса 
        public double get_Wд()
        {
            return _Wд = _Wдо * (1 + _Tд / 273);
        }

        /// <summary>
        /// Количество тепла, переданного воздуху, Квт
        /// </summary> 
        private double _Qв;    // закрытая переменная класса 
        public double get_Qв()
        {
            return _Qв = _Vв * (_Iв2 - _Iв1) / 1000;
        }

        /// <summary>
        /// Количество тепла,вносимое в теплообменный аппарат продуктами сгорания, Квт
        /// </summary> 
        private double _Qд1;    // закрытая переменная класса 
        public double get_Qд1()
        {
            return _Qд1 = (_Vд * _Iд1) / 1000;
        }

        /// <summary>
        /// Количество тепла,уносимое продуктами сгорания, Квт
        /// </summary> 
        private double _Qд2;    // закрытая переменная класса 
        public double get_Qд2()
        {
            return _Qд2 = 0.95 * _Qд1 - _Qв;
        }

        /// <summary>
        /// Энтальпия продуктов сгорания, кДж/м3
        /// </summary> 
        private double _iд2;    // закрытая переменная класса 
        public double get_iд2()
        {
            return _iд2 = _Qд2 / _Vд;
        }

        /// <summary>
        /// Температура продуктов сгорания после рекуператора, оС
        /// </summary> 
        private double _Tд2;    // закрытая переменная класса 
        public double get_Tд2()
        {
            return _Tд2 = (_iд2 * 1000) / _Сд;
        }

        /// <summary>
        /// Cреднелогарифмическая разность температур 
        /// </summary> 
        private double _tср;    // закрытая переменная класса 
        public double get_tср()
        {
            return _tср = ((_tд1 - _tв2) - (_Tд2)) / (2.3 * Math.Log10((_tд1 - _tв2) / (_Tд2 - _tв1)));
        }

        /// <summary>
        /// Параметр 
        /// </summary> 
        private double _R;    // закрытая переменная класса 
        public double get_R()
        {
            return _R = (_tд1 - _Tд2) / (_tв2 - _tв1);
        }

        /// <summary>
        /// Параметр 
        /// </summary> 
        private double _P;    // закрытая переменная класса 
        public double get_P()
        {
            return _P = (_tв2 - _tв1) / (_tд1 - _tв1);
        }

        /// <summary>
        /// Число Рейнольдса 1
        /// </summary> 
        private double _Re;    // закрытая переменная класса 
        public double get_Re()
        {
            return _Re = _Wв * _dэ / (_ν10 * Math.Pow(10, -6));
        }

        /// <summary>
        /// Средняя температура дыма 
        /// </summary> 
        private double _Tд;    // закрытая переменная класса 
        public double get_Tд()
        {
            return _Tд = 0.5 * (_tд1 + _Tд2);
        }

        /// <summary>
        /// Средняя температура стенки рекуператора 
        /// </summary> 
        private double _Tст;    // закрытая переменная класса 
        public double get_Tст()
        {
            return _Tст = 0.5 * (0.5 * (_tд1 + _Tд2) + 0.5 * (_tв2 + _tв2));
        }

        /// <summary>
        /// Отношение Тст/Тв
        /// </summary> 
        private double _Тст_Тв;    // закрытая переменная класса 
        public double get_Тст_Тв()
        {
            return _Тст_Тв = (_Tст + 273) / (_Tв + 273);
        }

        /// <summary>
        /// Поправочный коэффициент 
        /// </summary> 
        private double _kt;    // закрытая переменная класса 
        public double get_kt()
        {
            return _kt = Math.Pow(_Тст_Тв, -0.55);
        }

        /// <summary>
        /// Поправочный коэффициент (если изогнута труба) 
        /// </summary> 
        private double _Ku;    // закрытая переменная класса 
        public double get_Ku()
        {
            return _Ku = 1 +(1.8 * _d * 1000) / (_r / 2);
        }

        /// <summary>
        /// Суммарный поправочный коэффициент 1
        /// </summary> 
        private double _К_рек;    // закрытая переменная класса 
        public double get_К_рек()
        {
            return _К_рек = _kt * _Kl1 * _Ku;
        }

        /// <summary>
        /// Число Нуссельта 1
        /// </summary> 
        private double _Nu;    // закрытая переменная класса 
        public double get_Nu()
        {
            return _Nu = _A * Math.Pow(_Re, _n) * Math.Pow(_Pr, _m) * _К_рек;
        }

        /// <summary>
        /// Коэффициент теплоотдачи конвекцией на пути движения воздуха, Вт/(м^2*оС) 
        /// </summary> 
        private double _aв1;    // закрытая переменная класса 
        public double get_aв1()
        {
            return _aв1 = (_Nu * _λ) / _dэ;
        }

        /// <summary>
        /// 2, Вт/(м^2*оС) 
        /// </summary> 
        private double _aв;    // закрытая переменная класса 
        public double get_aв()
        {
            return _aв = (_aв1 * _dэ) / _d;
        }

        /// <summary>
        /// Число Рейнольдса 2
        /// </summary> 
        private double _Re1;    // закрытая переменная класса 
        public double get_Re1()
        {
            return _Re1 = (_Wд * _d) / (_ν_10 * Math.Pow(10, 6));
        }

        /// <summary>
        /// Суммарный поправочный коэффициент 2
        /// </summary> 
        private double _К_рек1;    // закрытая переменная класса 
        public double get_К_рек1()
        {
            return _К_рек1 = _Kz * _Kt;
        }

        /// <summary>
        /// Число Нуссельта 2
        /// </summary> 
        private double _Nu1;    // закрытая переменная класса 
        public double get_Nu1()
        {
            return _Nu1 = _A1 * Math.Pow(_Re1, n1) * Math.Pow(_Pr1, _m1) * _К_рек1;
        }

        /// <summary>
        /// Коэффициент конвективной теплоотдачи
        /// </summary> 
        private double _αкд;    // закрытая переменная класса 
        public double get_αкд()
        {
            return _αкд = (_Nu1 * _λ1) / _d;
        }

        /// <summary>
        /// Эффективная длина луча
        /// </summary> 
        private double _Sэф;    // закрытая переменная класса 
        public double get_Sэф()
        {
            return _Sэф = 1.2 * 3.5 * _d;
        }

        /// <summary>
        /// Коэффициент для газовой части печной среды
        /// </summary> 
        private double _kг;    // закрытая переменная класса 
        public double get_kг()
        {
            return _kг = ((0.78 + 0.016 * _H2O) / Math.Sqrt(0.01 *(_СO2 + _H2O) * _Sэф) - 0.1) * (1 - 0.37 * _Tд / 1000) * 0.01 * (_СO2 + _H2O);
        }

        /// <summary>
        /// 
        /// </summary> 
        private double _Cp_Hp;    // закрытая переменная класса 
        public double get_Cp_Hp()
        {
            return _Cp_Hp = 0.12 * (_СO2 + _H2O) * (1 / 2);
        }

        /// <summary>
        /// 
        /// </summary> 
        private double _kc;    // закрытая переменная класса 
        public double get_kc()
        {
            return _kc = 0.03 * (2 - 1.22) * (0.0016 * (_Tд + 273) - 0.5) * _Cp_Hp;
        }

        /// <summary>
        /// Связующая величина
        /// </summary> 
        private double _x;    // закрытая переменная класса 
        public double get_x()
        {
            return _x = (_kг + _kc) * _Sэф;
        }

        /// <summary>
        /// 
        /// </summary> 
        private double _ɛг2;    // закрытая переменная класса 
        public double get_ɛг2()
        {
            return _ɛг2 = _ɛг / _αг2;
        }

        /// <summary>
        /// Коэффициент лучистой теплоотдачи, Вт/(м^2*оС)
        /// </summary> 
        private double _αдл;    // закрытая переменная класса 
        public double get_αдл()
        {
            return _αдл = (_Co * _αст2) / ((1 / _ɛг2) + (1 / 0.8) - 1) * Math.Pow((_αг2 / _αст2) * ((_Tд + 273) / 100), 4) - Math.Pow((_Tст + 273) / 100, 4) / (_Tд - _Tст);
        }

        /// <summary>
        /// Суммарный коэффициент теплоотдачи от пс к стенке, Вт/(м^2*оС)
        /// </summary> 
        private double _αд;    // закрытая переменная класса 
        public double get_αд()
        {
            return _αд = _αкд + _αдл;
        }

        /// <summary>
        /// Коэффициент теплопередачи, Вт/(м^2*оС)
        /// </summary> 
        private double _Кзвезд;    // закрытая переменная класса 
        public double get_Кзвезд()
        {
            return _Кзвезд = 1 / ((1 / _αд) + (1 / _aв));
        }

        /// <summary>
        /// Коэффициент теплопередачи с учетом загрязнения труб, Вт/(м^2*оС)
        /// </summary> 
        private double _K;    // закрытая переменная класса 
        public double get_K()
        {
            return _K = _Кзвезд / 1.1;
        }

        /// <summary>
        /// Поверхность нагрева
        /// </summary> 
        private double _Fзвезд;    // закрытая переменная класса 
        public double get_Fзвезд()
        {
            return _Fзвезд = _Qв / _tср * _K * _ɛdt;
        }

        /// <summary>
        /// Плотность теплового потока от продуктов сгорания к воздуху, Вт/м2
        /// </summary> 
        private double _q;    // закрытая переменная класса 
        public double get_q()
        {
            return _q = _K * (_tд1 - _Tд2);
        }

        /// <summary>
        /// Максимальная температура стенки
        /// </summary> 
        private double _t_ст_max;    // закрытая переменная класса 
        public double get_t_ст_max()
        {
            return _t_ст_max = _tд1 - _q / _αд * 1.3;
        }
        #endregion Расчет показателей
    }
}
