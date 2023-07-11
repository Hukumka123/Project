using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Project
{
    public partial class CalculationForm : Form
    {
        #region Объявление переменных тарифов
        static double tHVS = 35.78;//Тариф ХВС
        static double tGVSTeplonos = 35.78;//Тариф ГВС Теплоноситель
        static double tGVSTepEner = 998.69;//Тариф ГВС Тепловая энергия
        static double tEE = 4.28;//Тариф ЭЭ общий
        static double tEED = 4.9;//Тариф ЭЭ день
        static double tEEN = 2.31;//Тариф ЭЭ ночь
        #endregion

        #region Объявление переменных нормативов
        public double nHVS = 4.85;//Норматив ХВС
        public double nEE = 164;//Норматив ЭЭ
        public double nGVSTeplonos = 4.01;//Норматив ГВС Теплоноситель
        public double nGVSTepEner = 0.05349;//Норматив ГВС Тепловая энергия
        #endregion

        #region Объявление переменных для объема потребления услуг
        public double vHVS = 0;//Объем потребления ХВС
        public double vGVSTeplonos = 0;//Объем потребления ГВС Теплоноситель
        public double vGVSTepEner = 0;//Объем потребления ГВС Тепловая энергия
        public double vEE = 0;//Объем потребления ЭЭ общий
        public double vEED = 0;//Объем потребления ЭЭ день
        public double vEEN = 0;//Объем потребления ЭЭ ночь
        #endregion

        #region Объявление переменных со стоимостью каждой услуги за текущий месяц
        public double costHVS = 0;//Стоимость услуги ХВС
        public double costGVSTeplonos = 0;//Стоимость услуги ГВС Теплоноситель
        public double costGVSTepEner = 0;//Стоимость услуги ГВС Тепловая энергия
        public double costEE = 0;//Стоимость услуги ЭЭ общий
        public double costEED = 0;//Стоимость услуги ЭЭ день
        public double costEEN = 0;//Стоимость услуги ЭЭ ночь
        public double totalCost = 0;//Общая стоимость всех услуг
        #endregion

        #region Объявление переменных показаний предыдущего расчетного месяца
        public double prevMonthHVS = 0;//Показания предыдущего месяца за ХВС
        public double prevMonthGVSTeplonos = 0;//Показания предыдущего месяца за ГВС
        public double prevMonthEED = 0;//Показания предыдущего месяца за ЭЭ день
        public double prevMonthEEN = 0;//Показания предыдущего месяца за ЭЭ ночь
        public string prevMonth;//переменная для хранения даты предыдущего месяца (месяц + год)
        #endregion

        public CalculationForm()
        {
            InitializeComponent();
        }
        private void btnInputReadings_Click(object sender, EventArgs e)
        {
            ReadingsForm RF = new ReadingsForm();
            RF.Owner = this;
            RF.Show();
        }

        public void CheckPrevMonth()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source = Показания.db");
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            //Выполнение запроса на поиск строки, у которой совпадает искомого значения расчетного месяца
            command.CommandText = $"SELECT count(*) FROM Recordings WHERE \"Расчетный месяц\" = '{prevMonth}'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if(count == 1)//Если строка найдена
            {
                SQLiteCommand readcommand = connection.CreateCommand();
                //Выполнения запроса на поиск значений в найденной строке
                readcommand.CommandText = $"SELECT * FROM Recordings WHERE \"Расчетный месяц\" = '{prevMonth}'";
                SQLiteDataReader reader = readcommand.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())//Чтение строки из базы данных
                    {
                        prevMonthHVS = reader.GetDouble(2);//Нахождение показаний ХВС за предыдущий месяц
                        prevMonthEED = reader.GetDouble(3);//Нахождение показаний ЭЭ день за предыдущий месяц
                        prevMonthEEN = reader.GetDouble(4);//Нахождение показаний ЭЭ ночь за предыдущий месяц
                        prevMonthGVSTeplonos = reader.GetDouble(5);//Нахождение показаний ГВС Теплоноситель за предыдущий месяц
                    }
                }
            }
            else//Если строка не найдена
            {
                MessageBox.Show("Нет показаний за предыдущий месяц");
            }
        }

        //Метод для расчета объема потребления и стоимости за услугу ХВС за текущий месяц
        public void CalculateHVS(double currentHVS, int residents, bool availabHVS)
        {
            if(availabHVS == true)//Если имеется прибор учета ХВС
            {
                vHVS = currentHVS - prevMonthHVS;//Формула расчёта ХВС по показаниям приборов учета
                costHVS = vHVS * tHVS;//Формула расчёта начислений по ХВС по общему алгоритму
                lblBillingMonthHVS.Text = currentHVS.ToString("F2"); 
            }
            else//Если отсутствует прибор учета ХВС
            {
                vHVS = residents * nHVS;//Формула расчёта ХВС по нормативному объему
                costHVS = vHVS * tHVS;//Формула расчёта начислений по ХВС по общему алгоритму
            }

            //Отображение результатов расчета услуги ХВС на главном окне программы
            lblPrevMonthHVS.Text = prevMonthHVS.ToString("F2");
            lblUtilitiesHVS.Text = vHVS.ToString("F2");
            lblCostUtilitiesHVS.Text = costHVS.ToString("F2");
        }

        //Метод для расчета объема потребления и стоимости за услугу ГВС за текущий месяц
        public void CalculateGVS(double currentGVS, int residents, bool availabGVS)
        {
            if(availabGVS == true)//Если имеется прибор учета ГВС
            {
                vGVSTeplonos = currentGVS - prevMonthGVSTeplonos;//Формула расчёта ГВС Теплоноситель по показаниям приборов учета
                costGVSTeplonos = vGVSTeplonos * tGVSTeplonos;//Формула расчёта начислений по ГВС Теплоноситель по общему алгоритму
                lblBillingMonthGVSTeplonos.Text = currentGVS.ToString("F2");
            }
            else//Если отсутствует прибор учета ГВС
            {
                vGVSTeplonos = residents * nGVSTeplonos;//Формула расчёта ГВС Теплоноситель по нормативному объему
                costGVSTeplonos = vGVSTeplonos * tGVSTeplonos;//Формула расчёта начислений по ГВС Теплоноситель по общему алгоритму
            }

            vGVSTepEner = vGVSTeplonos * nGVSTepEner;//Формула расчёта затрат на ГВС Тепловая энергия
            costGVSTepEner = vGVSTepEner * tGVSTepEner;//Формула расчёта начислений по ГВС Тепловая энергия по общему алгоритму

            //Отображение результатов расчета услуг ГВС Тепловая энергия и ГВС Теплоноситель на главном окне программы
            lblPrevMonthGVSTeplonos.Text = prevMonthGVSTeplonos.ToString("F2");
            lblUtilitiesGVSTeplonos.Text = vGVSTeplonos.ToString("F2");
            lblCostUtilitiesGVSTeplonos.Text = costGVSTeplonos.ToString("F2");
            lblUtilitiesGVSTepEner.Text = vGVSTepEner.ToString("F2");
            lblCostUtilitiesGVSTepEner.Text = costGVSTepEner.ToString("F2");
        }

        //Метод для расчета объема потребления и стоимости за услугу ЭЭ за текущий месяц
        public void CalculateEE(double currentEEN, double currentEED, int residents, bool availabEE)
        {
            if(availabEE == true)//Если имеется прибор учета ЭЭ
            {
                vEEN = currentEEN - prevMonthEEN;//Формула расчёта ЭЭ ночь по показаниям приборов учета
                costEEN = vEEN * tEEN;//Формула расчёта начислений по ЭЭ ночь по общему алгоритму

                //Отображение результатов расчета услуги ЭЭ ночь на главном окне программы
                lblBillingMonthEEN.Text = currentEEN.ToString("F2");
                lblPrevMonthEEN.Text = prevMonthEEN.ToString("F2");
                lblUtilitiesEEN.Text = vEEN.ToString("F2");
                lblCostUtilitiesEEN.Text = costEEN.ToString("F2");

                vEED = currentEED - prevMonthEED;//Формула расчёта ЭЭ день по показаниям приборов учета
                costEED = vEED * tEED;//Формула расчёта начислений по ЭЭ день по общему алгоритму

                //Отображение результатов расчета услуги ЭЭ день на главном окне программы
                lblBillingMonthEED.Text = currentEED.ToString("F2");
                lblPrevMonthEED.Text = prevMonthEED.ToString("F2");
                lblUtilitiesEED.Text = vEED.ToString("F2");
                lblCostUtilitiesEED.Text = costEED.ToString("F2");
            }
            else//Если отсутствует прибор учета ЭЭ
            {
                vEE = residents * nEE;//Формула расчёта ЭЭ общее по нормативному объему
                costEE = vEE * tEE;//Формула расчёта начислений по ЭЭ общее по общему алгоритму

                //Отображение результатов расчета услуги ЭЭ общее на главном окне программы
                lblUtilitiesEE.Text = vEE.ToString("F2");
                lblCostUtilitiesEE.Text = costEE.ToString("F2");
            }
        }

        //Метод для расчета общей стоимости всех услуг
        public void TotalCost()
        {
            totalCost = costHVS + costGVSTeplonos + costGVSTepEner + costEE + costEED + costEEN;//Формула подсчета общей стоимости услуг

            //Отображение результатов в главном окне программы
            lblTotalCost.Text = totalCost.ToString("F2");
        }
    }
}

