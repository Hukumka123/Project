using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Project
{
    public partial class ReadingsForm : Form
    {
        public ReadingsForm()
        {
            InitializeComponent();
        }

        private void btnSaveReadingsRF_Click(object sender, EventArgs e)
        {
            CalculationForm CF = new CalculationForm();
            CF.Owner = this;
            SavingReadings();//Вызов метода для сохранения введенных показаний в базе данных
            this.Close();
        }

        public void SavingReadings()
        {
            CalculationForm CF = this.Owner as CalculationForm;
            //Проверка на заполненность всех показаний приборов учета
            if ((tbNumberOfResidentsRF.Text == "" || tbNumberOfResidentsRF.Text == "0") ||
                (cbCheckHVSRB.Checked && (tbReadingsHVSRF.Text == "" || tbReadingsHVSRF.Text == "0")) ||
                (cbCheckGVSRF.Checked && (tbReadingsGVSRF.Text == "" || tbReadingsGVSRF.Text == "0")) ||
                (cbCheckEERF.Checked && (tbReadingsEEDayRF.Text == "" || tbReadingsEEDayRF.Text == "0" || tbReadingsEENightRF.Text == "" || tbReadingsEENightRF.Text == "0"))
                )
            {
                MessageBox.Show("Заполните все показания");
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source = Показания.db");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                //Выполнение запроса на добавление/заменю данных в текущем расчетном месяце
                command.CommandText = $"REPLACE INTO Recordings('Расчетный месяц', 'Количество проживающих', 'ХВС','ЭЭ день', 'ЭЭ ночь', 'ГВС Теплоноситель')" +
                                      $"VALUES ('{dtpBillingMonthRF.Text}', '{tbNumberOfResidentsRF.Text}', '{tbReadingsHVSRF.Text}', '{tbReadingsEENightRF.Text}', '{tbReadingsEEDayRF.Text}', '{tbReadingsGVSRF.Text}')";
                command.ExecuteNonQuery();

                //Отображение текущего месяца на экране
                CF.lblBillingDateCF.Text = dtpBillingMonthRF.Text;
                //Вызов метода вычисления предыдущего месяца из текущего
                PrevMonthSet();
                //Вызов методов расчета коммунальных услуг
                CF.CalculateHVS(Convert.ToDouble(tbReadingsHVSRF.Text), Convert.ToInt32(tbNumberOfResidentsRF.Text), cbCheckHVSRB.Checked);
                CF.CalculateGVS(Convert.ToDouble(tbReadingsGVSRF.Text), Convert.ToInt32(tbNumberOfResidentsRF.Text), cbCheckGVSRF.Checked);
                CF.CalculateEE(Convert.ToDouble(tbReadingsEENightRF.Text), Convert.ToDouble(tbReadingsEEDayRF.Text), Convert.ToInt32(tbNumberOfResidentsRF.Text), cbCheckEERF.Checked);
                //Вызов метода расчета общей стоимости услуг
                CF.TotalCost();
            }
        }

        //Метод для вычисления предыдущего месяца из текущего
        public void PrevMonthSet()
        {
            CalculationForm CF = this.Owner as CalculationForm;
            if (cbCheckHVSRB.Checked || cbCheckGVSRF.Checked || cbCheckEERF.Checked)
            {
                string[] date = dtpBillingMonthRF.Value.ToString().Split('.', ' ');//разделение текущей даты на части
                string month = date[1];//переменная для хранения месяца
                string year = date[2];//переменная для хранения года
                if (month == "01")
                {
                    month = "12";
                    year = Convert.ToString(Convert.ToInt32(year) - 1);
                }
                else if (month == "12" || month == "11")
                {
                    month = Convert.ToString(Convert.ToInt32(month) - 1);
                }
                else
                {
                    month = "0" + Convert.ToString(Convert.ToInt32(month) - 1);
                }
                CF.prevMonth = month + "." + year;
            };
            CF.CheckPrevMonth();//Вызов метода для проверки на наличие показаний предыдущего месяца в базе данных
        }


        #region Методы для отображения/скрытия полей для ввода показаний приборов учета
        private void cbCheckHVSRB_CheckedChanged(object sender, EventArgs e)//Метод отображения/скрытия полей для прибора учета ХВС
        {
            if(cbCheckHVSRB.Checked)
            {
                lblReadingsHVSRF.Visible = true;
                tbReadingsHVSRF.Visible = true;
            }
            else
            {
                lblReadingsHVSRF.Visible = false;
                tbReadingsHVSRF.Visible = false;
                tbReadingsHVSRF.Text = "0";
            }
        }

        private void cbCheckGVSRF_CheckedChanged(object sender, EventArgs e)//Метод отображения/скрытия полей для прибора учета ГВС
        {
            if (cbCheckGVSRF.Checked)
            {
                lblReadingsGVSRF.Visible = true;
                tbReadingsGVSRF.Visible = true;
            }
            else
            {
                lblReadingsGVSRF.Visible = false;
                tbReadingsGVSRF.Visible = false;
                tbReadingsGVSRF.Text = "0";
            }
        }

        private void cbCheckEERF_CheckedChanged(object sender, EventArgs e)//Метод отображения/скрытия полей для прибора учета ЭЭ
        {
            if (cbCheckEERF.Checked)
            {
                lblReadingsEEDayRF.Visible = true;
                lblReadingsEENightRF.Visible = true;
                tbReadingsEEDayRF.Visible = true;
                tbReadingsEENightRF.Visible = true;
            }
            else
            {
                lblReadingsEEDayRF.Visible = false;
                lblReadingsEENightRF.Visible = false;
                tbReadingsEEDayRF.Visible = false;
                tbReadingsEENightRF.Visible = false;
                tbReadingsEEDayRF.Text = "0";
                tbReadingsEENightRF.Text = "0";
            }
        }
        #endregion

        //Метод для контроля ввода значений
        //Разрешены для ввода только кнопки с цифрами, точками и backspace
        private void tbRF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8) e.Handled = true;
        }
    }
}
