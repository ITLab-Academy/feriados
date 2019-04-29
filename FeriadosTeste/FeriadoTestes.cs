﻿using System;
using System.Collections.Generic;
using FeriadoComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeriadosTeste
{
    [TestClass]
    public class FeriadoTestes
    {
        [TestMethod]
        public void AnoNovo_OK()
        {
            var newYears = new List<DateTime>();

            newYears.Add(new DateTime(1980, 01, 01));
            newYears.Add(new DateTime(2019, 01, 01));
            newYears.Add(new DateTime(2040, 01, 01));
            newYears.Add(new DateTime(1994, 01, 01));


            var holiday = new Holidays();

            foreach (var item in newYears)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void AnoNovo_NOK()
        {
            var newYears = new List<DateTime>();

            newYears.Add(new DateTime(1980, 01, 11));
            newYears.Add(new DateTime(2019, 01, 3));
            newYears.Add(new DateTime(2018, 12, 31));
            newYears.Add(new DateTime(2019, 01, 2));
            newYears.Add(new DateTime(2019, 02, 1));
            newYears.Add(new DateTime(2040, 01, 21));
            newYears.Add(new DateTime(1994, 01, 12));
            newYears.Add(new DateTime(2019, 03, 1));
            newYears.Add(new DateTime(2019, 04, 1));
            //newYears.Add(new DateTime(2019, 05, 1));
            newYears.Add(new DateTime(2019, 06, 1));
            newYears.Add(new DateTime(2019, 07, 1));
            newYears.Add(new DateTime(2019, 08, 1));
            newYears.Add(new DateTime(2019, 09, 1));
            newYears.Add(new DateTime(2019, 10, 1));
            newYears.Add(new DateTime(2019, 11, 1));
            newYears.Add(new DateTime(2019, 12, 1));

            var holiday = new Holidays();

            foreach (var item in newYears)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void SaoPauloBirthday_OK()
        {
            var birthdaySP = new List<DateTime>();

            birthdaySP.Add(new DateTime(1980, 01, 25));
            birthdaySP.Add(new DateTime(2019, 01, 25));
            birthdaySP.Add(new DateTime(2018, 01, 25));
            birthdaySP.Add(new DateTime(2019, 01, 25));
            birthdaySP.Add(new DateTime(2040, 01, 25));
            birthdaySP.Add(new DateTime(1994, 01, 25));


            var holiday = new Holidays();

            foreach (var item in birthdaySP)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void SaoPauloBirthday_NOK()
        {
            var birthdaySP = new List<DateTime>();

            birthdaySP.Add(new DateTime(1980, 01, 26));
            birthdaySP.Add(new DateTime(2019, 01, 24));
            birthdaySP.Add(new DateTime(2019, 02, 25));
            birthdaySP.Add(new DateTime(2040, 04, 25));
            birthdaySP.Add(new DateTime(1994, 05, 25));
            birthdaySP.Add(new DateTime(1994, 06, 25));
            birthdaySP.Add(new DateTime(1994, 07, 25));
            birthdaySP.Add(new DateTime(1994, 08, 25));
            birthdaySP.Add(new DateTime(1994, 09, 25));
            birthdaySP.Add(new DateTime(1994, 10, 25));
            birthdaySP.Add(new DateTime(1994, 11, 25));

            var holiday = new Holidays();

            foreach (var item in birthdaySP)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void IndependenceDay_OK()
        {
            var independenceDay = new List<DateTime>();

            independenceDay.Add(new DateTime(1980, 09, 07));
            independenceDay.Add(new DateTime(2018, 09, 07));
            independenceDay.Add(new DateTime(2040, 09, 07));
            independenceDay.Add(new DateTime(1994, 09, 07));
            independenceDay.Add(new DateTime(2019, 09, 07));


            var holiday = new Holidays();

            foreach (var item in independenceDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void IndependenceDay_NOK()
        {
            var independenceDay = new List<DateTime>();

            independenceDay.Add(new DateTime(1980, 09, 08));
            independenceDay.Add(new DateTime(2018, 09, 06));
            independenceDay.Add(new DateTime(2040, 09, 05));
            independenceDay.Add(new DateTime(1994, 09, 12));
            independenceDay.Add(new DateTime(2019, 10, 07));


            var holiday = new Holidays();

            foreach (var item in independenceDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void ChildrensDay_OK()
        {
            var childrensDay = new List<DateTime>();

            childrensDay.Add(new DateTime(1980, 10, 12));
            childrensDay.Add(new DateTime(2018, 10, 12));
            childrensDay.Add(new DateTime(2040, 10, 12));
            childrensDay.Add(new DateTime(1994, 10, 12));
            childrensDay.Add(new DateTime(2019, 10, 12));


            var holiday = new Holidays();

            foreach (var item in childrensDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void ChildrensDay_NOK()
        {
            var childrensDay = new List<DateTime>();

            childrensDay.Add(new DateTime(1980, 10, 11));
            childrensDay.Add(new DateTime(2018, 10, 13));
            childrensDay.Add(new DateTime(2040, 09, 12));
            childrensDay.Add(new DateTime(1994, 11, 12));


            var holiday = new Holidays();

            foreach (var item in childrensDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void AllSoulsDay_OK()
        {
            var allSoulsDay = new List<DateTime>();

            allSoulsDay.Add(new DateTime(1980, 11, 02));
            allSoulsDay.Add(new DateTime(2018, 11, 02));
            allSoulsDay.Add(new DateTime(2040, 11, 02));
            allSoulsDay.Add(new DateTime(1994, 11, 02));
            allSoulsDay.Add(new DateTime(2019, 11, 02));


            var holiday = new Holidays();

            foreach (var item in allSoulsDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void AllSoulsDay_NOK()
        {
            var allSoulsDay = new List<DateTime>();

            allSoulsDay.Add(new DateTime(1980, 11, 03));
            allSoulsDay.Add(new DateTime(2018, 11, 01));
            allSoulsDay.Add(new DateTime(2040, 11, 01));
            allSoulsDay.Add(new DateTime(1994, 12, 02));
            allSoulsDay.Add(new DateTime(2019, 10, 02));


            var holiday = new Holidays();

            foreach (var item in allSoulsDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }


        [TestMethod]
        public void Tirandentes_OK()
        {
            var tiradentes = new List<DateTime>();

            tiradentes.Add(new DateTime(1980, 04, 21));
            tiradentes.Add(new DateTime(2019, 04, 21));
            tiradentes.Add(new DateTime(2018, 04, 21));
            tiradentes.Add(new DateTime(2030, 04, 21));
            tiradentes.Add(new DateTime(2040, 04, 21));

            var holiday = new Holidays();

            foreach (var item in tiradentes)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void Tirandentes_NOK()
        {
            var tiradentes = new List<DateTime>();

            tiradentes.Add(new DateTime(1980, 04, 20));
            //tiradentes.Add(new DateTime(2019, 04, 19));
            tiradentes.Add(new DateTime(2018, 04, 23));
            tiradentes.Add(new DateTime(2030, 03, 21));
            tiradentes.Add(new DateTime(2040, 05, 21));
            tiradentes.Add(new DateTime(2040, 06, 21));
            tiradentes.Add(new DateTime(2040, 07, 21));
            tiradentes.Add(new DateTime(2040, 08, 21));
            tiradentes.Add(new DateTime(2040, 09, 21));
            tiradentes.Add(new DateTime(2040, 10, 21));
            tiradentes.Add(new DateTime(2040, 11, 21));
            tiradentes.Add(new DateTime(2040, 12, 21));

            var holiday = new Holidays();

            foreach (var item in tiradentes)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void WorDay_NOK()
        {
            var WorkDay = new List<DateTime>();

            WorkDay.Add(new DateTime(1980, 05, 02));
            WorkDay.Add(new DateTime(2019, 04, 01));
            WorkDay.Add(new DateTime(2030, 02, 01));
            WorkDay.Add(new DateTime(2040, 03, 01));
            WorkDay.Add(new DateTime(2040, 04, 30));
            WorkDay.Add(new DateTime(2040, 06, 01));
            WorkDay.Add(new DateTime(2040, 07, 01));
            WorkDay.Add(new DateTime(2040, 08, 01));
            WorkDay.Add(new DateTime(2040, 09, 01));
            WorkDay.Add(new DateTime(2040, 10, 01));
            WorkDay.Add(new DateTime(2040, 11, 01));
            WorkDay.Add(new DateTime(2040, 12, 01));

            var holiday = new Holidays();

            foreach (var item in WorkDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void WordDay_OK()
        {
            var WorkDay = new List<DateTime>();

            WorkDay.Add(new DateTime(1980, 05, 01));
            WorkDay.Add(new DateTime(2019, 05, 01));
            WorkDay.Add(new DateTime(2030, 05, 01));
            WorkDay.Add(new DateTime(2040, 05, 01));
            WorkDay.Add(new DateTime(1940, 05, 01));
            WorkDay.Add(new DateTime(2089, 05, 01));


            var holiday = new Holidays();

            foreach (var item in WorkDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }


        [TestMethod]
        public void RevolutionDay_NOK()
        {
            var revolutionDay = new List<DateTime>();

            revolutionDay.Add(new DateTime(1980, 07, 06));
            revolutionDay.Add(new DateTime(2019, 07, 08));
            revolutionDay.Add(new DateTime(2030, 07, 11));
            revolutionDay.Add(new DateTime(2040, 03, 09));
            revolutionDay.Add(new DateTime(2040, 04, 09));
            revolutionDay.Add(new DateTime(2040, 06, 09));
            revolutionDay.Add(new DateTime(2040, 08, 09));
            revolutionDay.Add(new DateTime(2040, 09, 09));
            revolutionDay.Add(new DateTime(2040, 10, 09));
            revolutionDay.Add(new DateTime(2040, 11, 09));
            revolutionDay.Add(new DateTime(2040, 12, 09));

            var holiday = new Holidays();

            foreach (var item in revolutionDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void RevolutionDay_OK()
        {
            var revolutionDay = new List<DateTime>();

            revolutionDay.Add(new DateTime(1980, 07, 09));
            revolutionDay.Add(new DateTime(2019, 07, 09));
            revolutionDay.Add(new DateTime(2030, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));
            revolutionDay.Add(new DateTime(2040, 07, 09));

            var holiday = new Holidays();

            foreach (var item in revolutionDay)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }
        [TestMethod]
        public void GoodFriday_OK()
        {
            var goodFriday = new List<DateTime>();

            goodFriday.Add(new DateTime(2019, 4, 19));
            goodFriday.Add(new DateTime(2020, 4, 10));
            goodFriday.Add(new DateTime(2021, 4, 2));
            goodFriday.Add(new DateTime(2022, 4, 15));
            goodFriday.Add(new DateTime(2023, 4, 7));
            goodFriday.Add(new DateTime(2024, 3, 29));
            goodFriday.Add(new DateTime(2025, 4, 18));
            goodFriday.Add(new DateTime(2026, 4, 3));
            goodFriday.Add(new DateTime(2027, 3, 26));
            goodFriday.Add(new DateTime(2028, 4, 14));
            goodFriday.Add(new DateTime(2029, 3, 30));

            var holiday = new Holidays();

            foreach (var item in goodFriday)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void GoodFriday_NOK()
        {
            var goodFriday = new List<DateTime>();

            goodFriday.Add(new DateTime(2019, 4, 18));
            goodFriday.Add(new DateTime(2019, 4, 20));
            goodFriday.Add(new DateTime(2020, 4, 11));
            goodFriday.Add(new DateTime(2021, 4, 3));
            goodFriday.Add(new DateTime(2022, 4, 16));
            goodFriday.Add(new DateTime(2023, 4, 6));
            goodFriday.Add(new DateTime(2024, 3, 30));
            goodFriday.Add(new DateTime(2025, 4, 17));
            goodFriday.Add(new DateTime(2026, 4, 2));
            goodFriday.Add(new DateTime(2027, 3, 25));
            goodFriday.Add(new DateTime(2028, 4, 15));
            goodFriday.Add(new DateTime(2029, 3, 29));

            var holiday = new Holidays();

            foreach (var item in goodFriday)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }


        [TestMethod]
        public void RepublicProclamation_OK()
        {
            var republicProclamation = new List<DateTime>();

            republicProclamation.Add(new DateTime(1980, 11, 15));
            republicProclamation.Add(new DateTime(2018, 11, 15));
            republicProclamation.Add(new DateTime(2040, 11, 15));
            republicProclamation.Add(new DateTime(1994, 11, 15));
            republicProclamation.Add(new DateTime(2019, 11, 15));


            var holiday = new Holidays();

            foreach (var item in republicProclamation)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }


        [TestMethod]
        public void RepublicProclamation_NOK()
        {
            var republicProclamation = new List<DateTime>();

            republicProclamation.Add(new DateTime(1980, 11, 16));
            republicProclamation.Add(new DateTime(2018, 11, 14));
            republicProclamation.Add(new DateTime(2040, 11, 17));
            republicProclamation.Add(new DateTime(1994, 10, 13));
            republicProclamation.Add(new DateTime(2019, 12, 15));


            var holiday = new Holidays();

            foreach (var item in republicProclamation)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }


        [TestMethod]
        public void BlackConsciousnessDay_OK()
        {
            var blackConsciousness = new List<DateTime>();

            blackConsciousness.Add(new DateTime(1980, 11, 20));
            blackConsciousness.Add(new DateTime(2018, 11, 20));
            blackConsciousness.Add(new DateTime(2040, 11, 20));
            blackConsciousness.Add(new DateTime(1994, 11, 20));
            blackConsciousness.Add(new DateTime(2019, 11, 20));


            var holiday = new Holidays();

            foreach (var item in blackConsciousness)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void BlackConsciousnessDay_NOK()
        {
            var blackConsciousness = new List<DateTime>();

            blackConsciousness.Add(new DateTime(1980, 11, 19));
            blackConsciousness.Add(new DateTime(2018, 11, 21));
            blackConsciousness.Add(new DateTime(2040, 11, 24));
            blackConsciousness.Add(new DateTime(1994, 11, 23));
            blackConsciousness.Add(new DateTime(2019, 11, 24));


            var holiday = new Holidays();

            foreach (var item in blackConsciousness)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void ChristmasDay_OK()
        {
            var christmas = new List<DateTime>();

            christmas.Add(new DateTime(1980, 12, 25));
            christmas.Add(new DateTime(2018, 12, 25));
            christmas.Add(new DateTime(2040, 12, 25));
            christmas.Add(new DateTime(1994, 12, 25));
            christmas.Add(new DateTime(2019, 12, 25));


            var holiday = new Holidays();

            foreach (var item in christmas)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void ChristmasDay_NOK()
        {
            var christmas = new List<DateTime>();

            christmas.Add(new DateTime(1980, 12, 26));
            christmas.Add(new DateTime(2018, 11, 23));
            christmas.Add(new DateTime(2040, 10, 24));
            christmas.Add(new DateTime(1994, 12, 22));
            christmas.Add(new DateTime(2019, 09, 25));


            var holiday = new Holidays();

            foreach (var item in christmas)
            {
                var result = holiday.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }

        }

        [TestMethod]
        public void Pascoa_OK()
        {
            List<DateTime> date = new List<DateTime>();

            date.Add(new DateTime(2006, 04, 16));
            date.Add(new DateTime(2019, 04, 21));
            date.Add(new DateTime(2020, 04, 12));
            date.Add(new DateTime(1980, 04, 06));
            date.Add(new DateTime(1986, 03, 30));

            var holiday = new Holidays();

            foreach (var item in date)
            {
                var result = holiday.CalculoPascoa(item.Year);
                Assert.AreEqual(item, result);
            }

        }

        [TestMethod]
        public void Pascoa_NOK()
        {
            List<DateTime> date = new List<DateTime>();

            date.Add(new DateTime(2006, 04, 15));
            date.Add(new DateTime(2019, 04, 22));
            date.Add(new DateTime(2020, 04, 11));
            date.Add(new DateTime(1980, 04, 07));
            date.Add(new DateTime(1986, 03, 29));

            var holiday = new Holidays();

            foreach (var item in date)
            {
                var result = holiday.CalculoPascoa(item.Year);
                Assert.AreNotEqual(item, result); //Correto?
            }

        }

        [TestMethod]
        public void Carnaval_OK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 02, 28));
            carnaval.Add(new DateTime(2019, 03, 05));
            carnaval.Add(new DateTime(2020, 02, 25));
            carnaval.Add(new DateTime(1980, 02, 19));
            carnaval.Add(new DateTime(1986, 02, 11));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, false);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]

        public void Carnaval_NOK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 02, 27));
            carnaval.Add(new DateTime(2019, 03, 04));
            carnaval.Add(new DateTime(2020, 02, 24));
            carnaval.Add(new DateTime(1980, 02, 18));
            carnaval.Add(new DateTime(1986, 02, 12));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, false);
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Carnaval_ComFacultativo_OK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 02, 28));
            carnaval.Add(new DateTime(2006, 02, 27));
            carnaval.Add(new DateTime(2019, 03, 05));
            carnaval.Add(new DateTime(2019, 03, 04));
            carnaval.Add(new DateTime(2020, 02, 25));
            carnaval.Add(new DateTime(2020, 02, 24));
            carnaval.Add(new DateTime(1980, 02, 19));
            carnaval.Add(new DateTime(1980, 02, 18));
            carnaval.Add(new DateTime(1986, 02, 11));
            carnaval.Add(new DateTime(1986, 02, 10));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, true);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]

        public void Carnaval_ComFacultativo_NOK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 02, 26));
            carnaval.Add(new DateTime(2019, 03, 03));
            carnaval.Add(new DateTime(2019, 03, 06));
            carnaval.Add(new DateTime(2020, 02, 23));
            carnaval.Add(new DateTime(2020, 02, 26));
            carnaval.Add(new DateTime(1980, 02, 17));
            carnaval.Add(new DateTime(1980, 02, 20));
            carnaval.Add(new DateTime(1986, 02, 12));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, true);
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void CorpusChristi_OK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 06, 15));
            carnaval.Add(new DateTime(2019, 06, 20));
            carnaval.Add(new DateTime(2020, 06, 11));
            carnaval.Add(new DateTime(1980, 06, 05));
            carnaval.Add(new DateTime(1986, 05, 29));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, false);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void CorpusChrist_NOK()
        {
            List<DateTime> carnaval = new List<DateTime>();

            carnaval.Add(new DateTime(2006, 06, 14));
            carnaval.Add(new DateTime(2019, 06, 21));
            carnaval.Add(new DateTime(2020, 06, 12));
            carnaval.Add(new DateTime(1980, 06, 04));
            carnaval.Add(new DateTime(1986, 05, 28));

            var holiday = new Holidays();

            foreach (var item in carnaval)
            {
                var result = holiday.IsHoliday(item, false);
                Assert.AreEqual(false, result);
            }
        }
    }
}
