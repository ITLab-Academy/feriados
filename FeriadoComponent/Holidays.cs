using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriadoComponent
{
    public class Holidays
    {
        private List<Holiday> HolidaysList = new List<Holiday>();

        public Holidays()
        {
            SetStaticHolidays();
        }

        public Holidays(int[] Years)
        {
            SetStaticHolidays();

            foreach (var year in Years)
            {
                var easter = CalculoPascoa(year);
                var carnival = CalculoCarnaval(year);
                var corpusChrist = easter.AddDays(60);
                var goodFriday = easter.AddDays(-2);
                HolidaysList.Add(new Holiday() { Year = year, Month = easter.Month, Day = easter.Day, Description = "Pascoa" });
                HolidaysList.Add(new Holiday() { Year = year, Month = carnival.Month, Day = carnival.Day, Description = "Carnaval" });
                HolidaysList.Add(new Holiday() { Year = year, Month = corpusChrist.Month, Day = corpusChrist.Day, Description = "Corpus Christ" });
                HolidaysList.Add(new Holiday() { Year = year, Month = goodFriday.Month, Day = goodFriday.Day, Description = "Sexta-feira santa" }); 
            }
        }

        private void SetStaticHolidays()
        {
            HolidaysList.Add(new Holiday() { Month = 1, Day = 1, Description = "Ano novo" });
            HolidaysList.Add(new Holiday() { Month = 4, Day = 21, Description = "Tiradentes" });
            HolidaysList.Add(new Holiday() { Month = 5, Day = 1, Description = "Dia do trabalhador" });
            HolidaysList.Add(new Holiday() { Month = 9, Day = 7, Description = "Independencia" });
            HolidaysList.Add(new Holiday() { Month = 10, Day = 12, Description = "Nossa senhora de aparecida" });
            HolidaysList.Add(new Holiday() { Month = 11, Day = 2, Description = "Finados" });
            HolidaysList.Add(new Holiday() { Month = 11, Day = 15, Description = "Proclamação da republica" });
            HolidaysList.Add(new Holiday() { Month = 12, Day = 25, Description = "Natal" });
        }

        public void Add(Holiday holiday)
        {
            HolidaysList.Add(holiday);
        }

        public void AddHolidaysSP()
        {
            HolidaysList.Add(new Holiday() { Month = 11, Day = 20, Description = "Consciência Negra" });
            HolidaysList.Add(new Holiday() { Month = 07, Day = 09, Description = "Revolução Constitucionalista"});
        }

        public List<Holiday> GetHolidays()
        {
            return HolidaysList;
        }

        public static bool IsHoliday(DateTime date, bool isOptionalDate)
        {
            if (IsNewYear(date)) return true;

            if (IsSaoPauloBirthday(date)) return true;

            if (IsTiradentes(date)) return true;

            if (IsWorkDay(date)) return true;

            if (IsRevolutionDay(date)) return true;

            if (IsGoodFriday(date)) return true;

            if (IsIndependenceDay(date)) return true;

            if (IsChildrensDay(date)) return true;

            if (IsAllSoulsDay(date)) return true;

            if (IsRepublicProclamation(date)) return true;

            if (IsBlackConsciousnessDay(date)) return true;

            if (IsChristmasDay(date)) return true;

            if (IsCarnaval(date)) return true;

            if (IsCorpusChristi(date)) return true;

            if (isOptionalDate && IsOptionalDate(date)) return true;

            return false;

        }

        public static bool IsNewYear(DateTime date)
        {
            if (date.Month == 01 && date.Day == 01) return true;

            return false;
        }

        public static bool IsTiradentes(DateTime date)
        {
            if (date.Month == 04 && date.Day == 21) return true;

            return false;
        }

        public static bool IsSaoPauloBirthday(DateTime date)
        {
            if (date.Month == 01 && date.Day == 25) return true;

            return false;
        }

        public static bool IsWorkDay(DateTime date)
        {
            if (date.Month == 05 && date.Day == 01) return true;

            return false;
        }

        public static bool IsRevolutionDay(DateTime date)
        {
            if (date.Month == 07 && date.Day == 09) return true;

            return false;
        }

        public static bool IsGoodFriday(DateTime date)
        {
            var pascoa = CalculoPascoa(date.Year);
            var goodFriday = pascoa.AddDays(-2); //TODO: Revisar esse codigo pois temos duplicidade (Sexta-feira santa)

            if (goodFriday == date) return true;

            return false;
        }

        public static DateTime CalculoPascoa(int year)
        {
            // Duvidas: http://www.vision.ime.usp.br/~pmiranda/mc102_1s07/lab01/lab.html

            var y_ano = year;
            var g_resto_divisao = y_ano % 19 + 1;
            var c_quociente = (y_ano / 100) + 1;
            var x_quociente = ((3 * c_quociente) / 4) - 12;
            var z_quociente = ((8 * c_quociente + 5) / 25) - 5;
            var e_resto_divisao = (11 * g_resto_divisao + 20 + z_quociente - x_quociente) % 30;

            if ((e_resto_divisao == 25 && g_resto_divisao > 11) || e_resto_divisao == 24)
            {
                e_resto_divisao += 1;
            }

            var n_lua_cheia = 44 - e_resto_divisao;
            if (n_lua_cheia < 21)
            {
                n_lua_cheia += 30;
            }

            var d_quociente_divisao = (((5 * y_ano) / 4) - (x_quociente + 10));
            n_lua_cheia += 7 - ((d_quociente_divisao + n_lua_cheia) % 7);

            DateTime pascoa;
            if (n_lua_cheia > 31)
            {
                pascoa = new DateTime(y_ano, 04, (n_lua_cheia - 31));
            }
            else
            {
                pascoa = new DateTime(y_ano, 03, n_lua_cheia);
            }

            return pascoa;
        }

        public static bool IsIndependenceDay(DateTime date)
        {
            if (date.Month == 09 && date.Day == 7) return true;

            return false;
        } //TODO: Daniela Nascimento

        public static bool IsChildrensDay(DateTime date)
        {
            if (date.Month == 10 && date.Day == 12) return true;
            return false;
        } //TODO: Daniela Nascimento

        public static bool IsAllSoulsDay(DateTime date)
        {
            if (date.Month == 11 && date.Day == 02) return true;
            return false;
        } //TODO: Daniela Nascimento

        public static bool IsRepublicProclamation(DateTime date)
        {
            if (date.Month == 11 && date.Day == 15) return true;
            return false;
        } //TODO: Daniela Nascimento

        public static bool IsBlackConsciousnessDay(DateTime date)
        {
            if (date.Month == 11 && date.Day == 20) return true;
            return false;
        } //TODO: Daniela Nascimento

        public static bool IsChristmasDay(DateTime date)
        {
            if (date.Month == 12 && date.Day == 25) return true;
            return false;
        } //TODO: Andre Falcao

        public static bool IsCarnaval(DateTime date)
        {
            var carnaval = CalculoCarnaval(date.Year);
            if (date == carnaval) return true;

            return false;
        } //TODO: Andre Falcao

        public static DateTime CalculoCarnaval(int year)
        {
            var pascoa = CalculoPascoa(year);
            var carnaval = pascoa.AddDays(-47);

            return carnaval;
        } //TODO: Andre Falcao

        public static bool IsCorpusChristi(DateTime date)
        {
            var pascoa = CalculoPascoa(date.Year);
            var corpusChristi = pascoa.AddDays(60); //TODO: Revisar esse codigo  pois temos duplicidade

            if (date == corpusChristi) return true;

            return false;
        } //TODO: Andre Falcao

        public static bool IsOptionalDate(DateTime date)
        {
            var preCarnaval = CalculoCarnaval(date.Year);
            preCarnaval = preCarnaval.AddDays(-1);

            if (date.Month == 12 && date.Day == 31) return true;
            if (date.Month == 12 && date.Day == 24) return true;
            if (preCarnaval == date) return true;

            return false;
        } //TODO: Andre Falcao
    }
}
