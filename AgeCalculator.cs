using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Vickypedia.AgeCalc
{
    public class AgeCalculator : INotifyPropertyChanged
    {
        public AgeCalculator(DateTime birthDate, DateTime compareDate)
        {
            this.birthDate = birthDate;
            this.compareDate = compareDate;
            Recalc();
        }

        private DateTime birthDate;
        /// <summary>
        /// Get or sets the Birthdate of a person
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
                OnPropertyChanged("CompareDate");
                Recalc();
            }
        }


        private DateTime compareDate;
        public DateTime CompareDate
        {
            get
            {
                return compareDate;
            }
            set
            {
                compareDate = value;
                OnPropertyChanged("CompareDate");
                Recalc();
            }
        }

        public TimeSpan Age { get; private set; }

        public int Years
        {
            get
            {
                int years = ((int)Age.TotalDays) / 365;
                if (birthDate.AddYears(years) <= compareDate)
                    return years;
                else
                    return years - 1;
            }
        }

        public int Months
        {
            get
            {
                int m = compareDate.Month - birthDate.Month;
                return Years * 12 + m;
            }
        }

        public int Days
        {
            get
            {
                return Age.Days;
            }
        }

        public int Hours
        {
            get
            {
                return Days*24 + Age.Hours;
            }
        }

        public int Minutes
        {
            get
            {
                return Hours * 60 + Age.Minutes;
            }
        }

        public int Seconds
        {
            get
            {
                return Minutes * 60 + Age.Seconds;
            }
        }

        

        public string AgeString
        {
            get
            {
                return String.Format("<b>{0}</b> years or <b>{1}</b> months or <b>{2}</b> days or <b>{3}</b> hours  or <b>{4}</b> minutes  or <b>{5}</b> seconds", Years, Months, Days, Hours, Minutes, Seconds);
            }
        }

        public void Recalc()
        {
            this.Age = compareDate.Subtract(birthDate);

            if (Recalculated != null)
                Recalculated(this, EventArgs.Empty);
        }

        public event EventHandler Recalculated;
             

        #region INotifyPropertyChanged Members
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

    }
}
