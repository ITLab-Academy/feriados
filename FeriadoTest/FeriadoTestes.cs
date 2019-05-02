using System;
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

            foreach (var item in newYears)
            {
                var result = Holidays.IsHoliday(item,false);

                Assert.AreEqual(true, result); 
            }
        }

        [TestMethod]
        public void AnoNovo_NOK()
        {
            var newYears = new List<DateTime>();

            newYears.Add(new DateTime(1980, 01, 11));
            newYears.Add(new DateTime(2019, 01, 3));
            newYears.Add(new DateTime(1971, 12, 31));
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

            foreach (var item in newYears)
            {
                var result = Holidays.IsHoliday(item, false);

                Assert.AreEqual(false, result);
            }
        }


        [TestMethod]
        public void AnoNovo_ComFacultativos_OK()
        {
            var newYearsOpt = new List<DateTime>();

            newYearsOpt.Add(new DateTime(1979, 12, 31)); 
            newYearsOpt.Add(new DateTime(1980, 01, 01)); 
            newYearsOpt.Add(new DateTime(2019, 12, 31)); 
            newYearsOpt.Add(new DateTime(2020, 01, 01)); 
            newYearsOpt.Add(new DateTime(1994, 12, 31)); 
            newYearsOpt.Add(new DateTime(1995, 01, 01)); 

            foreach (var item in newYearsOpt)
            {
                var result = Holidays.IsHoliday(item,true);

                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void AnoNovo_ComFacultativos_NOK()
        {
            var newYearsOpt = new List<DateTime>();

            newYearsOpt.Add(new DateTime(1999, 12, 29));
            newYearsOpt.Add(new DateTime(1996, 12, 02));
            newYearsOpt.Add(new DateTime(2025, 12, 29));
            newYearsOpt.Add(new DateTime(2042, 12, 02));
            newYearsOpt.Add(new DateTime(1993, 12, 29));

            foreach (var item in newYearsOpt)
            {
                var result = Holidays.IsHoliday(item, true);

                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Natal_ComFacultativos_OK()
        {
            var christmasOpt = new List<DateTime>(); 

            christmasOpt.Add(new DateTime(1999, 12, 24)); 
            christmasOpt.Add(new DateTime(1999, 12, 25)); 
            christmasOpt.Add(new DateTime(2025, 12, 24)); 
            christmasOpt.Add(new DateTime(2025, 12, 25)); 
            christmasOpt.Add(new DateTime(2030, 12, 24)); 
            christmasOpt.Add(new DateTime(2030, 12, 25));

            foreach (var item in christmasOpt)
            {
                var result = Holidays.IsHoliday(item, true);

                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Natal_ComFacultativos_NOK()
        {
            var christmasOpt = new List<DateTime>();

            christmasOpt.Add(new DateTime(1999, 12, 23)); 
            christmasOpt.Add(new DateTime(1999, 12, 26)); 
            christmasOpt.Add(new DateTime(2025, 12, 23)); 
            christmasOpt.Add(new DateTime(2025, 12, 26));
            christmasOpt.Add(new DateTime(2030, 12, 23)); 
            christmasOpt.Add(new DateTime(2030, 12, 26));  

            foreach (var item in christmasOpt)
            {
                var result = Holidays.IsHoliday(item, true);

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

            foreach (var item in birthdaySP)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in birthdaySP)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in independenceDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in independenceDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in childrensDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in childrensDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in allSoulsDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in allSoulsDay)
            {
                var result = Holidays.IsHoliday(item,false);

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
            
            foreach (var item in tiradentes)
            {
                var result = Holidays.IsHoliday(item,false);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void Tirandentes_NOK()
        {
            var tiradentes = new List<DateTime>();

            tiradentes.Add(new DateTime(1980, 04, 20));
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

            foreach (var item in tiradentes)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in WorkDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in WorkDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in revolutionDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in revolutionDay)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in goodFriday)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in goodFriday)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in republicProclamation)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in republicProclamation)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in blackConsciousness)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in blackConsciousness)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in christmas)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in christmas)
            {
                var result = Holidays.IsHoliday(item,false);

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

            foreach (var item in date)
            {
                var result = Holidays.CalculoPascoa(item.Year);
                Assert.AreEqual(item, result);
            }

        }

        [TestMethod]
        public void OptionalDate_OK()
        {
            var optionalDate = new List<DateTime>();

            optionalDate.Add(new DateTime(2018, 12, 31));
            optionalDate.Add(new DateTime(2018, 12, 24));
            optionalDate.Add(new DateTime(2040, 12, 24));
            optionalDate.Add(new DateTime(2040, 12, 31));
            optionalDate.Add(new DateTime(2019, 03, 05));
            optionalDate.Add(new DateTime(2020, 02, 25));

            foreach (var item in optionalDate)
            {
                var result = Holidays.IsHoliday(item, true);

                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void OptionalDate_NOK()
        {
            var optionalDate = new List<DateTime>();

            optionalDate.Add(new DateTime(2018, 12, 30));
            optionalDate.Add(new DateTime(2018, 12, 23));
            optionalDate.Add(new DateTime(2040, 12, 23));
            optionalDate.Add(new DateTime(2040, 12, 26));
            optionalDate.Add(new DateTime(2019, 03, 03));
            optionalDate.Add(new DateTime(2020, 02, 26));

            foreach (var item in optionalDate)
            {
                var result = Holidays.IsHoliday(item, true);

                Assert.AreEqual(false, result);
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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, false);

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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, false);

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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, true);

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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, true);

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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, false);

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

            foreach (var item in carnaval)

            {

                var result = Holidays.IsHoliday(item, false);

                Assert.AreEqual(false, result);

            }

        }

    }

}