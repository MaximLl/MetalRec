using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using MetalRecDLL;

namespace MetalRec
{  
    [Serializable]
	public class DataOutput
    {
        // Главный объект, который включает в себя все нужные объекты
        private MathLib _ML = new MathLib();

        public DataOutput(MathLib ML)
        {
            _ML = ML;
        }

        [Description("Теплоемкость воздуха, Дж/(м3*K)")]
        [DisplayName("Св, Дж/(м3*K)")]      
        public double get_Св
        {
            get { return _ML.get_Св(); }            
        }


        [Description("Теплоемкость дыма, Дж/(м3K)")]
        [DisplayName("Сд, Дж/(м3K)")]
        public double Get_Сд
        {
            get { return _ML.get_Сд(); }
        }

        [Description("Энтальпия воздуха при начальной температуре, кДж/м3")]
        [DisplayName("I''в, кДж/м3")]
        public double get_Iв2
        {
            get { return _ML.get_Iв2(); }
        }

        [Description("Энтальпия дыма при начальной температуре, кДж/м3")]
        [DisplayName("I'д, кДж/м3")]
        public double get_Iд
        {
            get { return _ML.get_Iд1(); }
        }

        [Description("Средняя температура воздуха, оС")]
        [DisplayName("Тв, оС")]
        public double get_Tв
        {
            get { return _ML.get_Tв(); }
        }

        [Description("Фактическая скорость воздуха, м/с")]
        [DisplayName("Wво, м/с")]
        public double get_Wво
        {
            get { return _ML.get_Wво(); }
        }

        [Description("Фактическая скорость продуктов сгорания, м/с")]
        [DisplayName("Wдо, м/с")]
        public double get_Wдо
        {
            get { return _ML.get_Wдо(); }
        }

        [Description("Действительная скорость воздуха, м/с")]
        [DisplayName("Wв, м/с")]
        public double get_Wв
        {
            get { return _ML.get_Wв(); }
        }

        [Description("Действительная скорость продуктов сгорания, м/с")]
        [DisplayName("Wд, м/с")]
        public double get_Wд
        {
            get { return _ML.get_Wд(); }
        }

        [Description("Количество тепла, переданного воздуху, Квт")]
        [DisplayName("Qв, Квт")]
        public double get_Qв
        {
            get { return _ML.get_Qв(); }
        }

        [Description("Количество тепла,вносимое в теплообменный аппарат продуктами сгорания, Квт")]
        [DisplayName("Q'д, Квт")]
        public double get_Qд1
        {
            get { return _ML.get_Qд1(); }
        }

        [Description("Количество тепла,уносимое продуктами сгорания, Квт")]
        [DisplayName("Q''д, Квт")]
        public double get_Qд2
        {
            get { return _ML.get_Qд2(); }
        }

        [Description("Энтальпия продуктов сгорания, кДж/м3")]
        [DisplayName("i''д, кДж/м3")]
        public double get_iд2
        {
            get { return _ML.get_iд2(); }
        }

        [Description("Температура продуктов сгорания после рекуператора, оС")]
        [DisplayName("t''д, оС")]
        public double get_Tд2
        {
            get { return _ML.get_Tд2(); }
        }

        [Description("Cреднелогарифмическая разность температур")]
        [DisplayName("⌂tср")]
        public double get_tср
        {
            get { return _ML.get_tср(); }
        }

        [Description("Параметр")]
        [DisplayName("R")]
        public double get_R
        {
            get { return _ML.get_R(); }
        }

        [Description("Параметр")]
        [DisplayName("P")]
        public double get_P
        {
            get { return _ML.get_P(); }
        }

        [Description("Число Рейнольдса 1")]
        [DisplayName("P")]
        public double get_Re
        {
            get { return _ML.get_Re(); }
        }

        [Description("Средняя температура дыма, оС")]
        [DisplayName("Tд, оС")]
        public double get_Tд
        {
            get { return _ML.get_Tд(); }
        }

        [Description("Средняя температура стенки рекуператора, оС")]
        [DisplayName("Tст, оС")]
        public double get_Tст
        {
            get { return _ML.get_Tст(); }
        }

        [Description("Отношение Тст/Тв")]
        [DisplayName("Tст, оС")]
        public double get_Тст_Тв
        {
            get { return _ML.get_Тст_Тв(); }
        }

        [Description("Поправочный коэффициент")]
        [DisplayName("Tст, оС")]
        public double get_kt
        {
            get { return _ML.get_kt(); }
        }

        [Description("Поправочный коэффициент (если изогнута труба)")]
        [DisplayName("Ки")]
        public double get_Ku
        {
            get { return _ML.get_Ku(); }
        }

        [Description("Суммарный поправочный коэффициент 1")]
        [DisplayName("Крек")]
        public double get_К_рек
        {
            get { return _ML.get_К_рек(); }
        }

        [Description("Число Нуссельта 1")]
        [DisplayName("Nu")]
        public double get_Nu
        {
            get { return _ML.get_Nu(); }
        }

        [Description("Коэффициент теплоотдачи конвекцией на пути движения воздуха, Вт/(м^2*оС)")]
        [DisplayName("αв, Вт/(м^2*оС)")]
        public double get_aв1
        {
            get { return _ML.get_aв1(); }
        }

        [Description("Коэффициент теплоотдачи конвекцией в пересчете на поверхность наружной трубы, Вт/(м^2*оС)")]
        [DisplayName("aв, Вт/(м^2*оС)")]
        public double get_aв
        {
            get { return _ML.get_aв(); }
        }

        [Description("Число Рейнольдса 2")]
        [DisplayName("Re")]
        public double get_Re1
        {
            get { return _ML.get_Re1(); }
        }

        [Description("Суммарный поправочный коэффициент 2")]
        [DisplayName("Крек")]
        public double get_К_рек1
        {
            get { return _ML.get_К_рек1(); }
        }

        [Description("Число Нуссельта 2")]
        [DisplayName("Nu")]
        public double get_Nu1
        {
            get { return _ML.get_Nu1(); }
        }

        [Description("Коэффициент конвективной теплоотдачи")]
        [DisplayName("αкд")]
        public double get_αкд
        {
            get { return _ML.get_αкд(); }
        }

        [Description("Эффективная длина луча")]
        [DisplayName("Sэф")]
        public double get_Sэф
        {
            get { return _ML.get_Sэф(); }
        }

        [Description("Коэффициент для газовой части печной среды")]
        [DisplayName("kг")]
        public double get_kг
        {
            get { return _ML.get_kг(); }
        }

        [Description("Отношение Ср/Нр")]
        [DisplayName("Cp/Hp")]
        public double get_Cp_Hp
        {
            get { return _ML.get_Cp_Hp(); }
        }

        [Description("Коэффициент")]
        [DisplayName("kc")]
        public double get_kc
        {
            get { return _ML.get_kc(); }
        }

        [Description("Связующая величина")]
        [DisplayName("x")]
        public double get_x
        {
            get { return _ML.get_x(); }
        }


        [Description("Расчетное значение доли излучения АЧТ")]
        [DisplayName("ɛ''г")]
        public double get_ɛг2
        {
            get { return _ML.get_ɛг2(); }
        }

        [Description("Коэффициент лучистой теплоотдачи, Вт/(м^2*оС)")]
        [DisplayName("αдл, Вт/(м^2*оС)")]
        public double get_αдл
        {
            get { return _ML.get_αдл(); }
        }

        [Description("Суммарный коэффициент теплоотдачи от пс к стенке, Вт/(м^2*оС)")]
        [DisplayName("αд, Вт/(м^2*оС)")]
        public double get_αд
        {
            get { return _ML.get_αд(); }
        }

        [Description("Суммарный коэффициент теплоотдачи от пс к стенке, Вт/(м^2*оС)")]
        [DisplayName("K*, Вт/(м^2*оС)")]
        public double get_Kзвезд
        {
            get { return _ML.get_Кзвезд(); }
        }

        [Description("Коэффициент теплопередачи с учетом загрязнения труб, Вт/(м^2*оС)")]
        [DisplayName("K, Вт/(м^2*оС)")]
        public double get_K
        {
            get { return _ML.get_K(); }
        }

        [Description("Коэффициент теплопередачи с учетом загрязнения труб, Вт/(м^2*оС)")]
        [DisplayName("F*, Вт/(м^2*оС)")]
        public double get_Fзвезд
        {
            get { return _ML.get_Fзвезд(); }
        }

        [Description("Плотность теплового потока от продуктов сгорания к воздуху, Вт/м2")]
        [DisplayName("q, Вт/м2")]
        public double get_q
        {
            get { return _ML.get_q(); }
        }

        [Description("Плотность теплового потока от продуктов сгорания к воздуху, Вт/м2")]
        [DisplayName("tст.max, Вт/м2")]
        public double get_t_ст_max
        {
            get { return _ML.get_t_ст_max(); }
        }


    }
    


}
